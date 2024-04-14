using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.hakuryuu.WargameOverlay.Models
{
    public record Player
    {
        public string PlayerUserId { get; set; }
        public string PlayerElo { get; set; }
        public string PlayerRank { get; set; }
        public string PlayerLevel { get; set; }
        public string PlayerName { get; set; }
        public string PlayerTeamName { get; set; }
        public string PlayerAvatar { get; set; }
        public string PlayerIALevel { get; set; }
        public string PlayerReady { get; set; }
        public string PlayerDeckName { get; set; }
        public string PlayerDeckContent { get; set; }
        public string PlayerAlliance { get; set; }
        public string PlayerIsEnteredInLobby { get; set; }
        public string PlayerScoreLimit { get; set; }
        public string PlayerIncomeRate { get; set; }
    }
}
