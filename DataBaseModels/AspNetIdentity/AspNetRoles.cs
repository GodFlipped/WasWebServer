using System.Collections.Generic;

namespace WasWebServerCore.DataBaseModels.AspNetIdentity
{
    public partial class AspNetRoles
    {
        public AspNetRoles()
        {
            AspNetRolePermission = new HashSet<AspNetRolePermission>();
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Discriminator { get; set; }

        public virtual ICollection<AspNetRolePermission> AspNetRolePermission { get; set; }
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
    }
}
