using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class storeanswer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 176);

            migrationBuilder.CreateTable(
                name: "QuestionAnswers",
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
                        onDelete: ReferentialAction.NoAction);
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionAnswers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1982b9b6-259a-4190-b24e-681dfac60a49", "0bb38f31-2aec-4e97-98b3-61b8dd7fec36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "70159f8a-5043-4350-bff4-218a15f29ab0", "db5d5515-574b-46fc-bea3-1f4723dbb408" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "615f2d98-5f72-4723-b5d3-8b7b192f8830", "fdc28a05-6cb8-424a-8cf5-380db521ba2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0d590022-d139-4243-b1bd-ec7025da3740", "cd0d17b2-bfa4-4759-8f33-0d6f7639d41b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e7490d7c-d826-41b6-b467-755be4286638", "5c7c910e-b834-406f-aa16-d155a80a47d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e305565e-04f8-4096-8ca3-1c8e3f9c7ff2", "b394fe96-1c3c-4474-a967-7c6bb897effa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "46342bfd-27f1-496e-b712-e9f56023bfde", "b9105a47-902b-440f-b517-9f6d11a69f08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "812e11b2-d1a2-427a-b3ab-dffd961211ad", "bb8f503f-d321-440c-8a84-adeab2d39366" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4fd52932-81c6-47b6-94ff-2690a50dc197", "82636cd0-041a-4baf-a333-93ba47f6da10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e52bfcce-fa14-49c8-9af6-a9887fdf7c04", "0fa73fcd-9b33-4536-adb0-44d8465846d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a4212083-3c05-43b4-bf9a-56ececbc1af2", "304d0e33-1a77-48c8-bdc9-5a0043ae6214" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f0cbae22-a85d-4948-8771-3555867b4cd2", "0b8d0c79-94b0-468d-be27-301de814e6d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "34b50421-d788-4d72-a5b8-c508579fa7ca", "c51a8f91-43f8-4d7e-9b87-105709116d07" });

            migrationBuilder.InsertData(
                table: "lessons",
                columns: new[] { "lessonId", "courseId", "isLive", "lessonContent", "lessonDescription", "lessonTitle", "lessonVideo" },
                values: new object[] { 176, 35, false, "Fact-checking, privacy concerns, representation.", "Responsibilities when writing about real people and events.", "Ethics in Non-fiction", "https://estigo.tryasp.net/vv.mp4" });
        }
    }
}
