using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Petek.BUmatik.DataAccess.Migrations
{
    public partial class NewTablesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DropColumn(
                name: "LastUseDate",
                table: "AutomatItems");

            migrationBuilder.RenameColumn(
                name: "Count",
                table: "AutomatItems",
                newName: "InfoId");

            migrationBuilder.AddColumn<int>(
                name: "AutomatItemInfoId",
                table: "AutomatItems",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "AutomatItems",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AutomatItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemCategoryId",
                table: "AutomatItems",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "AutomatItems",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

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
                name: "SelectedMenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Count = table.Column<int>(type: "integer", nullable: false),
                    MenuId = table.Column<int>(type: "integer", nullable: false),
                    ItemId = table.Column<int>(type: "integer", nullable: false),
                    StudentId = table.Column<int>(type: "integer", nullable: false),
                    LastStatus = table.Column<bool>(type: "boolean", nullable: false),
                    LastStatusDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    AutomatItemId = table.Column<int>(type: "integer", nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 176, 23, 89, 38, 97, 156, 126, 167, 107, 246, 65, 77, 101, 194, 56, 225, 118, 27, 92, 145, 11, 247, 83, 221, 10, 255, 112, 66, 108, 97, 140, 37, 156, 146, 233, 225, 238, 101, 203, 105, 24, 62, 3, 128, 74, 150, 66, 103, 182, 14, 63, 67, 90, 112, 197, 179, 96, 80, 51, 134, 2, 140, 36, 18 }, new byte[] { 202, 149, 179, 34, 187, 127, 133, 54, 153, 74, 159, 239, 240, 17, 219, 238, 140, 136, 189, 232, 60, 100, 43, 78, 104, 86, 207, 139, 130, 24, 149, 213, 251, 150, 109, 246, 215, 205, 198, 151, 243, 159, 95, 11, 169, 186, 234, 81, 234, 216, 14, 116, 86, 120, 105, 141, 254, 45, 34, 3, 6, 189, 96, 196, 13, 99, 230, 124, 123, 146, 58, 64, 83, 90, 67, 175, 247, 80, 133, 85, 203, 231, 177, 150, 80, 33, 71, 174, 83, 60, 103, 66, 0, 16, 162, 154, 29, 4, 183, 69, 3, 80, 209, 79, 165, 238, 223, 199, 97, 63, 240, 201, 82, 128, 250, 23, 195, 85, 200, 107, 21, 221, 158, 116, 29, 195, 219, 212 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 176, 23, 89, 38, 97, 156, 126, 167, 107, 246, 65, 77, 101, 194, 56, 225, 118, 27, 92, 145, 11, 247, 83, 221, 10, 255, 112, 66, 108, 97, 140, 37, 156, 146, 233, 225, 238, 101, 203, 105, 24, 62, 3, 128, 74, 150, 66, 103, 182, 14, 63, 67, 90, 112, 197, 179, 96, 80, 51, 134, 2, 140, 36, 18 }, new byte[] { 202, 149, 179, 34, 187, 127, 133, 54, 153, 74, 159, 239, 240, 17, 219, 238, 140, 136, 189, 232, 60, 100, 43, 78, 104, 86, 207, 139, 130, 24, 149, 213, 251, 150, 109, 246, 215, 205, 198, 151, 243, 159, 95, 11, 169, 186, 234, 81, 234, 216, 14, 116, 86, 120, 105, 141, 254, 45, 34, 3, 6, 189, 96, 196, 13, 99, 230, 124, 123, 146, 58, 64, 83, 90, 67, 175, 247, 80, 133, 85, 203, 231, 177, 150, 80, 33, 71, 174, 83, 60, 103, 66, 0, 16, 162, 154, 29, 4, 183, 69, 3, 80, 209, 79, 165, 238, 223, 199, 97, 63, 240, 201, 82, 128, 250, 23, 195, 85, 200, 107, 21, 221, 158, 116, 29, 195, 219, 212 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 176, 23, 89, 38, 97, 156, 126, 167, 107, 246, 65, 77, 101, 194, 56, 225, 118, 27, 92, 145, 11, 247, 83, 221, 10, 255, 112, 66, 108, 97, 140, 37, 156, 146, 233, 225, 238, 101, 203, 105, 24, 62, 3, 128, 74, 150, 66, 103, 182, 14, 63, 67, 90, 112, 197, 179, 96, 80, 51, 134, 2, 140, 36, 18 }, new byte[] { 202, 149, 179, 34, 187, 127, 133, 54, 153, 74, 159, 239, 240, 17, 219, 238, 140, 136, 189, 232, 60, 100, 43, 78, 104, 86, 207, 139, 130, 24, 149, 213, 251, 150, 109, 246, 215, 205, 198, 151, 243, 159, 95, 11, 169, 186, 234, 81, 234, 216, 14, 116, 86, 120, 105, 141, 254, 45, 34, 3, 6, 189, 96, 196, 13, 99, 230, 124, 123, 146, 58, 64, 83, 90, 67, 175, 247, 80, 133, 85, 203, 231, 177, 150, 80, 33, 71, 174, 83, 60, 103, 66, 0, 16, 162, 154, 29, 4, 183, 69, 3, 80, 209, 79, 165, 238, 223, 199, 97, 63, 240, 201, 82, 128, 250, 23, 195, 85, 200, 107, 21, 221, 158, 116, 29, 195, 219, 212 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 176, 23, 89, 38, 97, 156, 126, 167, 107, 246, 65, 77, 101, 194, 56, 225, 118, 27, 92, 145, 11, 247, 83, 221, 10, 255, 112, 66, 108, 97, 140, 37, 156, 146, 233, 225, 238, 101, 203, 105, 24, 62, 3, 128, 74, 150, 66, 103, 182, 14, 63, 67, 90, 112, 197, 179, 96, 80, 51, 134, 2, 140, 36, 18 }, new byte[] { 202, 149, 179, 34, 187, 127, 133, 54, 153, 74, 159, 239, 240, 17, 219, 238, 140, 136, 189, 232, 60, 100, 43, 78, 104, 86, 207, 139, 130, 24, 149, 213, 251, 150, 109, 246, 215, 205, 198, 151, 243, 159, 95, 11, 169, 186, 234, 81, 234, 216, 14, 116, 86, 120, 105, 141, 254, 45, 34, 3, 6, 189, 96, 196, 13, 99, 230, 124, 123, 146, 58, 64, 83, 90, 67, 175, 247, 80, 133, 85, 203, 231, 177, 150, 80, 33, 71, 174, 83, 60, 103, 66, 0, 16, 162, 154, 29, 4, 183, 69, 3, 80, 209, 79, 165, 238, 223, 199, 97, 63, 240, 201, 82, 128, 250, 23, 195, 85, 200, 107, 21, 221, 158, 116, 29, 195, 219, 212 } });

            migrationBuilder.InsertData(
                table: "AutomatItemInfos",
                columns: new[] { "Id", "Count", "CreatedDate", "CreatedUserId", "IsDeleted", "ModifiedDate", "ModifiedUserId" },
                values: new object[,]
                {
                    { 7, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 1, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 5, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 6, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 2, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 3, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null },
                    { 4, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, null, null }
                });

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "InfoId", "Name", "Price" },
                values: new object[] { 3, 1, "Portakal", 2m });

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "InfoId", "Name", "Price" },
                values: new object[] { 4, 2, "Ceviz", 5m });

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "InfoId", "Name", "Price" },
                values: new object[] { 4, 3, "Fındık", 7m });

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "InfoId", "Name", "Price" },
                values: new object[] { 1, 4, "Erikli Su", 2m });

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "InfoId", "Name", "Price" },
                values: new object[] { 1, 5, "Damla Su", 1m });

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "InfoId", "Name", "Price" },
                values: new object[] { 1, 6, "Hamidiye Su", 2m });

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "InfoId", "Name", "Price" },
                values: new object[] { 2, 7, "Sandviç", 8m });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 1, 8, 43, 315, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.InsertData(
                table: "ItemCategories",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "Description", "IsDeleted", "ModifiedDate", "ModifiedUserId", "Name" },
                values: new object[,]
                {
                    { 4, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "", false, null, null, "Kuruyemiş" },
                    { 3, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "", false, null, null, "Meyve" },
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

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 176, 23, 89, 38, 97, 156, 126, 167, 107, 246, 65, 77, 101, 194, 56, 225, 118, 27, 92, 145, 11, 247, 83, 221, 10, 255, 112, 66, 108, 97, 140, 37, 156, 146, 233, 225, 238, 101, 203, 105, 24, 62, 3, 128, 74, 150, 66, 103, 182, 14, 63, 67, 90, 112, 197, 179, 96, 80, 51, 134, 2, 140, 36, 18 }, new byte[] { 202, 149, 179, 34, 187, 127, 133, 54, 153, 74, 159, 239, 240, 17, 219, 238, 140, 136, 189, 232, 60, 100, 43, 78, 104, 86, 207, 139, 130, 24, 149, 213, 251, 150, 109, 246, 215, 205, 198, 151, 243, 159, 95, 11, 169, 186, 234, 81, 234, 216, 14, 116, 86, 120, 105, 141, 254, 45, 34, 3, 6, 189, 96, 196, 13, 99, 230, 124, 123, 146, 58, 64, 83, 90, 67, 175, 247, 80, 133, 85, 203, 231, 177, 150, 80, 33, 71, 174, 83, 60, 103, 66, 0, 16, 162, 154, 29, 4, 183, 69, 3, 80, 209, 79, 165, 238, 223, 199, 97, 63, 240, 201, 82, 128, 250, 23, 195, 85, 200, 107, 21, 221, 158, 116, 29, 195, 219, 212 } });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "IsDeleted", "MenuTypeId", "ModifiedDate", "ModifiedUserId", "StudentId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 1, null, null, 2 },
                    { 2, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 2, null, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "SelectedMenuItems",
                columns: new[] { "Id", "AutomatItemId", "Count", "CreatedDate", "CreatedUserId", "IsDeleted", "ItemId", "LastStatus", "LastStatusDate", "MenuId", "ModifiedDate", "ModifiedUserId", "StudentId" },
                values: new object[,]
                {
                    { 1, null, 2, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, 1 },
                    { 2, null, 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, 1 },
                    { 3, null, 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 3, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, 1 },
                    { 4, null, 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 7, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, null, 1 },
                    { 5, null, 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, null, 1 },
                    { 6, null, 1, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 3, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, null, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutomatItems_AutomatItemInfoId",
                table: "AutomatItems",
                column: "AutomatItemInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_AutomatItems_ItemCategoryId",
                table: "AutomatItems",
                column: "ItemCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_MenuTypeId",
                table: "Menus",
                column: "MenuTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_StudentId",
                table: "Menus",
                column: "StudentId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AutomatItems_AutomatItemInfos_AutomatItemInfoId",
                table: "AutomatItems",
                column: "AutomatItemInfoId",
                principalTable: "AutomatItemInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AutomatItems_ItemCategories_ItemCategoryId",
                table: "AutomatItems",
                column: "ItemCategoryId",
                principalTable: "ItemCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutomatItems_AutomatItemInfos_AutomatItemInfoId",
                table: "AutomatItems");

            migrationBuilder.DropForeignKey(
                name: "FK_AutomatItems_ItemCategories_ItemCategoryId",
                table: "AutomatItems");

            migrationBuilder.DropTable(
                name: "AutomatItemInfos");

            migrationBuilder.DropTable(
                name: "ItemCategories");

            migrationBuilder.DropTable(
                name: "SelectedMenuItems");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "MenuTypes");

            migrationBuilder.DropIndex(
                name: "IX_AutomatItems_AutomatItemInfoId",
                table: "AutomatItems");

            migrationBuilder.DropIndex(
                name: "IX_AutomatItems_ItemCategoryId",
                table: "AutomatItems");

            migrationBuilder.DropColumn(
                name: "AutomatItemInfoId",
                table: "AutomatItems");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "AutomatItems");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AutomatItems");

            migrationBuilder.DropColumn(
                name: "ItemCategoryId",
                table: "AutomatItems");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "AutomatItems");

            migrationBuilder.RenameColumn(
                name: "InfoId",
                table: "AutomatItems",
                newName: "Count");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUseDate",
                table: "AutomatItems",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 221, 40, 93, 177, 188, 195, 43, 103, 184, 32, 129, 123, 77, 236, 14, 42, 166, 164, 15, 91, 249, 175, 152, 239, 200, 129, 80, 50, 244, 238, 36, 174, 254, 19, 52, 28, 36, 4, 125, 245, 33, 149, 201, 70, 162, 121, 44, 94, 9, 230, 66, 144, 2, 2, 249, 25, 49, 10, 55, 159, 247, 106, 56, 236 }, new byte[] { 46, 149, 101, 108, 7, 147, 131, 215, 202, 242, 162, 155, 160, 169, 218, 58, 93, 190, 181, 33, 9, 95, 118, 155, 109, 165, 188, 144, 35, 37, 166, 159, 200, 43, 23, 12, 103, 205, 190, 253, 61, 12, 165, 213, 100, 81, 232, 48, 37, 44, 139, 250, 215, 50, 112, 210, 23, 243, 93, 84, 203, 121, 71, 12, 205, 42, 145, 228, 50, 176, 88, 56, 158, 16, 81, 5, 14, 179, 119, 17, 227, 61, 81, 20, 154, 91, 44, 39, 146, 175, 101, 184, 164, 223, 124, 216, 224, 124, 145, 155, 37, 110, 209, 248, 202, 73, 187, 131, 162, 13, 119, 196, 177, 51, 237, 42, 93, 1, 57, 176, 196, 150, 41, 81, 157, 65, 194, 19 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 221, 40, 93, 177, 188, 195, 43, 103, 184, 32, 129, 123, 77, 236, 14, 42, 166, 164, 15, 91, 249, 175, 152, 239, 200, 129, 80, 50, 244, 238, 36, 174, 254, 19, 52, 28, 36, 4, 125, 245, 33, 149, 201, 70, 162, 121, 44, 94, 9, 230, 66, 144, 2, 2, 249, 25, 49, 10, 55, 159, 247, 106, 56, 236 }, new byte[] { 46, 149, 101, 108, 7, 147, 131, 215, 202, 242, 162, 155, 160, 169, 218, 58, 93, 190, 181, 33, 9, 95, 118, 155, 109, 165, 188, 144, 35, 37, 166, 159, 200, 43, 23, 12, 103, 205, 190, 253, 61, 12, 165, 213, 100, 81, 232, 48, 37, 44, 139, 250, 215, 50, 112, 210, 23, 243, 93, 84, 203, 121, 71, 12, 205, 42, 145, 228, 50, 176, 88, 56, 158, 16, 81, 5, 14, 179, 119, 17, 227, 61, 81, 20, 154, 91, 44, 39, 146, 175, 101, 184, 164, 223, 124, 216, 224, 124, 145, 155, 37, 110, 209, 248, 202, 73, 187, 131, 162, 13, 119, 196, 177, 51, 237, 42, 93, 1, 57, 176, 196, 150, 41, 81, 157, 65, 194, 19 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 221, 40, 93, 177, 188, 195, 43, 103, 184, 32, 129, 123, 77, 236, 14, 42, 166, 164, 15, 91, 249, 175, 152, 239, 200, 129, 80, 50, 244, 238, 36, 174, 254, 19, 52, 28, 36, 4, 125, 245, 33, 149, 201, 70, 162, 121, 44, 94, 9, 230, 66, 144, 2, 2, 249, 25, 49, 10, 55, 159, 247, 106, 56, 236 }, new byte[] { 46, 149, 101, 108, 7, 147, 131, 215, 202, 242, 162, 155, 160, 169, 218, 58, 93, 190, 181, 33, 9, 95, 118, 155, 109, 165, 188, 144, 35, 37, 166, 159, 200, 43, 23, 12, 103, 205, 190, 253, 61, 12, 165, 213, 100, 81, 232, 48, 37, 44, 139, 250, 215, 50, 112, 210, 23, 243, 93, 84, 203, 121, 71, 12, 205, 42, 145, 228, 50, 176, 88, 56, 158, 16, 81, 5, 14, 179, 119, 17, 227, 61, 81, 20, 154, 91, 44, 39, 146, 175, 101, 184, 164, 223, 124, 216, 224, 124, 145, 155, 37, 110, 209, 248, 202, 73, 187, 131, 162, 13, 119, 196, 177, 51, 237, 42, 93, 1, 57, 176, 196, 150, 41, 81, 157, 65, 194, 19 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 221, 40, 93, 177, 188, 195, 43, 103, 184, 32, 129, 123, 77, 236, 14, 42, 166, 164, 15, 91, 249, 175, 152, 239, 200, 129, 80, 50, 244, 238, 36, 174, 254, 19, 52, 28, 36, 4, 125, 245, 33, 149, 201, 70, 162, 121, 44, 94, 9, 230, 66, 144, 2, 2, 249, 25, 49, 10, 55, 159, 247, 106, 56, 236 }, new byte[] { 46, 149, 101, 108, 7, 147, 131, 215, 202, 242, 162, 155, 160, 169, 218, 58, 93, 190, 181, 33, 9, 95, 118, 155, 109, 165, 188, 144, 35, 37, 166, 159, 200, 43, 23, 12, 103, 205, 190, 253, 61, 12, 165, 213, 100, 81, 232, 48, 37, 44, 139, 250, 215, 50, 112, 210, 23, 243, 93, 84, 203, 121, 71, 12, 205, 42, 145, 228, 50, 176, 88, 56, 158, 16, 81, 5, 14, 179, 119, 17, 227, 61, 81, 20, 154, 91, 44, 39, 146, 175, 101, 184, 164, 223, 124, 216, 224, 124, 145, 155, 37, 110, 209, 248, 202, 73, 187, 131, 162, 13, 119, 196, 177, 51, 237, 42, 93, 1, 57, 176, 196, 150, 41, 81, 157, 65, 194, 19 } });

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Count", "LastUseDate", "Name" },
                values: new object[] { 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elma" });

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Count", "LastUseDate", "Name" },
                values: new object[] { 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Armut" });

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Count", "LastUseDate", "Name" },
                values: new object[] { 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ananas" });

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Count", "LastUseDate", "Name" },
                values: new object[] { 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Portakal" });

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Count", "LastUseDate", "Name" },
                values: new object[] { 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mandalina" });

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Count", "LastUseDate", "Name" },
                values: new object[] { 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kivi" });

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Count", "LastUseDate", "Name" },
                values: new object[] { 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Çilek" });

            migrationBuilder.InsertData(
                table: "AutomatItems",
                columns: new[] { "Id", "Count", "CreatedDate", "CreatedUserId", "IsDeleted", "LastUseDate", "ModifiedDate", "ModifiedUserId", "Name" },
                values: new object[,]
                {
                    { 8, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Muz" },
                    { 25, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kaju" },
                    { 24, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Erik" },
                    { 23, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kayısı" },
                    { 26, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Karadut" },
                    { 21, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nektari" },
                    { 9, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Avokado" },
                    { 10, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Üzüm" },
                    { 11, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hurma" },
                    { 22, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Yaban Mersini" },
                    { 13, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Greyfurt" },
                    { 14, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Badem" },
                    { 12, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nar" },
                    { 16, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ayva" },
                    { 17, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ceviz" },
                    { 18, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "KEstane" },
                    { 19, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Su" },
                    { 20, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "ŞEftali" },
                    { 15, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Fındık" }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 28, 15, 582, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 221, 40, 93, 177, 188, 195, 43, 103, 184, 32, 129, 123, 77, 236, 14, 42, 166, 164, 15, 91, 249, 175, 152, 239, 200, 129, 80, 50, 244, 238, 36, 174, 254, 19, 52, 28, 36, 4, 125, 245, 33, 149, 201, 70, 162, 121, 44, 94, 9, 230, 66, 144, 2, 2, 249, 25, 49, 10, 55, 159, 247, 106, 56, 236 }, new byte[] { 46, 149, 101, 108, 7, 147, 131, 215, 202, 242, 162, 155, 160, 169, 218, 58, 93, 190, 181, 33, 9, 95, 118, 155, 109, 165, 188, 144, 35, 37, 166, 159, 200, 43, 23, 12, 103, 205, 190, 253, 61, 12, 165, 213, 100, 81, 232, 48, 37, 44, 139, 250, 215, 50, 112, 210, 23, 243, 93, 84, 203, 121, 71, 12, 205, 42, 145, 228, 50, 176, 88, 56, 158, 16, 81, 5, 14, 179, 119, 17, 227, 61, 81, 20, 154, 91, 44, 39, 146, 175, 101, 184, 164, 223, 124, 216, 224, 124, 145, 155, 37, 110, 209, 248, 202, 73, 187, 131, 162, 13, 119, 196, 177, 51, 237, 42, 93, 1, 57, 176, 196, 150, 41, 81, 157, 65, 194, 19 } });
        }
    }
}
