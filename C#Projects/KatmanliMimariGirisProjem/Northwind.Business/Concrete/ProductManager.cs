using Northwind.DataAccess.Concrete;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.NHibernate;

namespace Northwind.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;
        private NhProductDal nhProductDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public ProductManager(NhProductDal nhProductDal)
        {
            this.nhProductDal = nhProductDal;
        }

        //Business Code
        //Javadaki Controller Katmani Gibi access ayarlari ve istek return iliskilerini belirliyoruz
        //EfProductDal _productDal = new EfProductDal();
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch (Exception e)
            {
                MessageBox.Show("Salt Okunur Degerler Silinemez");

            }
            
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();

        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public void Update(Product product)
        {


            _productDal.Update(product);
           
        }
    }
}
