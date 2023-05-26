using System;

namespace InterfacesPractice
{

    internal /*internal class bagli oldugu proje icinde referans ihtiyaci olmadan kullanabilirsiniz
        Classlarin defaultu Internaldir yazip yazmamaniz farketmez. Classlarda privatelik anca class icinde baska class
        olusuturuldugu zaman mumkun olabilmektedir.Hemen asagidaki NestedClass mesela
        Static Classlardan nesne uretilemez. Cunku statik Class tek nesnedir ve herkes tarafindan o kullanilir.
        Statik methodlar class ismiyle direk cagirilabilir
              */
   
    class Program
    {

        private class NestedClass
        { }
        /*Parenti olmayan classtan korkun
        Bir musteri loglama istiyor birisi istemiyor
         veya baska birisi texte istiyor Json formatta belki.
    */
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager(10);
            customerManager.Logger = new DataBaseLogger();//new FileLogger();// new SmsLogger
            customerManager.Add();


        }
    }


    class CustomerManager {
        //fieldlar
        private int _count;


        //Field tanimlanirken _ ile baslar ama Constructor parametresi olrak yazilirken duz yazilir

        
        public CustomerManager(int count)
        {
            _count = count;
        } 
        public ILogger Logger { get; set; }
        public void Add() {
            
            Logger.Log();
            Console.WriteLine("Customer Added!");
        }
    }

    class DataBaseLogger : ILogger {
        public void Log()
        { Console.WriteLine("Logged to DATABASE!");}  
    }


    class FileLogger : ILogger {
        public void Log() {Console.WriteLine("Logged to FILE!");}    
    }

     class SmsLogger : ILogger
    {
        public void Log() { Console.WriteLine("Logged to SMS!"); }
    }

    interface ILogger {
        void Log();
    }

}
