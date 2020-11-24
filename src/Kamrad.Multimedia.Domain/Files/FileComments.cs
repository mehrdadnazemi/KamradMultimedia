using Kamrad.Multimedia.Users;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Kamrad.Multimedia.Files
{
    public class FileComments : Entity<long>, IEquatable<FileComments>
    {
        public string Comment { get; set; }
        public long FileIdFk { get; set; }

        [ForeignKey(nameof(FileIdFk))]
        public virtual AppFile File { get; set; }

        public bool Equals(FileComments other)
        {
            return this.Comment == other.Comment &&
                this.FileIdFk == other.FileIdFk;
        }
    }
}
