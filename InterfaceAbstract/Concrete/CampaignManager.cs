using InterfaceAbstract.Abstract;
using InterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract.Concrete
{
    public class CampaignManager : ICampaignManager
    {
        public void AddCampaign(Campaigns campaign)
        {
            Console.WriteLine("Kampanya eklendi.");
        }

        public void DeleteCampaign(Campaigns campaign)
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void UpdateCampaign(Campaigns campaign)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
