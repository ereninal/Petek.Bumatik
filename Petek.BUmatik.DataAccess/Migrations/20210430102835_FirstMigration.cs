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
                name: "AdminUsers",
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
                    table.PrimaryKey("PK_AdminUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Counties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CountryName = table.Column<string>(type: "text", nullable: true),
                    AdminUserId = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedUserId = table.Column<int>(type: "integer", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Counties_AdminUsers_AdminUserId",
                        column: x => x.AdminUserId,
                        principalTable: "AdminUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    AdminUserId = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedUserId = table.Column<int>(type: "integer", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationClaims_AdminUsers_AdminUserId",
                        column: x => x.AdminUserId,
                        principalTable: "AdminUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    AdminUserId = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedUserId = table.Column<int>(type: "integer", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parents_AdminUsers_AdminUserId",
                        column: x => x.AdminUserId,
                        principalTable: "AdminUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SendEmailOrSms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SmsOrEmail = table.Column<string>(type: "text", nullable: true),
                    ToAddress = table.Column<string>(type: "text", nullable: true),
                    SmsToNumber = table.Column<string>(type: "text", nullable: true),
                    CcAddress = table.Column<string>(type: "text", nullable: true),
                    BCcAddress = table.Column<string>(type: "text", nullable: true),
                    EmailSubject = table.Column<string>(type: "text", nullable: true),
                    EmailOrSmsTemplate = table.Column<int>(type: "integer", nullable: false),
                    EmailOrSmsValues = table.Column<string>(type: "text", nullable: true),
                    IsHtml = table.Column<bool>(type: "boolean", nullable: false),
                    IsSent = table.Column<bool>(type: "boolean", nullable: false),
                    AdminUserId = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedUserId = table.Column<int>(type: "integer", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SendEmailOrSms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SendEmailOrSms_AdminUsers_AdminUserId",
                        column: x => x.AdminUserId,
                        principalTable: "AdminUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CountryId = table.Column<int>(type: "integer", nullable: false),
                    CountiesId = table.Column<int>(type: "integer", nullable: true),
                    AdminUserId = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedUserId = table.Column<int>(type: "integer", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_AdminUsers_AdminUserId",
                        column: x => x.AdminUserId,
                        principalTable: "AdminUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cities_Counties_CountiesId",
                        column: x => x.CountiesId,
                        principalTable: "Counties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CountryId = table.Column<int>(type: "integer", nullable: false),
                    TownId = table.Column<int>(type: "integer", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: true),
                    CountyId = table.Column<int>(type: "integer", nullable: true),
                    AdminUserId = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedUserId = table.Column<int>(type: "integer", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schools_AdminUsers_AdminUserId",
                        column: x => x.AdminUserId,
                        principalTable: "AdminUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schools_Counties_CountyId",
                        column: x => x.CountyId,
                        principalTable: "Counties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParentId = table.Column<int>(type: "integer", nullable: false),
                    OperationClaimId = table.Column<int>(type: "integer", nullable: false),
                    AdminUserId = table.Column<int>(type: "integer", nullable: true),
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
                        name: "FK_UserOperationClaims_AdminUsers_AdminUserId",
                        column: x => x.AdminUserId,
                        principalTable: "AdminUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "AutomatInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Brand = table.Column<string>(type: "text", nullable: true),
                    Model = table.Column<string>(type: "text", nullable: true),
                    Number = table.Column<string>(type: "text", nullable: true),
                    Count = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastRepairDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    SchoolId = table.Column<int>(type: "integer", nullable: false),
                    AdminUserId = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedUserId = table.Column<int>(type: "integer", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutomatInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutomatInfo_AdminUsers_AdminUserId",
                        column: x => x.AdminUserId,
                        principalTable: "AdminUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutomatInfo_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
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
                    AdminUserId = table.Column<int>(type: "integer", nullable: true),
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
                        name: "FK_Students_AdminUsers_AdminUserId",
                        column: x => x.AdminUserId,
                        principalTable: "AdminUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                table: "AdminUsers",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "Email", "FullName", "IsDeleted", "ModifiedDate", "ModifiedUserId", "PasswordHash", "PasswordSalt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "eren@petek.com", "Eren İnal", false, null, null, new byte[] { 42, 105, 186, 199, 92, 15, 136, 48, 231, 186, 67, 40, 52, 222, 212, 8, 17, 35, 253, 188, 244, 54, 28, 149, 55, 93, 147, 36, 52, 4, 245, 132, 239, 254, 110, 185, 101, 207, 230, 17, 174, 161, 8, 106, 105, 139, 106, 43, 108, 34, 163, 218, 159, 102, 166, 96, 175, 161, 141, 175, 171, 159, 237, 179 }, new byte[] { 204, 94, 81, 21, 72, 75, 20, 233, 155, 140, 245, 226, 168, 195, 60, 72, 150, 108, 203, 91, 63, 106, 206, 111, 224, 5, 49, 226, 84, 14, 219, 68, 114, 163, 250, 171, 74, 251, 200, 134, 125, 75, 120, 123, 10, 82, 66, 53, 95, 35, 50, 48, 50, 78, 212, 123, 245, 40, 244, 159, 133, 84, 18, 145, 98, 82, 171, 17, 6, 32, 79, 173, 48, 0, 236, 109, 84, 207, 136, 14, 107, 1, 139, 255, 194, 175, 1, 236, 248, 67, 165, 70, 171, 95, 29, 112, 115, 138, 81, 249, 162, 120, 37, 3, 100, 58, 169, 209, 101, 139, 188, 121, 229, 246, 96, 103, 177, 208, 133, 230, 242, 250, 101, 65, 231, 37, 5, 105 } },
                    { 2, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "pelinsu@petek.com", "Eren İnal", false, null, null, new byte[] { 42, 105, 186, 199, 92, 15, 136, 48, 231, 186, 67, 40, 52, 222, 212, 8, 17, 35, 253, 188, 244, 54, 28, 149, 55, 93, 147, 36, 52, 4, 245, 132, 239, 254, 110, 185, 101, 207, 230, 17, 174, 161, 8, 106, 105, 139, 106, 43, 108, 34, 163, 218, 159, 102, 166, 96, 175, 161, 141, 175, 171, 159, 237, 179 }, new byte[] { 204, 94, 81, 21, 72, 75, 20, 233, 155, 140, 245, 226, 168, 195, 60, 72, 150, 108, 203, 91, 63, 106, 206, 111, 224, 5, 49, 226, 84, 14, 219, 68, 114, 163, 250, 171, 74, 251, 200, 134, 125, 75, 120, 123, 10, 82, 66, 53, 95, 35, 50, 48, 50, 78, 212, 123, 245, 40, 244, 159, 133, 84, 18, 145, 98, 82, 171, 17, 6, 32, 79, 173, 48, 0, 236, 109, 84, 207, 136, 14, 107, 1, 139, 255, 194, 175, 1, 236, 248, 67, 165, 70, 171, 95, 29, 112, 115, 138, 81, 249, 162, 120, 37, 3, 100, 58, 169, 209, 101, 139, 188, 121, 229, 246, 96, 103, 177, 208, 133, 230, 242, 250, 101, 65, 231, 37, 5, 105 } },
                    { 3, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "kemal@petek.com", "Eren İnal", false, null, null, new byte[] { 42, 105, 186, 199, 92, 15, 136, 48, 231, 186, 67, 40, 52, 222, 212, 8, 17, 35, 253, 188, 244, 54, 28, 149, 55, 93, 147, 36, 52, 4, 245, 132, 239, 254, 110, 185, 101, 207, 230, 17, 174, 161, 8, 106, 105, 139, 106, 43, 108, 34, 163, 218, 159, 102, 166, 96, 175, 161, 141, 175, 171, 159, 237, 179 }, new byte[] { 204, 94, 81, 21, 72, 75, 20, 233, 155, 140, 245, 226, 168, 195, 60, 72, 150, 108, 203, 91, 63, 106, 206, 111, 224, 5, 49, 226, 84, 14, 219, 68, 114, 163, 250, 171, 74, 251, 200, 134, 125, 75, 120, 123, 10, 82, 66, 53, 95, 35, 50, 48, 50, 78, 212, 123, 245, 40, 244, 159, 133, 84, 18, 145, 98, 82, 171, 17, 6, 32, 79, 173, 48, 0, 236, 109, 84, 207, 136, 14, 107, 1, 139, 255, 194, 175, 1, 236, 248, 67, 165, 70, 171, 95, 29, 112, 115, 138, 81, 249, 162, 120, 37, 3, 100, 58, 169, 209, 101, 139, 188, 121, 229, 246, 96, 103, 177, 208, 133, 230, 242, 250, 101, 65, 231, 37, 5, 105 } },
                    { 4, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "samet@petek.com", "Eren İnal", false, null, null, new byte[] { 42, 105, 186, 199, 92, 15, 136, 48, 231, 186, 67, 40, 52, 222, 212, 8, 17, 35, 253, 188, 244, 54, 28, 149, 55, 93, 147, 36, 52, 4, 245, 132, 239, 254, 110, 185, 101, 207, 230, 17, 174, 161, 8, 106, 105, 139, 106, 43, 108, 34, 163, 218, 159, 102, 166, 96, 175, 161, 141, 175, 171, 159, 237, 179 }, new byte[] { 204, 94, 81, 21, 72, 75, 20, 233, 155, 140, 245, 226, 168, 195, 60, 72, 150, 108, 203, 91, 63, 106, 206, 111, 224, 5, 49, 226, 84, 14, 219, 68, 114, 163, 250, 171, 74, 251, 200, 134, 125, 75, 120, 123, 10, 82, 66, 53, 95, 35, 50, 48, 50, 78, 212, 123, 245, 40, 244, 159, 133, 84, 18, 145, 98, 82, 171, 17, 6, 32, 79, 173, 48, 0, 236, 109, 84, 207, 136, 14, 107, 1, 139, 255, 194, 175, 1, 236, 248, 67, 165, 70, 171, 95, 29, 112, 115, 138, 81, 249, 162, 120, 37, 3, 100, 58, 169, 209, 101, 139, 188, 121, 229, 246, 96, 103, 177, 208, 133, 230, 242, 250, 101, 65, 231, 37, 5, 105 } }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "AdminUserId", "CountiesId", "CountryId", "CreatedDate", "CreatedUserId", "IsDeleted", "ModifiedDate", "ModifiedUserId", "Name" },
                values: new object[,]
                {
                    { 27, null, null, 17, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4369), 1, false, null, null, "Ezine" },
                    { 28, null, null, 17, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4370), 1, false, null, null, "Gelibolu" },
                    { 29, null, null, 59, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4371), 1, false, null, null, "Şarköy" },
                    { 31, null, null, 59, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4373), 1, false, null, null, "Süleymanpaşa" },
                    { 32, null, null, 59, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4374), 1, false, null, null, "Çorlu" },
                    { 33, null, null, 59, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4376), 1, false, null, null, "Çerkezköy" },
                    { 34, null, null, 59, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4377), 1, false, null, null, "Saray" },
                    { 35, null, null, 59, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4378), 1, false, null, null, "Kapaklı" },
                    { 36, null, null, 59, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4380), 1, false, null, null, "Malkara" },
                    { 37, null, null, 22, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4381), 1, false, null, null, "Keşan" },
                    { 39, null, null, 22, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4383), 1, false, null, null, "İpsala" },
                    { 26, null, null, 17, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4368), 1, false, null, null, "Ayvacık" },
                    { 40, null, null, 67, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4385), 1, false, null, null, "Zonguldak" },
                    { 41, null, null, 67, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4386), 1, false, null, null, "Alaplı" },
                    { 42, null, null, 67, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4387), 1, false, null, null, "Gökçebey" },
                    { 44, null, null, 61, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4390), 1, false, null, null, "Akçaabat" },
                    { 45, null, null, 61, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4391), 1, false, null, null, "Düzköy" },
                    { 46, null, null, 61, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4392), 1, false, null, null, "Enez" },
                    { 47, null, null, 61, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4394), 1, false, null, null, "Arsin" },
                    { 48, null, null, 61, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4395), 1, false, null, null, "Beşikdüzü" },
                    { 38, null, null, 22, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4382), 1, false, null, null, "Edirne" },
                    { 25, null, null, 17, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4366), 1, false, null, null, "Biga" },
                    { 43, null, null, 67, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4389), 1, false, null, null, "Çaycuma" },
                    { 23, null, null, 1, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4364), 1, false, null, null, "Çanakkale " },
                    { 24, null, null, 17, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4365), 1, false, null, null, "Bozcaada" },
                    { 1, null, null, 34, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(3477), 1, false, null, null, "Sarıyer" },
                    { 2, null, null, 34, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4318), 1, false, null, null, "Beyoğlu" },
                    { 4, null, null, 34, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4338), 1, false, null, null, "Kadıköy" },
                    { 5, null, null, 34, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4339), 1, false, null, null, "Esenler" },
                    { 6, null, null, 34, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4340), 1, false, null, null, "Maltepe" },
                    { 7, null, null, 34, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4342), 1, false, null, null, "Zeytinburnu" },
                    { 8, null, null, 34, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4343), 1, false, null, null, "Bakırköy" },
                    { 9, null, null, 34, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4346), 1, false, null, null, "Beylikdüzü" },
                    { 11, null, null, 42, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4347), 1, false, null, null, "Selçuklu" },
                    { 3, null, null, 34, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4336), 1, false, null, null, "Kartal" },
                    { 13, null, null, 42, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4350), 1, false, null, null, "Akşehir" },
                    { 12, null, null, 42, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4348), 1, false, null, null, "Beyşehir" },
                    { 21, null, null, 1, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4361), 1, false, null, null, "Beypazarı" },
                    { 19, null, null, 1, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4359), 1, false, null, null, "Şereflikoçhisar" },
                    { 18, null, null, 1, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4357), 1, false, null, null, "Gölbaşı" },
                    { 20, null, null, 1, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4360), 1, false, null, null, "Keçiören" },
                    { 17, null, null, 35, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4356), 1, false, null, null, "Urla " },
                    { 16, null, null, 35, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4355), 1, false, null, null, "Selçuk" },
                    { 15, null, null, 35, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4353), 1, false, null, null, "Foça" },
                    { 14, null, null, 42, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4352), 1, false, null, null, "Cihanbeyli" },
                    { 22, null, null, 1, new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4362), 1, false, null, null, "Polatlı" }
                });

            migrationBuilder.InsertData(
                table: "Counties",
                columns: new[] { "Id", "AdminUserId", "CountryName", "CreatedDate", "CreatedUserId", "IsDeleted", "ModifiedDate", "ModifiedUserId" },
                values: new object[,]
                {
                    { 59, null, "Tekirdağ", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 53, null, "Rize", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 58, null, "Sivas", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 57, null, "Sinop", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 56, null, "Siirt", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 55, null, "Samsun", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 54, null, "Sakarya", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 60, null, "Tokat", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 48, null, "Muğla", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 51, null, "Niğde", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 50, null, "Nevşehir", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 49, null, "Muş", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 47, null, "Mardin", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 46, null, "Kahramanmaraş", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 45, null, "Manisa", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 61, null, "Trabzon", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 44, null, "Malatya", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 52, null, "Ordu", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 62, null, "Tunceli", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 73, null, "Şırnak", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 64, null, "Uşak", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 43, null, "Kütahya", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 81, null, "Düzce", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 80, null, "Osmaniye", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 79, null, "Kilis", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 78, null, "Karabük", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 77, null, "Yalova", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 76, null, "Iğdır", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 75, null, "Ardahan", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 74, null, "Bartın", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 72, null, "Batman", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 71, null, "Kırıkkale", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 70, null, "Karaman", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 69, null, "Bayburt", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 68, null, "Aksaray", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 67, null, "Zonguldak", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 66, null, "Yozgat", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 65, null, "Van", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 63, null, "Şanlıurfa", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 42, null, "Konya", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 34, null, "İstanbul", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 40, null, "Kırşehir", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 17, null, "Çanakkale", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 16, null, "Bursa", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 15, null, "Burdur", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 14, null, "Bolu", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 13, null, "Bitlis", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 12, null, "Bingöl", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 11, null, "Bilecik", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 10, null, "Balıkesir", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 9, null, "Aydın", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 8, null, "Artvin", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 7, null, "Antalya", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 6, null, "Ankara", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 5, null, "Amasya", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 4, null, "Ağrı", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 3, null, "Afyon", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 41, null, "Kocaeli", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 1, null, "Adana", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 18, null, "Çankırı", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 19, null, "Çorum", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 2, null, "Adıyaman", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 21, null, "Diyarbakır", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 20, null, "Denizli", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 39, null, "Kırklareli", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 38, null, "Kayseri", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 37, null, "Kastamonu", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 36, null, "Kars", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 35, null, "İzmir", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 33, null, "İçel", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 31, null, "Hatay", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 32, null, "Isparta", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 29, null, "Gümüşhane", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 28, null, "Giresun", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 27, null, "Gaziantep", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 26, null, "Eskişehir", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 25, null, "Erzurum", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 24, null, "Erzincan", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 23, null, "Elazığ", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 22, null, "Edirne", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 30, null, "Hakkari", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "AdminUserId", "CreatedDate", "CreatedUserId", "IsDeleted", "ModifiedDate", "ModifiedUserId", "Name" },
                values: new object[,]
                {
                    { 7, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Student.Update" },
                    { 10, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Parent.Update" },
                    { 8, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Parent.Add" },
                    { 6, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Student.Delete" },
                    { 9, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Parent.Delete" },
                    { 4, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Student.Add" },
                    { 3, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Member.Create" },
                    { 2, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Member" },
                    { 1, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Admin" },
                    { 5, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Student.GetById" }
                });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "AdminUserId", "CreatedDate", "CreatedUserId", "Email", "FullName", "IsDeleted", "ModifiedDate", "ModifiedUserId", "PasswordHash", "PasswordSalt" },
                values: new object[] { 1, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "ereninal10@gmail.com", "Eren İNAL", false, null, null, new byte[] { 42, 105, 186, 199, 92, 15, 136, 48, 231, 186, 67, 40, 52, 222, 212, 8, 17, 35, 253, 188, 244, 54, 28, 149, 55, 93, 147, 36, 52, 4, 245, 132, 239, 254, 110, 185, 101, 207, 230, 17, 174, 161, 8, 106, 105, 139, 106, 43, 108, 34, 163, 218, 159, 102, 166, 96, 175, 161, 141, 175, 171, 159, 237, 179 }, new byte[] { 204, 94, 81, 21, 72, 75, 20, 233, 155, 140, 245, 226, 168, 195, 60, 72, 150, 108, 203, 91, 63, 106, 206, 111, 224, 5, 49, 226, 84, 14, 219, 68, 114, 163, 250, 171, 74, 251, 200, 134, 125, 75, 120, 123, 10, 82, 66, 53, 95, 35, 50, 48, 50, 78, 212, 123, 245, 40, 244, 159, 133, 84, 18, 145, 98, 82, 171, 17, 6, 32, 79, 173, 48, 0, 236, 109, 84, 207, 136, 14, 107, 1, 139, 255, 194, 175, 1, 236, 248, 67, 165, 70, 171, 95, 29, 112, 115, 138, 81, 249, 162, 120, 37, 3, 100, 58, 169, 209, 101, 139, 188, 121, 229, 246, 96, 103, 177, 208, 133, 230, 242, 250, 101, 65, 231, 37, 5, 105 } });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "AdminUserId", "CountryId", "CountyId", "CreatedDate", "CreatedUserId", "IsDeleted", "ModifiedDate", "ModifiedUserId", "Name", "TownId" },
                values: new object[,]
                {
                    { 15, null, null, 22, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Trakya Üniversitesi", 0 },
                    { 16, null, null, 1, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Ankara Üniversitesi", 0 },
                    { 17, null, null, 1, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Orta Doğu Teknik Üniversitesi", 0 },
                    { 18, null, null, 1, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Bilkent Üniversitesi", 0 },
                    { 21, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "İstanbul Aydın Üniversitesi", 0 },
                    { 20, null, null, 32, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Süleyman Demirel Üniversitesi", 0 },
                    { 14, null, null, 59, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Namık Kemal Üniversitesi", 0 },
                    { 22, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Nişantaşı Üniversitesi", 0 },
                    { 23, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Marmara Üniversitesi", 0 },
                    { 24, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Boğaziçi Üniversitesi", 0 },
                    { 19, null, null, 17, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Çanakkale 18 Mart Üniversitesi", 0 },
                    { 13, null, null, 67, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Fırat Üniversitesi", 0 },
                    { 10, null, null, 42, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Konya Teknik Üniversitesi", 0 },
                    { 11, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Kocaeli Üniversitesi", 0 },
                    { 9, null, null, 35, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Ege Üniversitesi", 0 },
                    { 8, null, null, 61, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Karadeniz Teknik Üniversitesi", 0 },
                    { 7, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "İstanbul Teknik Üniversitesi", 0 },
                    { 6, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "İstanbul Üniversitesi", 0 },
                    { 5, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Yıldız Teknik Üniversitesi", 0 },
                    { 4, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Koç Üniversitesi", 0 },
                    { 3, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Sabancı Üniversitesi", 0 },
                    { 2, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Beykent Üniversitesi", 0 },
                    { 1, null, null, 42, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Selçuk Üniversitesi", 0 },
                    { 25, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Gelişim Üniversitesi", 0 },
                    { 12, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Gebze Teknik Üniversitesi", 0 },
                    { 26, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Milli Savunma Üniversitesi", 0 }
                });

            migrationBuilder.InsertData(
                table: "AutomatInfo",
                columns: new[] { "Id", "AdminUserId", "Brand", "Count", "CreatedDate", "CreatedUserId", "IsDeleted", "LastRepairDate", "Model", "ModifiedDate", "ModifiedUserId", "Number", "SchoolId", "StartDate" },
                values: new object[,]
                {
                    { 1, null, "Pe-Tek", 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "BUMATIK-1", 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, "Pe-Tek", 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "BUMATIK-2", 2, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, "Pe-Tek", 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "BUMATIK-3", 4, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, "Pe-Tek", 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "BUMATIK-4", 5, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, "Pe-Tek", 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "BUMATIK-5", 6, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, "Pe-Tek", 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "BUMATIK-6", 7, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, "Pe-Tek", 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "BUMATIK-7", 8, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, "Pe-Tek", 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "BUMATIK-8", 9, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, "Pe-Tek", 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "BUMATIK-9", 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, null, "Pe-Tek", 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "BUMATIK-10", 11, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "AdminUserId", "BandNumber", "BirthDate", "CreatedDate", "CreatedUserId", "FullName", "Image", "IsDeleted", "ModifieUserId", "ModifiedDate", "ModifiedUserId", "ParentId", "RemainingMoney", "SchoolId" },
                values: new object[,]
                {
                    { 1, null, "11111", null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mira İNAL", null, false, null, null, null, 1, 50m, 1 },
                    { 2, null, "22222", null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Aras İNAL", null, false, null, null, null, 1, 50m, 2 }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "AdminUserId", "CreatedDate", "CreatedUserId", "IsDeleted", "ModifiedDate", "ModifiedUserId", "OperationClaimId", "ParentId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, 1, 1 },
                    { 2, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, 2, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutomatInfo_AdminUserId",
                table: "AutomatInfo",
                column: "AdminUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AutomatInfo_SchoolId",
                table: "AutomatInfo",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_AdminUserId",
                table: "Cities",
                column: "AdminUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountiesId",
                table: "Cities",
                column: "CountiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Counties_AdminUserId",
                table: "Counties",
                column: "AdminUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationClaims_AdminUserId",
                table: "OperationClaims",
                column: "AdminUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Parents_AdminUserId",
                table: "Parents",
                column: "AdminUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_AdminUserId",
                table: "Schools",
                column: "AdminUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_CountyId",
                table: "Schools",
                column: "CountyId");

            migrationBuilder.CreateIndex(
                name: "IX_SendEmailOrSms_AdminUserId",
                table: "SendEmailOrSms",
                column: "AdminUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_AdminUserId",
                table: "Students",
                column: "AdminUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ParentId",
                table: "Students",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolId",
                table: "Students",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_AdminUserId",
                table: "UserOperationClaims",
                column: "AdminUserId");

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
                name: "AutomatInfo");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "SendEmailOrSms");

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

            migrationBuilder.DropTable(
                name: "Counties");

            migrationBuilder.DropTable(
                name: "AdminUsers");
        }
    }
}
