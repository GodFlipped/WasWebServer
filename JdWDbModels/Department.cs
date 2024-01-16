using System;
using System.Collections.Generic;

namespace WasWebServerNew.JdWDbModels
{
    public partial class Department
    {
        public Department()
        {
            InverseParent = new HashSet<Department>();
            Personnel = new HashSet<Personnel>();
        }

        public string Id { get; set; }
        public int DepartmentDegree { get; set; }
        public string CompanyId { get; set; }
        public string ParentId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual Company Company { get; set; }
        public virtual Department Parent { get; set; }
        public virtual ICollection<Department> InverseParent { get; set; }
        public virtual ICollection<Personnel> Personnel { get; set; }
    }
}
