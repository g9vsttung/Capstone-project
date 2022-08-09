﻿using System;
using System.ComponentModel.DataAnnotations;

namespace kiosk_solution.Data.ViewModels
{
    public class PoiUpdateBannerViewModel
    {
        [Required]
        public Guid PoiId { get; set; }
        [Required]
        public string Banner { get; set; }
    }
}