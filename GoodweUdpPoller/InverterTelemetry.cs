using System;
using System.IO;
using System.Text.Json.Serialization;

namespace GoodweUdpPoller
{
    public class InverterTelemetry
    {
        /// <summary>
        /// Temperature in degrees Celsius
        /// </summary>
        public double Temperature { get; set; }

        public InverterStatus Status { get; set; }

        public double EnergyLifetime { get; set; }

        public double EnergyToday { get; set; }

        public double Power { get; set; }


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





        /// <summary>
        /// Timestamp of the telemetry according to the inverter, second precision.
        /// </summary>
        public DateTimeOffset Timestamp { get; set; }

        public string ResponseIp { get; set; }

        public static byte[] GoodweCrc(ReadOnlySpan<byte> payload)
        {
            var crc = 0xFFFF;
            bool odd;

            for (var i = 0; i < payload.Length; i++)
            {
                crc ^= payload[i];

                for (var j = 0; j < 8; j++)
                {
                    odd = (crc & 0x0001) != 0;
                    crc >>= 1;
                    if (odd)
                    {
                        crc ^= 0xA001;
                    }
                }
            }
            return BitConverter.GetBytes((ushort)crc);
        }

        public enum InverterStatus
        {
            Waiting,
            Normal,
            Error,
            Checking
        }
    }
}
