using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {

        static void Variableler()
        {
            Console.WriteLine("HelloWorld");


            //C# Variables Type
            int number1 = 123;

            int number2 = 666;  //32 bit

            long lonumber = 9999999999999999; //64 bit

            short shortnumber = 32767; //16 bit

            byte bytenumber = 255;// 0-255 arasini tutar

            bool dogruMu = true;

            bool yanlisMi = false;

            char karakter = 'C';// inte cevirebiliyoruz asci kodunu ceviriyor (int)karakter

            double cift = 2345.7234;

            float ciftter = 123123123123123123234.321231f;

            string selamsiz = "Hello maraba";

            decimal ses1 = 15.60M; //decimal virgulden sonra 14den fazla rakam tutabiliyor
            
                var sessiz = "selami";
                var numberss = 20;
                var charrs = 'a';
                //Var ile atama yaptiktan sonra tip sinirlamasi yapmiyor istedigin baska tipe donusturebiliyorsun. Tip guvenligi yok.

              





            //  Console.WriteLine("Number1 is {0}", number2);



            //  Console.ReadLine();





        }
        enum Days
        {
            Monday, Sunday, Saturday, Huimidag
        }
    }
    }

