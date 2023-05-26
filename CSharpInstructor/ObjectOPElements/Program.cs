using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOPElements
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //SOLID,I=> Interface Segregation

            ICustomerDal[] customerDals = new ICustomerDal[2] {
            new SqlServerCustomerDal(),
            new OracleServerCustomerDal() 
            };

            foreach (var customerDal in customerDals) {
                customerDal.Add();
                //Ayni Interfaceten implement edilmis iki farkli klastan ayni methodu interfaces uzerinden cagirdik

            }

        }

       }

    class Database {

        public virtual void Delete()
        {
            //Override yapilacak methodlar Virtual yazilir. mi?
            /*Intefaceden farkli olarak classlarda methodlarin islevi de yazilir. Parenti Implemente eden her sinif, 
            methodu kendine yazsin istersek parenti interface yapariz. ToDo List gibi. Ama istisnasi olarak method uzerinde degisik
            likler olacaksa 
            */
            Console.WriteLine("DeletedByDefault");
        }
        public void Add()
        {

            Console.WriteLine("AddedByDefault");
        }



    }
}
