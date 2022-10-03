using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace sifalibitkiler.Models
{
    public partial class sifalibitkiContext : DbContext
    {
        public sifalibitkiContext()
        {
        }

        public sifalibitkiContext(DbContextOptions<sifalibitkiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bitkiler> Bitkilers { get; set; } = null!;
        public virtual DbSet<Kategori> Kategoris { get; set; } = null!;
        public virtual DbSet<Menuler> Menulers { get; set; } = null!;
        public virtual DbSet<Panelgiris> Panelgirises { get; set; } = null!;
        public virtual DbSet<Sayfalar> Sayfalars { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=sifalibitki;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bitkiler>(entity =>
            {
                entity.HasKey(e => e.BitkiId)
                    .HasName("PK__bitkiler__02BBC9AC56F40C92");

                entity.ToTable("bitkiler");

                entity.Property(e => e.BitkiId).HasColumnName("bitkiID");

                entity.Property(e => e.Addtime)
                    .HasColumnType("datetime")
                    .HasColumnName("addtime");

                entity.Property(e => e.Aktif).HasColumnName("aktif");

                entity.Property(e => e.Bitkiimg)
                    .HasColumnType("image")
                    .HasColumnName("bitkiimg");

                entity.Property(e => e.Bitkiname)
                    .HasMaxLength(70)
                    .HasColumnName("bitkiname");

                entity.Property(e => e.Bitkioz)
                    .HasColumnType("ntext")
                    .HasColumnName("bitkioz");

                entity.Property(e => e.KategoriId).HasColumnName("kategoriID");

                entity.Property(e => e.Pasif).HasColumnName("pasif");

                entity.Property(e => e.Sira).HasColumnName("sira");

                entity.HasOne(d => d.Kategori)
                    .WithMany(p => p.Bitkilers)
                    .HasForeignKey(d => d.KategoriId)
                    .HasConstraintName("FK__bitkiler__katego__2A4B4B5E");
            });

            modelBuilder.Entity<Kategori>(entity =>
            {
                entity.ToTable("kategori");

                entity.Property(e => e.KategoriId).HasColumnName("kategoriID");

                entity.Property(e => e.Aktif).HasColumnName("aktif");

                entity.Property(e => e.Kategoriadi)
                    .HasMaxLength(100)
                    .HasColumnName("kategoriadi");

                entity.Property(e => e.Pasif).HasColumnName("pasif");
            });

            modelBuilder.Entity<Menuler>(entity =>
            {
                entity.HasKey(e => e.MenuId)
                    .HasName("PK__menuler__3B407E9448BAC738");

                entity.ToTable("menuler");

                entity.Property(e => e.MenuId).HasColumnName("menuID");

                entity.Property(e => e.Aktif).HasColumnName("aktif");

                entity.Property(e => e.Baslik)
                    .HasMaxLength(30)
                    .HasColumnName("baslik");

                entity.Property(e => e.Pasif).HasColumnName("pasif");

                entity.Property(e => e.Sira).HasColumnName("sira");

                entity.Property(e => e.UstId).HasColumnName("ustID");

                entity.Property(e => e.Yol)
                    .HasMaxLength(250)
                    .HasColumnName("yol");
            });

            modelBuilder.Entity<Panelgiris>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK__panelgir__AD05008659AAE462");

                entity.ToTable("panelgiris");

                entity.Property(e => e.AdminId).HasColumnName("adminID");

                entity.Property(e => e.Adi)
                    .HasMaxLength(70)
                    .HasColumnName("adi");

                entity.Property(e => e.Parola)
                    .HasMaxLength(70)
                    .HasColumnName("parola");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(70)
                    .HasColumnName("soyadi");
            });

            modelBuilder.Entity<Sayfalar>(entity =>
            {
                entity.HasKey(e => e.SayfaId)
                    .HasName("PK__sayfalar__F81FC2B2ABC73F6F");

                entity.ToTable("sayfalar");

                entity.Property(e => e.SayfaId).HasColumnName("sayfaID");

                entity.Property(e => e.Aktif).HasColumnName("aktif");

                entity.Property(e => e.Baslik)
                    .HasMaxLength(30)
                    .HasColumnName("baslik");

                entity.Property(e => e.Icerik)
                    .HasColumnType("ntext")
                    .HasColumnName("icerik");

                entity.Property(e => e.Pasif).HasColumnName("pasif");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
