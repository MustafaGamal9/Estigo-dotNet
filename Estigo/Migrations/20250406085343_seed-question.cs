using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class seedquestion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d032f282-449c-4629-a107-380badc49a1c", "e5773d91-24d2-4526-a946-03319afb944d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6eaadd01-16ad-4f9c-80d3-8bc8ed81e4b4", "d4306b03-023b-49b2-a0ec-8cf01cae9b69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "95d0e007-ef62-4572-bbd3-7e4c8d76ab76", "c9a2d1a2-ae96-4cb1-9558-8c2206942d46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a596a74f-c312-48bc-ab4a-68b1878f60c3", "4436f1ea-62b3-4fda-acb8-aa8823de2a9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8136282f-1bc2-4f19-92b2-1542f4a4e839", "b8f44330-dfc4-413f-ae8a-a4f4cd7b76e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16200911-c1d5-4852-8eb7-2e46b6baebb3", "995a1e52-e1a0-411e-8196-fe1c02c53019" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3cfc9615-3275-4224-8d7c-d26d7474e895", "32a9a462-a3a0-443a-a59e-c2ae5016becf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "77df74da-0e4a-4349-b3c7-96255b714a76", "0a741506-253f-4c9a-9391-ea65d4137e6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "de4f9595-b677-4439-9d9c-8a1643bef55f", "af9d3142-54a4-4bd5-b006-a4a413ad44de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "89506947-9274-4fb7-b9f8-317454e52028", "a9c48d43-50b8-4f4b-9a38-ffabb82fcacb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "029e2a0a-0450-4d0f-8919-a7da7e7f1bef", "577abcff-9201-4a78-b630-9be94365b08f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3264fb1b-e189-47c2-be21-3100d6714996", "afe21ea3-e3a9-42e1-b004-d4d351d21f8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f0ed2b64-63bc-4af0-ad3a-3ff923147c9f", "b503199b-234c-4391-974e-c3ec6a127309" });

            migrationBuilder.InsertData(
                table: "BankOfQuestions",
                columns: new[] { "Id", "CorrectAnswer", "ExamId", "OptionA", "OptionB", "OptionC", "OptionD", "QuestionText" },
                values: new object[,]
                {
                    { 1, "A", 11, "Paris", "London", "Rome", "Berlin", "What is the capital of France?" },
                    { 2, "B", 11, "Earth", "Mars", "Jupiter", "Saturn", "Which planet is known as the Red Planet?" },
                    { 3, "C", 11, "10", "11", "12", "13", "What is 5 + 7?" },
                    { 4, "C", 11, "Java", "Swift", "Kotlin", "C#", "Which language is primarily used for Android development?" },
                    { 5, "A", 11, "H2O", "O2", "CO2", "NaCl", "What is the chemical symbol for water?" },
                    { 6, "B", 12, "8", "9", "10", "7", "What is the square root of 81?" },
                    { 7, "B", 12, "Vincent van Gogh", "Leonardo da Vinci", "Pablo Picasso", "Michelangelo", "Who painted the Mona Lisa?" },
                    { 8, "D", 12, "Brain", "Lungs", "Liver", "Heart", "Which organ pumps blood through the body?" },
                    { 9, "C", 12, "Earth", "Mars", "Jupiter", "Saturn", "What is the largest planet in our solar system?" },
                    { 10, "B", 12, "Oxygen", "Hydrogen", "Helium", "Carbon", "Which element has the atomic number 1?" }
                });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 8, 53, 37, 894, DateTimeKind.Utc).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 8, 53, 37, 894, DateTimeKind.Utc).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 8, 53, 37, 894, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 8, 53, 37, 894, DateTimeKind.Utc).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 8, 53, 37, 894, DateTimeKind.Utc).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 8, 53, 37, 894, DateTimeKind.Utc).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 8, 53, 37, 894, DateTimeKind.Utc).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 8, 53, 37, 894, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 8, 53, 37, 894, DateTimeKind.Utc).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 8, 53, 37, 894, DateTimeKind.Utc).AddTicks(8227));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "816b375a-0c97-454a-986b-80731bccf519", "47227604-5695-41b7-a9b0-2d72bdebdec3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "71a07b03-8c94-47f3-9e15-30cf174ef9b2", "6741015c-b1e7-40b7-bffe-081c0a4da6e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1d35cee1-9529-4548-be35-f1f26ebe34fe", "9400caf8-4cc1-4e82-8695-190444cf3f02" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "02929c24-5e64-4ccb-ae94-5f40e1ff1b9e", "2737f310-ffa9-45d9-bb17-e11b4b034eb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "19fa3fa1-f068-47ed-9bcb-d4145fe658cf", "6cc352b1-9ef5-41ac-a669-e44361a2983d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c68eb63d-e9f5-4bee-83c5-15e3be265369", "24687b35-1866-4063-8952-6ed80d6366a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "837b2a73-1a48-4b14-92d0-4a90f10be419", "500cd443-731d-42d4-8628-2e218cbf2994" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "528a6e55-8a7c-4f9d-b772-a395ca3d44ed", "efb4d850-a682-49d8-8e7e-3e526c413448" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "910c6dd3-b6b7-488c-9c14-a9ba2b786b63", "b6e9dc39-d5e7-41da-804f-f31089419bcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7120c173-bb67-4229-99da-a3600a504534", "a1aa1585-941d-4524-8238-8ab90f9413a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b02f9701-4bc8-4292-950d-3d82d59f7763", "15ce943a-e4db-4bfa-8349-1dfaed38aa36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f7beb1d2-d118-4881-9927-5198e2a41fea", "179e7cf2-2051-4eca-9623-8d4d88439a04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9f06a530-18e0-478b-8844-3f1f744d5b26", "ab251c25-ff3c-49b6-b493-c9cac3ac777a" });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 8, 14, 9, 412, DateTimeKind.Utc).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 8, 14, 9, 412, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 8, 14, 9, 412, DateTimeKind.Utc).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 8, 14, 9, 412, DateTimeKind.Utc).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 8, 14, 9, 412, DateTimeKind.Utc).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 8, 14, 9, 412, DateTimeKind.Utc).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 8, 14, 9, 412, DateTimeKind.Utc).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 8, 14, 9, 412, DateTimeKind.Utc).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 8, 14, 9, 412, DateTimeKind.Utc).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 6, 8, 14, 9, 412, DateTimeKind.Utc).AddTicks(5483));
        }
    }
}
