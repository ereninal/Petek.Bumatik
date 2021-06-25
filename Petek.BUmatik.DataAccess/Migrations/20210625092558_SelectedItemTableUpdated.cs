using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Petek.BUmatik.DataAccess.Migrations
{
    public partial class SelectedItemTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UseDate",
                table: "SelectedMenuItems",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 126, 171, 227, 107, 180, 149, 183, 224, 64, 190, 174, 204, 206, 54, 62, 158, 160, 114, 19, 134, 60, 55, 120, 139, 66, 234, 11, 123, 208, 137, 36, 193, 240, 206, 237, 175, 188, 115, 69, 229, 9, 135, 80, 107, 169, 19, 113, 175, 91, 142, 194, 37, 69, 245, 152, 200, 36, 125, 59, 160, 176, 193, 56, 35 }, new byte[] { 209, 127, 21, 223, 224, 170, 151, 23, 175, 13, 246, 211, 93, 140, 15, 139, 97, 187, 6, 221, 4, 142, 85, 73, 36, 181, 34, 4, 243, 211, 66, 244, 42, 105, 226, 80, 162, 155, 197, 50, 227, 156, 28, 98, 34, 229, 15, 38, 191, 193, 69, 204, 95, 163, 84, 98, 237, 139, 42, 138, 202, 20, 61, 185, 216, 102, 157, 7, 130, 65, 118, 125, 222, 91, 176, 49, 116, 219, 246, 237, 118, 129, 72, 10, 212, 203, 223, 10, 46, 134, 158, 54, 165, 70, 1, 79, 61, 211, 211, 212, 148, 255, 56, 9, 242, 55, 192, 170, 40, 110, 129, 42, 173, 175, 234, 206, 111, 164, 84, 115, 216, 40, 105, 241, 43, 135, 57, 161 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 126, 171, 227, 107, 180, 149, 183, 224, 64, 190, 174, 204, 206, 54, 62, 158, 160, 114, 19, 134, 60, 55, 120, 139, 66, 234, 11, 123, 208, 137, 36, 193, 240, 206, 237, 175, 188, 115, 69, 229, 9, 135, 80, 107, 169, 19, 113, 175, 91, 142, 194, 37, 69, 245, 152, 200, 36, 125, 59, 160, 176, 193, 56, 35 }, new byte[] { 209, 127, 21, 223, 224, 170, 151, 23, 175, 13, 246, 211, 93, 140, 15, 139, 97, 187, 6, 221, 4, 142, 85, 73, 36, 181, 34, 4, 243, 211, 66, 244, 42, 105, 226, 80, 162, 155, 197, 50, 227, 156, 28, 98, 34, 229, 15, 38, 191, 193, 69, 204, 95, 163, 84, 98, 237, 139, 42, 138, 202, 20, 61, 185, 216, 102, 157, 7, 130, 65, 118, 125, 222, 91, 176, 49, 116, 219, 246, 237, 118, 129, 72, 10, 212, 203, 223, 10, 46, 134, 158, 54, 165, 70, 1, 79, 61, 211, 211, 212, 148, 255, 56, 9, 242, 55, 192, 170, 40, 110, 129, 42, 173, 175, 234, 206, 111, 164, 84, 115, 216, 40, 105, 241, 43, 135, 57, 161 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 126, 171, 227, 107, 180, 149, 183, 224, 64, 190, 174, 204, 206, 54, 62, 158, 160, 114, 19, 134, 60, 55, 120, 139, 66, 234, 11, 123, 208, 137, 36, 193, 240, 206, 237, 175, 188, 115, 69, 229, 9, 135, 80, 107, 169, 19, 113, 175, 91, 142, 194, 37, 69, 245, 152, 200, 36, 125, 59, 160, 176, 193, 56, 35 }, new byte[] { 209, 127, 21, 223, 224, 170, 151, 23, 175, 13, 246, 211, 93, 140, 15, 139, 97, 187, 6, 221, 4, 142, 85, 73, 36, 181, 34, 4, 243, 211, 66, 244, 42, 105, 226, 80, 162, 155, 197, 50, 227, 156, 28, 98, 34, 229, 15, 38, 191, 193, 69, 204, 95, 163, 84, 98, 237, 139, 42, 138, 202, 20, 61, 185, 216, 102, 157, 7, 130, 65, 118, 125, 222, 91, 176, 49, 116, 219, 246, 237, 118, 129, 72, 10, 212, 203, 223, 10, 46, 134, 158, 54, 165, 70, 1, 79, 61, 211, 211, 212, 148, 255, 56, 9, 242, 55, 192, 170, 40, 110, 129, 42, 173, 175, 234, 206, 111, 164, 84, 115, 216, 40, 105, 241, 43, 135, 57, 161 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 126, 171, 227, 107, 180, 149, 183, 224, 64, 190, 174, 204, 206, 54, 62, 158, 160, 114, 19, 134, 60, 55, 120, 139, 66, 234, 11, 123, 208, 137, 36, 193, 240, 206, 237, 175, 188, 115, 69, 229, 9, 135, 80, 107, 169, 19, 113, 175, 91, 142, 194, 37, 69, 245, 152, 200, 36, 125, 59, 160, 176, 193, 56, 35 }, new byte[] { 209, 127, 21, 223, 224, 170, 151, 23, 175, 13, 246, 211, 93, 140, 15, 139, 97, 187, 6, 221, 4, 142, 85, 73, 36, 181, 34, 4, 243, 211, 66, 244, 42, 105, 226, 80, 162, 155, 197, 50, 227, 156, 28, 98, 34, 229, 15, 38, 191, 193, 69, 204, 95, 163, 84, 98, 237, 139, 42, 138, 202, 20, 61, 185, 216, 102, 157, 7, 130, 65, 118, 125, 222, 91, 176, 49, 116, 219, 246, 237, 118, 129, 72, 10, 212, 203, 223, 10, 46, 134, 158, 54, 165, 70, 1, 79, 61, 211, 211, 212, 148, 255, 56, 9, 242, 55, 192, 170, 40, 110, 129, 42, 173, 175, 234, 206, 111, 164, 84, 115, 216, 40, 105, 241, 43, 135, 57, 161 } });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 12, 25, 57, 272, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 126, 171, 227, 107, 180, 149, 183, 224, 64, 190, 174, 204, 206, 54, 62, 158, 160, 114, 19, 134, 60, 55, 120, 139, 66, 234, 11, 123, 208, 137, 36, 193, 240, 206, 237, 175, 188, 115, 69, 229, 9, 135, 80, 107, 169, 19, 113, 175, 91, 142, 194, 37, 69, 245, 152, 200, 36, 125, 59, 160, 176, 193, 56, 35 }, new byte[] { 209, 127, 21, 223, 224, 170, 151, 23, 175, 13, 246, 211, 93, 140, 15, 139, 97, 187, 6, 221, 4, 142, 85, 73, 36, 181, 34, 4, 243, 211, 66, 244, 42, 105, 226, 80, 162, 155, 197, 50, 227, 156, 28, 98, 34, 229, 15, 38, 191, 193, 69, 204, 95, 163, 84, 98, 237, 139, 42, 138, 202, 20, 61, 185, 216, 102, 157, 7, 130, 65, 118, 125, 222, 91, 176, 49, 116, 219, 246, 237, 118, 129, 72, 10, 212, 203, 223, 10, 46, 134, 158, 54, 165, 70, 1, 79, 61, 211, 211, 212, 148, 255, 56, 9, 242, 55, 192, 170, 40, 110, 129, 42, 173, 175, 234, 206, 111, 164, 84, 115, 216, 40, 105, 241, 43, 135, 57, 161 } });

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "UseDate",
                value: new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "UseDate",
                value: new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "UseDate",
                value: new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "UseDate",
                value: new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "UseDate",
                value: new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "UseDate",
                value: new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UseDate",
                table: "SelectedMenuItems");

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 103, 243, 137, 139, 2, 212, 232, 73, 116, 92, 150, 207, 8, 135, 17, 163, 124, 151, 158, 108, 97, 144, 30, 134, 58, 226, 70, 189, 244, 8, 183, 181, 164, 158, 39, 39, 163, 155, 142, 111, 253, 66, 106, 243, 160, 243, 207, 95, 175, 156, 155, 187, 251, 147, 243, 243, 43, 233, 146, 189, 38, 59, 233, 189 }, new byte[] { 148, 210, 139, 107, 99, 223, 141, 55, 229, 71, 55, 39, 108, 193, 71, 158, 90, 238, 13, 166, 229, 172, 109, 243, 19, 1, 13, 174, 114, 12, 248, 129, 224, 206, 89, 187, 100, 127, 19, 177, 18, 71, 53, 167, 223, 38, 131, 90, 120, 87, 14, 199, 101, 170, 179, 253, 123, 2, 60, 204, 124, 169, 106, 133, 150, 57, 84, 67, 206, 222, 195, 86, 97, 236, 155, 246, 193, 175, 174, 223, 32, 138, 24, 48, 147, 128, 132, 18, 118, 191, 69, 73, 248, 241, 100, 143, 237, 11, 174, 252, 157, 150, 140, 101, 140, 85, 230, 154, 132, 126, 30, 43, 100, 10, 7, 207, 113, 88, 217, 3, 140, 159, 51, 86, 218, 128, 135, 186 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 103, 243, 137, 139, 2, 212, 232, 73, 116, 92, 150, 207, 8, 135, 17, 163, 124, 151, 158, 108, 97, 144, 30, 134, 58, 226, 70, 189, 244, 8, 183, 181, 164, 158, 39, 39, 163, 155, 142, 111, 253, 66, 106, 243, 160, 243, 207, 95, 175, 156, 155, 187, 251, 147, 243, 243, 43, 233, 146, 189, 38, 59, 233, 189 }, new byte[] { 148, 210, 139, 107, 99, 223, 141, 55, 229, 71, 55, 39, 108, 193, 71, 158, 90, 238, 13, 166, 229, 172, 109, 243, 19, 1, 13, 174, 114, 12, 248, 129, 224, 206, 89, 187, 100, 127, 19, 177, 18, 71, 53, 167, 223, 38, 131, 90, 120, 87, 14, 199, 101, 170, 179, 253, 123, 2, 60, 204, 124, 169, 106, 133, 150, 57, 84, 67, 206, 222, 195, 86, 97, 236, 155, 246, 193, 175, 174, 223, 32, 138, 24, 48, 147, 128, 132, 18, 118, 191, 69, 73, 248, 241, 100, 143, 237, 11, 174, 252, 157, 150, 140, 101, 140, 85, 230, 154, 132, 126, 30, 43, 100, 10, 7, 207, 113, 88, 217, 3, 140, 159, 51, 86, 218, 128, 135, 186 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 103, 243, 137, 139, 2, 212, 232, 73, 116, 92, 150, 207, 8, 135, 17, 163, 124, 151, 158, 108, 97, 144, 30, 134, 58, 226, 70, 189, 244, 8, 183, 181, 164, 158, 39, 39, 163, 155, 142, 111, 253, 66, 106, 243, 160, 243, 207, 95, 175, 156, 155, 187, 251, 147, 243, 243, 43, 233, 146, 189, 38, 59, 233, 189 }, new byte[] { 148, 210, 139, 107, 99, 223, 141, 55, 229, 71, 55, 39, 108, 193, 71, 158, 90, 238, 13, 166, 229, 172, 109, 243, 19, 1, 13, 174, 114, 12, 248, 129, 224, 206, 89, 187, 100, 127, 19, 177, 18, 71, 53, 167, 223, 38, 131, 90, 120, 87, 14, 199, 101, 170, 179, 253, 123, 2, 60, 204, 124, 169, 106, 133, 150, 57, 84, 67, 206, 222, 195, 86, 97, 236, 155, 246, 193, 175, 174, 223, 32, 138, 24, 48, 147, 128, 132, 18, 118, 191, 69, 73, 248, 241, 100, 143, 237, 11, 174, 252, 157, 150, 140, 101, 140, 85, 230, 154, 132, 126, 30, 43, 100, 10, 7, 207, 113, 88, 217, 3, 140, 159, 51, 86, 218, 128, 135, 186 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 103, 243, 137, 139, 2, 212, 232, 73, 116, 92, 150, 207, 8, 135, 17, 163, 124, 151, 158, 108, 97, 144, 30, 134, 58, 226, 70, 189, 244, 8, 183, 181, 164, 158, 39, 39, 163, 155, 142, 111, 253, 66, 106, 243, 160, 243, 207, 95, 175, 156, 155, 187, 251, 147, 243, 243, 43, 233, 146, 189, 38, 59, 233, 189 }, new byte[] { 148, 210, 139, 107, 99, 223, 141, 55, 229, 71, 55, 39, 108, 193, 71, 158, 90, 238, 13, 166, 229, 172, 109, 243, 19, 1, 13, 174, 114, 12, 248, 129, 224, 206, 89, 187, 100, 127, 19, 177, 18, 71, 53, 167, 223, 38, 131, 90, 120, 87, 14, 199, 101, 170, 179, 253, 123, 2, 60, 204, 124, 169, 106, 133, 150, 57, 84, 67, 206, 222, 195, 86, 97, 236, 155, 246, 193, 175, 174, 223, 32, 138, 24, 48, 147, 128, 132, 18, 118, 191, 69, 73, 248, 241, 100, 143, 237, 11, 174, 252, 157, 150, 140, 101, 140, 85, 230, 154, 132, 126, 30, 43, 100, 10, 7, 207, 113, 88, 217, 3, 140, 159, 51, 86, 218, 128, 135, 186 } });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 6, 25, 2, 47, 24, 723, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 103, 243, 137, 139, 2, 212, 232, 73, 116, 92, 150, 207, 8, 135, 17, 163, 124, 151, 158, 108, 97, 144, 30, 134, 58, 226, 70, 189, 244, 8, 183, 181, 164, 158, 39, 39, 163, 155, 142, 111, 253, 66, 106, 243, 160, 243, 207, 95, 175, 156, 155, 187, 251, 147, 243, 243, 43, 233, 146, 189, 38, 59, 233, 189 }, new byte[] { 148, 210, 139, 107, 99, 223, 141, 55, 229, 71, 55, 39, 108, 193, 71, 158, 90, 238, 13, 166, 229, 172, 109, 243, 19, 1, 13, 174, 114, 12, 248, 129, 224, 206, 89, 187, 100, 127, 19, 177, 18, 71, 53, 167, 223, 38, 131, 90, 120, 87, 14, 199, 101, 170, 179, 253, 123, 2, 60, 204, 124, 169, 106, 133, 150, 57, 84, 67, 206, 222, 195, 86, 97, 236, 155, 246, 193, 175, 174, 223, 32, 138, 24, 48, 147, 128, 132, 18, 118, 191, 69, 73, 248, 241, 100, 143, 237, 11, 174, 252, 157, 150, 140, 101, 140, 85, 230, 154, 132, 126, 30, 43, 100, 10, 7, 207, 113, 88, 217, 3, 140, 159, 51, 86, 218, 128, 135, 186 } });
        }
    }
}
