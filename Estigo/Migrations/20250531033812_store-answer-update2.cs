using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class storeanswerupdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionAnswer_StudentExamResults_StudentExamResultId1",
                table: "QuestionAnswer");

            migrationBuilder.DropIndex(
                name: "IX_QuestionAnswer_StudentExamResultId1",
                table: "QuestionAnswer");

            migrationBuilder.DropColumn(
                name: "StudentExamResultId1",
                table: "QuestionAnswer");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3558278b-c9de-40d8-9830-97356d2e7c8b", "15e46b43-c4a6-422f-a58c-815ec11c05dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dbd927cb-f0b4-4b9e-a302-d1661ef2b0a7", "dff40f53-b039-4d4d-9bb6-b0d4f9503fa3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c355c88b-0e0f-43d2-a740-837004a75a1e", "90904b21-9409-46c8-8c63-a8160af44400" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f3cb186e-e344-4297-8aeb-e38db9eb5013", "e5b63502-0cb2-4d81-a9d3-aa9f5538de9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "76166f32-af89-4be1-8029-1603fcd8d71c", "8bfcaf0f-8f3f-4e45-977d-1895a2e62817" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "af2b6860-1724-4c50-9a11-070c9287859e", "bf0f7dea-97d1-4658-be63-af5a298e004d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2ea70051-bfe2-4e30-8153-c571ea3dfbc4", "4823a348-a891-4e52-91ab-bda8a55e26ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "07613041-6fb7-43a8-9fbd-800b435d52d5", "af8d33e9-8397-456b-811c-69f0b200edba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "baecd9af-95a4-475e-a085-dcdfe86ab3c2", "d7ee56e0-4624-4790-ab54-4d60c8019752" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ef7aea35-0b65-4de6-a9b5-c60f8b882a17", "626d7503-6c81-47a7-99f3-9effcc712bbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e0a475c8-efae-40fc-b374-ef631f83144b", "f900cd1e-2c89-41e0-9d3c-0e51ce3347d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8f2ab604-b252-4367-899f-cb8d4858a427", "48cf7a12-e18e-4389-a7ee-7c3a477865a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "96674dec-e8c4-4635-b8b4-3080d0e0efa7", "95cd6822-6ef9-44da-ad35-1b0a28124830" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentExamResultId1",
                table: "QuestionAnswer",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                name: "IX_QuestionAnswer_StudentExamResultId1",
                table: "QuestionAnswer",
                column: "StudentExamResultId1");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionAnswer_StudentExamResults_StudentExamResultId1",
                table: "QuestionAnswer",
                column: "StudentExamResultId1",
                principalTable: "StudentExamResults",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
