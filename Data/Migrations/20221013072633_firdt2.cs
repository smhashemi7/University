using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class firdt2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseTeacher_DarsHa_CoursesId",
                table: "CourseTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_DaneshAmooz_StudentId",
                table: "StudentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_DarsHa_CourseId",
                table: "StudentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DarsHa",
                table: "DarsHa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DaneshAmooz",
                table: "DaneshAmooz");

            migrationBuilder.RenameTable(
                name: "DarsHa",
                newName: "Courses");

            migrationBuilder.RenameTable(
                name: "DaneshAmooz",
                newName: "Students");

            migrationBuilder.RenameColumn(
                name: "TarikhVorood",
                table: "Students",
                newName: "EntryDate");

            migrationBuilder.RenameColumn(
                name: "Esm",
                table: "Students",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "CodeDanehjooei",
                table: "Students",
                newName: "StudentCode");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EntryDate",
                table: "Students",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTeacher_Courses_CoursesId",
                table: "CourseTeacher",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Courses_CourseId",
                table: "StudentCourse",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Students_StudentId",
                table: "StudentCourse",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseTeacher_Courses_CoursesId",
                table: "CourseTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Courses_CourseId",
                table: "StudentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Students_StudentId",
                table: "StudentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "DaneshAmooz");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "DarsHa");

            migrationBuilder.RenameColumn(
                name: "StudentCode",
                table: "DaneshAmooz",
                newName: "CodeDanehjooei");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "DaneshAmooz",
                newName: "Esm");

            migrationBuilder.RenameColumn(
                name: "EntryDate",
                table: "DaneshAmooz",
                newName: "TarikhVorood");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TarikhVorood",
                table: "DaneshAmooz",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DaneshAmooz",
                table: "DaneshAmooz",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DarsHa",
                table: "DarsHa",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTeacher_DarsHa_CoursesId",
                table: "CourseTeacher",
                column: "CoursesId",
                principalTable: "DarsHa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_DaneshAmooz_StudentId",
                table: "StudentCourse",
                column: "StudentId",
                principalTable: "DaneshAmooz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_DarsHa_CourseId",
                table: "StudentCourse",
                column: "CourseId",
                principalTable: "DarsHa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
