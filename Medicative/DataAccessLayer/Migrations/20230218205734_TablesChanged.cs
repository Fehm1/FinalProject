using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class TablesChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 880, DateTimeKind.Local).AddTicks(3024),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 159, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 880, DateTimeKind.Local).AddTicks(2866),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 159, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 880, DateTimeKind.Local).AddTicks(1468),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 158, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 880, DateTimeKind.Local).AddTicks(1279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 158, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(9912),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 158, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(9788),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 158, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(8743),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(8583),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Size",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(7110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Size",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(6962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(6278),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(6119),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(5225),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 156, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(5102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 156, DateTimeKind.Local).AddTicks(7387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(4232),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 156, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(4117),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 156, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "MedicineCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(1138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicineCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(1005),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(165),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(4),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 878, DateTimeKind.Local).AddTicks(8490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 878, DateTimeKind.Local).AddTicks(8323),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 878, DateTimeKind.Local).AddTicks(5640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 878, DateTimeKind.Local).AddTicks(5517),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.AddColumn<string>(
                name: "DetailImage",
                table: "Departments",
                type: "NVarChar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PosterImage",
                table: "Departments",
                type: "NVarChar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 878, DateTimeKind.Local).AddTicks(4580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 878, DateTimeKind.Local).AddTicks(4452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(7183));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 878, DateTimeKind.Local).AddTicks(3450),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 878, DateTimeKind.Local).AddTicks(3272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(4826));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetailImage",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "PosterImage",
                table: "Departments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 159, DateTimeKind.Local).AddTicks(3736),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 880, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Trainings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 159, DateTimeKind.Local).AddTicks(3157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 880, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 158, DateTimeKind.Local).AddTicks(8052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 880, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Specializations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 158, DateTimeKind.Local).AddTicks(7444),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 880, DateTimeKind.Local).AddTicks(1279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 158, DateTimeKind.Local).AddTicks(2490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Sliders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 158, DateTimeKind.Local).AddTicks(2203),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(9677),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Skills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(9222),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Size",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(3591),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Size",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(3258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(1065),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 157, DateTimeKind.Local).AddTicks(749),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 156, DateTimeKind.Local).AddTicks(7909),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Professions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 156, DateTimeKind.Local).AddTicks(7387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 156, DateTimeKind.Local).AddTicks(3753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 156, DateTimeKind.Local).AddTicks(3536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "MedicineCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(9988),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "MedicineCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(9823),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(8857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Educations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(8655),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 879, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(6804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 878, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Doctors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(6590),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 878, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(8760),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 878, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(8564),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 878, DateTimeKind.Local).AddTicks(5517));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(7354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 878, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Counters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(7183),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 878, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(5358),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 878, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedTime",
                table: "Certifications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 154, DateTimeKind.Local).AddTicks(4826),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 2, 19, 0, 57, 33, 878, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.CreateTable(
                name: "DepartmentImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeparmentId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(2999)),
                    ImageURL = table.Column<string>(type: "NVarChar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsPoster = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 2, 16, 19, 56, 43, 155, DateTimeKind.Local).AddTicks(3154))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DepartmentImages_Departments_DeparmentId",
                        column: x => x.DeparmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentImages_DeparmentId",
                table: "DepartmentImages",
                column: "DeparmentId");
        }
    }
}
