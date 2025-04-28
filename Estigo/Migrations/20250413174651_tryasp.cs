using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class tryasp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "10cc3ae8-7d17-45b2-b71e-5cdae5b9e688", "e70b85b3-172e-4c7e-b4b9-1e314f36fe29", "https://estigo.tryasp.net/mahmoud.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "1157c9a6-435c-4a99-8d30-003b73dfa765", "fb7c3567-b557-4ad4-8a05-2cc637f69216", "https://estigo.tryasp.net/f.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "3ff3012a-45e4-47d0-8b76-2232bc7c92a0", "509dfffb-851c-4630-ad0f-4a4a60d968e1", "https://estigo.tryasp.net/sarah.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "3aa1f434-3895-44d5-b042-69e3ac385c87", "a128ae87-fed7-4a03-bd08-867ea55142a1", "https://estigo.tryasp.net/amira.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "4ebaefd3-3d63-45e1-bd6a-977697219b40", "e98d6cda-a439-418b-b365-8cee2d372f97", "https://estigo.tryasp.net/f.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "74899b6d-adcd-4faa-8966-748dfdcf6d04", "b0f1d3ab-d40a-4131-9a63-dacd53e07990", "https://estigo.tryasp.net/b.jpeg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "7faee7a9-245b-4f39-b169-c3750e124147", "14f96850-b33f-47c2-ba84-d6e3290ea8be", "https://estigo.tryasp.net/g.jpeg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "f368dd7e-0e7b-4224-bf5c-515d492d1f65", "c264d932-51cc-4d74-9c04-6e4c9c6ab217", "https://estigo.tryasp.net/q.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "7bfb639c-1213-42e6-89f0-9d5ccc7a7e21", "0a235f88-1704-4edc-8ede-45e09fb3d519", "https://estigo.tryasp.net/b.jpeg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "ba76a68f-ada4-4355-a130-113fae8768f1", "a8eded4d-7997-4022-a423-4dceabe6609c", "https://estigo.tryasp.net/c.jpeg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "1aad727b-3a86-4533-b208-228de4179d2a", "928c6c1a-c8f2-40fd-9c65-8178dfd78841", "https://estigo.tryasp.net/d.jpeg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "647ebb60-26e9-4d35-ba72-783f1957babc", "aa9caec1-30df-4d2f-b1cb-74832a7c4dd1", "https://estigo.tryasp.net/f.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "d191b322-7125-42d8-b032-898548eb1ce3", "610939a9-443e-4c07-9e46-a4b5b65bcb22", "https://estigo.tryasp.net/m.jpg" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 1,
                column: "Logo",
                value: "https://estigo.tryasp.net/algebra.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 2,
                column: "Logo",
                value: "https://estigo.tryasp.net/calculas.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 3,
                column: "Logo",
                value: "https://estigo.tryasp.net/geo.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 4,
                column: "Logo",
                value: "https://estigo.tryasp.net/trig.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 5,
                column: "Logo",
                value: "https://estigo.tryasp.net/stat.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 6,
                column: "Logo",
                value: "https://estigo.tryasp.net/prob.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 7,
                column: "Logo",
                value: "https://estigo.tryasp.net/disc.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 8,
                column: "Logo",
                value: "https://estigo.tryasp.net/mecha.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 9,
                column: "Logo",
                value: "https://estigo.tryasp.net/elec.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 10,
                column: "Logo",
                value: "https://estigo.tryasp.net/iron.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 11,
                column: "Logo",
                value: "https://estigo.tryasp.net/optics.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 12,
                column: "Logo",
                value: "https://estigo.tryasp.net/thermo.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 13,
                column: "Logo",
                value: "https://estigo.tryasp.net/quant.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 14,
                column: "Logo",
                value: "https://estigo.tryasp.net/rela.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 15,
                column: "Logo",
                value: "https://estigo.tryasp.net/cell.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 16,
                column: "Logo",
                value: "https://estigo.tryasp.net/gena.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 17,
                column: "Logo",
                value: "https://estigo.tryasp.net/move.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 18,
                column: "Logo",
                value: "https://estigo.tryasp.net/eco.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 19,
                column: "Logo",
                value: "https://estigo.tryasp.net/elec.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 20,
                column: "Logo",
                value: "https://estigo.tryasp.net/zoo.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 21,
                column: "Logo",
                value: "https://estigo.tryasp.net/micro.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 22,
                column: "Logo",
                value: "https://estigo.tryasp.net/organic.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 23,
                column: "Logo",
                value: "https://estigo.tryasp.net/inorganic.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 24,
                column: "Logo",
                value: "https://estigo.tryasp.net/physChem.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 25,
                column: "Logo",
                value: "https://estigo.tryasp.net/analyt.png");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 26,
                column: "Logo",
                value: "https://estigo.tryasp.net/biochem.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 27,
                column: "Logo",
                value: "https://estigo.tryasp.net/env.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 28,
                column: "Logo",
                value: "https://estigo.tryasp.net/theo.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 29,
                column: "Logo",
                value: "https://estigo.tryasp.net/lit.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 30,
                column: "Logo",
                value: "https://estigo.tryasp.net/write.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 31,
                column: "Logo",
                value: "https://estigo.tryasp.net/gram.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 32,
                column: "Logo",
                value: "https://estigo.tryasp.net/poe.png");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 33,
                column: "Logo",
                value: "https://estigo.tryasp.net/drama.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 34,
                column: "Logo",
                value: "https://estigo.tryasp.net/fiction.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 35,
                column: "Logo",
                value: "https://estigo.tryasp.net/nonfic.jpg");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 1,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 2,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 3,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 4,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 5,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 6,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 7,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 8,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 9,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 10,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 11,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 12,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 13,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 14,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 15,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 16,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 17,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 18,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 19,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 20,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 21,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 22,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 23,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 24,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 25,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 26,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 27,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 28,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 29,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 30,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 31,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 32,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 33,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 34,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 35,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 36,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 37,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 38,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 39,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 40,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 41,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 42,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 43,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 44,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 45,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 46,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 47,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 48,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 49,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 50,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 51,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 52,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 53,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 54,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 55,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 56,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 57,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 58,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 59,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 60,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 61,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 62,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 63,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 64,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 65,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 66,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 67,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 68,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 69,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 70,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 71,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 72,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 73,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 74,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 75,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 76,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 77,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 78,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 79,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 80,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 81,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 82,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 83,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 84,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 85,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 86,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 87,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 88,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 89,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 90,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 91,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 92,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 93,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 94,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 95,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 96,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 97,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 98,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 99,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 100,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 101,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 102,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 103,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 104,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 105,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 106,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 107,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 108,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 109,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 110,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 111,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 112,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 113,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 114,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 115,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 116,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 117,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 118,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 119,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 120,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 121,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 122,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 123,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 124,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 125,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 126,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 127,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 128,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 129,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 130,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 131,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 132,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 133,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 134,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 135,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 136,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 137,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 138,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 139,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 140,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 141,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 142,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 143,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 144,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 145,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 146,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 147,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 148,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 149,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 150,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 151,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 152,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 153,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 154,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 155,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 156,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 157,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 158,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 159,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 160,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 161,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 162,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 163,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 164,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 165,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 166,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 167,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 168,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 169,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 170,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 171,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 172,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 173,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 174,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 175,
                column: "lessonVideo",
                value: "https://estigo.tryasp.net/vv.mp4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "c0834eda-02a8-499c-bc74-7b2db53980d7", "37c1f6ea-e105-426a-840b-63a4062c1639", "https://est.runasp.net/mahmoud.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "b2be1683-b1d0-4dd4-b06f-4467e292230c", "12369e3e-6603-429e-9df7-13dc00ca41c2", "https://est.runasp.net/f.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "7c98d0ee-6436-4c9f-8762-dbba4d7c6f05", "881e4c19-43b3-45df-8abc-2179112738ca", "https://est.runasp.net/sarah.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "e267fd0e-f8d1-4fd6-be00-3d4c73724c2c", "89c10231-4c18-4d26-a3ee-3a3ed1af3a5d", "https://est.runasp.net/amira.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "cbea8d64-9cc1-4867-83c7-2150d8cdd1c6", "fb34e2a0-75c3-42d7-b64d-e019c405b411", "https://est.runasp.net/f.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "8145a249-5612-4174-b1f0-90ac8c17abc0", "16b92562-8471-4815-bbfc-821a513f913c", "https://est.runasp.net/b.jpeg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "3b4acf27-3fde-46d6-88dc-b5ca0995a110", "17360548-8652-4e15-a431-99aa0b78cefe", "https://est.runasp.net/g.jpeg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "eca2c5d0-033b-4634-93c3-ba3c7c7504cb", "b778603c-e9ce-4957-b712-962385e5af8b", "https://est.runasp.net/q.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "bf2a0b3f-3fb8-48c9-9506-2e02908af658", "7b2bd4db-2ee4-40b5-aaf3-3796d0a11a0a", "https://est.runasp.net/b.jpeg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "be9ff1d1-3636-4048-9879-7d3e1bafd7c5", "fc39008a-5950-48c9-981a-af2ebfc6d11c", "https://est.runasp.net/c.jpeg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "d079fcb6-585a-41b7-b9f1-9cfa1ae24ac4", "88cda5ed-2204-4196-ae1f-fd2b14ea984a", "https://est.runasp.net/d.jpeg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "39195986-70ed-453b-bf06-184a7587b79f", "8750deb0-dfd0-4dcb-ab22-605fa84c18e4", "https://est.runasp.net/f.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "c462b47e-9732-48c3-860e-6b4224f5ccea", "bc11559c-ed05-41bd-9fea-7b9b4ffd5be6", "https://est.runasp.net/m.jpg" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 1,
                column: "Logo",
                value: "https://est.runasp.net/algebra.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 2,
                column: "Logo",
                value: "https://est.runasp.net/calculas.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 3,
                column: "Logo",
                value: "https://est.runasp.net/geo.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 4,
                column: "Logo",
                value: "https://est.runasp.net/trig.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 5,
                column: "Logo",
                value: "https://est.runasp.net/stat.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 6,
                column: "Logo",
                value: "https://est.runasp.net/prob.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 7,
                column: "Logo",
                value: "https://est.runasp.net/disc.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 8,
                column: "Logo",
                value: "https://est.runasp.net/mecha.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 9,
                column: "Logo",
                value: "https://est.runasp.net/elec.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 10,
                column: "Logo",
                value: "https://est.runasp.net/iron.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 11,
                column: "Logo",
                value: "https://est.runasp.net/optics.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 12,
                column: "Logo",
                value: "https://est.runasp.net/thermo.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 13,
                column: "Logo",
                value: "https://est.runasp.net/quant.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 14,
                column: "Logo",
                value: "https://est.runasp.net/rela.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 15,
                column: "Logo",
                value: "https://est.runasp.net/cell.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 16,
                column: "Logo",
                value: "https://est.runasp.net/gena.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 17,
                column: "Logo",
                value: "https://est.runasp.net/move.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 18,
                column: "Logo",
                value: "https://est.runasp.net/eco.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 19,
                column: "Logo",
                value: "https://est.runasp.net/elec.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 20,
                column: "Logo",
                value: "https://est.runasp.net/zoo.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 21,
                column: "Logo",
                value: "https://est.runasp.net/micro.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 22,
                column: "Logo",
                value: "https://est.runasp.net/organic.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 23,
                column: "Logo",
                value: "https://est.runasp.net/inorganic.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 24,
                column: "Logo",
                value: "https://est.runasp.net/physChem.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 25,
                column: "Logo",
                value: "https://est.runasp.net/analyt.png");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 26,
                column: "Logo",
                value: "https://est.runasp.net/biochem.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 27,
                column: "Logo",
                value: "https://est.runasp.net/env.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 28,
                column: "Logo",
                value: "https://est.runasp.net/theo.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 29,
                column: "Logo",
                value: "https://est.runasp.net/lit.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 30,
                column: "Logo",
                value: "https://est.runasp.net/write.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 31,
                column: "Logo",
                value: "https://est.runasp.net/gram.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 32,
                column: "Logo",
                value: "https://est.runasp.net/poe.png");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 33,
                column: "Logo",
                value: "https://est.runasp.net/drama.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 34,
                column: "Logo",
                value: "https://est.runasp.net/fiction.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 35,
                column: "Logo",
                value: "https://est.runasp.net/nonfic.jpg");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 1,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 2,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 3,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 4,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 5,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 6,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 7,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 8,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 9,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 10,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 11,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 12,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 13,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 14,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 15,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 16,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 17,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 18,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 19,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 20,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 21,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 22,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 23,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 24,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 25,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 26,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 27,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 28,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 29,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 30,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 31,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 32,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 33,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 34,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 35,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 36,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 37,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 38,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 39,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 40,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 41,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 42,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 43,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 44,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 45,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 46,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 47,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 48,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 49,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 50,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 51,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 52,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 53,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 54,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 55,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 56,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 57,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 58,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 59,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 60,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 61,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 62,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 63,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 64,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 65,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 66,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 67,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 68,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 69,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 70,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 71,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 72,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 73,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 74,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 75,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 76,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 77,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 78,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 79,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 80,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 81,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 82,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 83,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 84,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 85,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 86,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 87,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 88,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 89,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 90,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 91,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 92,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 93,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 94,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 95,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 96,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 97,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 98,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 99,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 100,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 101,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 102,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 103,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 104,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 105,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 106,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 107,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 108,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 109,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 110,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 111,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 112,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 113,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 114,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 115,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 116,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 117,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 118,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 119,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 120,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 121,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 122,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 123,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 124,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 125,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 126,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 127,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 128,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 129,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 130,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 131,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 132,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 133,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 134,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 135,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 136,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 137,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 138,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 139,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 140,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 141,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 142,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 143,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 144,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 145,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 146,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 147,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 148,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 149,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 150,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 151,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 152,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 153,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 154,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 155,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 156,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 157,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 158,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 159,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 160,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 161,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 162,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 163,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 164,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 165,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 166,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 167,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 168,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 169,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 170,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 171,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 172,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 173,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 174,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 175,
                column: "lessonVideo",
                value: "https://est.runasp.net/vv.mp4");
        }
    }
}
