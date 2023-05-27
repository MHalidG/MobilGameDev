using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETradeEntityFrw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _proDal=new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _proDal.Add(new Product{
            Name=tbxName.Text,
            UnitPrice=Convert.ToDecimal(tbxUnitPrice.Text),
            StockAmount=Convert.ToInt32(tbxStockAmount.Text)            
            });
            LoadProducts();
            MessageBox.Show("Added");
        }

        private void LoadProducts() {

            dgwProducts.DataSource = _proDal.GetAll();
        }

        


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _proDal.Update(new Product {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
            });
            LoadProducts();
            MessageBox.Show("Updated");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();

        }
        private void SearchProducts(string key)
        {

            dgwProducts.DataSource = _proDal.GetAll().Where(p=>p.Name.ToLower().Contains(key.ToLower())).ToList();
            //Veri tabanindan direk sorgu yapmadigimiz icin sql injection mumkun degil
            //Language Integrate Query-LinQ
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _proDal.Delete(new Product {

                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)
            
            });
            LoadProducts();
            MessageBox.Show("Deleted");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //_proDal.GetById(1002);
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }
    }
}
