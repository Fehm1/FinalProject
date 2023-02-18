using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class DoctorTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RedirectURL",
                table: "Doctors");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(9667),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(9449),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(7568),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(7347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(5602),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(5423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(4038),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(3808),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Size",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(1306),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Size",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(1141),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 554, DateTimeKind.Local).AddTicks(9983),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(9172));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 554, DateTimeKind.Local).AddTicks(8670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 554, DateTimeKind.Local).AddTicks(8473),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 554, DateTimeKind.Local).AddTicks(6612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 554, DateTimeKind.Local).AddTicks(6412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "MedicineCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 553, DateTimeKind.Local).AddTicks(9248),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicineCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 553, DateTimeKind.Local).AddTicks(8761),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 553, DateTimeKind.Local).AddTicks(1376),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 553, DateTimeKind.Local).AddTicks(1001),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 552, DateTimeKind.Local).AddTicks(6957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 552, DateTimeKind.Local).AddTicks(6577),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 551, DateTimeKind.Local).AddTicks(1215),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 551, DateTimeKind.Local).AddTicks(773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "DepartmentImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 551, DateTimeKind.Local).AddTicks(8989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DepartmentImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 551, DateTimeKind.Local).AddTicks(8658),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 550, DateTimeKind.Local).AddTicks(8052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 550, DateTimeKind.Local).AddTicks(7826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 550, DateTimeKind.Local).AddTicks(6016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 550, DateTimeKind.Local).AddTicks(5714),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(2505));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(6311),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(6168),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(4875),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(4727),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(7347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(3407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(3286),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(5423));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(2247),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(2077),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Size",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 690, DateTimeKind.Local).AddTicks(121),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Size",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(9996),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(9306),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 555, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(9172),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 554, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(8204),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 554, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(8055),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 554, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(6812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 554, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(6623),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 554, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "MedicineCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(2672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 553, DateTimeKind.Local).AddTicks(9248));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicineCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(2545),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 553, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(1461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 553, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 689, DateTimeKind.Local).AddTicks(1315),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 553, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(9971),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 552, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(9813),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 552, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.AddColumn<string>(
                name: "RedirectURL",
                table: "Doctors",
                type: "NVarChar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(4901),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 551, DateTimeKind.Local).AddTicks(1215));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(4780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 551, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "DepartmentImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(7464),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 551, DateTimeKind.Local).AddTicks(8989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "DepartmentImages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(7344),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 551, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(3814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 550, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(3690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 550, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(2681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 550, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 12, 20, 42, 31, 688, DateTimeKind.Local).AddTicks(2505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 20, 13, 550, DateTimeKind.Local).AddTicks(5714));
        }
    }
}
