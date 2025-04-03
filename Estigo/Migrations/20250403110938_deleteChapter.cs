using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class deleteChapter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chapters_Courses_CourseId",
                table: "Chapters");

            migrationBuilder.DropForeignKey(
                name: "FK_lessons_Chapters_chapterId",
                table: "lessons");

            migrationBuilder.DropIndex(
                name: "IX_Chapters_CourseId",
                table: "Chapters");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Chapters");

            migrationBuilder.RenameColumn(
                name: "chapterId",
                table: "lessons",
                newName: "courseId");

            migrationBuilder.RenameIndex(
                name: "IX_lessons_chapterId",
                table: "lessons",
                newName: "IX_lessons_courseId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1b2c601e-724e-4460-9fd9-5767ca4e7707", "7da75318-3220-45ed-8ec0-99db266c4fca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c96e7a95-882a-47ff-8643-3cc81ffe0301", "d7e52b45-4d3c-4fd8-b957-f1ee95f92bd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ca0779ab-0c75-45f5-bd83-754e16394d5c", "08c5bccb-2548-4323-9401-a0b8a25c52cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f744c373-4fa3-472a-be4c-a62d39bb724c", "778371b5-c0bb-4a4c-a7bd-29f34a40aed8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "81513033-3f80-4076-86c1-dfdabc36fa64", "b87b0f16-8f92-473e-843c-1b234fb9a68f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ce9eaf50-e182-4dbd-a231-dde2c18812bd", "7bea7e3b-c846-465c-bc10-42091c9aca8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2e7356ae-b266-4958-9e1d-7b1a0c58ea87", "aeb27bea-1a15-4889-983d-fdf4a61825f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f43e4d0d-b08c-4fb8-a08f-055dd0eff2a3", "95e458a3-1467-4119-bb4a-e209c7e343ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "81b4960c-4187-4dc0-a60b-ac269bc951ce", "89b2e9d7-bf70-473a-9e88-a09112c79266" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "23404834-51a5-4038-b176-b8ceffae64ed", "e8cb0764-b574-4d3b-b89d-f5e74c31758d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "252aaf86-c59a-4797-999c-7f8953f5c304", "667c8a20-e1a4-4f23-b957-f9886ef3b85f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "43a6c02d-a128-43b4-b4fa-c70adad3c810", "a8b8f4bc-9276-4f2a-961b-9a8fe942fbb4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1b1b798e-7f0e-489c-aa4b-091be81c669d", "b2367af1-37e1-4597-a672-ffc8d1058040" });

            migrationBuilder.AddForeignKey(
                name: "FK_lessons_Courses_courseId",
                table: "lessons",
                column: "courseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_lessons_Courses_courseId",
                table: "lessons");

            migrationBuilder.RenameColumn(
                name: "courseId",
                table: "lessons",
                newName: "chapterId");

            migrationBuilder.RenameIndex(
                name: "IX_lessons_courseId",
                table: "lessons",
                newName: "IX_lessons_chapterId");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Chapters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8a6fd9e2-8514-4d90-ab08-5b47d5076030", "3353c204-da83-4352-977f-638f6d3dcec2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f485b883-1a6d-442d-960a-ae34cae728ed", "a201153c-e232-4537-93a1-ee30d2074082" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ccd70a3a-2878-4dee-8dc7-0b8e745fed22", "2fed5d24-62b2-4454-aafa-be13a07a5aaa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "056709f4-4933-4a5e-9419-413fc2943145", "d0cfc77e-d33d-4ad9-a6a2-708700432f06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9c267e64-1666-4b25-b5d6-815a49e4148d", "351bfecc-524d-4040-bfec-e990ea2115cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7d220abe-fdba-42e9-8610-be6cfc02fe05", "36a0a6a3-8e59-47bb-a6f6-f1d48e3142ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "54ff9403-1f8d-4a97-a3e1-470f750a100c", "3ed89086-8448-4c0a-9d13-c79af6b861f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "24691afe-9071-46b7-869e-9a6bf138803d", "63f6896e-8800-4fc1-8c58-8e7b76880013" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c5f04491-bd3a-4412-becf-dbbdfec20ba9", "2b7fc1a2-3d00-468a-8ef5-0ddcf6e55a90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "47d1aca6-a1ed-48cd-8eb7-8f4d99c809d9", "fc6a7be5-196c-47c8-8549-e99ae3376848" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bdb96930-e9ef-4ae5-8579-2f6230acc393", "b8671714-f376-4f7a-bdde-76d9b9db2173" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1f7bd33d-3be2-4e71-af7f-460cd051d8ff", "6785b589-06a0-4463-b18e-fcac50747cf6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c6b61e9c-acce-4089-88fb-4b8e49cb36c3", "772d87cf-9a71-40e5-bcfd-cc91f427e813" });

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_CourseId",
                table: "Chapters",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chapters_Courses_CourseId",
                table: "Chapters",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_lessons_Chapters_chapterId",
                table: "lessons",
                column: "chapterId",
                principalTable: "Chapters",
                principalColumn: "ChapterId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
