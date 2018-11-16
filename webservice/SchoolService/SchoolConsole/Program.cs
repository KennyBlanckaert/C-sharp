using SchoolConsole.SchoolServiceReference;
using SchoolServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SchoolService_nowClient client = new SchoolService_nowClient();

            Teacher[] teachers = client.getTeachers();
            foreach(Teacher teacher in teachers)
            {
                Console.WriteLine(teacher.id + " : " + teacher.firstname + " " + teacher.firstname);
            }

            Console.ReadLine();
        }
    }
}
