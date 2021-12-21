namespace QuanLyGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOITUONGMIENGIAM")]
    public partial class DOITUONGMIENGIAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOITUONGMIENGIAM()
        {
            CHUCVUCQs = new HashSet<CHUCVUCQ>();
            CHUCVUDANGs = new HashSet<CHUCVUDANG>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDTMG { get; set; }

        public int? TiLeMG { get; set; }

        [StringLength(100)]
        public string TenDTMG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUCVUCQ> CHUCVUCQs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUCVUDANG> CHUCVUDANGs { get; set; }
    }
}
