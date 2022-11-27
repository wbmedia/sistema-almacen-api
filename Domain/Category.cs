using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Active> Actives { get; set; } = new List<Active>();
    }
}