﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moviepedia.Models.ORM
{
    public class Base
    {
        public int ID { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime AddDate { get; set; }
    }
}
