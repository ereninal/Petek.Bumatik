﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Petek.BUmatik.DataAccess.Migrations
{
    public partial class CreateTransactionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StudentId = table.Column<int>(type: "integer", nullable: false),
                    ParentId = table.Column<int>(type: "integer", nullable: false),
                    MenuTypeId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedUserId = table.Column<int>(type: "integer", nullable: true),
                    ModifiedUserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_MenuTypes_MenuTypeId",
                        column: x => x.MenuTypeId,
                        principalTable: "MenuTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 5, 36, 785, DateTimeKind.Local).AddTicks(4609));

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

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "IsDeleted", "MenuTypeId", "ModifiedDate", "ModifiedUserId", "ParentId", "StudentId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 1, null, null, 1, 1 },
                    { 6, new DateTime(2021, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 2, null, null, 1, 2 },
                    { 5, new DateTime(2021, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 2, null, null, 1, 1 },
                    { 4, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 2, null, null, 1, 4 },
                    { 3, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 1, null, null, 1, 3 },
                    { 2, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, false, 2, null, null, 1, 2 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_MenuTypeId",
                table: "Transactions",
                column: "MenuTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ParentId",
                table: "Transactions",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_StudentId",
                table: "Transactions",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new byte[] { 142, 214, 61, 213, 198, 241, 121, 170, 144, 105, 146, 203, 207, 99, 168, 18, 22, 125, 62, 252, 197, 41, 45, 54, 180, 107, 157, 89, 9, 35, 218, 75, 0, 24, 23, 243, 60, 253, 199, 254, 169, 184, 83, 174, 30, 207, 59, 135, 115, 91, 100, 193, 219, 235, 196, 20, 71, 26, 250, 192, 187, 130, 118, 245 }, new byte[] { 37, 255, 246, 60, 115, 173, 86, 181, 5, 79, 77, 226, 221, 61, 133, 104, 127, 210, 112, 223, 42, 99, 85, 15, 121, 10, 22, 174, 112, 53, 74, 84, 201, 43, 27, 34, 234, 138, 169, 239, 252, 34, 112, 83, 195, 193, 218, 212, 149, 28, 73, 159, 137, 144, 76, 26, 47, 25, 17, 156, 159, 216, 102, 36, 238, 226, 93, 142, 51, 64, 184, 81, 186, 211, 148, 39, 154, 209, 12, 88, 141, 131, 252, 240, 142, 154, 14, 117, 207, 202, 96, 26, 104, 87, 198, 208, 250, 194, 97, 137, 73, 154, 50, 131, 98, 44, 214, 110, 112, 90, 100, 200, 215, 93, 156, 23, 154, 156, 13, 48, 60, 140, 163, 179, 178, 60, 84, 6 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new byte[] { 142, 214, 61, 213, 198, 241, 121, 170, 144, 105, 146, 203, 207, 99, 168, 18, 22, 125, 62, 252, 197, 41, 45, 54, 180, 107, 157, 89, 9, 35, 218, 75, 0, 24, 23, 243, 60, 253, 199, 254, 169, 184, 83, 174, 30, 207, 59, 135, 115, 91, 100, 193, 219, 235, 196, 20, 71, 26, 250, 192, 187, 130, 118, 245 }, new byte[] { 37, 255, 246, 60, 115, 173, 86, 181, 5, 79, 77, 226, 221, 61, 133, 104, 127, 210, 112, 223, 42, 99, 85, 15, 121, 10, 22, 174, 112, 53, 74, 84, 201, 43, 27, 34, 234, 138, 169, 239, 252, 34, 112, 83, 195, 193, 218, 212, 149, 28, 73, 159, 137, 144, 76, 26, 47, 25, 17, 156, 159, 216, 102, 36, 238, 226, 93, 142, 51, 64, 184, 81, 186, 211, 148, 39, 154, 209, 12, 88, 141, 131, 252, 240, 142, 154, 14, 117, 207, 202, 96, 26, 104, 87, 198, 208, 250, 194, 97, 137, 73, 154, 50, 131, 98, 44, 214, 110, 112, 90, 100, 200, 215, 93, 156, 23, 154, 156, 13, 48, 60, 140, 163, 179, 178, 60, 84, 6 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new byte[] { 142, 214, 61, 213, 198, 241, 121, 170, 144, 105, 146, 203, 207, 99, 168, 18, 22, 125, 62, 252, 197, 41, 45, 54, 180, 107, 157, 89, 9, 35, 218, 75, 0, 24, 23, 243, 60, 253, 199, 254, 169, 184, 83, 174, 30, 207, 59, 135, 115, 91, 100, 193, 219, 235, 196, 20, 71, 26, 250, 192, 187, 130, 118, 245 }, new byte[] { 37, 255, 246, 60, 115, 173, 86, 181, 5, 79, 77, 226, 221, 61, 133, 104, 127, 210, 112, 223, 42, 99, 85, 15, 121, 10, 22, 174, 112, 53, 74, 84, 201, 43, 27, 34, 234, 138, 169, 239, 252, 34, 112, 83, 195, 193, 218, 212, 149, 28, 73, 159, 137, 144, 76, 26, 47, 25, 17, 156, 159, 216, 102, 36, 238, 226, 93, 142, 51, 64, 184, 81, 186, 211, 148, 39, 154, 209, 12, 88, 141, 131, 252, 240, 142, 154, 14, 117, 207, 202, 96, 26, 104, 87, 198, 208, 250, 194, 97, 137, 73, 154, 50, 131, 98, 44, 214, 110, 112, 90, 100, 200, 215, 93, 156, 23, 154, 156, 13, 48, 60, 140, 163, 179, 178, 60, 84, 6 } });

            migrationBuilder.UpdateData(
                table: "AdminUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new byte[] { 142, 214, 61, 213, 198, 241, 121, 170, 144, 105, 146, 203, 207, 99, 168, 18, 22, 125, 62, 252, 197, 41, 45, 54, 180, 107, 157, 89, 9, 35, 218, 75, 0, 24, 23, 243, 60, 253, 199, 254, 169, 184, 83, 174, 30, 207, 59, 135, 115, 91, 100, 193, 219, 235, 196, 20, 71, 26, 250, 192, 187, 130, 118, 245 }, new byte[] { 37, 255, 246, 60, 115, 173, 86, 181, 5, 79, 77, 226, 221, 61, 133, 104, 127, 210, 112, 223, 42, 99, 85, 15, 121, 10, 22, 174, 112, 53, 74, 84, 201, 43, 27, 34, 234, 138, 169, 239, 252, 34, 112, 83, 195, 193, 218, 212, 149, 28, 73, 159, 137, 144, 76, 26, 47, 25, 17, 156, 159, 216, 102, 36, 238, 226, 93, 142, 51, 64, 184, 81, 186, 211, 148, 39, 154, 209, 12, 88, 141, 131, 252, 240, 142, 154, 14, 117, 207, 202, 96, 26, 104, 87, 198, 208, 250, 194, 97, 137, 73, 154, 50, 131, 98, 44, 214, 110, 112, 90, 100, 200, 215, 93, 156, 23, 154, 156, 13, 48, 60, 140, 163, 179, 178, 60, 84, 6 } });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "AutomatInfo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "LastRepairDate", "StartDate" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "AutomatItemInfos",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "AutomatItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "ItemCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "MenuTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "MenuTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093), new byte[] { 142, 214, 61, 213, 198, 241, 121, 170, 144, 105, 146, 203, 207, 99, 168, 18, 22, 125, 62, 252, 197, 41, 45, 54, 180, 107, 157, 89, 9, 35, 218, 75, 0, 24, 23, 243, 60, 253, 199, 254, 169, 184, 83, 174, 30, 207, 59, 135, 115, 91, 100, 193, 219, 235, 196, 20, 71, 26, 250, 192, 187, 130, 118, 245 }, new byte[] { 37, 255, 246, 60, 115, 173, 86, 181, 5, 79, 77, 226, 221, 61, 133, 104, 127, 210, 112, 223, 42, 99, 85, 15, 121, 10, 22, 174, 112, 53, 74, 84, 201, 43, 27, 34, 234, 138, 169, 239, 252, 34, 112, 83, 195, 193, 218, 212, 149, 28, 73, 159, 137, 144, 76, 26, 47, 25, 17, 156, 159, 216, 102, 36, 238, 226, 93, 142, 51, 64, 184, 81, 186, 211, 148, 39, 154, 209, 12, 88, 141, 131, 252, 240, 142, 154, 14, 117, 207, 202, 96, 26, 104, 87, 198, 208, 250, 194, 97, 137, 73, 154, 50, 131, 98, 44, 214, 110, 112, 90, 100, 200, 215, 93, 156, 23, 154, 156, 13, 48, 60, 140, 163, 179, 178, 60, 84, 6 } });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "SelectedMenuItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "StudentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 9, 16, 8, 2, 29, 357, DateTimeKind.Local).AddTicks(9093));
        }
    }
}
