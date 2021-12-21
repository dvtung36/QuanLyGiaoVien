namespace QuanLyGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHUCDANHCMNV")]
    public partial class CHUCDANHCMNV
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUCDANHCMNV()
        {
            TTCDCMNVs = new HashSet<TTCDCMNV>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCDCMNV { get; set; }

        [StringLength(50)]
        public string TenCDCMNV { get; set; }

        public int? MaDM { get; set; }

        public virtual DINHMUC DINHMUC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTCDCMNV> TTCDCMNVs { get; set; }
    }
}
