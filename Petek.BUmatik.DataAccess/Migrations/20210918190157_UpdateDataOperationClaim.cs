using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Petek.BUmatik.DataAccess.Migrations
{
    public partial class UpdateDataOperationClaim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new byte[] { 94, 233, 163, 198, 116, 127, 205, 95, 218, 21, 156, 154, 121, 114, 2, 6, 63, 249, 118, 214, 19, 37, 191, 184, 176, 60, 164, 167, 38, 1, 168, 219, 170, 38, 60, 83, 202, 51, 187, 172, 248, 222, 44, 24, 114, 92, 243, 117, 1, 98, 112, 142, 199, 102, 90, 64, 185, 171, 93, 139, 236, 86, 158, 157 }, new byte[] { 84, 157, 49, 114, 105, 214, 214, 36, 69, 190, 244, 254, 200, 92, 29, 103, 20, 144, 37, 38, 13, 122, 202, 143, 2, 40, 214, 61, 120, 220, 91, 147, 189, 0, 198, 149, 95, 71, 164, 6, 226, 9, 100, 253, 16, 56, 51, 182, 240, 209, 249, 95, 71, 17, 77, 175, 113, 10, 239, 128, 93, 106, 126, 245, 12, 157, 7, 147, 178, 174, 31, 21, 239, 209, 41, 60, 247, 84, 63, 146, 154, 212, 161, 0, 130, 209, 28, 248, 217, 21, 58, 38, 123, 132, 146, 220, 217, 110, 208, 194, 133, 231, 153, 32, 10, 180, 205, 249, 228, 144, 243, 46, 42, 20, 219, 98, 239, 199, 158, 93, 23, 72, 142, 148, 196, 199, 68, 202 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new byte[] { 94, 233, 163, 198, 116, 127, 205, 95, 218, 21, 156, 154, 121, 114, 2, 6, 63, 249, 118, 214, 19, 37, 191, 184, 176, 60, 164, 167, 38, 1, 168, 219, 170, 38, 60, 83, 202, 51, 187, 172, 248, 222, 44, 24, 114, 92, 243, 117, 1, 98, 112, 142, 199, 102, 90, 64, 185, 171, 93, 139, 236, 86, 158, 157 }, new byte[] { 84, 157, 49, 114, 105, 214, 214, 36, 69, 190, 244, 254, 200, 92, 29, 103, 20, 144, 37, 38, 13, 122, 202, 143, 2, 40, 214, 61, 120, 220, 91, 147, 189, 0, 198, 149, 95, 71, 164, 6, 226, 9, 100, 253, 16, 56, 51, 182, 240, 209, 249, 95, 71, 17, 77, 175, 113, 10, 239, 128, 93, 106, 126, 245, 12, 157, 7, 147, 178, 174, 31, 21, 239, 209, 41, 60, 247, 84, 63, 146, 154, 212, 161, 0, 130, 209, 28, 248, 217, 21, 58, 38, 123, 132, 146, 220, 217, 110, 208, 194, 133, 231, 153, 32, 10, 180, 205, 249, 228, 144, 243, 46, 42, 20, 219, 98, 239, 199, 158, 93, 23, 72, 142, 148, 196, 199, 68, 202 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new byte[] { 94, 233, 163, 198, 116, 127, 205, 95, 218, 21, 156, 154, 121, 114, 2, 6, 63, 249, 118, 214, 19, 37, 191, 184, 176, 60, 164, 167, 38, 1, 168, 219, 170, 38, 60, 83, 202, 51, 187, 172, 248, 222, 44, 24, 114, 92, 243, 117, 1, 98, 112, 142, 199, 102, 90, 64, 185, 171, 93, 139, 236, 86, 158, 157 }, new byte[] { 84, 157, 49, 114, 105, 214, 214, 36, 69, 190, 244, 254, 200, 92, 29, 103, 20, 144, 37, 38, 13, 122, 202, 143, 2, 40, 214, 61, 120, 220, 91, 147, 189, 0, 198, 149, 95, 71, 164, 6, 226, 9, 100, 253, 16, 56, 51, 182, 240, 209, 249, 95, 71, 17, 77, 175, 113, 10, 239, 128, 93, 106, 126, 245, 12, 157, 7, 147, 178, 174, 31, 21, 239, 209, 41, 60, 247, 84, 63, 146, 154, 212, 161, 0, 130, 209, 28, 248, 217, 21, 58, 38, 123, 132, 146, 220, 217, 110, 208, 194, 133, 231, 153, 32, 10, 180, 205, 249, 228, 144, 243, 46, 42, 20, 219, 98, 239, 199, 158, 93, 23, 72, 142, 148, 196, 199, 68, 202 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new byte[] { 94, 233, 163, 198, 116, 127, 205, 95, 218, 21, 156, 154, 121, 114, 2, 6, 63, 249, 118, 214, 19, 37, 191, 184, 176, 60, 164, 167, 38, 1, 168, 219, 170, 38, 60, 83, 202, 51, 187, 172, 248, 222, 44, 24, 114, 92, 243, 117, 1, 98, 112, 142, 199, 102, 90, 64, 185, 171, 93, 139, 236, 86, 158, 157 }, new byte[] { 84, 157, 49, 114, 105, 214, 214, 36, 69, 190, 244, 254, 200, 92, 29, 103, 20, 144, 37, 38, 13, 122, 202, 143, 2, 40, 214, 61, 120, 220, 91, 147, 189, 0, 198, 149, 95, 71, 164, 6, 226, 9, 100, 253, 16, 56, 51, 182, 240, 209, 249, 95, 71, 17, 77, 175, 113, 10, 239, 128, 93, 106, 126, 245, 12, 157, 7, 147, 178, 174, 31, 21, 239, 209, 41, 60, 247, 84, 63, 146, 154, 212, 161, 0, 130, 209, 28, 248, 217, 21, 58, 38, 123, 132, 146, 220, 217, 110, 208, 194, 133, 231, 153, 32, 10, 180, 205, 249, 228, 144, 243, 46, 42, 20, 219, 98, 239, 199, 158, 93, 23, 72, 142, 148, 196, 199, 68, 202 } });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "MenuTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "MenuTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new byte[] { 94, 233, 163, 198, 116, 127, 205, 95, 218, 21, 156, 154, 121, 114, 2, 6, 63, 249, 118, 214, 19, 37, 191, 184, 176, 60, 164, 167, 38, 1, 168, 219, 170, 38, 60, 83, 202, 51, 187, 172, 248, 222, 44, 24, 114, 92, 243, 117, 1, 98, 112, 142, 199, 102, 90, 64, 185, 171, 93, 139, 236, 86, 158, 157 }, new byte[] { 84, 157, 49, 114, 105, 214, 214, 36, 69, 190, 244, 254, 200, 92, 29, 103, 20, 144, 37, 38, 13, 122, 202, 143, 2, 40, 214, 61, 120, 220, 91, 147, 189, 0, 198, 149, 95, 71, 164, 6, 226, 9, 100, 253, 16, 56, 51, 182, 240, 209, 249, 95, 71, 17, 77, 175, 113, 10, 239, 128, 93, 106, 126, 245, 12, 157, 7, 147, 178, 174, 31, 21, 239, 209, 41, 60, 247, 84, 63, 146, 154, 212, 161, 0, 130, 209, 28, 248, 217, 21, 58, 38, 123, 132, 146, 220, 217, 110, 208, 194, 133, 231, 153, 32, 10, 180, 205, 249, 228, 144, 243, 46, 42, 20, 219, 98, 239, 199, 158, 93, 23, 72, 142, 148, 196, 199, 68, 202 } });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new byte[] { 94, 233, 163, 198, 116, 127, 205, 95, 218, 21, 156, 154, 121, 114, 2, 6, 63, 249, 118, 214, 19, 37, 191, 184, 176, 60, 164, 167, 38, 1, 168, 219, 170, 38, 60, 83, 202, 51, 187, 172, 248, 222, 44, 24, 114, 92, 243, 117, 1, 98, 112, 142, 199, 102, 90, 64, 185, 171, 93, 139, 236, 86, 158, 157 }, new byte[] { 84, 157, 49, 114, 105, 214, 214, 36, 69, 190, 244, 254, 200, 92, 29, 103, 20, 144, 37, 38, 13, 122, 202, 143, 2, 40, 214, 61, 120, 220, 91, 147, 189, 0, 198, 149, 95, 71, 164, 6, 226, 9, 100, 253, 16, 56, 51, 182, 240, 209, 249, 95, 71, 17, 77, 175, 113, 10, 239, 128, 93, 106, 126, 245, 12, 157, 7, 147, 178, 174, 31, 21, 239, 209, 41, 60, 247, 84, 63, 146, 154, 212, 161, 0, 130, 209, 28, 248, 217, 21, 58, 38, 123, 132, 146, 220, 217, 110, 208, 194, 133, 231, 153, 32, 10, 180, 205, 249, 228, 144, 243, 46, 42, 20, 219, 98, 239, 199, 158, 93, 23, 72, 142, 148, 196, 199, 68, 202 } });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new byte[] { 94, 233, 163, 198, 116, 127, 205, 95, 218, 21, 156, 154, 121, 114, 2, 6, 63, 249, 118, 214, 19, 37, 191, 184, 176, 60, 164, 167, 38, 1, 168, 219, 170, 38, 60, 83, 202, 51, 187, 172, 248, 222, 44, 24, 114, 92, 243, 117, 1, 98, 112, 142, 199, 102, 90, 64, 185, 171, 93, 139, 236, 86, 158, 157 }, new byte[] { 84, 157, 49, 114, 105, 214, 214, 36, 69, 190, 244, 254, 200, 92, 29, 103, 20, 144, 37, 38, 13, 122, 202, 143, 2, 40, 214, 61, 120, 220, 91, 147, 189, 0, 198, 149, 95, 71, 164, 6, 226, 9, 100, 253, 16, 56, 51, 182, 240, 209, 249, 95, 71, 17, 77, 175, 113, 10, 239, 128, 93, 106, 126, 245, 12, 157, 7, 147, 178, 174, 31, 21, 239, 209, 41, 60, 247, 84, 63, 146, 154, 212, 161, 0, 130, 209, 28, 248, 217, 21, 58, 38, 123, 132, 146, 220, 217, 110, 208, 194, 133, 231, 153, 32, 10, 180, 205, 249, 228, 144, 243, 46, 42, 20, 219, 98, 239, 199, 158, 93, 23, 72, 142, 148, 196, 199, 68, 202 } });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new byte[] { 94, 233, 163, 198, 116, 127, 205, 95, 218, 21, 156, 154, 121, 114, 2, 6, 63, 249, 118, 214, 19, 37, 191, 184, 176, 60, 164, 167, 38, 1, 168, 219, 170, 38, 60, 83, 202, 51, 187, 172, 248, 222, 44, 24, 114, 92, 243, 117, 1, 98, 112, 142, 199, 102, 90, 64, 185, 171, 93, 139, 236, 86, 158, 157 }, new byte[] { 84, 157, 49, 114, 105, 214, 214, 36, 69, 190, 244, 254, 200, 92, 29, 103, 20, 144, 37, 38, 13, 122, 202, 143, 2, 40, 214, 61, 120, 220, 91, 147, 189, 0, 198, 149, 95, 71, 164, 6, 226, 9, 100, 253, 16, 56, 51, 182, 240, 209, 249, 95, 71, 17, 77, 175, 113, 10, 239, 128, 93, 106, 126, 245, 12, 157, 7, 147, 178, 174, 31, 21, 239, 209, 41, 60, 247, 84, 63, 146, 154, 212, 161, 0, 130, 209, 28, 248, 217, 21, 58, 38, 123, 132, 146, 220, 217, 110, 208, 194, 133, 231, 153, 32, 10, 180, 205, 249, 228, 144, 243, 46, 42, 20, 219, 98, 239, 199, 158, 93, 23, 72, 142, 148, 196, 199, 68, 202 } });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), new byte[] { 94, 233, 163, 198, 116, 127, 205, 95, 218, 21, 156, 154, 121, 114, 2, 6, 63, 249, 118, 214, 19, 37, 191, 184, 176, 60, 164, 167, 38, 1, 168, 219, 170, 38, 60, 83, 202, 51, 187, 172, 248, 222, 44, 24, 114, 92, 243, 117, 1, 98, 112, 142, 199, 102, 90, 64, 185, 171, 93, 139, 236, 86, 158, 157 }, new byte[] { 84, 157, 49, 114, 105, 214, 214, 36, 69, 190, 244, 254, 200, 92, 29, 103, 20, 144, 37, 38, 13, 122, 202, 143, 2, 40, 214, 61, 120, 220, 91, 147, 189, 0, 198, 149, 95, 71, 164, 6, 226, 9, 100, 253, 16, 56, 51, 182, 240, 209, 249, 95, 71, 17, 77, 175, 113, 10, 239, 128, 93, 106, 126, 245, 12, 157, 7, 147, 178, 174, 31, 21, 239, 209, 41, 60, 247, 84, 63, 146, 154, 212, 161, 0, 130, 209, 28, 248, 217, 21, 58, 38, 123, 132, 146, 220, 217, 110, 208, 194, 133, 231, 153, 32, 10, 180, 205, 249, 228, 144, 243, 46, 42, 20, 219, 98, 239, 199, 158, 93, 23, 72, 142, 148, 196, 199, 68, 202 } });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "StudentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "AdminUserId", "CreatedDate", "CreatedUserId", "IsDeleted", "ModifiedDate", "ModifiedUserId", "OperationClaimId", "ParentId" },
                values: new object[,]
                {
                    { 9, null, new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), 1, false, null, null, 2, 5 },
                    { 8, null, new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), 1, false, null, null, 2, 4 },
                    { 7, null, new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), 1, false, null, null, 2, 4 },
                    { 6, null, new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), 1, false, null, null, 2, 3 },
                    { 5, null, new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), 1, false, null, null, 2, 3 },
                    { 4, null, new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), 1, false, null, null, 2, 2 },
                    { 10, null, new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), 1, false, null, null, 2, 5 },
                    { 3, null, new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), 1, false, null, null, 2, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new byte[] { 9, 251, 147, 105, 189, 102, 142, 11, 53, 175, 96, 55, 213, 155, 124, 126, 140, 233, 45, 232, 191, 114, 115, 105, 210, 209, 247, 227, 203, 7, 242, 157, 179, 31, 234, 73, 7, 67, 196, 184, 14, 15, 173, 156, 62, 1, 105, 216, 30, 199, 175, 121, 93, 219, 236, 205, 45, 109, 172, 159, 255, 160, 13, 41 }, new byte[] { 242, 223, 85, 109, 99, 111, 76, 227, 167, 229, 44, 70, 207, 75, 18, 73, 214, 83, 75, 60, 228, 73, 236, 72, 248, 248, 169, 253, 206, 58, 49, 121, 65, 186, 8, 179, 122, 112, 197, 57, 210, 191, 195, 57, 90, 118, 177, 81, 246, 241, 224, 32, 174, 61, 253, 219, 143, 205, 17, 51, 77, 244, 209, 131, 134, 127, 138, 15, 202, 13, 88, 147, 206, 224, 37, 70, 51, 78, 188, 174, 241, 18, 78, 87, 205, 65, 126, 131, 5, 15, 24, 119, 121, 159, 32, 223, 186, 143, 1, 34, 121, 112, 122, 194, 135, 254, 48, 18, 136, 137, 224, 71, 128, 69, 64, 255, 132, 247, 60, 90, 116, 143, 67, 164, 89, 148, 32, 42 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new byte[] { 9, 251, 147, 105, 189, 102, 142, 11, 53, 175, 96, 55, 213, 155, 124, 126, 140, 233, 45, 232, 191, 114, 115, 105, 210, 209, 247, 227, 203, 7, 242, 157, 179, 31, 234, 73, 7, 67, 196, 184, 14, 15, 173, 156, 62, 1, 105, 216, 30, 199, 175, 121, 93, 219, 236, 205, 45, 109, 172, 159, 255, 160, 13, 41 }, new byte[] { 242, 223, 85, 109, 99, 111, 76, 227, 167, 229, 44, 70, 207, 75, 18, 73, 214, 83, 75, 60, 228, 73, 236, 72, 248, 248, 169, 253, 206, 58, 49, 121, 65, 186, 8, 179, 122, 112, 197, 57, 210, 191, 195, 57, 90, 118, 177, 81, 246, 241, 224, 32, 174, 61, 253, 219, 143, 205, 17, 51, 77, 244, 209, 131, 134, 127, 138, 15, 202, 13, 88, 147, 206, 224, 37, 70, 51, 78, 188, 174, 241, 18, 78, 87, 205, 65, 126, 131, 5, 15, 24, 119, 121, 159, 32, 223, 186, 143, 1, 34, 121, 112, 122, 194, 135, 254, 48, 18, 136, 137, 224, 71, 128, 69, 64, 255, 132, 247, 60, 90, 116, 143, 67, 164, 89, 148, 32, 42 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new byte[] { 9, 251, 147, 105, 189, 102, 142, 11, 53, 175, 96, 55, 213, 155, 124, 126, 140, 233, 45, 232, 191, 114, 115, 105, 210, 209, 247, 227, 203, 7, 242, 157, 179, 31, 234, 73, 7, 67, 196, 184, 14, 15, 173, 156, 62, 1, 105, 216, 30, 199, 175, 121, 93, 219, 236, 205, 45, 109, 172, 159, 255, 160, 13, 41 }, new byte[] { 242, 223, 85, 109, 99, 111, 76, 227, 167, 229, 44, 70, 207, 75, 18, 73, 214, 83, 75, 60, 228, 73, 236, 72, 248, 248, 169, 253, 206, 58, 49, 121, 65, 186, 8, 179, 122, 112, 197, 57, 210, 191, 195, 57, 90, 118, 177, 81, 246, 241, 224, 32, 174, 61, 253, 219, 143, 205, 17, 51, 77, 244, 209, 131, 134, 127, 138, 15, 202, 13, 88, 147, 206, 224, 37, 70, 51, 78, 188, 174, 241, 18, 78, 87, 205, 65, 126, 131, 5, 15, 24, 119, 121, 159, 32, 223, 186, 143, 1, 34, 121, 112, 122, 194, 135, 254, 48, 18, 136, 137, 224, 71, 128, 69, 64, 255, 132, 247, 60, 90, 116, 143, 67, 164, 89, 148, 32, 42 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new byte[] { 9, 251, 147, 105, 189, 102, 142, 11, 53, 175, 96, 55, 213, 155, 124, 126, 140, 233, 45, 232, 191, 114, 115, 105, 210, 209, 247, 227, 203, 7, 242, 157, 179, 31, 234, 73, 7, 67, 196, 184, 14, 15, 173, 156, 62, 1, 105, 216, 30, 199, 175, 121, 93, 219, 236, 205, 45, 109, 172, 159, 255, 160, 13, 41 }, new byte[] { 242, 223, 85, 109, 99, 111, 76, 227, 167, 229, 44, 70, 207, 75, 18, 73, 214, 83, 75, 60, 228, 73, 236, 72, 248, 248, 169, 253, 206, 58, 49, 121, 65, 186, 8, 179, 122, 112, 197, 57, 210, 191, 195, 57, 90, 118, 177, 81, 246, 241, 224, 32, 174, 61, 253, 219, 143, 205, 17, 51, 77, 244, 209, 131, 134, 127, 138, 15, 202, 13, 88, 147, 206, 224, 37, 70, 51, 78, 188, 174, 241, 18, 78, 87, 205, 65, 126, 131, 5, 15, 24, 119, 121, 159, 32, 223, 186, 143, 1, 34, 121, 112, 122, 194, 135, 254, 48, 18, 136, 137, 224, 71, 128, 69, 64, 255, 132, 247, 60, 90, 116, 143, 67, 164, 89, 148, 32, 42 } });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "MenuTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "MenuTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new byte[] { 9, 251, 147, 105, 189, 102, 142, 11, 53, 175, 96, 55, 213, 155, 124, 126, 140, 233, 45, 232, 191, 114, 115, 105, 210, 209, 247, 227, 203, 7, 242, 157, 179, 31, 234, 73, 7, 67, 196, 184, 14, 15, 173, 156, 62, 1, 105, 216, 30, 199, 175, 121, 93, 219, 236, 205, 45, 109, 172, 159, 255, 160, 13, 41 }, new byte[] { 242, 223, 85, 109, 99, 111, 76, 227, 167, 229, 44, 70, 207, 75, 18, 73, 214, 83, 75, 60, 228, 73, 236, 72, 248, 248, 169, 253, 206, 58, 49, 121, 65, 186, 8, 179, 122, 112, 197, 57, 210, 191, 195, 57, 90, 118, 177, 81, 246, 241, 224, 32, 174, 61, 253, 219, 143, 205, 17, 51, 77, 244, 209, 131, 134, 127, 138, 15, 202, 13, 88, 147, 206, 224, 37, 70, 51, 78, 188, 174, 241, 18, 78, 87, 205, 65, 126, 131, 5, 15, 24, 119, 121, 159, 32, 223, 186, 143, 1, 34, 121, 112, 122, 194, 135, 254, 48, 18, 136, 137, 224, 71, 128, 69, 64, 255, 132, 247, 60, 90, 116, 143, 67, 164, 89, 148, 32, 42 } });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new byte[] { 9, 251, 147, 105, 189, 102, 142, 11, 53, 175, 96, 55, 213, 155, 124, 126, 140, 233, 45, 232, 191, 114, 115, 105, 210, 209, 247, 227, 203, 7, 242, 157, 179, 31, 234, 73, 7, 67, 196, 184, 14, 15, 173, 156, 62, 1, 105, 216, 30, 199, 175, 121, 93, 219, 236, 205, 45, 109, 172, 159, 255, 160, 13, 41 }, new byte[] { 242, 223, 85, 109, 99, 111, 76, 227, 167, 229, 44, 70, 207, 75, 18, 73, 214, 83, 75, 60, 228, 73, 236, 72, 248, 248, 169, 253, 206, 58, 49, 121, 65, 186, 8, 179, 122, 112, 197, 57, 210, 191, 195, 57, 90, 118, 177, 81, 246, 241, 224, 32, 174, 61, 253, 219, 143, 205, 17, 51, 77, 244, 209, 131, 134, 127, 138, 15, 202, 13, 88, 147, 206, 224, 37, 70, 51, 78, 188, 174, 241, 18, 78, 87, 205, 65, 126, 131, 5, 15, 24, 119, 121, 159, 32, 223, 186, 143, 1, 34, 121, 112, 122, 194, 135, 254, 48, 18, 136, 137, 224, 71, 128, 69, 64, 255, 132, 247, 60, 90, 116, 143, 67, 164, 89, 148, 32, 42 } });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new byte[] { 9, 251, 147, 105, 189, 102, 142, 11, 53, 175, 96, 55, 213, 155, 124, 126, 140, 233, 45, 232, 191, 114, 115, 105, 210, 209, 247, 227, 203, 7, 242, 157, 179, 31, 234, 73, 7, 67, 196, 184, 14, 15, 173, 156, 62, 1, 105, 216, 30, 199, 175, 121, 93, 219, 236, 205, 45, 109, 172, 159, 255, 160, 13, 41 }, new byte[] { 242, 223, 85, 109, 99, 111, 76, 227, 167, 229, 44, 70, 207, 75, 18, 73, 214, 83, 75, 60, 228, 73, 236, 72, 248, 248, 169, 253, 206, 58, 49, 121, 65, 186, 8, 179, 122, 112, 197, 57, 210, 191, 195, 57, 90, 118, 177, 81, 246, 241, 224, 32, 174, 61, 253, 219, 143, 205, 17, 51, 77, 244, 209, 131, 134, 127, 138, 15, 202, 13, 88, 147, 206, 224, 37, 70, 51, 78, 188, 174, 241, 18, 78, 87, 205, 65, 126, 131, 5, 15, 24, 119, 121, 159, 32, 223, 186, 143, 1, 34, 121, 112, 122, 194, 135, 254, 48, 18, 136, 137, 224, 71, 128, 69, 64, 255, 132, 247, 60, 90, 116, 143, 67, 164, 89, 148, 32, 42 } });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new byte[] { 9, 251, 147, 105, 189, 102, 142, 11, 53, 175, 96, 55, 213, 155, 124, 126, 140, 233, 45, 232, 191, 114, 115, 105, 210, 209, 247, 227, 203, 7, 242, 157, 179, 31, 234, 73, 7, 67, 196, 184, 14, 15, 173, 156, 62, 1, 105, 216, 30, 199, 175, 121, 93, 219, 236, 205, 45, 109, 172, 159, 255, 160, 13, 41 }, new byte[] { 242, 223, 85, 109, 99, 111, 76, 227, 167, 229, 44, 70, 207, 75, 18, 73, 214, 83, 75, 60, 228, 73, 236, 72, 248, 248, 169, 253, 206, 58, 49, 121, 65, 186, 8, 179, 122, 112, 197, 57, 210, 191, 195, 57, 90, 118, 177, 81, 246, 241, 224, 32, 174, 61, 253, 219, 143, 205, 17, 51, 77, 244, 209, 131, 134, 127, 138, 15, 202, 13, 88, 147, 206, 224, 37, 70, 51, 78, 188, 174, 241, 18, 78, 87, 205, 65, 126, 131, 5, 15, 24, 119, 121, 159, 32, 223, 186, 143, 1, 34, 121, 112, 122, 194, 135, 254, 48, 18, 136, 137, 224, 71, 128, 69, 64, 255, 132, 247, 60, 90, 116, 143, 67, 164, 89, 148, 32, 42 } });

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new byte[] { 9, 251, 147, 105, 189, 102, 142, 11, 53, 175, 96, 55, 213, 155, 124, 126, 140, 233, 45, 232, 191, 114, 115, 105, 210, 209, 247, 227, 203, 7, 242, 157, 179, 31, 234, 73, 7, 67, 196, 184, 14, 15, 173, 156, 62, 1, 105, 216, 30, 199, 175, 121, 93, 219, 236, 205, 45, 109, 172, 159, 255, 160, 13, 41 }, new byte[] { 242, 223, 85, 109, 99, 111, 76, 227, 167, 229, 44, 70, 207, 75, 18, 73, 214, 83, 75, 60, 228, 73, 236, 72, 248, 248, 169, 253, 206, 58, 49, 121, 65, 186, 8, 179, 122, 112, 197, 57, 210, 191, 195, 57, 90, 118, 177, 81, 246, 241, 224, 32, 174, 61, 253, 219, 143, 205, 17, 51, 77, 244, 209, 131, 134, 127, 138, 15, 202, 13, 88, 147, 206, 224, 37, 70, 51, 78, 188, 174, 241, 18, 78, 87, 205, 65, 126, 131, 5, 15, 24, 119, 121, 159, 32, 223, 186, 143, 1, 34, 121, 112, 122, 194, 135, 254, 48, 18, 136, 137, 224, 71, 128, 69, 64, 255, 132, 247, 60, 90, 116, 143, 67, 164, 89, 148, 32, 42 } });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "StudentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142));
        }
    }
}
