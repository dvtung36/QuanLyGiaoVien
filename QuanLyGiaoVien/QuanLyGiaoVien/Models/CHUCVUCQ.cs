namespace QuanLyGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHUCVUCQ")]
    public partial class CHUCVUCQ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUCVUCQ()
        {
            TTCHUCVUCQs = new HashSet<TTCHUCVUCQ>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCVCQ { get; set; }

        [StringLength(100)]
        public string TenCVCQ { get; set; }

        public int? MaDTMG { get; set; }

        public virtual DOITUONGMIENGIAM DOITUONGMIENGIAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTCHUCVUCQ> TTCHUCVUCQs { get; set; }
    }
}
