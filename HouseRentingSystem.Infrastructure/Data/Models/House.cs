using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    [Comment("House to rent")]
    public class House
    {
        [Key]
        [Comment("House identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(HouseTitleMaxLength)]
        [Comment("House title")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(HouseAddressMaxLength)]
        [Comment("House address")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [MaxLength(HouseDesciptionMaxLength)]
        [Comment("House description")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Comment("House image url")]
        public string ImageUrl { get; set; } = string.Empty;

        //[Range(typeof(decimal),
        //HousePricePerMonthMinLength, 
        //HousePricePerMonthMaxLength, 
        //ConvertValueInInvariantCulture = true)]
        [Required]
        [Comment("House price per month")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PricePerMonth { get; set; }

        [Required]
        [Comment("House category indentifier")]
        public int CategoryId { get; set; }

        [Comment("House category")]
        public Category Category { get; set; } = null!;

        [Required]
        [Comment("House agent indentifier")]
        public int AgentId { get; set; }

        [Comment("House agent")]
        public Category Agent { get; set; } = null!;

        [Comment("House renterer identifier")]
        public string? RenterId { get; set; }
    }
}
