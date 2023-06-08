namespace Multi.Tenancy.Common
{
    public interface IMustHaveTenant
    {
        public string TenantId { get; set; } 
    }
}
