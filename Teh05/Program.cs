using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh05
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student
                {
                    Name = "Jesse McCree", StudentID = " K2898"
                },
                new Student
                {
                    Name = "Lúcio Correia dos Santos", StudentID = " K1977"
                },
                new Student
                {
                    Name = "Mei-Ling Zhou", StudentID = " K1432"
                },
                new Student
                {
                    Name = "Unknown", StudentID = " K1631"
                }
            };

            foreach (Student i in students)
                Console.WriteLine("Name:{0}, StudentID{1}", i.Name, i.StudentID);
        }
    }
}
