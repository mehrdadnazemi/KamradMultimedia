using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace Kamrad.Multimedia.Medias
{
    public class OrganizationalMatters:Entity<int>, IEquatable<OrganizationalMatters>
    {
        public OrganizationalMatters()
        {
            OrganizationalMattersNavigation = new HashSet<OrganizationalMatters>();
        }
        public int Bandwidth { get; set; }
        public string ConnectionType { get; set; }
        public int? OrganizationalMatterIdFk { get; set; }
        public string OrganizationalName { get; set; }

        public virtual OrganizationalMatters OrganizationalMatter { get; set; }
        public virtual ICollection<OrganizationalMatters> OrganizationalMattersNavigation { get; set; }

        public bool Equals(OrganizationalMatters other)
        {
            return this.Bandwidth == other.Bandwidth &&
                this.ConnectionType == other.ConnectionType &&
                this.OrganizationalMatterIdFk == other.OrganizationalMatterIdFk &&
                string.Equals(this.OrganizationalName.Trim(), other.OrganizationalName.Trim(),
                StringComparison.OrdinalIgnoreCase);
        }
    }
}
