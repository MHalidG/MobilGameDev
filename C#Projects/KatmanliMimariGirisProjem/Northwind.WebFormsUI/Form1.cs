using System.Windows.Forms;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                _productService = new ProductManager(new EfProductDal());
        }


        IProductService _productService;
        private void Form1_Load(object sender, System.EventArgs e)
        {

            dgwProduct.DataSource = _productService.GetAll();
        }
    }
}
