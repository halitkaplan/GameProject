using GameProject.Abstract;
using GameProject.Entities;
using GameProject.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class MemberManager : IMemberService
    {
        private IMemberCheckService _memberCheckService;

        public MemberManager(IMemberCheckService memberCheckService)
        {
            this._memberCheckService = memberCheckService;
        }

        public void Add(Member member)
        {
            if (_memberCheckService.CheckIfRealPerson(member))
            {
                Console.WriteLine(member.FirstName + " " + member.LastName + " - Oyuncu Eklendi");
            }
            else
            {
               // throw new Exception("Not a valid person");
                Console.WriteLine("Kullanıcı Bilgileri Hatalı");
                Environment.Exit(0);
            }
        }

        public void Delete(Member member)
        {
            Console.WriteLine("Oyuncu Silindi");
        }

        public void Update(Member member)
        {
            Console.WriteLine("Oyuncu Güncellendi");
        }
    }
}
