using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class modelAttr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "attendance",
                table: "MyCourses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "attempts",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "final",
                table: "Exams",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c8d764cb-aaa3-47ae-b8e7-b829f81487f9", "df124ab1-f82c-4964-a6cf-89a04c5ce3ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a4921a25-145e-4cc5-b142-8fa2a5cb25b0", "16d336de-c3d9-464c-b9d5-2743923a94c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "03b589b8-489e-47b0-932c-d6d003907ba7", "6d48fd35-8f6b-48bb-926a-c5ec6cfccf15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a46996d6-597b-4092-ade3-8c69dbe914cb", "6ba8ddbd-b1b6-42ec-80be-1c6865b3201c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4dd58e96-9d22-4b14-a9fd-9f1de33faace", "e2332e8a-373f-44ad-81c8-f96fc70a2fab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6845d5ea-4383-4ac8-aca6-3ca455354c06", "e1ff1b04-09de-44ee-adc1-36b6c9ec1ed0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "10758ca6-5ec1-4820-aa62-4d3dc10576a6", "91a4bc6d-cef5-46dc-b6fd-419df674964d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "88c03e1c-1c3d-46e1-82ae-b35f104d9409", "d57b5259-5120-4198-9265-48283e51edf7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3096cd73-9e55-44bd-9238-5700642ce594", "c88e9ac9-618d-41a8-8b96-ca6e790c563e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "03c70d72-6428-4b63-9f69-64447d8c60cb", "2ee9e16e-516f-4340-8923-54bfdae1bc09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "83c48b45-4acf-40f5-926c-b5c893b0c96d", "94f45869-5851-4119-a162-95d789ef6ea4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86076b2f-5122-44f4-8851-070dee224d47", "cf652c96-47c3-4c50-aef0-c384c2bf38b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ec3916c1-1abb-4b0e-b002-4e28c43b6d45", "9a01add1-704e-4793-a449-4fdc2e96f431" });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "attempts", "final" },
                values: new object[] { 0, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "attendance",
                table: "MyCourses");

            migrationBuilder.DropColumn(
                name: "attempts",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "final",
                table: "Exams");

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
        }
    }
}
