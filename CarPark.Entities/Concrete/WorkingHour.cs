﻿using System.Collections.Generic;

namespace CarPark.Entities.Concrete
{
    public class WorkingHour
    {
        public ICollection<Translation> Translations { get; set; }

    }
}