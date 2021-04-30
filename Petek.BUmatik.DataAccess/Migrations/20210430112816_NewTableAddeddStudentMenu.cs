using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Petek.BUmatik.DataAccess.Migrations
{
    public partial class NewTableAddeddStudentMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 133, 139, 164, 174, 37, 28, 248, 155, 3, 164, 148, 36, 84, 188, 9, 16, 49, 171, 94, 8, 216, 243, 108, 227, 141, 158, 104, 62, 152, 137, 133, 219, 167, 132, 14, 113, 48, 44, 25, 126, 168, 27, 231, 238, 75, 132, 189, 0, 181, 11, 186, 158, 10, 66, 64, 247, 36, 121, 108, 178, 39, 71, 111, 100 }, new byte[] { 112, 193, 178, 161, 252, 160, 243, 116, 232, 25, 35, 181, 97, 17, 84, 170, 30, 49, 73, 231, 222, 70, 41, 232, 249, 128, 115, 38, 243, 32, 130, 101, 185, 52, 235, 66, 71, 174, 132, 182, 181, 15, 245, 242, 161, 160, 233, 167, 72, 81, 216, 168, 244, 191, 101, 121, 100, 244, 151, 55, 106, 249, 184, 56, 27, 88, 137, 253, 15, 146, 94, 17, 54, 170, 217, 66, 170, 250, 128, 71, 61, 127, 212, 223, 185, 172, 205, 242, 7, 92, 114, 236, 59, 248, 125, 177, 7, 11, 77, 122, 0, 176, 10, 181, 188, 211, 181, 165, 137, 195, 2, 210, 28, 49, 241, 109, 168, 231, 81, 70, 15, 110, 5, 34, 42, 10, 196, 137 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 133, 139, 164, 174, 37, 28, 248, 155, 3, 164, 148, 36, 84, 188, 9, 16, 49, 171, 94, 8, 216, 243, 108, 227, 141, 158, 104, 62, 152, 137, 133, 219, 167, 132, 14, 113, 48, 44, 25, 126, 168, 27, 231, 238, 75, 132, 189, 0, 181, 11, 186, 158, 10, 66, 64, 247, 36, 121, 108, 178, 39, 71, 111, 100 }, new byte[] { 112, 193, 178, 161, 252, 160, 243, 116, 232, 25, 35, 181, 97, 17, 84, 170, 30, 49, 73, 231, 222, 70, 41, 232, 249, 128, 115, 38, 243, 32, 130, 101, 185, 52, 235, 66, 71, 174, 132, 182, 181, 15, 245, 242, 161, 160, 233, 167, 72, 81, 216, 168, 244, 191, 101, 121, 100, 244, 151, 55, 106, 249, 184, 56, 27, 88, 137, 253, 15, 146, 94, 17, 54, 170, 217, 66, 170, 250, 128, 71, 61, 127, 212, 223, 185, 172, 205, 242, 7, 92, 114, 236, 59, 248, 125, 177, 7, 11, 77, 122, 0, 176, 10, 181, 188, 211, 181, 165, 137, 195, 2, 210, 28, 49, 241, 109, 168, 231, 81, 70, 15, 110, 5, 34, 42, 10, 196, 137 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 133, 139, 164, 174, 37, 28, 248, 155, 3, 164, 148, 36, 84, 188, 9, 16, 49, 171, 94, 8, 216, 243, 108, 227, 141, 158, 104, 62, 152, 137, 133, 219, 167, 132, 14, 113, 48, 44, 25, 126, 168, 27, 231, 238, 75, 132, 189, 0, 181, 11, 186, 158, 10, 66, 64, 247, 36, 121, 108, 178, 39, 71, 111, 100 }, new byte[] { 112, 193, 178, 161, 252, 160, 243, 116, 232, 25, 35, 181, 97, 17, 84, 170, 30, 49, 73, 231, 222, 70, 41, 232, 249, 128, 115, 38, 243, 32, 130, 101, 185, 52, 235, 66, 71, 174, 132, 182, 181, 15, 245, 242, 161, 160, 233, 167, 72, 81, 216, 168, 244, 191, 101, 121, 100, 244, 151, 55, 106, 249, 184, 56, 27, 88, 137, 253, 15, 146, 94, 17, 54, 170, 217, 66, 170, 250, 128, 71, 61, 127, 212, 223, 185, 172, 205, 242, 7, 92, 114, 236, 59, 248, 125, 177, 7, 11, 77, 122, 0, 176, 10, 181, 188, 211, 181, 165, 137, 195, 2, 210, 28, 49, 241, 109, 168, 231, 81, 70, 15, 110, 5, 34, 42, 10, 196, 137 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 133, 139, 164, 174, 37, 28, 248, 155, 3, 164, 148, 36, 84, 188, 9, 16, 49, 171, 94, 8, 216, 243, 108, 227, 141, 158, 104, 62, 152, 137, 133, 219, 167, 132, 14, 113, 48, 44, 25, 126, 168, 27, 231, 238, 75, 132, 189, 0, 181, 11, 186, 158, 10, 66, 64, 247, 36, 121, 108, 178, 39, 71, 111, 100 }, new byte[] { 112, 193, 178, 161, 252, 160, 243, 116, 232, 25, 35, 181, 97, 17, 84, 170, 30, 49, 73, 231, 222, 70, 41, 232, 249, 128, 115, 38, 243, 32, 130, 101, 185, 52, 235, 66, 71, 174, 132, 182, 181, 15, 245, 242, 161, 160, 233, 167, 72, 81, 216, 168, 244, 191, 101, 121, 100, 244, 151, 55, 106, 249, 184, 56, 27, 88, 137, 253, 15, 146, 94, 17, 54, 170, 217, 66, 170, 250, 128, 71, 61, 127, 212, 223, 185, 172, 205, 242, 7, 92, 114, 236, 59, 248, 125, 177, 7, 11, 77, 122, 0, 176, 10, 181, 188, 211, 181, 165, 137, 195, 2, 210, 28, 49, 241, 109, 168, 231, 81, 70, 15, 110, 5, 34, 42, 10, 196, 137 } });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 14, 24, 42, 594, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 133, 139, 164, 174, 37, 28, 248, 155, 3, 164, 148, 36, 84, 188, 9, 16, 49, 171, 94, 8, 216, 243, 108, 227, 141, 158, 104, 62, 152, 137, 133, 219, 167, 132, 14, 113, 48, 44, 25, 126, 168, 27, 231, 238, 75, 132, 189, 0, 181, 11, 186, 158, 10, 66, 64, 247, 36, 121, 108, 178, 39, 71, 111, 100 }, new byte[] { 112, 193, 178, 161, 252, 160, 243, 116, 232, 25, 35, 181, 97, 17, 84, 170, 30, 49, 73, 231, 222, 70, 41, 232, 249, 128, 115, 38, 243, 32, 130, 101, 185, 52, 235, 66, 71, 174, 132, 182, 181, 15, 245, 242, 161, 160, 233, 167, 72, 81, 216, 168, 244, 191, 101, 121, 100, 244, 151, 55, 106, 249, 184, 56, 27, 88, 137, 253, 15, 146, 94, 17, 54, 170, 217, 66, 170, 250, 128, 71, 61, 127, 212, 223, 185, 172, 205, 242, 7, 92, 114, 236, 59, 248, 125, 177, 7, 11, 77, 122, 0, 176, 10, 181, 188, 211, 181, 165, 137, 195, 2, 210, 28, 49, 241, 109, 168, 231, 81, 70, 15, 110, 5, 34, 42, 10, 196, 137 } });
        }
    }
}
