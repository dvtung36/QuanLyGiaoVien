namespace QuanLyGiaoVien.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<BOMON> BOMONs { get; set; }
        public virtual DbSet<CHUCDANHCMNV> CHUCDANHCMNVs { get; set; }
        public virtual DbSet<CHUCVUCQ> CHUCVUCQs { get; set; }
        public virtual DbSet<CHUCVUDANG> CHUCVUDANGs { get; set; }
        public virtual DbSet<CONGVIEC> CONGVIECs { get; set; }
        public virtual DbSet<CTCONGVIEC> CTCONGVIECs { get; set; }
        public virtual DbSet<DINHMUC> DINHMUCs { get; set; }
        public virtual DbSet<DOITUONGGD> DOITUONGGDs { get; set; }
        public virtual DbSet<DOITUONGMIENGIAM> DOITUONGMIENGIAMs { get; set; }
        public virtual DbSet<GIAOVIEN> GIAOVIENs { get; set; }
        public virtual DbSet<HOCHAM> HOCHAMs { get; set; }
        public virtual DbSet<HOCPHAN> HOCPHANs { get; set; }
        public virtual DbSet<HOCVI> HOCVIs { get; set; }
        public virtual DbSet<KHOA> KHOAs { get; set; }
        public virtual DbSet<LOAICV_DM> LOAICV_DM { get; set; }
        public virtual DbSet<LOAIHP_DM> LOAIHP_DM { get; set; }
        public virtual DbSet<LOP> LOPs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TTCDCMNV> TTCDCMNVs { get; set; }
        public virtual DbSet<TTCHUCVUCQ> TTCHUCVUCQs { get; set; }
        public virtual DbSet<TTCHUCVUDANG> TTCHUCVUDANGs { get; set; }
        public virtual DbSet<TTGIANGDAY> TTGIANGDAYs { get; set; }
        public virtual DbSet<TTHOCHAM> TTHOCHAMs { get; set; }
        public virtual DbSet<TTHOCVI> TTHOCVIs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHUCDANHCMNV>()
                .HasMany(e => e.TTCDCMNVs)
                .WithRequired(e => e.CHUCDANHCMNV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHUCVUCQ>()
                .HasMany(e => e.TTCHUCVUCQs)
                .WithRequired(e => e.CHUCVUCQ)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHUCVUDANG>()
                .HasMany(e => e.TTCHUCVUDANGs)
                .WithRequired(e => e.CHUCVUDANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONGVIEC>()
                .HasMany(e => e.CTCONGVIECs)
                .WithRequired(e => e.CONGVIEC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOITUONGGD>()
                .HasMany(e => e.TTGIANGDAYs)
                .WithRequired(e => e.DOITUONGGD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GIAOVIEN>()
                .HasMany(e => e.CTCONGVIECs)
                .WithRequired(e => e.GIAOVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GIAOVIEN>()
                .HasMany(e => e.TTCDCMNVs)
                .WithRequired(e => e.GIAOVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GIAOVIEN>()
                .HasMany(e => e.TTCHUCVUCQs)
                .WithRequired(e => e.GIAOVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GIAOVIEN>()
                .HasMany(e => e.TTCHUCVUDANGs)
                .WithRequired(e => e.GIAOVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GIAOVIEN>()
                .HasMany(e => e.TTGIANGDAYs)
                .WithRequired(e => e.GIAOVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GIAOVIEN>()
                .HasMany(e => e.TTHOCHAMs)
                .WithRequired(e => e.GIAOVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GIAOVIEN>()
                .HasMany(e => e.TTHOCVIs)
                .WithRequired(e => e.GIAOVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOCHAM>()
                .HasMany(e => e.TTHOCHAMs)
                .WithRequired(e => e.HOCHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOCVI>()
                .HasMany(e => e.TTHOCVIs)
                .WithRequired(e => e.HOCVI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOP>()
                .HasMany(e => e.TTGIANGDAYs)
                .WithRequired(e => e.LOP)
                .WillCascadeOnDelete(false);
        }
    }
}
