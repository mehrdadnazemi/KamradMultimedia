using Kamrad.Multimedia.Medias;
using System;
using System.Collections.Generic;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Kamrad.Multimedia.Files
{
    public partial class AppFile: Entity<long>, IAuditedObject
    {
        public AppFile()
        {
            FileComments = new HashSet<FileComments>();
            FileUserLikes = new HashSet<FileUserLike>();
            MediaInfoFileParticipants = new HashSet<MediaInfoFileParticipants>();
        }
        public double Duration { get; set; }
        public string FileName { get; set; }
        public long FileSize { get; set; }
        public int FileTypeFk { get; set; }
        public byte[] Img { get; set; }
        public string MediaAddress { get; set; }
        public int MediaInfoFk { get; set; }
        public string Tag { get; set; }
        public long Like { get; set; }
        public long Visit { get; set; }
        public int? FileTypeId { get; set; }
        public int? ParticipantsId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Place { get; set; }
        public string ShortKey { get; set; }

        public virtual FileTypes FileType { get; set; }
        public virtual MediaInfos MediaInfoFkNavigation { get; set; }
        public virtual ICollection<FileComments> FileComments { get; set; }
        public virtual ICollection<FileUserLike> FileUserLikes { get; set; }
        public virtual ICollection<MediaInfoFileParticipants> MediaInfoFileParticipants { get; set; }
        public DateTime CreationTime { get; set; }
        public Guid? CreatorId { get; set; }
        public Guid? LastModifierId { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}
