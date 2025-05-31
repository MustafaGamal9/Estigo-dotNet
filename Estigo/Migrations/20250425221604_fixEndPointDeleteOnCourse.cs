using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class fixEndPointDeleteOnCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c32dd088-7fc1-4718-b373-66053b55ae32", "90752e73-0507-4718-ad5a-13a84513af20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "13f4cb85-3619-4733-a3d9-f74ea9620db2", "dbb9e960-77bd-4124-8884-248006a266cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e895e5c1-e6c3-420d-9598-fd8272f33a56", "1cf77523-d273-467d-9e42-3d31423f74c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a57ff863-c4b4-452a-a0c7-4e8ddd95e343", "dbbc5bff-d3a7-4a2f-bacd-646f5eaa3190" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ed392998-5f52-4203-97f8-61b91da7a2b4", "690ee055-8fdf-4e78-a890-64dcffe41884" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e0a2db82-3682-458f-828e-d230bacf9991", "78efc31a-ad7e-4b91-91af-56479b83405b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0e6f5f42-0f98-496f-9ab7-7ac92b22fc04", "70d808a3-abd5-427e-b6ac-ed7a8261549b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "59394da2-f9d2-4ba5-b7fe-355003cdd78f", "aea28903-1cd4-4816-8df7-341520b92031" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9eabc88f-324c-460d-ac40-3593e848d099", "ef6390b1-8835-49b2-a9db-8dd271e35b95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a0195194-1e65-4747-b0e2-c536bf62afb7", "0326b4a7-7452-4109-be95-e80f0b3fafdb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "db230d97-ef84-402a-b4e9-a3ec18996aec", "986e63cf-1d1d-4996-aa03-a685afaf0317" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0c38ff8b-f68c-46e7-a0ec-4d6b71ad54a9", "375f3be5-9e86-47d3-a3a2-465e17b4b9db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c1d5c6e4-6a5b-4ccb-8298-f40a8b74c3df", "7d821ecc-6a34-45f1-bbcf-4f1bbdae8a57" });

            migrationBuilder.InsertData(
                table: "lessons",
                columns: new[] { "lessonId", "courseId", "lessonContent", "lessonDescription", "lessonTitle", "lessonVideo" },
                values: new object[] { 176, 35, "Fact-checking, privacy concerns, representation.", "Responsibilities when writing about real people and events.", "Ethics in Non-fiction", "https://estigo.tryasp.net/vv.mp4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
