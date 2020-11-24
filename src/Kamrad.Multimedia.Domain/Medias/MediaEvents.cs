using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace Kamrad.Multimedia.Medias
{
    public class MediaEvents : Entity<int>, IEquatable<MediaEvents>
    {
        public MediaEvents()
        {
            MediaInfos = new HashSet<MediaInfos>();
        }
        public string EventName { get; set; }

        public virtual ICollection<MediaInfos> MediaInfos { get; set; }

        public bool Equals(MediaEvents other)
        {
            return string.Equals(this.EventName.Trim(), other.EventName.Trim(), StringComparison.OrdinalIgnoreCase);
        }
    }
}
