using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Driver
    {
        public long Id { get; set; }
        [MinLength(2)]
        [MaxLength(20)]
        public string FirstName { get; set; }
        [MinLength(2)]
        [MaxLength(20)]
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        
        // TODO: Add some rank system of drivers. [Probably, via fk to order and client, that will give some feedback by ranking(in order) lol].
        public Transport Transport { get; set; }
    }
}