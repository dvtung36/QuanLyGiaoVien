namespace QuanLyGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TTGIANGDAY")]
    public partial class TTGIANGDAY
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaGV { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLop { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDT { get; set; }

        public int? SoTiet { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKT { get; set; }

        public int? GioChuan { get; set; }

        public DateTime? ThoiDiemSua { get; set; }

        public virtual DOITUONGGD DOITUONGGD { get; set; }

        public virtual GIAOVIEN GIAOVIEN { get; set; }

        public virtual LOP LOP { get; set; }
    }
}
