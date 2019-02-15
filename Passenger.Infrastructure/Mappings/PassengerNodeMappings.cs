using AutoMapper;
using Passenger.Core.Domain;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Mappings
{
    public class PassengerNodeMappings : Profile
    {
        public PassengerNodeMappings()
        {
            CreateMap<PassengerNode, PassengerNodeDTO>();
        }
    }
}
