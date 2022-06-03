﻿using kiosk_solution.Data.Attributes;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiosk_solution.Data.ViewModels
{
    public class ServiceApplicationSearchViewModel
    {
        [BindNever]
        public Guid? Id { get; set; }
        [String]
        public string Name { get; set; }
        [BindNever]
        public string Description { get; set; }
        [BindNever]
        public string Logo { get; set; }
        [BindNever]
        public string Link { get; set; }
        [BindNever]
        public Guid? PartyId { get; set; }
        [String]
        public string PartyName { get; set; }
        [BindNever]
        public Guid? AppCategoryId { get; set; }
        [String]
        public string AppCategoryName { get; set; }
        [BindNever]
        public Guid? ApplicationMarketId { get; set; }
        [String]
        public string Status { get; set; }
    }
}