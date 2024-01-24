using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApplikasiPenilaianMahasiswa.Api.Migrations
{
    /// <inheritdoc />
    public partial class initdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "m_agama",
                columns: table => new
                {
                    Kode_Agama = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deskripsi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Created_by = table.Column<long>(type: "bigint", maxLength: 50, nullable: false),
                    Created_on = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_by = table.Column<long>(type: "bigint", maxLength: 50, nullable: true),
                    Modified_on = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_by = table.Column<long>(type: "bigint", maxLength: 50, nullable: true),
                    Deleted_on = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_agama", x => x.Kode_Agama);
                });

            migrationBuilder.CreateTable(
                name: "m_jurusan",
                columns: table => new
                {
                    Kode_Jurusan = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nama_Jurusan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status_Jurusan = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_by = table.Column<long>(type: "bigint", maxLength: 50, nullable: false),
                    Created_on = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_by = table.Column<long>(type: "bigint", maxLength: 50, nullable: true),
                    Modified_on = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_by = table.Column<long>(type: "bigint", maxLength: 50, nullable: true),
                    Deleted_on = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_jurusan", x => x.Kode_Jurusan);
                });

            migrationBuilder.CreateTable(
                name: "m_type_dosen",
                columns: table => new
                {
                    Kode_Type_Dosen = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deskripsi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Created_by = table.Column<long>(type: "bigint", maxLength: 50, nullable: false),
                    Created_on = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_by = table.Column<long>(type: "bigint", maxLength: 50, nullable: true),
                    Modified_on = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_by = table.Column<long>(type: "bigint", maxLength: 50, nullable: true),
                    Deleted_on = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_type_dosen", x => x.Kode_Type_Dosen);
                });

            migrationBuilder.CreateTable(
                name: "m_ujian",
                columns: table => new
                {
                    Kode_Ujian = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nama_Ujian = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status_Ujian = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Created_by = table.Column<long>(type: "bigint", maxLength: 50, nullable: false),
                    Created_on = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_by = table.Column<long>(type: "bigint", maxLength: 50, nullable: true),
                    Modified_on = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_by = table.Column<long>(type: "bigint", maxLength: 50, nullable: true),
                    Deleted_on = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_ujian", x => x.Kode_Ujian);
                });

            migrationBuilder.CreateTable(
                name: "m_mahasiswa",
                columns: table => new
                {
                    Kode_Mahasiswa = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nama_Mahasiswa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Alamat = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Kode_Agama = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Kode_Jurusan = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Created_by = table.Column<long>(type: "bigint", maxLength: 50, nullable: false),
                    Created_on = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_by = table.Column<long>(type: "bigint", maxLength: 50, nullable: true),
                    Modified_on = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_by = table.Column<long>(type: "bigint", maxLength: 50, nullable: true),
                    Deleted_on = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_mahasiswa", x => x.Kode_Mahasiswa);
                    table.ForeignKey(
                        name: "FK_m_mahasiswa_m_agama_Kode_Agama",
                        column: x => x.Kode_Agama,
                        principalTable: "m_agama",
                        principalColumn: "Kode_Agama",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_m_mahasiswa_m_jurusan_Kode_Jurusan",
                        column: x => x.Kode_Jurusan,
                        principalTable: "m_jurusan",
                        principalColumn: "Kode_Jurusan",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "m_dosen",
                columns: table => new
                {
                    Kode_Dosen = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nama_Dosen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Kode_Jurusan = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Kode_Type_Dosen = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Created_by = table.Column<long>(type: "bigint", maxLength: 50, nullable: false),
                    Created_on = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_by = table.Column<long>(type: "bigint", maxLength: 50, nullable: true),
                    Modified_on = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_by = table.Column<long>(type: "bigint", maxLength: 50, nullable: true),
                    Deleted_on = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_dosen", x => x.Kode_Dosen);
                    table.ForeignKey(
                        name: "FK_m_dosen_m_jurusan_Kode_Jurusan",
                        column: x => x.Kode_Jurusan,
                        principalTable: "m_jurusan",
                        principalColumn: "Kode_Jurusan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_m_dosen_m_type_dosen_Kode_Type_Dosen",
                        column: x => x.Kode_Type_Dosen,
                        principalTable: "m_type_dosen",
                        principalColumn: "Kode_Type_Dosen",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "m_nilai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kode_Mahasiswa = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Kode_Ujian = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    NilaiMahasiswa = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Created_by = table.Column<long>(type: "bigint", maxLength: 50, nullable: false),
                    Created_on = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_by = table.Column<long>(type: "bigint", maxLength: 50, nullable: true),
                    Modified_on = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_by = table.Column<long>(type: "bigint", maxLength: 50, nullable: true),
                    Deleted_on = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_nilai", x => x.Id);
                    table.ForeignKey(
                        name: "FK_m_nilai_m_mahasiswa_Kode_Mahasiswa",
                        column: x => x.Kode_Mahasiswa,
                        principalTable: "m_mahasiswa",
                        principalColumn: "Kode_Mahasiswa",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_m_nilai_m_ujian_Kode_Ujian",
                        column: x => x.Kode_Ujian,
                        principalTable: "m_ujian",
                        principalColumn: "Kode_Ujian",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "m_agama",
                columns: new[] { "Kode_Agama", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Deskripsi", "Id", "Is_delete", "Modified_by", "Modified_on" },
                values: new object[,]
                {
                    { "A001", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1325), null, null, "Islam", 1, false, null, null },
                    { "A002", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1327), null, null, "Kristen", 2, false, null, null },
                    { "A003", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1328), null, null, "Katolik", 4, false, null, null },
                    { "A004", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1329), null, null, "Hindu", 4, false, null, null },
                    { "A005", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1331), null, null, "Budha", 5, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "m_jurusan",
                columns: new[] { "Kode_Jurusan", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Id", "Is_delete", "Modified_by", "Modified_on", "Nama_Jurusan", "Status_Jurusan" },
                values: new object[,]
                {
                    { "J001", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1156), null, null, 1, false, null, null, "Teknik Informatika", "Aktif" },
                    { "J002", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1170), null, null, 2, false, null, null, "Management Informatika", "Aktif" },
                    { "J003", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1172), null, null, 3, false, null, null, "Sistem Informasi", "Non Aktif" },
                    { "J004", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1173), null, null, 4, false, null, null, "Sistem Komputer", "Aktif" },
                    { "J005", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1174), null, null, 5, false, null, null, "Komputer Akuntansi", "Non Aktif" }
                });

            migrationBuilder.InsertData(
                table: "m_type_dosen",
                columns: new[] { "Kode_Type_Dosen", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Deskripsi", "Id", "Is_delete", "Modified_by", "Modified_on" },
                values: new object[,]
                {
                    { "T001", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1415), null, null, "Tetap", 1, false, null, null },
                    { "T002", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1417), null, null, "Honorer", 2, false, null, null },
                    { "T003", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1418), null, null, "Expertise", 3, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "m_ujian",
                columns: new[] { "Kode_Ujian", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Id", "Is_delete", "Modified_by", "Modified_on", "Nama_Ujian", "Status_Ujian" },
                values: new object[,]
                {
                    { "U001", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1386), null, null, 1, false, null, null, "Algoritma", "Aktif" },
                    { "U002", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1387), null, null, 2, false, null, null, "Aljabar", "Aktif" },
                    { "U003", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1389), null, null, 3, false, null, null, "Statistika", "Non Aktif" },
                    { "U004", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1390), null, null, 4, false, null, null, "Etika Profesi", "Non Aktif" },
                    { "U005", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1392), null, null, 5, false, null, null, "Bahasa Inggris", "Aktif" }
                });

            migrationBuilder.InsertData(
                table: "m_dosen",
                columns: new[] { "Kode_Dosen", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Id", "Is_delete", "Kode_Jurusan", "Kode_Type_Dosen", "Modified_by", "Modified_on", "Nama_Dosen" },
                values: new object[,]
                {
                    { "D001", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1441), null, null, 1, false, "J001", "T002", null, null, "Prof. Dr. Retno Wahyuningsih" },
                    { "D002", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1442), null, null, 2, false, "J002", "T001", null, null, "Prof. Roy M. Sutikno" },
                    { "D003", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1444), null, null, 3, false, "J003", "T002", null, null, "Prof. Hendri A. Verburgh" },
                    { "D004", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1445), null, null, 4, false, "J004", "T002", null, null, "Prof. Risma Suparwata" },
                    { "D005", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1447), null, null, 5, false, "J005", "T001", null, null, "Prof. Amir Sjarifuddin Madjid, MM, MA" }
                });

            migrationBuilder.InsertData(
                table: "m_mahasiswa",
                columns: new[] { "Kode_Mahasiswa", "Alamat", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Id", "Is_delete", "Kode_Agama", "Kode_Jurusan", "Modified_by", "Modified_on", "Nama_Mahasiswa" },
                values: new object[,]
                {
                    { "M001", "Jl. Mawar No 3 RT 05 Cicalengka, Bandung", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1354), null, null, 1, false, "A001", "J001", null, null, "Budi Gunawan" },
                    { "M002", "Jl. Kebagusan No. 33 RT04 RW06 Bandung", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1356), null, null, 2, false, "A002", "J002", null, null, "Rinto Raharjo" },
                    { "M003", "Jl. Sumatera No. 12 RT02 RW01, Ciamis", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1358), null, null, 3, false, "A001", "J003", null, null, "Asep Saepudin" },
                    { "M004", "Jl. Jawa No 01 RT01 RW01, Jakarta Pusat", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1360), null, null, 4, false, "A001", "J001", null, null, "M. Hafif Isbullah" },
                    { "M005", "Jl. Niagara No. 54 RT01 RW09, Surabaya", 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1361), null, null, 5, false, "A003", "J002", null, null, "Cahyono" }
                });

            migrationBuilder.InsertData(
                table: "m_nilai",
                columns: new[] { "Id", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Is_delete", "Kode_Mahasiswa", "Kode_Ujian", "Modified_by", "Modified_on", "NilaiMahasiswa" },
                values: new object[,]
                {
                    { 1, 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1468), null, null, false, "M004", "U001", null, null, 90m },
                    { 2, 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1524), null, null, false, "M001", "U001", null, null, 80m },
                    { 3, 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1525), null, null, false, "M002", "U003", null, null, 85m },
                    { 4, 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1527), null, null, false, "M004", "U002", null, null, 95m },
                    { 5, 1L, new DateTime(2024, 1, 24, 17, 2, 38, 684, DateTimeKind.Local).AddTicks(1528), null, null, false, "M005", "U005", null, null, 70m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_m_dosen_Kode_Jurusan",
                table: "m_dosen",
                column: "Kode_Jurusan");

            migrationBuilder.CreateIndex(
                name: "IX_m_dosen_Kode_Type_Dosen",
                table: "m_dosen",
                column: "Kode_Type_Dosen");

            migrationBuilder.CreateIndex(
                name: "IX_m_mahasiswa_Kode_Agama",
                table: "m_mahasiswa",
                column: "Kode_Agama");

            migrationBuilder.CreateIndex(
                name: "IX_m_mahasiswa_Kode_Jurusan",
                table: "m_mahasiswa",
                column: "Kode_Jurusan");

            migrationBuilder.CreateIndex(
                name: "IX_m_nilai_Kode_Mahasiswa",
                table: "m_nilai",
                column: "Kode_Mahasiswa");

            migrationBuilder.CreateIndex(
                name: "IX_m_nilai_Kode_Ujian",
                table: "m_nilai",
                column: "Kode_Ujian");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "m_dosen");

            migrationBuilder.DropTable(
                name: "m_nilai");

            migrationBuilder.DropTable(
                name: "m_type_dosen");

            migrationBuilder.DropTable(
                name: "m_mahasiswa");

            migrationBuilder.DropTable(
                name: "m_ujian");

            migrationBuilder.DropTable(
                name: "m_agama");

            migrationBuilder.DropTable(
                name: "m_jurusan");
        }
    }
}
