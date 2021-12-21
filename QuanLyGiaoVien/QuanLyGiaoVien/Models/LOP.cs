namespace QuanLyGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOP")]
    public partial class LOP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOP()
        {
            TTGIANGDAYs = new HashSet<TTGIANGDAY>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLop { get; set; }

        public int? MaHP { get; set; }

        [StringLength(50)]
        public string TenLop { get; set; }

        public int? SiSo { get; set; }

        public int? HocKy { get; set; }

        [StringLength(20)]
        public string NamHoc { get; set; }

        [StringLength(10)]
        public string He { get; set; }

        public virtual HOCPHAN HOCPHAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TTGIANGDAY> TTGIANGDAYs { get; set; }
    }
}
