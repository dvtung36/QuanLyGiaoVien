namespace QuanLyGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DINHMUC")]
    public partial class DINHMUC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DINHMUC()
        {
            CHUCDANHCMNVs = new HashSet<CHUCDANHCMNV>();
            HOCHAMs = new HashSet<HOCHAM>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDM { get; set; }

        [StringLength(50)]
        public string TenDM { get; set; }

        public int? DMgioNC { get; set; }

        public int? DMgioMC { get; set; }

        public int? DMgioMTC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUCDANHCMNV> CHUCDANHCMNVs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOCHAM> HOCHAMs { get; set; }
    }
}
