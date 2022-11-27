using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Client
    {
        [Key]
        public int Guid { get; set; }
        public string Subject { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string? MobileNumber { get; set; }
        public string? RFC { get; set; }
        public string Address { get; set; } = string.Empty;
    }
}