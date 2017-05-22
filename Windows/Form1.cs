using BarcodeLib.Barcode;
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
using Windows.BussinessLogic;

namespace Windows
{
    public partial class Form1 : Form
    {
        Web.Models.ProductType type;
        private TransferProduct product;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var product = Server.GetAllData(ean13TextBox.Text);
            if (product.Name == null)
            {
               var res =  MessageBox.Show("Додати", "Додати?", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)                
                    new FormAdd(ean13TextBox.Text).ShowDialog();
                else
                {
                    DrawQR(Color.Black, Color.Red);
                }
            }
            else
            {
                var types = Server.GetAllTypes();
                type = types.FirstOrDefault(t => t.Id == product.ProductTypeId);
                DrawQR(Color.Black, Color.Red);
                nameLabel.Text = product.Name;
                manufacturerLabel.Text = product.Manufacturer;
                priceLabel.Text = product.Price.ToString();
                ShelfDateLabel.Text = product.ShelfLifeInDays.ToString();
            }
        }

        private void DrawQR(Color backgroundColor, Color moduleColor)
        {
            try
            {
                QRCode barcode = Img.QRCodeInit(backgroundColor, moduleColor);
                barcode.Data = ean13TextBox.Text;

                var logoPath = $@"{System.IO.Directory.GetCurrentDirectory()}\Logos\{type.Type}.png";
                var QRWithLogo = new QRLogo(Image.FromFile(logoPath), barcode.drawBarcode());
                QRWithLogo.Add();
                QRPictureBox.Image = QRWithLogo.QRWithLogo;
            }
            catch
            {
                QRCode barcode = Img.QRCodeInit(backgroundColor, moduleColor);
                barcode.Data = ean13TextBox.Text;
                QRPictureBox.Image = barcode.drawBarcode();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
                moduleColorButton.BackColor = colorDialog1.Color;
        }

        private void backgruondColorButton_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
                backgruondColorButton.BackColor = colorDialog1.Color;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            DrawQR(backgruondColorButton.BackColor, moduleColorButton.BackColor);
        }

        double previousZoom = 1;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            var currentZoom = (double)trackBar1.Value / 100;
            var zoom = currentZoom / previousZoom;
            previousZoom = currentZoom;
            var lastImg = QRPictureBox.Image;

            QRPictureBox.Size = new Size(
                Convert.ToInt32(QRPictureBox.Width * zoom),
                Convert.ToInt32(QRPictureBox.Height * zoom)
                );
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog()
            {
                Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                EAN13PictureBox.Image = new Bitmap(open.FileName);
                try
                {
                    ean13TextBox.Text = Img.ReadEAN13(EAN13PictureBox.Image);
                }
                catch
                {
                    MessageBox.Show("Error, make new photo");
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var form = new FormCamera())
            {
                try
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        product = form.Product;
                        EAN13PictureBox.Image = product.EAN13Image;
                        if (product.EAN13.Length == 0)
                            try { ean13TextBox.Text = Img.ReadEAN13(product.EAN13Image); }
                            catch { MessageBox.Show("Error, make new photo"); }
                        else
                            ean13TextBox.Text = product.EAN13;
                    }
                }
                catch { }
            }
        }
    }
}
