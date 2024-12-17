using DeliveryAppBlazor.Server.Data.Entities;
using MediatR;
using System.Collections.Generic;

namespace DeliveryAppBlazor.Server.Features.Clients.Queries
{
    public class GetAllClientsQuery : IRequest<List<ClientEntity>>
    {
    }
}
