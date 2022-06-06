﻿using System;
using System.Collections.Generic;

#nullable disable

namespace kiosk_solution.Data.Models
{
    public partial class Event
    {
        public Event()
        {
            EventPositions = new HashSet<EventPosition>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? TimeStart { get; set; }
        public DateTime? TimeEnd { get; set; }
        public string Longtitude { get; set; }
        public string Latitude { get; set; }
        public string Street { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public Guid? CreatorId { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }

        public virtual Party Creator { get; set; }
        public virtual ICollection<EventPosition> EventPositions { get; set; }
    }
}
