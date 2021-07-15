using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Petek.BUmatik.DataAccess.Migrations
{
    public partial class AutomatTablesUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "AutomatItems",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new byte[] { 54, 29, 190, 200, 52, 16, 252, 32, 176, 17, 122, 255, 129, 161, 38, 117, 204, 224, 22, 106, 112, 102, 157, 66, 116, 61, 18, 110, 255, 51, 153, 150, 204, 159, 135, 81, 73, 204, 183, 149, 226, 125, 20, 81, 169, 68, 10, 196, 26, 135, 208, 213, 236, 117, 86, 68, 186, 200, 59, 18, 17, 67, 1, 60 }, new byte[] { 191, 175, 251, 159, 190, 10, 44, 87, 98, 140, 135, 4, 30, 187, 125, 161, 174, 185, 104, 141, 34, 204, 198, 231, 152, 43, 77, 31, 138, 125, 164, 75, 201, 140, 20, 71, 18, 63, 181, 62, 78, 4, 148, 139, 79, 6, 199, 95, 151, 101, 175, 137, 176, 28, 119, 136, 13, 54, 91, 105, 147, 62, 195, 147, 91, 109, 243, 208, 32, 162, 245, 51, 146, 135, 29, 187, 34, 111, 127, 143, 106, 114, 142, 176, 101, 15, 38, 161, 127, 69, 102, 112, 42, 255, 128, 59, 105, 129, 180, 42, 234, 88, 195, 172, 9, 110, 209, 167, 229, 47, 67, 133, 28, 226, 231, 94, 114, 109, 228, 25, 198, 206, 71, 191, 111, 108, 225, 251 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new byte[] { 54, 29, 190, 200, 52, 16, 252, 32, 176, 17, 122, 255, 129, 161, 38, 117, 204, 224, 22, 106, 112, 102, 157, 66, 116, 61, 18, 110, 255, 51, 153, 150, 204, 159, 135, 81, 73, 204, 183, 149, 226, 125, 20, 81, 169, 68, 10, 196, 26, 135, 208, 213, 236, 117, 86, 68, 186, 200, 59, 18, 17, 67, 1, 60 }, new byte[] { 191, 175, 251, 159, 190, 10, 44, 87, 98, 140, 135, 4, 30, 187, 125, 161, 174, 185, 104, 141, 34, 204, 198, 231, 152, 43, 77, 31, 138, 125, 164, 75, 201, 140, 20, 71, 18, 63, 181, 62, 78, 4, 148, 139, 79, 6, 199, 95, 151, 101, 175, 137, 176, 28, 119, 136, 13, 54, 91, 105, 147, 62, 195, 147, 91, 109, 243, 208, 32, 162, 245, 51, 146, 135, 29, 187, 34, 111, 127, 143, 106, 114, 142, 176, 101, 15, 38, 161, 127, 69, 102, 112, 42, 255, 128, 59, 105, 129, 180, 42, 234, 88, 195, 172, 9, 110, 209, 167, 229, 47, 67, 133, 28, 226, 231, 94, 114, 109, 228, 25, 198, 206, 71, 191, 111, 108, 225, 251 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new byte[] { 54, 29, 190, 200, 52, 16, 252, 32, 176, 17, 122, 255, 129, 161, 38, 117, 204, 224, 22, 106, 112, 102, 157, 66, 116, 61, 18, 110, 255, 51, 153, 150, 204, 159, 135, 81, 73, 204, 183, 149, 226, 125, 20, 81, 169, 68, 10, 196, 26, 135, 208, 213, 236, 117, 86, 68, 186, 200, 59, 18, 17, 67, 1, 60 }, new byte[] { 191, 175, 251, 159, 190, 10, 44, 87, 98, 140, 135, 4, 30, 187, 125, 161, 174, 185, 104, 141, 34, 204, 198, 231, 152, 43, 77, 31, 138, 125, 164, 75, 201, 140, 20, 71, 18, 63, 181, 62, 78, 4, 148, 139, 79, 6, 199, 95, 151, 101, 175, 137, 176, 28, 119, 136, 13, 54, 91, 105, 147, 62, 195, 147, 91, 109, 243, 208, 32, 162, 245, 51, 146, 135, 29, 187, 34, 111, 127, 143, 106, 114, 142, 176, 101, 15, 38, 161, 127, 69, 102, 112, 42, 255, 128, 59, 105, 129, 180, 42, 234, 88, 195, 172, 9, 110, 209, 167, 229, 47, 67, 133, 28, 226, 231, 94, 114, 109, 228, 25, 198, 206, 71, 191, 111, 108, 225, 251 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new byte[] { 54, 29, 190, 200, 52, 16, 252, 32, 176, 17, 122, 255, 129, 161, 38, 117, 204, 224, 22, 106, 112, 102, 157, 66, 116, 61, 18, 110, 255, 51, 153, 150, 204, 159, 135, 81, 73, 204, 183, 149, 226, 125, 20, 81, 169, 68, 10, 196, 26, 135, 208, 213, 236, 117, 86, 68, 186, 200, 59, 18, 17, 67, 1, 60 }, new byte[] { 191, 175, 251, 159, 190, 10, 44, 87, 98, 140, 135, 4, 30, 187, 125, 161, 174, 185, 104, 141, 34, 204, 198, 231, 152, 43, 77, 31, 138, 125, 164, 75, 201, 140, 20, 71, 18, 63, 181, 62, 78, 4, 148, 139, 79, 6, 199, 95, 151, 101, 175, 137, 176, 28, 119, 136, 13, 54, 91, 105, 147, 62, 195, 147, 91, 109, 243, 208, 32, 162, 245, 51, 146, 135, 29, 187, 34, 111, 127, 143, 106, 114, 142, 176, 101, 15, 38, 161, 127, 69, 102, 112, 42, 255, 128, 59, 105, 129, 180, 42, 234, 88, 195, 172, 9, 110, 209, 167, 229, 47, 67, 133, 28, 226, 231, 94, 114, 109, 228, 25, 198, 206, 71, 191, 111, 108, 225, 251 } });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), "/src/assets/img/automatItems/items-1.jpg" });

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), "/src/assets/img/automatItems/items-1.jpg" });

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), "/src/assets/img/automatItems/items-1.jpg" });

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), "/src/assets/img/automatItems/items-1.jpg" });

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), "/src/assets/img/automatItems/items-1.jpg" });

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), "/src/assets/img/automatItems/items-1.jpg" });

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ImagePath" },
                values: new object[] { new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), "/src/assets/img/automatItems/items-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 124, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "MenuTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "MenuTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966), new byte[] { 54, 29, 190, 200, 52, 16, 252, 32, 176, 17, 122, 255, 129, 161, 38, 117, 204, 224, 22, 106, 112, 102, 157, 66, 116, 61, 18, 110, 255, 51, 153, 150, 204, 159, 135, 81, 73, 204, 183, 149, 226, 125, 20, 81, 169, 68, 10, 196, 26, 135, 208, 213, 236, 117, 86, 68, 186, 200, 59, 18, 17, 67, 1, 60 }, new byte[] { 191, 175, 251, 159, 190, 10, 44, 87, 98, 140, 135, 4, 30, 187, 125, 161, 174, 185, 104, 141, 34, 204, 198, 231, 152, 43, 77, 31, 138, 125, 164, 75, 201, 140, 20, 71, 18, 63, 181, 62, 78, 4, 148, 139, 79, 6, 199, 95, 151, 101, 175, 137, 176, 28, 119, 136, 13, 54, 91, 105, 147, 62, 195, 147, 91, 109, 243, 208, 32, 162, 245, 51, 146, 135, 29, 187, 34, 111, 127, 143, 106, 114, 142, 176, 101, 15, 38, 161, 127, 69, 102, 112, 42, 255, 128, 59, 105, 129, 180, 42, 234, 88, 195, 172, 9, 110, 209, 167, 229, 47, 67, 133, 28, 226, 231, 94, 114, 109, 228, 25, 198, 206, 71, 191, 111, 108, 225, 251 } });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "StudentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 7, 16, 0, 50, 41, 94, DateTimeKind.Local).AddTicks(3966));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "AutomatItems");

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 126, 171, 227, 107, 180, 149, 183, 224, 64, 190, 174, 204, 206, 54, 62, 158, 160, 114, 19, 134, 60, 55, 120, 139, 66, 234, 11, 123, 208, 137, 36, 193, 240, 206, 237, 175, 188, 115, 69, 229, 9, 135, 80, 107, 169, 19, 113, 175, 91, 142, 194, 37, 69, 245, 152, 200, 36, 125, 59, 160, 176, 193, 56, 35 }, new byte[] { 209, 127, 21, 223, 224, 170, 151, 23, 175, 13, 246, 211, 93, 140, 15, 139, 97, 187, 6, 221, 4, 142, 85, 73, 36, 181, 34, 4, 243, 211, 66, 244, 42, 105, 226, 80, 162, 155, 197, 50, 227, 156, 28, 98, 34, 229, 15, 38, 191, 193, 69, 204, 95, 163, 84, 98, 237, 139, 42, 138, 202, 20, 61, 185, 216, 102, 157, 7, 130, 65, 118, 125, 222, 91, 176, 49, 116, 219, 246, 237, 118, 129, 72, 10, 212, 203, 223, 10, 46, 134, 158, 54, 165, 70, 1, 79, 61, 211, 211, 212, 148, 255, 56, 9, 242, 55, 192, 170, 40, 110, 129, 42, 173, 175, 234, 206, 111, 164, 84, 115, 216, 40, 105, 241, 43, 135, 57, 161 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 126, 171, 227, 107, 180, 149, 183, 224, 64, 190, 174, 204, 206, 54, 62, 158, 160, 114, 19, 134, 60, 55, 120, 139, 66, 234, 11, 123, 208, 137, 36, 193, 240, 206, 237, 175, 188, 115, 69, 229, 9, 135, 80, 107, 169, 19, 113, 175, 91, 142, 194, 37, 69, 245, 152, 200, 36, 125, 59, 160, 176, 193, 56, 35 }, new byte[] { 209, 127, 21, 223, 224, 170, 151, 23, 175, 13, 246, 211, 93, 140, 15, 139, 97, 187, 6, 221, 4, 142, 85, 73, 36, 181, 34, 4, 243, 211, 66, 244, 42, 105, 226, 80, 162, 155, 197, 50, 227, 156, 28, 98, 34, 229, 15, 38, 191, 193, 69, 204, 95, 163, 84, 98, 237, 139, 42, 138, 202, 20, 61, 185, 216, 102, 157, 7, 130, 65, 118, 125, 222, 91, 176, 49, 116, 219, 246, 237, 118, 129, 72, 10, 212, 203, 223, 10, 46, 134, 158, 54, 165, 70, 1, 79, 61, 211, 211, 212, 148, 255, 56, 9, 242, 55, 192, 170, 40, 110, 129, 42, 173, 175, 234, 206, 111, 164, 84, 115, 216, 40, 105, 241, 43, 135, 57, 161 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 126, 171, 227, 107, 180, 149, 183, 224, 64, 190, 174, 204, 206, 54, 62, 158, 160, 114, 19, 134, 60, 55, 120, 139, 66, 234, 11, 123, 208, 137, 36, 193, 240, 206, 237, 175, 188, 115, 69, 229, 9, 135, 80, 107, 169, 19, 113, 175, 91, 142, 194, 37, 69, 245, 152, 200, 36, 125, 59, 160, 176, 193, 56, 35 }, new byte[] { 209, 127, 21, 223, 224, 170, 151, 23, 175, 13, 246, 211, 93, 140, 15, 139, 97, 187, 6, 221, 4, 142, 85, 73, 36, 181, 34, 4, 243, 211, 66, 244, 42, 105, 226, 80, 162, 155, 197, 50, 227, 156, 28, 98, 34, 229, 15, 38, 191, 193, 69, 204, 95, 163, 84, 98, 237, 139, 42, 138, 202, 20, 61, 185, 216, 102, 157, 7, 130, 65, 118, 125, 222, 91, 176, 49, 116, 219, 246, 237, 118, 129, 72, 10, 212, 203, 223, 10, 46, 134, 158, 54, 165, 70, 1, 79, 61, 211, 211, 212, 148, 255, 56, 9, 242, 55, 192, 170, 40, 110, 129, 42, 173, 175, 234, 206, 111, 164, 84, 115, 216, 40, 105, 241, 43, 135, 57, 161 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 126, 171, 227, 107, 180, 149, 183, 224, 64, 190, 174, 204, 206, 54, 62, 158, 160, 114, 19, 134, 60, 55, 120, 139, 66, 234, 11, 123, 208, 137, 36, 193, 240, 206, 237, 175, 188, 115, 69, 229, 9, 135, 80, 107, 169, 19, 113, 175, 91, 142, 194, 37, 69, 245, 152, 200, 36, 125, 59, 160, 176, 193, 56, 35 }, new byte[] { 209, 127, 21, 223, 224, 170, 151, 23, 175, 13, 246, 211, 93, 140, 15, 139, 97, 187, 6, 221, 4, 142, 85, 73, 36, 181, 34, 4, 243, 211, 66, 244, 42, 105, 226, 80, 162, 155, 197, 50, 227, 156, 28, 98, 34, 229, 15, 38, 191, 193, 69, 204, 95, 163, 84, 98, 237, 139, 42, 138, 202, 20, 61, 185, 216, 102, 157, 7, 130, 65, 118, 125, 222, 91, 176, 49, 116, 219, 246, 237, 118, 129, 72, 10, 212, 203, 223, 10, 46, 134, 158, 54, 165, 70, 1, 79, 61, 211, 211, 212, 148, 255, 56, 9, 242, 55, 192, 170, 40, 110, 129, 42, 173, 175, 234, 206, 111, 164, 84, 115, 216, 40, 105, 241, 43, 135, 57, 161 } });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MenuTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MenuTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 126, 171, 227, 107, 180, 149, 183, 224, 64, 190, 174, 204, 206, 54, 62, 158, 160, 114, 19, 134, 60, 55, 120, 139, 66, 234, 11, 123, 208, 137, 36, 193, 240, 206, 237, 175, 188, 115, 69, 229, 9, 135, 80, 107, 169, 19, 113, 175, 91, 142, 194, 37, 69, 245, 152, 200, 36, 125, 59, 160, 176, 193, 56, 35 }, new byte[] { 209, 127, 21, 223, 224, 170, 151, 23, 175, 13, 246, 211, 93, 140, 15, 139, 97, 187, 6, 221, 4, 142, 85, 73, 36, 181, 34, 4, 243, 211, 66, 244, 42, 105, 226, 80, 162, 155, 197, 50, 227, 156, 28, 98, 34, 229, 15, 38, 191, 193, 69, 204, 95, 163, 84, 98, 237, 139, 42, 138, 202, 20, 61, 185, 216, 102, 157, 7, 130, 65, 118, 125, 222, 91, 176, 49, 116, 219, 246, 237, 118, 129, 72, 10, 212, 203, 223, 10, 46, 134, 158, 54, 165, 70, 1, 79, 61, 211, 211, 212, 148, 255, 56, 9, 242, 55, 192, 170, 40, 110, 129, 42, 173, 175, 234, 206, 111, 164, 84, 115, 216, 40, 105, 241, 43, 135, 57, 161 } });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "StudentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
