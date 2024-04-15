using net.hakuryuu.RankedReportDataImporter.PremadeModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.hakuryuu.WargameOverlay.Services
{
    public class RankedInfo : IRankedInfo
    {
        private readonly HttpClient _httpClient;
        public RankedInfo() 
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.hakuryuu.net")
            };
        }

        public async Task<ReportedPlayer> GetRankedReports(string eugenId)
        {
            var res = _httpClient.GetAsync($"RankedReports/{eugenId}").Result;

            //res.EnsureSuccessStatusCode();

            var body = await res.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ReportedPlayer>(body);
        }
    }
}
