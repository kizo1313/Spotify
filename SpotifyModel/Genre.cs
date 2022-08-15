namespace SpotifyModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Genre")]
    public partial class Genre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Genre()
        {
            Album = new HashSet<Album>();
            Music = new HashSet<Music>();
        }

        public int GenreId { get; set; }

        [StringLength(10)]
        public string EnglishName { get; set; }

        [StringLength(10)]
        public string ChineseName { get; set; }

        [Column(TypeName = "text")]
        public string GenreContent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Album> Album { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Music> Music { get; set; }
    }
}
