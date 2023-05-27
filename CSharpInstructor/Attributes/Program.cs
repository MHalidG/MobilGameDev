using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer=new Customer { Id=1,LastName="Dagdeviren",Age=32};
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);//method eski uyarisi aliyor
        }
    }

    [ToTable("Customers")]
    [ToTable("TblCustomers")]//Multiple Kullanim
    //Anotation lara benziyorlar
    class Customer { 
    
        public int Id { get; set; }
        [RequiredProperty]
        public string Name { get; set; }
        [RequiredProperty]

        public string LastName { get; set; }
        [RequiredProperty]

        public int Age { get; set; }

    }

    class CustomerDal {

        [Obsolete("Add kullanma onun yerine AddNew Kullan")]//Deprecated gibi.
        public void Add(Customer customer) {

            Console.WriteLine("{0},{1},{2},{3}", customer.Id, customer.Name, customer.LastName, customer.Age);
        
        }

        public void AddNew(Customer customer)
        {

            Console.WriteLine("{0},{1},{2},{3}", customer.Id, customer.Name, customer.LastName, customer.Age);

        }



    }
    //[AttributeUsage(AttributeTargets.Class)] //Sadece Classlarda kullan
    //[AttributeUsage(AttributeTargets.All)] Herseyeuygulanir
    //[AttributeUsage(AttributeTargets.Method)] Methodlara uygulanir
    //[AttributeUsage(AttributeTargets.Property|AttributeTargets.Method)]// Propertylere ve Methodlara uygulanir
    [AttributeUsage(AttributeTargets.Property,AllowMultiple=true)]//sadece Propertylere uygulanir Alt alta kullanilabilir mi
    class RequiredPropertyAttribute : Attribute { 
    
    }
    [AttributeUsage(AttributeTargets.Class,AllowMultiple = true)] 
    class ToTableAttribute : Attribute
    {

        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }

    }

    internal struct NewStruct
    {
        public object Item1;
        public object Item2;

        public NewStruct(object ıtem1, object ıtem2)
        {
            Item1 = ıtem1;
            Item2 = ıtem2;
        }

        public override bool Equals(object obj)
        {
            return obj is NewStruct other &&
                   EqualityComparer<object>.Default.Equals(Item1, other.Item1) &&
                   EqualityComparer<object>.Default.Equals(Item2, other.Item2);
        }

        public override int GetHashCode()
        {
            int hashCode = -1030903623;
            hashCode = hashCode * -1521134295 + EqualityComparer<object>.Default.GetHashCode(Item1);
            hashCode = hashCode * -1521134295 + EqualityComparer<object>.Default.GetHashCode(Item2);
            return hashCode;
        }

        public void Deconstruct(out object ıtem1, out object ıtem2)
        {
            ıtem1 = Item1;
            ıtem2 = Item2;
        }

        public static implicit operator (object, object)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((object, object) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }
}
