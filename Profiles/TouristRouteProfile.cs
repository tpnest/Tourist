﻿using AutoMapper;
using Tourist.Dtos;
using Tourist.Models;

namespace Tourist.Profiles
{
    public class TouristRouteProfile : Profile
    {

        public TouristRouteProfile()
        {
            CreateMap<TouristRoute, TouristRouteDto>()
                .ForMember(des => des.Price,
                    opt => opt.MapFrom(src => src.OriginalPrice * (decimal)(src.DiscountPresent ?? 1)));
        }
    }
}
