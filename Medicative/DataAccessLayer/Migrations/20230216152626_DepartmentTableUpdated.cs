using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class DepartmentTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RedirectURL",
                table: "Departments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 470, DateTimeKind.Local).AddTicks(1619),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 470, DateTimeKind.Local).AddTicks(1334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(8771),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(8475),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(6133),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(5973),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(4753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(4551),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Size",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(1991),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Size",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(1766),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(209),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 554, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(8679),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 554, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(8424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 554, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(7095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 554, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(6953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 554, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "MedicineCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(2452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 553, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicineCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(2232),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 553, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 553, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(465),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 553, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(8609),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 552, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(8377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 552, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(1229),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 551, DateTimeKind.Local).AddTicks(1215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(1080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 551, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "DepartmentImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(5061),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 551, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DepartmentImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(4896),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 551, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 466, DateTimeKind.Local).AddTicks(9972),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 550, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 466, DateTimeKind.Local).AddTicks(9817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 550, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 466, DateTimeKind.Local).AddTicks(8449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 550, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 466, DateTimeKind.Local).AddTicks(8205),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 550, DateTimeKind.Local).AddTicks(5714));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(9667),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 470, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(9449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 470, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(7568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(7347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(5602),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(5423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(4038),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(3808),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Size",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(1306),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Size",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(1141),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 554, DateTimeKind.Local).AddTicks(9983),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 469, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 554, DateTimeKind.Local).AddTicks(8670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 554, DateTimeKind.Local).AddTicks(8473),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 554, DateTimeKind.Local).AddTicks(6612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 554, DateTimeKind.Local).AddTicks(6412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "MedicineCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 553, DateTimeKind.Local).AddTicks(9248),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicineCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 553, DateTimeKind.Local).AddTicks(8761),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 553, DateTimeKind.Local).AddTicks(1376),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 553, DateTimeKind.Local).AddTicks(1001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 468, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 552, DateTimeKind.Local).AddTicks(6957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 552, DateTimeKind.Local).AddTicks(6577),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 551, DateTimeKind.Local).AddTicks(1215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 551, DateTimeKind.Local).AddTicks(773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.AddColumn<string>(
                name: "RedirectURL",
                table: "Departments",
                type: "NVarChar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "DepartmentImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 551, DateTimeKind.Local).AddTicks(8989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DepartmentImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 551, DateTimeKind.Local).AddTicks(8658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 467, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 550, DateTimeKind.Local).AddTicks(8052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 466, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 550, DateTimeKind.Local).AddTicks(7826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 466, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 550, DateTimeKind.Local).AddTicks(6016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 466, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 550, DateTimeKind.Local).AddTicks(5714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 26, 26, 466, DateTimeKind.Local).AddTicks(8205));
        }
    }
}
