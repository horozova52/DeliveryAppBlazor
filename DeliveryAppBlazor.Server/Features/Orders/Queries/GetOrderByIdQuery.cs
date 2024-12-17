using MediatR;
using DeliveryAppBlazor.Server.Data.Entities;

namespace DeliveryAppBlazor.Server.Features.Orders.Queries
{
    public class GetOrderByIdQuery : IRequest<Order>
    {
        public Guid Id { get; set; }
    }
}
