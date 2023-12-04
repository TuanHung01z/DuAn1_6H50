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
        => optionsBuilder.UseSqlServer("Data Source= DESKTOP-JEL1AQM\\MSSQLSERVER1 ;Initial Catalog= Moviet;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DaoDien>(entity =>
        {
            entity.HasKey(e => e.MaDaoDien).HasName("PK__DaoDien__F57FCFF45482C8F0");

            entity.Property(e => e.MaDaoDien).IsFixedLength();
        });

        modelBuilder.Entity<DichVu>(entity =>
        {
            entity.HasKey(e => e.MaDichVu).HasName("PK__DichVu__C0E6DE8F7799A80E");

            entity.Property(e => e.MaDichVu).IsFixedLength();
        });

        modelBuilder.Entity<DienVien>(entity =>
        {
            entity.HasKey(e => e.MaDienVien).HasName("PK__DienVien__28BD9B0CD953425F");

            entity.Property(e => e.MaDienVien).IsFixedLength();
        });

        modelBuilder.Entity<Ghe>(entity =>
        {
            entity.HasKey(e => e.MaGhe).HasName("PK__Ghe__3CD3C67B91CE5E3D");

            entity.Property(e => e.MaGhe).IsFixedLength();
            entity.Property(e => e.HangGhe).IsFixedLength();
            entity.Property(e => e.MaPhongChieu).IsFixedLength();

            entity.HasOne(d => d.MaPhongChieuNavigation).WithMany(p => p.Ghes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ghe__MaPhongChie__29572725");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHoaDon).HasName("PK__HoaDon__835ED13BC5D63D0C");

            entity.Property(e => e.MaHoaDon).IsFixedLength();
            entity.Property(e => e.MaKhachHang).IsFixedLength();
            entity.Property(e => e.MaVoucher).IsFixedLength();

            entity.HasOne(d => d.MaKhachHangNavigation).WithMany(p => p.HoaDons)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDon__MaKhachH__2B3F6F97");

            entity.HasOne(d => d.MaVoucherNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaVouche__2A4B4B5E");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => e.MaHoaDonChiTiet).HasName("PK__HoaDonCh__6C2FD0CE7FE01491");

            entity.Property(e => e.MaHoaDonChiTiet).IsFixedLength();
            entity.Property(e => e.MaDichVu).IsFixedLength();
            entity.Property(e => e.MaHoaDon).IsFixedLength();
            entity.Property(e => e.MaVe).IsFixedLength();

            entity.HasOne(d => d.MaDichVuNavigation).WithMany(p => p.HoaDonChiTiets).HasConstraintName("FK__HoaDonChi__MaDic__2C3393D0");

            entity.HasOne(d => d.MaHoaDonNavigation).WithMany(p => p.HoaDonChiTiets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDonChi__MaHoa__2D27B809");

            entity.HasOne(d => d.MaVeNavigation).WithMany(p => p.HoaDonChiTiets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDonChiT__MaVe__2E1BDC42");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKhachHang).HasName("PK__KhachHan__88D2F0E57619BCAF");

            entity.Property(e => e.MaKhachHang).IsFixedLength();
            entity.Property(e => e.SdtkhachHang).IsFixedLength();
        });

        modelBuilder.Entity<LichChieu>(entity =>
        {
            entity.HasKey(e => e.MaLichChieu).HasName("PK__LichChie__DC74019717C8168A");

            entity.Property(e => e.MaLichChieu).IsFixedLength();
            entity.Property(e => e.MaPhim).IsFixedLength();
            entity.Property(e => e.MaPhongChieu).IsFixedLength();

            entity.HasOne(d => d.MaPhimNavigation).WithMany(p => p.LichChieus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LichChieu__MaPhi__2F10007B");

            entity.HasOne(d => d.MaPhongChieuNavigation).WithMany(p => p.LichChieus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LichChieu__MaPho__300424B4");
        });

        modelBuilder.Entity<Phim>(entity =>
        {
            entity.HasKey(e => e.MaPhim).HasName("PK__Phim__4AC03DE324B56C15");

            entity.Property(e => e.MaPhim).IsFixedLength();
            entity.Property(e => e.MaDaoDien).IsFixedLength();
            entity.Property(e => e.MaDienVien).IsFixedLength();
            entity.Property(e => e.MaTheLoai).IsFixedLength();
            entity.Property(e => e.Rated).IsFixedLength();

            entity.HasOne(d => d.MaDaoDienNavigation).WithMany(p => p.Phims)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Phim__MaDaoDien__30F848ED");

            entity.HasOne(d => d.MaDienVienNavigation).WithMany(p => p.Phims)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Phim__MaDienVien__31EC6D26");

            entity.HasOne(d => d.MaTheLoaiNavigation).WithMany(p => p.Phims)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Phim__MaTheLoai__32E0915F");
        });

        modelBuilder.Entity<PhongChieu>(entity =>
        {
            entity.HasKey(e => e.MaPhongChieu).HasName("PK__PhongChi__121FC6E2F5CE2161");

            entity.Property(e => e.MaPhongChieu).IsFixedLength();
        });

        modelBuilder.Entity<TheLoai>(entity =>
        {
            entity.HasKey(e => e.MaTheLoai).HasName("PK__TheLoai__D73FF34A7D38C3E5");

            entity.Property(e => e.MaTheLoai).IsFixedLength();
        });

        modelBuilder.Entity<ThongKe>(entity =>
        {
            entity.HasKey(e => e.MaThongKe).HasName("PK__ThongKe__60E521F4B16A78E3");

            entity.Property(e => e.MaThongKe).IsFixedLength();
        });

        modelBuilder.Entity<Ve>(entity =>
        {
            entity.HasKey(e => e.MaVe).HasName("PK__Ve__2725100F542B0E4E");

            entity.Property(e => e.MaVe).IsFixedLength();
            entity.Property(e => e.MaGhe).IsFixedLength();
            entity.Property(e => e.MaLichChieu).IsFixedLength();
            entity.Property(e => e.MaPhim).IsFixedLength();
            entity.Property(e => e.MaPhongChieu).IsFixedLength();

            entity.HasOne(d => d.MaGheNavigation).WithMany(p => p.Ves)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ve__MaGhe__33D4B598");

            entity.HasOne(d => d.MaLichChieuNavigation).WithMany(p => p.Ves)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ve__MaLichChieu__34C8D9D1");

            entity.HasOne(d => d.MaPhimNavigation).WithMany(p => p.Ves)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ve__MaPhim__35BCFE0A");

            entity.HasOne(d => d.MaPhongChieuNavigation).WithMany(p => p.Ves)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ve__MaPhongChieu__36B12243");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.MaVoucher).HasName("PK__Voucher__0AAC5B11DAD365D9");

            entity.Property(e => e.MaVoucher).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
