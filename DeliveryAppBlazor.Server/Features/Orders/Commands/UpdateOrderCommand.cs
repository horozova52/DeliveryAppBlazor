﻿using MediatR;

namespace DeliveryAppBlazor.Server.Features.Orders.Commands
{
    public class UpdateOrderCommand : IRequest <Unit>
    {
        public Guid Id { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
    }
}
