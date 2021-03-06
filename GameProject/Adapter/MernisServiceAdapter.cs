using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapter
{
    public class MernisServiceAdapter : IMemberCheckService
    {
        public bool CheckIfRealPerson(Member member)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(member.NationalityID), member.FirstName.ToUpper(), member.LastName.ToUpper(), member.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
       


    }
}
