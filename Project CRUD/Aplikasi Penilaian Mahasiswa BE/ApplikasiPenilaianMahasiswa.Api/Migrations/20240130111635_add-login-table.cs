using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApplikasiPenilaianMahasiswa.Api.Migrations
{
    /// <inheritdoc />
    public partial class addlogintable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "m_role_group",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    table.PrimaryKey("PK_m_role_group", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "m_accounts",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValue: "auriwanyasper@gmail.com"),
                    Otp = table.Column<string>(type: "char(6)", nullable: true),
                    OtpExpire = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Attempt = table.Column<int>(type: "int", nullable: false),
                    RoleGroupId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_m_accounts", x => x.UserName);
                    table.ForeignKey(
                        name: "FK_m_accounts_m_role_group_RoleGroupId",
                        column: x => x.RoleGroupId,
                        principalTable: "m_role_group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "m_authorization_groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleGroupId = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    table.PrimaryKey("PK_m_authorization_groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_m_authorization_groups_m_role_group_RoleGroupId",
                        column: x => x.RoleGroupId,
                        principalTable: "m_role_group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "m_role_group",
                columns: new[] { "Id", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "GroupName", "Is_delete", "Modified_by", "Modified_on" },
                values: new object[,]
                {
                    { 1, 1L, new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5912), null, null, "Admin", false, null, null },
                    { 2, 1L, new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5913), null, null, "Dosen", false, null, null },
                    { 3, 1L, new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5914), null, null, "Mahasiswa", false, null, null }
                });

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

            migrationBuilder.InsertData(
                table: "m_accounts",
                columns: new[] { "UserName", "Attempt", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Email", "FirstName", "Id", "Is_delete", "LastName", "Modified_by", "Modified_on", "Otp", "OtpExpire", "Password", "RoleGroupId" },
                values: new object[,]
                {
                    { "admin", 0, 1L, new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5939), null, null, "auriwanyasper@gmail.com", "Super", 1, false, "Admin", null, null, null, null, "ac9689e2272427085e35b9d3e3e8bed88cb3434828b43b86fc0596cad4c6e270", 1 },
                    { "dosen", 0, 1L, new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5941), null, null, "auriwanyasper@gmail.com", "dosen", 2, false, "tes", null, null, null, null, "c431bffe6c2cf3b69ad2e9cbbe9806835dbced7c97b9d3f946387ee92eb17018", 2 }
                });

            migrationBuilder.InsertData(
                table: "m_authorization_groups",
                columns: new[] { "Id", "Created_by", "Created_on", "Deleted_by", "Deleted_on", "Is_delete", "Modified_by", "Modified_on", "Role", "RoleGroupId" },
                values: new object[,]
                {
                    { 1, 1L, new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5971), null, null, false, null, null, "jurusan", 1 },
                    { 2, 1L, new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5972), null, null, false, null, null, "mahasiswa", 1 },
                    { 3, 1L, new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5974), null, null, false, null, null, "agama", 1 },
                    { 4, 1L, new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5975), null, null, false, null, null, "dosen", 1 },
                    { 5, 1L, new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5976), null, null, false, null, null, "nilai", 1 },
                    { 6, 1L, new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5977), null, null, false, null, null, "typedosen", 1 },
                    { 7, 1L, new DateTime(2024, 1, 30, 18, 16, 34, 862, DateTimeKind.Local).AddTicks(5978), null, null, false, null, null, "ujian", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_m_accounts_RoleGroupId",
                table: "m_accounts",
                column: "RoleGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_m_accounts_UserName",
                table: "m_accounts",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_m_authorization_groups_RoleGroupId",
                table: "m_authorization_groups",
                column: "RoleGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_m_role_group_GroupName",
                table: "m_role_group",
                column: "GroupName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "m_accounts");

            migrationBuilder.DropTable(
                name: "m_authorization_groups");

            migrationBuilder.DropTable(
                name: "m_role_group");

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "m_agama",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "m_dosen",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "m_jurusan",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "m_mahasiswa",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4406));

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
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "m_type_dosen",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "m_ujian",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_on",
                value: new DateTime(2024, 1, 25, 20, 36, 52, 419, DateTimeKind.Local).AddTicks(4438));
        }
    }
}
