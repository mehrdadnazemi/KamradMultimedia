using Kamrad.Multimedia.Users;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Kamrad.Multimedia.Files
{
    public class FileComments : Entity<long>, IEquatable<FileComments>
    {
        public string Comment { get; set; }
        public int? UserIdFk { get; set; }
        public int FileIdFk { get; set; }
        [ForeignKey(nameof(FileIdFk))]
        public virtual AppFile Files { get; set; }
        [ForeignKey(nameof(UserIdFk))]
        public virtual AppUser User { get; set; }

        public bool Equals(FileComments other)
        {
            return this.Comment == other.Comment &&
                this.UserIdFk == other.UserIdFk &&
                this.FileIdFk == other.FileIdFk;
        }
    }
}
