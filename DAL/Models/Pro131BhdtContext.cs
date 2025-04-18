using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class Pro131BhdtContext : DbContext
{
    public Pro131BhdtContext()
    {
    }

    public Pro131BhdtContext(DbContextOptions<Pro131BhdtContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }

    public virtual DbSet<DoiDiemLayVoucher> DoiDiemLayVouchers { get; set; }

    public virtual DbSet<HinhThucThanhToan> HinhThucThanhToans { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }

    public virtual DbSet<LichSuThanhToan> LichSuThanhToans { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ITS-MY;Initial Catalog=Pro131_QLPM;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietHoaDon>(entity =>
        {
            entity.HasKey(e => e.MaChiTiet).HasName("PK__ChiTietH__CDF0A114BC73B07D");

            entity.ToTable("ChiTietHoaDon");

            entity.Property(e => e.MaChiTiet).ValueGeneratedNever();

            entity.HasOne(d => d.MaHoaDonNavigation).WithMany(p => p.ChiTietHoaDons)
                .HasForeignKey(d => d.MaHoaDon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietHo__MaHoa__3B75D760");

            entity.HasOne(d => d.MaSanPhamNavigation).WithMany(p => p.ChiTietHoaDons)
                .HasForeignKey(d => d.MaSanPham)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietHo__MaSan__3C69FB99");
        });

        modelBuilder.Entity<DoiDiemLayVoucher>(entity =>
        {
            entity.HasKey(e => e.MaDoiDiem).HasName("PK__DoiDiemL__072BDE7FF21B3448");

            entity.ToTable("DoiDiemLayVoucher");

            entity.Property(e => e.MaDoiDiem).ValueGeneratedNever();
            entity.Property(e => e.MaVoucher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NgayDoi).HasColumnType("datetime");
            entity.Property(e => e.SoDienThoaiKhachHang).HasMaxLength(50);

            entity.HasOne(d => d.MaVoucherNavigation).WithMany(p => p.DoiDiemLayVouchers)
                .HasForeignKey(d => d.MaVoucher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DoiDiemLa__MaVou__403A8C7D");

            entity.HasOne(d => d.SoDienThoaiKhachHangNavigation).WithMany(p => p.DoiDiemLayVouchers)
                .HasForeignKey(d => d.SoDienThoaiKhachHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DoiDiemLa__SoDie__3F466844");
        });

        modelBuilder.Entity<HinhThucThanhToan>(entity =>
        {
            entity.HasKey(e => e.MaHinhThuc).HasName("PK__HinhThuc__46E72C267422FC9C");

            entity.ToTable("HinhThucThanhToan");

            entity.Property(e => e.MaHinhThuc).ValueGeneratedNever();
            entity.Property(e => e.TenHinhThuc).HasMaxLength(255);
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHoaDon).HasName("PK__HoaDon__835ED13B2BFEAB9E");

            entity.ToTable("HoaDon");

            entity.Property(e => e.MaHoaDon).ValueGeneratedNever();
            entity.Property(e => e.MaTaiKhoan).HasMaxLength(50);
            entity.Property(e => e.MaVoucher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NgayTao).HasColumnType("datetime");
            entity.Property(e => e.SoDienThoaiKhachHang).HasMaxLength(50);

            entity.HasOne(d => d.MaTaiKhoanNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaTaiKhoan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDon__MaTaiKho__32E0915F");

            entity.HasOne(d => d.MaVoucherNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaVoucher)
                .HasConstraintName("FK__HoaDon__MaVouche__34C8D9D1");

            entity.HasOne(d => d.SoDienThoaiKhachHangNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.SoDienThoaiKhachHang)
                .HasConstraintName("FK__HoaDon__SoDienTh__33D4B598");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.SoDienThoai).HasName("PK__KhachHan__0389B7BCACE42F75");

            entity.ToTable("KhachHang");

            entity.Property(e => e.SoDienThoai).HasMaxLength(50);
            entity.Property(e => e.TenKhachHang).HasMaxLength(255);
        });

        modelBuilder.Entity<KhuyenMai>(entity =>
        {
            entity.HasKey(e => e.MaKhuyenMai).HasName("PK__KhuyenMa__6F56B3BDFCBABD0F");

            entity.ToTable("KhuyenMai");

            entity.Property(e => e.MaKhuyenMai).ValueGeneratedNever();
            entity.Property(e => e.NgayBatDau).HasColumnType("datetime");
            entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            entity.Property(e => e.TenKhuyenMai).HasMaxLength(255);
        });

        modelBuilder.Entity<LichSuThanhToan>(entity =>
        {
            entity.HasKey(e => e.MaLichSu).HasName("PK__LichSuTh__C443222AC50EB8EA");

            entity.ToTable("LichSuThanhToan");

            entity.Property(e => e.MaLichSu).ValueGeneratedNever();

            entity.HasOne(d => d.MaHinhThucNavigation).WithMany(p => p.LichSuThanhToans)
                .HasForeignKey(d => d.MaHinhThuc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LichSuTha__MaHin__37A5467C");

            entity.HasOne(d => d.MaHoaDonNavigation).WithMany(p => p.LichSuThanhToans)
                .HasForeignKey(d => d.MaHoaDon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LichSuTha__MaHoa__38996AB5");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.MaSanPham).HasName("PK__SanPham__FAC7442D6BB71314");

            entity.ToTable("SanPham");

            entity.Property(e => e.MaSanPham).ValueGeneratedNever();
            entity.Property(e => e.HinhAnh).HasMaxLength(255);
            entity.Property(e => e.TenSanPham).HasMaxLength(255);
            entity.Property(e => e.XuatXu).HasMaxLength(255);

            entity.HasOne(d => d.MaKhuyenMaiNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MaKhuyenMai)
                .HasConstraintName("FK__SanPham__MaKhuye__300424B4");
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.TenDangNhap).HasName("PK__TaiKhoan__55F68FC15BD57569");

            entity.ToTable("TaiKhoan");

            entity.Property(e => e.TenDangNhap).HasMaxLength(50);
            entity.Property(e => e.MatKhau).HasMaxLength(255);
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.MaVoucher).HasName("PK__Voucher__0AAC5B11CC260FD3");

            entity.ToTable("Voucher");

            entity.Property(e => e.MaVoucher)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NgayBatDau).HasColumnType("datetime");
            entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            entity.Property(e => e.TenVoucher).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
