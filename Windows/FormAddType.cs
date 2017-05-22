using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.BussinessLogic;

namespace Windows
{
    public partial class FormAddType : Form
    {
        public FormAddType()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog()
            {
                Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var img = pictureBox1.Image;
            var path = $@"{System.IO.Directory.GetCurrentDirectory()}\Logos\{textBox1.Text}.png";
            img.Save(path);
            var result = Server.AddType(new Web.Models.ProductType
            {
                Type = textBox1.Text,
                IsFood = checkBox1.Checked
            });

            MessageBox.Show(result, result, MessageBoxButtons.OK);
        }
    }
}
