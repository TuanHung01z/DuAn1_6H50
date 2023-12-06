using System;
using System.Collections.Generic;
using DAL1.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DAL1.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DaoDien> DaoDiens { get; set; }

    public virtual DbSet<DichVu> DichVus { get; set; }

    public virtual DbSet<DienVien> DienViens { get; set; }

    public virtual DbSet<Ghe> Ghes { get; set; }

    public virtual DbSet<HangGhe> HangGhes { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<LichChieu> LichChieus { get; set; }

    public virtual DbSet<Phim> Phims { get; set; }

    public virtual DbSet<PhongChieu> PhongChieus { get; set; }

    public virtual DbSet<TheLoai> TheLoais { get; set; }

    public virtual DbSet<ThongKe> ThongKes { get; set; }

    public virtual DbSet<Ve> Ves { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source= DESKTOP-JEL1AQM\\MSSQLSERVER1 ;Initial Catalog= Moviet_Fixed;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DaoDien>(entity =>
        {
            entity.HasKey(e => e.MaDaoDien).HasName("PK__DaoDien__F57FCFF4FD280D00");

            entity.Property(e => e.MaDaoDien).IsFixedLength();
        });

        modelBuilder.Entity<DichVu>(entity =>
        {
            entity.HasKey(e => e.MaDichVu).HasName("PK__DichVu__C0E6DE8F52EB8B1C");

            entity.Property(e => e.MaDichVu).IsFixedLength();
        });

        modelBuilder.Entity<DienVien>(entity =>
        {
            entity.HasKey(e => e.MaDienVien).HasName("PK__DienVien__28BD9B0C267A69AD");

            entity.Property(e => e.MaDienVien).IsFixedLength();
        });

        modelBuilder.Entity<Ghe>(entity =>
        {
            entity.HasKey(e => e.MaGhe).HasName("PK__Ghe__3CD3C67BB185B924");

            entity.Property(e => e.MaGhe).IsFixedLength();

            entity.HasOne(d => d.MaHangGheNavigation).WithMany(p => p.Ghes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ghe__MaHangGhe__145C0A3F");
        });

        modelBuilder.Entity<HangGhe>(entity =>
        {
            entity.HasKey(e => e.MaHangGhe).HasName("PK__HangGhe__9774DC5310386A8B");

            entity.Property(e => e.MaHangGhe).ValueGeneratedNever();
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHoaDon).HasName("PK__HoaDon__835ED13BCC07B25F");

            entity.Property(e => e.MaHoaDon).IsFixedLength();
            entity.Property(e => e.MaVoucher).IsFixedLength();
            entity.Property(e => e.SdtkhachHang).IsFixedLength();

            entity.HasOne(d => d.MaVoucherNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaVouche__2C3393D0");

            entity.HasOne(d => d.SdtkhachHangNavigation).WithMany(p => p.HoaDons)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDon__SDTKhach__2B3F6F97");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => e.MaHoaDonChiTiet).HasName("PK__HoaDonCh__6C2FD0CE59914F1D");

            entity.Property(e => e.MaHoaDonChiTiet).IsFixedLength();
            entity.Property(e => e.MaDichVu).IsFixedLength();
            entity.Property(e => e.MaHoaDon).IsFixedLength();
            entity.Property(e => e.MaVe).IsFixedLength();

            entity.HasOne(d => d.MaDichVuNavigation).WithMany(p => p.HoaDonChiTiets).HasConstraintName("FK__HoaDonChi__MaDic__36B12243");

            entity.HasOne(d => d.MaHoaDonNavigation).WithMany(p => p.HoaDonChiTiets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDonChi__MaHoa__34C8D9D1");

            entity.HasOne(d => d.MaVeNavigation).WithMany(p => p.HoaDonChiTiets).HasConstraintName("FK__HoaDonChiT__MaVe__35BCFE0A");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.SdtkhachHang).HasName("PK__KhachHan__C87280B115C192EB");

            entity.Property(e => e.SdtkhachHang).IsFixedLength();
        });

        modelBuilder.Entity<LichChieu>(entity =>
        {
            entity.HasKey(e => e.MaLichChieu).HasName("PK__LichChie__DC740197D90B0DAF");

            entity.Property(e => e.MaLichChieu).IsFixedLength();
            entity.Property(e => e.MaPhim).IsFixedLength();

            entity.HasOne(d => d.MaPhimNavigation).WithMany(p => p.LichChieus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LichChieu__MaPhi__276EDEB3");

            entity.HasOne(d => d.MaPhongChieuNavigation).WithMany(p => p.LichChieus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LichChieu__MaPho__286302EC");
        });

        modelBuilder.Entity<Phim>(entity =>
        {
            entity.HasKey(e => e.MaPhim).HasName("PK__Phim__4AC03DE332E0A9F6");

            entity.Property(e => e.MaPhim).IsFixedLength();
            entity.Property(e => e.MaDaoDien).IsFixedLength();
            entity.Property(e => e.MaDienVien).IsFixedLength();
            entity.Property(e => e.MaTheLoai).IsFixedLength();
            entity.Property(e => e.Rated).IsFixedLength();

            entity.HasOne(d => d.MaDaoDienNavigation).WithMany(p => p.Phims)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Phim__MaDaoDien__21B6055D");

            entity.HasOne(d => d.MaDienVienNavigation).WithMany(p => p.Phims)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Phim__MaDienVien__22AA2996");

            entity.HasOne(d => d.MaTheLoaiNavigation).WithMany(p => p.Phims)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Phim__MaTheLoai__20C1E124");
        });

        modelBuilder.Entity<PhongChieu>(entity =>
        {
            entity.HasKey(e => e.MaPhongChieu).HasName("PK__PhongChi__121FC6E23C2C5F1C");
        });

        modelBuilder.Entity<TheLoai>(entity =>
        {
            entity.HasKey(e => e.MaTheLoai).HasName("PK__TheLoai__D73FF34AAABFF69E");

            entity.Property(e => e.MaTheLoai).IsFixedLength();
        });

        modelBuilder.Entity<ThongKe>(entity =>
        {
            entity.HasKey(e => e.MaThongKe).HasName("PK__ThongKe__60E521F4A7E75E52");

            entity.Property(e => e.MaThongKe).IsFixedLength();
        });

        modelBuilder.Entity<Ve>(entity =>
        {
            entity.HasKey(e => e.MaVe).HasName("PK__Ve__2725100FFEAAB85E");

            entity.Property(e => e.MaVe).IsFixedLength();
            entity.Property(e => e.MaGhe).IsFixedLength();
            entity.Property(e => e.MaLichChieu).IsFixedLength();
            entity.Property(e => e.MaPhim).IsFixedLength();

            entity.HasOne(d => d.MaGheNavigation).WithMany(p => p.Ves)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ve__MaGhe__30F848ED");

            entity.HasOne(d => d.MaLichChieuNavigation).WithMany(p => p.Ves)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ve__MaLichChieu__31EC6D26");

            entity.HasOne(d => d.MaPhimNavigation).WithMany(p => p.Ves)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ve__MaPhim__2F10007B");

            entity.HasOne(d => d.MaPhongChieuNavigation).WithMany(p => p.Ves)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ve__MaPhongChieu__300424B4");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.MaVoucher).HasName("PK__Voucher__0AAC5B1131511D7A");

            entity.Property(e => e.MaVoucher).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
