using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class LiveVideo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "lessonVideo",
                table: "lessons",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AddColumn<bool>(
                name: "IsLive",
                table: "lessons",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsLive",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LiveLink",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "501907e7-642f-4fd9-822a-8e1885fa5298", "6e2e4d62-7c36-4685-a0a5-982e0403fa1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fa23d3d2-4f28-41a4-b4c9-c9d45000a0ca", "5c396b81-bd2e-46a8-9310-5569733aacfb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "39607e20-a6af-4d2b-b857-df8d05ef6039", "fdaba976-9dee-4641-99ef-0b15c26756d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "32c234b1-419e-4d70-8f8c-7b1a67ef5d01", "823d135c-253f-426c-9b40-9c69bd14e02c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "354bb1c5-08fd-4698-ab37-0e9d96fa0a3f", "41b834b7-8521-4f93-95b9-a57d8966d544" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0e185ec3-46fc-4091-ad67-288ef3a33ed7", "4c09e649-6f40-4a70-97be-94ee20ef2779" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3ad9db08-0ea2-4627-947b-0258131da131", "d3e1b96f-ffaf-4b1d-9f4a-c193e5df2ab9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0992a02c-ba92-4caf-ab2a-2411253f1f1e", "03c4022a-fb53-4ec4-bb91-1af909f7ea06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "68758145-b19a-44b5-bcb6-39778203d975", "9e823e61-9fbc-44fc-9d64-96064491d356" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c5c0d66f-b3e8-4796-bdd2-fb97524df7f8", "15bc310b-b955-4ef2-90f8-37185cde0418" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2a61cf69-8599-45b0-b9a8-3cf213afadac", "47eb43aa-2f21-4b02-b14d-d2bd04e87526" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "88be9ef0-4ab5-439b-9cee-6a03c4bb37e5", "ded11417-bde0-4c35-a0f8-7e09f89d6dcb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d4953efa-e738-453c-b824-ffbb330aa099", "06a941f0-3d95-4a66-8ed0-19df51fe4ef2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 1,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 2,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 3,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 4,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 5,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 6,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 7,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 8,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 9,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 10,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 11,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 12,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 13,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 14,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 15,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 16,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 17,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 18,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 19,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 20,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 21,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 22,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 23,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 24,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 25,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 26,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 27,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 28,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 29,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 30,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 31,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 32,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 33,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 34,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 35,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 1,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 2,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 3,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 4,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 5,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 6,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 7,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 8,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 9,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 10,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 11,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 12,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 13,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 14,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 15,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 16,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 17,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 18,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 19,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 20,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 21,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 22,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 23,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 24,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 25,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 26,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 27,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 28,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 29,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 30,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 31,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 32,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 33,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 34,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 35,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 36,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 37,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 38,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 39,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 40,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 41,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 42,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 43,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 44,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 45,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 46,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 47,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 48,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 49,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 50,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 51,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 52,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 53,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 54,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 55,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 56,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 57,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 58,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 59,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 60,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 61,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 62,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 63,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 64,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 65,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 66,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 67,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 68,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 69,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 70,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 71,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 72,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 73,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 74,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 75,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 76,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 77,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 78,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 79,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 80,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 81,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 82,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 83,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 84,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 85,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 86,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 87,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 88,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 89,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 90,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 91,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 92,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 93,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 94,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 95,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 96,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 97,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 98,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 99,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 100,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 101,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 102,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 103,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 104,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 105,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 106,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 107,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 108,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 109,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 110,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 111,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 112,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 113,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 114,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 115,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 116,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 117,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 118,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 119,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 120,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 121,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 122,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 123,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 124,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 125,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 126,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 127,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 128,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 129,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 130,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 131,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 132,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 133,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 134,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 135,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 136,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 137,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 138,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 139,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 140,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 141,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 142,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 143,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 144,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 145,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 146,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 147,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 148,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 149,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 150,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 151,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 152,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 153,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 154,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 155,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 156,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 157,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 158,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 159,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 160,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 161,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 162,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 163,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 164,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 165,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 166,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 167,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 168,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 169,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 170,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 171,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 172,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 173,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 174,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 175,
                column: "IsLive",
                value: false);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 176,
                column: "IsLive",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLive",
                table: "lessons");

            migrationBuilder.DropColumn(
                name: "IsLive",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "LiveLink",
                table: "Courses");

            migrationBuilder.AlterColumn<string>(
                name: "lessonVideo",
                table: "lessons",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c8d764cb-aaa3-47ae-b8e7-b829f81487f9", "df124ab1-f82c-4964-a6cf-89a04c5ce3ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a4921a25-145e-4cc5-b142-8fa2a5cb25b0", "16d336de-c3d9-464c-b9d5-2743923a94c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "03b589b8-489e-47b0-932c-d6d003907ba7", "6d48fd35-8f6b-48bb-926a-c5ec6cfccf15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a46996d6-597b-4092-ade3-8c69dbe914cb", "6ba8ddbd-b1b6-42ec-80be-1c6865b3201c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4dd58e96-9d22-4b14-a9fd-9f1de33faace", "e2332e8a-373f-44ad-81c8-f96fc70a2fab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6845d5ea-4383-4ac8-aca6-3ca455354c06", "e1ff1b04-09de-44ee-adc1-36b6c9ec1ed0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "10758ca6-5ec1-4820-aa62-4d3dc10576a6", "91a4bc6d-cef5-46dc-b6fd-419df674964d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "88c03e1c-1c3d-46e1-82ae-b35f104d9409", "d57b5259-5120-4198-9265-48283e51edf7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3096cd73-9e55-44bd-9238-5700642ce594", "c88e9ac9-618d-41a8-8b96-ca6e790c563e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "03c70d72-6428-4b63-9f69-64447d8c60cb", "2ee9e16e-516f-4340-8923-54bfdae1bc09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "83c48b45-4acf-40f5-926c-b5c893b0c96d", "94f45869-5851-4119-a162-95d789ef6ea4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86076b2f-5122-44f4-8851-070dee224d47", "cf652c96-47c3-4c50-aef0-c384c2bf38b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ec3916c1-1abb-4b0e-b002-4e28c43b6d45", "9a01add1-704e-4793-a449-4fdc2e96f431" });
        }
    }
}
