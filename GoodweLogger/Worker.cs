using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public string broadcastAddress { set { this._broadcastAddress= value; } }
        public string PVOutputSystemID { set { this._PVOutputSystemID = value; } }
        public string PVOutputAPIKey { set { this._PVOutputAPIKey = value; } }
        public string PVOutputRequestURL { set { this._PVOutputRequestURL = value;} }
        public string logFilename { set { this._logFileName = value; } }
        public int logInterval { set { this._logInterval = value;} }

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

        private bool _hasFoundIPAddress;
        private GoodwePoller _poller;

        public Worker(GoodweLogger.MainForm form)
        {
            this.form = form;

            this.workerShouldClose = false;
            this.workerHasClosed = false;
            this.loggingEnabled = false;
            this._hasFoundIPAddress= false;

            this._poller = new GoodwePoller(TimeSpan.FromSeconds(3));


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
                    if (this._hasFoundIPAddress == false)
                    {
                        if (this._hostAddress.Equals(""))
                        {
                            WriteToLog("Discovering inverter...");
                            /*
                            await foreach (var foundInverter in poller.DiscoverInvertersAsync(broadcastAddress))
                            {
                                if (foundInverter.Ssid == null //== not a Goodwe inverter)
                                    continue;

                            WriteObject(foundInverter);
                            host = foundInverter.ResponseIp;
                            */
                        }
                    }
                }
                else
                {
                    this._hasFoundIPAddress = false;
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
    }
}
