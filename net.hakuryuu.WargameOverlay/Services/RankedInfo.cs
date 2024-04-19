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
        private const string BASE_ADDRESS = "https://api.hakuryuu.net/";
        private readonly HttpClient _httpClient;
        public RankedInfo() 
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(BASE_ADDRESS)
            };
        }

        public async Task<ReportedPlayer> GetRankedReports(string eugenId)
        {
            var res = _httpClient.GetAsync($"rankedreport/{eugenId}").Result;

            if (res.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return new ReportedPlayer()
                {
                    Reports = new()
                };
            }

            var body = await res.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ReportedPlayer>(body);
        }
    }
}
