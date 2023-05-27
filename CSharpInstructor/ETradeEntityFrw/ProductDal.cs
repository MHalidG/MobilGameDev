using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeEntityFrw
{
    public class ProductDal
    {
        public List<Product> GetAll() {
            //Asagida newlenen nesne bellek icin fazla agirdir
            //using ile kullaninca islev biter bitmez garbage collectore birakmadan nesneyi hafizadan atar.
            using (ETradeContext context = new ETradeContext())
            {
               return context.Products.ToList();//GetAll from Products Table islevi gorur
            }


        }

        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                 context.Products.Add(product);
/*Yukaridaki islemin asagida iki satirlik hali
                var entity = context.Entry(product);// Productu veritabanindakiyle esitle
                entity.State = EntityState.Added;
*/
                context.SaveChanges();
            }


        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                
                
                var entity=context.Entry(product);
                entity.State=EntityState.Modified;
                context.SaveChanges();
            }

        }


        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
              
                //context.Products.Remove(product);
               
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                

                context.SaveChanges();  
            }

        }





    }
}
