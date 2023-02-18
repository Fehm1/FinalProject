using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class DepartmentsTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubTitle",
                table: "Departments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 159, DateTimeKind.Local).AddTicks(3736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 470, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 159, DateTimeKind.Local).AddTicks(3157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 470, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 158, DateTimeKind.Local).AddTicks(8052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 158, DateTimeKind.Local).AddTicks(7444),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 158, DateTimeKind.Local).AddTicks(2490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 158, DateTimeKind.Local).AddTicks(2203),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(9677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(9222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Size",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(3591),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Size",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(3258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(1065),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 156, DateTimeKind.Local).AddTicks(7909),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 156, DateTimeKind.Local).AddTicks(7387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 156, DateTimeKind.Local).AddTicks(3753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 156, DateTimeKind.Local).AddTicks(3536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "MedicineCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(9988),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicineCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(9823),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(8857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(8655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(6804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(6590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(8760),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(8564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "DepartmentImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(3154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DepartmentImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(2999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(7354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 466, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(7183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 466, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(5358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 466, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(4826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 466, DateTimeKind.Local).AddTicks(8205));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 470, DateTimeKind.Local).AddTicks(1619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 159, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 470, DateTimeKind.Local).AddTicks(1334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 159, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(8771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 158, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(8475),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 158, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(6133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 158, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(5973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 158, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(4753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(4551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Size",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(1991),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Size",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(1766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(8679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 156, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(8424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 156, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(7095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 156, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(6953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 156, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "MedicineCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(2452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicineCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(2232),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(8609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(8377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(1229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(1080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.AddColumn<string>(
                name: "SubTitle",
                table: "Departments",
                type: "NVarChar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "DepartmentImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(5061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DepartmentImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(4896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 466, DateTimeKind.Local).AddTicks(9972),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 466, DateTimeKind.Local).AddTicks(9817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 466, DateTimeKind.Local).AddTicks(8449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 466, DateTimeKind.Local).AddTicks(8205),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(4826));
        }
    }
}
