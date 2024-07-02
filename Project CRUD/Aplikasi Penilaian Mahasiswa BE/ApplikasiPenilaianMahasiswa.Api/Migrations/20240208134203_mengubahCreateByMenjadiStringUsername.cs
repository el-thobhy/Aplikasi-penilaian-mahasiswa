using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplikasiPenilaianMahasiswa.Api.Migrations
{
    /// <inheritdoc />
    public partial class mengubahCreateByMenjadiStringUsername : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Modified_by",
                table: "m_ujian",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Created_by",
                table: "m_ujian",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Modified_by",
                table: "m_type_dosen",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Created_by",
                table: "m_type_dosen",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Modified_by",
                table: "m_role_group",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Created_by",
                table: "m_role_group",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Modified_by",
                table: "m_nilai",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Created_by",
                table: "m_nilai",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Modified_by",
                table: "m_mahasiswa",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Created_by",
                table: "m_mahasiswa",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Modified_by",
                table: "m_jurusan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Created_by",
                table: "m_jurusan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Modified_by",
                table: "m_dosen",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Created_by",
                table: "m_dosen",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Modified_by",
                table: "m_authorization_groups",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Created_by",
                table: "m_authorization_groups",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Modified_by",
                table: "m_agama",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Created_by",
                table: "m_agama",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Modified_by",
                table: "m_accounts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Created_by",
                table: "m_accounts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "m_accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3333), null });

            migrationBuilder.UpdateData(
                table: "m_accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3341), null });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2530), null });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2538), null });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2546), null });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2740), null });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2750), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3404), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3410), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3420), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3433), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3441), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3449), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3455), null });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3070), null });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3080), null });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3087), null });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3091), null });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3095), null });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(1794), null });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(1856), null });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(1860), null });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(1867), null });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(1871), null });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2815), null });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2825), null });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2830), null });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2840), null });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2847), null });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3169), null });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3177), null });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3191), null });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3198), null });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3203), null });

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3258), null });

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3262), null });

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3267), null });

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3009), null });

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3017), null });

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3023), null });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2923), null });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2929), null });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2935), null });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2940), null });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { "admin", new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2946), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Modified_by",
                table: "m_ujian",
                type: "bigint",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Created_by",
                table: "m_ujian",
                type: "bigint",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<long>(
                name: "Modified_by",
                table: "m_type_dosen",
                type: "bigint",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Created_by",
                table: "m_type_dosen",
                type: "bigint",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<long>(
                name: "Modified_by",
                table: "m_role_group",
                type: "bigint",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Created_by",
                table: "m_role_group",
                type: "bigint",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<long>(
                name: "Modified_by",
                table: "m_nilai",
                type: "bigint",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Created_by",
                table: "m_nilai",
                type: "bigint",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<long>(
                name: "Modified_by",
                table: "m_mahasiswa",
                type: "bigint",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Created_by",
                table: "m_mahasiswa",
                type: "bigint",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<long>(
                name: "Modified_by",
                table: "m_jurusan",
                type: "bigint",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Created_by",
                table: "m_jurusan",
                type: "bigint",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<long>(
                name: "Modified_by",
                table: "m_dosen",
                type: "bigint",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Created_by",
                table: "m_dosen",
                type: "bigint",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<long>(
                name: "Modified_by",
                table: "m_authorization_groups",
                type: "bigint",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Created_by",
                table: "m_authorization_groups",
                type: "bigint",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<long>(
                name: "Modified_by",
                table: "m_agama",
                type: "bigint",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Created_by",
                table: "m_agama",
                type: "bigint",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<long>(
                name: "Modified_by",
                table: "m_accounts",
                type: "bigint",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Created_by",
                table: "m_accounts",
                type: "bigint",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "m_accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4297), null });

            migrationBuilder.UpdateData(
                table: "m_accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4349), null });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4074), null });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4076), null });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4078), null });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4080), null });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4082), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4375), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4378), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4379), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4381), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4383), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4385), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4387), null });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4204), null });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4206), null });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4208), null });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4210), null });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4212), null });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(3719), null });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(3745), null });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(3748), null });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(3813), null });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(3816), null });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4107), null });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4110), null });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4112), null });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4114), null });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4116), null });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4238), null });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4240), null });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4242), null });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4244), null });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4246), null });

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4268), null });

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4271), null });

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4272), null });

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4180), null });

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4182), null });

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4184), null });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4147), null });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4150), null });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4152), null });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4154), null });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_by", "Created_on", "Modified_by" },
                values: new object[] { 1L, new DateTime(2024, 2, 6, 14, 23, 7, 518, DateTimeKind.Local).AddTicks(4156), null });
        }
    }
}
