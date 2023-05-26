using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class _04_Diziler
    {

        static void Add() {

            string student1 = "Engin";
            string student2 = "Derin";
            string student3 = "Salih";

            string[] students = new string[4];
            students[0] = "Engin";
            students[1] = "Enginimsi";
            students[2] = "Enginsi";
            students[3] = "Enginsin";

            foreach (string s in students)
            {
                Console.WriteLine(s);
            }

            string[] students1 = new[]{"Selam","Selami"};
            string[] students2 = {"Selam","Selami"};

            string[,] bolgeler = new string[7, 3]//7 satur 3 sutun
                {
                {"11","12","13"},
                {"21","22","23"},
                {"31","32","33"},
                {"41","42","43"},
                {"51","52","53"},
                {"61","62","63"},
                {"71","72","73"}
                };

            for (int i = 0; i<=bolgeler.GetUpperBound(0); i++)
            {
                for (int j = 0; j<=bolgeler.GetUpperBound(1); j++) {
                    Console.WriteLine(bolgeler[i, j]);
                }

                Console.WriteLine("*****");
            }






        }


    }
}
