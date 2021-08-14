using InterfaceAbstract.Abstract;
using InterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract.Adapter
{
    public class MernisServiceAdapter : IMernisCheckService
    {
        public bool CheckRealPerson(Customer customer)
        {
            return true;
        }
    }
}
