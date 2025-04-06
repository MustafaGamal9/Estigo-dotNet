using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class video : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cfdbb9ed-3bce-4ab4-8531-19077eaf3879", "417202c2-ecd3-46e2-8442-a1ea7c651c49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c1fc79ab-4a9d-409e-bf72-77a4575b4aaa", "fc9abde7-c53a-42a2-b0ab-fc7ff3f3da93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3d60fff4-eef1-4346-8bc3-a1de0a1517f4", "6f2b7d07-cd48-4263-91b2-e3b09fdb7b88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "39118009-2919-4c26-aef6-a98dcd3b2d37", "68bca019-e554-4d97-b763-3997bbf6d5c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9f55d453-436b-413b-b338-a236ceaf731d", "c96a7c8a-4ecd-4287-8c38-16bc314bf2d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f9c0f544-d427-48bd-837d-e9fd16f045fb", "3e9da10a-ac8f-4081-82b7-8ea27558d613" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "47e00b3e-935d-49e8-a807-e789638f4d56", "1bed3003-e15e-4e00-9248-5f6b0ab2db12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1dd0cd63-4b09-47fb-b8ed-6a4b131756ee", "68462990-5bd6-41d4-b85b-c759805e8703" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d8596ee1-acb2-491e-a62b-b34030c613a6", "bb8e03a3-d051-4364-a86a-9b2dafc68561" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5254e81e-df3f-425f-9e54-ae262ea1f9de", "a86ddcdf-6562-4fe0-921e-d39118561a95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "08ccbf46-025e-4751-8b3c-02d9618bf232", "400c7e3a-ac7d-4a43-b80e-9c0cce10481e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3417e226-52e8-4931-b47b-f7549c17fc7d", "5fa12c47-65e0-418d-b81d-cc819a0b95b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "87dabebe-b4cc-4825-8ae5-58858e2fee92", "5ab53aff-abc5-4b64-8973-da81872af57e" });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 21, 9, 56, 964, DateTimeKind.Utc).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 21, 9, 56, 964, DateTimeKind.Utc).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 21, 9, 56, 964, DateTimeKind.Utc).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 21, 9, 56, 964, DateTimeKind.Utc).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 21, 9, 56, 964, DateTimeKind.Utc).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 21, 9, 56, 964, DateTimeKind.Utc).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 21, 9, 56, 964, DateTimeKind.Utc).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 21, 9, 56, 964, DateTimeKind.Utc).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 21, 9, 56, 964, DateTimeKind.Utc).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 21, 9, 56, 964, DateTimeKind.Utc).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 11,
                column: "lessonVideo",
                value: "vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 12,
                column: "lessonVideo",
                value: "vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 13,
                column: "lessonVideo",
                value: "vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 14,
                column: "lessonVideo",
                value: "vv.mp4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 11,
                column: "lessonVideo",
                value: "http://path/to/lesson1_video.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 12,
                column: "lessonVideo",
                value: "http://path/to/lesson2_video.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 13,
                column: "lessonVideo",
                value: "http://path/to/lesson3_video.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 14,
                column: "lessonVideo",
                value: "http://path/to/lesson4_video.mp4");
        }
    }
}
