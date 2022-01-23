using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CarPark.Entities.Concrete
{
     public class Personel:BaseModel
    {
        
        public string Username { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string[] Roles { get; set; }
        public PersonelContact Contact { get; set; }

        public ICollection<Address> Adres { get; set; }
        public short Status { get; set; }
        public DateTime CreateDate { get; set; }

        public DateTime?  UpdatedDate { get; set; }



    }
}
