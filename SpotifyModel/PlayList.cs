namespace SpotifyModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlayList")]
    public partial class PlayList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlayList()
        {
            comment = new HashSet<comment>();
            PlayListDetails = new HashSet<PlayListDetails>();
        }

        [Key]
        public int ListId { get; set; }

        public int UserId { get; set; }

        [Column(TypeName = "text")]
        public string ListContent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment> comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayListDetails> PlayListDetails { get; set; }

        public virtual User User { get; set; }
    }
}
