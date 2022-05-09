﻿using System;
using System.Collections.Generic;

#nullable disable

namespace kiosk_solution.Data.Models
{
    public partial class TblApplicationMarket
    {
        public TblApplicationMarket()
        {
            TblServiceApplications = new HashSet<TblServiceApplication>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public string Status { get; set; }

        public virtual ICollection<TblServiceApplication> TblServiceApplications { get; set; }
    }
}
