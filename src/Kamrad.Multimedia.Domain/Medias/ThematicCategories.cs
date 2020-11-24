using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Kamrad.Multimedia.Medias
{
    public partial class ThematicCategories:Entity<int>, IEquatable<ThematicCategories>
    {
        public ThematicCategories()
        {
            ThematicCategoriesNavigation = new HashSet<ThematicCategories>();
            MediaInfos = new HashSet<MediaInfos>();
        }
        public string ThematicCategorieName { get; set; }
        public int? ThematicCategorieIdFk { get; set; }
        [ForeignKey(nameof(ThematicCategorieIdFk))]

        public virtual ThematicCategories ThematicCategory { get; set; }

        public virtual ICollection<ThematicCategories> ThematicCategoriesNavigation { get; set; }
        public virtual ICollection<MediaInfos> MediaInfos { get; set; }

        public bool Equals(ThematicCategories other)
        {
            return this.ThematicCategorieName == other.ThematicCategorieName;
        }
    }
}
