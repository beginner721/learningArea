using InterfaceAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract.Abstract
{
    public interface ICampaignManager
    {
        void AddCampaign(Campaigns campaign);
        void DeleteCampaign(Campaigns campaign);
        void UpdateCampaign(Campaigns campaign);
    }
}
