using System;
using System.Collections.Generic;

namespace GenericsDIY
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> sayilar = new MyList<int>();
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            sayilar.Add(4);
            Console.WriteLine(sayilar.Count);

            var numaralar = new Dictionary<int, string>(); //bir sayı ve bir text i birbirine bağladık sözlük ile 
            //yazıldığı sırayla gösterilirler, düzenli olması için SortedDictionary gerekir 
            numaralar.Add(5,"Ahmet");
            numaralar.Add(6,"Mehmet");
            numaralar.Add(7,"Zehra");
            numaralar.Add(8,"Zeynep");
            numaralar.Add(9,"Deniz");

            foreach (var test in numaralar)
            {
                Console.WriteLine("Numara: "+ test.Key+ " Ad: "+test.Value);
            }

            Console.WriteLine("** SORTED **");

            var numaralarSorted = new SortedDictionary<int, string>(); //veya SortedList aynıdır ...
            //yukarıdakinden farkı ise düzensiz olsa dahi key sıralı verir 
            numaralarSorted.Add(5, "Ahmet");
            numaralarSorted.Add(8, "Zeynep");
            numaralarSorted.Add(6, "Mehmet");
            numaralarSorted.Add(9, "Deniz");
            numaralarSorted.Add(7, "Zehra");

            foreach (var x in numaralarSorted)
            {
                Console.WriteLine("Numara: "+x.Key + " Ad: " + x.Value);
            }
            
            

        }

        
    }
    class MyList<T>
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
