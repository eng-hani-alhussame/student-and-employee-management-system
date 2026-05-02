using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using People;
using Employment_Office;
namespace Management
    {
        public class Management : Employee
        {
            public Management() { }
            public Management(int Id, int Age, string Name, string Nationality, string Blood_type, string Gender, string Department, int Level)
                : base(Id, Age, Name, Nationality, Blood_type, Gender, Department, Level, "", "", 0, 0)
            {
            }

            public override void Salary_inc()
            {
                base.Salary_inc();
                Console.WriteLine("\n\t--- Financial Data ---");
                Console.WriteLine($"\tSalary: {Salary}");
                Console.WriteLine($"\tIncentive: {Incentive}");
                Console.WriteLine($"\tSalary after incentive: {Salary + Incentive}");
                Console.WriteLine("\t----------------------");
            }

            public override void getData_emp()
            {
                int num_students;
                Console.Write("Enter number of students: ");
                num_students = int.Parse(Console.ReadLine());

                for (int i = 0; i < num_students; i++)
                {
                    Console.Clear();
                    Console.WriteLine($"\n\t--- Enter data for student {i + 1} ---");

                    int id = i + 1;
                    Console.Write("Name: ");
                    string name = Console.ReadLine().ToUpper();
                    Console.Write("Age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Gender: ");
                    string gender = Console.ReadLine().ToUpper();
                    Console.Write("Nationality: ");
                    string nationality = Console.ReadLine().ToUpper();
                    Console.Write("Blood Type: ");
                    string blood = Console.ReadLine().ToUpper();
                    Console.Write("Department (CS / IT): ");
                    string dept = Console.ReadLine().ToUpper();
                    Console.Write("Level (1-4): ");
                    int level = int.Parse(Console.ReadLine());

                    Management m = new Management(id, age, name, nationality, blood, gender, dept, level);

                    Console.WriteLine("\n--- Entering Degrees ---");
                    m.input_degrees();

                    Console.WriteLine("\n--- Student Result ---");
                    m.output_degrees();

                    Console.WriteLine("\n--- Employee Financial Data ---");
                    m.Salary_inc();

                    Console.WriteLine("\nPress any key to continue to next student...");
                    Console.ReadKey();
                }

                Console.Clear();
                Console.WriteLine("\n\tAll students processed. Thank you!");
                Console.ReadKey();
            }
        }
    }

