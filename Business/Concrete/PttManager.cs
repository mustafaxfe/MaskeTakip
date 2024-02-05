using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;
        public PttManager(IApplicantService applicantService) //Constructor new 
        {
            _applicantService = applicantService;
        }


        public void GiveMask(Person person)
        {
            if (true)
            {
                Console.WriteLine("test1");

                //Console.WriteLine(person.FirstName + " için maske verildi");
            }
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                //Console.WriteLine("test2");
                Console.WriteLine(person.FirstName + " için maske verilemedi");
            }
        }
    }
}
