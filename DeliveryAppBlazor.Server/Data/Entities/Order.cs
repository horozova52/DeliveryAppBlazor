namespace DeliveryAppBlazor.Server.Data.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public string SenderId { get; set; }
        public string ReceviedId { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; }

        public string CourierId { get; set; }
        public ClientEntity Client { get; set; }
        public Courier Curier { get; set; }
        
        
    }
}
