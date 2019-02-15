using AutoMapper;
using Passenger.Core.Domain;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Mappings
{
    public class RouteMappings : Profile
    {
        public RouteMappings()
        {
            CreateMap<Route, RouteDTO>();
        }
    }
}
