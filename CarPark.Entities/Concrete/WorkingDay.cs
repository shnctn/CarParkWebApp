using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CarPark.Entities.Concrete
{
     public class WorkingDay:BaseModel
    {
      

        public ICollection<Translation> Translation { get; set; }
        public ICollection<WorkingHour> WorkingHoursCollection { get; set; }
    }
}
