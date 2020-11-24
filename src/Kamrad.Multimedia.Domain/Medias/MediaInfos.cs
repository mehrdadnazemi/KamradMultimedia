using Kamrad.Multimedia.Files;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;

namespace Kamrad.Multimedia.Medias
{
    public class MediaInfos:Entity<int>
    {
        public MediaInfos()
        {
            Files = new HashSet<AppFile>();
            MediaInfoFileParticipants = new HashSet<MediaInfoFileParticipants>();
        }
        public string Actors { get; set; }
        public string Author { get; set; }
        public string CameraMan { get; set; }
        public string CameraModel { get; set; }
        public string Compositor { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string Director { get; set; }
        public string Editor { get; set; }
        public int? MediaEventIdFk { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public string MediaName { get; set; }
        public int NumberOfRowsAndArchive { get; set; }
        public string Orator { get; set; }
        public int? ParticipantIdFk { get; set; }
        public string Photographer { get; set; }
        public string Place { get; set; }
        public string Producer { get; set; }
        public int Rate { get; set; }
        public string Studio { get; set; }
        public int ThematicCategoryIdFk { get; set; }
        public string Title { get; set; }
        public int UserIdFk { get; set; }
        public int? GenreIdFk { get; set; }
        public int? ParticipantsId { get; set; }
        public string Tags { get; set; }
        public int? MediaInfoIdFk { get; set; }
        [ForeignKey(nameof(MediaEventIdFk))]
        public virtual MediaEvents MediaEvent { get; set; }
        [ForeignKey(nameof(GenreIdFk))]
        public virtual Genres Genre { get; set; }
        [ForeignKey(nameof(ParticipantIdFk))]
        public virtual Participants Participant { get; set; }
        [ForeignKey(nameof(ThematicCategoryIdFk))]
        public virtual ThematicCategories ThematicCategory { get; set; }
        public virtual ICollection<AppFile> Files { get; set; }
        public virtual ICollection<MediaInfoFileParticipants> MediaInfoFileParticipants { get; set; }
    }
}
