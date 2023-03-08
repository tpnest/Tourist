using System.ComponentModel.DataAnnotations;

namespace Tourist.Dtos
{
    public class TouristRouteUpdateDto :TouristRouteBaseDto
    {
        [Required(ErrorMessage ="必需")]
        public override string Title { get; set; }

    }
}
