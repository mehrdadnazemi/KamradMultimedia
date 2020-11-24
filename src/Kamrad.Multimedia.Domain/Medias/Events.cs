using System;
using System.Collections.Generic;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Kamrad.Multimedia.Medias
{
    public class Events: Entity<int>, IEquatable<Events>
    {
        public Events()
        {
            MediaInfos = new HashSet<MediaInfos>();
        }
        public string EventName { get; set; }

        public virtual ICollection<MediaInfos> MediaInfos { get; set; }

        public bool Equals(Events other)
        {
            return string.Equals(this.EventName.Trim(), other.EventName.Trim(), StringComparison.OrdinalIgnoreCase);
        }
    }
}
