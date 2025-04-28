using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class fixSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "db05f9cf-d26c-4a5f-8f8d-a50526612dce", "3097e660-0a4e-4132-85a7-f322819862ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0a39e060-4508-4d45-a4c2-eadab4068ad2", "03befeca-6629-4fee-9e27-ef71bbaeede9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d88bcd4d-af67-43ec-9db6-d5057240dfa0", "2c7c47d3-68b0-4ab5-ba30-71db895e1136" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8171160f-8a46-458e-b453-626a9de628c7", "b89ad5f5-c6ff-4f1c-92aa-5ffa51870f9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6aeeb85e-022d-4e3b-86c3-2084e01229c9", "62d82726-06eb-444d-89f9-e6199b151096" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e303201a-efe3-4fdc-a1b5-7b107a19a211", "0213ee65-1874-4650-b73f-4c9608965e03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "27e2ad54-f343-4a1d-84aa-1bc5ea2e8b94", "671b8bc3-b094-4d3a-9e3f-0a4e379a0ee9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "36aa0aab-33ed-49b0-87f1-1a4dd4d1348d", "8ed074d7-3d72-4683-a300-815975f103c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cf11befe-ea43-4f6c-bc61-fff1c5ad2851", "3829d755-bbe2-4be0-9b65-7e68b346f107" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "80c7785a-3777-4821-987a-1176bf7a278a", "4909a56b-8348-48c3-9473-eb826364c513" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "12e150b0-72cc-4aac-8564-e85fe1179f5a", "d472ec0f-bfe0-4cd2-919a-503a2265ad1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f941f802-f99d-4335-ae98-632c894ab281", "df01d2ae-fc0b-4605-acf9-d35f28636a77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d9eddc4e-c7f8-4b98-bda2-5d670d0c7fd8", "daf143ae-ad98-4ecb-99e3-18ab0d0c58cc" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 15,
                column: "Logo",
                value: "http://est.runasp.net/cell.jpg");

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 18, 18, 22, 759, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 18, 18, 22, 759, DateTimeKind.Utc).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 18, 18, 22, 759, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 18, 18, 22, 759, DateTimeKind.Utc).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 18, 18, 22, 759, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 18, 18, 22, 759, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 18, 18, 22, 759, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 18, 18, 22, 759, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 18, 18, 22, 759, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 18, 18, 22, 759, DateTimeKind.Utc).AddTicks(6731));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1bcb45c6-b3c0-436a-a567-69f65bc204b1", "47d77f4b-a90f-4745-8bd8-c45bd1602e54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "accfe0d9-6d1d-4514-a769-3e4c735a2d23", "1f60dc86-2a11-4ba7-9029-d1aa702322db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6c4160a4-6b82-4594-89b9-9c76045a6804", "14517745-e44b-4077-8b93-0cf07c5016ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9a15520e-e409-42f5-bad1-ea1537beab1b", "7425ac29-93e0-4e8c-9b09-6dbfa662fb63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c483daad-4d47-4827-9c8f-51f2bd8e50d2", "898696ed-aa2a-4fca-af98-c2eb5af419ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "23b00310-9998-435c-b01a-9a04dc228051", "acc92ffa-22aa-4cd9-9885-0a63864700b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1150e36f-679a-419b-96fa-3f28bb9509ac", "0ecf48d7-297b-452b-a1bb-85a4aa8a31c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eb72e830-29e7-40cd-8328-bc8098ebf61b", "60472f62-061a-46fb-8e4d-e24590650670" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e7af0672-aab2-422b-b559-e0194004de0c", "c7227624-8ffe-4bf3-aed3-0ffeb633db00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "48c7429a-ec23-4bca-b422-d5b01950729e", "d4c7618a-f00e-4863-bf34-573d500d0470" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b0dbd9ee-05db-40fc-b4be-494552865d67", "440468ab-ba2f-447a-b984-e16a808b60c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "98cd2e31-529e-4086-9d12-01ffdd53263c", "56204be7-8a06-424d-88d4-a66593be1971" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2fc99843-83ac-43f0-83d4-313efc37ccc8", "61a323a4-1710-480a-b715-5b2b34d5bf5f" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 15,
                column: "Logo",
                value: "http://est.runasp.net/cell/jpg");

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 18, 14, 53, 744, DateTimeKind.Utc).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 18, 14, 53, 744, DateTimeKind.Utc).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 18, 14, 53, 744, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 18, 14, 53, 744, DateTimeKind.Utc).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 18, 14, 53, 744, DateTimeKind.Utc).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 18, 14, 53, 744, DateTimeKind.Utc).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 18, 14, 53, 744, DateTimeKind.Utc).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 18, 14, 53, 744, DateTimeKind.Utc).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 18, 14, 53, 744, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 10, 18, 14, 53, 744, DateTimeKind.Utc).AddTicks(3442));
        }
    }
}
