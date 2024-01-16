using System;
using System.Collections.Generic;

namespace WasWebServerNew.JdWDbModels
{
    public partial class FunctionPrivilege
    {
        public FunctionPrivilege()
        {
            InverseParent = new HashSet<FunctionPrivilege>();
            RoleRefs = new HashSet<Role>();
            Users = new HashSet<User>();
        }

        public string Id { get; set; }
        public int FunObjType { get; set; }
        public int AccessModle { get; set; }
        public int FunObjParentId { get; set; }
        public string FunObjCatalog { get; set; }
        public string AuthorizationMask { get; set; }
        public int IsExtendAuthority { get; set; }
        public string ConditionExpression { get; set; }
        public string ParentId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual FunctionPrivilege Parent { get; set; }
        public virtual ICollection<FunctionPrivilege> InverseParent { get; set; }

        public virtual ICollection<Role> RoleRefs { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
