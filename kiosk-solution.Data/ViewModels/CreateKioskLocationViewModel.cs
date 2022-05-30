﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiosk_solution.Data.ViewModels
{
    public class CreateKioskLocationViewModel
    {
        [Required]
        public string District { get; set; }
        [Required]
        public string Province { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
