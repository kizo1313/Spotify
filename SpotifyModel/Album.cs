namespace SpotifyModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Album")]
    public partial class Album
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Album()
        {
            comment = new HashSet<comment>();
            Music = new HashSet<Music>();
        }

        public int AlbumId { get; set; }

        [Required]
        [StringLength(50)]
        public string AlbumName { get; set; }

        [Required]
        [StringLength(20)]
        public string Languages { get; set; }

        [Required]
        [StringLength(50)]
        public string Cover { get; set; }

        public int? GenreId { get; set; }

        public int SingerId { get; set; }

        [StringLength(50)]
        public string Publisher { get; set; }

        [StringLength(50)]
        public string CopyrightOwner { get; set; }

        [Column(TypeName = "text")]
        public string AlbumContent { get; set; }

        public decimal? Price { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual Singer Singer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment> comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Music> Music { get; set; }
    }
}
