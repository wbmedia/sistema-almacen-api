namespace Domain
{
    public class Category : BaseClass
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<Active> Actives { get; set; } = new List<Active>();
    }
}