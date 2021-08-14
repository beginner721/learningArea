using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            AMevzuat aMevzuat = new AMevzuat();
            //abstract classlar NEWlenemez
            //abstact classlar CTOR içerebilir, onu inherit eden sınıf newlenince CTOR çalışacaktır.
            //abstract classların CTOR'u protected olmalıdır, çünkü inherit edilen yerde çalışacaktır sadece.
            
        }
    }
    abstract class MevzuatBase
    {
        public abstract void Degerlendir(); //interface gibi imza olarak bırakılabilir OVERRIDE edilerek tekrar yazılır 
        public void Kaydet() //bu ortak operasyondur hepsinde bu geçerlidir.
        {
            Console.WriteLine("Kaydedildi");
        }

    }
    class AMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            throw new NotImplementedException();
        }
    }
    class CustomerManager
    {
        public void Add()
        {

        }
        public void Delete()
        {

        }
    }
}
