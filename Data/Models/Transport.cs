namespace Data.Models
{
    public class Transport
    {
        public long Id { get; set; }
        public Driver Driver { get; set; }
        public  TransportType Type { get; set; }
    }
}