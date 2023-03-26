using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace GoodweUdpPoller
{
    public class GoodwePoller
    {
        public TimeSpan ListenTimeout { get; }

        public GoodwePoller(TimeSpan listenTimeout)
        {
            ListenTimeout = listenTimeout;
        }

        public async IAsyncEnumerable<Inverter> DiscoverInvertersAsync(string broadcastAddress = "255.255.255.255")
        {
            using var channel = new UdpClient { EnableBroadcast = true };
            await SendHello(channel, broadcastAddress);

            var timeout = Task.Delay(ListenTimeout);
            while (true)
            {
                var greeting = RecieveGreetings(channel);
                var finishedTask = await Task.WhenAny(timeout, greeting);
                if (finishedTask == greeting)
                    yield return greeting.Result;
                else
                    yield break;
            }
        }

        private async Task SendHello(UdpClient client, string broadcastAddress)
        {
            var payload = Encoding.ASCII.GetBytes("WIFIKIT-214028-READ");
            await client.SendAsync(payload, payload.Length, broadcastAddress, 48899);
        }

        private async Task<Inverter> RecieveGreetings(UdpClient client)
        {
            var helloBack = await client.ReceiveAsync();
            return new Inverter
            {
                ResponseIp = helloBack.RemoteEndPoint.Address.ToString(),
                DiscoverData = helloBack.Buffer
            };
        }

        public async Task<InverterTelemetry> QueryInverter(string host)
        {
            using var client = new UdpClient();

            var payload = new byte[] { 0x7f, 0x03, 0x75, 0x94, 0x00, 0x49, 0xd5, 0xc2 };
            await client.SendAsync(payload, payload.Length, host, port: 8899);
            var result = await client.ReceiveAsync(ListenTimeout);
            var response = CreateTelemetryFrom(result.Buffer, result.RemoteEndPoint.Address.ToString());
            return response;
        }

        public static InverterTelemetry CreateTelemetryFrom(ReadOnlySpan<byte> data, string responseIp)
        {
            const int expectedLength = 153;
            if (data.Length != expectedLength)
                throw new InvalidDataException($"Got size {data.Length}, expected {expectedLength}");
            var header = data.Slice(0, 2);
            if (!header.SequenceEqual(new byte[] { 0xaa, 0x55 }))
            {
                throw new InvalidDataException($"Wrong header");
            }

            var receivedCrc = data.Slice(data.Length - 2);
            var payload = data.Slice(2, data.Length - 4);
            if (!receivedCrc.SequenceEqual(InverterTelemetry.GoodweCrc(payload)))
            {
                throw new InvalidDataException($"CRC mismatch");
            }

            return new InverterTelemetry
            {
                Timestamp = new DateTimeOffset(new DateTime(kind: DateTimeKind.Local,
                    year: data[5] + 2000, month: data[6], day: data[7],
                    hour: data[8], minute: data[9], second: data[10], millisecond: 0)),
                Vpv1 = data.To16BitScale10(11),
                Ipv1 = data.To16BitScale10(13),
                Vpv2 = data.To16BitScale10(15),
                Ipv2 = data.To16BitScale10(17),

                TestD = data.To16Bit(35), // 4017
                TestE = data.To16Bit(37), // 4047
                TestF = data.To16Bit(39), // 4027

                Vac1 = data.To16BitScale10(41),
                Vac2 = data.To16BitScale10(43),
                Vac3 = data.To16BitScale10(45),
                Iac1 = data.To16BitScale10(47),
                Iac2 = data.To16BitScale10(49),
                Iac3 = data.To16BitScale10(51),
                GridFrequency1 = data.To16BitScale100(53),
                GridFrequency2 = data.To16BitScale100(55),
                GridFrequency3 = data.To16BitScale100(57),

                //TestA = data.To16Bit(59), //0

                Power = data.To16Bit(61),

                Status = (InverterTelemetry.InverterStatus)data[63],

                //TestC = data.To16Bit(65), //0

                //TestH = data.To16Bit(67),  //0
                //TestH = data.To16Bit(69),  //0
                //TestI = data.To16Bit(71),  //0
                //TestH = data.To16Bit(73), //65535
                //TestA = data.To16Bit(75), //65535
                TestB = data.To16Bit(77), //65305

                //TestK = data.To16Bit(79), // 0
                //TestL = data.To16Bit(81), //0
                TestC = data.To16Bit(83), // 887
                //TestN = data.To16Bit(85), //65535
                
                Temperature = data.To16BitScale10(87),

                //TestH = data.To16Bit(89), // 65535
                //TestI = data.To16Bit(91), // 65535

                EnergyToday = data.To16BitScale10(93),
                EnergyLifetime = data.To32BitScale10(95),
                ResponseIp = responseIp
            };
        }
    }
}
