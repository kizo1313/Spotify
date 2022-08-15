namespace SpotifyModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MusicType")]
    public partial class MusicType
    {
        [Key]
        public int TypeId { get; set; }

        [Required]
        [StringLength(50)]
        public string MusicId { get; set; }

        [Required]
        [StringLength(3)]
        public string TypeName { get; set; }

        [Required]
        [StringLength(20)]
        public string Extension { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string MusicFile { get; set; }

        public virtual Music Music { get; set; }
    }
}
