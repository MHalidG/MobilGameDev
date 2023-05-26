using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void ExceptionIntro()
        {


            try
            {
                string[] students = new string[3] { "Sungur", "Kose", "Selim" };

                students[3] = "Suleyman";
            }
            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine("Lan yannis yapiyon oglim");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine("Lan yannis yapiyon oglim");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
            }
            catch (Exception e)
            {

                Console.WriteLine("Lan yannis yapiyon oglim");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.InnerException);
            }
        }
    }
}
