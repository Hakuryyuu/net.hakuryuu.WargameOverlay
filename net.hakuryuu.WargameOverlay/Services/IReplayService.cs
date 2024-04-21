using net.hakuryuu.WargameOverlay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.hakuryuu.WargameOverlay.Services
{
    public interface IReplayService
    {
        /// <summary>
        /// Get all Replays as raw JSON
        /// </summary>
        /// <returns></returns>
        Task<List<string>> GetReplays();

        /// <summary>
        /// Get all the Replay Data formatted
        /// </summary>
        /// <returns></returns>
        Task<List<List<Player>>> GetReplayInfoFormatted();
    }
}
