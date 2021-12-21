namespace QuanLyGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TTCDCMNV")]
    public partial class TTCDCMNV
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCDCMNV { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaGV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBD { get; set; }

        [StringLength(100)]
        public string DonViHD { get; set; }

        public virtual CHUCDANHCMNV CHUCDANHCMNV { get; set; }

        public virtual GIAOVIEN GIAOVIEN { get; set; }
    }
}
