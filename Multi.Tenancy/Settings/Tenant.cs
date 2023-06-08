namespace Multi.Tenancy.Settings
{
    public class Tenant
    {
        public string Name { get; set; } = null!;
        public string TId { get; set; } = null!;
        public string? ConnectionString { get; set; }
    }
}
