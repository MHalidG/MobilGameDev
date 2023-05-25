using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class _05_Loops
    {

        static void Loops(){

            for(int i = 0; i < 5; i++) {

                Console.WriteLine(i);
            }

            int num1 = 20;
            while (num1 > 10)
            {
                Console.WriteLine(num1);
                num1--; }

            do { Console.WriteLine("Selam ben dunya yansa caliscam"); } while (num1 > 10);



            string[] students = { "Sungur", "Colt" };


            foreach (string s in students)
            {
                Console.WriteLine("Selam "+ s);
            }

            

        }


    }
}
