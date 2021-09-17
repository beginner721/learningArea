using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//delegeler sıklıkla Action ve Func ile kullanılır yeni haliyle...
namespace Delegates
{
    public delegate void MyDelegate();  //ELÇİLİK
    public delegate void MyDelegate2(string text);  //parametreli void 
    public delegate int MyDelegate3(int number1,int number2); // iki int parametre isteyen ve int döndüren operasyonlar için

    //bu bir elçidir, bunun görevi herhangi bir dönüş değeri olmayan
    //void döndüren ve parametre almayan operasyonlara delegelik yapıyor.
    class Program
    {
        static void Main(string[] args)
        {
            Matematik matematik = new Matematik();
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage; //ELÇİLİK özel bir elçi gönderdi...
            myDelegate += customerManager.ShowAlert;
            myDelegate -= customerManager.SendMessage;

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;
            myDelegate2("mydelegate2 Hello");

            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp; //bunu ekleyince topla yerine çarpım yaptı ... yukarıdaki gibi ekstra ekleme yapılmadı
            //delegelerde return type var ise son verilen ne ise onu kullanır
            var result = myDelegate3(2,3);
            Console.WriteLine(result);

            myDelegate(); //çağırıldığında çalışacaktır ...

            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }
    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
