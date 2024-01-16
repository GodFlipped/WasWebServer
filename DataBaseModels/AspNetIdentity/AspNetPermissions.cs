using System.Collections.Generic;

namespace WasWebServerCore.DataBaseModels.AspNetIdentity
{
    public partial class AspNetPermissions
    {
        public AspNetPermissions()
        {
            AspNetRolePermission = new HashSet<AspNetRolePermission>();
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AspNetRolePermission> AspNetRolePermission { get; set; }
    }
}
