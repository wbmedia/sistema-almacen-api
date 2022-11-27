using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class BaseClass
    {
        [Key]
        public Guid Id { get; set; }
    }
}
