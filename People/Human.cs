using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public partial class Human
    {
        private static int id;
        private static int age;
        private static string name;
        private static string gender;
        private static string nationality;
        private static string blood_type;

        protected static int Id { get { return id; } set { id = value; } }
        protected static int Age { get { return age; } set { age = value; } }
        protected static string Name { get { return name; } set { name = value; } }
        protected static string Nationality { get { return nationality; } set { nationality = value; } }
        protected static string Blood_type { get { return blood_type; } set { blood_type = value; } }
        protected static string Gender { get { return gender; } set { gender = value; } }
    }

    public partial class Human
    {
        public Human() { }
        public Human(int Id, int Age, string Name, string Nationality, string Blood_type, string Gender)
        {
            Human.Id = Id;
            Human.Age = Age;
            Human.Name = Name;
            Human.Nationality = Nationality;
            Human.Blood_type = Blood_type;
            Human.Gender = Gender;
        }

        public virtual void Data_Human()
        {
            Console.Clear();
            Console.WriteLine($"\n\n\tInformation of student [{Id}]");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Id is: {Id}");
            Console.WriteLine($"Name is: {Name}");
            Console.WriteLine($"Age is: {Age}");
            Console.WriteLine($"Nationality is: {Nationality}");
            Console.WriteLine($"Blood type is: {Blood_type}");
            Console.WriteLine($"Gender is: {Gender}");
        }
    }
}
