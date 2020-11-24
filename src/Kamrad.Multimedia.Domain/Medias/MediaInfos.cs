using Kamrad.Multimedia.Files;
using System;
using System.Collections.Generic;

namespace Kamrad.Multimedia.Medias
{
    public class MediaInfos
    {
        public MediaInfos()
        {
            Files = new HashSet<AppFile>();
            MediaInfoFileParticipants = new HashSet<MediaInfoFileParticipants>();
            //MediaUserGroups = new HashSet<MediaUserGroups>();
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
        public int? EventIdFk { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public string MediaName { get; set; }
        public int NumberOfRowsAndArchive { get; set; }
        public string Orator { get; set; }
        public int? ParticipantFk { get; set; }
        public string Photographer { get; set; }
        public string Place { get; set; }
        public string Producer { get; set; }
        public int Rate { get; set; }
        public string Studio { get; set; }
        public int ThematicCategoryFk { get; set; }
        public string Title { get; set; }
        public int UserIdFk { get; set; }
        public int? GenreIdFk { get; set; }
        public int? ParticipantsId { get; set; }
        public string Tags { get; set; }
        public int? MediaInfoIdFk { get; set; }

        public virtual Events EventIdFkNavigation { get; set; }
        public virtual Genres GenreIdFkNavigation { get; set; }
        public virtual Participants ParticipantFkNavigation { get; set; }
        public virtual ThematicCategories ThematicCategoryFkNavigation { get; set; }
        //public virtual UmUsers UserIdFkNavigation { get; set; }
        public virtual ICollection<AppFile> Files { get; set; }
        public virtual ICollection<MediaInfoFileParticipants> MediaInfoFileParticipants { get; set; }
        //public virtual ICollection<MediaUserGroups> MediaUserGroups { get; set; }
    }
}
