using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Petek.BUmatik.DataAccess.Migrations
{
    public partial class NewTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AutomatItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Count = table.Column<int>(type: "integer", nullable: false),
                    LastUseDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedUserId = table.Column<int>(type: "integer", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutomatItems", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 36, 191, 64, 5, 152, 101, 212, 124, 4, 175, 247, 50, 82, 170, 204, 170, 206, 48, 27, 123, 46, 26, 110, 95, 216, 188, 196, 147, 253, 128, 232, 177, 71, 38, 56, 144, 95, 117, 196, 39, 132, 151, 6, 42, 175, 59, 124, 251, 235, 202, 24, 90, 137, 50, 44, 144, 218, 44, 73, 75, 102, 245, 29, 40 }, new byte[] { 79, 241, 8, 172, 148, 85, 14, 58, 254, 120, 135, 206, 145, 164, 220, 204, 1, 81, 101, 129, 135, 22, 152, 70, 93, 174, 37, 83, 179, 90, 134, 19, 238, 251, 225, 173, 35, 48, 77, 122, 221, 91, 65, 97, 158, 252, 119, 195, 9, 128, 197, 123, 165, 58, 195, 218, 214, 117, 244, 173, 231, 74, 57, 33, 211, 50, 241, 155, 52, 32, 157, 20, 2, 107, 214, 240, 52, 105, 244, 21, 177, 65, 40, 153, 3, 111, 241, 175, 229, 244, 70, 59, 33, 41, 238, 140, 64, 140, 17, 163, 58, 189, 57, 7, 233, 133, 110, 109, 189, 188, 249, 194, 127, 139, 98, 43, 85, 53, 212, 180, 163, 110, 75, 214, 7, 204, 120, 221 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 36, 191, 64, 5, 152, 101, 212, 124, 4, 175, 247, 50, 82, 170, 204, 170, 206, 48, 27, 123, 46, 26, 110, 95, 216, 188, 196, 147, 253, 128, 232, 177, 71, 38, 56, 144, 95, 117, 196, 39, 132, 151, 6, 42, 175, 59, 124, 251, 235, 202, 24, 90, 137, 50, 44, 144, 218, 44, 73, 75, 102, 245, 29, 40 }, new byte[] { 79, 241, 8, 172, 148, 85, 14, 58, 254, 120, 135, 206, 145, 164, 220, 204, 1, 81, 101, 129, 135, 22, 152, 70, 93, 174, 37, 83, 179, 90, 134, 19, 238, 251, 225, 173, 35, 48, 77, 122, 221, 91, 65, 97, 158, 252, 119, 195, 9, 128, 197, 123, 165, 58, 195, 218, 214, 117, 244, 173, 231, 74, 57, 33, 211, 50, 241, 155, 52, 32, 157, 20, 2, 107, 214, 240, 52, 105, 244, 21, 177, 65, 40, 153, 3, 111, 241, 175, 229, 244, 70, 59, 33, 41, 238, 140, 64, 140, 17, 163, 58, 189, 57, 7, 233, 133, 110, 109, 189, 188, 249, 194, 127, 139, 98, 43, 85, 53, 212, 180, 163, 110, 75, 214, 7, 204, 120, 221 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 36, 191, 64, 5, 152, 101, 212, 124, 4, 175, 247, 50, 82, 170, 204, 170, 206, 48, 27, 123, 46, 26, 110, 95, 216, 188, 196, 147, 253, 128, 232, 177, 71, 38, 56, 144, 95, 117, 196, 39, 132, 151, 6, 42, 175, 59, 124, 251, 235, 202, 24, 90, 137, 50, 44, 144, 218, 44, 73, 75, 102, 245, 29, 40 }, new byte[] { 79, 241, 8, 172, 148, 85, 14, 58, 254, 120, 135, 206, 145, 164, 220, 204, 1, 81, 101, 129, 135, 22, 152, 70, 93, 174, 37, 83, 179, 90, 134, 19, 238, 251, 225, 173, 35, 48, 77, 122, 221, 91, 65, 97, 158, 252, 119, 195, 9, 128, 197, 123, 165, 58, 195, 218, 214, 117, 244, 173, 231, 74, 57, 33, 211, 50, 241, 155, 52, 32, 157, 20, 2, 107, 214, 240, 52, 105, 244, 21, 177, 65, 40, 153, 3, 111, 241, 175, 229, 244, 70, 59, 33, 41, 238, 140, 64, 140, 17, 163, 58, 189, 57, 7, 233, 133, 110, 109, 189, 188, 249, 194, 127, 139, 98, 43, 85, 53, 212, 180, 163, 110, 75, 214, 7, 204, 120, 221 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 36, 191, 64, 5, 152, 101, 212, 124, 4, 175, 247, 50, 82, 170, 204, 170, 206, 48, 27, 123, 46, 26, 110, 95, 216, 188, 196, 147, 253, 128, 232, 177, 71, 38, 56, 144, 95, 117, 196, 39, 132, 151, 6, 42, 175, 59, 124, 251, 235, 202, 24, 90, 137, 50, 44, 144, 218, 44, 73, 75, 102, 245, 29, 40 }, new byte[] { 79, 241, 8, 172, 148, 85, 14, 58, 254, 120, 135, 206, 145, 164, 220, 204, 1, 81, 101, 129, 135, 22, 152, 70, 93, 174, 37, 83, 179, 90, 134, 19, 238, 251, 225, 173, 35, 48, 77, 122, 221, 91, 65, 97, 158, 252, 119, 195, 9, 128, 197, 123, 165, 58, 195, 218, 214, 117, 244, 173, 231, 74, 57, 33, 211, 50, 241, 155, 52, 32, 157, 20, 2, 107, 214, 240, 52, 105, 244, 21, 177, 65, 40, 153, 3, 111, 241, 175, 229, 244, 70, 59, 33, 41, 238, 140, 64, 140, 17, 163, 58, 189, 57, 7, 233, 133, 110, 109, 189, 188, 249, 194, 127, 139, 98, 43, 85, 53, 212, 180, 163, 110, 75, 214, 7, 204, 120, 221 } });

            migrationBuilder.InsertData(
                table: "AutomatItems",
                columns: new[] { "Id", "Count", "CreatedDate", "CreatedUserId", "IsDeleted", "LastUseDate", "ModifiedDate", "ModifiedUserId", "Name" },
                values: new object[,]
                {
                    { 1, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Elma" },
                    { 26, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Karadut" },
                    { 25, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kaju" },
                    { 24, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Erik" },
                    { 23, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kayısı" },
                    { 22, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Yaban Mersini" },
                    { 21, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nektari" },
                    { 20, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "ŞEftali" },
                    { 18, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "KEstane" },
                    { 17, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ceviz" },
                    { 16, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ayva" },
                    { 19, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Su" },
                    { 14, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Badem" },
                    { 2, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Armut" },
                    { 3, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Ananas" },
                    { 4, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Portakal" },
                    { 15, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Fındık" },
                    { 6, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Kivi" },
                    { 7, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Çilek" },
                    { 5, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mandalina" },
                    { 9, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Avokado" },
                    { 10, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Üzüm" },
                    { 11, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Hurma" },
                    { 12, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Nar" },
                    { 13, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Greyfurt" },
                    { 8, 10, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Muz" }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 55, 37, 814, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 36, 191, 64, 5, 152, 101, 212, 124, 4, 175, 247, 50, 82, 170, 204, 170, 206, 48, 27, 123, 46, 26, 110, 95, 216, 188, 196, 147, 253, 128, 232, 177, 71, 38, 56, 144, 95, 117, 196, 39, 132, 151, 6, 42, 175, 59, 124, 251, 235, 202, 24, 90, 137, 50, 44, 144, 218, 44, 73, 75, 102, 245, 29, 40 }, new byte[] { 79, 241, 8, 172, 148, 85, 14, 58, 254, 120, 135, 206, 145, 164, 220, 204, 1, 81, 101, 129, 135, 22, 152, 70, 93, 174, 37, 83, 179, 90, 134, 19, 238, 251, 225, 173, 35, 48, 77, 122, 221, 91, 65, 97, 158, 252, 119, 195, 9, 128, 197, 123, 165, 58, 195, 218, 214, 117, 244, 173, 231, 74, 57, 33, 211, 50, 241, 155, 52, 32, 157, 20, 2, 107, 214, 240, 52, 105, 244, 21, 177, 65, 40, 153, 3, 111, 241, 175, 229, 244, 70, 59, 33, 41, 238, 140, 64, 140, 17, 163, 58, 189, 57, 7, 233, 133, 110, 109, 189, 188, 249, 194, 127, 139, 98, 43, 85, 53, 212, 180, 163, 110, 75, 214, 7, 204, 120, 221 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutomatItems");

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 42, 105, 186, 199, 92, 15, 136, 48, 231, 186, 67, 40, 52, 222, 212, 8, 17, 35, 253, 188, 244, 54, 28, 149, 55, 93, 147, 36, 52, 4, 245, 132, 239, 254, 110, 185, 101, 207, 230, 17, 174, 161, 8, 106, 105, 139, 106, 43, 108, 34, 163, 218, 159, 102, 166, 96, 175, 161, 141, 175, 171, 159, 237, 179 }, new byte[] { 204, 94, 81, 21, 72, 75, 20, 233, 155, 140, 245, 226, 168, 195, 60, 72, 150, 108, 203, 91, 63, 106, 206, 111, 224, 5, 49, 226, 84, 14, 219, 68, 114, 163, 250, 171, 74, 251, 200, 134, 125, 75, 120, 123, 10, 82, 66, 53, 95, 35, 50, 48, 50, 78, 212, 123, 245, 40, 244, 159, 133, 84, 18, 145, 98, 82, 171, 17, 6, 32, 79, 173, 48, 0, 236, 109, 84, 207, 136, 14, 107, 1, 139, 255, 194, 175, 1, 236, 248, 67, 165, 70, 171, 95, 29, 112, 115, 138, 81, 249, 162, 120, 37, 3, 100, 58, 169, 209, 101, 139, 188, 121, 229, 246, 96, 103, 177, 208, 133, 230, 242, 250, 101, 65, 231, 37, 5, 105 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 42, 105, 186, 199, 92, 15, 136, 48, 231, 186, 67, 40, 52, 222, 212, 8, 17, 35, 253, 188, 244, 54, 28, 149, 55, 93, 147, 36, 52, 4, 245, 132, 239, 254, 110, 185, 101, 207, 230, 17, 174, 161, 8, 106, 105, 139, 106, 43, 108, 34, 163, 218, 159, 102, 166, 96, 175, 161, 141, 175, 171, 159, 237, 179 }, new byte[] { 204, 94, 81, 21, 72, 75, 20, 233, 155, 140, 245, 226, 168, 195, 60, 72, 150, 108, 203, 91, 63, 106, 206, 111, 224, 5, 49, 226, 84, 14, 219, 68, 114, 163, 250, 171, 74, 251, 200, 134, 125, 75, 120, 123, 10, 82, 66, 53, 95, 35, 50, 48, 50, 78, 212, 123, 245, 40, 244, 159, 133, 84, 18, 145, 98, 82, 171, 17, 6, 32, 79, 173, 48, 0, 236, 109, 84, 207, 136, 14, 107, 1, 139, 255, 194, 175, 1, 236, 248, 67, 165, 70, 171, 95, 29, 112, 115, 138, 81, 249, 162, 120, 37, 3, 100, 58, 169, 209, 101, 139, 188, 121, 229, 246, 96, 103, 177, 208, 133, 230, 242, 250, 101, 65, 231, 37, 5, 105 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 42, 105, 186, 199, 92, 15, 136, 48, 231, 186, 67, 40, 52, 222, 212, 8, 17, 35, 253, 188, 244, 54, 28, 149, 55, 93, 147, 36, 52, 4, 245, 132, 239, 254, 110, 185, 101, 207, 230, 17, 174, 161, 8, 106, 105, 139, 106, 43, 108, 34, 163, 218, 159, 102, 166, 96, 175, 161, 141, 175, 171, 159, 237, 179 }, new byte[] { 204, 94, 81, 21, 72, 75, 20, 233, 155, 140, 245, 226, 168, 195, 60, 72, 150, 108, 203, 91, 63, 106, 206, 111, 224, 5, 49, 226, 84, 14, 219, 68, 114, 163, 250, 171, 74, 251, 200, 134, 125, 75, 120, 123, 10, 82, 66, 53, 95, 35, 50, 48, 50, 78, 212, 123, 245, 40, 244, 159, 133, 84, 18, 145, 98, 82, 171, 17, 6, 32, 79, 173, 48, 0, 236, 109, 84, 207, 136, 14, 107, 1, 139, 255, 194, 175, 1, 236, 248, 67, 165, 70, 171, 95, 29, 112, 115, 138, 81, 249, 162, 120, 37, 3, 100, 58, 169, 209, 101, 139, 188, 121, 229, 246, 96, 103, 177, 208, 133, 230, 242, 250, 101, 65, 231, 37, 5, 105 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 42, 105, 186, 199, 92, 15, 136, 48, 231, 186, 67, 40, 52, 222, 212, 8, 17, 35, 253, 188, 244, 54, 28, 149, 55, 93, 147, 36, 52, 4, 245, 132, 239, 254, 110, 185, 101, 207, 230, 17, 174, 161, 8, 106, 105, 139, 106, 43, 108, 34, 163, 218, 159, 102, 166, 96, 175, 161, 141, 175, 171, 159, 237, 179 }, new byte[] { 204, 94, 81, 21, 72, 75, 20, 233, 155, 140, 245, 226, 168, 195, 60, 72, 150, 108, 203, 91, 63, 106, 206, 111, 224, 5, 49, 226, 84, 14, 219, 68, 114, 163, 250, 171, 74, 251, 200, 134, 125, 75, 120, 123, 10, 82, 66, 53, 95, 35, 50, 48, 50, 78, 212, 123, 245, 40, 244, 159, 133, 84, 18, 145, 98, 82, 171, 17, 6, 32, 79, 173, 48, 0, 236, 109, 84, 207, 136, 14, 107, 1, 139, 255, 194, 175, 1, 236, 248, 67, 165, 70, 171, 95, 29, 112, 115, 138, 81, 249, 162, 120, 37, 3, 100, 58, 169, 209, 101, 139, 188, 121, 229, 246, 96, 103, 177, 208, 133, 230, 242, 250, 101, 65, 231, 37, 5, 105 } });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 4, 30, 13, 28, 34, 937, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 42, 105, 186, 199, 92, 15, 136, 48, 231, 186, 67, 40, 52, 222, 212, 8, 17, 35, 253, 188, 244, 54, 28, 149, 55, 93, 147, 36, 52, 4, 245, 132, 239, 254, 110, 185, 101, 207, 230, 17, 174, 161, 8, 106, 105, 139, 106, 43, 108, 34, 163, 218, 159, 102, 166, 96, 175, 161, 141, 175, 171, 159, 237, 179 }, new byte[] { 204, 94, 81, 21, 72, 75, 20, 233, 155, 140, 245, 226, 168, 195, 60, 72, 150, 108, 203, 91, 63, 106, 206, 111, 224, 5, 49, 226, 84, 14, 219, 68, 114, 163, 250, 171, 74, 251, 200, 134, 125, 75, 120, 123, 10, 82, 66, 53, 95, 35, 50, 48, 50, 78, 212, 123, 245, 40, 244, 159, 133, 84, 18, 145, 98, 82, 171, 17, 6, 32, 79, 173, 48, 0, 236, 109, 84, 207, 136, 14, 107, 1, 139, 255, 194, 175, 1, 236, 248, 67, 165, 70, 171, 95, 29, 112, 115, 138, 81, 249, 162, 120, 37, 3, 100, 58, 169, 209, 101, 139, 188, 121, 229, 246, 96, 103, 177, 208, 133, 230, 242, 250, 101, 65, 231, 37, 5, 105 } });
        }
    }
}
