using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SalesManager
    {
        public void Sales(Member member, Game game)
        {
            Console.WriteLine(member.FirstName + " " + member.LastName + " ", game.GameName + " Oyununu Satın Aldı.");
        }

        public void CampaignSales(Member member, Game game, Campaign campaign)
        {
            int Account = game.GamePrice - ((game.GamePrice * campaign.PercentageOfDiscount) / 100);
            Console.WriteLine(member.FirstName + " " + member.LastName + ", " + game.GameName + " oyununu " + campaign.CampaignName + " kampanyası ile %" + campaign.PercentageOfDiscount + " indirimle " + Account + " TL'ye satın aldı.");
        }
    }
}
