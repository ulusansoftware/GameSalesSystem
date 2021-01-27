using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesSystem
{
    class CampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi : " + campaign.campaignName +" %"+ campaign.discountRate + "İndirim");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("%" + campaign.discountRate +"indirim oranlı " + campaign.campaignName +"kampanyası bitmiştir.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi : " + campaign.campaignName + "Kampanyanın Yeni İndirim Oranı %" + campaign.discountRate);
        }
    }
}
