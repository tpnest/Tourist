using System.ComponentModel.DataAnnotations;
using Tourist.ValidationAttributes;

namespace Tourist.Dtos
{
    [DateCanNotExceedTheNow]
    public abstract class TouristRouteBaseDto:IValidatableObject
    {
        [Required(ErrorMessage ="标题不能为空")]
        public virtual string Title { get; set; }
        public string Description { get; set; }
        public decimal OriginalPrice { get; set; }
        public double? DiscountPresent { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? DepartureTime { get; set; }
        public string Features { get; set; }
        public string Fees { get; set; }
        public string Notes { get; set; }
        public ICollection<TouristRoutePictureCreateDto> TouristRoutePictures { get; set; }
            = new List<TouristRoutePictureCreateDto>();

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Title == Description)
            {
                yield return new ValidationResult(
                    "标题与描述必需不一样",
                    new[] { validationContext.DisplayName });
            }
        }
    }
}
