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
                name: "AutomatItemInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Count = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedUserId = table.Column<int>(type: "integer", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutomatItemInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedUserId = table.Column<int>(type: "integer", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<TimeSpan>(type: "interval", nullable: false),
                    FinishDate = table.Column<TimeSpan>(type: "interval", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedUserId = table.Column<int>(type: "integer", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuTypes", x => x.Id);
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
                name: "AutomatItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    ItemCategoryId = table.Column<int>(type: "integer", nullable: false),
                    AutomatItemInfoId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedUserId = table.Column<int>(type: "integer", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutomatItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutomatItems_AutomatItemInfos_AutomatItemInfoId",
                        column: x => x.AutomatItemInfoId,
                        principalTable: "AutomatItemInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutomatItems_ItemCategories_ItemCategoryId",
                        column: x => x.ItemCategoryId,
                        principalTable: "ItemCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MenuTypeId = table.Column<int>(type: "integer", nullable: false),
                    StudentId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedUserId = table.Column<int>(type: "integer", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menus_MenuTypes_MenuTypeId",
                        column: x => x.MenuTypeId,
                        principalTable: "MenuTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Menus_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    SeledtedItem = table.Column<string>(type: "text", nullable: true),
                    StudentId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedUserId = table.Column<int>(type: "integer", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentMenus_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SelectedMenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Count = table.Column<int>(type: "integer", nullable: false),
                    MenuId = table.Column<int>(type: "integer", nullable: false),
                    AutomatItemId = table.Column<int>(type: "integer", nullable: false),
                    StudentId = table.Column<int>(type: "integer", nullable: false),
                    LastStatus = table.Column<bool>(type: "boolean", nullable: false),
                    LastStatusDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedUserId = table.Column<int>(type: "integer", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedMenuItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SelectedMenuItems_AutomatItems_AutomatItemId",
                        column: x => x.AutomatItemId,
                        principalTable: "AutomatItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedMenuItems_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedMenuItems_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AdminUsers",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "Email", "FullName", "IsDeleted", "ModifiedDate", "ModifiedUserId", "PasswordHash", "PasswordSalt" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "eren@petek.com", "Eren İnal", false, null, null, new byte[] { 103, 243, 137, 139, 2, 212, 232, 73, 116, 92, 150, 207, 8, 135, 17, 163, 124, 151, 158, 108, 97, 144, 30, 134, 58, 226, 70, 189, 244, 8, 183, 181, 164, 158, 39, 39, 163, 155, 142, 111, 253, 66, 106, 243, 160, 243, 207, 95, 175, 156, 155, 187, 251, 147, 243, 243, 43, 233, 146, 189, 38, 59, 233, 189 }, new byte[] { 148, 210, 139, 107, 99, 223, 141, 55, 229, 71, 55, 39, 108, 193, 71, 158, 90, 238, 13, 166, 229, 172, 109, 243, 19, 1, 13, 174, 114, 12, 248, 129, 224, 206, 89, 187, 100, 127, 19, 177, 18, 71, 53, 167, 223, 38, 131, 90, 120, 87, 14, 199, 101, 170, 179, 253, 123, 2, 60, 204, 124, 169, 106, 133, 150, 57, 84, 67, 206, 222, 195, 86, 97, 236, 155, 246, 193, 175, 174, 223, 32, 138, 24, 48, 147, 128, 132, 18, 118, 191, 69, 73, 248, 241, 100, 143, 237, 11, 174, 252, 157, 150, 140, 101, 140, 85, 230, 154, 132, 126, 30, 43, 100, 10, 7, 207, 113, 88, 217, 3, 140, 159, 51, 86, 218, 128, 135, 186 } },
                    { 2, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "pelinsu@petek.com", "Peinsu Baltacı", false, null, null, new byte[] { 103, 243, 137, 139, 2, 212, 232, 73, 116, 92, 150, 207, 8, 135, 17, 163, 124, 151, 158, 108, 97, 144, 30, 134, 58, 226, 70, 189, 244, 8, 183, 181, 164, 158, 39, 39, 163, 155, 142, 111, 253, 66, 106, 243, 160, 243, 207, 95, 175, 156, 155, 187, 251, 147, 243, 243, 43, 233, 146, 189, 38, 59, 233, 189 }, new byte[] { 148, 210, 139, 107, 99, 223, 141, 55, 229, 71, 55, 39, 108, 193, 71, 158, 90, 238, 13, 166, 229, 172, 109, 243, 19, 1, 13, 174, 114, 12, 248, 129, 224, 206, 89, 187, 100, 127, 19, 177, 18, 71, 53, 167, 223, 38, 131, 90, 120, 87, 14, 199, 101, 170, 179, 253, 123, 2, 60, 204, 124, 169, 106, 133, 150, 57, 84, 67, 206, 222, 195, 86, 97, 236, 155, 246, 193, 175, 174, 223, 32, 138, 24, 48, 147, 128, 132, 18, 118, 191, 69, 73, 248, 241, 100, 143, 237, 11, 174, 252, 157, 150, 140, 101, 140, 85, 230, 154, 132, 126, 30, 43, 100, 10, 7, 207, 113, 88, 217, 3, 140, 159, 51, 86, 218, 128, 135, 186 } },
                    { 3, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "kemal@petek.com", "Mehmet Kemal Sarıkaya", false, null, null, new byte[] { 103, 243, 137, 139, 2, 212, 232, 73, 116, 92, 150, 207, 8, 135, 17, 163, 124, 151, 158, 108, 97, 144, 30, 134, 58, 226, 70, 189, 244, 8, 183, 181, 164, 158, 39, 39, 163, 155, 142, 111, 253, 66, 106, 243, 160, 243, 207, 95, 175, 156, 155, 187, 251, 147, 243, 243, 43, 233, 146, 189, 38, 59, 233, 189 }, new byte[] { 148, 210, 139, 107, 99, 223, 141, 55, 229, 71, 55, 39, 108, 193, 71, 158, 90, 238, 13, 166, 229, 172, 109, 243, 19, 1, 13, 174, 114, 12, 248, 129, 224, 206, 89, 187, 100, 127, 19, 177, 18, 71, 53, 167, 223, 38, 131, 90, 120, 87, 14, 199, 101, 170, 179, 253, 123, 2, 60, 204, 124, 169, 106, 133, 150, 57, 84, 67, 206, 222, 195, 86, 97, 236, 155, 246, 193, 175, 174, 223, 32, 138, 24, 48, 147, 128, 132, 18, 118, 191, 69, 73, 248, 241, 100, 143, 237, 11, 174, 252, 157, 150, 140, 101, 140, 85, 230, 154, 132, 126, 30, 43, 100, 10, 7, 207, 113, 88, 217, 3, 140, 159, 51, 86, 218, 128, 135, 186 } },
                    { 4, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "samet@petek.com", "Samet Dikmen", false, null, null, new byte[] { 103, 243, 137, 139, 2, 212, 232, 73, 116, 92, 150, 207, 8, 135, 17, 163, 124, 151, 158, 108, 97, 144, 30, 134, 58, 226, 70, 189, 244, 8, 183, 181, 164, 158, 39, 39, 163, 155, 142, 111, 253, 66, 106, 243, 160, 243, 207, 95, 175, 156, 155, 187, 251, 147, 243, 243, 43, 233, 146, 189, 38, 59, 233, 189 }, new byte[] { 148, 210, 139, 107, 99, 223, 141, 55, 229, 71, 55, 39, 108, 193, 71, 158, 90, 238, 13, 166, 229, 172, 109, 243, 19, 1, 13, 174, 114, 12, 248, 129, 224, 206, 89, 187, 100, 127, 19, 177, 18, 71, 53, 167, 223, 38, 131, 90, 120, 87, 14, 199, 101, 170, 179, 253, 123, 2, 60, 204, 124, 169, 106, 133, 150, 57, 84, 67, 206, 222, 195, 86, 97, 236, 155, 246, 193, 175, 174, 223, 32, 138, 24, 48, 147, 128, 132, 18, 118, 191, 69, 73, 248, 241, 100, 143, 237, 11, 174, 252, 157, 150, 140, 101, 140, 85, 230, 154, 132, 126, 30, 43, 100, 10, 7, 207, 113, 88, 217, 3, 140, 159, 51, 86, 218, 128, 135, 186 } }
                });

            migrationBuilder.InsertData(
                table: "AutomatItemInfos",
                columns: new[] { "Id", "Count", "CreatedDate", "CreatedUserId", "IsDeleted", "ModifiedDate", "ModifiedUserId" },
                values: new object[,]
                {
                    { 6, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 5, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 4, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 7, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 2, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 1, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 3, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "AdminUserId", "CountiesId", "CountryId", "CreatedDate", "CreatedUserId", "IsDeleted", "ModifiedDate", "ModifiedUserId", "Name" },
                values: new object[,]
                {
                    { 36, null, null, 59, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2350), 1, false, null, null, "Malkara" },
                    { 27, null, null, 17, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2335), 1, false, null, null, "Ezine" },
                    { 28, null, null, 17, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2336), 1, false, null, null, "Gelibolu" },
                    { 29, null, null, 59, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2339), 1, false, null, null, "Şarköy" },
                    { 31, null, null, 59, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2341), 1, false, null, null, "Süleymanpaşa" },
                    { 32, null, null, 59, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2343), 1, false, null, null, "Çorlu" },
                    { 33, null, null, 59, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2345), 1, false, null, null, "Çerkezköy" },
                    { 34, null, null, 59, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2347), 1, false, null, null, "Saray" },
                    { 35, null, null, 59, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2349), 1, false, null, null, "Kapaklı" },
                    { 37, null, null, 22, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2352), 1, false, null, null, "Keşan" },
                    { 43, null, null, 67, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2365), 1, false, null, null, "Çaycuma" },
                    { 39, null, null, 22, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2357), 1, false, null, null, "İpsala" },
                    { 41, null, null, 67, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2361), 1, false, null, null, "Alaplı" },
                    { 42, null, null, 67, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2363), 1, false, null, null, "Gökçebey" },
                    { 26, null, null, 17, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2332), 1, false, null, null, "Ayvacık" },
                    { 44, null, null, 61, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2367), 1, false, null, null, "Akçaabat" },
                    { 45, null, null, 61, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2369), 1, false, null, null, "Düzköy" },
                    { 46, null, null, 61, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2371), 1, false, null, null, "Enez" },
                    { 47, null, null, 61, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2373), 1, false, null, null, "Arsin" },
                    { 48, null, null, 61, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2375), 1, false, null, null, "Beşikdüzü" },
                    { 38, null, null, 22, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2355), 1, false, null, null, "Edirne" },
                    { 25, null, null, 17, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2330), 1, false, null, null, "Biga" },
                    { 40, null, null, 67, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2359), 1, false, null, null, "Zonguldak" },
                    { 23, null, null, 1, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2326), 1, false, null, null, "Çanakkale " },
                    { 24, null, null, 17, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2328), 1, false, null, null, "Bozcaada" },
                    { 1, null, null, 34, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(889), 1, false, null, null, "Sarıyer" },
                    { 2, null, null, 34, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2249), 1, false, null, null, "Beyoğlu" },
                    { 4, null, null, 34, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2286), 1, false, null, null, "Kadıköy" },
                    { 5, null, null, 34, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2288), 1, false, null, null, "Esenler" },
                    { 6, null, null, 34, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2290), 1, false, null, null, "Maltepe" },
                    { 7, null, null, 34, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2292), 1, false, null, null, "Zeytinburnu" },
                    { 8, null, null, 34, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2294), 1, false, null, null, "Bakırköy" },
                    { 9, null, null, 34, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2296), 1, false, null, null, "Beylikdüzü" },
                    { 11, null, null, 42, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2298), 1, false, null, null, "Selçuklu" },
                    { 3, null, null, 34, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2283), 1, false, null, null, "Kartal" },
                    { 13, null, null, 42, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2303), 1, false, null, null, "Akşehir" },
                    { 12, null, null, 42, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2301), 1, false, null, null, "Beyşehir" },
                    { 21, null, null, 1, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2321), 1, false, null, null, "Beypazarı" },
                    { 19, null, null, 1, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2316), 1, false, null, null, "Şereflikoçhisar" },
                    { 18, null, null, 1, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2313), 1, false, null, null, "Gölbaşı" },
                    { 20, null, null, 1, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2318), 1, false, null, null, "Keçiören" },
                    { 16, null, null, 35, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2309), 1, false, null, null, "Selçuk" },
                    { 15, null, null, 35, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2307), 1, false, null, null, "Foça" },
                    { 14, null, null, 42, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2305), 1, false, null, null, "Cihanbeyli" },
                    { 17, null, null, 35, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2311), 1, false, null, null, "Urla " },
                    { 22, null, null, 1, new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2323), 1, false, null, null, "Polatlı" }
                });

            migrationBuilder.InsertData(
                table: "Counties",
                columns: new[] { "Id", "AdminUserId", "CountryName", "CreatedDate", "CreatedUserId", "IsDeleted", "ModifiedDate", "ModifiedUserId" },
                values: new object[,]
                {
                    { 59, null, "Tekirdağ", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 53, null, "Rize", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 60, null, "Tokat", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 58, null, "Sivas", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 57, null, "Sinop", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 56, null, "Siirt", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 55, null, "Samsun", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 54, null, "Sakarya", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
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
                    { 2, null, "Adıyaman", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 1, null, "Adana", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 18, null, "Çankırı", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 19, null, "Çorum", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 20, null, "Denizli", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 21, null, "Diyarbakır", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 39, null, "Kırklareli", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 38, null, "Kayseri", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 37, null, "Kastamonu", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 36, null, "Kars", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 35, null, "İzmir", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 33, null, "İçel", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 32, null, "Isparta", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 30, null, "Hakkari", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 31, null, "Hatay", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 28, null, "Giresun", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 27, null, "Gaziantep", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 26, null, "Eskişehir", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 25, null, "Erzurum", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 24, null, "Erzincan", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 23, null, "Elazığ", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 22, null, "Edirne", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 29, null, "Gümüşhane", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 41, null, "Kocaeli", new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "ItemCategories",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "Description", "IsDeleted", "ModifiedDate", "ModifiedUserId", "Name" },
                values: new object[,]
                {
                    { 3, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "", false, null, null, "Meyve" },
                    { 4, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "", false, null, null, "Kuruyemiş" },
                    { 2, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "", false, null, null, "Katı Gıda" },
                    { 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "", false, null, null, "İçecek" }
                });

            migrationBuilder.InsertData(
                table: "MenuTypes",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "Description", "FinishDate", "IsDeleted", "ModifiedDate", "ModifiedUserId", "StartDate", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new TimeSpan(0, 10, 0, 0, 0), false, null, null, new TimeSpan(0, 6, 0, 0, 0), "Sabah" },
                    { 2, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new TimeSpan(0, 3, 0, 0, 0), false, null, null, new TimeSpan(0, 12, 0, 0, 0), "Öğle" }
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "AdminUserId", "CreatedDate", "CreatedUserId", "IsDeleted", "ModifiedDate", "ModifiedUserId", "Name" },
                values: new object[,]
                {
                    { 9, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Parent.Delete" },
                    { 8, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Parent.Add" },
                    { 7, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Student.Update" },
                    { 5, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Student.GetById" },
                    { 6, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Student.Delete" },
                    { 3, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Member.Create" },
                    { 2, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Member" },
                    { 1, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Admin" },
                    { 4, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Student.Add" },
                    { 10, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Parent.Update" }
                });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "AdminUserId", "CreatedDate", "CreatedUserId", "Email", "FullName", "IsDeleted", "ModifiedDate", "ModifiedUserId", "PasswordHash", "PasswordSalt" },
                values: new object[] { 1, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "ereninal10@gmail.com", "Eren İNAL", false, null, null, new byte[] { 103, 243, 137, 139, 2, 212, 232, 73, 116, 92, 150, 207, 8, 135, 17, 163, 124, 151, 158, 108, 97, 144, 30, 134, 58, 226, 70, 189, 244, 8, 183, 181, 164, 158, 39, 39, 163, 155, 142, 111, 253, 66, 106, 243, 160, 243, 207, 95, 175, 156, 155, 187, 251, 147, 243, 243, 43, 233, 146, 189, 38, 59, 233, 189 }, new byte[] { 148, 210, 139, 107, 99, 223, 141, 55, 229, 71, 55, 39, 108, 193, 71, 158, 90, 238, 13, 166, 229, 172, 109, 243, 19, 1, 13, 174, 114, 12, 248, 129, 224, 206, 89, 187, 100, 127, 19, 177, 18, 71, 53, 167, 223, 38, 131, 90, 120, 87, 14, 199, 101, 170, 179, 253, 123, 2, 60, 204, 124, 169, 106, 133, 150, 57, 84, 67, 206, 222, 195, 86, 97, 236, 155, 246, 193, 175, 174, 223, 32, 138, 24, 48, 147, 128, 132, 18, 118, 191, 69, 73, 248, 241, 100, 143, 237, 11, 174, 252, 157, 150, 140, 101, 140, 85, 230, 154, 132, 126, 30, 43, 100, 10, 7, 207, 113, 88, 217, 3, 140, 159, 51, 86, 218, 128, 135, 186 } });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "AdminUserId", "CountryId", "CountyId", "CreatedDate", "CreatedUserId", "IsDeleted", "ModifiedDate", "ModifiedUserId", "Name", "TownId" },
                values: new object[,]
                {
                    { 19, null, null, 17, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Çanakkale 18 Mart Üniversitesi", 0 },
                    { 16, null, null, 1, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Ankara Üniversitesi", 0 },
                    { 17, null, null, 1, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Orta Doğu Teknik Üniversitesi", 0 },
                    { 18, null, null, 1, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Bilkent Üniversitesi", 0 },
                    { 25, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Gelişim Üniversitesi", 0 },
                    { 21, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "İstanbul Aydın Üniversitesi", 0 },
                    { 22, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Nişantaşı Üniversitesi", 0 },
                    { 23, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Marmara Üniversitesi", 0 },
                    { 24, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Boğaziçi Üniversitesi", 0 },
                    { 15, null, null, 22, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Trakya Üniversitesi", 0 },
                    { 20, null, null, 32, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Süleyman Demirel Üniversitesi", 0 },
                    { 14, null, null, 59, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Namık Kemal Üniversitesi", 0 },
                    { 6, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "İstanbul Üniversitesi", 0 },
                    { 12, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Gebze Teknik Üniversitesi", 0 },
                    { 11, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Kocaeli Üniversitesi", 0 },
                    { 10, null, null, 42, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Konya Teknik Üniversitesi", 0 },
                    { 9, null, null, 35, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Ege Üniversitesi", 0 },
                    { 8, null, null, 61, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Karadeniz Teknik Üniversitesi", 0 },
                    { 7, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "İstanbul Teknik Üniversitesi", 0 },
                    { 5, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Yıldız Teknik Üniversitesi", 0 },
                    { 4, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Koç Üniversitesi", 0 },
                    { 3, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Sabancı Üniversitesi", 0 },
                    { 2, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Beykent Üniversitesi", 0 },
                    { 1, null, null, 42, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Selçuk Üniversitesi", 0 },
                    { 13, null, null, 67, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Fırat Üniversitesi", 0 },
                    { 26, null, null, 34, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, "Milli Savunma Üniversitesi", 0 }
                });

            migrationBuilder.InsertData(
                table: "AutomatInfo",
                columns: new[] { "Id", "AdminUserId", "Brand", "Count", "CreatedDate", "CreatedUserId", "IsDeleted", "LastRepairDate", "Model", "ModifiedDate", "ModifiedUserId", "Number", "SchoolId", "StartDate" },
                values: new object[,]
                {
                    { 10, null, "Pe-Tek", 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "BUMATIK-10", 11, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, "Pe-Tek", 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "BUMATIK-8", 9, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, "Pe-Tek", 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "BUMATIK-7", 8, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, "Pe-Tek", 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "BUMATIK-6", 7, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, "Pe-Tek", 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "BUMATIK-5", 6, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, "Pe-Tek", 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "BUMATIK-4", 5, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, "Pe-Tek", 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "BUMATIK-3", 4, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, "Pe-Tek", 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "BUMATIK-2", 2, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, "Pe-Tek", 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "BUMATIK-9", 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, null, "Pe-Tek", 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "BUMATIK-1", 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AutomatItems",
                columns: new[] { "Id", "AutomatItemInfoId", "CreatedDate", "CreatedUserId", "Description", "IsDeleted", "ItemCategoryId", "ModifiedDate", "ModifiedUserId", "Name", "Price" },
                values: new object[,]
                {
                    { 4, 4, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, false, 1, null, null, "Erikli Su", 2m },
                    { 3, 3, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, false, 4, null, null, "Fındık", 7m },
                    { 2, 2, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, false, 4, null, null, "Ceviz", 5m },
                    { 1, 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, false, 3, null, null, "Portakal", 2m },
                    { 7, 7, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, false, 2, null, null, "Sandviç", 8m },
                    { 6, 6, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, false, 1, null, null, "Hamidiye Su", 2m },
                    { 5, 5, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, false, 1, null, null, "Damla Su", 1m }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "AdminUserId", "BandNumber", "BirthDate", "CreatedDate", "CreatedUserId", "FullName", "Image", "IsDeleted", "ModifieUserId", "ModifiedDate", "ModifiedUserId", "ParentId", "RemainingMoney", "SchoolId" },
                values: new object[,]
                {
                    { 2, null, "22222", null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Aras İNAL", null, false, null, null, null, 1, 50m, 2 },
                    { 1, null, "11111", null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mira İNAL", null, false, null, null, null, 1, 50m, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "AdminUserId", "CreatedDate", "CreatedUserId", "IsDeleted", "ModifiedDate", "ModifiedUserId", "OperationClaimId", "ParentId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, 1, 1 },
                    { 2, null, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "IsDeleted", "MenuTypeId", "ModifiedDate", "ModifiedUserId", "StudentId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 1, null, null, 2 },
                    { 2, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 2, null, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "StudentMenus",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "IsDeleted", "ModifiedDate", "ModifiedUserId", "SeledtedItem", "Status", "StudentId" },
                values: new object[] { 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, null, "{'Elma','Portakal','Su' }", false, 1 });

            migrationBuilder.InsertData(
                table: "SelectedMenuItems",
                columns: new[] { "Id", "AutomatItemId", "Count", "CreatedDate", "CreatedUserId", "IsDeleted", "LastStatus", "LastStatusDate", "MenuId", "ModifiedDate", "ModifiedUserId", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, 2, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, 1 },
                    { 2, 2, 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, 1 },
                    { 3, 3, 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, 1 },
                    { 4, 7, 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, null, 1 },
                    { 5, 2, 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, null, 1 },
                    { 6, 3, 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, null, 1 }
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
                name: "IX_AutomatItems_AutomatItemInfoId",
                table: "AutomatItems",
                column: "AutomatItemInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_AutomatItems_ItemCategoryId",
                table: "AutomatItems",
                column: "ItemCategoryId");

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
                name: "IX_Menus_MenuTypeId",
                table: "Menus",
                column: "MenuTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_StudentId",
                table: "Menus",
                column: "StudentId");

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
                name: "IX_SelectedMenuItems_AutomatItemId",
                table: "SelectedMenuItems",
                column: "AutomatItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedMenuItems_MenuId",
                table: "SelectedMenuItems",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedMenuItems_StudentId",
                table: "SelectedMenuItems",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_SendEmailOrSms_AdminUserId",
                table: "SendEmailOrSms",
                column: "AdminUserId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentMenus_StudentId",
                table: "StudentMenus",
                column: "StudentId");

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
                name: "SelectedMenuItems");

            migrationBuilder.DropTable(
                name: "SendEmailOrSms");

            migrationBuilder.DropTable(
                name: "StudentMenus");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "AutomatItems");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "AutomatItemInfos");

            migrationBuilder.DropTable(
                name: "ItemCategories");

            migrationBuilder.DropTable(
                name: "MenuTypes");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Parents");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "Counties");

            migrationBuilder.DropTable(
                name: "AdminUsers");
        }
    }
}
