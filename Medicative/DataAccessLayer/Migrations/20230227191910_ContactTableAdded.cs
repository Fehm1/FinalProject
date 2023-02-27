using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class ContactTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 98, DateTimeKind.Local).AddTicks(55),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 73, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(9867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 73, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(8418),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 73, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(8256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 73, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(6756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 73, DateTimeKind.Local).AddTicks(894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(6629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 73, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(5750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 72, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(5623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 72, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(4843),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 72, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(4719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 72, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(3821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 72, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(3694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 72, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(2796),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 72, DateTimeKind.Local).AddTicks(5990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(2638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 72, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(1182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 72, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(1011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 72, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(8461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 72, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(8334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 71, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(7409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 71, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(7281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 71, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(5145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 71, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(4922),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 71, DateTimeKind.Local).AddTicks(6181));

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "NVarChar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "NVarChar(100)", maxLength: 100, nullable: false),
                    Subject = table.Column<string>(type: "NVarChar(100)", maxLength: 100, nullable: false),
                    Message = table.Column<string>(type: "NVarChar(500)", maxLength: 500, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(6198)),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(6327)),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 73, DateTimeKind.Local).AddTicks(4635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 98, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 73, DateTimeKind.Local).AddTicks(4442),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 73, DateTimeKind.Local).AddTicks(2728),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 73, DateTimeKind.Local).AddTicks(2534),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 73, DateTimeKind.Local).AddTicks(894),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 73, DateTimeKind.Local).AddTicks(706),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 72, DateTimeKind.Local).AddTicks(9628),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 72, DateTimeKind.Local).AddTicks(9482),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 72, DateTimeKind.Local).AddTicks(8471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 72, DateTimeKind.Local).AddTicks(8320),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 72, DateTimeKind.Local).AddTicks(7235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 72, DateTimeKind.Local).AddTicks(7075),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 72, DateTimeKind.Local).AddTicks(5990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 72, DateTimeKind.Local).AddTicks(5784),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 72, DateTimeKind.Local).AddTicks(3833),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 72, DateTimeKind.Local).AddTicks(3610),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 72, DateTimeKind.Local).AddTicks(162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 71, DateTimeKind.Local).AddTicks(9963),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 71, DateTimeKind.Local).AddTicks(8716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 71, DateTimeKind.Local).AddTicks(8539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 71, DateTimeKind.Local).AddTicks(6535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 25, 18, 47, 56, 71, DateTimeKind.Local).AddTicks(6181),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(4922));
        }
    }
}
