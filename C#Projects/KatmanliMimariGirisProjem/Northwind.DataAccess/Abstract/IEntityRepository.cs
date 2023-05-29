using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities.Abstract;

namespace Northwind.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {//generic kisitlari koyduk
        List<T> GetAll(Expression <Func<T,bool>> filter=null);
        /*Kullanici nul verirse tumunu getircek filtre verirse
        Filtreleyip getirecek
        */





        T Get(Expression<Func<T, bool>> filter);
        //Urunu neye gore getirecegini belirtsin mutlaka


        void Add(T entity);

        void Delete(T entity);


        void Update(T entity);



    }
}
