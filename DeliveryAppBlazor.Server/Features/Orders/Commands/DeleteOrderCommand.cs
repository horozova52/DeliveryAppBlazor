using MediatR;

namespace DeliveryAppBlazor.Server.Features.Orders.Commands
{
    public class DeleteOrderCommand : IRequest <Unit>
    {
        public Guid Id { get; set; }
    }
}
