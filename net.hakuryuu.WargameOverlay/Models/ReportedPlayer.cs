using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.hakuryuu.RankedReportDataImporter.PremadeModels
{
    public class ReportedPlayer
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int Elo { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime LastChanged { get; set; }
        public DateTime LastReport { get; set; }
        public DateTime LastRankedPlayed { get; set; }
        public Reports Reports { get; set; }
        public object Aliases { get; set; }
        public List<string> NameHistory { get; set; }
        public List<int> EloHistory { get; set; }
    }
}
