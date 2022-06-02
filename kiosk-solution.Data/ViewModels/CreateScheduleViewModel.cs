﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace kiosk_solution.Data.ViewModels
{
    public class CreateScheduleViewModel
    {
        [Required] public string Name { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        [Required] public string StringTimeStart { get; set; }
        [Required] public string StringTimeEnd { get; set; }
        [Required] public string DayOfWeek { get; set; }
    }
}