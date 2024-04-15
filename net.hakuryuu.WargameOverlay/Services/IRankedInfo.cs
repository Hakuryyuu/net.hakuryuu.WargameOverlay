using net.hakuryuu.RankedReportDataImporter.PremadeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.hakuryuu.WargameOverlay.Services
{
    public interface IRankedInfo
    {
        Task<ReportedPlayer> GetRankedReports(string eugenId);
    }
}
