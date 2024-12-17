using DeliveryAppBlazor.Server.Data.Entities;
using MediatR;
using System.Collections.Generic;

namespace DeliveryAppBlazor.Server.Features.Couriers.Queries
{
    public class GetAllCouriersQuery : IRequest<List<Courier>>
    {
    }
}
