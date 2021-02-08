namespace Data.Models
{
    public class Order
    {
        public long Id { get; set; }
        /// <summary>
        /// The fare of provided service.
        /// </summary>
        public decimal Fare { get; set; }
        /// <summary>
        /// Initial point of taxi ride.
        /// </summary>
        // TODO: Take the initial point from Yandex.Map or Google.Map open API.
        public string From { get; set; }
        /// <summary>
        /// Final point of taxi ride.
        /// </summary>
        // TODO: The same for final point of ride.
        // TODO: Add some enum or even instance of ride type to provide the ability of users(clients) several points to visit (probably something like graph with ability to choose the best path(shortest one(Dijkstra algorithm))).
        public string To { get; set; }
        
        public Client Client { get; set; }
        public Driver Driver { get; set; }
    }
}