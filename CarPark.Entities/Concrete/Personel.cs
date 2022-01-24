using System;
using System.Collections.Generic;
using System.Text;
using AspNetCore.Identity.MongoDbCore.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDbGenericRepository.Attributes;

namespace CarPark.Entities.Concrete
{
    [CollectionName("Personel")]
    public class Personel:MongoIdentityUser
    {
       
        public Personel()
        {
            CreateDate=DateTime.Now;
            Status = 1;
        }
        
        public PersonelContact Contact { get; set; }

        public ICollection<Address> Adres { get; set; }
        public short Status { get; set; }
        public DateTime CreateDate { get; set; }

        public DateTime?  UpdatedDate { get; set; }



    }
}
