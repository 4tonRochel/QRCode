using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using System.IO;

namespace QRCode_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection)
                cbxCam.Items.Add(Device.Name);
            cbxCam.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cbxCam.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
            lblcam.Visible = false;
        }

        private void CaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pbxQR.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbxQR.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pbxQR.Image);

                if (result != null)
                {
                    StreamWriter Decode;
                    Decode = File.AppendText("File Information.txt");
                    Decode.WriteLine("INFORMATION");
                    Decode.WriteLine(" ");
                    Decode.WriteLine(result.Text);
                    Decode.WriteLine("Date:" + " " + DateTime.Now.ToString("MM/dd/yyyy"));
                    Decode.WriteLine("Time:" + " " + DateTime.Now.ToString("h:mm:ss tt"));
                    Decode.WriteLine(" ");
                    Decode.Close();
                    MessageBox.Show("Saved!");
                }
            }
        }

        private void pbxQR_Click(object sender, EventArgs e)
        {

        }
    }
}
