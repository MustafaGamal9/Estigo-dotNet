using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class seedLesson2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 10);

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

            migrationBuilder.InsertData(
                table: "lessons",
                columns: new[] { "lessonId", "courseId", "examId", "lessonContent", "lessonDescription", "lessonTitle", "lessonVideo" },
                values: new object[,]
                {
                    { 16, 2, null, "This is the content of the lesson.", "This lesson covers the basics of C# programming.", "Introduction to C#", "http://path/to/lesson1_video.mp4" },
                    { 17, 2, null, "This is the content of the lesson.", "Learn about variables and data types in C#.", "C# Variables and Data Types", "http://path/to/lesson2_video.mp4" },
                    { 18, 2, null, "This is the content of the lesson.", "Learn about control structures in C#.", "C# Control Structures", "http://path/to/lesson3_video.mp4" },
                    { 19, 2, null, "This is the content of the lesson.", "Learn how to define and call functions in C#.", "C# Functions", "http://path/to/lesson4_video.mp4" },
                    { 20, 2, null, "This is the content of the lesson.", "Learn about classes and objects in C#.", "C# Classes and Objects", "http://path/to/lesson5_video.mp4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "469b7668-24de-4924-bd50-4cb819889759", "44623357-0acd-4067-b0c0-726802827127" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c2cee4b8-1050-45bf-9204-b2423d5df9e7", "c8ca6ba8-f8e0-4a4c-b3f2-ede6fb5410b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6ef1180a-a331-459a-b055-ecd01846a32e", "7e44d110-6b38-42d0-8d1b-38a1591dc395" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e85d1739-ff68-4021-bd08-2bb4c8940cd9", "e23f8f3c-2cb1-4b6c-897f-686133560d5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d84fac17-c147-45e9-801d-4077070ca799", "68f4b6cd-6653-447b-bc4c-c2bc54cf5616" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "01f25804-3968-424d-b4ab-ecf54c86908e", "2fbca59c-7afd-498c-b7fd-2569b8049f7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d36f81ff-6ab2-4475-9efb-0582d712d4fc", "4ec40076-a860-440c-b570-65bf74936054" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "160a22ad-806a-434d-af94-e8db7e7d9584", "1b3f1d95-9e8a-4d8b-9113-35011836f52c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9ff8d185-111e-4d8f-ad1b-89c435a9787a", "48e10262-4bcb-4e02-ac49-b0ad05081935" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "45c59967-1ddb-4d75-9185-041745eea111", "920dcd19-4c54-46f7-b5fe-200dbb3663c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d805b56f-bd3b-462b-8690-13ba6a616b30", "283f060f-fd85-43fe-aace-58cd1fdf2df9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a097dabf-64b1-4e72-a051-7ed1b180d88c", "6b8559ae-385c-4927-816e-59b897921594" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4d571f07-85cb-4eb4-9a1e-e29b240df2a1", "af0db994-fda8-40ab-96ed-ec31f88cdaf5" });

            migrationBuilder.InsertData(
                table: "lessons",
                columns: new[] { "lessonId", "courseId", "examId", "lessonContent", "lessonDescription", "lessonTitle", "lessonVideo" },
                values: new object[,]
                {
                    { 6, 1, null, "This is the content of the lesson.", "This lesson covers the basics of C# programming.", "Introduction to C#", "http://path/to/lesson1_video.mp4" },
                    { 7, 1, null, "This is the content of the lesson.", "Learn about variables and data types in C#.", "C# Variables and Data Types", "http://path/to/lesson2_video.mp4" },
                    { 8, 1, null, "This is the content of the lesson.", "Learn about control structures in C#.", "C# Control Structures", "http://path/to/lesson3_video.mp4" },
                    { 9, 1, null, "This is the content of the lesson.", "Learn how to define and call functions in C#.", "C# Functions", "http://path/to/lesson4_video.mp4" },
                    { 10, 1, null, "This is the content of the lesson.", "Learn about classes and objects in C#.", "C# Classes and Objects", "http://path/to/lesson5_video.mp4" }
                });
        }
    }
}
