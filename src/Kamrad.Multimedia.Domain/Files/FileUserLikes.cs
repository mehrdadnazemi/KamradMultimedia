using Kamrad.Multimedia.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Kamrad.Multimedia.Files
{
    public class FileUserLikes : Entity<int>, IEquatable<FileUserLikes>
    {
        public string Ipaddress { get; set; }
        public long FileIdFk { get; set; }

        public int UserIdFK { get; set; }
        [ForeignKey(nameof(FileIdFk))]
        public virtual AppFile File { get; set; }

        public bool Equals(FileUserLikes other)
        {
            return this.Ipaddress == other.Ipaddress &&
                this.FileIdFk == other.FileIdFk &&
                this.UserIdFK == other.UserIdFK;
        }
    }
}
