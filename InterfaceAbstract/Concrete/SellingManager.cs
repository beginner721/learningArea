using InterfaceAbstract.Abstract;
using InterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract.Concrete
{
    public class SellingManager : ISellingManager
    {
        


        public void Sell(Customer customer) 
        {

            Console.WriteLine("Ödeme başarılı. Tebrikler! "+ customer.FirstName);
        }
    }
}
