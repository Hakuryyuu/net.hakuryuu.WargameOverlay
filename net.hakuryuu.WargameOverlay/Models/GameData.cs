using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.hakuryuu.WargameOverlay.Models
{
    public record GameData
    {
        public string IsNetworkMode { get; set; }
        public string Version { get; set; }
        public string GameMode { get; set; }
        public string Map { get; set; }
        public string NbMaxPlayer { get; set; }
        public string NbAI { get; set; }
        public string GameType { get; set; }
        public string Private { get; set; }
        public string InitMoney { get; set; }
        public string TimeLimit { get; set; }
        public string ScoreLimit { get; set; }
        public string ServerName { get; set; }
        public string VictoryCond { get; set; }
        public string NationConstraint { get; set; }
        public string ThematicConstraint { get; set; }
        public string DateConstraint { get; set; }
        public string IncomeRate { get; set; }
        public string AllowNbObs { get; set; }
        public string Seed { get; set; }
    }
}
