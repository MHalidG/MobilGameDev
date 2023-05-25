using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Conditionals
    {

        static void Sartlar()
        {
            //If else
            var number = 10;
            if (number == 10 && number <= 250)
            {
                Console.WriteLine("Selam");
            }
            else if (number == 30 || number >= 250)
            { Console.WriteLine("Aselam"); }
            else
            {
                Console.WriteLine("Ne oluyor laaa");
            }

            //Single line if
            Console.WriteLine(number == 10 ? "number is 10" : "Number is not 10");

            switch (number)
            {
                case 10:
                    Console.WriteLine("number is 10");
                    break;

                case 30:
                    Console.WriteLine("number is 10");
                    break;

                default:
                    Console.WriteLine("Number Kac bilmiyom");
                    break;
            }

        }
        }
    }

