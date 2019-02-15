using System;

namespace Passenger.Infrastructure.DTO
{
    public class PassengerDTO
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public NodeDTO Address { get; set; }
    }
}