﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiosk_solution.Data.ViewModels
{
    public class ScheduleTemplateViewModel
    {
        public Guid Id { get; set; }
        public Guid? ScheduleId { get; set; }
        public Guid? TemplateId { get; set; }
    }
}
