using Kamrad.Multimedia.Files;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace Kamrad.Multimedia.Medias
{
    public partial class MediaInfoFileParticipants:Entity<int>
    {
        public int? MediaInfoIdFk { get; set; }
        public int? FileIdFk { get; set; }
        public int ParticipantIdFk { get; set; }

        public virtual AppFile File { get; set; }
        public virtual MediaInfos MediaInfo { get; set; }
        public virtual Participants Participant { get; set; }
    }
}
