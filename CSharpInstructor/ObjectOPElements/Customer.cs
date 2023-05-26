using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOPElements
{

    
    internal class Customer : IPerson, ICustomerDal
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

    class PersonManager {

        public void Add(IPerson person) { 
       // Customer da baska class da IPersonu Implemente eden her clas bu methodu kullanabilir

        }
    
    }

}
