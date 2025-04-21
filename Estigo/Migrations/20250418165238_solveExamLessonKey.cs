using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class solveExamLessonKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "examId",
                table: "lessons");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d44b4176-724b-4642-b317-21dad6130672", "1be69dec-5108-4ffd-a0bb-0b00b0462628" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "41906bab-8134-46e4-bcfa-08db1c5d0005", "e6111276-e831-4a97-91a8-9171bcc255d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "01e6b49c-1a6c-49fd-a805-6b38831217e7", "cf52054d-6b07-47fc-b92c-a5fb93b8d33b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2fdf1361-852a-4475-92e8-59e77de60006", "591b31ba-aeb0-4c43-8fed-f0af73848bbb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac4b493c-8508-413f-a408-c58d994c02a7", "954d0dfc-a3e8-439f-bf69-1d2a3cf599f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ad38b01b-939c-424f-b9cc-62d9921c49d7", "18e83609-712f-4579-b05b-0b10285e7304" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8c750a70-21dd-4e5f-adf3-1a4f124d36bb", "cfe0d038-7847-480c-b372-54b93a6b8c14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c2b60f35-8841-45a2-b5e1-f102b682c991", "f76aa551-c26b-40de-be8f-8b3b9b8d7ecc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4fa99a6a-a19e-4ed0-bb16-9b6992427598", "92c1a16d-83c8-4bb0-bc71-553b81b4d0a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8a6c5b93-fd51-413a-a427-89e66d9d65e8", "d7432709-beeb-4196-9c20-6d694873841d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5d28dd68-9eab-4ea2-81e6-0ca8823bfd21", "1ef56621-bf7e-47af-a387-d6e630404bbf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e8ba1c31-ac49-4608-87a6-9831ea4dcb60", "92570a57-dd16-4a09-96e6-0e86357623f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f2e85f12-3cb6-43c5-8a26-ddbdc07e268f", "6dcb756a-cba2-4626-ad39-a1dd28fdc72d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "examId",
                table: "lessons",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "10cc3ae8-7d17-45b2-b71e-5cdae5b9e688", "e70b85b3-172e-4c7e-b4b9-1e314f36fe29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1157c9a6-435c-4a99-8d30-003b73dfa765", "fb7c3567-b557-4ad4-8a05-2cc637f69216" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3ff3012a-45e4-47d0-8b76-2232bc7c92a0", "509dfffb-851c-4630-ad0f-4a4a60d968e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3aa1f434-3895-44d5-b042-69e3ac385c87", "a128ae87-fed7-4a03-bd08-867ea55142a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ebaefd3-3d63-45e1-bd6a-977697219b40", "e98d6cda-a439-418b-b365-8cee2d372f97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "74899b6d-adcd-4faa-8966-748dfdcf6d04", "b0f1d3ab-d40a-4131-9a63-dacd53e07990" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7faee7a9-245b-4f39-b169-c3750e124147", "14f96850-b33f-47c2-ba84-d6e3290ea8be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f368dd7e-0e7b-4224-bf5c-515d492d1f65", "c264d932-51cc-4d74-9c04-6e4c9c6ab217" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7bfb639c-1213-42e6-89f0-9d5ccc7a7e21", "0a235f88-1704-4edc-8ede-45e09fb3d519" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ba76a68f-ada4-4355-a130-113fae8768f1", "a8eded4d-7997-4022-a423-4dceabe6609c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1aad727b-3a86-4533-b208-228de4179d2a", "928c6c1a-c8f2-40fd-9c65-8178dfd78841" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "647ebb60-26e9-4d35-ba72-783f1957babc", "aa9caec1-30df-4d2f-b1cb-74832a7c4dd1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d191b322-7125-42d8-b032-898548eb1ce3", "610939a9-443e-4c07-9e46-a4b5b65bcb22" });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 1,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 2,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 3,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 4,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 5,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 6,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 7,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 8,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 9,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 10,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 11,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 12,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 13,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 14,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 15,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 16,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 17,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 18,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 19,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 20,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 21,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 22,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 23,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 24,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 25,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 26,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 27,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 28,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 29,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 30,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 31,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 32,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 33,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 34,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 35,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 36,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 37,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 38,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 39,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 40,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 41,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 42,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 43,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 44,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 45,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 46,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 47,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 48,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 49,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 50,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 51,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 52,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 53,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 54,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 55,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 56,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 57,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 58,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 59,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 60,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 61,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 62,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 63,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 64,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 65,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 66,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 67,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 68,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 69,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 70,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 71,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 72,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 73,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 74,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 75,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 76,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 77,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 78,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 79,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 80,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 81,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 82,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 83,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 84,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 85,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 86,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 87,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 88,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 89,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 90,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 91,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 92,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 93,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 94,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 95,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 96,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 97,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 98,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 99,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 100,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 101,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 102,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 103,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 104,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 105,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 106,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 107,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 108,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 109,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 110,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 111,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 112,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 113,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 114,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 115,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 116,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 117,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 118,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 119,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 120,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 121,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 122,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 123,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 124,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 125,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 126,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 127,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 128,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 129,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 130,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 131,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 132,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 133,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 134,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 135,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 136,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 137,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 138,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 139,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 140,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 141,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 142,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 143,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 144,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 145,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 146,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 147,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 148,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 149,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 150,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 151,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 152,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 153,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 154,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 155,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 156,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 157,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 158,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 159,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 160,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 161,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 162,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 163,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 164,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 165,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 166,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 167,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 168,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 169,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 170,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 171,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 172,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 173,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 174,
                column: "examId",
                value: null);

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 175,
                column: "examId",
                value: null);
        }
    }
}
