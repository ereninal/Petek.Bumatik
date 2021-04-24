using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Petek.BUmatik.DataAccess.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedUserId = table.Column<int>(type: "integer", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedUserId = table.Column<int>(type: "integer", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    TownId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedUserId = table.Column<int>(type: "integer", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParentId = table.Column<int>(type: "integer", nullable: false),
                    OperationClaimId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedUserId = table.Column<int>(type: "integer", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_OperationClaims_OperationClaimId",
                        column: x => x.OperationClaimId,
                        principalTable: "OperationClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<byte[]>(type: "bytea", nullable: true),
                    RemainingMoney = table.Column<decimal>(type: "numeric", nullable: false),
                    BandNumber = table.Column<string>(type: "text", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ModifieUserId = table.Column<int>(type: "integer", nullable: true),
                    SchoolId = table.Column<int>(type: "integer", nullable: false),
                    ParentId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedUserId = table.Column<int>(type: "integer", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "IsDeleted", "ModifiedDate", "ModifiedUserId", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Admin" },
                    { 2, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Member" },
                    { 4, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Student.Add" },
                    { 5, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Student.GetById" },
                    { 6, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Student.Delete" },
                    { 7, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Student.Update" },
                    { 8, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Parent.Add" },
                    { 9, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Parent.Delete" },
                    { 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Parent.Update" }
                });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "Email", "FullName", "IsDeleted", "ModifiedDate", "ModifiedUserId", "PasswordHash", "PasswordSalt" },
                values: new object[] { 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "ereninal10@gmail.com", "Eren İNAL", false, null, null, new byte[] { 197, 52, 181, 26, 41, 155, 245, 40, 240, 60, 106, 233, 122, 28, 147, 161, 108, 235, 32, 208, 108, 10, 105, 211, 250, 17, 58, 148, 90, 133, 131, 178, 212, 202, 81, 200, 250, 120, 31, 102, 193, 218, 193, 248, 97, 75, 44, 110, 173, 224, 39, 28, 110, 92, 67, 237, 85, 65, 213, 59, 134, 243, 5, 29 }, new byte[] { 91, 223, 111, 121, 21, 167, 54, 85, 65, 199, 240, 70, 30, 26, 123, 65, 171, 37, 88, 153, 69, 0, 20, 24, 97, 199, 184, 8, 142, 112, 29, 173, 42, 208, 146, 90, 140, 16, 213, 171, 75, 4, 15, 185, 15, 137, 220, 116, 159, 233, 166, 3, 212, 124, 9, 172, 113, 54, 42, 82, 220, 85, 17, 49, 146, 168, 40, 113, 34, 66, 28, 210, 142, 152, 200, 21, 83, 152, 206, 28, 183, 180, 59, 18, 40, 247, 85, 28, 205, 178, 227, 186, 17, 101, 51, 142, 169, 134, 171, 123, 254, 232, 84, 149, 126, 121, 39, 233, 178, 41, 136, 59, 252, 199, 205, 179, 21, 100, 90, 173, 43, 164, 94, 158, 164, 141, 198, 156 } });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "CityId", "CreatedDate", "CreatedUserId", "IsDeleted", "ModifiedDate", "ModifiedUserId", "Name", "TownId" },
                values: new object[,]
                {
                    { 15, 22, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Trakya Üniversitesi", 0 },
                    { 16, 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Ankara Üniversitesi", 0 },
                    { 17, 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Orta Doğu Teknik Üniversitesi", 0 },
                    { 18, 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Bilkent Üniversitesi", 0 },
                    { 19, 17, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Çanakkale 18 Mart Üniversitesi", 0 },
                    { 24, 34, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Boğaziçi Üniversitesi", 0 },
                    { 21, 34, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "İstanbul Aydın Üniversitesi", 0 },
                    { 22, 34, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Nişantaşı Üniversitesi", 0 },
                    { 23, 34, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Marmara Üniversitesi", 0 },
                    { 14, 59, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Namık Kemal Üniversitesi", 0 },
                    { 20, 32, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Süleyman Demirel Üniversitesi", 0 },
                    { 13, 67, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Fırat Üniversitesi", 0 },
                    { 8, 61, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Karadeniz Teknik Üniversitesi", 0 },
                    { 11, 34, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Kocaeli Üniversitesi", 0 },
                    { 10, 42, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Konya Teknik Üniversitesi", 0 },
                    { 9, 35, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Ege Üniversitesi", 0 },
                    { 25, 34, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Gelişim Üniversitesi", 0 },
                    { 7, 34, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "İstanbul Teknik Üniversitesi", 0 },
                    { 6, 34, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "İstanbul Üniversitesi", 0 },
                    { 5, 34, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Yıldız Teknik Üniversitesi", 0 },
                    { 4, 34, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Koç Üniversitesi", 0 },
                    { 3, 34, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Sabancı Üniversitesi", 0 },
                    { 2, 34, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Beykent Üniversitesi", 0 },
                    { 1, 42, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Selçuk Üniversitesi", 0 },
                    { 12, 34, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Gebze Teknik Üniversitesi", 0 },
                    { 26, 34, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Milli Savunma Üniversitesi", 0 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BandNumber", "BirthDate", "CreatedDate", "CreatedUserId", "FullName", "Image", "IsDeleted", "ModifieUserId", "ModifiedDate", "ModifiedUserId", "ParentId", "RemainingMoney", "SchoolId" },
                values: new object[,]
                {
                    { 1, "11111", null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mira İNAL", null, false, null, null, null, 1, 50m, 1 },
                    { 2, "22222", null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Aras İNAL", null, false, null, null, null, 1, 50m, 2 }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "IsDeleted", "ModifiedDate", "ModifiedUserId", "OperationClaimId", "ParentId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, 1, 1 },
                    { 2, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, 2, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_ParentId",
                table: "Students",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolId",
                table: "Students",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_OperationClaimId",
                table: "UserOperationClaims",
                column: "OperationClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_ParentId",
                table: "UserOperationClaims",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "Parents");
        }
    }
}
