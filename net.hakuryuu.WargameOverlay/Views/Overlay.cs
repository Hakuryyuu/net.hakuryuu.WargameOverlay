using net.hakuryuu.RankedReportDataImporter.PremadeModels;
using net.hakuryuu.WargameOverlay.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace net.hakuryuu.WargameOverlay.Views
{
    public partial class Overlay : Form
    {
        private readonly IDataExtractor _dataExtractor;
        private readonly IRankedInfo _rankedInfo;

        public Overlay(IDataExtractor dataExtractor, IRankedInfo rankedInfo)
        {
            InitializeComponent();

            _dataExtractor = dataExtractor;
            _rankedInfo = rankedInfo;

            this.TopMost = true;
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
        }

        public void SetRawData(string json)
        {
            if (json != "404") // Only display if a game is running
            {
                _dataExtractor.MatchesCount(json);
                var res = _dataExtractor.GetPlayers();

                var player1 = _rankedInfo.GetRankedReports(res[0].PlayerUserId).Result;
                ReportedPlayer player2;
                if (res.Count > 1)
                {
                     player2 = _rankedInfo.GetRankedReports(res[1].PlayerUserId).Result;
                }
                else
                {
                    player2 = new();
                }

                

                lblReportsPlayer1.Visible = true;
                lblPlayer2.Visible = true;
                lblReportsPlayer2.Visible = true;

                var resPlayer1 = SetReports(ref player1);
                lblPlayer1.Text = res[0].PlayerName;
                lblReportsPlayer1.Text = resPlayer1.reports;
                lblReportsPlayer1.ForeColor = resPlayer1.color;

                if (res.Count > 1) // Sologame
                {
                    var resPlayer2 = SetReports(ref player2);
                    lblPlayer2.Text = res[1].PlayerName;
                    lblReportsPlayer2.Text = resPlayer2.reports;
                    lblReportsPlayer2.ForeColor = resPlayer2.color;
                }
                else
                {        
                    lblPlayer2.Text = "COMPUTER";
                    lblReportsPlayer2.Text = "AI Game";
                }
            }
            else
            {
                lblPlayer1.Text = "No Match found.";
                lblReportsPlayer1.Visible = false;
                lblPlayer2.Visible = false;
                lblReportsPlayer2.Visible = false;
            }
            
        }

        private void Overlay_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(scrn.Bounds.Right - this.Width, scrn.Bounds.Top);
                    return;
                }
            }
            

        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, e.ClipRectangle);
        }

        private (string reports, Color color) SetReports(ref ReportedPlayer player)
        {
            var str = String.Empty;
            if (player.Reports.hr == 0
                && player.Reports.hr == 0
                && player.Reports.hr == 0
                && player.Reports.hr == 0
                && player.Reports.hr == 0)
            {
                str = "No Reports found!";
                return (str, Color.LimeGreen);
            }
            else
            {
                str = $"hr:{player.Reports.hr} sr:{player.Reports.sr} tr:{player.Reports.tr} ohc:{player.Reports.ohc} mh:{player.Reports.mh}";
            }
            return (str, Color.Brown);
        }
    }
}
