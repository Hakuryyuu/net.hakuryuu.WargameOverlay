using net.hakuryuu.WargameOverlay.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace net.hakuryuu.WargameOverlay.Services
{
    public class DataExtractor : IDataExtractor
    {
        private static readonly string pattern = "(?<=:)({.*?})";

        private static MatchCollection matches;

        public int MatchesCount(string json)
        {
            matches = Regex.Matches(json, pattern);
            return matches.Count;
        }


        public GameData GetGameModel()
        {
            var game = JsonConvert.DeserializeObject<GameData>(matches[0].Value);

            return game;
        }

        public List<Player> GetPlayers()
        {
            List<Player> players = new List<Player>();

            for (int i = 1; i < matches.Count; i++) // -1
            {
                if (matches[i].Value.StartsWith("{\""))
                {
                    var player = JsonConvert.DeserializeObject<Player>(matches[i].Value);
                    if (player != null)
                        players.Add(player);
                }
            }
            return players;
        }
    }
}
