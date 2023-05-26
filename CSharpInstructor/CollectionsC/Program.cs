using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsC
{
    internal class Program
    {
        private class Customer//nested class
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            //ArrayList();
            //List();
            //Dictionary<int,string> 
            //Dictionary<int,Customer> 
            
            ArrayList citiesList=new ArrayList();
            citiesList.Add("Istanbul");
            citiesList.Add("Corum");
            citiesList.Add("Zwolle");
            citiesList.Add(1);
            citiesList.Add('a');
            
            foreach (var city in citiesList) {
            
                Console.WriteLine(city);
            }
            

            List<string> cities = new List<string>();

            cities.Add("Ankara");
            //cities.Add(12);
            //cities.Add('a');

            List<Customer> kisiler=new List<Customer>();

            kisiler.Add(new Customer { Id = 1, Name = "Sungur" });
            kisiler.Add(new Customer { Id = 2, Name = "Colt" });

            foreach (var c in kisiler) {
                Console.WriteLine(c.Name);
            }

            var count = kisiler.Count;
            var customer = new Customer
            {
                Id=3,Name="Sungur"
            };

            kisiler.AddRange(//Customer Array veya Customer ekliyor listenin sonuna.
                new Customer[2] {
                new Customer{Id=9,Name="Sunguri"},
                new Customer{Id=6, Name="Cihangir" }
                });


            //kisiler.Clear();    //Butun listeyi temizler

            cities.Contains("Ankara");//Sehirlerin arasinda Ankara var mi?

            kisiler.IndexOf(customer);

            foreach (var kisi in kisiler) {
                Console.WriteLine(kisi.Id + " " + kisi.Name);
            
            }

            kisiler.Insert(0, customer);
            kisiler.Remove(customer);//Buldugu ilk costumeri siler ayni isimde baska varsa silmez.
            kisiler.RemoveAll(c=>c.Name=="Salih");// elemanlardan ismi Salih olanlari sil. Lambda expression



            Dictionary<int,string> sozluk= new Dictionary<int,string>();

            sozluk.Add(1,"Cihangir");
            sozluk.Add(2,"Malik");
            sozluk.Add(3,"Qira");

            Console.WriteLine(sozluk[1]);
            //Console.WriteLine(sozluk[4]);   exception

            foreach (var item in sozluk) {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);

            }
            sozluk.ContainsKey(1);
            sozluk.ContainsValue("Selamsiz");
                    }
    }


}
