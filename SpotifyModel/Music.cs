namespace SpotifyModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Music")]
    public partial class Music
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Music()
        {
            comment = new HashSet<comment>();
            MusicType = new HashSet<MusicType>();
            PlaybackRecord = new HashSet<PlaybackRecord>();
            PlayListDetails = new HashSet<PlayListDetails>();
        }

        [StringLength(50)]
        public string MusicId { get; set; }

        [Required]
        [StringLength(50)]
        public string MusicName { get; set; }

        public int AlbumId { get; set; }

        public int? GenreId { get; set; }

        public int SingerId { get; set; }

        [StringLength(50)]
        public string Cover { get; set; }

        public TimeSpan Duration { get; set; }

        [StringLength(50)]
        public string Lyricist { get; set; }

        [StringLength(50)]
        public string Composer { get; set; }

        [StringLength(50)]
        public string Arranger { get; set; }

        [StringLength(50)]
        public string Producer { get; set; }

        [StringLength(50)]
        public string Publisher { get; set; }

        [StringLength(50)]
        public string CopyrightOwner { get; set; }

        [Column(TypeName = "text")]
        public string Lyric { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReleaseTime { get; set; }

        public decimal? Price { get; set; }

        [Required]
        [StringLength(1)]
        public string VipMusic { get; set; }

        public int Popularity { get; set; }

        [Required]
        [StringLength(3)]
        public string Audit { get; set; }

        public virtual Album Album { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment> comment { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual Singer Singer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MusicType> MusicType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlaybackRecord> PlaybackRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayListDetails> PlayListDetails { get; set; }
    }
}
