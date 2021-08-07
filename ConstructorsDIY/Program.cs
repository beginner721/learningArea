using System;

namespace ConstructorsDIY
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person {Id=1,FirstName="Yağmur",LastName="Kavak",Skills="None" };
            Person person2 = new Person(1,"Ahmet","Tan","Office Programları");

            Console.WriteLine(person1.FirstName);
            Console.WriteLine(person2.FirstName);//bunu görmemiz için ikinci ctorun düzenlenmesi gerekir 
        }
    }
    class Person
    {
        public Person()
        {

        }
        public Person(int id, string firstName, string lastName, string skills)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Skills = skills;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Skills { get; set; }
    }
}
