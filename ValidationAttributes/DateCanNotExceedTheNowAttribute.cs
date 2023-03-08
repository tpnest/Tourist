using Microsoft.AspNetCore.Mvc.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using Tourist.Dtos;

namespace Tourist.ValidationAttributes
{
    public class DateCanNotExceedTheNowAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var touristRoute = validationContext.ObjectInstance as TouristRouteBaseDto;
            if (touristRoute != null)
            {
                if (touristRoute.CreateTime > DateTime.Now)
                {
                    return new ValidationResult("时间不能超过现在",
                        new[] { "TouristRouteCreateDto" });
                }
            }
            return ValidationResult.Success;
        }
    }
}
