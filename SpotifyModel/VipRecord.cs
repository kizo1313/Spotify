namespace SpotifyModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VipRecord")]
    public partial class VipRecord
    {
        [Key]
        public int RecordId { get; set; }

        public int UserId { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }

        public virtual User User { get; set; }
    }
}
