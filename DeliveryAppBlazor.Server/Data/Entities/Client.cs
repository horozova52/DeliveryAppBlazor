﻿namespace DeliveryAppBlazor.Server.Data.Entities
{
    public class ClientEntity
    {
            public Guid Id { get; set; }
            public string UserId { get; set; }
            public ApplicationUser User { get; set; }

        
        //public UserRole Role { get; set; }

    }
}
