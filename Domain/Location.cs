using System.ComponentModel.DataAnnotations;

namespace Domain
{
    /// <summary>
    /// The Location.
    /// </summary>
    public class Location
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        public ICollection<Active> Actives { get; set; } = new List<Active>();
    }
}