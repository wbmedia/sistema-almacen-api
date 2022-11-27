namespace Domain
{
    public class ActiveHistory : BaseClass
    {
        public TypeActive TypeActive { get; set; }
        public int Amount { get; set; }
        public string Responsible { get; set; } = string.Empty;
        public DateTime DateModified { get; set; }
        public string? Note { get; set; }
    }

    public enum TypeActive
    {
        Open = 1,
        Close = 2,
    }
}