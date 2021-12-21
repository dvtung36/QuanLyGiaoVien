namespace QuanLyGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHUCVUDANG")]
    public partial class CHUCVUDANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUCVUDANG()
        {
            TTCHUCVUDANGs = new HashSet<TTCHUCVUDANG>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCVD { get; set; }

        [StringLength(100)]
        public string TenCVD { get; set; }

        public int? MaDTMG { get; set; }

        public virtual DOITUONGMIENGIAM DOITUONGMIENGIAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTCHUCVUDANG> TTCHUCVUDANGs { get; set; }
    }
}
