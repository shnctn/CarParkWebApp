using System;
using System.Collections.Generic;
using System.Text;
using CarPark.Business.Abstract;
using CarPark.Core.Models;
using CarPark.DataAccess.Abstract;
using CarPark.Entities.Concrete;

namespace CarPark.Business.Concrete
{
    public class PersonelManager : IPersonelService
    {
        private readonly IPersonelDataAccess _personelDataAccess;

        public PersonelManager(IPersonelDataAccess personelDataAccess)
        {
            _personelDataAccess = personelDataAccess;
        }

        public GetManyResult<Personel> GetPersonelByAge()
        {
            var personels = _personelDataAccess.GetAll();
            return personels;
        }
    }
}
