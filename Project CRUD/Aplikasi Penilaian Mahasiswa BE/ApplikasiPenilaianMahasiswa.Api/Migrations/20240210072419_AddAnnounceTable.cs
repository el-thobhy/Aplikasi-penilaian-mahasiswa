using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplikasiPenilaianMahasiswa.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddAnnounceTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Deleted_by",
                table: "m_ujian",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Deleted_by",
                table: "m_type_dosen",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Deleted_by",
                table: "m_role_group",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Deleted_by",
                table: "m_nilai",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Deleted_by",
                table: "m_mahasiswa",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Deleted_by",
                table: "m_jurusan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Deleted_by",
                table: "m_dosen",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Deleted_by",
                table: "m_authorization_groups",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Deleted_by",
                table: "m_agama",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Deleted_by",
                table: "m_accounts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "m_announcement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_by = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Created_on = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified_by = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Modified_on = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Deleted_by = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Deleted_on = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Is_delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_announcement", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "m_accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8450), null });

            migrationBuilder.UpdateData(
                table: "m_accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8453), null });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8122), null });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8126), null });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8128), null });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8130), null });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8132), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8470), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8473), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8475), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8477), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8479), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8480), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8482), null });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8355), null });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8357), null });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8360), null });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8362), null });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8364), null });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(7816), null });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(7843), null });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(7846), null });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(7848), null });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(7851), null });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8161), null });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8164), null });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8167), null });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8169), null });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8172), null });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8387), null });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8390), null });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8392), null });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8394), null });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8396), null });

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8423), null });

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8425), null });

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8427), null });

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8323), null });

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8326), null });

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8328), null });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8201), null });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8204), null });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8206), null });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8208), null });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 10, 14, 24, 18, 848, DateTimeKind.Local).AddTicks(8210), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "m_announcement");

            migrationBuilder.AlterColumn<long>(
                name: "Deleted_by",
                table: "m_ujian",
                type: "bigint",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Deleted_by",
                table: "m_type_dosen",
                type: "bigint",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Deleted_by",
                table: "m_role_group",
                type: "bigint",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Deleted_by",
                table: "m_nilai",
                type: "bigint",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Deleted_by",
                table: "m_mahasiswa",
                type: "bigint",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Deleted_by",
                table: "m_jurusan",
                type: "bigint",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Deleted_by",
                table: "m_dosen",
                type: "bigint",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Deleted_by",
                table: "m_authorization_groups",
                type: "bigint",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Deleted_by",
                table: "m_agama",
                type: "bigint",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Deleted_by",
                table: "m_accounts",
                type: "bigint",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "m_accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3333), null });

            migrationBuilder.UpdateData(
                table: "m_accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3341), null });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2530), null });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2538), null });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2546), null });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2740), null });

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2750), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3404), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3410), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3420), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3433), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3441), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3449), null });

            migrationBuilder.UpdateData(
                table: "m_authorization_groups",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3455), null });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3070), null });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3080), null });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3087), null });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3091), null });

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3095), null });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(1794), null });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(1856), null });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(1860), null });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(1867), null });

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(1871), null });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2815), null });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2825), null });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2830), null });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2840), null });

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2847), null });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3169), null });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3177), null });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3191), null });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3198), null });

            migrationBuilder.UpdateData(
                table: "m_nilai",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3203), null });

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3258), null });

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3262), null });

            migrationBuilder.UpdateData(
                table: "m_role_group",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3267), null });

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3009), null });

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3017), null });

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(3023), null });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2923), null });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2929), null });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2935), null });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2940), null });

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created_on", "Deleted_by" },
                values: new object[] { new DateTime(2024, 2, 8, 20, 42, 2, 701, DateTimeKind.Local).AddTicks(2946), null });
        }
    }
}
