using System;

namespace Passenger.Infrastructure.DTO
{
    public class RouteDTO
    {
        public Guid Id { get; set; }

        public NodeDTO StartNode { get; set; }

        public NodeDTO EndNode { get; set; }
    }
}