using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Petek.BUmatik.DataAccess.Migrations
{
    public partial class PackageTypeTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PackageTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PackageName = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedUserId = table.Column<int>(type: "integer", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new byte[] { 125, 251, 70, 58, 86, 186, 215, 100, 210, 223, 99, 228, 62, 54, 95, 6, 210, 114, 238, 156, 163, 13, 196, 226, 155, 182, 89, 156, 18, 222, 155, 88, 21, 134, 130, 229, 248, 197, 47, 246, 88, 209, 196, 191, 102, 97, 72, 94, 16, 103, 206, 91, 235, 7, 141, 125, 67, 224, 201, 224, 227, 130, 158, 102 }, new byte[] { 163, 21, 180, 177, 15, 9, 38, 159, 2, 112, 130, 64, 9, 34, 134, 117, 89, 188, 211, 222, 21, 209, 10, 164, 45, 241, 244, 48, 233, 79, 94, 91, 243, 189, 113, 242, 164, 98, 255, 160, 94, 64, 101, 234, 253, 215, 13, 176, 220, 133, 100, 219, 96, 202, 105, 79, 104, 52, 67, 240, 235, 163, 87, 140, 239, 240, 184, 169, 16, 84, 255, 106, 175, 162, 62, 3, 154, 197, 122, 65, 40, 179, 69, 155, 178, 253, 229, 131, 74, 94, 48, 222, 90, 152, 134, 244, 133, 231, 17, 207, 29, 189, 114, 51, 93, 178, 114, 230, 80, 101, 23, 93, 59, 47, 77, 112, 33, 150, 89, 229, 162, 81, 208, 241, 83, 2, 145, 9 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new byte[] { 125, 251, 70, 58, 86, 186, 215, 100, 210, 223, 99, 228, 62, 54, 95, 6, 210, 114, 238, 156, 163, 13, 196, 226, 155, 182, 89, 156, 18, 222, 155, 88, 21, 134, 130, 229, 248, 197, 47, 246, 88, 209, 196, 191, 102, 97, 72, 94, 16, 103, 206, 91, 235, 7, 141, 125, 67, 224, 201, 224, 227, 130, 158, 102 }, new byte[] { 163, 21, 180, 177, 15, 9, 38, 159, 2, 112, 130, 64, 9, 34, 134, 117, 89, 188, 211, 222, 21, 209, 10, 164, 45, 241, 244, 48, 233, 79, 94, 91, 243, 189, 113, 242, 164, 98, 255, 160, 94, 64, 101, 234, 253, 215, 13, 176, 220, 133, 100, 219, 96, 202, 105, 79, 104, 52, 67, 240, 235, 163, 87, 140, 239, 240, 184, 169, 16, 84, 255, 106, 175, 162, 62, 3, 154, 197, 122, 65, 40, 179, 69, 155, 178, 253, 229, 131, 74, 94, 48, 222, 90, 152, 134, 244, 133, 231, 17, 207, 29, 189, 114, 51, 93, 178, 114, 230, 80, 101, 23, 93, 59, 47, 77, 112, 33, 150, 89, 229, 162, 81, 208, 241, 83, 2, 145, 9 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new byte[] { 125, 251, 70, 58, 86, 186, 215, 100, 210, 223, 99, 228, 62, 54, 95, 6, 210, 114, 238, 156, 163, 13, 196, 226, 155, 182, 89, 156, 18, 222, 155, 88, 21, 134, 130, 229, 248, 197, 47, 246, 88, 209, 196, 191, 102, 97, 72, 94, 16, 103, 206, 91, 235, 7, 141, 125, 67, 224, 201, 224, 227, 130, 158, 102 }, new byte[] { 163, 21, 180, 177, 15, 9, 38, 159, 2, 112, 130, 64, 9, 34, 134, 117, 89, 188, 211, 222, 21, 209, 10, 164, 45, 241, 244, 48, 233, 79, 94, 91, 243, 189, 113, 242, 164, 98, 255, 160, 94, 64, 101, 234, 253, 215, 13, 176, 220, 133, 100, 219, 96, 202, 105, 79, 104, 52, 67, 240, 235, 163, 87, 140, 239, 240, 184, 169, 16, 84, 255, 106, 175, 162, 62, 3, 154, 197, 122, 65, 40, 179, 69, 155, 178, 253, 229, 131, 74, 94, 48, 222, 90, 152, 134, 244, 133, 231, 17, 207, 29, 189, 114, 51, 93, 178, 114, 230, 80, 101, 23, 93, 59, 47, 77, 112, 33, 150, 89, 229, 162, 81, 208, 241, 83, 2, 145, 9 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new byte[] { 125, 251, 70, 58, 86, 186, 215, 100, 210, 223, 99, 228, 62, 54, 95, 6, 210, 114, 238, 156, 163, 13, 196, 226, 155, 182, 89, 156, 18, 222, 155, 88, 21, 134, 130, 229, 248, 197, 47, 246, 88, 209, 196, 191, 102, 97, 72, 94, 16, 103, 206, 91, 235, 7, 141, 125, 67, 224, 201, 224, 227, 130, 158, 102 }, new byte[] { 163, 21, 180, 177, 15, 9, 38, 159, 2, 112, 130, 64, 9, 34, 134, 117, 89, 188, 211, 222, 21, 209, 10, 164, 45, 241, 244, 48, 233, 79, 94, 91, 243, 189, 113, 242, 164, 98, 255, 160, 94, 64, 101, 234, 253, 215, 13, 176, 220, 133, 100, 219, 96, 202, 105, 79, 104, 52, 67, 240, 235, 163, 87, 140, 239, 240, 184, 169, 16, 84, 255, 106, 175, 162, 62, 3, 154, 197, 122, 65, 40, 179, 69, 155, 178, 253, 229, 131, 74, 94, 48, 222, 90, 152, 134, 244, 133, 231, 17, 207, 29, 189, 114, 51, 93, 178, 114, 230, 80, 101, 23, 93, 59, 47, 77, 112, 33, 150, 89, 229, 162, 81, 208, 241, 83, 2, 145, 9 } });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970) });

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "MenuTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "MenuTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.InsertData(
                table: "PackageTypes",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "IsDeleted", "ModifiedDate", "ModifiedUserId", "PackageName" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), 1, false, null, null, "Menü 1" },
                    { 18, new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), 1, false, null, null, "Menü 18" },
                    { 3, new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), 1, false, null, null, "Menü 3" },
                    { 4, new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), 1, false, null, null, "Menü 4" },
                    { 5, new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), 1, false, null, null, "Menü 5" },
                    { 6, new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), 1, false, null, null, "Menü 6" },
                    { 7, new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), 1, false, null, null, "Menü 7" },
                    { 8, new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), 1, false, null, null, "Menü 8" },
                    { 9, new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), 1, false, null, null, "Menü 9" },
                    { 2, new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), 1, false, null, null, "Menü 2" },
                    { 11, new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), 1, false, null, null, "Menü 11" },
                    { 12, new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), 1, false, null, null, "Menü 12" },
                    { 13, new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), 1, false, null, null, "Menü 13" },
                    { 14, new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), 1, false, null, null, "Menü 14" },
                    { 15, new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), 1, false, null, null, "Menü 15" },
                    { 16, new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), 1, false, null, null, "Menü 16" },
                    { 17, new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), 1, false, null, null, "Menü 17" },
                    { 10, new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), 1, false, null, null, "Menü 10" }
                });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new byte[] { 125, 251, 70, 58, 86, 186, 215, 100, 210, 223, 99, 228, 62, 54, 95, 6, 210, 114, 238, 156, 163, 13, 196, 226, 155, 182, 89, 156, 18, 222, 155, 88, 21, 134, 130, 229, 248, 197, 47, 246, 88, 209, 196, 191, 102, 97, 72, 94, 16, 103, 206, 91, 235, 7, 141, 125, 67, 224, 201, 224, 227, 130, 158, 102 }, new byte[] { 163, 21, 180, 177, 15, 9, 38, 159, 2, 112, 130, 64, 9, 34, 134, 117, 89, 188, 211, 222, 21, 209, 10, 164, 45, 241, 244, 48, 233, 79, 94, 91, 243, 189, 113, 242, 164, 98, 255, 160, 94, 64, 101, 234, 253, 215, 13, 176, 220, 133, 100, 219, 96, 202, 105, 79, 104, 52, 67, 240, 235, 163, 87, 140, 239, 240, 184, 169, 16, 84, 255, 106, 175, 162, 62, 3, 154, 197, 122, 65, 40, 179, 69, 155, 178, 253, 229, 131, 74, 94, 48, 222, 90, 152, 134, 244, 133, 231, 17, 207, 29, 189, 114, 51, 93, 178, 114, 230, 80, 101, 23, 93, 59, 47, 77, 112, 33, 150, 89, 229, 162, 81, 208, 241, 83, 2, 145, 9 } });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new byte[] { 125, 251, 70, 58, 86, 186, 215, 100, 210, 223, 99, 228, 62, 54, 95, 6, 210, 114, 238, 156, 163, 13, 196, 226, 155, 182, 89, 156, 18, 222, 155, 88, 21, 134, 130, 229, 248, 197, 47, 246, 88, 209, 196, 191, 102, 97, 72, 94, 16, 103, 206, 91, 235, 7, 141, 125, 67, 224, 201, 224, 227, 130, 158, 102 }, new byte[] { 163, 21, 180, 177, 15, 9, 38, 159, 2, 112, 130, 64, 9, 34, 134, 117, 89, 188, 211, 222, 21, 209, 10, 164, 45, 241, 244, 48, 233, 79, 94, 91, 243, 189, 113, 242, 164, 98, 255, 160, 94, 64, 101, 234, 253, 215, 13, 176, 220, 133, 100, 219, 96, 202, 105, 79, 104, 52, 67, 240, 235, 163, 87, 140, 239, 240, 184, 169, 16, 84, 255, 106, 175, 162, 62, 3, 154, 197, 122, 65, 40, 179, 69, 155, 178, 253, 229, 131, 74, 94, 48, 222, 90, 152, 134, 244, 133, 231, 17, 207, 29, 189, 114, 51, 93, 178, 114, 230, 80, 101, 23, 93, 59, 47, 77, 112, 33, 150, 89, 229, 162, 81, 208, 241, 83, 2, 145, 9 } });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new byte[] { 125, 251, 70, 58, 86, 186, 215, 100, 210, 223, 99, 228, 62, 54, 95, 6, 210, 114, 238, 156, 163, 13, 196, 226, 155, 182, 89, 156, 18, 222, 155, 88, 21, 134, 130, 229, 248, 197, 47, 246, 88, 209, 196, 191, 102, 97, 72, 94, 16, 103, 206, 91, 235, 7, 141, 125, 67, 224, 201, 224, 227, 130, 158, 102 }, new byte[] { 163, 21, 180, 177, 15, 9, 38, 159, 2, 112, 130, 64, 9, 34, 134, 117, 89, 188, 211, 222, 21, 209, 10, 164, 45, 241, 244, 48, 233, 79, 94, 91, 243, 189, 113, 242, 164, 98, 255, 160, 94, 64, 101, 234, 253, 215, 13, 176, 220, 133, 100, 219, 96, 202, 105, 79, 104, 52, 67, 240, 235, 163, 87, 140, 239, 240, 184, 169, 16, 84, 255, 106, 175, 162, 62, 3, 154, 197, 122, 65, 40, 179, 69, 155, 178, 253, 229, 131, 74, 94, 48, 222, 90, 152, 134, 244, 133, 231, 17, 207, 29, 189, 114, 51, 93, 178, 114, 230, 80, 101, 23, 93, 59, 47, 77, 112, 33, 150, 89, 229, 162, 81, 208, 241, 83, 2, 145, 9 } });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new byte[] { 125, 251, 70, 58, 86, 186, 215, 100, 210, 223, 99, 228, 62, 54, 95, 6, 210, 114, 238, 156, 163, 13, 196, 226, 155, 182, 89, 156, 18, 222, 155, 88, 21, 134, 130, 229, 248, 197, 47, 246, 88, 209, 196, 191, 102, 97, 72, 94, 16, 103, 206, 91, 235, 7, 141, 125, 67, 224, 201, 224, 227, 130, 158, 102 }, new byte[] { 163, 21, 180, 177, 15, 9, 38, 159, 2, 112, 130, 64, 9, 34, 134, 117, 89, 188, 211, 222, 21, 209, 10, 164, 45, 241, 244, 48, 233, 79, 94, 91, 243, 189, 113, 242, 164, 98, 255, 160, 94, 64, 101, 234, 253, 215, 13, 176, 220, 133, 100, 219, 96, 202, 105, 79, 104, 52, 67, 240, 235, 163, 87, 140, 239, 240, 184, 169, 16, 84, 255, 106, 175, 162, 62, 3, 154, 197, 122, 65, 40, 179, 69, 155, 178, 253, 229, 131, 74, 94, 48, 222, 90, 152, 134, 244, 133, 231, 17, 207, 29, 189, 114, 51, 93, 178, 114, 230, 80, 101, 23, 93, 59, 47, 77, 112, 33, 150, 89, 229, 162, 81, 208, 241, 83, 2, 145, 9 } });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970), new byte[] { 125, 251, 70, 58, 86, 186, 215, 100, 210, 223, 99, 228, 62, 54, 95, 6, 210, 114, 238, 156, 163, 13, 196, 226, 155, 182, 89, 156, 18, 222, 155, 88, 21, 134, 130, 229, 248, 197, 47, 246, 88, 209, 196, 191, 102, 97, 72, 94, 16, 103, 206, 91, 235, 7, 141, 125, 67, 224, 201, 224, 227, 130, 158, 102 }, new byte[] { 163, 21, 180, 177, 15, 9, 38, 159, 2, 112, 130, 64, 9, 34, 134, 117, 89, 188, 211, 222, 21, 209, 10, 164, 45, 241, 244, 48, 233, 79, 94, 91, 243, 189, 113, 242, 164, 98, 255, 160, 94, 64, 101, 234, 253, 215, 13, 176, 220, 133, 100, 219, 96, 202, 105, 79, 104, 52, 67, 240, 235, 163, 87, 140, 239, 240, 184, 169, 16, 84, 255, 106, 175, 162, 62, 3, 154, 197, 122, 65, 40, 179, 69, 155, 178, 253, 229, 131, 74, 94, 48, 222, 90, 152, 134, 244, 133, 231, 17, 207, 29, 189, 114, 51, 93, 178, 114, 230, 80, 101, 23, 93, 59, 47, 77, 112, 33, 150, 89, 229, 162, 81, 208, 241, 83, 2, 145, 9 } });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "StudentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 20, 21, 21, 31, 6, DateTimeKind.Local).AddTicks(970));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PackageTypes");

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new byte[] { 251, 84, 184, 214, 12, 61, 178, 231, 171, 58, 31, 62, 2, 15, 126, 170, 151, 191, 204, 189, 31, 242, 10, 139, 34, 48, 168, 40, 199, 67, 126, 100, 180, 164, 255, 196, 66, 97, 179, 172, 229, 84, 169, 47, 170, 23, 108, 94, 168, 45, 229, 120, 107, 138, 7, 3, 143, 37, 188, 1, 65, 187, 91, 45 }, new byte[] { 16, 93, 173, 135, 234, 229, 251, 170, 4, 17, 76, 145, 237, 65, 197, 228, 50, 5, 181, 17, 210, 231, 176, 245, 147, 133, 175, 164, 206, 202, 77, 206, 186, 87, 144, 116, 117, 233, 168, 232, 134, 3, 70, 155, 117, 116, 195, 175, 185, 61, 43, 194, 72, 123, 99, 87, 77, 177, 150, 82, 152, 200, 49, 92, 27, 129, 102, 104, 144, 185, 220, 213, 159, 125, 158, 118, 158, 139, 150, 96, 224, 181, 92, 221, 131, 30, 236, 207, 218, 223, 82, 204, 244, 173, 175, 86, 173, 180, 0, 202, 250, 121, 35, 138, 57, 180, 64, 53, 44, 30, 218, 203, 96, 56, 224, 6, 129, 117, 143, 244, 176, 248, 208, 220, 99, 206, 213, 119 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new byte[] { 251, 84, 184, 214, 12, 61, 178, 231, 171, 58, 31, 62, 2, 15, 126, 170, 151, 191, 204, 189, 31, 242, 10, 139, 34, 48, 168, 40, 199, 67, 126, 100, 180, 164, 255, 196, 66, 97, 179, 172, 229, 84, 169, 47, 170, 23, 108, 94, 168, 45, 229, 120, 107, 138, 7, 3, 143, 37, 188, 1, 65, 187, 91, 45 }, new byte[] { 16, 93, 173, 135, 234, 229, 251, 170, 4, 17, 76, 145, 237, 65, 197, 228, 50, 5, 181, 17, 210, 231, 176, 245, 147, 133, 175, 164, 206, 202, 77, 206, 186, 87, 144, 116, 117, 233, 168, 232, 134, 3, 70, 155, 117, 116, 195, 175, 185, 61, 43, 194, 72, 123, 99, 87, 77, 177, 150, 82, 152, 200, 49, 92, 27, 129, 102, 104, 144, 185, 220, 213, 159, 125, 158, 118, 158, 139, 150, 96, 224, 181, 92, 221, 131, 30, 236, 207, 218, 223, 82, 204, 244, 173, 175, 86, 173, 180, 0, 202, 250, 121, 35, 138, 57, 180, 64, 53, 44, 30, 218, 203, 96, 56, 224, 6, 129, 117, 143, 244, 176, 248, 208, 220, 99, 206, 213, 119 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new byte[] { 251, 84, 184, 214, 12, 61, 178, 231, 171, 58, 31, 62, 2, 15, 126, 170, 151, 191, 204, 189, 31, 242, 10, 139, 34, 48, 168, 40, 199, 67, 126, 100, 180, 164, 255, 196, 66, 97, 179, 172, 229, 84, 169, 47, 170, 23, 108, 94, 168, 45, 229, 120, 107, 138, 7, 3, 143, 37, 188, 1, 65, 187, 91, 45 }, new byte[] { 16, 93, 173, 135, 234, 229, 251, 170, 4, 17, 76, 145, 237, 65, 197, 228, 50, 5, 181, 17, 210, 231, 176, 245, 147, 133, 175, 164, 206, 202, 77, 206, 186, 87, 144, 116, 117, 233, 168, 232, 134, 3, 70, 155, 117, 116, 195, 175, 185, 61, 43, 194, 72, 123, 99, 87, 77, 177, 150, 82, 152, 200, 49, 92, 27, 129, 102, 104, 144, 185, 220, 213, 159, 125, 158, 118, 158, 139, 150, 96, 224, 181, 92, 221, 131, 30, 236, 207, 218, 223, 82, 204, 244, 173, 175, 86, 173, 180, 0, 202, 250, 121, 35, 138, 57, 180, 64, 53, 44, 30, 218, 203, 96, 56, 224, 6, 129, 117, 143, 244, 176, 248, 208, 220, 99, 206, 213, 119 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new byte[] { 251, 84, 184, 214, 12, 61, 178, 231, 171, 58, 31, 62, 2, 15, 126, 170, 151, 191, 204, 189, 31, 242, 10, 139, 34, 48, 168, 40, 199, 67, 126, 100, 180, 164, 255, 196, 66, 97, 179, 172, 229, 84, 169, 47, 170, 23, 108, 94, 168, 45, 229, 120, 107, 138, 7, 3, 143, 37, 188, 1, 65, 187, 91, 45 }, new byte[] { 16, 93, 173, 135, 234, 229, 251, 170, 4, 17, 76, 145, 237, 65, 197, 228, 50, 5, 181, 17, 210, 231, 176, 245, 147, 133, 175, 164, 206, 202, 77, 206, 186, 87, 144, 116, 117, 233, 168, 232, 134, 3, 70, 155, 117, 116, 195, 175, 185, 61, 43, 194, 72, 123, 99, 87, 77, 177, 150, 82, 152, 200, 49, 92, 27, 129, 102, 104, 144, 185, 220, 213, 159, 125, 158, 118, 158, 139, 150, 96, 224, 181, 92, 221, 131, 30, 236, 207, 218, 223, 82, 204, 244, 173, 175, 86, 173, 180, 0, 202, 250, 121, 35, 138, 57, 180, 64, 53, 44, 30, 218, 203, 96, 56, 224, 6, 129, 117, 143, 244, 176, 248, 208, 220, 99, 206, 213, 119 } });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129) });

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "MenuTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "MenuTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new byte[] { 251, 84, 184, 214, 12, 61, 178, 231, 171, 58, 31, 62, 2, 15, 126, 170, 151, 191, 204, 189, 31, 242, 10, 139, 34, 48, 168, 40, 199, 67, 126, 100, 180, 164, 255, 196, 66, 97, 179, 172, 229, 84, 169, 47, 170, 23, 108, 94, 168, 45, 229, 120, 107, 138, 7, 3, 143, 37, 188, 1, 65, 187, 91, 45 }, new byte[] { 16, 93, 173, 135, 234, 229, 251, 170, 4, 17, 76, 145, 237, 65, 197, 228, 50, 5, 181, 17, 210, 231, 176, 245, 147, 133, 175, 164, 206, 202, 77, 206, 186, 87, 144, 116, 117, 233, 168, 232, 134, 3, 70, 155, 117, 116, 195, 175, 185, 61, 43, 194, 72, 123, 99, 87, 77, 177, 150, 82, 152, 200, 49, 92, 27, 129, 102, 104, 144, 185, 220, 213, 159, 125, 158, 118, 158, 139, 150, 96, 224, 181, 92, 221, 131, 30, 236, 207, 218, 223, 82, 204, 244, 173, 175, 86, 173, 180, 0, 202, 250, 121, 35, 138, 57, 180, 64, 53, 44, 30, 218, 203, 96, 56, 224, 6, 129, 117, 143, 244, 176, 248, 208, 220, 99, 206, 213, 119 } });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new byte[] { 251, 84, 184, 214, 12, 61, 178, 231, 171, 58, 31, 62, 2, 15, 126, 170, 151, 191, 204, 189, 31, 242, 10, 139, 34, 48, 168, 40, 199, 67, 126, 100, 180, 164, 255, 196, 66, 97, 179, 172, 229, 84, 169, 47, 170, 23, 108, 94, 168, 45, 229, 120, 107, 138, 7, 3, 143, 37, 188, 1, 65, 187, 91, 45 }, new byte[] { 16, 93, 173, 135, 234, 229, 251, 170, 4, 17, 76, 145, 237, 65, 197, 228, 50, 5, 181, 17, 210, 231, 176, 245, 147, 133, 175, 164, 206, 202, 77, 206, 186, 87, 144, 116, 117, 233, 168, 232, 134, 3, 70, 155, 117, 116, 195, 175, 185, 61, 43, 194, 72, 123, 99, 87, 77, 177, 150, 82, 152, 200, 49, 92, 27, 129, 102, 104, 144, 185, 220, 213, 159, 125, 158, 118, 158, 139, 150, 96, 224, 181, 92, 221, 131, 30, 236, 207, 218, 223, 82, 204, 244, 173, 175, 86, 173, 180, 0, 202, 250, 121, 35, 138, 57, 180, 64, 53, 44, 30, 218, 203, 96, 56, 224, 6, 129, 117, 143, 244, 176, 248, 208, 220, 99, 206, 213, 119 } });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new byte[] { 251, 84, 184, 214, 12, 61, 178, 231, 171, 58, 31, 62, 2, 15, 126, 170, 151, 191, 204, 189, 31, 242, 10, 139, 34, 48, 168, 40, 199, 67, 126, 100, 180, 164, 255, 196, 66, 97, 179, 172, 229, 84, 169, 47, 170, 23, 108, 94, 168, 45, 229, 120, 107, 138, 7, 3, 143, 37, 188, 1, 65, 187, 91, 45 }, new byte[] { 16, 93, 173, 135, 234, 229, 251, 170, 4, 17, 76, 145, 237, 65, 197, 228, 50, 5, 181, 17, 210, 231, 176, 245, 147, 133, 175, 164, 206, 202, 77, 206, 186, 87, 144, 116, 117, 233, 168, 232, 134, 3, 70, 155, 117, 116, 195, 175, 185, 61, 43, 194, 72, 123, 99, 87, 77, 177, 150, 82, 152, 200, 49, 92, 27, 129, 102, 104, 144, 185, 220, 213, 159, 125, 158, 118, 158, 139, 150, 96, 224, 181, 92, 221, 131, 30, 236, 207, 218, 223, 82, 204, 244, 173, 175, 86, 173, 180, 0, 202, 250, 121, 35, 138, 57, 180, 64, 53, 44, 30, 218, 203, 96, 56, 224, 6, 129, 117, 143, 244, 176, 248, 208, 220, 99, 206, 213, 119 } });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new byte[] { 251, 84, 184, 214, 12, 61, 178, 231, 171, 58, 31, 62, 2, 15, 126, 170, 151, 191, 204, 189, 31, 242, 10, 139, 34, 48, 168, 40, 199, 67, 126, 100, 180, 164, 255, 196, 66, 97, 179, 172, 229, 84, 169, 47, 170, 23, 108, 94, 168, 45, 229, 120, 107, 138, 7, 3, 143, 37, 188, 1, 65, 187, 91, 45 }, new byte[] { 16, 93, 173, 135, 234, 229, 251, 170, 4, 17, 76, 145, 237, 65, 197, 228, 50, 5, 181, 17, 210, 231, 176, 245, 147, 133, 175, 164, 206, 202, 77, 206, 186, 87, 144, 116, 117, 233, 168, 232, 134, 3, 70, 155, 117, 116, 195, 175, 185, 61, 43, 194, 72, 123, 99, 87, 77, 177, 150, 82, 152, 200, 49, 92, 27, 129, 102, 104, 144, 185, 220, 213, 159, 125, 158, 118, 158, 139, 150, 96, 224, 181, 92, 221, 131, 30, 236, 207, 218, 223, 82, 204, 244, 173, 175, 86, 173, 180, 0, 202, 250, 121, 35, 138, 57, 180, 64, 53, 44, 30, 218, 203, 96, 56, 224, 6, 129, 117, 143, 244, 176, 248, 208, 220, 99, 206, 213, 119 } });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), new byte[] { 251, 84, 184, 214, 12, 61, 178, 231, 171, 58, 31, 62, 2, 15, 126, 170, 151, 191, 204, 189, 31, 242, 10, 139, 34, 48, 168, 40, 199, 67, 126, 100, 180, 164, 255, 196, 66, 97, 179, 172, 229, 84, 169, 47, 170, 23, 108, 94, 168, 45, 229, 120, 107, 138, 7, 3, 143, 37, 188, 1, 65, 187, 91, 45 }, new byte[] { 16, 93, 173, 135, 234, 229, 251, 170, 4, 17, 76, 145, 237, 65, 197, 228, 50, 5, 181, 17, 210, 231, 176, 245, 147, 133, 175, 164, 206, 202, 77, 206, 186, 87, 144, 116, 117, 233, 168, 232, 134, 3, 70, 155, 117, 116, 195, 175, 185, 61, 43, 194, 72, 123, 99, 87, 77, 177, 150, 82, 152, 200, 49, 92, 27, 129, 102, 104, 144, 185, 220, 213, 159, 125, 158, 118, 158, 139, 150, 96, 224, 181, 92, 221, 131, 30, 236, 207, 218, 223, 82, 204, 244, 173, 175, 86, 173, 180, 0, 202, 250, 121, 35, 138, 57, 180, 64, 53, 44, 30, 218, 203, 96, 56, 224, 6, 129, 117, 143, 244, 176, 248, 208, 220, 99, 206, 213, 119 } });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "StudentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));
        }
    }
}
