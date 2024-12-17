using MediatR;

namespace DeliveryAppBlazor.Server.Features.Client.Commands
{
    public class CreateClientCommand : IRequest<Guid>
    {
        public string UserId { get; set; }
    }
}
