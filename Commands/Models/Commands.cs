﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commands.Models
{
    public class Commands
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Platform { get; set; }
        public string CommandLine { get; set; }
    }
}
