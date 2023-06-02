using System;
using System.Windows.Forms;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;

namespace Northwind.WebFormsUI
{
    /*
     *S=Single Responsibilty Principle
     
     *O=Open-Closed Principle
     * This rule is about an inheritance. The principle is as follows:
    the class must be closed to modification and open to extension.
    New class functionality should be added to an existing class through
    inheritance, and not by modifying the existing one.
     
     *L=Liskov Substitution Principle
    This rule also applies to an inheritance. 
    It can be seen as a method of applying the open-closed principle.
    The rule explains how to properly override parent class methods. 
    The  Liskov substitution principle can be summarized as follows:
    If you have a function or class X using class A,
    then the replacement of class A by any of its subclasses should not break the function of X. 
     
     *I=Interface Segregation Principle
    The interface segregation principle is very simple: 
    you cannot overload a class and force it to 
    implement and execute functionality that it does not need.
     
     *D=Dependency Inversion Principle
    This principle is at the heart of dependency injection. 
    The principle of dependency inversion has different and 
    quite complex formulations, so let's try it in simple terms. 
    This principle states that: classes should depend on abstractions,
    not on specific implementations of those abstractions.
     */


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                _productService = new ProductManager(new EfProductDal());
                _categoryService = new CategoryManager(new EfCategoryDal());
        }


        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, System.EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryId.DataSource = _categoryService.GetAll();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryId";


            cbxCategoryIdUpdate.DataSource = _categoryService.GetAll();
            cbxCategoryIdUpdate.DisplayMember = "CategoryName";
            cbxCategoryIdUpdate.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {

                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));

            }
            catch (Exception exception)
            {

            }

        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);

            }
            else
            {

                LoadProducts();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                ProductName = tbxProductName2.Text,
                CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                QuantityPerUnit =tbxQuantityPerUnit.Text,
                UnitsInStock = Convert.ToInt16(tbxStock.Text)
            });
            MessageBox.Show("Product Saved.");
            LoadProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    ProductName = tbxProductNameUpdate.Text,
                    CategoryId = Convert.ToInt32(cbxCategoryIdUpdate.SelectedValue),
                    UnitsInStock = Convert.ToInt16(tbxUnitInStockUpdate.Text),
                    QuantityPerUnit = tbxQuantityPerUnitUpdate.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text)
                });
            MessageBox.Show("Urun Guncellendi");
            LoadProducts();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            if (row != null)
            {
                tbxProductNameUpdate.Text = row.Cells[1].Value.ToString();
                cbxCategoryIdUpdate.SelectedValue = row.Cells[2].Value;
                tbxUnitPriceUpdate.Text = row.Cells[3].Value.ToString();
                tbxQuantityPerUnitUpdate.Text = row.Cells[4].Value.ToString();
                tbxUnitInStockUpdate.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
                _productService.Delete(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                });
            MessageBox.Show("Urun Silindi");
            LoadProducts();
        }
    }
}
