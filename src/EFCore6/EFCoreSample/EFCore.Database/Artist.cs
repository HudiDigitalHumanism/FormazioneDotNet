namespace EFCore.Database
{
    public class Artist
    {
        public string FiscalCode { get; set; } = FiscalNotSet;
        public string Name { get; init; } = null!;
        public string Surname { get; set; } = null!;
        public Address CurrentAddress { get; set; } = null!;
        //public ArtistRoles Role { get; set; } = null!;
        public Gendre Gendre { get; set; } = Gendre.NotDeclared;

        public static string FiscalNotSet = "NA";
        public bool IsDeleted { get; set; }
    }

    public class Address
    {
        public string Via { get; set; }
        public string? City { get; set; }
        public int? Number { get; set; }
    }

    public enum Gendre
    {
        Male,
        Female,
        NotDeclared
    }
}