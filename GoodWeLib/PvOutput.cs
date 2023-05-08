using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodweLib
{
    public class PvOutput
    {
        private readonly HttpClient _client = new HttpClient();

        public async Task<string> Post(InverterTelemetry inverterStatus, string pvOutputSystemId, string pvOutputApikey, string pvOutputRequestUrl)
        {
            var values = new Dictionary<string, string>
            {
                { "d", inverterStatus.Timestamp.ToString("yyyyMMdd") },
                { "t", inverterStatus.Timestamp.ToString("HH:mm") },
                { "v1", (inverterStatus.EnergyLifetime*1000).ToString(CultureInfo.InvariantCulture) },
                { "c1", "1" /*Lifetime energy is cumulative*/},
                { "v2", inverterStatus.Power.ToString(CultureInfo.InvariantCulture) },
                { "v5", inverterStatus.Temperature.ToString(CultureInfo.InvariantCulture) },
                { "v6", inverterStatus.Vac1.ToString(CultureInfo.InvariantCulture) },
            };

            var content = new FormUrlEncodedContent(values);
            _client.DefaultRequestHeaders.Add("X-Pvoutput-Apikey", pvOutputApikey);
            _client.DefaultRequestHeaders.Add("X-Pvoutput-SystemId", pvOutputSystemId);
            var response = await _client.PostAsync(pvOutputRequestUrl, content);

            var responseString = await response.Content.ReadAsStringAsync();
            response.EnsureSuccessStatusCode();
            return responseString;
        }
    }
}
