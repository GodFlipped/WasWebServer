using System;
using System.Collections.Generic;

namespace WasWebServerNew.JdWDbModels
{
    public partial class Personnel
    {
        public string Id { get; set; }
        public int Sex { get; set; }
        public string ChineseName { get; set; }
        public string EnglishName { get; set; }
        public int Job { get; set; }
        public string MobileNo { get; set; }
        public string PostAddress { get; set; }
        public string CompanyTelephone { get; set; }
        public string Comments { get; set; }
        public string PhotoLink { get; set; }
        public string DepartmentId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual Department Department { get; set; }
        public virtual User User { get; set; }
    }
}
