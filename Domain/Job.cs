﻿using System.ComponentModel.DataAnnotations;

namespace Domain
{
    /// <summary>
    /// The Job.
    /// </summary>
    public class Job
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        public ICollection<Output> Outputs { get; set; } = new List<Output>();
        public Active Active { get; set; } = default!;
    }
}