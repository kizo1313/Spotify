namespace SpotifyModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("comment")]
    public partial class comment
    {
        public int CommentId { get; set; }

        public int? AlbumId { get; set; }

        [StringLength(50)]
        public string MusicId { get; set; }

        public int? ListId { get; set; }

        public int? UserId { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReleaseDate { get; set; }

        [Column(TypeName = "text")]
        public string Content { get; set; }

        public int likes { get; set; }

        public virtual Album Album { get; set; }

        public virtual Music Music { get; set; }

        public virtual PlayList PlayList { get; set; }

        public virtual User User { get; set; }
    }
}
