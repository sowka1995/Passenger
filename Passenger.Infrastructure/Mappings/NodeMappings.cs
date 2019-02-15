using AutoMapper;
using Passenger.Core.Domain;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Mappings
{
    public class NodeMappings : Profile
    {
        public NodeMappings()
        {
            CreateMap<Node, NodeDTO>();
        }
    }
}
