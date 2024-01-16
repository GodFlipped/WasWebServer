using System;
using System.Collections.Generic;

namespace WasWebServerNew.JdWDbModels
{
    public partial class User
    {
        public User()
        {
            Passwords = new HashSet<Password>();
            FunctionPrivileges = new HashSet<FunctionPrivilege>();
            Roles = new HashSet<Role>();
            Terminals = new HashSet<Terminal>();
            Workgroups = new HashSet<Workgroup>();
        }

        public string Id { get; set; }
        public string LastAccessIp { get; set; }
        public DateTime LastAccessTimestamp { get; set; }
        public int UserStatus { get; set; }
        public int MaxPasswordReconNum { get; set; }
        public int TerminalMaxLoginNum { get; set; }
        public int LongestIdleTime { get; set; }
        public int TerminalLimit { get; set; }
        public string TerminalStartIpAddress { get; set; }
        public string TerminalEndIpAddress { get; set; }
        public string TerminalIpAddress { get; set; }
        public int IsManyLogin { get; set; }
        public string PersonnelId { get; set; }
        public string PhotoLink { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual Personnel IdNavigation { get; set; }
        public virtual ICollection<Password> Passwords { get; set; }

        public virtual ICollection<FunctionPrivilege> FunctionPrivileges { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Terminal> Terminals { get; set; }
        public virtual ICollection<Workgroup> Workgroups { get; set; }
    }
}
