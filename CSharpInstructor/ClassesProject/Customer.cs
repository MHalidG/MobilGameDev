using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProject
{
    internal class Customer
    {
        //Field
        //public string FirstName;   
        
       //Property (Getter Setter)
        public int Id { get; set; }


        string _firstName;
        public string Name { get { return "Mr." +_firstName; } set { _firstName = value; } }


        public string LastName { get; set; }
        public string City { get; set; }

    }
}
