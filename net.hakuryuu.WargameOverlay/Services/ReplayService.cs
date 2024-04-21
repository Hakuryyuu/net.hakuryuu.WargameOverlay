using net.hakuryuu.WargameOverlay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.hakuryuu.WargameOverlay.Services
{
    public class ReplayService : IReplayService
    {

        private readonly IDataExtractor _extractor;

        private const string REPLAY_FOLDER_WINDOWS = "C:\\Users\\%username%\\Saved Games\\EugenSystems\\WarGame3";

        private List<string> replays = new();

        public ReplayService(IDataExtractor extractor)
        {
            _extractor = extractor;
        }

        public async Task<List<string>> GetReplays()
        {
            var replays = Directory.GetFiles(REPLAY_FOLDER_WINDOWS, ".wargamerpl2");

            // Only perform the reading operations if new Replays are added.
            if (replays.Length != this.replays.Count || this.replays.Count == 0)
            {
                for (int i = 0; i < replays.Length; i++)
                {
                    this.replays.Add(await File.ReadAllTextAsync(replays[i]));
                }
            }
            return this.replays;
        }

        public async Task<List<List<Player>>> GetReplayInfoFormatted()
        {
            var rawReplays = await GetReplays();
            var replayInfo = new List<List<Player>>();

            for (int i = 0; i < rawReplays.Count; i++)
            {
                _extractor.MatchesCount(rawReplays[i]);
                replayInfo.Add(_extractor.GetPlayers());
            }
            return replayInfo;
        }

    }
}
