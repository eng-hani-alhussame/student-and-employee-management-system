using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace People
{
    public abstract partial class Student : Human
    {
        internal double Average { get; set; }
        internal double Sum { get; set; }
        internal float Degree { get; set; }
        public int Level { get; set; }
        public string Department { get; set; }
        internal string Grade { get; set; }
        internal protected int Number_of_students { get; set; }
        int numperofsubject = 0;
        Stack<float> Grades { get; set; } = new Stack<float>();
        Stack<string> subject { get; set; } = new Stack<string>();
    }

    public abstract partial class Student
    {
        public Student() { }
        public Student(int Id, int Age, string Name, string Nationality, string Blood_type, string Gender, string Department, int Level)
            : base(Id, Age, Name, Nationality, Blood_type, Gender)
        {
            this.Department = Department;
            this.Level = Level;
        }

        public void input_degrees()
        {
            Sum = 0;
            Average = 0;
            int count = 2;
            string[] IT_CS = new string[0];
            if (Department == "it" || Department == "IT")
            {
                if (Level == 1)
                    IT_CS = new string[] { "Maths", "Computer", "English", "Arabic", "Information Technology" };
                else if (Level == 2)
                    IT_CS = new string[] { "Data Base", "OOP", "Data Structure", "Statistics", "Computer Ethics", "Computer Organization" };
                else if (Level == 3)
                    IT_CS = new string[] { "Algorithms Analysis", "INformation Security", "Software Engineering", "Web development", "Wireless and Mobile Communications" };
                else if (Level == 4)
                    IT_CS = new string[] { "Special Topics IT", "Network Security", "Dtat Science", "Cloud Computing", "Institutional Architecture" };
            }
            else if (Department == "cs" || Department == "CS")
            {
                if (Level == 1)
                    IT_CS = new string[] { "Maths", "Computer", "English", "Arabic", "Logic Design" };
                else if (Level == 2)
                    IT_CS = new string[] { "Data Base", "OOP", "Data Structure", "Statistics", "Computer Ethics", "Computer Architecture" };
                else if (Level == 3)
                    IT_CS = new string[] { "Algorithms Analysis", "Accounting Principles", "INformation Security", "Software Engineering", "Web development", "Arithmetic Theory" };
                else if (Level == 4)
                    IT_CS = new string[] { "Special Topics IT", "Network programming", "Dtat Science", "Wireless and Mobile Communications", "Smart Computing" };
            }

            for (int i = 0; i < IT_CS.Length; i++)
            {
                Console.Write($"Please Enter degree of {IT_CS[i]} subject( 0 - 100 ) : ");
                Degree = float.Parse(Console.ReadLine());

                if (Degree >= 0 && Degree <= 100)
                {
                    count = 2;
                    if (Degree >= 50)
                        Console.WriteLine("Pass");
                    else
                        Console.WriteLine("Fail");
                    Sum += Degree;
                    Grades.Push(Degree);
                    subject.Push(IT_CS[i]);
                    numperofsubject++;
                }
                else
                {
                    i--;
                    if (count == 0)
                    {
                        Console.WriteLine("Erorrs\n");
                        Sum += 0;
                        break;
                    }
                    Console.WriteLine("\nThe Degree is out of the range ( 0 -100 )");
                    Console.WriteLine($"you have {count--} attempt try again\n");
                }
            }
            Average = Sum / IT_CS.Length;
        }

        public void output_degrees()
        {
            Console.WriteLine("----------------------------");
            if (Average >= 90)
                Grade = "Excellent";
            else if (Average >= 80)
                Grade = "Very Good";
            else if (Average >= 70)
                Grade = "Good";
            else if (Average >= 60)
                Grade = "Accepted";
            else if (Average >= 50)
                Grade = "Weak";
            else
                Grade = "failur";

            while (numperofsubject != 0)
            {
                Console.WriteLine(subject.Pop() + " : " + Grades.Pop());
                numperofsubject--;
            }
            Console.WriteLine($"Sum is : {Sum}\nAverage is : {Average}\nGrade is : {Grade}");
            Console.WriteLine("----------------------------");
            Console.WriteLine("thanks, that's all information...");
            Console.WriteLine("PLEES Click on Next to go excpt for the financil data SALARE");
            Console.ReadKey();
        }

        public override void Data_Human()
        {
            base.Data_Human();
            Console.WriteLine($"Department : {Department} \nLevel : {Level}\nSum :{Sum}\nAverage :{Average} ");
            Console.WriteLine($"\n {Name}'s Degree of subject");
        }
    }
}