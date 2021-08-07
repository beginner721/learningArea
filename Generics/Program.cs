using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Afyon");
            sehirler.Add("Afyon");
            sehirler.Add("Afyon");
            sehirler.Add("Afyon");
            sehirler.Add("Afyon");
            Console.WriteLine(sehirler.Count);
            
           
            MyList<string> sehirler2 = new MyList<string> ();
            sehirler2.Add("Batman");
            sehirler2.Add("Batman");
            sehirler2.Add("Batman");
            sehirler2.Add("Batman");
            sehirler2.Add("Batman");
            sehirler2.Add("Batman");
            Console.WriteLine(sehirler2.Count);
            
        }
    }
    //kendi listemizi oluşturuyoruz genericleri görüyoruz <>
    class MyList<T> //Generic class oldu, T tipi ile çalışır, yani çalışılacak tipi biz veririz, ne verirsek ona dönüşür.
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];

            }
            _array[_array.Length - 1] = item;
        }


        public int Count
        {
            get { return _array.Length; }
        }

    }
}
