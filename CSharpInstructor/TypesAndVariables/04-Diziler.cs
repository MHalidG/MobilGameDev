using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class _04_Diziler
    {

        static void Main(string[] args) {

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
            






        }


    }
}
