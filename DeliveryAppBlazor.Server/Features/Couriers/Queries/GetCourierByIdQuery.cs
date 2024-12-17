using MediatR;
using DeliveryAppBlazor.Server.Data.Entities;

namespace DeliveryAppBlazor.Server.Features.Couriers.Queries
{
    public class GetCourierByIdQuery : IRequest<Courier>
    {
        public Guid Id { get; set; }
    }
}
