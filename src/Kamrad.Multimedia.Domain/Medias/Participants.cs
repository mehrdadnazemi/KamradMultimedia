using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace Kamrad.Multimedia.Medias
{
    public partial class Participants: Entity<int>, IEquatable<Participants>
    {
        public Participants()
        {
            MediaInfoFileParticipants = new HashSet<MediaInfoFileParticipants>();
            MediaInfos = new HashSet<MediaInfos>();
        }
        public int? OrganizationalPositionIdFk { get; set; }
        public string ParticipantLastName { get; set; }
        public string ParticipantName { get; set; }

        public virtual OrganizationalPositions OrganizationalPosition { get; set; }
        public virtual ICollection<MediaInfoFileParticipants> MediaInfoFileParticipants { get; set; }
        public virtual ICollection<MediaInfos> MediaInfos { get; set; }

        public bool Equals(Participants other)
        {
            return string.Equals(this.ParticipantName.Trim(), other.ParticipantName.Trim(), StringComparison.OrdinalIgnoreCase)
                && string.Equals(this.ParticipantLastName.Trim(), other.ParticipantLastName.Trim(), StringComparison.OrdinalIgnoreCase)
                && this.OrganizationalPositionIdFk == other.OrganizationalPositionIdFk;
        }
    }
}
