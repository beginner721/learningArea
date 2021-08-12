using System;
using System.Collections.Generic;
using System.Text;

namespace oop3DIY
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {
            krediManager.Hesapla();
        }
    }
}
