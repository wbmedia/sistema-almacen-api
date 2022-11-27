using System.ComponentModel.DataAnnotations;

namespace Domain
{
    /// <summary>
    /// The Actives Oputput
    /// </summary>
    public class Output
    {
        public Guid Id { get; set; }

        [Required]
        public DateTime OutputDate { get; set; }

        [Required]
        public string Place { get; set; } = string.Empty;

        [Required]
        public string Responsible { get; set; } = string.Empty;

        public string? Note { get; set; }
        public bool Status { get; set; }
        public Job Job { get; set; } = default!;
    }
}