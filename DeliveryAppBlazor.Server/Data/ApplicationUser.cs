using DeliveryAppBlazor.Server.Data.Entities;
using DeliveryAppBlazor.Shared.Enums;
using Microsoft.AspNetCore.Identity;

namespace DeliveryAppBlazor.Server.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public ClientEntity Client { get; set; }
        public Courier Courier { get; set; }
        public UserRole Role { get; set; }
    }

}
