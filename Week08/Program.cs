using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            Person person = new Person("Tom",25);
            person.Talks();

            Student student = new Student("John", 19, "123456789A");
            student.Studies();
            student.Talks();

            DemosticStudent domestic = new DemosticStudent("Mary", 21, "123456789B");
                domestic.Talks();
        }
    }
}
