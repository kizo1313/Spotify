namespace SpotifyModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Resources
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Resources()
        {
            Authority = new HashSet<Authority>();
        }

        public int ResourcesId { get; set; }

        [Required]
        [StringLength(50)]
        public string TableName { get; set; }

        [Required]
        [StringLength(50)]
        public string ChineseTableName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Authority> Authority { get; set; }
    }
}
