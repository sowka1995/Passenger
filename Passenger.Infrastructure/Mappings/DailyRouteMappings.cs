using AutoMapper;
using Passenger.Core.Domain;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Mappings
{
    public class DailyRouteMappings : Profile
    {
        public DailyRouteMappings()
        {
            CreateMap<DailyRoute, DailyRouteDTO>();
        }
    }
}
