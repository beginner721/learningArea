using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Baran";
            customer.LastName = "Kurtboğan";

            Customer customer2 = new Customer
            {
                Id = 2, City="Batman", LastName="Kurtboğan", FirstName="Memduh"
            };

            Console.WriteLine(customer2.FirstName);
        }
    }
}
