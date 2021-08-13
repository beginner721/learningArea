using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces3
{
    class Program
    {
        //interface'ler newlenemez!
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager(); //interface'ler onu implemente eden classın ref. no sunu tutabilirler 
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager()); //sonradan stajyeri ekledik

            Console.ReadLine();
        }
    }
    interface IPersonManager
    {
        void Add();
        void Update();

    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi.");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi.");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

    }
}
