using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Exceptions
    {

        static void Main(string[] args) {

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


        }

        private static void HandleException(Action value {
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
