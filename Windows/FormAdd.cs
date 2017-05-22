using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Web.Models;
using Windows.BussinessLogic;

namespace Windows
{
    public partial class FormAdd : Form
    {

        List<ProductType> allTypes = Server.GetAllTypes();

        public FormAdd()
        {
            InitializeComponent();
        }
        public FormAdd(string EAN13)
        {
            InitializeComponent();
            EAN13TextBox.Text = EAN13;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                EAN13 = EAN13TextBox.Text,
                Manufacturer = manufacturerTextBox.Text,
                Name = nameTextBox.Text,
                Price = Convert.ToDouble(priceTextBox.Text),
                ShelfLifeInDays = Convert.ToInt32(ShelfLifeInDaysTextBox.Text),
                ProductTypeId = allTypes
                        .FirstOrDefault(pt => pt.Type == typeComboBox.SelectedItem.ToString())
                        .Id
            };

            var result = Server.AddProduct(product);
            MessageBox.Show(result, result, MessageBoxButtons.OK);
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            
            foreach (var type in allTypes)
            {
                typeComboBox.Items.Add(type.Type);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new FormAddType().ShowDialog();
        }
    }
}
