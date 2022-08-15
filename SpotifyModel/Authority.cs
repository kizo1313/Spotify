namespace SpotifyModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Authority")]
    public partial class Authority
    {
        public int AuthorityId { get; set; }

        public int IdentityId { get; set; }

        public int OperationId { get; set; }

        public int ResourcesId { get; set; }

        [Column("Authority")]
        [Required]
        [StringLength(3)]
        public string Authority1 { get; set; }

        public virtual Identity Identity { get; set; }

        public virtual Operation Operation { get; set; }

        public virtual Resources Resources { get; set; }
    }
}
