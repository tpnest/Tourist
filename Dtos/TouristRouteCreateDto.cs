﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Tourist.Models;

namespace Tourist.Dtos
{
    public class TouristRouteCreateDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal OriginalPrice { get; set; }
        public double? DiscountPresent { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? DepartureTime { get; set; }
        public string Features { get; set; }
        public string Fees { get; set; }
        public string Notes { get; set; }
    }
}
