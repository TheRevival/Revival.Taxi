namespace Data.Models
{
    /// <summary>
    /// Stores the types of transports, such as 'economy', 'comfort' or 'start'/'basic'.
    /// </summary>
    public class TransportType
    {
        public long Id { get; set; }
        public string TransportClassType { get; set; }
        public string Description { get; set; }
    }
}