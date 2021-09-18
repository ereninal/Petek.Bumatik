using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Petek.BUmatik.DataAccess.Migrations
{
    public partial class UpdateColumnParent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "Parents",
                type: "text",
                nullable: true);

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
                columns: new[] { "Avatar", "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { "avatar-s-1.jpg", new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), new byte[] { 9, 251, 147, 105, 189, 102, 142, 11, 53, 175, 96, 55, 213, 155, 124, 126, 140, 233, 45, 232, 191, 114, 115, 105, 210, 209, 247, 227, 203, 7, 242, 157, 179, 31, 234, 73, 7, 67, 196, 184, 14, 15, 173, 156, 62, 1, 105, 216, 30, 199, 175, 121, 93, 219, 236, 205, 45, 109, 172, 159, 255, 160, 13, 41 }, new byte[] { 242, 223, 85, 109, 99, 111, 76, 227, 167, 229, 44, 70, 207, 75, 18, 73, 214, 83, 75, 60, 228, 73, 236, 72, 248, 248, 169, 253, 206, 58, 49, 121, 65, 186, 8, 179, 122, 112, 197, 57, 210, 191, 195, 57, 90, 118, 177, 81, 246, 241, 224, 32, 174, 61, 253, 219, 143, 205, 17, 51, 77, 244, 209, 131, 134, 127, 138, 15, 202, 13, 88, 147, 206, 224, 37, 70, 51, 78, 188, 174, 241, 18, 78, 87, 205, 65, 126, 131, 5, 15, 24, 119, 121, 159, 32, 223, 186, 143, 1, 34, 121, 112, 122, 194, 135, 254, 48, 18, 136, 137, 224, 71, 128, 69, 64, 255, 132, 247, 60, 90, 116, 143, 67, 164, 89, 148, 32, 42 } });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "AdminUserId", "Avatar", "CreatedDate", "CreatedUserId", "Email", "FullName", "IsDeleted", "ModifiedDate", "ModifiedUserId", "PasswordHash", "PasswordSalt" },
                values: new object[,]
                {
                    { 2, null, "avatar-s-2.jpg", new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), 1, "pelinsu.baltaci@petek.com", "Pelinsu Baltacı", false, null, null, new byte[] { 9, 251, 147, 105, 189, 102, 142, 11, 53, 175, 96, 55, 213, 155, 124, 126, 140, 233, 45, 232, 191, 114, 115, 105, 210, 209, 247, 227, 203, 7, 242, 157, 179, 31, 234, 73, 7, 67, 196, 184, 14, 15, 173, 156, 62, 1, 105, 216, 30, 199, 175, 121, 93, 219, 236, 205, 45, 109, 172, 159, 255, 160, 13, 41 }, new byte[] { 242, 223, 85, 109, 99, 111, 76, 227, 167, 229, 44, 70, 207, 75, 18, 73, 214, 83, 75, 60, 228, 73, 236, 72, 248, 248, 169, 253, 206, 58, 49, 121, 65, 186, 8, 179, 122, 112, 197, 57, 210, 191, 195, 57, 90, 118, 177, 81, 246, 241, 224, 32, 174, 61, 253, 219, 143, 205, 17, 51, 77, 244, 209, 131, 134, 127, 138, 15, 202, 13, 88, 147, 206, 224, 37, 70, 51, 78, 188, 174, 241, 18, 78, 87, 205, 65, 126, 131, 5, 15, 24, 119, 121, 159, 32, 223, 186, 143, 1, 34, 121, 112, 122, 194, 135, 254, 48, 18, 136, 137, 224, 71, 128, 69, 64, 255, 132, 247, 60, 90, 116, 143, 67, 164, 89, 148, 32, 42 } },
                    { 5, null, "avatar-s-4.jpg", new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), 1, "samet.dikmen@petek.com", "Samet Dikmen", false, null, null, new byte[] { 9, 251, 147, 105, 189, 102, 142, 11, 53, 175, 96, 55, 213, 155, 124, 126, 140, 233, 45, 232, 191, 114, 115, 105, 210, 209, 247, 227, 203, 7, 242, 157, 179, 31, 234, 73, 7, 67, 196, 184, 14, 15, 173, 156, 62, 1, 105, 216, 30, 199, 175, 121, 93, 219, 236, 205, 45, 109, 172, 159, 255, 160, 13, 41 }, new byte[] { 242, 223, 85, 109, 99, 111, 76, 227, 167, 229, 44, 70, 207, 75, 18, 73, 214, 83, 75, 60, 228, 73, 236, 72, 248, 248, 169, 253, 206, 58, 49, 121, 65, 186, 8, 179, 122, 112, 197, 57, 210, 191, 195, 57, 90, 118, 177, 81, 246, 241, 224, 32, 174, 61, 253, 219, 143, 205, 17, 51, 77, 244, 209, 131, 134, 127, 138, 15, 202, 13, 88, 147, 206, 224, 37, 70, 51, 78, 188, 174, 241, 18, 78, 87, 205, 65, 126, 131, 5, 15, 24, 119, 121, 159, 32, 223, 186, 143, 1, 34, 121, 112, 122, 194, 135, 254, 48, 18, 136, 137, 224, 71, 128, 69, 64, 255, 132, 247, 60, 90, 116, 143, 67, 164, 89, 148, 32, 42 } },
                    { 4, null, "avatar-s-9.jpg", new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), 1, "kemal.sarikaya@petek.com", "Mehmet Kemal Sarıkaya", false, null, null, new byte[] { 9, 251, 147, 105, 189, 102, 142, 11, 53, 175, 96, 55, 213, 155, 124, 126, 140, 233, 45, 232, 191, 114, 115, 105, 210, 209, 247, 227, 203, 7, 242, 157, 179, 31, 234, 73, 7, 67, 196, 184, 14, 15, 173, 156, 62, 1, 105, 216, 30, 199, 175, 121, 93, 219, 236, 205, 45, 109, 172, 159, 255, 160, 13, 41 }, new byte[] { 242, 223, 85, 109, 99, 111, 76, 227, 167, 229, 44, 70, 207, 75, 18, 73, 214, 83, 75, 60, 228, 73, 236, 72, 248, 248, 169, 253, 206, 58, 49, 121, 65, 186, 8, 179, 122, 112, 197, 57, 210, 191, 195, 57, 90, 118, 177, 81, 246, 241, 224, 32, 174, 61, 253, 219, 143, 205, 17, 51, 77, 244, 209, 131, 134, 127, 138, 15, 202, 13, 88, 147, 206, 224, 37, 70, 51, 78, 188, 174, 241, 18, 78, 87, 205, 65, 126, 131, 5, 15, 24, 119, 121, 159, 32, 223, 186, 143, 1, 34, 121, 112, 122, 194, 135, 254, 48, 18, 136, 137, 224, 71, 128, 69, 64, 255, 132, 247, 60, 90, 116, 143, 67, 164, 89, 148, 32, 42 } },
                    { 3, null, "avatar-s-1.jpg", new DateTime(2021, 9, 18, 21, 54, 27, 884, DateTimeKind.Local).AddTicks(6142), 1, "eren.inal@petek.com", "Eren İnal", false, null, null, new byte[] { 9, 251, 147, 105, 189, 102, 142, 11, 53, 175, 96, 55, 213, 155, 124, 126, 140, 233, 45, 232, 191, 114, 115, 105, 210, 209, 247, 227, 203, 7, 242, 157, 179, 31, 234, 73, 7, 67, 196, 184, 14, 15, 173, 156, 62, 1, 105, 216, 30, 199, 175, 121, 93, 219, 236, 205, 45, 109, 172, 159, 255, 160, 13, 41 }, new byte[] { 242, 223, 85, 109, 99, 111, 76, 227, 167, 229, 44, 70, 207, 75, 18, 73, 214, 83, 75, 60, 228, 73, 236, 72, 248, 248, 169, 253, 206, 58, 49, 121, 65, 186, 8, 179, 122, 112, 197, 57, 210, 191, 195, 57, 90, 118, 177, 81, 246, 241, 224, 32, 174, 61, 253, 219, 143, 205, 17, 51, 77, 244, 209, 131, 134, 127, 138, 15, 202, 13, 88, 147, 206, 224, 37, 70, 51, 78, 188, 174, 241, 18, 78, 87, 205, 65, 126, 131, 5, 15, 24, 119, 121, 159, 32, 223, 186, 143, 1, 34, 121, 112, 122, 194, 135, 254, 48, 18, 136, 137, 224, 71, 128, 69, 64, 255, 132, 247, 60, 90, 116, 143, 67, 164, 89, 148, 32, 42 } }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "Parents");

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new byte[] { 92, 40, 39, 169, 19, 183, 42, 201, 41, 151, 203, 221, 34, 254, 123, 200, 182, 5, 108, 217, 60, 40, 248, 52, 162, 30, 178, 228, 202, 182, 165, 117, 193, 234, 45, 178, 126, 15, 78, 84, 64, 230, 50, 123, 173, 122, 198, 91, 251, 36, 170, 228, 93, 1, 148, 165, 132, 74, 234, 227, 158, 72, 79, 162 }, new byte[] { 194, 36, 130, 175, 23, 161, 32, 212, 221, 160, 137, 104, 167, 245, 71, 187, 73, 5, 50, 116, 18, 55, 1, 20, 119, 64, 127, 64, 191, 182, 249, 6, 210, 177, 14, 125, 13, 71, 144, 157, 42, 51, 199, 71, 147, 157, 207, 224, 76, 110, 235, 128, 213, 195, 171, 228, 229, 209, 18, 246, 190, 222, 235, 174, 209, 100, 202, 162, 24, 135, 190, 221, 210, 137, 129, 10, 15, 150, 178, 113, 48, 153, 81, 110, 76, 91, 230, 208, 195, 97, 218, 188, 212, 35, 237, 7, 110, 103, 205, 202, 73, 167, 105, 168, 172, 83, 42, 109, 65, 182, 210, 148, 247, 41, 68, 140, 140, 105, 74, 227, 243, 131, 185, 182, 157, 158, 209, 62 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new byte[] { 92, 40, 39, 169, 19, 183, 42, 201, 41, 151, 203, 221, 34, 254, 123, 200, 182, 5, 108, 217, 60, 40, 248, 52, 162, 30, 178, 228, 202, 182, 165, 117, 193, 234, 45, 178, 126, 15, 78, 84, 64, 230, 50, 123, 173, 122, 198, 91, 251, 36, 170, 228, 93, 1, 148, 165, 132, 74, 234, 227, 158, 72, 79, 162 }, new byte[] { 194, 36, 130, 175, 23, 161, 32, 212, 221, 160, 137, 104, 167, 245, 71, 187, 73, 5, 50, 116, 18, 55, 1, 20, 119, 64, 127, 64, 191, 182, 249, 6, 210, 177, 14, 125, 13, 71, 144, 157, 42, 51, 199, 71, 147, 157, 207, 224, 76, 110, 235, 128, 213, 195, 171, 228, 229, 209, 18, 246, 190, 222, 235, 174, 209, 100, 202, 162, 24, 135, 190, 221, 210, 137, 129, 10, 15, 150, 178, 113, 48, 153, 81, 110, 76, 91, 230, 208, 195, 97, 218, 188, 212, 35, 237, 7, 110, 103, 205, 202, 73, 167, 105, 168, 172, 83, 42, 109, 65, 182, 210, 148, 247, 41, 68, 140, 140, 105, 74, 227, 243, 131, 185, 182, 157, 158, 209, 62 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new byte[] { 92, 40, 39, 169, 19, 183, 42, 201, 41, 151, 203, 221, 34, 254, 123, 200, 182, 5, 108, 217, 60, 40, 248, 52, 162, 30, 178, 228, 202, 182, 165, 117, 193, 234, 45, 178, 126, 15, 78, 84, 64, 230, 50, 123, 173, 122, 198, 91, 251, 36, 170, 228, 93, 1, 148, 165, 132, 74, 234, 227, 158, 72, 79, 162 }, new byte[] { 194, 36, 130, 175, 23, 161, 32, 212, 221, 160, 137, 104, 167, 245, 71, 187, 73, 5, 50, 116, 18, 55, 1, 20, 119, 64, 127, 64, 191, 182, 249, 6, 210, 177, 14, 125, 13, 71, 144, 157, 42, 51, 199, 71, 147, 157, 207, 224, 76, 110, 235, 128, 213, 195, 171, 228, 229, 209, 18, 246, 190, 222, 235, 174, 209, 100, 202, 162, 24, 135, 190, 221, 210, 137, 129, 10, 15, 150, 178, 113, 48, 153, 81, 110, 76, 91, 230, 208, 195, 97, 218, 188, 212, 35, 237, 7, 110, 103, 205, 202, 73, 167, 105, 168, 172, 83, 42, 109, 65, 182, 210, 148, 247, 41, 68, 140, 140, 105, 74, 227, 243, 131, 185, 182, 157, 158, 209, 62 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new byte[] { 92, 40, 39, 169, 19, 183, 42, 201, 41, 151, 203, 221, 34, 254, 123, 200, 182, 5, 108, 217, 60, 40, 248, 52, 162, 30, 178, 228, 202, 182, 165, 117, 193, 234, 45, 178, 126, 15, 78, 84, 64, 230, 50, 123, 173, 122, 198, 91, 251, 36, 170, 228, 93, 1, 148, 165, 132, 74, 234, 227, 158, 72, 79, 162 }, new byte[] { 194, 36, 130, 175, 23, 161, 32, 212, 221, 160, 137, 104, 167, 245, 71, 187, 73, 5, 50, 116, 18, 55, 1, 20, 119, 64, 127, 64, 191, 182, 249, 6, 210, 177, 14, 125, 13, 71, 144, 157, 42, 51, 199, 71, 147, 157, 207, 224, 76, 110, 235, 128, 213, 195, 171, 228, 229, 209, 18, 246, 190, 222, 235, 174, 209, 100, 202, 162, 24, 135, 190, 221, 210, 137, 129, 10, 15, 150, 178, 113, 48, 153, 81, 110, 76, 91, 230, 208, 195, 97, 218, 188, 212, 35, 237, 7, 110, 103, 205, 202, 73, 167, 105, 168, 172, 83, 42, 109, 65, 182, 210, 148, 247, 41, 68, 140, 140, 105, 74, 227, 243, 131, 185, 182, 157, 158, 209, 62 } });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "MenuTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "MenuTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new byte[] { 92, 40, 39, 169, 19, 183, 42, 201, 41, 151, 203, 221, 34, 254, 123, 200, 182, 5, 108, 217, 60, 40, 248, 52, 162, 30, 178, 228, 202, 182, 165, 117, 193, 234, 45, 178, 126, 15, 78, 84, 64, 230, 50, 123, 173, 122, 198, 91, 251, 36, 170, 228, 93, 1, 148, 165, 132, 74, 234, 227, 158, 72, 79, 162 }, new byte[] { 194, 36, 130, 175, 23, 161, 32, 212, 221, 160, 137, 104, 167, 245, 71, 187, 73, 5, 50, 116, 18, 55, 1, 20, 119, 64, 127, 64, 191, 182, 249, 6, 210, 177, 14, 125, 13, 71, 144, 157, 42, 51, 199, 71, 147, 157, 207, 224, 76, 110, 235, 128, 213, 195, 171, 228, 229, 209, 18, 246, 190, 222, 235, 174, 209, 100, 202, 162, 24, 135, 190, 221, 210, 137, 129, 10, 15, 150, 178, 113, 48, 153, 81, 110, 76, 91, 230, 208, 195, 97, 218, 188, 212, 35, 237, 7, 110, 103, 205, 202, 73, 167, 105, 168, 172, 83, 42, 109, 65, 182, 210, 148, 247, 41, 68, 140, 140, 105, 74, 227, 243, 131, 185, 182, 157, 158, 209, 62 } });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "StudentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459));
        }
    }
}
