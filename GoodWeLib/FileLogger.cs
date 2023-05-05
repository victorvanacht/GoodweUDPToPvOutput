using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static GoodweLib.InverterTelemetry;
using System.Globalization;

namespace GoodweLib
{
    public class FileLogger
    {
        public static void WriteToFile(string fileName, InverterTelemetry data)
        {
            if (!File.Exists(fileName))
            {
                // write header to .CSV file
                using (StreamWriter writer = new StreamWriter(fileName, false))
                {
                    writer.WriteLine("TimeStamp, IP, EnergyToday, EnergyLifetime, Power, Temperature, Status, Iac1, Vac1, Freq1, Iac2, Vac2, Freq2, Iac3, Vac3, Freq3, Ipv1, Vpv1, Ipv2, Vpv2");
                }
            }

            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                string line = "";
                line += data.Timestamp.ToString(CultureInfo.InvariantCulture) + ", ";
                line += data.ResponseIp.ToString(CultureInfo.InvariantCulture) + ", ";
                line += data.EnergyToday.ToString(CultureInfo.InvariantCulture) + ", ";
                line += data.EnergyLifetime.ToString(CultureInfo.InvariantCulture) + ", ";
                line += data.Power.ToString(CultureInfo.InvariantCulture) + ", ";
                line += data.Temperature.ToString(CultureInfo.InvariantCulture) + ", ";
                line += data.Status.ToString() + ", ";
                line += data.Iac1.ToString(CultureInfo.InvariantCulture) + ", ";
                line += data.Vac1.ToString(CultureInfo.InvariantCulture) + ", ";
                line += data.GridFrequency1.ToString(CultureInfo.InvariantCulture) + ", ";
                line += data.Iac2.ToString(CultureInfo.InvariantCulture) + ", ";
                line += data.Vac2.ToString(CultureInfo.InvariantCulture) + ", ";
                line += data.GridFrequency2.ToString(CultureInfo.InvariantCulture) + ", ";
                line += data.Iac3.ToString(CultureInfo.InvariantCulture) + ", ";
                line += data.Vac3.ToString(CultureInfo.InvariantCulture) + ", ";
                line += data.GridFrequency3.ToString(CultureInfo.InvariantCulture) + ", ";
                line += data.Ipv1.ToString(CultureInfo.InvariantCulture) + ", ";
                line += data.Vpv1.ToString(CultureInfo.InvariantCulture) + ", ";
                line += data.Ipv2.ToString(CultureInfo.InvariantCulture) + ", ";
                line += data.Vpv2.ToString(CultureInfo.InvariantCulture);
                writer.WriteLine(line);
            }
            return;
        }
    }
}
