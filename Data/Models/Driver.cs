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
        public Transport Transport { get; set; }
    }
}