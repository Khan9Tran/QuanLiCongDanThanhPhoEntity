using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace QuanLiCongDanThanhPho.Model;

public partial class QuanlitpContext : DbContext
{
    public QuanlitpContext()
    {
    }

    public QuanlitpContext(DbContextOptions<QuanlitpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Cccd> Cccds { get; set; }

    public virtual DbSet<Congdan> Congdans { get; set; }

    public virtual DbSet<Hokhau> Hokhaus { get; set; }

    public virtual DbSet<Honnhan> Honnhans { get; set; }

    public virtual DbSet<Khaisinh> Khaisinhs { get; set; }

    public virtual DbSet<Tamtrutamvang> Tamtrutamvangs { get; set; }

    public virtual DbSet<Thue> Thues { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QUANLITP;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.UserName).HasName("PK__ACCOUNT__C9F28457E59EB581");

            entity.ToTable("ACCOUNT");

            entity.Property(e => e.UserName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName).HasMaxLength(30);
            entity.Property(e => e.StrPassword)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Cccd>(entity =>
        {
            entity.HasKey(e => e.MaCccd).HasName("PK__CCCD__02503095C0F0C801");

            entity.ToTable("CCCD");

            entity.Property(e => e.MaCccd)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MaCCCD");
            entity.Property(e => e.DacDiem).HasMaxLength(50);
            entity.Property(e => e.NgayCap).HasColumnType("date");

            entity.HasOne(d => d.MaCccdNavigation).WithOne(p => p.CccdNavigation)
                .HasForeignKey<Cccd>(d => d.MaCccd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CCCD__MaCCCD__29572725");
        });

        modelBuilder.Entity<Congdan>(entity =>
        {
            entity.HasKey(e => e.Cccd).HasName("PK__CONGDAN__A955A0AB993D4853");

            entity.ToTable("CONGDAN");

            entity.Property(e => e.Cccd)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CCCD");
            entity.Property(e => e.MaHk)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MaHK");
            entity.Property(e => e.NgheNghiep).HasMaxLength(30);
            entity.Property(e => e.QuanHeVoiChuHo).HasMaxLength(30);
            entity.Property(e => e.Sdt)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.Ten).HasMaxLength(30);
            entity.Property(e => e.TonGiao).HasMaxLength(30);

            entity.HasOne(d => d.MaHkNavigation).WithMany(p => p.Congdans)
                .HasForeignKey(d => d.MaHk)
                .HasConstraintName("FK__CONGDAN__MaHK__267ABA7A");
        });

        modelBuilder.Entity<Hokhau>(entity =>
        {
            entity.HasKey(e => e.MaHk).HasName("PK__HOKHAU__2725A6E78D4EEAE1");

            entity.ToTable("HOKHAU");

            entity.Property(e => e.MaHk)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MaHK");
            entity.Property(e => e.CccdchuHo)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CCCDChuHo");
            entity.Property(e => e.DiaChi).HasMaxLength(100);
        });

        modelBuilder.Entity<Honnhan>(entity =>
        {
            entity.HasKey(e => e.MaHonNhan).HasName("PK__HONNHAN__9DAE44DD3D3515DC");

            entity.ToTable("HONNHAN");

            entity.Property(e => e.MaHonNhan)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Cccdnam)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CCCDNam");
            entity.Property(e => e.Cccdnu)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CCCDNu");
            entity.Property(e => e.NgayDangKy).HasColumnType("date");
            entity.Property(e => e.NoiDangKy).HasMaxLength(100);
            entity.Property(e => e.TenNam).HasMaxLength(30);
            entity.Property(e => e.TenNu).HasMaxLength(30);

            entity.HasOne(d => d.CccdnamNavigation).WithMany(p => p.HonnhanCccdnamNavigations)
                .HasForeignKey(d => d.Cccdnam)
                .HasConstraintName("FK__HONNHAN__CCCDNam__34C8D9D1");

            entity.HasOne(d => d.CccdnuNavigation).WithMany(p => p.HonnhanCccdnuNavigations)
                .HasForeignKey(d => d.Cccdnu)
                .HasConstraintName("FK__HONNHAN__CCCDNu__35BCFE0A");
        });

        modelBuilder.Entity<Khaisinh>(entity =>
        {
            entity.HasKey(e => e.MaKs).HasName("PK__KHAISINH__2725CF136E682DB8");

            entity.ToTable("KHAISINH");

            entity.Property(e => e.MaKs)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MaKS");
            entity.Property(e => e.Cccdcha)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CCCDCha");
            entity.Property(e => e.Cccdme)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CCCDMe");
            entity.Property(e => e.DanToc).HasMaxLength(20);
            entity.Property(e => e.GioiTinh)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.NgayDangKy).HasColumnType("date");
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.NoiSinh).HasMaxLength(100);
            entity.Property(e => e.QueQuan).HasMaxLength(100);
            entity.Property(e => e.QuocTich).HasMaxLength(20);
            entity.Property(e => e.Ten).HasMaxLength(30);
            entity.Property(e => e.TenCha).HasMaxLength(30);
            entity.Property(e => e.TenMe).HasMaxLength(30);

            entity.HasOne(d => d.MaKsNavigation).WithOne(p => p.Khaisinh)
                .HasForeignKey<Khaisinh>(d => d.MaKs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KHAISINH__MaKS__2F10007B");
        });

        modelBuilder.Entity<Tamtrutamvang>(entity =>
        {
            entity.HasKey(e => e.Cccd).HasName("PK__TAMTRUTA__A955A0AB2794D037");

            entity.ToTable("TAMTRUTAMVANG");

            entity.Property(e => e.Cccd)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CCCD");
            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.LiDo).HasMaxLength(100);
            entity.Property(e => e.MaTttv)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MaTTTV");
            entity.Property(e => e.NgayBd)
                .HasColumnType("date")
                .HasColumnName("NgayBD");
            entity.Property(e => e.NgayKt)
                .HasColumnType("date")
                .HasColumnName("NgayKT");
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.CccdNavigation).WithOne(p => p.Tamtrutamvang)
                .HasForeignKey<Tamtrutamvang>(d => d.Cccd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TAMTRUTAMV__CCCD__2C3393D0");
        });

        modelBuilder.Entity<Thue>(entity =>
        {
            entity.HasKey(e => e.MaThue).HasName("PK__THUE__9CC2FDA388AD2865");

            entity.ToTable("THUE");

            entity.Property(e => e.MaThue)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Cccd)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CCCD");
            entity.Property(e => e.HanNop).HasColumnType("date");
            entity.Property(e => e.NgayCap).HasColumnType("date");
            entity.Property(e => e.SoTienCanNop)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SoTienDaNop)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.CccdNavigation).WithMany(p => p.Thues)
                .HasForeignKey(d => d.Cccd)
                .HasConstraintName("FK__THUE__CCCD__31EC6D26");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
