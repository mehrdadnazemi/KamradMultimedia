using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Kamrad.Multimedia.Files
{
    public partial class FileTypes: Entity<int>, IEquatable<FileTypes>
    {
        public FileTypes()
        {
            Files = new HashSet<AppFile>();
        }
        public int FileCategoryFk { get; set; }
        public string FileExtension { get; set; }
        public string FileMimeType { get; set; }
        [ForeignKey(nameof(FileCategoryFk))]
        public virtual FileCategories FileCategories { get; set; }
        public virtual ICollection<AppFile> Files { get; set; }

        public bool Equals(FileTypes other)
        {
            return this.FileCategoryFk == other.FileCategoryFk
                && this.FileExtension == other.FileExtension
                && this.FileMimeType == other.FileMimeType;
        }
    }
}
