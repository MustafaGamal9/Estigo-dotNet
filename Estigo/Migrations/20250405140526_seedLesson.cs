using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class seedLesson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "examId",
                table: "lessons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                    { 10, 1, null, "This is the content of the lesson.", "Learn about classes and objects in C#.", "C# Classes and Objects", "http://path/to/lesson5_video.mp4" },
                    { 11, 1, null, "This is the content of the lesson.", "This lesson covers the basics of C# programming.", "Introduction to C#", "http://path/to/lesson1_video.mp4" },
                    { 12, 1, null, "This is the content of the lesson.", "Learn about variables and data types in C#.", "C# Variables and Data Types", "http://path/to/lesson2_video.mp4" },
                    { 13, 1, null, "This is the content of the lesson.", "Learn about control structures in C#.", "C# Control Structures", "http://path/to/lesson3_video.mp4" },
                    { 14, 1, null, "This is the content of the lesson.", "Learn how to define and call functions in C#.", "C# Functions", "http://path/to/lesson4_video.mp4" },
                    { 15, 1, null, "This is the content of the lesson.", "Learn about classes and objects in C#.", "C# Classes and Objects", "http://path/to/lesson5_video.mp4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 15);

            migrationBuilder.AlterColumn<int>(
                name: "examId",
                table: "lessons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "57874e97-252e-4da1-a124-828c3506230a", "37df4611-a25e-494b-bc8a-58556d1524dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9563dc09-cde8-41a8-80c4-7c7761f1b15d", "73cdf283-2e69-460c-9418-10728aa75f34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5571f0e6-ab6a-4cd2-96d7-d6dc26119110", "4906a863-446f-4e76-9d13-a4f300aff244" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "83d8a619-9583-45f7-951b-1af3586c1ca0", "8d1b2703-93b5-496e-abc8-a28b3f0aa5cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c5794d2c-05c8-48a0-a040-d59e2dd5085f", "f466d16f-4edf-4104-b3fa-40c851bdae8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cffde56b-fb56-4183-b492-e04fd6ee3fe5", "9444579f-3160-4474-85e7-0e7c799c688e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a2b6b912-652a-43f9-83d3-b622394fc8a3", "555c3105-6cf3-4852-bc07-d87d8b0a90d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b22d1be7-c9aa-415a-9953-2b334facd872", "d3c376ed-7af8-4019-b5f3-fc6457bde244" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e2b93d17-5c7d-4f4d-8268-fdbfc825271e", "a0d6745c-9f2d-440e-b477-94ba28d91cfd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e09eb7bd-0ca0-43dd-8774-dfa85c91f803", "e68b0e82-93a9-4e16-b5ac-b885b665812d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b8cf6d04-deb0-44f6-bebf-c10253cc1d1b", "32770a46-c951-4493-9188-dceb35913243" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "32e2c947-a967-41f7-ab1e-90bf856cf631", "c892514c-46de-43d3-927b-eaa8a84ab317" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a8aec355-fd23-439c-b242-6cd880da15a8", "ef7b3946-6712-4df1-aead-92749df5f836" });
        }
    }
}
