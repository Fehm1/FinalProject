using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class AppUserTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(6311),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 541, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(6168),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 541, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(4875),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 541, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(4727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 541, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(3407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 541, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(3286),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 540, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(2247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 540, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(2077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 540, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Size",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(121),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 540, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Size",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(9996),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 540, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(9306),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 540, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(9172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 540, DateTimeKind.Local).AddTicks(1256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(8204),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 539, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(8055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 539, DateTimeKind.Local).AddTicks(8697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(6812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 539, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(6623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 539, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "MedicineCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(2672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 538, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicineCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(2545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 538, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(1461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 538, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(1315),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 538, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(9971),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 538, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(9813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 538, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(4901),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 537, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(4780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 537, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "DepartmentImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(7464),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 538, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DepartmentImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(7344),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 538, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(3814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 537, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(3690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 537, DateTimeKind.Local).AddTicks(3517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(2681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 537, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(2505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 537, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 541, DateTimeKind.Local).AddTicks(8102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 541, DateTimeKind.Local).AddTicks(7700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 541, DateTimeKind.Local).AddTicks(4358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 541, DateTimeKind.Local).AddTicks(3939),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 541, DateTimeKind.Local).AddTicks(242),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 540, DateTimeKind.Local).AddTicks(9920),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 540, DateTimeKind.Local).AddTicks(7655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 540, DateTimeKind.Local).AddTicks(7187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Size",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 540, DateTimeKind.Local).AddTicks(3622),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Size",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 540, DateTimeKind.Local).AddTicks(3294),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 540, DateTimeKind.Local).AddTicks(1574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 540, DateTimeKind.Local).AddTicks(1256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 539, DateTimeKind.Local).AddTicks(9034),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 539, DateTimeKind.Local).AddTicks(8697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 539, DateTimeKind.Local).AddTicks(6517),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 539, DateTimeKind.Local).AddTicks(6206),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "MedicineCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 538, DateTimeKind.Local).AddTicks(9545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicineCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 538, DateTimeKind.Local).AddTicks(9222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 538, DateTimeKind.Local).AddTicks(7268),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 538, DateTimeKind.Local).AddTicks(6850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 538, DateTimeKind.Local).AddTicks(4756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 538, DateTimeKind.Local).AddTicks(4514),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 537, DateTimeKind.Local).AddTicks(6083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 537, DateTimeKind.Local).AddTicks(5832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "DepartmentImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 538, DateTimeKind.Local).AddTicks(923),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DepartmentImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 538, DateTimeKind.Local).AddTicks(732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 537, DateTimeKind.Local).AddTicks(3801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 537, DateTimeKind.Local).AddTicks(3517),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 537, DateTimeKind.Local).AddTicks(1167),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 17, 33, 20, 537, DateTimeKind.Local).AddTicks(850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);
        }
    }
}
