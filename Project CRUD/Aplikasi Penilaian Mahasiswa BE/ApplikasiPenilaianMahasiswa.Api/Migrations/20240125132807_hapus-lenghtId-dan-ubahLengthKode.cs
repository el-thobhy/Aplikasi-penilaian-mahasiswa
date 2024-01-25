using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplikasiPenilaianMahasiswa.Api.Migrations
{
    /// <inheritdoc />
    public partial class hapuslenghtIddanubahLengthKode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Kode_Ujian",
                table: "m_ujian",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Kode_Type_Dosen",
                table: "m_type_dosen",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Kode_Mahasiswa",
                table: "m_mahasiswa",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Kode_Jurusan",
                table: "m_jurusan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Kode_Dosen",
                table: "m_dosen",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Kode_Agama",
                table: "m_agama",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1388));

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
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 28, 6, 916, DateTimeKind.Local).AddTicks(1431));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Kode_Ujian",
                table: "m_ujian",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Kode_Type_Dosen",
                table: "m_type_dosen",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Kode_Mahasiswa",
                table: "m_mahasiswa",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Kode_Jurusan",
                table: "m_jurusan",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Kode_Dosen",
                table: "m_dosen",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Kode_Agama",
                table: "m_agama",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 0, 13, 281, DateTimeKind.Local).AddTicks(9582));
        }
    }
}
