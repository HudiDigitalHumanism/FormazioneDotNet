namespace EFCore.Database
{
    public class ArtistRoles
    {
        public string FiscalCode { get; set; }
        public ICollection<PersonRole> HistoricalRoles { get; set; }
    }
}
