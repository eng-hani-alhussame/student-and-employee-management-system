
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using People;

namespace Employment_Office
{
    public abstract class Employee : Student
    {
        protected string Job_type { get; set; }
        protected string Scientific_degree { get; set; }
        protected int Salary { get; set; }
        protected float Incentive { get; set; }

        public Employee() { }
        public Employee(int Id, int Age, string Name, string Nationality, string Blood_type, string Gender, string Department, int Level,
                        string job_type, string scientific_degree, int salary, int incentive)
            : base(Id, Age, Name, Nationality, Blood_type, Gender, Department, Level)
        {
            Job_type = job_type;
            Scientific_degree = scientific_degree;
            Salary = salary;
            Incentive = incentive;
        }

        public virtual void Salary_inc()
        {
            Console.Write("\nEnter job type ( Teacher / Secretariat / Accountant / Manager / Programmer ) : ");
            Job_type = Console.ReadLine();

            Console.Write("Enter Scientific degree ( Bachelor / Master / Doctorate ) : ");
            Scientific_degree = Console.ReadLine();

            if (Job_type == "teacher" || Job_type == "Teacher")
                Salary = 80000;
            else if (Job_type == "secretariat" || Job_type == "Secretariat")
                Salary = 160000;
            else if (Job_type == "accountant" || Job_type == "Accountant")
                Salary = 120000;
            else if (Job_type == "manager" || Job_type == "Manager")
                Salary = 100000;
            else if (Job_type == "programmer" || Job_type == "Programmer")
                Salary = 190000;
            else Salary = 0;

            if (Scientific_degree == "bachelor" || Scientific_degree == "Bachelor")
                Incentive = Salary * 0.05f;
            else if (Scientific_degree == "master" || Scientific_degree == "Master")
                Incentive = Salary * 0.10f;
            else if (Scientific_degree == "doctorate" || Scientific_degree == "Doctorate")
                Incentive = Salary * 0.20f;
            else Incentive = 0;
        }

        public abstract void getData_emp();
    }
}


