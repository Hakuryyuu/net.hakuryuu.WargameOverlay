using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Memory;
using Squalr.Engine.Utils.Extensions;
using System.DirectoryServices.ActiveDirectory;
using net.hakuryuu.WargameOverlay.Services;
using MaterialSkin.Controls;
using net.hakuryuu.WargameOverlay.Views;
using MaterialSkin;

namespace net.hakuryuu.WargameOverlay
{
    public partial class Form1 : MaterialForm
    {
        private readonly IDataReader _dataReader;
        private readonly Overlay _overlay;
        private string _rawData;
        public Form1(IDataReader dataReader, Overlay overlay)
        {
            InitializeComponent();
            timer1.Interval = Properties.Settings1.Default.RefreshRate;
            _dataReader = dataReader;
            _overlay = overlay;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbxRefreshRate.Text = timer1.Interval.ToString();
            SetTheme();
            GetData();
            _overlay.SetRawData(_rawData);
            _overlay.Show();
        }

        private void GetData()
        {
            try
            {
                _rawData = _dataReader.GetRawData().Result;
                _overlay.SetRawData(_rawData);
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message, "Error occured");
            }
        }

        private void SetTheme()
        {
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green500, MaterialSkin.Primary.Green600, MaterialSkin.Primary.Green200, MaterialSkin.Accent.Green700, MaterialSkin.TextShade.BLACK);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var converted = Int32.TryParse(tbxRefreshRate.Text, out var interval);

            if (!converted)
            {
                MaterialMessageBox.Show("You can only use Numbers", "Conversion Error");
                return;
            }

            timer1.Interval = interval;
            Properties.Settings1.Default.Save();
            tbxRefreshRate.Text = timer1.Interval.ToString();
        }
    }
}
