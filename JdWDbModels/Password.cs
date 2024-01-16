using System;
using System.Collections.Generic;

namespace WasWebServerNew.JdWDbModels
{
    public partial class Password
    {
        public string Id { get; set; }
        public string HashCode { get; set; }
        public int PasswordType { get; set; }
        public int AuthenticationType { get; set; }
        public int PasswordDegree { get; set; }
        public string PasswordDefine { get; set; }
        public int MaxLoginTryNum { get; set; }
        public string UserId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public virtual User User { get; set; }
    }
}
