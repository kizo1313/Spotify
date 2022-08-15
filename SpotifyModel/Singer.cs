namespace SpotifyModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Singer")]
    public partial class Singer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Singer()
        {
            Album = new HashSet<Album>();
            Music = new HashSet<Music>();
        }

        public int SingerId { get; set; }

        [Required]
        [StringLength(50)]
        public string SingerName { get; set; }

        [Required]
        [StringLength(50)]
        public string Portrait { get; set; }

        [Required]
        [StringLength(50)]
        public string Cover { get; set; }

        [StringLength(50)]
        public string SingerContent { get; set; }

        public int? UserId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Album> Album { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Music> Music { get; set; }

        public virtual User User { get; set; }
    }
}
