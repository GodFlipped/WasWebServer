namespace WasWebServerCore.DataBaseModels.AspNetIdentity
{
    public partial class AspNetRolePermission
    {
        public string PermissionId { get; set; }
        public string RoleId { get; set; }

        public virtual AspNetPermissions Permission { get; set; }
        public virtual AspNetRoles Role { get; set; }
    }
}
