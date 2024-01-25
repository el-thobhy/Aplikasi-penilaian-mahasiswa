using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplikasiPenilaianMahasiswa.Api.Migrations
{
    /// <inheritdoc />
    public partial class editKodeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Kode_Agama" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4370), "AGM-2401-0001" });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Kode_Agama" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4372), "AGM-2401-0002" });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Kode_Agama" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4373), "AGM-2401-0003" });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Kode_Agama" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4375), "AGM-2401-0004" });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Kode_Agama" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4376), "AGM-2401-0005" });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Kode_Dosen" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4483), "DSN-2401-0001" });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Kode_Dosen" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4485), "DSN-2401-0002" });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Kode_Dosen" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4486), "DSN-2401-0003" });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Kode_Dosen" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4488), "DSN-2401-0004" });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Kode_Dosen" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4618), "DSN-2401-0005" });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Kode_Jurusan" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4197), "JUR-2401-0001" });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Kode_Jurusan" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4213), "JUR-2401-0002" });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Kode_Jurusan" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4214), "JUR-2401-0003" });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Kode_Jurusan" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4216), "JUR-2401-0004" });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Kode_Jurusan" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4217), "JUR-2401-0005" });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Kode_Mahasiswa" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4399), "MHS-2401-0001" });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Kode_Mahasiswa" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4402), "MHS-2401-0002" });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Kode_Mahasiswa" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4403), "MHS-2401-0003" });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Kode_Mahasiswa" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4405), "MHS-2401-0004" });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Kode_Mahasiswa" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4406), "MHS-2401-0005" });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Kode_Type_Dosen" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4460), "TYP-2401-0001" });

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Kode_Type_Dosen" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4461), "TYP-2401-0002" });

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Kode_Type_Dosen" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4462), "TYP-2401-0003" });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Kode_Ujian" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4433), "UJN-2401-0001" });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Kode_Ujian" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4434), "UJN-2401-0002" });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Kode_Ujian" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4435), "UJN-2401-0003" });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Kode_Ujian" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4437), "UJN-2401-0004" });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Kode_Ujian" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4438), "UJN-2401-0005" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Kode_Agama" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1344), "A001" });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Kode_Agama" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1347), "A002" });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Kode_Agama" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1349), "A003" });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Kode_Agama" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1350), "A004" });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Kode_Agama" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1352), "A005" });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Kode_Dosen" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1955), "D001" });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Kode_Dosen" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1957), "D002" });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Kode_Dosen" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1959), "D003" });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Kode_Dosen" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1961), "D004" });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Kode_Dosen" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1963), "D005" });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Kode_Jurusan" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1144), "J001" });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Kode_Jurusan" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1159), "J002" });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Kode_Jurusan" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1161), "J003" });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Kode_Jurusan" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1162), "J004" });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Kode_Jurusan" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1164), "J005" });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Kode_Mahasiswa" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1381), "M001" });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Kode_Mahasiswa" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1383), "M002" });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Kode_Mahasiswa" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1385), "M003" });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Kode_Mahasiswa" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1387), "M004" });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Kode_Mahasiswa" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1388), "M005" });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Kode_Type_Dosen" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1461), "T001" });

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Kode_Type_Dosen" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1463), "T002" });

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Kode_Type_Dosen" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1899), "T003" });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Kode_Ujian" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1424), "U001" });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Kode_Ujian" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1426), "U002" });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Kode_Ujian" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1427), "U003" });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Kode_Ujian" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1429), "U004" });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Kode_Ujian" },
                values: new object[] { new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1431), "U005" });
        }
    }
}
