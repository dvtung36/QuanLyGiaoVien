namespace QuanLyGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TTCHUCVUCQ")]
    public partial class TTCHUCVUCQ
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCVCQ { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaGV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKT { get; set; }

        public virtual CHUCVUCQ CHUCVUCQ { get; set; }

        public virtual GIAOVIEN GIAOVIEN { get; set; }
    }
}
