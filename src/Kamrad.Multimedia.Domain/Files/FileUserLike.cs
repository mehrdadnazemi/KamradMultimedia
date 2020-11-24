using Kamrad.Multimedia.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Kamrad.Multimedia.Files
{
    public class FileUserLike : Entity<int>, IEquatable<FileUserLike>
    {
        public string Ipaddress { get; set; }
        public int FileIdFk { get; set; }

        public int UserIdFK { get; set; }
        [ForeignKey(nameof(FileIdFk))]
        public virtual AppFile File { get; set; }
        [ForeignKey(nameof(UserIdFK))]
        public virtual AppUser User { get; set; }

        public bool Equals(FileUserLike other)
        {
            return this.Ipaddress == other.Ipaddress &&
                this.FileIdFk == other.FileIdFk &&
                this.UserIdFK == other.UserIdFK;
        }
    }
}
