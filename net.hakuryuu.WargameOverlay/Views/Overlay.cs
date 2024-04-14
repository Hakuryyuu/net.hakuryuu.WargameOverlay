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
        private string _rawJson;
        public Overlay(IDataExtractor dataExtractor)
        {
            InitializeComponent();
            _dataExtractor = dataExtractor;
            this.TopMost = true;
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
        }

        public void SetRawData(string json)
        {
            _rawJson = json;
            _dataExtractor.MatchesCount(json);
            var res = _dataExtractor.GetPlayers();

            lblPlayer1.Text = res[0].PlayerName;
            lblReportsPlayer1.Text = "No Reports found";
            lblReportsPlayer1.ForeColor = Color.LimeGreen;
            if (res.Count == 2) // Sologame
            {
                lblPlayer2.Text = res[1].PlayerName;
            }
            else
            {
                lblPlayer2.Text = "F-5A PUFF The Magic Dragon";
                lblReportsPlayer2.Text = "hr:5";
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
    }
}
