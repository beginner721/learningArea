using System;

namespace oop3DIY
{
    class Program
    {
        static void Main(string[] args)
        {
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager);
        }
    }
}
