using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class examSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "66b4e0d1-9c9d-4d69-9a49-b6a6c906e866", "7ff3cf52-5fa9-4b0e-a631-ad43c4d25ac4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "955efa34-729c-4673-9005-d4cd1e71b55f", "fe62cd2d-278a-4a9b-8e11-64ba268f319f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8f267377-984e-4e6f-aa70-990f75ae15eb", "e638e928-d9b0-4359-b820-4745a32d282a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bffbacb5-a51d-43a0-9364-4ecdb64811a7", "c55eed99-3b9b-4077-8bbe-156aa0da125d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1c1289b7-6db1-484d-8bb7-b517957ca746", "335da3df-deab-4c8c-ae0a-4bdd9c0f0507" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "37568571-e24e-4ce4-be5a-302337c9052e", "9b0d1d00-3022-4764-873c-50346b2fb7ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "65ed003d-677a-497b-b04d-d2a76753e69c", "9df03c11-78e3-404c-b127-f9c580e8b800" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dbef42c4-e461-4d86-9931-2713d04b2ae7", "86a83a3a-2f7b-4c6d-9591-82b28ff052d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7725931e-1881-4643-8180-4b0c0dc1d358", "a1b20f21-a03a-43d0-996e-6aafd5c29d2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7c86d173-c2a1-4055-a2ef-a23f59bceafc", "7b8cf950-23ce-4a36-a965-6b8806f89c5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d5395bd5-df79-4d39-89b2-022d48db45b2", "2e271b72-3726-47b4-bb25-dcaea113f530" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0b285c5f-9ff7-4ab2-bd29-805b045c3900", "99fb1305-49d3-4ee2-8ee5-c43d0bdfd97f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "364d0e79-6dc6-4452-b9c0-9e4e7158fd9e", "ce48c144-8192-47ca-95a2-3320dabc764a" });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "CreatedAt", "ExamDescription", "ExamTitle", "Grade", "courseId", "lessonId" },
                values: new object[,]
                {
                    { 11, new DateTime(2025, 4, 5, 15, 16, 13, 960, DateTimeKind.Utc).AddTicks(8402), "Test your knowledge of C# basics.", "Exam: Introduction to C#", "Not Graded", 1, 11 },
                    { 12, new DateTime(2025, 4, 5, 15, 16, 13, 960, DateTimeKind.Utc).AddTicks(8970), "Variables and types quiz.", "Exam: Variables and Data Types", "Not Graded", 1, 12 },
                    { 13, new DateTime(2025, 4, 5, 15, 16, 13, 960, DateTimeKind.Utc).AddTicks(8973), "Control flow evaluation.", "Exam: Control Structures", "Not Graded", 1, 13 },
                    { 14, new DateTime(2025, 4, 5, 15, 16, 13, 960, DateTimeKind.Utc).AddTicks(8976), "Function usage test.", "Exam: Functions", "Not Graded", 1, 14 },
                    { 15, new DateTime(2025, 4, 5, 15, 16, 13, 960, DateTimeKind.Utc).AddTicks(8978), "OOP concepts in C#.", "Exam: Classes and Objects", "Not Graded", 1, 15 },
                    { 16, new DateTime(2025, 4, 5, 15, 16, 13, 960, DateTimeKind.Utc).AddTicks(8979), "Test your knowledge of C# basics.", "Exam: Introduction to C#", "Not Graded", 2, 16 },
                    { 17, new DateTime(2025, 4, 5, 15, 16, 13, 960, DateTimeKind.Utc).AddTicks(8981), "Variables and types quiz.", "Exam: Variables and Data Types", "Not Graded", 2, 17 },
                    { 18, new DateTime(2025, 4, 5, 15, 16, 13, 960, DateTimeKind.Utc).AddTicks(8983), "Control flow evaluation.", "Exam: Control Structures", "Not Graded", 2, 18 },
                    { 19, new DateTime(2025, 4, 5, 15, 16, 13, 960, DateTimeKind.Utc).AddTicks(8985), "Function usage test.", "Exam: Functions", "Not Graded", 2, 19 },
                    { 20, new DateTime(2025, 4, 5, 15, 16, 13, 960, DateTimeKind.Utc).AddTicks(8987), "OOP concepts in C#.", "Exam: Classes and Objects", "Not Graded", 2, 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a2620393-ed4f-481f-b8ff-6b53a4e41ffc", "93fb1000-edad-41ef-b664-e5c1ab38f0c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "67ff3dca-6a3c-4b19-beac-04288e8c7d5b", "46c4d5eb-60ec-46b9-a3a5-5bd9de9bc3a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "17254e9b-4b98-44ae-a018-732184843e05", "6751d21c-6ca0-442c-91f6-1f4678203be2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f345c4ed-9281-4fbf-8de5-99c2fb89d1cb", "7e72f7c3-d638-44c4-a734-f2884cefa21f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2c2c7280-ed6a-4e30-acab-7780a4b84411", "ee641b94-7851-4d89-bb53-67c3f144a63a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "685901e4-e620-4448-b665-ea572b268e63", "2dca2192-4d30-431c-b3d1-3d37d418f1cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9e19c2f2-d0e3-4adb-b805-d609593064fc", "a71efa05-e4d4-4e64-a66f-05346c386e5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9b3a2c15-767a-412d-be15-00417e78a91d", "6419cb94-af7f-4fd1-8a0a-d56ac8d317fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "df5e18e0-155c-4bb0-ba1f-2bc7f9cacb91", "709c30bc-a1df-405a-b2eb-273647af5b52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "45105778-3ffb-401f-b486-7f131129108f", "1578507a-d539-415e-be2c-e6528ab1e92e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d15bbe92-f31c-4d08-9c98-21c4a736e431", "904ed165-f569-4092-b22f-f78c6eee17fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0a27b5d8-05ca-47d1-b59d-4026238102a1", "be761521-c5f1-4039-b4db-82722b71201f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "edfdcdb4-ee6e-4b6d-91bc-91cbedc45be5", "81727662-8f99-4c46-94be-2f6e58995d57" });
        }
    }
}
