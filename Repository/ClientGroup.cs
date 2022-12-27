using System;
using System.Collections.Generic;

namespace DeveloperTest_Anthony_Mugabira
{
    public partial class ClientGroup
    {
        public ClientGroup()
        {
            ClientGroupUsers = new HashSet<ClientGroupUsers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsHidden { get; set; }

        public virtual ICollection<ClientGroupUsers> ClientGroupUsers { get; set; }
    }
}
