using System;
using System.Collections.Generic;

namespace DeveloperTest_Anthony_Mugabira
{
    public partial class ClientGroupUsers
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ClientGroupId { get; set; }

        public virtual ClientGroup ClientGroup { get; set; }
        public virtual Users User { get; set; }
    }
}
