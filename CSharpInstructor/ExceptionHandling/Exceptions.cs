using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Exceptions
    {

        static void Main(string[] args) {



            /*
            try
            {
                Find();
            }
            catch (RecordNotFoundException exceptions)
            {
                Console.WriteLine(exceptions.Message);
                
            }


            HandleException(() => {
                Find();            
            });
            */

            Func<int, int, int> add = Topla;//Ilk iki int parametrelerdir son int return.
            add(3, 4);
            Console.WriteLine(add(3, 4));

            Func<int> getRandomNumber = delegate () { 
            Random rnd=new Random();
                return rnd.Next(1,100);
           };

            //Thread.Sleep(1000);
            Console.WriteLine(getRandomNumber());
            //Thread.Sleep(1000);
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            //Thread.Sleep(1000);
            Console.WriteLine(getRandomNumber());
            //Thread.Sleep(1000);
            Console.WriteLine(getRandomNumber2());

        }


        static int Topla(int x, int y) { 
        return x + y;
        }

        private static void HandleException(Action value) {
            //Void methodlar icin 
            try
            {value.Invoke();}
            catch (Exception e)
            { Console.WriteLine(e.Message);}
        }

        private static void Find() {


            List<string> students = new List<string> { "Sungur", "Layt", "Colt" };

            if (!students.Contains("Ahmet"))
            {

                throw new RecordNotFoundException("Record Not Found");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }

        }









        public class RecordNotFoundException : Exception {

            public RecordNotFoundException(string message):base(message)
            {
                    
            }

        }
    }
}
