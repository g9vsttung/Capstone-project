﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiosk_solution.Data.ViewModels
{
    public class KioskDetailViewModel
    {
        public Guid Id { get; set; }
        public string DeviceId { get; set; }
        public KioskScheduleTemplateDetailViewModel? KioskScheduleTemplate { get; set; }

    }
}
