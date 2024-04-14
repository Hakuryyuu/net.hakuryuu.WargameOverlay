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
    public interface IDataExtractor
    {
        public int MatchesCount(string json);
        public GameData GetGameModel();
        public List<Player> GetPlayers();
    }
}
