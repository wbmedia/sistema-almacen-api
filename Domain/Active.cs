using System.ComponentModel.DataAnnotations;

namespace Domain
{
    /// <summary>
    /// The Active Units.
    /// </summary>
    public class Active
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Features { get; set; }

        [Required]
        public int Unit { get; set; }

        [Required]
        public int Stock { get; set; }

        [Required]
        public string Note { get; set; } = string.Empty;

        public bool Status { get; set; }
    }
}