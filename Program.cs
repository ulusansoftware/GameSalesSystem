using System;

namespace GameSalesSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new Customer
            {
                InternationalId = "12345678910",
                FirstName = "Emre",
                LastName = " Ulusan",
                BirthDay = new DateTime(1984, 6, 16)
            });

            Product product1= new Product();
            product1.Id = 1;
            product1.gameName = "Call Of Duty";
            product1.gameType = "Battle";
            product1.gamePrice = 35;

            Customer customer1 = new Customer();
            customer1.FirstName = "Sade";
            customer1.LastName = "Küçükoğlu";

            SalesAssistantManager salesAssistantManager = new SalesAssistantManager();
            salesAssistantManager.Sale(product1, customer1);
                       
            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.campaignName = "Büyük Fırsat";
            campaign.discountRate = 19;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);


        }
    }
}
