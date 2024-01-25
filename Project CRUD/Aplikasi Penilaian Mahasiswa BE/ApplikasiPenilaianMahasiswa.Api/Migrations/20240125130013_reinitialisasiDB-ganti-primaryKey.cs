using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApplikasiPenilaianMahasiswa.Api.Migrations
{
    /// <inheritdoc />
    public partial class reinitialisasiDBgantiprimaryKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_m_dosen_m_jurusan_Kode_Jurusan",
                table: "m_dosen");

            migrationBuilder.DropForeignKey(
                name: "FK_m_dosen_m_type_dosen_Kode_Type_Dosen",
                table: "m_dosen");

            migrationBuilder.DropForeignKey(
                name: "FK_m_mahasiswa_m_agama_Kode_Agama",
                table: "m_mahasiswa");

            migrationBuilder.DropForeignKey(
                name: "FK_m_mahasiswa_m_jurusan_Kode_Jurusan",
                table: "m_mahasiswa");

            migrationBuilder.DropForeignKey(
                name: "FK_m_nilai_m_mahasiswa_Kode_Mahasiswa",
                table: "m_nilai");

            migrationBuilder.DropForeignKey(
                name: "FK_m_nilai_m_ujian_Kode_Ujian",
                table: "m_nilai");

            migrationBuilder.DropPrimaryKey(
                name: "PK_m_ujian",
                table: "m_ujian");

            migrationBuilder.DropPrimaryKey(
                name: "PK_m_type_dosen",
                table: "m_type_dosen");

            migrationBuilder.DropIndex(
                name: "IX_m_nilai_Kode_Mahasiswa",
                table: "m_nilai");

            migrationBuilder.DropIndex(
                name: "IX_m_nilai_Kode_Ujian",
                table: "m_nilai");

            migrationBuilder.DropPrimaryKey(
                name: "PK_m_mahasiswa",
                table: "m_mahasiswa");

            migrationBuilder.DropIndex(
                name: "IX_m_mahasiswa_Kode_Agama",
                table: "m_mahasiswa");

            migrationBuilder.DropIndex(
                name: "IX_m_mahasiswa_Kode_Jurusan",
                table: "m_mahasiswa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_m_jurusan",
                table: "m_jurusan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_m_dosen",
                table: "m_dosen");

            migrationBuilder.DropIndex(
                name: "IX_m_dosen_Kode_Jurusan",
                table: "m_dosen");

            migrationBuilder.DropIndex(
                name: "IX_m_dosen_Kode_Type_Dosen",
                table: "m_dosen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_m_agama",
                table: "m_agama");

            migrationBuilder.DeleteData(
                table: "m_agama",
                keyColumn: "Kode_Agama",
                keyValue: "A004");

            migrationBuilder.DeleteData(
                table: "m_agama",
                keyColumn: "Kode_Agama",
                keyValue: "A005");

            migrationBuilder.DeleteData(
                table: "m_dosen",
                keyColumn: "Kode_Dosen",
                keyValue: "D001");

            migrationBuilder.DeleteData(
                table: "m_dosen",
                keyColumn: "Kode_Dosen",
                keyValue: "D002");

            migrationBuilder.DeleteData(
                table: "m_dosen",
                keyColumn: "Kode_Dosen",
                keyValue: "D003");

            migrationBuilder.DeleteData(
                table: "m_dosen",
                keyColumn: "Kode_Dosen",
                keyValue: "D004");

            migrationBuilder.DeleteData(
                table: "m_dosen",
                keyColumn: "Kode_Dosen",
                keyValue: "D005");

            migrationBuilder.DeleteData(
                table: "m_mahasiswa",
                keyColumn: "Kode_Mahasiswa",
                keyValue: "M001");

            migrationBuilder.DeleteData(
                table: "m_mahasiswa",
                keyColumn: "Kode_Mahasiswa",
                keyValue: "M002");

            migrationBuilder.DeleteData(
                table: "m_mahasiswa",
                keyColumn: "Kode_Mahasiswa",
                keyValue: "M003");

            migrationBuilder.DeleteData(
                table: "m_mahasiswa",
                keyColumn: "Kode_Mahasiswa",
                keyValue: "M004");

            migrationBuilder.DeleteData(
                table: "m_mahasiswa",
                keyColumn: "Kode_Mahasiswa",
                keyValue: "M005");

            migrationBuilder.DeleteData(
                table: "m_type_dosen",
                keyColumn: "Kode_Type_Dosen",
                keyValue: "T003");

            migrationBuilder.DeleteData(
                table: "m_ujian",
                keyColumn: "Kode_Ujian",
                keyValue: "U001");

            migrationBuilder.DeleteData(
                table: "m_ujian",
                keyColumn: "Kode_Ujian",
                keyValue: "U002");

            migrationBuilder.DeleteData(
                table: "m_ujian",
                keyColumn: "Kode_Ujian",
                keyValue: "U003");

            migrationBuilder.DeleteData(
                table: "m_ujian",
                keyColumn: "Kode_Ujian",
                keyValue: "U004");

            migrationBuilder.DeleteData(
                table: "m_ujian",
                keyColumn: "Kode_Ujian",
                keyValue: "U005");

            migrationBuilder.DeleteData(
                table: "m_agama",
                keyColumn: "Kode_Agama",
                keyValue: "A001");

            migrationBuilder.DeleteData(
                table: "m_agama",
                keyColumn: "Kode_Agama",
                keyValue: "A002");

            migrationBuilder.DeleteData(
                table: "m_agama",
                keyColumn: "Kode_Agama",
                keyValue: "A003");

            migrationBuilder.DeleteData(
                table: "m_jurusan",
                keyColumn: "Kode_Jurusan",
                keyValue: "J001");

            migrationBuilder.DeleteData(
                table: "m_jurusan",
                keyColumn: "Kode_Jurusan",
                keyValue: "J002");

            migrationBuilder.DeleteData(
                table: "m_jurusan",
                keyColumn: "Kode_Jurusan",
                keyValue: "J003");

            migrationBuilder.DeleteData(
                table: "m_jurusan",
                keyColumn: "Kode_Jurusan",
                keyValue: "J004");

            migrationBuilder.DeleteData(
                table: "m_jurusan",
                keyColumn: "Kode_Jurusan",
                keyValue: "J005");

            migrationBuilder.DeleteData(
                table: "m_type_dosen",
                keyColumn: "Kode_Type_Dosen",
                keyValue: "T001");

            migrationBuilder.DeleteData(
                table: "m_type_dosen",
                keyColumn: "Kode_Type_Dosen",
                keyValue: "T002");

            migrationBuilder.DropColumn(
                name: "Kode_Mahasiswa",
                table: "m_nilai");

            migrationBuilder.DropColumn(
                name: "Kode_Ujian",
                table: "m_nilai");

            migrationBuilder.DropColumn(
                name: "Kode_Agama",
                table: "m_mahasiswa");

            migrationBuilder.DropColumn(
                name: "Kode_Jurusan",
                table: "m_mahasiswa");

            migrationBuilder.DropColumn(
                name: "Kode_Jurusan",
                table: "m_dosen");

            migrationBuilder.DropColumn(
                name: "Kode_Type_Dosen",
                table: "m_dosen");

            migrationBuilder.AddColumn<int>(
                name: "Id_Mahasiswa",
                table: "m_nilai",
                type: "int",
                maxLength: 5,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_Ujian",
                table: "m_nilai",
                type: "int",
                maxLength: 5,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_Agama",
                table: "m_mahasiswa",
                type: "int",
                maxLength: 5,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_Jurusan",
                table: "m_mahasiswa",
                type: "int",
                maxLength: 5,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_Jurusan",
                table: "m_dosen",
                type: "int",
                maxLength: 5,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_Type_Dosen",
                table: "m_dosen",
                type: "int",
                maxLength: 5,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_ujian",
                table: "m_ujian",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_type_dosen",
                table: "m_type_dosen",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_mahasiswa",
                table: "m_mahasiswa",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_jurusan",
                table: "m_jurusan",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_dosen",
                table: "m_dosen",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_agama",
                table: "m_agama",
                column: "Id");

            migrationBuilder.InsertData(
                table: "m_agama",
                columns: new[] { "Id", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Deskripsi", "Is_delete", "Kode_Agama", "Modified_by", "Modified_on" },
                values: new object[,]
                {
                    { 1, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9439), null, null, "Islam", false, "A001", null, null },
                    { 2, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9443), null, null, "Kristen", false, "A002", null, null },
                    { 3, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9446), null, null, "Katolik", false, "A003", null, null },
                    { 4, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9450), null, null, "Hindu", false, "A004", null, null },
                    { 5, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9453), null, null, "Budha", false, "A005", null, null }
                });

            migrationBuilder.InsertData(
                table: "m_jurusan",
                columns: new[] { "Id", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Is_delete", "Kode_Jurusan", "Modified_by", "Modified_on", "Nama_Jurusan", "Status_Jurusan" },
                values: new object[,]
                {
                    { 1, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9132), null, null, false, "J001", null, null, "Teknik Informatika", "Aktif" },
                    { 2, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9150), null, null, false, "J002", null, null, "Management Informatika", "Aktif" },
                    { 3, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9154), null, null, false, "J003", null, null, "Sistem Informasi", "Non Aktif" },
                    { 4, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9158), null, null, false, "J004", null, null, "Sistem Komputer", "Aktif" },
                    { 5, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9161), null, null, false, "J005", null, null, "Komputer Akuntansi", "Non Aktif" }
                });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Id_Mahasiswa", "Id_Ujian" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9756), 4, 1 });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Id_Mahasiswa", "Id_Ujian" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9760), 1, 1 });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Id_Mahasiswa", "Id_Ujian" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9763), 2, 3 });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Id_Mahasiswa", "Id_Ujian" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9767), 4, 2 });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Id_Mahasiswa", "Id_Ujian" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9771), 5, 5 });

            migrationBuilder.InsertData(
                table: "m_type_dosen",
                columns: new[] { "Id", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Deskripsi", "Is_delete", "Kode_Type_Dosen", "Modified_by", "Modified_on" },
                values: new object[,]
                {
                    { 1, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9625), null, null, "Tetap", false, "T001", null, null },
                    { 2, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9629), null, null, "Honorer", false, "T002", null, null },
                    { 3, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9632), null, null, "Expertise", false, "T003", null, null }
                });

            migrationBuilder.InsertData(
                table: "m_ujian",
                columns: new[] { "Id", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Is_delete", "Kode_Ujian", "Modified_by", "Modified_on", "Nama_Ujian", "Status_Ujian" },
                values: new object[,]
                {
                    { 1, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9567), null, null, false, "U001", null, null, "Algoritma", "Aktif" },
                    { 2, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9571), null, null, false, "U002", null, null, "Aljabar", "Aktif" },
                    { 3, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9574), null, null, false, "U003", null, null, "Statistika", "Non Aktif" },
                    { 4, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9578), null, null, false, "U004", null, null, "Etika Profesi", "Non Aktif" },
                    { 5, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9582), null, null, false, "U005", null, null, "Bahasa Inggris", "Aktif" }
                });

            migrationBuilder.InsertData(
                table: "m_dosen",
                columns: new[] { "Id", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Id_Jurusan", "Id_Type_Dosen", "Is_delete", "Kode_Dosen", "Modified_by", "Modified_on", "Nama_Dosen" },
                values: new object[,]
                {
                    { 1, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9670), null, null, 1, 2, false, "D001", null, null, "Prof. Dr. Retno Wahyuningsih" },
                    { 2, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9674), null, null, 2, 1, false, "D002", null, null, "Prof. Roy M. Sutikno" },
                    { 3, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9678), null, null, 3, 2, false, "D003", null, null, "Prof. Hendri A. Verburgh" },
                    { 4, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9697), null, null, 4, 2, false, "D004", null, null, "Prof. Risma Suparwata" },
                    { 5, 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9701), null, null, 5, 1, false, "D005", null, null, "Prof. Amir Sjarifuddin Madjid, MM, MA" }
                });

            migrationBuilder.InsertData(
                table: "m_mahasiswa",
                columns: new[] { "Id", "Alamat", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Id_Agama", "Id_Jurusan", "Is_delete", "Kode_Mahasiswa", "Modified_by", "Modified_on", "Nama_Mahasiswa" },
                values: new object[,]
                {
                    { 1, "Jl. Mawar No 3 RT 05 Cicalengka, Bandung", 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9501), null, null, 1, 1, false, "M001", null, null, "Budi Gunawan" },
                    { 2, "Jl. Kebagusan No. 33 RT04 RW06 Bandung", 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9505), null, null, 2, 2, false, "M002", null, null, "Rinto Raharjo" },
                    { 3, "Jl. Sumatera No. 12 RT02 RW01, Ciamis", 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9509), null, null, 1, 3, false, "M003", null, null, "Asep Saepudin" },
                    { 4, "Jl. Jawa No 01 RT01 RW01, Jakarta Pusat", 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9513), null, null, 1, 1, false, "M004", null, null, "M. Hafif Isbullah" },
                    { 5, "Jl. Niagara No. 54 RT01 RW09, Surabaya", 1L, new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9517), null, null, 3, 2, false, "M005", null, null, "Cahyono" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_m_nilai_Id_Mahasiswa",
                table: "m_nilai",
                column: "Id_Mahasiswa");

            migrationBuilder.CreateIndex(
                name: "IX_m_nilai_Id_Ujian",
                table: "m_nilai",
                column: "Id_Ujian");

            migrationBuilder.CreateIndex(
                name: "IX_m_mahasiswa_Id_Agama",
                table: "m_mahasiswa",
                column: "Id_Agama");

            migrationBuilder.CreateIndex(
                name: "IX_m_mahasiswa_Id_Jurusan",
                table: "m_mahasiswa",
                column: "Id_Jurusan");

            migrationBuilder.CreateIndex(
                name: "IX_m_dosen_Id_Jurusan",
                table: "m_dosen",
                column: "Id_Jurusan");

            migrationBuilder.CreateIndex(
                name: "IX_m_dosen_Id_Type_Dosen",
                table: "m_dosen",
                column: "Id_Type_Dosen");

            migrationBuilder.AddForeignKey(
                name: "FK_m_dosen_m_jurusan_Id_Jurusan",
                table: "m_dosen",
                column: "Id_Jurusan",
                principalTable: "m_jurusan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_m_dosen_m_type_dosen_Id_Type_Dosen",
                table: "m_dosen",
                column: "Id_Type_Dosen",
                principalTable: "m_type_dosen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_m_mahasiswa_m_agama_Id_Agama",
                table: "m_mahasiswa",
                column: "Id_Agama",
                principalTable: "m_agama",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_m_mahasiswa_m_jurusan_Id_Jurusan",
                table: "m_mahasiswa",
                column: "Id_Jurusan",
                principalTable: "m_jurusan",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_m_nilai_m_mahasiswa_Id_Mahasiswa",
                table: "m_nilai",
                column: "Id_Mahasiswa",
                principalTable: "m_mahasiswa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_m_nilai_m_ujian_Id_Ujian",
                table: "m_nilai",
                column: "Id_Ujian",
                principalTable: "m_ujian",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_m_dosen_m_jurusan_Id_Jurusan",
                table: "m_dosen");

            migrationBuilder.DropForeignKey(
                name: "FK_m_dosen_m_type_dosen_Id_Type_Dosen",
                table: "m_dosen");

            migrationBuilder.DropForeignKey(
                name: "FK_m_mahasiswa_m_agama_Id_Agama",
                table: "m_mahasiswa");

            migrationBuilder.DropForeignKey(
                name: "FK_m_mahasiswa_m_jurusan_Id_Jurusan",
                table: "m_mahasiswa");

            migrationBuilder.DropForeignKey(
                name: "FK_m_nilai_m_mahasiswa_Id_Mahasiswa",
                table: "m_nilai");

            migrationBuilder.DropForeignKey(
                name: "FK_m_nilai_m_ujian_Id_Ujian",
                table: "m_nilai");

            migrationBuilder.DropPrimaryKey(
                name: "PK_m_ujian",
                table: "m_ujian");

            migrationBuilder.DropPrimaryKey(
                name: "PK_m_type_dosen",
                table: "m_type_dosen");

            migrationBuilder.DropIndex(
                name: "IX_m_nilai_Id_Mahasiswa",
                table: "m_nilai");

            migrationBuilder.DropIndex(
                name: "IX_m_nilai_Id_Ujian",
                table: "m_nilai");

            migrationBuilder.DropPrimaryKey(
                name: "PK_m_mahasiswa",
                table: "m_mahasiswa");

            migrationBuilder.DropIndex(
                name: "IX_m_mahasiswa_Id_Agama",
                table: "m_mahasiswa");

            migrationBuilder.DropIndex(
                name: "IX_m_mahasiswa_Id_Jurusan",
                table: "m_mahasiswa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_m_jurusan",
                table: "m_jurusan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_m_dosen",
                table: "m_dosen");

            migrationBuilder.DropIndex(
                name: "IX_m_dosen_Id_Jurusan",
                table: "m_dosen");

            migrationBuilder.DropIndex(
                name: "IX_m_dosen_Id_Type_Dosen",
                table: "m_dosen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_m_agama",
                table: "m_agama");

            migrationBuilder.DeleteData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Id_Mahasiswa",
                table: "m_nilai");

            migrationBuilder.DropColumn(
                name: "Id_Ujian",
                table: "m_nilai");

            migrationBuilder.DropColumn(
                name: "Id_Agama",
                table: "m_mahasiswa");

            migrationBuilder.DropColumn(
                name: "Id_Jurusan",
                table: "m_mahasiswa");

            migrationBuilder.DropColumn(
                name: "Id_Jurusan",
                table: "m_dosen");

            migrationBuilder.DropColumn(
                name: "Id_Type_Dosen",
                table: "m_dosen");

            migrationBuilder.AddColumn<string>(
                name: "Kode_Mahasiswa",
                table: "m_nilai",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Kode_Ujian",
                table: "m_nilai",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Kode_Agama",
                table: "m_mahasiswa",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Kode_Jurusan",
                table: "m_mahasiswa",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Kode_Jurusan",
                table: "m_dosen",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Kode_Type_Dosen",
                table: "m_dosen",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_ujian",
                table: "m_ujian",
                column: "Kode_Ujian");

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_type_dosen",
                table: "m_type_dosen",
                column: "Kode_Type_Dosen");

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_mahasiswa",
                table: "m_mahasiswa",
                column: "Kode_Mahasiswa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_jurusan",
                table: "m_jurusan",
                column: "Kode_Jurusan");

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_dosen",
                table: "m_dosen",
                column: "Kode_Dosen");

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_agama",
                table: "m_agama",
                column: "Kode_Agama");

            migrationBuilder.InsertData(
                table: "m_agama",
                columns: new[] { "Kode_Agama", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Deskripsi", "Id", "Is_delete", "Modified_by", "Modified_on" },
                values: new object[,]
                {
                    { "A001", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1294), null, null, "Islam", 1, false, null, null },
                    { "A002", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1296), null, null, "Kristen", 2, false, null, null },
                    { "A003", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1298), null, null, "Katolik", 4, false, null, null },
                    { "A004", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1299), null, null, "Hindu", 4, false, null, null },
                    { "A005", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1300), null, null, "Budha", 5, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "m_jurusan",
                columns: new[] { "Kode_Jurusan", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Id", "Is_delete", "Modified_by", "Modified_on", "Nama_Jurusan", "Status_Jurusan" },
                values: new object[,]
                {
                    { "J001", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1149), null, null, 1, false, null, null, "Teknik Informatika", "Aktif" },
                    { "J002", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1161), null, null, 2, false, null, null, "Management Informatika", "Aktif" },
                    { "J003", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1162), null, null, 3, false, null, null, "Sistem Informasi", "Non Aktif" },
                    { "J004", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1164), null, null, 4, false, null, null, "Sistem Komputer", "Aktif" },
                    { "J005", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1165), null, null, 5, false, null, null, "Komputer Akuntansi", "Non Aktif" }
                });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Kode_Mahasiswa", "Kode_Ujian" },
                values: new object[] { new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1444), "M004", "U001" });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Kode_Mahasiswa", "Kode_Ujian" },
                values: new object[] { new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1445), "M001", "U001" });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Kode_Mahasiswa", "Kode_Ujian" },
                values: new object[] { new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1447), "M002", "U003" });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Kode_Mahasiswa", "Kode_Ujian" },
                values: new object[] { new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1448), "M004", "U002" });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Kode_Mahasiswa", "Kode_Ujian" },
                values: new object[] { new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1449), "M005", "U005" });

            migrationBuilder.InsertData(
                table: "m_type_dosen",
                columns: new[] { "Kode_Type_Dosen", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Deskripsi", "Id", "Is_delete", "Modified_by", "Modified_on" },
                values: new object[,]
                {
                    { "T001", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1384), null, null, "Tetap", 1, false, null, null },
                    { "T002", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1386), null, null, "Honorer", 2, false, null, null },
                    { "T003", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1388), null, null, "Expertise", 3, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "m_ujian",
                columns: new[] { "Kode_Ujian", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Id", "Is_delete", "Modified_by", "Modified_on", "Nama_Ujian", "Status_Ujian" },
                values: new object[,]
                {
                    { "U001", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1353), null, null, 1, false, null, null, "Algoritma", "Aktif" },
                    { "U002", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1354), null, null, 2, false, null, null, "Aljabar", "Aktif" },
                    { "U003", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1355), null, null, 3, false, null, null, "Statistika", "Non Aktif" },
                    { "U004", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1357), null, null, 4, false, null, null, "Etika Profesi", "Non Aktif" },
                    { "U005", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1358), null, null, 5, false, null, null, "Bahasa Inggris", "Aktif" }
                });

            migrationBuilder.InsertData(
                table: "m_dosen",
                columns: new[] { "Kode_Dosen", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Id", "Is_delete", "Kode_Jurusan", "Kode_Type_Dosen", "Modified_by", "Modified_on", "Nama_Dosen" },
                values: new object[,]
                {
                    { "D001", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1405), null, null, 1, false, "J001", "T002", null, null, "Prof. Dr. Retno Wahyuningsih" },
                    { "D002", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1407), null, null, 2, false, "J002", "T001", null, null, "Prof. Roy M. Sutikno" },
                    { "D003", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1416), null, null, 3, false, "J003", "T002", null, null, "Prof. Hendri A. Verburgh" },
                    { "D004", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1418), null, null, 4, false, "J004", "T002", null, null, "Prof. Risma Suparwata" },
                    { "D005", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1419), null, null, 5, false, "J005", "T001", null, null, "Prof. Amir Sjarifuddin Madjid, MM, MA" }
                });

            migrationBuilder.InsertData(
                table: "m_mahasiswa",
                columns: new[] { "Kode_Mahasiswa", "Alamat", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Id", "Is_delete", "Kode_Agama", "Kode_Jurusan", "Modified_by", "Modified_on", "Nama_Mahasiswa" },
                values: new object[,]
                {
                    { "M001", "Jl. Mawar No 3 RT 05 Cicalengka, Bandung", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1325), null, null, 1, false, "A001", "J001", null, null, "Budi Gunawan" },
                    { "M002", "Jl. Kebagusan No. 33 RT04 RW06 Bandung", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1326), null, null, 2, false, "A002", "J002", null, null, "Rinto Raharjo" },
                    { "M003", "Jl. Sumatera No. 12 RT02 RW01, Ciamis", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1328), null, null, 3, false, "A001", "J003", null, null, "Asep Saepudin" },
                    { "M004", "Jl. Jawa No 01 RT01 RW01, Jakarta Pusat", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1329), null, null, 4, false, "A001", "J001", null, null, "M. Hafif Isbullah" },
                    { "M005", "Jl. Niagara No. 54 RT01 RW09, Surabaya", 1L, new DateTime(2024, 1, 24, 17, 18, 44, 909, DateTimeKind.Local).AddTicks(1331), null, null, 5, false, "A003", "J002", null, null, "Cahyono" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_m_nilai_Kode_Mahasiswa",
                table: "m_nilai",
                column: "Kode_Mahasiswa");

            migrationBuilder.CreateIndex(
                name: "IX_m_nilai_Kode_Ujian",
                table: "m_nilai",
                column: "Kode_Ujian");

            migrationBuilder.CreateIndex(
                name: "IX_m_mahasiswa_Kode_Agama",
                table: "m_mahasiswa",
                column: "Kode_Agama");

            migrationBuilder.CreateIndex(
                name: "IX_m_mahasiswa_Kode_Jurusan",
                table: "m_mahasiswa",
                column: "Kode_Jurusan");

            migrationBuilder.CreateIndex(
                name: "IX_m_dosen_Kode_Jurusan",
                table: "m_dosen",
                column: "Kode_Jurusan");

            migrationBuilder.CreateIndex(
                name: "IX_m_dosen_Kode_Type_Dosen",
                table: "m_dosen",
                column: "Kode_Type_Dosen");

            migrationBuilder.AddForeignKey(
                name: "FK_m_dosen_m_jurusan_Kode_Jurusan",
                table: "m_dosen",
                column: "Kode_Jurusan",
                principalTable: "m_jurusan",
                principalColumn: "Kode_Jurusan",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_m_dosen_m_type_dosen_Kode_Type_Dosen",
                table: "m_dosen",
                column: "Kode_Type_Dosen",
                principalTable: "m_type_dosen",
                principalColumn: "Kode_Type_Dosen",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_m_mahasiswa_m_agama_Kode_Agama",
                table: "m_mahasiswa",
                column: "Kode_Agama",
                principalTable: "m_agama",
                principalColumn: "Kode_Agama",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_m_mahasiswa_m_jurusan_Kode_Jurusan",
                table: "m_mahasiswa",
                column: "Kode_Jurusan",
                principalTable: "m_jurusan",
                principalColumn: "Kode_Jurusan",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_m_nilai_m_mahasiswa_Kode_Mahasiswa",
                table: "m_nilai",
                column: "Kode_Mahasiswa",
                principalTable: "m_mahasiswa",
                principalColumn: "Kode_Mahasiswa",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_m_nilai_m_ujian_Kode_Ujian",
                table: "m_nilai",
                column: "Kode_Ujian",
                principalTable: "m_ujian",
                principalColumn: "Kode_Ujian",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
