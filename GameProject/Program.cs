using System;
using GameProject.Abstract;
using GameProject.Entities;
using GameProject.Concrete;
using GameProject.Adapter;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MemberManager memberManager = new MemberManager(new MernisServiceAdapter());
            Member member = new Member
            {
                ID = 1,
                NationalityID = "1234567890",
                FirstName = "Halit",
                LastName = "Kaplan",
                DateOfBirth = new DateTime(2000,01,01)      

            };
            memberManager.Add(member);

            GameManager gameManager = new GameManager();
            Game game = new Game
            {
                GameId = 1,
                GameName = "Battlefield 1",
                GameType = "War",
                GamePrice = 159
                
                
            };
            GameManager gameManager2 = new GameManager();
            Game game2 = new Game
            {
                GameId = 2,
                GameName = "Forza Horizon",
                GameType = "Race",
                GamePrice = 249

            };


  //          SalesManager salesManager = new SalesManager();
  //          salesManager.Sales(member, game);


            Campaign campaign1 = new Campaign();
            campaign1.ID = 1;
            campaign1.CampaignName = "Cadılar Bayramı";
            campaign1.PercentageOfDiscount = 9;


            Campaign campaign2 = new Campaign();
            campaign2.ID = 2;
            campaign2.CampaignName = "Paskalya";
            campaign2.PercentageOfDiscount = 3;



            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign2);

            SalesManager salesManager1 = new SalesManager();
            salesManager1.CampaignSales(member, game2, campaign1);








        }
    }
}
