using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Araclar dedigimiz bi class bu
            //Bunun icinde Generic bir method yazdik bu method liste olusturuyor. Ne turden gonderirsen gonder o turden olusturuyor.
            Utilities utilities=new Utilities();
            List<string> result = utilities.BuildList<string>("Erzurum", "Istanbul", "Canakkale");
            List<int> result1 = utilities.BuildList<int>(1, 2, 3);
            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { Name="Cihangir"}, new Customer { Name = "Malik" }, new Customer { Name = "Qira" });
           
            foreach (var item in result) { Console.WriteLine(item); }
            foreach (var item in result1) { Console.WriteLine(item); }
            foreach (var item in result2) { Console.WriteLine(item.Name); }

        }
    }

    class Utilities {

        public List<T> BuildList<T>(params T[] items) { 
        
            return new List<T>(items);

        }
    
    }


    interface IGenericConstrains<T> where T: class, IEntity ,new()

        {
    /*Generic Constrains: Generic kisitlari demek. 
    T objesini kisitlayabiliyoruz.Yanlislikla istemedigimiz bir Obje gonderilmemesi icin.
    where T: Yazilarak kisitlar siralanabilir
    yalniz class yazilinca referans tipleri kabul ediyor string de referans tiptir string de gireblilr bunu kisitlamak icin de
    new() yaziyoruz new yapilabilen nesneler yazilsin istiyoruz demek bu ve bu da stringi de eler yalnizca classlar gelir.
    IEntity yazarak da IEntity interfacesini implemente etmis olan claslardan obje kabul etmeli diyoruz.

    */
    }

    class Student : IEntity {


    }

    interface IEntity { 
    
    }



    interface IRepository<T>
    {//Adim 1. Generic Repository olusturduk<T> yerine ne verilirse onu isler

        List<T> GetAll();

        T Get(int id);

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);
    }



    interface ICustomerDal :IRepository<Customer>
    {//Adim 2:Customer Data acces layer icin interface olusturduk ve onu Generic IRepo interfacesinden implemente ettik.
     //Adim 3: Implementasyon yaparken<T>degerini Customer sinifi olarak belirledik
     //ADim 4: Methodlari Implemente ettik ve Customera gore duzenlenmis olarak geldi.
        List<Customer> GetAll();

        Product Get(int id);

        void Add(Customer customer);

        void Delete(Customer customer);

        void Update(Customer customer);

    }
    public class Customer
    {

       public string Name { get; set; }
       

    }

    class CustomerDal : ICustomerDal
    {/*Adim 5: Customer Data Acces Layer Classi olusturduk ve ICustomerDaldan implemente ettik. Sonuc asagidadir*/

        void ICustomerDal.Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        void IRepository<Customer>.Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        void ICustomerDal.Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        void IRepository<Customer>.Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        Product ICustomerDal.Get(int id)
        {
            throw new NotImplementedException();
        }

        Customer IRepository<Customer>.Get(int id)
        {
            throw new NotImplementedException();
        }

        List<Customer> ICustomerDal.GetAll()
        {
            throw new NotImplementedException();
        }

        List<Customer> IRepository<Customer>.GetAll()
        {
            throw new NotImplementedException();
        }

        void ICustomerDal.Update(Customer customer)
        {
            throw new NotImplementedException();
        }

        void IRepository<Customer>.Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }





    interface IProductDal : IRepository<Product>
    {

        List<Product> GetAll();

        Product Get(int id);

        void Add(Product product);

        void Delete(Product product);

        void Update(Product product);
    
    }

    internal class Product
    {
    }

    class ProductDal : IProductDal
    {
        void IProductDal.Add(Product product)
        {
            throw new NotImplementedException();
        }

        void IRepository<Product>.Add(Product entity)
        {
            throw new NotImplementedException();
        }

        void IProductDal.Delete(Product product)
        {
            throw new NotImplementedException();
        }

        void IRepository<Product>.Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        Product IProductDal.Get(int id)
        {
            throw new NotImplementedException();
        }

        Product IRepository<Product>.Get(int id)
        {
            throw new NotImplementedException();
        }

        List<Product> IProductDal.GetAll()
        {
            throw new NotImplementedException();
        }

        List<Product> IRepository<Product>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IProductDal.Update(Product product)
        {
            throw new NotImplementedException();
        }

        void IRepository<Product>.Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    


}
