using System;
using System.Collections.Generic;

namespace WasWebServerNew.JdWDbModels
{
    public partial class Terminal
    {
        public Terminal()
        {
            Users = new HashSet<User>();
            Workgroups = new HashSet<Workgroup>();
        }

        public string Id { get; set; }
        public int TerminalType { get; set; }
        public int TerminalStatus { get; set; }
        public string TerminalIp { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Workgroup> Workgroups { get; set; }
    }
}
