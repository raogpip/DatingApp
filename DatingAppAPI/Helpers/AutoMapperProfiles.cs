using AutoMapper;
using DatingAppAPI.DTOs;
using DatingAppAPI.Entities;
using DatingAppAPI.Extensions;

namespace DatingAppAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDTO>()
                .ForMember(destination => destination.PhotoUrl, option => option
                        .MapFrom(source => source.Photos
                        .Find(x => x.IsMain).Url))
                .ForMember(dest => dest.Age, opt => opt
                        .MapFrom(src => src.DateOfBirth.CalculateAge()));

            CreateMap<Photo, PhotoDTO>();
        }
    }
}