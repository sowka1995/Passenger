using AutoMapper;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Mappings
{
    public class PassengerMappings : Profile
    {
        public PassengerMappings()
        {
            CreateMap<Core.Domain.Passenger, PassengerDTO>();
        }
    }
}
