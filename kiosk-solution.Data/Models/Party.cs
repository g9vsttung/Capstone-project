using System;
using System.Collections.Generic;

#nullable disable

namespace kiosk_solution.Data.Models
{
    public partial class Party
    {
        public Party()
        {
            InverseCreator = new HashSet<Party>();
            Events = new HashSet<Event>();
            Kiosks = new HashSet<Kiosk>();
            Orders = new HashSet<Order>();
            PartyKioskLocations = new HashSet<PartyKioskLocation>();
            PartyServiceApplications = new HashSet<PartyServiceApplication>();
            Pois = new HashSet<Poi>();
            Schedules = new HashSet<Schedule>();
            ServiceApplications = new HashSet<ServiceApplication>();
            Templates = new HashSet<Template>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Password { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? RoleId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Status { get; set; }

        public virtual Party Creator { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Party> InverseCreator { get; set; }
        public virtual ICollection<Event> Events { get; set; }
        public virtual ICollection<Kiosk> Kiosks { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PartyKioskLocation> PartyKioskLocations { get; set; }
        public virtual ICollection<PartyServiceApplication> PartyServiceApplications { get; set; }
        public virtual ICollection<Poi> Pois { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
        public virtual ICollection<ServiceApplication> ServiceApplications { get; set; }
        public virtual ICollection<Template> Templates { get; set; }
    }
}
