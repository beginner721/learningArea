using InterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract.Abstract
{
    public interface ICustomerService
    {
        void Register(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);

    }
}
