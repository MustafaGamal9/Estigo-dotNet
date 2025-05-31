using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class storeanswerupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionAnswers");

            migrationBuilder.CreateTable(
                name: "QuestionAnswer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    SelectedOption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    StudentExamResultId = table.Column<int>(type: "int", nullable: false),
                    StudentExamResultId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAnswer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionAnswer_StudentExamResults_StudentExamResultId",
                        column: x => x.StudentExamResultId,
                        principalTable: "StudentExamResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_QuestionAnswer_StudentExamResults_StudentExamResultId1",
                        column: x => x.StudentExamResultId1,
                        principalTable: "StudentExamResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1a7f092f-614a-48b4-9dab-710021b6e1dd", "66f4dbac-0290-4f2d-ba4c-7ee68234be81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f5adadac-b2b0-4630-a3a3-7301329c34cf", "ab20971a-a43e-46a7-a013-dedaf02ac181" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fc2bf17a-9ca6-4e94-ab13-58f74f29e033", "f6e1c774-c310-4e5a-b8e5-a8fb1583c55c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "84f77edc-4aaa-4813-bcb9-343517d64bbd", "25cd1b72-ee57-4111-bc27-ae0f529dbe50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "90d21485-5836-4a46-8a2d-a961e32c4e26", "6a8ea774-a568-4c22-bea6-b78f73ac9533" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4e5cd3b7-cf80-4448-9796-e098fd36b28f", "ecc83c82-2bc5-4596-b4fd-bc31779ccb97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "965d5dfd-117b-4a81-8642-99a058c81dfb", "5933efd9-8992-474d-8aca-f3a182481b5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b316cade-084f-4c95-87dc-1ed0645a29f7", "919536f8-a7c0-4cbc-b5de-d83fb14df00e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3b1d904c-af14-4d30-8c7a-092757b98ecd", "30ac6faf-d64f-4f93-afed-0699fbd223ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e292dc53-1d9a-48e7-a1eb-00dbf4780aa2", "fd3743d4-14db-41cf-8119-4deafdbfa7c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6dc17fe9-c56e-4e9d-bece-e5e9ef163643", "c960d124-5be4-4845-9a96-96628d190b86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cb9cade2-a06a-4f74-9d76-418fede45e72", "e1d84ddc-5115-4380-9e46-86f640fed6cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "28b192d3-2235-4df1-a658-4b90172aab3d", "551ffeef-389c-4e1a-b4de-d9dcc1948326" });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswer_StudentExamResultId",
                table: "QuestionAnswer",
                column: "StudentExamResultId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswer_StudentExamResultId1",
                table: "QuestionAnswer",
                column: "StudentExamResultId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionAnswer");

            migrationBuilder.CreateTable(
                name: "QuestionAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentExamResultId1 = table.Column<int>(type: "int", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    SelectedOption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentExamResultId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionAnswers_StudentExamResults_StudentExamResultId",
                        column: x => x.StudentExamResultId,
                        principalTable: "StudentExamResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_QuestionAnswers_StudentExamResults_StudentExamResultId1",
                        column: x => x.StudentExamResultId1,
                        principalTable: "StudentExamResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f284b80d-3a3f-462e-9f9a-fe1f2fbe3d8e", "2749c280-1700-46ac-83ea-bcedf2d02a78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d19967bf-a6a8-4042-8172-27d68f932666", "5d092196-c15c-4a85-ac95-40117e0254eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "013f9766-7ba7-4b2b-9732-9384c25fbad9", "f7641f40-35b3-4772-8894-4ff4876e396a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d2d26f35-dbbf-4dcf-b283-64eb36b834b1", "e7191a41-ed1e-4b1c-a715-8c667d548415" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b65748fd-31d1-40f1-bf3a-4c74afbe3ee4", "7af934b1-5ffb-4124-90f3-e0511e88abdb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "945cacd5-545a-4d40-9d0e-59be60df2fd2", "b82c6673-a3ac-40b0-8f51-239d34caae3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "718312ea-e0c0-4349-b0b5-6d826c8c4baf", "528d5215-57c8-4f5c-83f3-1131d1df3ad1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7767a88c-49c6-4ddc-b7e9-75cf3d6f7ae4", "7d7bcf04-4536-49a3-ae99-14323f513789" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "741cfbd2-16d5-4c8e-94fa-eb1a4a6fcfd5", "078a989e-18a2-4ccd-9941-c5edbfea9448" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3afc2838-7734-4db6-b5b1-d777651da6e7", "d856994e-8d9c-4097-8185-ae456d0b269d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "421be4e3-944f-4383-b2f7-24f7a79d2180", "e059bc59-c77b-4007-895c-7ca1cfafeaf7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a45d3e60-d35d-4628-8fe2-a1aad535f707", "1927c8c8-2d1c-4f43-99b8-541d71ad280a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2778109e-23fd-4e98-b678-5aa660e41db7", "73743cff-43c6-492e-9015-48bd015f1ebd" });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswers_StudentExamResultId",
                table: "QuestionAnswers",
                column: "StudentExamResultId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswers_StudentExamResultId1",
                table: "QuestionAnswers",
                column: "StudentExamResultId1");
        }
    }
}
