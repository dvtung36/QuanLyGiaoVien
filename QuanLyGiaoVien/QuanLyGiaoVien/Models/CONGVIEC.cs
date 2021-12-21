namespace QuanLyGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONGVIEC")]
    public partial class CONGVIEC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONGVIEC()
        {
            CTCONGVIECs = new HashSet<CTCONGVIEC>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCV { get; set; }

        public int? MaLoaiCV { get; set; }

        [StringLength(100)]
        public string TenCV { get; set; }

        public int? SoLuongCV { get; set; }

        [StringLength(50)]
        public string DonVi { get; set; }

        public int? SoLuongTG { get; set; }

        [StringLength(50)]
        public string VaiTro { get; set; }

        public virtual LOAICV_DM LOAICV_DM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTCONGVIEC> CTCONGVIECs { get; set; }
    }
}
