using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegatesFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = Topla; //parametreli func delegasyonu
            Console.WriteLine(add(3,5));

            Console.WriteLine(Topla(2,3)); //klasik gösterim, bunu func ile yazalım yukarıda

            Func<int> getRandomNumber = delegate () //tek int var demek ki parametresiz methoda delegasyon yapacak, int dönecek yalnızca
            {
                Random random = new Random();
                return random.Next(1, 100); //parametre yok 1 ila 100 arasında rastgele bir int sayı istiyoruz ve onu döndürüyor
            };

            Func<int> getRandomNumber2 = () => new Random().Next(1,100);//farklı bir yazım ile üsteki func 
            
            Console.WriteLine(getRandomNumber());
            Thread.Sleep(1000); //1000= 1 saniye bekletir, bir miktar bekleme olmazsa ikisi de aynı random sayıyı üretecektir
            Console.WriteLine(getRandomNumber2());

            Console.ReadLine();
        }
        static int Topla(int x, int y)
        {
            return x + y;
        }

    }
    

}
