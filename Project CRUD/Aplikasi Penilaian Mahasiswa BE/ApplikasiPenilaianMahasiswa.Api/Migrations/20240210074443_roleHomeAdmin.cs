using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplikasiPenilaianMahasiswa.Api.Migrations
{
    /// <inheritdoc />
    public partial class roleHomeAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "m_accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "m_accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3108));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3457));

            migrationBuilder.InsertData(
                table: "m_authorization_groups",
                columns: new[] { "Id", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Is_delete", "Modified_by", "Modified_on", "Role", "RoleGroupId" },
                values: new object[] { 8, "admin", new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3458), null, null, false, null, null, "home", 1 });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 44, 42, 735, DateTimeKind.Local).AddTicks(3183));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "m_accounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "m_accounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8425));

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8210));
        }
    }
}
