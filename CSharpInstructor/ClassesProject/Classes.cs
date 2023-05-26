using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProject
{
    internal class Classes
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            customer.Id = 1;
            customer.Name = "Test";

            Customer customer2 = new Customer
            {
                Id = 2,
                Name = "Halid",
                LastName = "Cihangir",
                City = "Unknown"
            };


            Console.WriteLine(customer2.Name);

        }



    }
}

