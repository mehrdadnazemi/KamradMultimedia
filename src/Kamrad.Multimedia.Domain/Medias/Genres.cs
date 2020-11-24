using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace Kamrad.Multimedia.Medias
{
    public partial class Genres: Entity<int>, IEquatable<Genres>
    {
        public Genres()
        {
            MediaInfos = new HashSet<MediaInfos>();
        }
        public string GenreName { get; set; }

        public virtual ICollection<MediaInfos> MediaInfos { get; set; }

        public bool Equals(Genres other)
        {
            return string.Equals(this.GenreName.Trim(), other.GenreName.Trim(),
                StringComparison.OrdinalIgnoreCase);
        }
    }
}
