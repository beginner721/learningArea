using InterfaceAbstract.Abstract;
using InterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract.Concrete
{
    public class CustomerManager : ICustomerService
    {
        IMernisCheckService mernisCheckService;

        public CustomerManager(IMernisCheckService mernisCheckService)
        {
            this.mernisCheckService = mernisCheckService;
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Hesap silindi.");
        }

        public void Register(Customer customer)
        {
            if (mernisCheckService.CheckRealPerson(customer))
            {
                Console.WriteLine("Başarıyla kayıt olundu.");
            }
            else
            {
                Console.WriteLine("HATA");
            }
            
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Güncelleme başarılı.");
        }
    }
}
