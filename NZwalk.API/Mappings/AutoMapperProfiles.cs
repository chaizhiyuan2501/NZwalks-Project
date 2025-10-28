using AutoMapper;
using NZwalk.API.Models.Domain;
using NZwalk.API.Models.DTO;
using AutoMapper;

namespace NZwalk.API.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<AddRegionRequestDto, Region>().ReverseMap();
            CreateMap<UpdateRegionRequestDto, Region>().ReverseMap();

            CreateMap<AddWalkRequestDto, Walk>().ReverseMap();
            CreateMap<Walk, WalkDto>().ReverseMap();
            CreateMap<Difficulty, DifficultDto>().ReverseMap();
            CreateMap<UpdateWalkRequestDto, Walk>().ReverseMap();
        }
    }
}
