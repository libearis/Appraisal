using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AppraisalDataAccess.Models;

public partial class AppraisalContext : DbContext
{
    public AppraisalContext()
    {
    }

    public AppraisalContext(DbContextOptions<AppraisalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<IndikatorArea> IndikatorAreas { get; set; }

    public virtual DbSet<IndikatorUtamaKerja> IndikatorUtamaKerjas { get; set; }

    public virtual DbSet<KompetensiDasar> KompetensiDasars { get; set; }

    public virtual DbSet<Kpi> Kpis { get; set; }

    public virtual DbSet<PerubahanNilai> PerubahanNilais { get; set; }

    public virtual DbSet<Rekapitulasi> Rekapitulasis { get; set; }

    public virtual DbSet<User> Users { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseNpgsql("Host=localhost:8080;Database=Appraisal;Username=postgres;Password=indocyber");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IndikatorArea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("indikatorArea_pkey");

            entity.ToTable("indikatorArea");

            entity.Property(e => e.Id)
                .HasColumnType("character varying")
                .HasColumnName("id");
            entity.Property(e => e.Aktual).HasColumnName("aktual");
            entity.Property(e => e.Aspek)
                .HasColumnType("character varying")
                .HasColumnName("aspek");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Keterangan)
                .HasColumnType("character varying")
                .HasColumnName("keterangan");
            entity.Property(e => e.NilaiUnjukKerja).HasColumnName("nilaiUnjukKerja");
            entity.Property(e => e.RekapId)
                .HasColumnType("character varying")
                .HasColumnName("rekapId");
            entity.Property(e => e.Target).HasColumnName("target");
            entity.Property(e => e.TingkatUnjukKerja).HasColumnName("tingkatUnjukKerja");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.Rekap).WithMany(p => p.IndikatorAreas)
                .HasForeignKey(d => d.RekapId)
                .HasConstraintName("indikatorArea_rekapId_fkey");
        });

        modelBuilder.Entity<IndikatorUtamaKerja>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("indikatorUtamaKerja_pkey");

            entity.ToTable("indikatorUtamaKerja");

            entity.Property(e => e.Id)
                .HasColumnType("character varying")
                .HasColumnName("id");
            entity.Property(e => e.Aktual).HasColumnName("aktual");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Kpi)
                .HasComment("Content of the post")
                .HasColumnType("character varying")
                .HasColumnName("kpi");
            entity.Property(e => e.NilaiUnjukKerja).HasColumnName("nilaiUnjukKerja");
            entity.Property(e => e.Polarisasi).HasColumnName("polarisasi");
            entity.Property(e => e.RekapId)
                .HasColumnType("character varying")
                .HasColumnName("rekapId");
            entity.Property(e => e.StrategicObjective)
                .HasColumnType("character varying")
                .HasColumnName("strategicObjective");
            entity.Property(e => e.Target).HasColumnName("target");
            entity.Property(e => e.TingkatUnjukKerja).HasColumnName("tingkatUnjukKerja");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.KpiNavigation).WithMany(p => p.IndikatorUtamaKerjas)
                .HasForeignKey(d => d.Kpi)
                .HasConstraintName("indikatorUtamaKerja_kpi_fkey");

            entity.HasOne(d => d.Rekap).WithMany(p => p.IndikatorUtamaKerjas)
                .HasForeignKey(d => d.RekapId)
                .HasConstraintName("indikatorUtamaKerja_rekapId_fkey");
        });

        modelBuilder.Entity<KompetensiDasar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("kompetensiDasar_pkey");

            entity.ToTable("kompetensiDasar");

            entity.Property(e => e.Id)
                .HasColumnType("character varying")
                .HasColumnName("id");
            entity.Property(e => e.ContinuousImprovement)
                .HasColumnType("character varying")
                .HasColumnName("continuousImprovement");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CustomerFocus)
                .HasColumnType("character varying")
                .HasColumnName("customerFocus");
            entity.Property(e => e.Integritas)
                .HasColumnType("character varying")
                .HasColumnName("integritas");
            entity.Property(e => e.KerjasamaTim)
                .HasColumnType("character varying")
                .HasColumnName("kerjasamaTim");
            entity.Property(e => e.RekapId)
                .HasColumnType("character varying")
                .HasColumnName("rekapId");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.WorkExcellence)
                .HasColumnType("character varying")
                .HasColumnName("workExcellence");

            entity.HasOne(d => d.Rekap).WithMany(p => p.KompetensiDasars)
                .HasForeignKey(d => d.RekapId)
                .HasConstraintName("kompetensiDasar_rekapId_fkey");
        });

        modelBuilder.Entity<Kpi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("kpi_pkey");

            entity.ToTable("kpi");

            entity.Property(e => e.Id)
                .HasColumnType("character varying")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Nama)
                .HasColumnType("character varying")
                .HasColumnName("nama");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
        });

        modelBuilder.Entity<PerubahanNilai>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("perubahanNilai_pkey");

            entity.ToTable("perubahanNilai");

            entity.Property(e => e.Id)
                .HasColumnType("character varying")
                .HasColumnName("id");
            entity.Property(e => e.AuditorOrTrainer).HasColumnName("auditorOrTrainer");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.FireIncident)
                .HasColumnType("character varying")
                .HasColumnName("fireIncident");
            entity.Property(e => e.LostTimeInjury).HasColumnName("lostTimeInjury");
            entity.Property(e => e.Project).HasColumnName("project");
            entity.Property(e => e.RekapId)
                .HasColumnType("character varying")
                .HasColumnName("rekapId");
            entity.Property(e => e.Sga).HasColumnName("sga");
            entity.Property(e => e.SuratPeringatan)
                .HasColumnType("character varying")
                .HasColumnName("suratPeringatan");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.Rekap).WithMany(p => p.PerubahanNilais)
                .HasForeignKey(d => d.RekapId)
                .HasConstraintName("perubahanNilai_rekapId_fkey");
        });

        modelBuilder.Entity<Rekapitulasi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("rekapitulasi_pkey");

            entity.ToTable("rekapitulasi");

            entity.Property(e => e.Id)
                .HasColumnType("character varying")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Nik).HasColumnName("NIK");
            entity.Property(e => e.Periode)
                .HasColumnType("character varying")
                .HasColumnName("periode");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");

            entity.HasOne(d => d.NikNavigation).WithMany(p => p.Rekapitulasis)
                .HasForeignKey(d => d.Nik)
                .HasConstraintName("rekapitulasi_NIK_fkey");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Nik).HasName("users_pkey");

            entity.HasIndex(e => e.Nik, "UQ__Users__6354A73FEFBA1441").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Users__A9D10534726D34FB").IsUnique();

            entity.ToTable("users");

            entity.Property(e => e.Nik)
                .ValueGeneratedNever()
                .HasColumnName("NIK");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("Email");
            entity.Property(e => e.Password)
                .HasColumnType("character varying")
                .HasColumnName("Password");
            entity.Property(e => e.DivisiOrDepartemen)
                .HasColumnType("character varying")
                .HasColumnName("divisiOrDepartemen");
            entity.Property(e => e.Jabatan)
                .HasColumnType("character varying")
                .HasColumnName("jabatan");
            entity.Property(e => e.Nama)
                .HasColumnType("character varying")
                .HasColumnName("nama");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
