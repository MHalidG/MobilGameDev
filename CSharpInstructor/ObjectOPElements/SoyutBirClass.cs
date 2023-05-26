using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOPElements
{
    internal class SoyutBirClass
    {
    }

    abstract class DataB {
        //Abstract classtan da nesne uretilmez bu yonuyle interface benzer
        // Hem tamamlanmis hemde tamamlanmamis classlar kullanilabiliyor. bu yonuyle normal classa benziyor

        public void Add() {

            Console.WriteLine("Added");
        
        }

        public abstract void Delete();
    
    }

    class SqlServer : DataB
    {
        public override void Delete()
        {
            Console.WriteLine("SilerizSQL");
        }
    }
    class OracleServer : DataB
    {
        public override void Delete()
        {
            Console.WriteLine("SilerizORACLE");
        }
    }

}
