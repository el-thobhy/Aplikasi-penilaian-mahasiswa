﻿// <auto-generated />
using System;
using ApplikasiPenilaianMahasiswa.Api.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApplikasiPenilaianMahasiswa.Api.Migrations
{
    [DbContext(typeof(MahasiswaDbContext))]
    [Migration("20240125133652_editKodeTable")]
    partial class editKodeTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApplikasiPenilaianMahasiswa.Api.DataModel.Agama", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<long>("Created_by")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Created_on")
                        .HasColumnType("datetime2");

                    b.Property<long?>("Deleted_by")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Deleted_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("Deskripsi")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("Is_delete")
                        .HasColumnType("bit");

                    b.Property<string>("Kode_Agama")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long?>("Modified_by")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Modified_on")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("m_agama");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4370),
                            Deskripsi = "Islam",
                            Is_delete = false,
                            Kode_Agama = "AGM-2401-0001"
                        },
                        new
                        {
                            Id = 2,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4372),
                            Deskripsi = "Kristen",
                            Is_delete = false,
                            Kode_Agama = "AGM-2401-0002"
                        },
                        new
                        {
                            Id = 3,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4373),
                            Deskripsi = "Katolik",
                            Is_delete = false,
                            Kode_Agama = "AGM-2401-0003"
                        },
                        new
                        {
                            Id = 4,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4375),
                            Deskripsi = "Hindu",
                            Is_delete = false,
                            Kode_Agama = "AGM-2401-0004"
                        },
                        new
                        {
                            Id = 5,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4376),
                            Deskripsi = "Budha",
                            Is_delete = false,
                            Kode_Agama = "AGM-2401-0005"
                        });
                });

            modelBuilder.Entity("ApplikasiPenilaianMahasiswa.Api.DataModel.Dosen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<long>("Created_by")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Created_on")
                        .HasColumnType("datetime2");

                    b.Property<long?>("Deleted_by")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Deleted_on")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Jurusan")
                        .HasColumnType("int");

                    b.Property<int>("Id_Type_Dosen")
                        .HasColumnType("int");

                    b.Property<bool>("Is_delete")
                        .HasColumnType("bit");

                    b.Property<string>("Kode_Dosen")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long?>("Modified_by")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Modified_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nama_Dosen")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Jurusan");

                    b.HasIndex("Id_Type_Dosen");

                    b.ToTable("m_dosen");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4483),
                            Id_Jurusan = 1,
                            Id_Type_Dosen = 2,
                            Is_delete = false,
                            Kode_Dosen = "DSN-2401-0001",
                            Nama_Dosen = "Prof. Dr. Retno Wahyuningsih"
                        },
                        new
                        {
                            Id = 2,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4485),
                            Id_Jurusan = 2,
                            Id_Type_Dosen = 1,
                            Is_delete = false,
                            Kode_Dosen = "DSN-2401-0002",
                            Nama_Dosen = "Prof. Roy M. Sutikno"
                        },
                        new
                        {
                            Id = 3,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4486),
                            Id_Jurusan = 3,
                            Id_Type_Dosen = 2,
                            Is_delete = false,
                            Kode_Dosen = "DSN-2401-0003",
                            Nama_Dosen = "Prof. Hendri A. Verburgh"
                        },
                        new
                        {
                            Id = 4,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4488),
                            Id_Jurusan = 4,
                            Id_Type_Dosen = 2,
                            Is_delete = false,
                            Kode_Dosen = "DSN-2401-0004",
                            Nama_Dosen = "Prof. Risma Suparwata"
                        },
                        new
                        {
                            Id = 5,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4618),
                            Id_Jurusan = 5,
                            Id_Type_Dosen = 1,
                            Is_delete = false,
                            Kode_Dosen = "DSN-2401-0005",
                            Nama_Dosen = "Prof. Amir Sjarifuddin Madjid, MM, MA"
                        });
                });

            modelBuilder.Entity("ApplikasiPenilaianMahasiswa.Api.DataModel.Jurusan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<long>("Created_by")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Created_on")
                        .HasColumnType("datetime2");

                    b.Property<long?>("Deleted_by")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Deleted_on")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Is_delete")
                        .HasColumnType("bit");

                    b.Property<string>("Kode_Jurusan")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long?>("Modified_by")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Modified_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nama_Jurusan")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Status_Jurusan")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("m_jurusan");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4197),
                            Is_delete = false,
                            Kode_Jurusan = "JUR-2401-0001",
                            Nama_Jurusan = "Teknik Informatika",
                            Status_Jurusan = "Aktif"
                        },
                        new
                        {
                            Id = 2,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4213),
                            Is_delete = false,
                            Kode_Jurusan = "JUR-2401-0002",
                            Nama_Jurusan = "Management Informatika",
                            Status_Jurusan = "Aktif"
                        },
                        new
                        {
                            Id = 3,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4214),
                            Is_delete = false,
                            Kode_Jurusan = "JUR-2401-0003",
                            Nama_Jurusan = "Sistem Informasi",
                            Status_Jurusan = "Non Aktif"
                        },
                        new
                        {
                            Id = 4,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4216),
                            Is_delete = false,
                            Kode_Jurusan = "JUR-2401-0004",
                            Nama_Jurusan = "Sistem Komputer",
                            Status_Jurusan = "Aktif"
                        },
                        new
                        {
                            Id = 5,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4217),
                            Is_delete = false,
                            Kode_Jurusan = "JUR-2401-0005",
                            Nama_Jurusan = "Komputer Akuntansi",
                            Status_Jurusan = "Non Aktif"
                        });
                });

            modelBuilder.Entity("ApplikasiPenilaianMahasiswa.Api.DataModel.Mahasiswa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Alamat")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<long>("Created_by")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Created_on")
                        .HasColumnType("datetime2");

                    b.Property<long?>("Deleted_by")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Deleted_on")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Agama")
                        .HasColumnType("int");

                    b.Property<int>("Id_Jurusan")
                        .HasColumnType("int");

                    b.Property<bool>("Is_delete")
                        .HasColumnType("bit");

                    b.Property<string>("Kode_Mahasiswa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long?>("Modified_by")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Modified_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nama_Mahasiswa")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Agama");

                    b.HasIndex("Id_Jurusan");

                    b.ToTable("m_mahasiswa");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Alamat = "Jl. Mawar No 3 RT 05 Cicalengka, Bandung",
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4399),
                            Id_Agama = 1,
                            Id_Jurusan = 1,
                            Is_delete = false,
                            Kode_Mahasiswa = "MHS-2401-0001",
                            Nama_Mahasiswa = "Budi Gunawan"
                        },
                        new
                        {
                            Id = 2,
                            Alamat = "Jl. Kebagusan No. 33 RT04 RW06 Bandung",
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4402),
                            Id_Agama = 2,
                            Id_Jurusan = 2,
                            Is_delete = false,
                            Kode_Mahasiswa = "MHS-2401-0002",
                            Nama_Mahasiswa = "Rinto Raharjo"
                        },
                        new
                        {
                            Id = 3,
                            Alamat = "Jl. Sumatera No. 12 RT02 RW01, Ciamis",
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4403),
                            Id_Agama = 1,
                            Id_Jurusan = 3,
                            Is_delete = false,
                            Kode_Mahasiswa = "MHS-2401-0003",
                            Nama_Mahasiswa = "Asep Saepudin"
                        },
                        new
                        {
                            Id = 4,
                            Alamat = "Jl. Jawa No 01 RT01 RW01, Jakarta Pusat",
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4405),
                            Id_Agama = 1,
                            Id_Jurusan = 1,
                            Is_delete = false,
                            Kode_Mahasiswa = "MHS-2401-0004",
                            Nama_Mahasiswa = "M. Hafif Isbullah"
                        },
                        new
                        {
                            Id = 5,
                            Alamat = "Jl. Niagara No. 54 RT01 RW09, Surabaya",
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4406),
                            Id_Agama = 3,
                            Id_Jurusan = 2,
                            Is_delete = false,
                            Kode_Mahasiswa = "MHS-2401-0005",
                            Nama_Mahasiswa = "Cahyono"
                        });
                });

            modelBuilder.Entity("ApplikasiPenilaianMahasiswa.Api.DataModel.Nilai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<long>("Created_by")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Created_on")
                        .HasColumnType("datetime2");

                    b.Property<long?>("Deleted_by")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Deleted_on")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_Mahasiswa")
                        .HasColumnType("int");

                    b.Property<int>("Id_Ujian")
                        .HasColumnType("int");

                    b.Property<bool>("Is_delete")
                        .HasColumnType("bit");

                    b.Property<long?>("Modified_by")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Modified_on")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("NilaiMahasiswa")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("Id_Mahasiswa");

                    b.HasIndex("Id_Ujian");

                    b.ToTable("m_nilai");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4647),
                            Id_Mahasiswa = 4,
                            Id_Ujian = 1,
                            Is_delete = false,
                            NilaiMahasiswa = 90m
                        },
                        new
                        {
                            Id = 2,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4650),
                            Id_Mahasiswa = 1,
                            Id_Ujian = 1,
                            Is_delete = false,
                            NilaiMahasiswa = 80m
                        },
                        new
                        {
                            Id = 3,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4652),
                            Id_Mahasiswa = 2,
                            Id_Ujian = 3,
                            Is_delete = false,
                            NilaiMahasiswa = 85m
                        },
                        new
                        {
                            Id = 4,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4653),
                            Id_Mahasiswa = 4,
                            Id_Ujian = 2,
                            Is_delete = false,
                            NilaiMahasiswa = 95m
                        },
                        new
                        {
                            Id = 5,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4655),
                            Id_Mahasiswa = 5,
                            Id_Ujian = 5,
                            Is_delete = false,
                            NilaiMahasiswa = 70m
                        });
                });

            modelBuilder.Entity("ApplikasiPenilaianMahasiswa.Api.DataModel.TypeDosen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<long>("Created_by")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Created_on")
                        .HasColumnType("datetime2");

                    b.Property<long?>("Deleted_by")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Deleted_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("Deskripsi")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("Is_delete")
                        .HasColumnType("bit");

                    b.Property<string>("Kode_Type_Dosen")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long?>("Modified_by")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Modified_on")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("m_type_dosen");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4460),
                            Deskripsi = "Tetap",
                            Is_delete = false,
                            Kode_Type_Dosen = "TYP-2401-0001"
                        },
                        new
                        {
                            Id = 2,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4461),
                            Deskripsi = "Honorer",
                            Is_delete = false,
                            Kode_Type_Dosen = "TYP-2401-0002"
                        },
                        new
                        {
                            Id = 3,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4462),
                            Deskripsi = "Expertise",
                            Is_delete = false,
                            Kode_Type_Dosen = "TYP-2401-0003"
                        });
                });

            modelBuilder.Entity("ApplikasiPenilaianMahasiswa.Api.DataModel.Ujian", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<long>("Created_by")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Created_on")
                        .HasColumnType("datetime2");

                    b.Property<long?>("Deleted_by")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Deleted_on")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Is_delete")
                        .HasColumnType("bit");

                    b.Property<string>("Kode_Ujian")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long?>("Modified_by")
                        .HasMaxLength(50)
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("Modified_on")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nama_Ujian")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Status_Ujian")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("m_ujian");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4433),
                            Is_delete = false,
                            Kode_Ujian = "UJN-2401-0001",
                            Nama_Ujian = "Algoritma",
                            Status_Ujian = "Aktif"
                        },
                        new
                        {
                            Id = 2,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4434),
                            Is_delete = false,
                            Kode_Ujian = "UJN-2401-0002",
                            Nama_Ujian = "Aljabar",
                            Status_Ujian = "Aktif"
                        },
                        new
                        {
                            Id = 3,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4435),
                            Is_delete = false,
                            Kode_Ujian = "UJN-2401-0003",
                            Nama_Ujian = "Statistika",
                            Status_Ujian = "Non Aktif"
                        },
                        new
                        {
                            Id = 4,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4437),
                            Is_delete = false,
                            Kode_Ujian = "UJN-2401-0004",
                            Nama_Ujian = "Etika Profesi",
                            Status_Ujian = "Non Aktif"
                        },
                        new
                        {
                            Id = 5,
                            Created_by = 1L,
                            Created_on = new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4438),
                            Is_delete = false,
                            Kode_Ujian = "UJN-2401-0005",
                            Nama_Ujian = "Bahasa Inggris",
                            Status_Ujian = "Aktif"
                        });
                });

            modelBuilder.Entity("ApplikasiPenilaianMahasiswa.Api.DataModel.Dosen", b =>
                {
                    b.HasOne("ApplikasiPenilaianMahasiswa.Api.DataModel.Jurusan", "Jurusan")
                        .WithMany()
                        .HasForeignKey("Id_Jurusan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplikasiPenilaianMahasiswa.Api.DataModel.TypeDosen", "TypeDosen")
                        .WithMany()
                        .HasForeignKey("Id_Type_Dosen")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jurusan");

                    b.Navigation("TypeDosen");
                });

            modelBuilder.Entity("ApplikasiPenilaianMahasiswa.Api.DataModel.Mahasiswa", b =>
                {
                    b.HasOne("ApplikasiPenilaianMahasiswa.Api.DataModel.Agama", "Agama")
                        .WithMany()
                        .HasForeignKey("Id_Agama")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplikasiPenilaianMahasiswa.Api.DataModel.Jurusan", "Jurusan")
                        .WithMany()
                        .HasForeignKey("Id_Jurusan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agama");

                    b.Navigation("Jurusan");
                });

            modelBuilder.Entity("ApplikasiPenilaianMahasiswa.Api.DataModel.Nilai", b =>
                {
                    b.HasOne("ApplikasiPenilaianMahasiswa.Api.DataModel.Mahasiswa", "Mahasiswa")
                        .WithMany()
                        .HasForeignKey("Id_Mahasiswa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplikasiPenilaianMahasiswa.Api.DataModel.Ujian", "Ujian")
                        .WithMany()
                        .HasForeignKey("Id_Ujian")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mahasiswa");

                    b.Navigation("Ujian");
                });
#pragma warning restore 612, 618
        }
    }
}
