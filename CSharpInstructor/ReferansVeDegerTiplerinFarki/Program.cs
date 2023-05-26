using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferansVeDegerTiplerinFarki
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number1 = 10;
            int number2 = 20;

            number2 = number1;

            number1 = 30;
            Console.WriteLine(number2);

            string[] cities1 = new string[] { "Istanbul", "Erzurum", "Canakkale" };//Referansi 101 Diyelim

            string[] cities2 = new string[] { "Augsburg", "Zwolle" };//Referansi 201

            //Yeni obje newlemek bellekteki en pahali islemdir

            //Asagidaki islemde 201 ref nolu cities2 arrayinin referansi 101 e esitlenmistir. Ortak referanslari var suan. 
            //Hangisinde degisiklik yaparsan yap ikisini de etkiler
            cities2 = cities1;

            cities1[0] = "Augsburg";
            cities1[1] = "Augsburg";
            cities1[2] = "Augsburg";

            Console.WriteLine(cities2[2]);
            Console.WriteLine(cities1[2]);

            cities1[2] = "Erzurum";

            Console.WriteLine(cities1[2]);
            Console.WriteLine(cities2[2]);

        }
    }
}
