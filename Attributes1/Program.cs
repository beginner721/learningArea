using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id=1, LastName="kurtbogan",Age=24, };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();

        }
    }

    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty] //aşağıda attribute' umuzu oluşturduk
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    class CustomerDal
    {
        [Obsolete("Dont' Use Add, instead use AddNew")] //bu kullanılınca altaki metodu kullanana uyarı verir, çünkü yenisi vardır. Hazır Attribute
        //parantez içine kullanan kişiyi uyarıcı yazı yazdık
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3}",customer.Id,customer.FirstName,customer.LastName,customer.Age);
        }
        public void AddNew(Customer customer) //yeni bir method yazarsak üstekini kullanmamaları için hazır attribute kullanırız
        {
            Console.WriteLine("{0},{1},{2},{3}", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    //Kullanırken Attribute kelimesini yazmaya gerek kalmaz
    //Attribute'lara parametre de yollanabilir 
    [AttributeUsage(AttributeTargets.Property)]//pipe ile birden fazla ekleyebiliriz | AttributeTargets.Field
    // virgül ile AllowMultiple =true eklersek targets'in yanına birden fazla kere aynı prop veya class için kullanabiliriz
    //atributlara da atribut eklenebilir. Target ile hedef oluşturulur AttributeTargets.Class dersek o attribute sadece classlarda kullanılır
    class RequiredPropertyAttribute :Attribute //Attribute ların sonuna Attribute yazılır ve Attribute sınıfından inherit edilmelidir
    {

    }
    [AttributeUsage(AttributeTargets.Class, AllowMultiple =true)] //birden fazla kullanabiliyoruz AllowMultiple 
    class ToTableAttribute : Attribute
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }
    
}
