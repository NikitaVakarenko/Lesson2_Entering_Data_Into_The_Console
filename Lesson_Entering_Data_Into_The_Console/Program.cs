using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_Entering_Data_Into_The_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entering_Data_Into_The_Console
            Console.Write("Enter your data:");
            string data = Console.ReadLine();
            Console.WriteLine($"Data:{data}");
            Console.ReadKey();
        }
    }
}
