using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CarPark.Entities.Concrete
{
    public class Address
    {
        public string CountyId { get; set; }
        public string Title { get; set; }
        public string Desciription { get; set; }
       

    }
}
