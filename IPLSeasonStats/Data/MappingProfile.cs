using AutoMapper;
using IPLSeasonStats.Data.Entities;
using IPLSeasonStats.DTOs;

namespace IPLSeasonStats.Data
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Matches, MatchesDto>();
            CreateMap<MatchesDto, Matches>();

            CreateMap<MatchDemo, Matches>();
            CreateMap<Matches, MatchDemo>();
            // CreateMap<Deliveries, DeliveriesDto>();
            // CreateMap<DeliveriesDto, Deliveries>();
        }
    }

}
