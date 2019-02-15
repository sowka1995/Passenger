using System;
using System.Collections.Generic;

namespace Passenger.Infrastructure.DTO
{
    public class DriverDTO
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public VehicleDTO Vehicle { get; set; }

        public IEnumerable<RouteDTO> Routes { get; set; }

        public IEnumerable<DailyRouteDTO> DailyRoutes { get; set; }
    }
}
