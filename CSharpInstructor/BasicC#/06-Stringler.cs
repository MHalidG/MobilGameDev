using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class _06_Stringler
    {
        static void String(){

            string sehir = "Adana";
            string city = "Arnhem";

            Console.WriteLine(sehir[0]);

            Console.WriteLine("Stringler Char arraydir aslinda");

            Console.WriteLine(sehir + city);
            Console.WriteLine("{0} {1}",sehir,city);

            string cumle = "Benim Adim Name";

            var sayi=cumle.Length;
            var sayi1=cumle.Clone();

            cumle.EndsWith("d");//bool doner
            cumle.StartsWith("d");
            //Index Off=LastIndexOf
            //Substring
            //cumle.Insert(0,"Hello ,)
            //ToLower-ToUpper
            //Replace(" ", "-")  bosluk yerine tire yazdirdik
            //Remove(x,y) x Indexten itibaren y kadar ucuruyor

            Console.WriteLine(sayi);
        }
    }
}
