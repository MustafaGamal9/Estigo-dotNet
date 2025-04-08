using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class update_studentexamresult : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aac95750-be35-4257-91ba-9d898864a282", "52ed97da-18d9-4d2a-b679-bc27d2cc9cb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "10db8ff5-eb23-4660-979b-30c7e1c41df7", "65d1e6c9-7177-47ba-805d-b8bb8ea4b677" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "32bb1d91-1073-4b79-a584-eda0019f3bfe", "fd3d9c7a-1de1-4f0b-b6e1-1f65c2ca0fda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e98c5356-064c-40f9-b729-18e62c019e51", "bfa14214-9895-4f5d-8566-fcc5419d865b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8d0e47ac-6189-478b-b6fc-dd08924ce545", "5f6beb96-a7fd-473c-9099-2476441eab8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9de37b21-2088-468a-b72c-b21e1b4abd45", "c1f056ef-ca36-4ddb-b68c-7c7e006b6fcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c29dd9b0-d0c0-4a41-b1c0-e4469993dec9", "395c2c56-0156-4c6a-a38e-1805611e6973" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "41c612c4-1b5d-4972-b54e-250eeb92a183", "4c4d25e3-40fb-4f97-939a-c117cae40b3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9fbb9e55-e5e0-4406-b2e3-17a079e15c10", "031b79d0-d3ff-45d4-828f-45d5953ad733" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "10c76324-e0b2-42e2-9a9f-8366be46ab53", "630823cb-6c68-4974-bf90-41d7b7bfad0d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3ea7f272-8e37-4301-819f-28a3329cacd5", "72ae449f-977f-4543-83b8-487f37fafb84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "24a9adb2-a2df-4db4-bdd7-b39bb3576adf", "aa50949b-1017-4b70-8cd7-bc490e048dd6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8b714f06-b7cc-4cf1-8641-0f23644782d7", "decc4b45-1e3e-4f28-89af-0e2620fcaf2d" });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 8, 20, 21, 41, 355, DateTimeKind.Utc).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 8, 20, 21, 41, 355, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 8, 20, 21, 41, 355, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 8, 20, 21, 41, 355, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 8, 20, 21, 41, 355, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 8, 20, 21, 41, 355, DateTimeKind.Utc).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 8, 20, 21, 41, 355, DateTimeKind.Utc).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 8, 20, 21, 41, 355, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 8, 20, 21, 41, 355, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 8, 20, 21, 41, 355, DateTimeKind.Utc).AddTicks(4136));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "348944c1-9ca0-4f2d-865f-fcc79ec6dc4d", "8a17331c-7e47-44d1-babd-bef847887574" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b16fa281-a224-4f5a-8397-d28667a785f8", "564116b2-cc98-47a3-af72-3b48c1c921c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a7b428f9-4bd4-4c57-a8de-39a2f9abd53e", "0ea70487-1a38-4d4e-842e-470516f09a8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "432b3b35-64f3-4c7c-94ab-a9d515d10159", "9dcd0e38-711f-45db-af42-1f23b29bad45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "62f15097-7b3f-4003-80ac-b3d03a27466d", "0698632a-4d7e-4261-8600-9d3df1bbf889" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "25b5011d-1cd0-42f1-b941-c61c87473d26", "8a0e9f2e-39d4-4ded-bbe0-9fe184fd6390" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ad67385c-fa39-412c-b104-72a31495fc15", "ff1146c1-8bf4-49bf-a15c-8c3e25bc5ce4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b7500a86-3063-4f94-80bb-1942acc3e560", "1601f772-915c-4228-ac63-2f52c516f1f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "04d6083b-2450-4938-af86-bfe541d944c6", "0e21acb0-579e-4268-94ad-8a6e97727896" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ae1455b8-2161-4568-8947-51133d6b5d3b", "a2f20e57-2e32-4b8b-b55d-dee00bcdac18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e6ec68dc-8682-48ca-ad23-f23fed76bfec", "3bb01d33-4d8b-42b7-92e4-4e0c9b46ef42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dfcff67c-fb83-4610-9359-0bb382fad142", "6248a4b9-bd70-46fc-a85e-fa0967c0f689" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8bcf3bfc-a06d-4770-b634-79ff37bafdd1", "d386ca40-a373-4558-b3e6-8e58d97b45fb" });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 21, 22, 58, 969, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 21, 22, 58, 969, DateTimeKind.Utc).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 21, 22, 58, 969, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 21, 22, 58, 969, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 21, 22, 58, 969, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 21, 22, 58, 969, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 21, 22, 58, 969, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 21, 22, 58, 969, DateTimeKind.Utc).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 21, 22, 58, 969, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 5, 21, 22, 58, 969, DateTimeKind.Utc).AddTicks(4612));
        }
    }
}
