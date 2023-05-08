﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using GoodweLib;

namespace GoodweLogger
{
    internal class Worker
    {
        public volatile bool workerShouldClose;
        public volatile bool workerHasClosed;

        public bool loggingEnabled { set { this._loggingEnabled = value; } }
        public string hostAddress { set { this._hostAddress = value; } }
        public string broadcastAddress { set { this._broadcastAddress = value; } }
        public string PVOutputSystemID { set { this._PVOutputSystemID = value; } }
        public string PVOutputAPIKey { set { this._PVOutputAPIKey = value; } }
        public string PVOutputRequestURL { set { this._PVOutputRequestURL = value; } }
        public string logFilename { set { this._logFileName = value; } }
        public int logInterval { set { this._logInterval = value; } }

        private Thread workerThread;
        private GoodweLogger.MainForm form;

        private volatile bool _loggingEnabled;
        private volatile string _hostAddress;
        private volatile string _broadcastAddress;
        private volatile string _PVOutputSystemID;
        private volatile string _PVOutputAPIKey;
        private volatile string _PVOutputRequestURL;
        private volatile string _logFileName;
        private volatile int _logInterval;

        private bool discoveryComplete;
        private GoodwePoller poller;
        private string hostIPaddress;

        public Worker(GoodweLogger.MainForm form)
        {
            this.form = form;

            this.workerShouldClose = false;
            this.workerHasClosed = false;
            this.loggingEnabled = false;
            this.discoveryComplete = false;

            this.poller = new GoodwePoller(TimeSpan.FromSeconds(3));


            this.workerThread = new Thread(WorkerThread);
            this.workerThread.IsBackground = true;
            this.workerThread.Start();
        }


        // returns true if closed successfully
        public bool Close(int maximumWaitingSeconds)
        {
            this.workerShouldClose = true;
            DateTime t0 = DateTime.Now;
            while ((this.workerHasClosed == false) && (DateTime.Now - t0).TotalSeconds < maximumWaitingSeconds)
            {
                Thread.Sleep(10);
            }
            return this.workerHasClosed;
        }


        private void WorkerThread()
        {
            while (workerShouldClose == false)
            {
                if (_loggingEnabled == true)
                {
                    if (this.discoveryComplete == false)
                    {
                        if (this._hostAddress.Equals(""))
                        {
                            WriteToLog("Discovering inverter...");
                            this.hostIPaddress = DiscoverInverters().Result;
                            if (this.hostIPaddress.Equals("")) WriteErrorToLog("No Goodwe inverters found");
                        }
                        else
                        {
                            this.hostIPaddress = this._hostAddress; //@@@ TODO: we may want to find the IP adress via DNS-lookup or something.
                        }
                        this.discoveryComplete = true;
                    }

                    InverterTelemetry telemetry = null;
                    if (!this.hostIPaddress.Equals(""))
                    {
                        telemetry = ReadTelemetry().Result;
                    }

                    if (telemetry != null)
                    {
                        string? serialized = JsonSerializer.Serialize(telemetry, new JsonSerializerOptions { WriteIndented = true });
                        WriteToLog(serialized);
                    }
                }
                else
                {
                    this.discoveryComplete = false;
                }
                Thread.Sleep(1);
            }
            workerHasClosed = true;
        }

        private void SetProgressBar(int progress)
        {
            //this.form.SetProgress(progress);
        }

        private void WriteToLog(string text)
        {
            this.form.WriteToLog(text);
        }

        private void WriteErrorToLog(string text)
        {
            this.WriteToLog("ERROR - " + text);
        }

        private async Task<string> DiscoverInverters()
        {
            string host = "";
            await foreach (var foundInverter in poller.DiscoverInvertersAsync(_broadcastAddress))
            {
                if (foundInverter.Ssid == null /*== not a Goodwe inverter*/)
                    continue;

                WriteToLog(foundInverter.Ssid + " @ " + foundInverter.ResponseIp);
                host = foundInverter.ResponseIp;
            }
            return host;
        }

        private async Task<InverterTelemetry> ReadTelemetry()
        {
            int retries = 5; //maximum number of retries
            InverterTelemetry response = null;

            while (retries > 0)
            {
                try
                {
                    response = await poller.QueryInverter(hostIPaddress);
                    return response;
                }
                catch
                {
                    retries--;
                }
            }
            return response;
        }
    }
}
