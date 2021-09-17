using System;

namespace hahafunny
{
    class Program
    {
        static void Main(string[] args)
        {

            string Name = null;
            string sonuc = Name ?? "Boş bırakıldı"; //name NULL ise (??) sağdaki değeri yaz
            Console.WriteLine(sonuc);
        }
    }
}
