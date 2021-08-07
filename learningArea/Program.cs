using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Memduh";
            person2 = person1; // artık p1 değişince p2 de değişecektir referans numaralarını eşitledik. Heap kısmında ref no çalıştı
            person1.FirstName = "Ayça";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCartNumber = "12345678";

            Employee employee = new Employee();
            employee.FirstName = "Mehmet";

            Person person3 = customer;
            Console.WriteLine(person3.FirstName);

            //Console.WriteLine(((Customer)person3).CreditCartNumber); //boxing yöntemiyle kredi kartı görüntüleme çünkü person içinde bu prop yok

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);



        }
        //PERSON customerın da employee nin de adresini tutabilir çünkü temel sınıflarıdır, ancak onlar PERSON'ın adresini tutamazlar !!

    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Customer : Person
    {
        public string CreditCartNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager //bu metod hem customer hem employee için sorunsuz çalışacaktır...
                        //diğer türlü her class için bir metod gerekecekti...
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
