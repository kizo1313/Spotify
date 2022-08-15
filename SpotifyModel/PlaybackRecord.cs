namespace SpotifyModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlaybackRecord")]
    public partial class PlaybackRecord
    {
        [Key]
        public int RecordId { get; set; }

        [Required]
        [StringLength(50)]
        public string MusicId { get; set; }

        public int UserId { get; set; }

        public DateTime PlayTime { get; set; }

        public virtual Music Music { get; set; }

        public virtual User User { get; set; }
    }
}
