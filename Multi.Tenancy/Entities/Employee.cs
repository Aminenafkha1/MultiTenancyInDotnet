using Multi.Tenancy.Common;

namespace Multi.Tenancy.Entities
{
    public class Employee : IMustHaveTenant
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string TenantId  { get; set; } = null!;

    }
}
