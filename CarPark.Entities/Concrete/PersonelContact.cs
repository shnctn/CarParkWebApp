﻿using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CarPark.Entities.Concrete
{
    public class PersonelContact
    {
       
        public string PhoneNumber { get; set; }
        public string WorkPhoneNumber { get; set; }
    }
}
