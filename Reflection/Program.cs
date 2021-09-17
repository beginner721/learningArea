using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    //reflekşın attribute'larla beraber çalışınca anlamlıdır..
    ////Reflection
    //Reflection ile çalışma anında uygulama çalışırken
    //herhangi bir nesnenin hakkında bilgi toplayabiliriz
    //Bu toplanan bilgiye göre bu nesneyi istenilen zaman çalıştırabiliriz
    //-ÇALIŞMA ANINDA!-
    //Reflection PAHALIDIR!	 Gerçekten çalışma anında yapmamız gerekiyor ise kullanmalıyız


    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2,3);
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(3,4));

            var type = typeof(DortIslem);
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type,5,6); //Bunu yaparak çalışma anında New'lemeyi yapıyoruz, gelen tipe göre 
            //Console.WriteLine(dortIslem.Topla(4, 5)); //burası da 4,5 aldı
            //Console.WriteLine(dortIslem.Topla2()); //buradaki yukarıda bulunan 5,6 yı aldı

            var instance = Activator.CreateInstance(type, 6, 7);
            //topla2 ye ulaşmanın farklı yolu, Invoke çalıştırır varsa parametre yazılır paranteze
            //Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null));
            //tipin     metodu              çağırmak

            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2"); //gelişmiş versiyon, method info oluşturduk, instance ile olan bağımızı kaybediyoruz
            Console.WriteLine(methodInfo.Invoke(instance, null)  ); // instance olan bağımızı kaybettiğimiz için hangi instance onu burada belirtiyoruz
                                                                    //hangi instance 'ın Topla2'sini getirecek....

            Console.WriteLine("-----------------");
            var metodlar = type.GetMethods();//metodlara ulaşıyoruz
            foreach (var info in metodlar) 
            {
                Console.WriteLine("Metod adı: {0}",info.Name);
                foreach (var parameterInfo in info.GetParameters()) //parametrelerine ulaşıyoruz burada
                {
                    Console.WriteLine("Parametre: {0} ",parameterInfo.Name);
                }
                foreach (var attribute in info.GetCustomAttributes()) //varsa attribute'lere ulaşırız 
                {
                    Console.WriteLine("Attribute Name: {0}", attribute.GetType().Name);
                }
            }
            //çalışma anında dinamik instance üretiyoruz, çalışma esnasında newleniyor

            Console.ReadLine();
            
        }
        
    }
    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;
        public DortIslem(int sayi1, int sayi2) //buradaki ctor ile kullanıcıdan sayıları alıyoruz
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1,int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 +_sayi2;
        }
        [MetodName("Çarpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }


    }
    public class MetodNameAttribute : Attribute
    {
        public MetodNameAttribute(string name)
        {

        }
    }
}
