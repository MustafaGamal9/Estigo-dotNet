using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class BOQExam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Courses_courseId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_courseId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "courseId",
                table: "Exams");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "courseId",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "434dfadc-e619-40d5-b489-284ac68b1b7f", "aed0e026-9ed0-4cce-843a-874c913b253b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "89d157ad-108b-4e10-a27b-fb58589c55ad", "f0c4d9e5-b30f-4b72-8a06-e9ef38e21af2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "109c79ea-6135-47ef-a08b-abd3bdd1b299", "837d249a-c5c9-484e-8c19-b92eedd66e74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4010f38b-b70a-46ee-8b5e-5e977f213f31", "359f8089-69e2-4186-9697-69b66f4500bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cb2b2d4c-1f34-4f1d-a357-7dfdb3e25d35", "463d9bad-6f6b-4810-acd0-fae2aef2af48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3c801706-2443-4cab-96be-c86fe1b4ecfd", "b0b1cb75-cae1-4424-bf10-7fd34d155e21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0c08d555-992c-4c81-87bc-1adf4fd9324c", "26f680bd-572c-4bf8-8afe-45cc7bfa6160" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "203bf410-45b2-4bcd-8a2c-862f4b16c9e0", "bc978bbf-e6cf-4de8-9bc1-cd304f9b059b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "79119392-cd72-4a67-8323-d21726a62b83", "e42601ce-1a2b-44e7-8401-c5ea5f11f0fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "85e6e3e0-f300-4ba4-a819-84da5ae323bb", "bdd63882-c5f7-49f5-ab6a-73914cb5d557" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "11ba1dbe-c8b6-4caa-9312-b7299e2bf837", "81bcab26-73c1-46dd-af95-acff4a176375" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "31341c42-e8a0-4d12-a635-b175efab8758", "058fe701-5c6a-4752-8dea-7fc2f96e7c55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "471c3868-6098-480a-80a0-d02e47780108", "b153af23-0c1b-4414-9fc2-644c8a827b56" });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                column: "courseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2,
                column: "courseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 3,
                column: "courseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 4,
                column: "courseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 5,
                column: "courseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 6,
                column: "courseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 7,
                column: "courseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 8,
                column: "courseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 9,
                column: "courseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 10,
                column: "courseId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 11,
                column: "courseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 12,
                column: "courseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 13,
                column: "courseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 14,
                column: "courseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 15,
                column: "courseId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 16,
                column: "courseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 17,
                column: "courseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 18,
                column: "courseId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 19,
                column: "courseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 20,
                column: "courseId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 21,
                column: "courseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 22,
                column: "courseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 23,
                column: "courseId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 24,
                column: "courseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 25,
                column: "courseId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 26,
                column: "courseId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 27,
                column: "courseId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 28,
                column: "courseId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 29,
                column: "courseId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 30,
                column: "courseId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 31,
                column: "courseId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 32,
                column: "courseId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 33,
                column: "courseId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 34,
                column: "courseId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 35,
                column: "courseId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 36,
                column: "courseId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 37,
                column: "courseId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 38,
                column: "courseId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 39,
                column: "courseId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 40,
                column: "courseId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 41,
                column: "courseId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 42,
                column: "courseId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 43,
                column: "courseId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 44,
                column: "courseId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 45,
                column: "courseId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 46,
                column: "courseId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 47,
                column: "courseId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 48,
                column: "courseId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 49,
                column: "courseId",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 50,
                column: "courseId",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 51,
                column: "courseId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 52,
                column: "courseId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 53,
                column: "courseId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 54,
                column: "courseId",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 55,
                column: "courseId",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 56,
                column: "courseId",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 57,
                column: "courseId",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 58,
                column: "courseId",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 59,
                column: "courseId",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 60,
                column: "courseId",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 61,
                column: "courseId",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 62,
                column: "courseId",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 63,
                column: "courseId",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 64,
                column: "courseId",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 65,
                column: "courseId",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 66,
                column: "courseId",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 67,
                column: "courseId",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 68,
                column: "courseId",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 69,
                column: "courseId",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 70,
                column: "courseId",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 71,
                column: "courseId",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 72,
                column: "courseId",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 73,
                column: "courseId",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 74,
                column: "courseId",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 75,
                column: "courseId",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 76,
                column: "courseId",
                value: 31);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 77,
                column: "courseId",
                value: 31);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 78,
                column: "courseId",
                value: 31);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 79,
                column: "courseId",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 80,
                column: "courseId",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 81,
                column: "courseId",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 82,
                column: "courseId",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 83,
                column: "courseId",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 84,
                column: "courseId",
                value: 34);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 85,
                column: "courseId",
                value: 34);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 86,
                column: "courseId",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 87,
                column: "courseId",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 88,
                column: "courseId",
                value: 35);

            migrationBuilder.CreateIndex(
                name: "IX_Exams_courseId",
                table: "Exams",
                column: "courseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Courses_courseId",
                table: "Exams",
                column: "courseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
