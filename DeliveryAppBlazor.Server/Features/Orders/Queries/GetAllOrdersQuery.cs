using MediatR;
using DeliveryAppBlazor.Server.Data.Entities;

namespace DeliveryAppBlazor.Server.Features.Orders.Queries
{
    public class GetAllOrdersQuery : IRequest<List<Order>>
    {
    }
}
