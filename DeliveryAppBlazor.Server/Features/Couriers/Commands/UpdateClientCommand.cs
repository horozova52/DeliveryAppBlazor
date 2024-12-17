using Azure.Core;
using MediatR;

namespace DeliveryAppBlazor.Server.Features.Couriers.Commands
{
    public class UpdateCourierCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
    }
}
