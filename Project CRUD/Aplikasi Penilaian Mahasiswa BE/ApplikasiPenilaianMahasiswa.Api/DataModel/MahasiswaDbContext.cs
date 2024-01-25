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
        public DbSet<Ujian> Ujians { get; set; }
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
                .Property(o => o.Id_Agama)
                .IsRequired(true);
            modelBuilder.Entity<Mahasiswa>()
                .Property(o => o.Id_Jurusan)
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
                .Property(o => o.Id_Jurusan)
                .IsRequired(true);
            modelBuilder.Entity<Dosen>()
                .Property(o => o.Id_Type_Dosen)
                .IsRequired(true);


            modelBuilder.Entity<Nilai>()
                .Property(o => o.Id_Mahasiswa)
                .IsRequired(true);
            modelBuilder.Entity<Nilai>()
                .Property(o => o.Id_Ujian)
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
                    Kode_Jurusan = "JUR-2401-0001",
                    Nama_Jurusan = "Teknik Informatika",
                    Status_Jurusan = "Aktif",
                    Created_by = 1,
                    Created_on = DateTime.Now,
                },
                new Jurusan
                {
                    Id = 2,
                    Kode_Jurusan = "JUR-2401-0002",
                    Nama_Jurusan = "Management Informatika",
                    Status_Jurusan = "Aktif",
                    Created_by = 1,
                    Created_on = DateTime.Now,
                },
                new Jurusan
                {
                    Id = 3,
                    Kode_Jurusan = "JUR-2401-0003",
                    Nama_Jurusan = "Sistem Informasi",
                    Status_Jurusan = "Non Aktif",
                    Created_by = 1,
                    Created_on = DateTime.Now,
                },
                new Jurusan
                {
                    Id = 4,
                    Kode_Jurusan = "JUR-2401-0004",
                    Nama_Jurusan = "Sistem Komputer",
                    Status_Jurusan = "Aktif",
                    Created_by = 1,
                    Created_on = DateTime.Now,
                },
                new Jurusan
                {
                    Id = 5,
                    Kode_Jurusan = "JUR-2401-0005",
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
                    Kode_Agama = "AGM-2401-0001",
                    Deskripsi = "Islam",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Agama
                {
                    Id = 2,
                    Kode_Agama = "AGM-2401-0002",
                    Deskripsi = "Kristen",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Agama
                {
                    Id = 3,
                    Kode_Agama = "AGM-2401-0003",
                    Deskripsi = "Katolik",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Agama
                {
                    Id = 4,
                    Kode_Agama = "AGM-2401-0004",
                    Deskripsi = "Hindu",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Agama
                {
                    Id = 5,
                    Kode_Agama = "AGM-2401-0005",
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
                    Kode_Mahasiswa = "MHS-2401-0001",
                    Nama_Mahasiswa = "Budi Gunawan",
                    Alamat = "Jl. Mawar No 3 RT 05 Cicalengka, Bandung",
                    Id_Agama = 1,
                    Id_Jurusan = 1,
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Mahasiswa
                {
                    Id = 2,
                    Kode_Mahasiswa = "MHS-2401-0002",
                    Nama_Mahasiswa = "Rinto Raharjo",
                    Alamat = "Jl. Kebagusan No. 33 RT04 RW06 Bandung",
                    Id_Agama = 2,
                    Id_Jurusan = 2,
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Mahasiswa
                {
                    Id = 3,
                    Kode_Mahasiswa = "MHS-2401-0003",
                    Nama_Mahasiswa = "Asep Saepudin",
                    Alamat = "Jl. Sumatera No. 12 RT02 RW01, Ciamis",
                    Id_Agama = 1,
                    Id_Jurusan = 3,
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Mahasiswa
                {
                    Id = 4,
                    Kode_Mahasiswa = "MHS-2401-0004",
                    Nama_Mahasiswa = "M. Hafif Isbullah",
                    Alamat = "Jl. Jawa No 01 RT01 RW01, Jakarta Pusat",
                    Id_Agama = 1,
                    Id_Jurusan = 1,
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Mahasiswa
                {
                    Id = 5,
                    Kode_Mahasiswa = "MHS-2401-0005",
                    Nama_Mahasiswa = "Cahyono",
                    Alamat = "Jl. Niagara No. 54 RT01 RW09, Surabaya",
                    Id_Agama = 3,
                    Id_Jurusan = 2,
                    Created_by = 1,
                    Created_on = DateTime.Now
                }
                );
            modelBuilder.Entity<Ujian>()
                .HasData(
                new Ujian
                {
                    Id= 1,
                    Kode_Ujian = "UJN-2401-0001",
                    Nama_Ujian = "Algoritma",
                    Status_Ujian = "Aktif",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Ujian
                {
                    Id = 2,
                    Kode_Ujian = "UJN-2401-0002",
                    Nama_Ujian = "Aljabar",
                    Status_Ujian = "Aktif",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Ujian
                {
                    Id = 3,
                    Kode_Ujian = "UJN-2401-0003",
                    Nama_Ujian = "Statistika",
                    Status_Ujian = "Non Aktif",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Ujian
                {
                    Id = 4,
                    Kode_Ujian = "UJN-2401-0004",
                    Nama_Ujian = "Etika Profesi",
                    Status_Ujian = "Non Aktif",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Ujian
                {
                    Id = 5,
                    Kode_Ujian = "UJN-2401-0005",
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
                    Kode_Type_Dosen = "TYP-2401-0001",
                    Deskripsi = "Tetap",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new TypeDosen
                {
                    Id = 2,
                    Kode_Type_Dosen = "TYP-2401-0002",
                    Deskripsi = "Honorer",
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new TypeDosen
                {
                    Id = 3,
                    Kode_Type_Dosen = "TYP-2401-0003",
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
                    Kode_Dosen = "DSN-2401-0001",
                    Nama_Dosen = "Prof. Dr. Retno Wahyuningsih",
                    Id_Jurusan = 1,
                    Id_Type_Dosen = 2,
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Dosen
                {
                    Id = 2,
                    Kode_Dosen = "DSN-2401-0002",
                    Nama_Dosen = "Prof. Roy M. Sutikno",
                    Id_Jurusan = 2,
                    Id_Type_Dosen = 1,
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Dosen
                {
                    Id = 3,
                    Kode_Dosen = "DSN-2401-0003",
                    Nama_Dosen = "Prof. Hendri A. Verburgh",
                    Id_Jurusan = 3,
                    Id_Type_Dosen = 2,
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Dosen
                {
                    Id = 4,
                    Kode_Dosen = "DSN-2401-0004",
                    Nama_Dosen = "Prof. Risma Suparwata",
                    Id_Jurusan = 4,
                    Id_Type_Dosen = 2,
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Dosen
                {
                    Id = 5,
                    Kode_Dosen = "DSN-2401-0005",
                    Nama_Dosen = "Prof. Amir Sjarifuddin Madjid, MM, MA",
                    Id_Jurusan = 5,
                    Id_Type_Dosen = 1,
                    Created_by = 1,
                    Created_on = DateTime.Now
                }
                );

            modelBuilder.Entity<Nilai>()
                .HasData(
                new Nilai
                {
                    Id = 1,
                    Id_Mahasiswa = 4,
                    Id_Ujian = 1,
                    NilaiMahasiswa = 90,
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Nilai
                {
                    Id = 2,
                    Id_Mahasiswa = 1,
                    Id_Ujian = 1,
                    NilaiMahasiswa = 80,
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Nilai
                {
                    Id = 3,
                    Id_Mahasiswa = 2,
                    Id_Ujian = 3,
                    NilaiMahasiswa = 85,
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Nilai
                {
                    Id = 4,
                    Id_Mahasiswa = 4,
                    Id_Ujian = 2,
                    NilaiMahasiswa = 95,
                    Created_by = 1,
                    Created_on = DateTime.Now
                },
                new Nilai
                {
                    Id = 5,
                    Id_Mahasiswa = 5,
                    Id_Ujian = 5,
                    NilaiMahasiswa = 70,
                    Created_by = 1,
                    Created_on = DateTime.Now
                }
                );
        }
    }
}
