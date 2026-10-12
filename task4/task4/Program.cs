
using System;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Student student1 = new Student("Yasmeen", 22, 98);
            student1.DisplayInfo();

            Student student2 = new Student("Deya", 22, 88);
            student2.DisplayInfo();

            Student student3 = new Student("Nada", 24, 95);
            student3.DisplayInfo();

            Student student4 = new Student();
            student4.Name = "Fatima";
            student4.Age = 22;
            student4.Grade = 99;
            student4.DisplayInfo();
        }
    }
}

