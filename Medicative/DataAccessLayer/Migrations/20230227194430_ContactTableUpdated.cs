using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class ContactTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(8052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 98, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(7807),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(6339),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(6161),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(4584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(4451),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(3489),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(3358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(2498),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(2368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(1458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(1319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(395),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(226),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 141, DateTimeKind.Local).AddTicks(8643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 141, DateTimeKind.Local).AddTicks(8444),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 141, DateTimeKind.Local).AddTicks(5561),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 141, DateTimeKind.Local).AddTicks(5421),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 141, DateTimeKind.Local).AddTicks(4436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 141, DateTimeKind.Local).AddTicks(4300),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 141, DateTimeKind.Local).AddTicks(3439),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Contacts",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 141, DateTimeKind.Local).AddTicks(3302),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(6198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 141, DateTimeKind.Local).AddTicks(2251),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 141, DateTimeKind.Local).AddTicks(1994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(4922));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 98, DateTimeKind.Local).AddTicks(55),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(9867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(8418),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(8256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(6161));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(6756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(6629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(5750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Settings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(5623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(4843),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(4719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(3821),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(3694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(2796),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(2638),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 142, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(1182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 141, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 97, DateTimeKind.Local).AddTicks(1011),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 141, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(8461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 141, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(8334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 141, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(7409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 141, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(7281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 141, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(6327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 141, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "Contacts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(6198),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 141, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(5145),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 141, DateTimeKind.Local).AddTicks(2251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 27, 23, 19, 10, 96, DateTimeKind.Local).AddTicks(4922),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 27, 23, 44, 30, 141, DateTimeKind.Local).AddTicks(1994));
        }
    }
}
