using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tourist.Models
{
    public class TouristRoutePicture
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Url { get; set; }

        [ForeignKey("TouristRouteId")]
        public Guid TouristRouteId { get; set; }
        public TouristRoute TouristRoute { get; set; }
    }
}
