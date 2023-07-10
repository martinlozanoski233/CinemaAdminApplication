using System;
using System.Collections.Generic;

namespace CinemaAdminApplication.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        public string UserId { get; set; }

        public CinemaApplicationUser User { get; set; }

        public IEnumerable<TicketInOrder> TicketInOrders { get; set; }

    }
}
