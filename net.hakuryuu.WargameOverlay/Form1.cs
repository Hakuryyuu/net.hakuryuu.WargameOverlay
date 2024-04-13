using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Memory;
using Squalr.Engine.Utils.Extensions;
using System.DirectoryServices.ActiveDirectory;
using net.hakuryuu.WargameOverlay.Services;
using MaterialSkin.Controls;

namespace net.hakuryuu.WargameOverlay
{
    public partial class Form1 : MaterialForm
    {
        private readonly IDataReader _dataReader;
        public Form1(IDataReader dataReader)
        {
            InitializeComponent();
            _dataReader = dataReader;
            //this.BackColor = Color.LimeGreen;
            //this.TransparencyKey = Color.LimeGreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                rtbResult.Text = _dataReader.GetRawData().Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.LimeGreen, e.ClipRectangle);
        }
    }
}
