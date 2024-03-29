﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    [Comment("House category")]
    public class Category
    {
        [Key]
        [Comment("Category Identyfier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        [Comment("Category name")]
        public string Name { get; set; } = string.Empty;

        [Comment("Category houses")]
        public List<House> Houses { get; set; } = new List<House>();
    }
}
