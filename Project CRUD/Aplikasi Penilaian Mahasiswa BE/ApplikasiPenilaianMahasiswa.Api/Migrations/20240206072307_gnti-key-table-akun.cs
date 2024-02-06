using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApplikasiPenilaianMahasiswa.Api.Migrations
{
    /// <inheritdoc />
    public partial class gntikeytableakun : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_m_accounts",
                table: "m_accounts");

            migrationBuilder.DeleteData(
                table: "m_accounts",
                keyColumn: "UserName",
                keyValue: "admin");

            migrationBuilder.DeleteData(
                table: "m_accounts",
                keyColumn: "UserName",
                keyValue: "dosen");

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_accounts",
                table: "m_accounts",
                column: "Id");

            migrationBuilder.InsertData(
                table: "m_accounts",
                columns: new[] { "Id", "Attempt", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Email", "FirstName", "Is_delete", "LastName", "Modified_by", "Modified_on", "Otp", "OtpExpire", "Password", "RoleGroupId", "UserName" },
                values: new object[,]
                {
                    { 1, 0, 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4297), null, null, "auriwanyasper@gmail.com", "Super", false, "Admin", null, null, null, null, "ac9689e2272427085e35b9d3e3e8bed88cb3434828b43b86fc0596cad4c6e270", 1, "admin" },
                    { 2, 0, 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4349), null, null, "auriwanyasper@gmail.com", "dosen", false, "tes", null, null, null, null, "c431bffe6c2cf3b69ad2e9cbbe9806835dbced7c97b9d3f946387ee92eb17018", 2, "dosen" }
                });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4156));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_m_accounts",
                table: "m_accounts");

            migrationBuilder.DeleteData(
                table: "m_accounts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "m_accounts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddPrimaryKey(
                name: "PK_m_accounts",
                table: "m_accounts",
                column: "UserName");

            migrationBuilder.InsertData(
                table: "m_accounts",
                columns: new[] { "UserName", "Attempt", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Email", "FirstName", "Id", "Is_delete", "LastName", "Modified_by", "Modified_on", "Otp", "OtpExpire", "Password", "RoleGroupId" },
                values: new object[,]
                {
                    { "admin", 0, 1L, new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5939), null, null, "auriwanyasper@gmail.com", "Super", 1, false, "Admin", null, null, null, null, "ac9689e2272427085e35b9d3e3e8bed88cb3434828b43b86fc0596cad4c6e270", 1 },
                    { "dosen", 0, 1L, new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5941), null, null, "auriwanyasper@gmail.com", "dosen", 2, false, "tes", null, null, null, null, "c431bffe6c2cf3b69ad2e9cbbe9806835dbced7c97b9d3f946387ee92eb17018", 2 }
                });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5805));
        }
    }
}
