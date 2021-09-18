using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Petek.BUmatik.DataAccess.Migrations
{
    public partial class UpdateColumnTransaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ItemCount",
                table: "Transactions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2021, 9, 18, 15, 22, 28, 689, DateTimeKind.Local).AddTicks(3459), new TimeSpan(0, 15, 0, 0, 0) });

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
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 1,
                column: "ItemCount",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 2,
                column: "ItemCount",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 3,
                column: "ItemCount",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 4,
                column: "ItemCount",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 5,
                column: "ItemCount",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Transactions",
                keyColumn: "Id",
                keyValue: 6,
                column: "ItemCount",
                value: 5);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemCount",
                table: "Transactions");

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new byte[] { 124, 141, 153, 46, 212, 246, 48, 244, 27, 7, 203, 201, 143, 244, 182, 55, 81, 193, 122, 159, 210, 227, 14, 52, 31, 127, 243, 144, 152, 199, 208, 180, 209, 204, 123, 42, 212, 150, 60, 71, 210, 132, 218, 4, 74, 57, 158, 45, 228, 164, 194, 131, 150, 166, 3, 51, 97, 203, 243, 9, 9, 188, 195, 219 }, new byte[] { 83, 179, 119, 233, 205, 37, 127, 183, 189, 109, 140, 81, 235, 36, 46, 113, 183, 153, 67, 96, 240, 85, 109, 67, 141, 85, 136, 138, 178, 112, 255, 146, 51, 225, 120, 217, 154, 219, 245, 15, 184, 7, 49, 144, 210, 161, 189, 24, 158, 93, 24, 127, 205, 116, 216, 165, 147, 12, 100, 180, 191, 111, 145, 32, 0, 0, 151, 54, 33, 2, 27, 176, 67, 111, 54, 122, 127, 107, 42, 107, 81, 189, 19, 47, 203, 200, 4, 139, 49, 74, 98, 47, 204, 205, 45, 51, 223, 201, 47, 78, 186, 92, 196, 7, 200, 192, 195, 171, 147, 236, 13, 177, 12, 208, 17, 190, 113, 77, 10, 51, 34, 157, 143, 110, 109, 227, 192, 126 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new byte[] { 124, 141, 153, 46, 212, 246, 48, 244, 27, 7, 203, 201, 143, 244, 182, 55, 81, 193, 122, 159, 210, 227, 14, 52, 31, 127, 243, 144, 152, 199, 208, 180, 209, 204, 123, 42, 212, 150, 60, 71, 210, 132, 218, 4, 74, 57, 158, 45, 228, 164, 194, 131, 150, 166, 3, 51, 97, 203, 243, 9, 9, 188, 195, 219 }, new byte[] { 83, 179, 119, 233, 205, 37, 127, 183, 189, 109, 140, 81, 235, 36, 46, 113, 183, 153, 67, 96, 240, 85, 109, 67, 141, 85, 136, 138, 178, 112, 255, 146, 51, 225, 120, 217, 154, 219, 245, 15, 184, 7, 49, 144, 210, 161, 189, 24, 158, 93, 24, 127, 205, 116, 216, 165, 147, 12, 100, 180, 191, 111, 145, 32, 0, 0, 151, 54, 33, 2, 27, 176, 67, 111, 54, 122, 127, 107, 42, 107, 81, 189, 19, 47, 203, 200, 4, 139, 49, 74, 98, 47, 204, 205, 45, 51, 223, 201, 47, 78, 186, 92, 196, 7, 200, 192, 195, 171, 147, 236, 13, 177, 12, 208, 17, 190, 113, 77, 10, 51, 34, 157, 143, 110, 109, 227, 192, 126 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new byte[] { 124, 141, 153, 46, 212, 246, 48, 244, 27, 7, 203, 201, 143, 244, 182, 55, 81, 193, 122, 159, 210, 227, 14, 52, 31, 127, 243, 144, 152, 199, 208, 180, 209, 204, 123, 42, 212, 150, 60, 71, 210, 132, 218, 4, 74, 57, 158, 45, 228, 164, 194, 131, 150, 166, 3, 51, 97, 203, 243, 9, 9, 188, 195, 219 }, new byte[] { 83, 179, 119, 233, 205, 37, 127, 183, 189, 109, 140, 81, 235, 36, 46, 113, 183, 153, 67, 96, 240, 85, 109, 67, 141, 85, 136, 138, 178, 112, 255, 146, 51, 225, 120, 217, 154, 219, 245, 15, 184, 7, 49, 144, 210, 161, 189, 24, 158, 93, 24, 127, 205, 116, 216, 165, 147, 12, 100, 180, 191, 111, 145, 32, 0, 0, 151, 54, 33, 2, 27, 176, 67, 111, 54, 122, 127, 107, 42, 107, 81, 189, 19, 47, 203, 200, 4, 139, 49, 74, 98, 47, 204, 205, 45, 51, 223, 201, 47, 78, 186, 92, 196, 7, 200, 192, 195, 171, 147, 236, 13, 177, 12, 208, 17, 190, 113, 77, 10, 51, 34, 157, 143, 110, 109, 227, 192, 126 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new byte[] { 124, 141, 153, 46, 212, 246, 48, 244, 27, 7, 203, 201, 143, 244, 182, 55, 81, 193, 122, 159, 210, 227, 14, 52, 31, 127, 243, 144, 152, 199, 208, 180, 209, 204, 123, 42, 212, 150, 60, 71, 210, 132, 218, 4, 74, 57, 158, 45, 228, 164, 194, 131, 150, 166, 3, 51, 97, 203, 243, 9, 9, 188, 195, 219 }, new byte[] { 83, 179, 119, 233, 205, 37, 127, 183, 189, 109, 140, 81, 235, 36, 46, 113, 183, 153, 67, 96, 240, 85, 109, 67, 141, 85, 136, 138, 178, 112, 255, 146, 51, 225, 120, 217, 154, 219, 245, 15, 184, 7, 49, 144, 210, 161, 189, 24, 158, 93, 24, 127, 205, 116, 216, 165, 147, 12, 100, 180, 191, 111, 145, 32, 0, 0, 151, 54, 33, 2, 27, 176, 67, 111, 54, 122, 127, 107, 42, 107, 81, 189, 19, 47, 203, 200, 4, 139, 49, 74, 98, 47, 204, 205, 45, 51, 223, 201, 47, 78, 186, 92, 196, 7, 200, 192, 195, 171, 147, 236, 13, 177, 12, 208, 17, 190, 113, 77, 10, 51, 34, 157, 143, 110, 109, 227, 192, 126 } });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "MenuTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "MenuTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FinishDate" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new TimeSpan(0, 3, 0, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609), new byte[] { 124, 141, 153, 46, 212, 246, 48, 244, 27, 7, 203, 201, 143, 244, 182, 55, 81, 193, 122, 159, 210, 227, 14, 52, 31, 127, 243, 144, 152, 199, 208, 180, 209, 204, 123, 42, 212, 150, 60, 71, 210, 132, 218, 4, 74, 57, 158, 45, 228, 164, 194, 131, 150, 166, 3, 51, 97, 203, 243, 9, 9, 188, 195, 219 }, new byte[] { 83, 179, 119, 233, 205, 37, 127, 183, 189, 109, 140, 81, 235, 36, 46, 113, 183, 153, 67, 96, 240, 85, 109, 67, 141, 85, 136, 138, 178, 112, 255, 146, 51, 225, 120, 217, 154, 219, 245, 15, 184, 7, 49, 144, 210, 161, 189, 24, 158, 93, 24, 127, 205, 116, 216, 165, 147, 12, 100, 180, 191, 111, 145, 32, 0, 0, 151, 54, 33, 2, 27, 176, 67, 111, 54, 122, 127, 107, 42, 107, 81, 189, 19, 47, 203, 200, 4, 139, 49, 74, 98, 47, 204, 205, 45, 51, 223, 201, 47, 78, 186, 92, 196, 7, 200, 192, 195, 171, 147, 236, 13, 177, 12, 208, 17, 190, 113, 77, 10, 51, 34, 157, 143, 110, 109, 227, 192, 126 } });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "StudentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));
        }
    }
}
