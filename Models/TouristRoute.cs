using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tourist.Models
{
    public class TouristRoute
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1500)]
        public string Description { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        public decimal OriginalPrice { get; set; }

        [Range(0.0,0.1)]
        public double? DiscountPresent { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? DepartureTime { get; set;}

        [MaxLength]
        public string Features { get; set; }
        [MaxLength]
        public string Fees { get; set; }
        [MaxLength]
        public string Notes { get; set; }

        public ICollection<TouristRoutePicture> TouristRoutePictures { get; set; }
            = new HashSet<TouristRoutePicture>();

    }
}
