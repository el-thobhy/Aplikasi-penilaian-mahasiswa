using Microsoft.EntityFrameworkCore;

namespace ApplikasiPenilaianMahasiswa.Api.DataModel
{
    public class MahasiswaDbContext: DbContext
    {
        public MahasiswaDbContext(DbContextOptions<MahasiswaDbContext> options) : base(options)
        {
            
        }

        public DbSet<Jurusan> Jurusans { get; set; }
        public DbSet<Agama> Agamas { get; set; }
        public DbSet<Mahasiswa> Mahasiswas { get; set; }
        public DbSet<Ujian> Ujans { get; set; }
        public DbSet<TypeDosen> TypeDosens { get; set; }
        public DbSet<Dosen> Dosens { get; set; }
        public DbSet<Nilai> Nilais { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

            modelBuilder.Entity<Jurusan>()
                .Property(o => o.Status_Jurusan)
                .IsRequired(true);
            modelBuilder.Entity<Jurusan>()
                .Property(o => o.Kode_Jurusan)
                .IsRequired(true);
            modelBuilder.Entity<Jurusan>()
                .Property(o => o.Nama_Jurusan)
                .IsRequired(true);


            modelBuilder.Entity<Agama>()
                .Property(o => o.Deskripsi)
                .IsRequired(true);
            modelBuilder.Entity<Agama>()
                .Property(o => o.Kode_Agama)
                .IsRequired(true);


            modelBuilder.Entity<Mahasiswa>()
                .Property(o => o.Kode_Mahasiswa)
                .IsRequired(true);
            modelBuilder.Entity<Mahasiswa>()
                .Property(o => o.Nama_Mahasiswa)
                .IsRequired(true);
            modelBuilder.Entity<Mahasiswa>()
                .Property(o => o.Alamat)
                .IsRequired(true);
            modelBuilder.Entity<Mahasiswa>()
                .Property(o => o.Kode_Agama)
                .IsRequired(true);
            modelBuilder.Entity<Mahasiswa>()
                .Property(o => o.Kode_Jurusan)
                .IsRequired(true);


           
            modelBuilder.Entity<Ujian>()
                .Property(o=>o.Kode_Ujian)
                .IsRequired(true);
            modelBuilder.Entity<Ujian>()
                .Property(o => o.Nama_Ujian)
                .IsRequired(true);
            modelBuilder.Entity<Ujian>()
                .Property(o => o.Status_Ujian)
                .IsRequired(true);


            modelBuilder.Entity<TypeDosen>()
                .Property(o => o.Kode_Type_Dosen)
                .IsRequired(true);
            modelBuilder.Entity<TypeDosen>()
                .Property(o => o.Deskripsi)
                .IsRequired(true);


            modelBuilder.Entity<Dosen>()
                .Property(o => o.Kode_Dosen)
                .IsRequired(true);
            modelBuilder.Entity<Dosen>()
                .Property(o => o.Nama_Dosen)
                .IsRequired(true);
            modelBuilder.Entity<Dosen>()
                .Property(o => o.Kode_Jurusan)
                .IsRequired(true);
            modelBuilder.Entity<Dosen>()
                .Property(o => o.Kode_Type_Dosen)
                .IsRequired(true);


            modelBuilder.Entity<Nilai>()
                .Property(o => o.Kode_Mahasiswa)
                .IsRequired(true);
            modelBuilder.Entity<Nilai>()
                .Property(o => o.Kode_Ujian)
                .IsRequired(true);
            modelBuilder.Entity<Nilai>()
                .Property(o => o.NilaiMahasiswa)
                .HasColumnType("decimal(8,2)");

        }

    }
    public static class ModelBuilderExtention
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jurusan>()
                .HasData(
                new Jurusan
                {
                    Id = 1,
                    Kode_Jurusan = "J001",
                    Nama_Jurusan = "Teknik Informatika",
                    Status_Jurusan = "Aktif",
                    Created_by = 1,
                    Created_on = DateTime.Now,
                },
                new Jurusan
                {
                    Id = 2,
                    Kode_Jurusan = "J002",
                    Nama_Jurusan = "Management Informatika",
                    Status_Jurusan = "Aktif",
                    Created_by = 1,
                    Created_on = DateTime.Now,
                },
                new Jurusan
                {
                    Id = 3,
                    Kode_Jurusan = "J003",
                    Nama_Jurusan = "Sistem Informasi",
                    Status_Jurusan = "Non Aktif",
                    Created_by = 1,
                    Created_on = DateTime.Now,
                },
                new Jurusan
                {
                    Id = 4,
                    Kode_Jurusan = "J004",
                    Nama_Jurusan = "Sistem Komputer",
                    Status_Jurusan = "Aktif",
                    Created_by = 1,
                    Created_on = DateTime.Now,
                },
                new Jurusan
                {
                    Id = 5,
                    Kode_Jurusan = "J005",
                    Nama_Jurusan = "Komputer Akuntansi",
                    Status_Jurusan = "Non Aktif",
                    Created_by = 1,
                    Created_on = DateTime.Now,
                }
                );
            modelBuilder.Entity<Agama>()
                .HasData(
                new Agama
                {
                    Id = 1,
                    Kode_Agama = "A001",
                    Deskripsi = "Islam",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Agama
                {
                    Id = 2,
                    Kode_Agama = "A002",
                    Deskripsi = "Kristen",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Agama
                {
                    Id = 4,
                    Kode_Agama = "A003",
                    Deskripsi = "Katolik",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Agama
                {
                    Id = 4,
                    Kode_Agama = "A004",
                    Deskripsi = "Hindu",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Agama
                {
                    Id = 5,
                    Kode_Agama = "A005",
                    Deskripsi = "Budha",
                    Created_by = 1,
                    Created_on = DateTime.Now
                }
                );

            modelBuilder.Entity<Mahasiswa>()
                .HasData(
                new Mahasiswa
                {
                    Id = 1,
                    Kode_Mahasiswa = "M001",
                    Nama_Mahasiswa = "Budi Gunawan",
                    Alamat = "Jl. Mawar No 3 RT 05 Cicalengka, Bandung",
                    Kode_Agama = "A001",
                    Kode_Jurusan = "J001",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Mahasiswa
                {
                    Id = 2,
                    Kode_Mahasiswa = "M002",
                    Nama_Mahasiswa = "Rinto Raharjo",
                    Alamat = "Jl. Kebagusan No. 33 RT04 RW06 Bandung",
                    Kode_Agama = "A002",
                    Kode_Jurusan = "J002",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Mahasiswa
                {
                    Id = 3,
                    Kode_Mahasiswa = "M003",
                    Nama_Mahasiswa = "Asep Saepudin",
                    Alamat = "Jl. Sumatera No. 12 RT02 RW01, Ciamis",
                    Kode_Agama = "A001",
                    Kode_Jurusan = "J003",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Mahasiswa
                {
                    Id = 4,
                    Kode_Mahasiswa = "M004",
                    Nama_Mahasiswa = "M. Hafif Isbullah",
                    Alamat = "Jl. Jawa No 01 RT01 RW01, Jakarta Pusat",
                    Kode_Agama = "A001",
                    Kode_Jurusan = "J001",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Mahasiswa
                {
                    Id = 5,
                    Kode_Mahasiswa = "M005",
                    Nama_Mahasiswa = "Cahyono",
                    Alamat = "Jl. Niagara No. 54 RT01 RW09, Surabaya",
                    Kode_Agama = "A003",
                    Kode_Jurusan = "J002",
                    Created_by = 1,
                    Created_on = DateTime.Now
                }
                );
            modelBuilder.Entity<Ujian>()
                .HasData(
                new Ujian
                {
                    Id= 1,
                    Kode_Ujian = "U001",
                    Nama_Ujian = "Algoritma",
                    Status_Ujian = "Aktif",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Ujian
                {
                    Id = 2,
                    Kode_Ujian = "U002",
                    Nama_Ujian = "Aljabar",
                    Status_Ujian = "Aktif",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Ujian
                {
                    Id = 3,
                    Kode_Ujian = "U003",
                    Nama_Ujian = "Statistika",
                    Status_Ujian = "Non Aktif",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Ujian
                {
                    Id = 4,
                    Kode_Ujian = "U004",
                    Nama_Ujian = "Etika Profesi",
                    Status_Ujian = "Non Aktif",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Ujian
                {
                    Id = 5,
                    Kode_Ujian = "U005",
                    Nama_Ujian = "Bahasa Inggris",
                    Status_Ujian = "Aktif",
                    Created_by = 1,
                    Created_on = DateTime.Now
                }
                );

            modelBuilder.Entity<TypeDosen>()
                .HasData(
                new TypeDosen
                {
                    Id = 1,
                    Kode_Type_Dosen = "T001",
                    Deskripsi = "Tetap",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new TypeDosen
                {
                    Id = 2,
                    Kode_Type_Dosen = "T002",
                    Deskripsi = "Honorer",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new TypeDosen
                {
                    Id = 3,
                    Kode_Type_Dosen = "T003",
                    Deskripsi = "Expertise",
                    Created_by = 1,
                    Created_on = DateTime.Now
                }
                );

            modelBuilder.Entity<Dosen>()
                .HasData(
                new Dosen
                {
                    Id = 1,
                    Kode_Dosen = "D001",
                    Nama_Dosen = "Prof. Dr. Retno Wahyuningsih",
                    Kode_Jurusan = "J001",
                    Kode_Type_Dosen = "T002",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Dosen
                {
                    Id = 2,
                    Kode_Dosen = "D002",
                    Nama_Dosen = "Prof. Roy M. Sutikno",
                    Kode_Jurusan = "J002",
                    Kode_Type_Dosen = "T001",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Dosen
                {
                    Id = 3,
                    Kode_Dosen = "D003",
                    Nama_Dosen = "Prof. Hendri A. Verburgh",
                    Kode_Jurusan = "J003",
                    Kode_Type_Dosen = "T002",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Dosen
                {
                    Id = 4,
                    Kode_Dosen = "D004",
                    Nama_Dosen = "Prof. Risma Suparwata",
                    Kode_Jurusan = "J004",
                    Kode_Type_Dosen = "T002",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Dosen
                {
                    Id = 5,
                    Kode_Dosen = "D005",
                    Nama_Dosen = "Prof. Amir Sjarifuddin Madjid, MM, MA",
                    Kode_Jurusan = "J005",
                    Kode_Type_Dosen = "T001",
                    Created_by = 1,
                    Created_on = DateTime.Now
                }
                );

            modelBuilder.Entity<Nilai>()
                .HasData(
                new Nilai
                {
                    Id = 1,
                    Kode_Mahasiswa = "M004",
                    Kode_Ujian = "U001",
                    NilaiMahasiswa = 90,
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Nilai
                {
                    Id = 2,
                    Kode_Mahasiswa = "M001",
                    Kode_Ujian = "U001",
                    NilaiMahasiswa = 80,
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Nilai
                {
                    Id = 3,
                    Kode_Mahasiswa = "M002",
                    Kode_Ujian = "U003",
                    NilaiMahasiswa = 85,
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Nilai
                {
                    Id = 4,
                    Kode_Mahasiswa = "M004",
                    Kode_Ujian = "U002",
                    NilaiMahasiswa = 95,
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Nilai
                {
                    Id = 5,
                    Kode_Mahasiswa = "M005",
                    Kode_Ujian = "U005",
                    NilaiMahasiswa = 70,
                    Created_by = 1,
                    Created_on = DateTime.Now
                }
                );
        }
    }
}
