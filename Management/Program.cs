using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Management System - Group Project";

            Console.WriteLine("\t\t=========================================");
            Console.WriteLine("\t\t|   WELCOME TO STUDENT & EMPLOYMENT    |");
            Console.WriteLine("\t\t|         MANAGEMENT SYSTEM            |");
            Console.WriteLine("\t\t=========================================");
            Console.WriteLine("\n\t\tGroup Members:");
            Console.WriteLine("\t\t- [Hani Ahmed Abdullah Muhammed]");
            Console.WriteLine("\t\t- [Sabri Muhammed Alhadaa]");
            Console.WriteLine("\t\t- [Abdualuhab Dubaa]");
            Console.WriteLine("\t\t- [Saad Abdualmajed Aldelaa]");
            Console.WriteLine("\t\t- [Aqeel Sead Wise]");
            Console.WriteLine("\t\t- [Abdualrhman Abdulaziz Gayee]");


            Console.WriteLine("\t\t...\n");
            Console.WriteLine("Press any key to clear old data and start...");
            Console.ReadKey();

            Console.Clear();

            Administrator admin = new Administrator();
            admin.getData_emp();

            Console.WriteLine("\n\n\tProgram ended. Press any key to exit.");
            Console.ReadKey();
        }
    }
}


