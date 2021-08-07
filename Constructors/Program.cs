using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir class ilk kez çalışınca bir kez devreye girer ve bidaha çalışmaz ctor-
            Customer customer1 = new Customer {Id=1,FirstName="Baran",LastName="Kurtboğan",City="Batman" }; //bu kullanım için ilk ctor
            Customer customer2 = new Customer(2, "Memduh", "Yıldız", "Batman"); //bu kullanım için ise ikinci ctor çalışır
            //ctorlardan biri eksik olursa eksik olan customer kısmı çalışmaz, iki farklı kullanım için ctorlar yazdık

            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer1.FirstName);

        }
        static void Method(int id,string firstName, string lastName, string city)
        {

        }
    }
    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city) //default constructor, yazılsa da yazılmasa da arkaplanda ctor çalışacaktır.
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            //gelen değerleri alttaki proplarla eşleştirmiş olduk
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }

}
