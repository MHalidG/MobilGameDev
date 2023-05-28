using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {

        public delegate void MyDelegate();
        public delegate void MyDelegate2(string text);
        
        public delegate int MyDelegate3(int sayi1,int sayi2);

        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Matematik matematik = new Matematik();
            //Delegate Donussuz ve parametresiz methodlari calistirabilir.

            //Delegate2 Donussuz ama string parametreli methodlari calistirabilir.

            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate();

            Console.WriteLine("--------");

            myDelegate-= customerManager.ShowAlert;
            myDelegate();


            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2=customerManager.ShowAlert2;
            MyDelegate3 myDelegate3 = matematik.Topla;
            var sonuc = myDelegate3(9, 9);
            Console.WriteLine(sonuc);
            myDelegate3 += matematik.Carp;
            var sonuc1 = myDelegate3(3, 3);//Return type olanlarda en son methodun donusu neyse onu cevirir

            Console.WriteLine(sonuc1);

        }

        class CustomerManager 
        {
            public void SendMessage() {
                Console.WriteLine("Hello");
            }
            public void ShowAlert() {
                Console.WriteLine("Be Careful Bro");
            }
            public void SendMessage2(string message)
            {
                Console.WriteLine("String Parametreli Void");
            }
            public void ShowAlert2(string message)
            {
                Console.WriteLine("String Parametreli Void");
            }

        }

        class Matematik {
            public int Topla(int sayi1, int sayi2) {
                return sayi1 + sayi2;
            } 
            public int Carp(int sayi1, int sayi2) {
                return sayi1 * sayi2;
            }
        }
    }
}
