using System;
using System.Collections.Generic;

namespace WasWebServerNew.JdWDbModels
{
    public partial class Company
    {
        public Company()
        {
            Departments = new HashSet<Department>();
            InverseParent = new HashSet<Company>();
        }

        public string Id { get; set; }
        public string AddressDetail { get; set; }
        public string AddressCode { get; set; }
        public int IsdefaultAddress { get; set; }
        public string Fax { get; set; }
        public string Telephone { get; set; }
        public string EmailAddress { get; set; }
        public string EmailCode { get; set; }
        public string ParentId { get; set; }
        public string PhotoLink { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual Company Parent { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Company> InverseParent { get; set; }
    }
}
