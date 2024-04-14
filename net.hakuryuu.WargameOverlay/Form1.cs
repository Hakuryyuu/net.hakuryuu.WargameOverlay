using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Memory;
using Squalr.Engine.Utils.Extensions;
using System.DirectoryServices.ActiveDirectory;
using net.hakuryuu.WargameOverlay.Services;
using MaterialSkin.Controls;
using net.hakuryuu.WargameOverlay.Views;

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
            _dataReader = dataReader;
            _overlay = overlay;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
                rtbResult.Text = _rawData;
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message,"Error occured");
            }
        }

        private void SetTheme()
        {
            this.SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            this.SkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green500, MaterialSkin.Primary.Green600, MaterialSkin.Primary.Green200, MaterialSkin.Accent.Green700, MaterialSkin.TextShade.BLACK);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
