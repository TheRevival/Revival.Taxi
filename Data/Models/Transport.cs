namespace Data.Models
{
    public class Transport
    {
        public long Id { get; set; }
        
        public long DriverId { get; set; }
        public Driver Driver { get; set; }

        public long TransportTypeId { get; set; }
        public  TransportType Type { get; set; }
    }
}