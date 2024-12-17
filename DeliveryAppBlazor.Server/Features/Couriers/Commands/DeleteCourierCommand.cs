using Azure.Core;
using MediatR;

namespace DeliveryAppBlazor.Server.Features.Couriers.Commands
{
    public class DeleteCourierCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
