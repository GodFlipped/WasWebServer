using System;
using System.Collections.Generic;

namespace WasWebServerNew.JdWDbModels
{
    public partial class Workgroup
    {
        public Workgroup()
        {
            Terminals = new HashSet<Terminal>();
            Users = new HashSet<User>();
        }

        public string Id { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Terminal> Terminals { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
