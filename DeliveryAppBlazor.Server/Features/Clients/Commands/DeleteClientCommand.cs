using Azure.Core;
using MediatR;

namespace DeliveryAppBlazor.Server.Features.Client.Commands
{
    public class DeleteClientCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}
