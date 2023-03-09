using AutoMapper;
using Tourist.Dtos;
using Tourist.Models;

namespace Tourist.Profiles
{
    public class TouristRoutePictureProfile:Profile
    {
        public TouristRoutePictureProfile()
        {
            CreateMap<TouristRoutePicture, TouristRoutePictureDto>();

            CreateMap<TouristRoutePictureCreateDto, TouristRoutePicture>();

            CreateMap<TouristRoutePicture,TouristRoutePictureCreateDto>();
        }
    }
}
