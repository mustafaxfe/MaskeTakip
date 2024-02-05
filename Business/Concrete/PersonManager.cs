using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System.Collections.Generic;

namespace Business.Concrete
{
    //Çıplak class kalmasın
    public class PersonManager : IApplicantService
    {

        // encapsulation
        public void ApplyForMask(Person person)
        {

        }
        public List<Person> GetList()
        {
            return null;
        }
        public bool CheckPerson(Person person)
        {
            //KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            //return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, pero, "DEMİROĞ"))).Result.Body.TCKimlikNoDogrulaResult;
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName.ToUpper(), person.LastName.ToUpper(), person.DateofBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
            //return true;
        }
    }
}
