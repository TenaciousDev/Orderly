﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Data
{
    public class Housing
    {
        [Key]
        public int Id { get; set; }
        public string Address { get; set; }
        public string Room { get; set; }
    }
}
