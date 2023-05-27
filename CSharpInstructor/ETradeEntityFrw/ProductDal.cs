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

        //IMPORTANT NOTICE
        public List<Product> GetByName(string key)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p=>p.Name.Contains(key)).ToList();//GetAll from Products Table islevi gorur
            //DIREK VERI TABANINA SORGU ATILIRKEN SON KULLANICIDAN ALINAN DEGER DIREK DATABASEDE SORULURSA SQL INJECT MUMKUN.
            //Fakat ikinci bir liste olusturmadan direk dbden veri cektigimiz icin daha hizli ve masrafsiz.
           //Koleksiyona atama yapilip onun ustune filtreleme yapilirsa Kucuk buyuk harf duyarliligi vardir. C# duyarli.
           //Dbden sorgu yapilirken buyuk kuck harf duyarsizdir. Onlem aliyoruz
            
            }


        }


        public List<Product> GetByUnitPrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice>=price).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal min,decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min&& p.UnitPrice<=max).ToList();
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


        public Product GetById(int id)
        {

            using (ETradeContext context = new ETradeContext())
            {
                var result= context.Products.FirstOrDefault(p => p.Id == id);//Ya veriyi ya nullu donduruyor sadece ilk buldugunu getiriyor
                //var result= context.Products.SingleOrDefault(p => p.Id == id);//Ayni datadan ikitane varsa Throw exception. Tekse donuyor
                return result;
            
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
