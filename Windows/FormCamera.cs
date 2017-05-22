using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Web.BussinessLogic;
using Web.Models;

namespace Windows
{
    public partial class FormCamera : Form
    {
        public FormCamera()
        {
            InitializeComponent();
        }

        private FilterInfoCollection devices;
        private VideoCaptureDevice stream;
        public TransferProduct Product { get; private set; }
        private void Camera_Load(object sender, EventArgs e)
        {
            devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in devices)
                devicesComboBox.Items.Add(device.Name);
            devicesComboBox.SelectedIndex = 0;
        }

        private void devicesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stream = new VideoCaptureDevice(devices[devicesComboBox.SelectedIndex].MonikerString);
            stream.NewFrame += NewFrame;
            stream.Start();
        }

        private void NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Paint += PictureBox1_Paint;
        }

        private int couner = 0;
        private bool find = false;
        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (find)
                return;
            couner++;
            if (couner == 200)
            {
                couner = 0;                
                try
                {
                    var img = pictureBox1.Image;
                    EAN13Label.Text = Img.ReadEAN13(img);
                    pictureBox2.Image = img;
                    pictureBox2.Refresh();
                    find = true;
                }
                catch
                {
                }
            }

        }

        private void FormCamera_FormClosed(object sender, FormClosedEventArgs e) => stream.Stop();

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
            pictureBox2.Refresh();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Product = new TransferProduct
            {
                EAN13Image = (Bitmap)pictureBox2.Image,
                EAN13 = EAN13Label.Text
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            find = false;
            EAN13Label.Text = "";
            pictureBox2.Image = null;
        }
    }
}
