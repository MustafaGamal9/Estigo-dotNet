using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class FixCourseLesson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Courses_courseId",
                table: "Payments");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "951f8023-922c-40a1-bab1-42de742d61a7", "37fc4058-85db-41d6-99cf-55676671afb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "47f21173-4c71-41c6-8954-6194dd79b095", "c03d0e2c-82c7-46d4-b532-2fec43686136" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d4058ac9-6a74-4cf6-9567-b5166910a067", "06cbc3c9-1e7d-4e90-89d5-dce70beb1709" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a4691ff6-2930-4bcf-890d-0451e0f83f2f", "ee5ace84-8d04-4114-84f0-5f22394f9a68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b4f6d121-68be-4c34-892b-90f131d9ef51", "db85cfc7-5c2d-49d5-a96d-1b19207a79f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "39862ba7-ed22-4e60-9f44-bd27bf9f6459", "ff7fe82e-f6f2-4522-9f7e-75ba51c181e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fa33f701-fac0-406e-97a6-c7555cd51f4a", "c025265a-b4a6-4263-8fcd-4dc27987fe57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9f03a2d4-d2f6-4947-ac4e-ab4f4aa5d245", "28fc3578-5376-47fa-ad9e-09a8da18695b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c13dc896-3ba6-41c9-bfde-55abef2a969c", "5402f4ef-7fe6-4986-b2ab-2b6d680c3417" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "64c2e407-518a-4be1-8fb4-6334420228d3", "41a28dfa-abd2-4577-8aae-9d45958dd5b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a8ce2d48-0d45-4dab-ad49-fd6b799824a0", "d4435ce0-8bcc-40ea-935b-2ea953226f1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "026de3fd-3344-4fe1-8880-29e537a04f64", "3ff242ad-6506-4dfd-8b9c-1f3f8a7b6e3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bac6712c-2529-4d30-b1a9-6288e651b7ae", "d9f53fbe-9863-4710-a0f0-3ecf509ff5db" });

            migrationBuilder.InsertData(
                table: "lessons",
                columns: new[] { "lessonId", "courseId", "lessonContent", "lessonDescription", "lessonTitle", "lessonVideo" },
                values: new object[] { 176, 35, "Fact-checking, privacy concerns, representation.", "Responsibilities when writing about real people and events.", "Ethics in Non-fiction", "https://estigo.tryasp.net/vv.mp4" });

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Courses_courseId",
                table: "Payments",
                column: "courseId",
                principalTable: "Courses",
                principalColumn: "courseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Courses_courseId",
                table: "Payments");

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 176);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a0a5a016-ea2a-43a1-9786-33dae726c5b8", "a3cddf00-fe83-4596-9c79-3597641ccf6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "80a53347-55b7-451c-babc-0fd9d9a111ab", "02175981-f723-409f-b59e-db4f30851418" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fc332645-a1e6-468b-87fa-52897b1fd267", "b1222ee5-a7a3-4208-8c9b-a07318369dea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0a3d5140-d75d-423a-9a98-78c5a1432e2f", "ff6457bb-19ed-4a34-b408-4cef6b11b496" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d5847929-2d0a-4aad-904f-cc9df3b38c3f", "e423d8e6-0dd1-433c-9ec6-13de97a58167" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7100828c-9c0a-4932-9d22-2c6ad4bb14dd", "8daf6243-4ae4-4596-89c8-997195747050" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a22b3e2e-af37-4e01-8bab-65e1746f57dc", "bb367cc7-f1fe-4667-82b0-b64bba933680" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d794efae-de8a-4a19-87f7-87dbcf6eb917", "a13a0428-08c9-44df-9f66-5baae890bbac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0e21ebb2-4728-439f-bbf2-4730867bdcc4", "03331f36-6bac-44d2-ac3b-39d3a15de961" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "35ecfb1f-0784-4bd4-85a5-515f81759080", "62a38312-bf98-41a0-ab9f-2edd66eab66a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b9e515f-6abc-4074-82f7-8568a37d2d6f", "b5497a09-6f0f-49ff-b6ce-bd78f213322a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "60bf5fa9-384e-4819-b074-203026f72aed", "eedb7fa6-9817-423a-a6a1-9cc0d648556f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d591c7a7-0d07-40da-bfa4-87ac00a7f251", "7204b0c2-4afd-456e-960b-d5b6f660881b" });

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Courses_courseId",
                table: "Payments",
                column: "courseId",
                principalTable: "Courses",
                principalColumn: "courseId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
