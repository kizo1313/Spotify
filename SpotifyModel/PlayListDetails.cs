namespace SpotifyModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PlayListDetails
    {
        [Key]
        public int DetailsId { get; set; }

        public int ListId { get; set; }

        [Required]
        [StringLength(50)]
        public string MusicId { get; set; }

        public virtual Music Music { get; set; }

        public virtual PlayList PlayList { get; set; }
    }
}
