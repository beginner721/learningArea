using System;

namespace inheritanceDIY
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person() { Ad = "Baran", Soyad = "Kurtbogan", TCno = "123123", Id = 1 };
            Person person2 = new Person() { Ad = "Mehmet", Soyad = "Yılmaz", TCno = "123123", Id = 2 };
            Person person3 = new Person() { Ad = "Can", Soyad = "Demir", TCno = "123123", Id = 3 };

            Device device1 = new Device();
            person3 = device1;
            device1.Ad = "Ali";
            device1.DeviceName = "iOS";



            SoftwareLanguage softwareLanguage = new SoftwareLanguage();

            Console.WriteLine(((Device)person3).DeviceName);

            PersonManager personManager = new PersonManager();
            personManager.Add(device1);

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCno { get; set; }

    }

    class Device : Person
    {
        public string DeviceName { get; set; }

    }

    class SoftwareLanguage : Person
    {
        public string SoftwareName { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.Ad + " kişi eklendi.");
        }
    }

}
