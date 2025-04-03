using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class remove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Chapters",
                table: "Chapters");

            migrationBuilder.RenameTable(
                name: "Chapters",
                newName: "Chapter");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chapter",
                table: "Chapter",
                column: "ChapterId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Chapter",
                table: "Chapter");

            migrationBuilder.RenameTable(
                name: "Chapter",
                newName: "Chapters");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chapters",
                table: "Chapters",
                column: "ChapterId");

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
        }
    }
}
