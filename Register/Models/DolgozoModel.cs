﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Models
{
    public class DolgozoModel
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public List<BlokkModel> Blokkok { get; set; }
    }
}
