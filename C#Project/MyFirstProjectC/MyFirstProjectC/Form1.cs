using System;
using System.Linq;
using System.Windows.Forms;

namespace MyFirstProjectC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListCategories();
            ListProducts();
        }

        private void ListProducts()
        {
            using (var context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.ToList();
            }
        }

        private void ListProductsByCategory(int categoryId)
        {
            using (var context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.CategoryId == categoryId).ToList();
            }
        }

        private void ListProductsByProductName(string key)
        {
            using (var context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(key.ToLower()))
                    .ToList();
            }
        }

        private void ListCategories
            ()
        {
            using (var context = new NorthwindContext())
            {
                cbxCategory.DataSource = context.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryId";
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch (Exception exception)
            {
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            var key = tbxSearch.Text;
            if (string.IsNullOrEmpty(key))
                ListProducts();
            else
                ListProductsByProductName(tbxSearch.Text);
        }
    }
}