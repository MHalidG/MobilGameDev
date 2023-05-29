using Northwind.DataAccess.Concrete;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
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
        public List<Product> GetAll()
        {
            return _productDal.GetAll();

        }
    }
}
