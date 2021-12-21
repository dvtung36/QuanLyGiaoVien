namespace QuanLyGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOCHAM")]
    public partial class HOCHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOCHAM()
        {
            TTHOCHAMs = new HashSet<TTHOCHAM>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHH { get; set; }

        [StringLength(50)]
        public string TenHH { get; set; }

        public int? MaDM { get; set; }

        public virtual DINHMUC DINHMUC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTHOCHAM> TTHOCHAMs { get; set; }
    }
}
