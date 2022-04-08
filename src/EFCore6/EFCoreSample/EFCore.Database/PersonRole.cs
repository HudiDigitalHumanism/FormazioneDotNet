namespace EFCore.Database
{
    public class PersonRole
    {
        public string RoleName { get; set; } = null!;
        public DateTime StartRole { get; set; }
        public DateTime EndRole { get; set; }
    }
}
