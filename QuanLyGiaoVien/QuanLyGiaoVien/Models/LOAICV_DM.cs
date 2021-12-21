namespace QuanLyGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOAICV_DM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAICV_DM()
        {
            CONGVIECs = new HashSet<CONGVIEC>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLoaiCV { get; set; }

        [StringLength(100)]
        public string TenLoaiCV { get; set; }

        public int? DonViTinh { get; set; }

        public int? QRGioChuan { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONGVIEC> CONGVIECs { get; set; }
    }
}
