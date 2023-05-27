using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* DortIslem dortIslem=new DortIslem(2,3);
            Console.WriteLine(dortIslem.Topla(3, 4));
            Console.WriteLine(dortIslem.Topla2());*/

            var tip=typeof(DortIslem);
            //var dortIslem =Activator.CreateInstance(tip);//Runtime da bunu olusturuyorsun
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip);//Runtime da bunu olusturuyorsun parametresiz Const kullaniyor
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip,6,7);

            //Console.WriteLine(dortIslem.Topla(4, 5));
            //Console.WriteLine(dortIslem.Topla2());

           var instance=Activator.CreateInstance(tip, 6, 6);

            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");

            Console.WriteLine(methodInfo.Invoke(instance, null));

            var metodlar = tip.GetMethods();

            foreach (var info in metodlar) {
                Console.WriteLine("Method Adi : {0}",info.Name);
                foreach (var parametreInfo in info.GetParameters()) {
                Console.WriteLine("Parametre Adi : {0}",parametreInfo.Name);
                }
                    }

        }
    }

    public class DortIslem {

        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1,int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2; 

        }
        public DortIslem()
        {
            
        }

        public int Topla(int sayi1,int sayi2) {

            return sayi1 + sayi2;
        
        }

        public int Carp(int sayi1, int sayi2)
        {

            return sayi1 * sayi2;

        }


        public int Topla2()
        {

            return _sayi1 + _sayi2;

        }

        public int Carp2()
        {

            return _sayi1 * _sayi2;

        }



    }

}
