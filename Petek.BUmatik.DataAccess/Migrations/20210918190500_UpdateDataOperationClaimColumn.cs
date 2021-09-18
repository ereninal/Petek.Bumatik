using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Petek.BUmatik.DataAccess.Migrations
{
    public partial class UpdateDataOperationClaimColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "OperationClaimId" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), 1 });

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
                columns: new[] { "CreatedDate", "OperationClaimId" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), 1 });

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
                columns: new[] { "CreatedDate", "OperationClaimId" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), 1 });

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
                columns: new[] { "CreatedDate", "OperationClaimId" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129), 1 });

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 4, 59, 106, DateTimeKind.Local).AddTicks(129));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "OperationClaimId" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), 2 });

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "OperationClaimId" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), 2 });

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "OperationClaimId" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), 2 });

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "OperationClaimId" },
                values: new object[] { new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612), 2 });

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 18, 22, 1, 55, 488, DateTimeKind.Local).AddTicks(4612));
        }
    }
}
