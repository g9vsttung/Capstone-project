﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiosk_solution.Data.ViewModels
{
    public class ServiceApplicationViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public string Link { get; set; }
        public Guid? PartyId { get; set; }
        public string PartyName { get; set; }
        public string PartyEmail { get; set; }
        public Guid? AppCategoryId { get; set; }
        public string AppCategoryName { get; set; }
        public Guid? ApplicationMarketId { get; set; }
        public string Status { get; set; }
    }
}
