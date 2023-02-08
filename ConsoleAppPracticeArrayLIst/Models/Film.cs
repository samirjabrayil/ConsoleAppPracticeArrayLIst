﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPracticeArrayLIst.Models
{
    internal class Film : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public int TimeInMinute { get; set; }

        public override string ToString()
        {
            return $"{"ID:",-7} {Id}\n{"Name",-7} {Name}\n{"Minute",-7} {TimeInMinute}";
        }
    }
}
