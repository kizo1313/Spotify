namespace SpotifyModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            comment = new HashSet<comment>();
            PlaybackRecord = new HashSet<PlaybackRecord>();
            PlayList = new HashSet<PlayList>();
            Singer = new HashSet<Singer>();
            VipRecord = new HashSet<VipRecord>();
        }

        public int UserId { get; set; }

        [Required]
        [StringLength(20)]
        public string UserName { get; set; }

        [Required]
        [StringLength(20)]
        public string Account { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        [Required]
        [StringLength(11)]
        public string Telephone { get; set; }

        [StringLength(50)]
        public string Signature { get; set; }

        public int Age { get; set; }

        [StringLength(50)]
        public string Portrait { get; set; }

        public int IdentityId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment> comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlaybackRecord> PlaybackRecord { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayList> PlayList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Singer> Singer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VipRecord> VipRecord { get; set; }
    }
}
