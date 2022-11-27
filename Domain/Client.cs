using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Client : BaseClass
    {
        [Required]
        public string Subject { get; set; } = string.Empty;

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public string Company { get; set; } = string.Empty;

        [Required]
        public string PhoneNumber { get; set; } = string.Empty;

        public string? MobileNumber { get; set; }
        public string? RFC { get; set; }

        [Required]
        public string Address { get; set; } = string.Empty;
    }
}