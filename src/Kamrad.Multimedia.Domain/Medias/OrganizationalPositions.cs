using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace Kamrad.Multimedia.Medias
{
    public partial class OrganizationalPositions : Entity<int>, IEquatable<OrganizationalPositions>
    {
        public OrganizationalPositions()
        {
            Participants = new HashSet<Participants>();
        }
        public string OrganizationalpositionName { get; set; }
        public virtual ICollection<Participants> Participants { get; set; }

        public bool Equals(OrganizationalPositions other)
        {
            return string.Equals(this.OrganizationalpositionName.Trim(), other.OrganizationalpositionName.Trim(),
                StringComparison.OrdinalIgnoreCase);
        }
    }
}
