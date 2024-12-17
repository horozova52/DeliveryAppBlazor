using MediatR;
using DeliveryAppBlazor.Server.Data.Entities;

namespace DeliveryAppBlazor.Server.Features.Clients.Queries
{
    public class GetClientByIdQuery : IRequest<ClientEntity>
    {
        public Guid Id { get; set; }
    }
}
