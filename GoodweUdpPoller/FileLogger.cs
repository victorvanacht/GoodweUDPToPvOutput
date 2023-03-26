using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static GoodweUdpPoller.InverterTelemetry;
using System.Globalization;

namespace GoodweUdpPoller
{
    internal class FileLogger
    {
        public static void WriteToFile(string fileName, InverterTelemetry data)
        {
            if (!File.Exists(fileName))
            {
                // write header to .CSV file
                using (StreamWriter writer = new StreamWriter(fileName, false))
                {
                    writer.WriteLine("TimeStamp, IP, EnergyToday, EnergyLifetime, Power, Temperature, Status, Iac1, Vac1, Freq1, Iac2, Vac2, Freq2, Iac2, Vac2, Freq2, Ipv1, Vpv1, Ipv2, Vpv2");
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

/*
/// <summary>
/// Timestamp of the telemetry according to the inverter, second precision.
/// </summary>
public DateTimeOffset Timestamp { get; set; }

public string ResponseIp { get; set; }

public double EnergyToday { get; set; }


public double EnergyLifetime { get; set; }

public double Power { get; set; }

/// <summary>
/// Temperature in degrees Celsius
/// </summary>
public double Temperature { get; set; }

public InverterStatus Status { get; set; }




// phase 1 + 2 + 3

public double Iac1 { get; set; }

public double Vac1 { get; set; }

public double GridFrequency1 { get; set; }

public double Iac2 { get; set; }

public double Vac2 { get; set; }

public double GridFrequency2 { get; set; }

public double Iac3 { get; set; }

public double Vac3 { get; set; }

public double GridFrequency3 { get; set; }


/// <summary>
/// DC Current from the solar array 1, in A 
/// </summary>
public double Ipv1 { get; set; }

/// <summary>
/// DC Voltage from the solar array 1, in V
/// </summary>
public double Vpv1 { get; set; }


/// <summary>
/// DC Current from the solar array 2, in A 
/// </summary>
public double Ipv2 { get; set; }

/// <summary>
/// DC Voltage from the solar array 2, in V
/// </summary>
public double Vpv2 { get; set; }



public double TestA { get; set; }
public double TestB { get; set; }
public double TestC { get; set; }
public double TestD { get; set; }
public double TestE { get; set; }
public double TestF { get; set; }
public double TestG { get; set; }
public double TestH { get; set; }
public double TestI { get; set; }
public double TestJ { get; set; }
public double TestK { get; set; }
public double TestL { get; set; }
public double TestM { get; set; }
public double TestN { get; set; }

*/
