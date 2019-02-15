using AutoMapper;
using Passenger.Core.Domain;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Mappings
{
    public class VehicleMappings : Profile
    {
        public VehicleMappings()
        {
            CreateMap<Vehicle, VehicleDTO>();
        }
    }
}
