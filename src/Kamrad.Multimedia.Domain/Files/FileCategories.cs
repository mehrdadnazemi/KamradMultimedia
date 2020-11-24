using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace Kamrad.Multimedia.Files
{
    public class FileCategories : Entity<int>, IEquatable<FileCategories>
    {
        public FileCategories()
        {
            FileTypes = new HashSet<FileTypes>();
        }
        public string CategoryName { get; set; }
        public string ContentType { get; set; }
        public double? MaxLength { get; set; }

        public virtual ICollection<FileTypes> FileTypes { get; set; }

        public bool Equals(FileCategories other)
        {
            return string.Equals(this.CategoryName.Trim(), other.CategoryName.Trim(),
                StringComparison.OrdinalIgnoreCase);
        }
    }
}
