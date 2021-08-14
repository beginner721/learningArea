using InterfaceAbstract.Entities;
using InterfaceAbstract.Abstract;
using InterfaceAbstract.Concrete;
using InterfaceAbstract.Adapter;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace InterfaceAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Customer customer = new Customer {FirstName="Memduh Baran",LastName="Kurtboğan",DateOfBirth=new System.DateTime(1997,5,21),Id=1,NationalityId="31265166910" };

            CustomerManager customerManager = new CustomerManager(new MernisServiceAdapter());
            customerManager.Register(customer);
            Console.ReadLine();
        }
    }
}
