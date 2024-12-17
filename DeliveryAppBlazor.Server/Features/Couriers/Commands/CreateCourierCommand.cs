using MediatR;

namespace DeliveryAppBlazor.Server.Features.Couriers.Commands
{
    public class CreateCourierCommand : IRequest<Guid>
    {
        public string UserId { get; set; }
    }
}
