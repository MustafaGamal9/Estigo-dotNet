using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class updateQuestionExam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankOfQuestionExam");

            migrationBuilder.AddColumn<int>(
                name: "ExamId",
                table: "BankOfQuestions",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_BankOfQuestions_ExamId",
                table: "BankOfQuestions",
                column: "ExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_BankOfQuestions_Exams_ExamId",
                table: "BankOfQuestions",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankOfQuestions_Exams_ExamId",
                table: "BankOfQuestions");

            migrationBuilder.DropIndex(
                name: "IX_BankOfQuestions_ExamId",
                table: "BankOfQuestions");

            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "BankOfQuestions");

            migrationBuilder.CreateTable(
                name: "BankOfQuestionExam",
                columns: table => new
                {
                    ExamsId = table.Column<int>(type: "int", nullable: false),
                    QuestionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankOfQuestionExam", x => new { x.ExamsId, x.QuestionsId });
                    table.ForeignKey(
                        name: "FK_BankOfQuestionExam_BankOfQuestions_QuestionsId",
                        column: x => x.QuestionsId,
                        principalTable: "BankOfQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BankOfQuestionExam_Exams_ExamsId",
                        column: x => x.ExamsId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 15, 16, 13, 960, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 15, 16, 13, 960, DateTimeKind.Utc).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 15, 16, 13, 960, DateTimeKind.Utc).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 15, 16, 13, 960, DateTimeKind.Utc).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 15, 16, 13, 960, DateTimeKind.Utc).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 15, 16, 13, 960, DateTimeKind.Utc).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 15, 16, 13, 960, DateTimeKind.Utc).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 15, 16, 13, 960, DateTimeKind.Utc).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 15, 16, 13, 960, DateTimeKind.Utc).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 15, 16, 13, 960, DateTimeKind.Utc).AddTicks(8987));

            migrationBuilder.CreateIndex(
                name: "IX_BankOfQuestionExam_QuestionsId",
                table: "BankOfQuestionExam",
                column: "QuestionsId");
        }
    }
}
