using System;
using System.Collections.Generic;
using System.Text;
using CarPark.Core.Settings;
using CarPark.DataAccess.Abstract;
using CarPark.DataAccess.Context;
using CarPark.DataAccess.Repository;
using CarPark.Entities.Concrete;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CarPark.DataAccess.Concrete
{
     public class PersonelDataAccess : MongoRepositoryBase<Personel>,IPersonelDataAccess
     {
         private readonly MongoDBContext _context;
         private readonly IMongoCollection<Personel> _collection;
        public PersonelDataAccess(IOptions<MongoSettings> settings) : base(settings)
        {
            _context = new MongoDBContext(settings);
            _collection = _context.GetCollection<Personel>();
        }

      
    }
}
