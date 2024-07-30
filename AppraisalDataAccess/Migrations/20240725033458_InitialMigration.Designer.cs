﻿// <auto-generated />
using System;
using AppraisalDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AppraisalDataAccess.Migrations
{
    [DbContext(typeof(AppraisalContext))]
    [Migration("20240725033458_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AppraisalDataAccess.Models.IndikatorArea", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("character varying")
                        .HasColumnName("id");

                    b.Property<int?>("Aktual")
                        .HasColumnType("integer")
                        .HasColumnName("aktual");

                    b.Property<string>("Aspek")
                        .HasColumnType("character varying")
                        .HasColumnName("aspek");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("now()");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("created_by");

                    b.Property<string>("Keterangan")
                        .HasColumnType("character varying")
                        .HasColumnName("keterangan");

                    b.Property<int?>("NilaiUnjukKerja")
                        .HasColumnType("integer")
                        .HasColumnName("nilaiUnjukKerja");

                    b.Property<string>("RekapId")
                        .HasColumnType("character varying")
                        .HasColumnName("rekapId");

                    b.Property<int?>("Target")
                        .HasColumnType("integer")
                        .HasColumnName("target");

                    b.Property<int?>("TingkatUnjukKerja")
                        .HasColumnType("integer")
                        .HasColumnName("tingkatUnjukKerja");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("indikatorArea_pkey");

                    b.HasIndex("RekapId");

                    b.ToTable("indikatorArea", (string)null);
                });

            modelBuilder.Entity("AppraisalDataAccess.Models.IndikatorUtamaKerja", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("character varying")
                        .HasColumnName("id");

                    b.Property<int?>("Aktual")
                        .HasColumnType("integer")
                        .HasColumnName("aktual");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("now()");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("created_by");

                    b.Property<string>("Kpi")
                        .HasColumnType("character varying")
                        .HasColumnName("kpi")
                        .HasComment("Content of the post");

                    b.Property<int?>("NilaiUnjukKerja")
                        .HasColumnType("integer")
                        .HasColumnName("nilaiUnjukKerja");

                    b.Property<int?>("Polarisasi")
                        .HasColumnType("integer")
                        .HasColumnName("polarisasi");

                    b.Property<string>("RekapId")
                        .HasColumnType("character varying")
                        .HasColumnName("rekapId");

                    b.Property<string>("StrategicObjective")
                        .HasColumnType("character varying")
                        .HasColumnName("strategicObjective");

                    b.Property<int?>("Target")
                        .HasColumnType("integer")
                        .HasColumnName("target");

                    b.Property<int?>("TingkatUnjukKerja")
                        .HasColumnType("integer")
                        .HasColumnName("tingkatUnjukKerja");

                    b.Property<int?>("UoM")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("indikatorUtamaKerja_pkey");

                    b.HasIndex("Kpi");

                    b.HasIndex("RekapId");

                    b.ToTable("indikatorUtamaKerja", (string)null);
                });

            modelBuilder.Entity("AppraisalDataAccess.Models.KompetensiDasar", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("character varying")
                        .HasColumnName("id");

                    b.Property<string>("ContinuousImprovement")
                        .HasColumnType("character varying")
                        .HasColumnName("continuousImprovement");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("now()");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("created_by");

                    b.Property<string>("CustomerFocus")
                        .HasColumnType("character varying")
                        .HasColumnName("customerFocus");

                    b.Property<string>("Integritas")
                        .HasColumnType("character varying")
                        .HasColumnName("integritas");

                    b.Property<string>("KerjasamaTim")
                        .HasColumnType("character varying")
                        .HasColumnName("kerjasamaTim");

                    b.Property<string>("RekapId")
                        .HasColumnType("character varying")
                        .HasColumnName("rekapId");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.Property<string>("WorkExcellence")
                        .HasColumnType("character varying")
                        .HasColumnName("workExcellence");

                    b.HasKey("Id")
                        .HasName("kompetensiDasar_pkey");

                    b.HasIndex("RekapId");

                    b.ToTable("kompetensiDasar", (string)null);
                });

            modelBuilder.Entity("AppraisalDataAccess.Models.Kpi", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("character varying")
                        .HasColumnName("id");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("now()");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("created_by");

                    b.Property<string>("Nama")
                        .HasColumnType("character varying")
                        .HasColumnName("nama");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("kpi_pkey");

                    b.ToTable("kpi", (string)null);
                });

            modelBuilder.Entity("AppraisalDataAccess.Models.PerubahanNilai", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("character varying")
                        .HasColumnName("id");

                    b.Property<int?>("AuditorOrTrainer")
                        .HasColumnType("integer")
                        .HasColumnName("auditorOrTrainer");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("now()");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("created_by");

                    b.Property<string>("FireIncident")
                        .HasColumnType("character varying")
                        .HasColumnName("fireIncident");

                    b.Property<int?>("LostTimeInjury")
                        .HasColumnType("integer")
                        .HasColumnName("lostTimeInjury");

                    b.Property<int?>("Project")
                        .HasColumnType("integer")
                        .HasColumnName("project");

                    b.Property<string>("RekapId")
                        .HasColumnType("character varying")
                        .HasColumnName("rekapId");

                    b.Property<int?>("Sga")
                        .HasColumnType("integer")
                        .HasColumnName("sga");

                    b.Property<string>("SuratPeringatan")
                        .HasColumnType("character varying")
                        .HasColumnName("suratPeringatan");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("perubahanNilai_pkey");

                    b.HasIndex("RekapId");

                    b.ToTable("perubahanNilai", (string)null);
                });

            modelBuilder.Entity("AppraisalDataAccess.Models.Rekapitulasi", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("character varying")
                        .HasColumnName("id");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("now()");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("created_by");

                    b.Property<int?>("Nik")
                        .HasColumnType("integer")
                        .HasColumnName("NIK");

                    b.Property<string>("Periode")
                        .HasColumnType("character varying")
                        .HasColumnName("periode");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("rekapitulasi_pkey");

                    b.HasIndex("Nik");

                    b.ToTable("rekapitulasi", (string)null);
                });

            modelBuilder.Entity("AppraisalDataAccess.Models.User", b =>
                {
                    b.Property<int>("Nik")
                        .HasColumnType("integer")
                        .HasColumnName("NIK");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("now()");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("created_by");

                    b.Property<string>("DivisiOrDepartemen")
                        .HasColumnType("character varying")
                        .HasColumnName("divisiOrDepartemen");

                    b.Property<string>("Jabatan")
                        .HasColumnType("character varying")
                        .HasColumnName("jabatan");

                    b.Property<string>("Nama")
                        .HasColumnType("character varying")
                        .HasColumnName("nama");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer")
                        .HasColumnName("updated_by");

                    b.HasKey("Nik")
                        .HasName("users_pkey");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("AppraisalDataAccess.Models.IndikatorArea", b =>
                {
                    b.HasOne("AppraisalDataAccess.Models.Rekapitulasi", "Rekap")
                        .WithMany("IndikatorAreas")
                        .HasForeignKey("RekapId")
                        .HasConstraintName("indikatorArea_rekapId_fkey");

                    b.Navigation("Rekap");
                });

            modelBuilder.Entity("AppraisalDataAccess.Models.IndikatorUtamaKerja", b =>
                {
                    b.HasOne("AppraisalDataAccess.Models.Kpi", "KpiNavigation")
                        .WithMany("IndikatorUtamaKerjas")
                        .HasForeignKey("Kpi")
                        .HasConstraintName("indikatorUtamaKerja_kpi_fkey");

                    b.HasOne("AppraisalDataAccess.Models.Rekapitulasi", "Rekap")
                        .WithMany("IndikatorUtamaKerjas")
                        .HasForeignKey("RekapId")
                        .HasConstraintName("indikatorUtamaKerja_rekapId_fkey");

                    b.Navigation("KpiNavigation");

                    b.Navigation("Rekap");
                });

            modelBuilder.Entity("AppraisalDataAccess.Models.KompetensiDasar", b =>
                {
                    b.HasOne("AppraisalDataAccess.Models.Rekapitulasi", "Rekap")
                        .WithMany("KompetensiDasars")
                        .HasForeignKey("RekapId")
                        .HasConstraintName("kompetensiDasar_rekapId_fkey");

                    b.Navigation("Rekap");
                });

            modelBuilder.Entity("AppraisalDataAccess.Models.PerubahanNilai", b =>
                {
                    b.HasOne("AppraisalDataAccess.Models.Rekapitulasi", "Rekap")
                        .WithMany("PerubahanNilais")
                        .HasForeignKey("RekapId")
                        .HasConstraintName("perubahanNilai_rekapId_fkey");

                    b.Navigation("Rekap");
                });

            modelBuilder.Entity("AppraisalDataAccess.Models.Rekapitulasi", b =>
                {
                    b.HasOne("AppraisalDataAccess.Models.User", "NikNavigation")
                        .WithMany("Rekapitulasis")
                        .HasForeignKey("Nik")
                        .HasConstraintName("rekapitulasi_NIK_fkey");

                    b.Navigation("NikNavigation");
                });

            modelBuilder.Entity("AppraisalDataAccess.Models.Kpi", b =>
                {
                    b.Navigation("IndikatorUtamaKerjas");
                });

            modelBuilder.Entity("AppraisalDataAccess.Models.Rekapitulasi", b =>
                {
                    b.Navigation("IndikatorAreas");

                    b.Navigation("IndikatorUtamaKerjas");

                    b.Navigation("KompetensiDasars");

                    b.Navigation("PerubahanNilais");
                });

            modelBuilder.Entity("AppraisalDataAccess.Models.User", b =>
                {
                    b.Navigation("Rekapitulasis");
                });
#pragma warning restore 612, 618
        }
    }
}
