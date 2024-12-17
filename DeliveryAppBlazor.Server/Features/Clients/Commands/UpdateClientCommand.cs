using Azure.Core;
using MediatR;

namespace DeliveryAppBlazor.Server.Features.Client.Commands
{
    public class UpdateClientCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
    }
}
