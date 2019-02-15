using System;
using System.Collections.Generic;

namespace Passenger.Infrastructure.DTO
{
    public class DailyRouteDTO
    {
        public Guid Id { get; set; }

        public RouteDTO Route { get; set; }

        public IEnumerable<PassengerNodeDTO> PassengerNodes { get; set; }
    }
}