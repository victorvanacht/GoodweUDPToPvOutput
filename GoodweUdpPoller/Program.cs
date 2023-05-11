using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using GoodweLib;


namespace GoodweUdpPoller
{
    class Program
    {
        private static readonly HttpClient _client = new HttpClient();

        private static bool _verbatim;

        /// <summary>
        /// Tool for querying Goodwe inverters over the local network.
        /// Without options set, will try to discover any responding inverters on the network and display current telemetry for the last one.
        /// Intended use is to invoke in a cronjob every 5 minutes to update PVOutput.org, but can be adapted to other uses as it outputs json by default.
        /// </summary>
        /// <param name="host">IP address, hostname or subnet broadcast address of the inverter.
        /// If unset, will broadcast a discovery packet to find any compatible inverter.</param>
        /// <param name="timeout">Listen timeout for replies</param>
        /// <param name="pvoutputSystemId">System Id for API access on pvoutput.org, see https://pvoutput.org/help/api_specification.html </param>
        /// <param name="pvoutputApikey">API key for API access on pvoutput.org, see https://pvoutput.org/help/api_specification.html </param>
        /// <param name="pvoutputRequestUrl">optional url to post to</param>
        /// <param name="broadcastAddress">the address to send broadcasts to, for example 192.168.0.255 if that is your subnet</param>
        /// <param name="logfilename">the name of the local log file to which a log entry should be written</param>
        /// <param name="interval">interval in seconds between measurements. 0 means only 1 measurement</param>
        /// <param name="verbatim">if true, data elements will also be printed on screen</param>
        public static async Task Main(
            string host = null,
            int timeout = 1000,
            int pvoutputSystemId = 0,
            string pvoutputApikey = "",
            string pvoutputRequestUrl = "https://pvoutput.org/service/r2/addstatus.jsp",
            string broadcastAddress = "255.255.255.255",
            string logfilename = null,
            int interval = 0,
            bool verbatim = false)
        {
            _verbatim = verbatim;
            var listenTimeout = TimeSpan.FromMilliseconds(timeout);
            var poller = new GoodwePoller(listenTimeout);
            var pvOutput = new PvOutput();
            if (host == null)
            {
                if (_verbatim)
                {
                    Console.WriteLine("Discovering inverter...");
                }
                await foreach (var foundInverter in poller.DiscoverInvertersAsync(broadcastAddress))
                {
                    if (foundInverter.Ssid == null /*== not a Goodwe inverter*/)
                        continue;

                    WriteObject(foundInverter);
                    host = foundInverter.ResponseIp;
                }
            }

            if (host == null)
                throw new ArgumentException("No host given on command line and none discovered, nothing to do. Either make sure your router doesn't block broadcasts or discover the IP with, for example, the Goodwe app");
            if (pvoutputSystemId <= 0 ^ string.IsNullOrEmpty(pvoutputApikey))
                throw new ArgumentException("Both systemid and apikey need to be set to upload to pvoutput");

            if (interval != 0)
                Console.WriteLine("Press ESC to abort logging.");

            bool quit = false;
            do
            {
                if ((Console.KeyAvailable) && (Console.ReadKey(true).Key == ConsoleKey.Escape)) quit = true;

                int retries = 5; //maximum number of retries
                InverterTelemetry response = null;

                while (retries > 0)
                {
                    try
                    {
                        response = await poller.QueryInverter(host);
                        break;
                    }
                    catch
                    {
                        retries--;
                    }
                }

                if (response != null) // if we do have a response, log it to Pvout
                {
                    WriteObject(response);
                    if (pvoutputSystemId > 0)
                    {
                        string responseString = await pvOutput.Post(response, pvoutputSystemId.ToString(CultureInfo.InvariantCulture), pvoutputApikey, pvoutputRequestUrl);
                        Console.WriteLine($"<={responseString}");
                    }
                }
                else // if we do not have a response, make an empty reponse with the current time stamp, so that we can log it to file.
                {
                    response = new InverterTelemetry
                    {
                        Timestamp = DateTime.Now,
                        ResponseIp = host,
                        Status = InverterTelemetry.InverterStatus.Off
                    };
                }

                if (logfilename != null)
                    GoodweLib.FileLogger.WriteToFile(logfilename, response);

                if (interval != 0) Thread.Sleep(interval * 1000);

            } while ((interval != 0) && (quit == false));
        }

        private static void WriteObject(object toWrite)
        {
            if (_verbatim)
            {
                var serialized = JsonSerializer.Serialize(toWrite, new JsonSerializerOptions { WriteIndented = true });
                Console.WriteLine(serialized);
            }
        }
    }
}
