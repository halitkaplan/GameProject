using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
  

        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " Oyun Kütüphaneye Eklendi");
        }

        public bool CheckIfRealPerson(Member member)
        {
            throw new NotImplementedException();
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " Oyun Kütüphaneden Silindi");
        }
    }
}
