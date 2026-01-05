using AutoMapper;
using UrlShortener.Api.DTOs;
using UrlShortener.Api.Models;

namespace UrlShortener.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Url, UrlResponse>()
                .ForMember(dest => dest.ShortUrl,
                           opt => opt.MapFrom((src, dest, destMember, context) => 
                                $"{context.Items["BaseUrl"]}/{src.ShortCode}"));

            CreateMap<Url, CreateResponse>()
                 .ForMember(dest => dest.ShortUrl,
                           opt => opt.MapFrom((src, dest, destMember, context) => 
                                $"{context.Items["BaseUrl"]}/{src.ShortCode}"));
        }
    }
}