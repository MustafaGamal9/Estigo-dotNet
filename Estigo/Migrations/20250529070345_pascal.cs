using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class pascal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsLive",
                table: "lessons",
                newName: "isLive");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1982b9b6-259a-4190-b24e-681dfac60a49", "0bb38f31-2aec-4e97-98b3-61b8dd7fec36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "70159f8a-5043-4350-bff4-218a15f29ab0", "db5d5515-574b-46fc-bea3-1f4723dbb408" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "615f2d98-5f72-4723-b5d3-8b7b192f8830", "fdc28a05-6cb8-424a-8cf5-380db521ba2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0d590022-d139-4243-b1bd-ec7025da3740", "cd0d17b2-bfa4-4759-8f33-0d6f7639d41b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e7490d7c-d826-41b6-b467-755be4286638", "5c7c910e-b834-406f-aa16-d155a80a47d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e305565e-04f8-4096-8ca3-1c8e3f9c7ff2", "b394fe96-1c3c-4474-a967-7c6bb897effa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "46342bfd-27f1-496e-b712-e9f56023bfde", "b9105a47-902b-440f-b517-9f6d11a69f08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "812e11b2-d1a2-427a-b3ab-dffd961211ad", "bb8f503f-d321-440c-8a84-adeab2d39366" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4fd52932-81c6-47b6-94ff-2690a50dc197", "82636cd0-041a-4baf-a333-93ba47f6da10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e52bfcce-fa14-49c8-9af6-a9887fdf7c04", "0fa73fcd-9b33-4536-adb0-44d8465846d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a4212083-3c05-43b4-bf9a-56ececbc1af2", "304d0e33-1a77-48c8-bdc9-5a0043ae6214" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f0cbae22-a85d-4948-8771-3555867b4cd2", "0b8d0c79-94b0-468d-be27-301de814e6d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "34b50421-d788-4d72-a5b8-c508579fa7ca", "c51a8f91-43f8-4d7e-9b87-105709116d07" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isLive",
                table: "lessons",
                newName: "IsLive");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f0ae2ce8-927a-4ff4-8bb5-e189c2f59935", "2d0cfb47-2f3c-4459-978e-359ef28e9507" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6d34fb43-53fb-4e87-b752-40182aa2cfc3", "2289493f-54bf-45a9-901f-96d36e19779b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "afc6a2e8-9996-4960-9f71-6f1c7986a4b5", "a0474873-81b5-4b65-9007-f07845a98855" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e754e2ec-d41e-43d8-b419-725841366c6d", "dcf0a46e-003b-4b93-ad04-84c91ff53f80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c87a5a51-fcdb-4305-b1ac-aab99247bd14", "d7ef44fb-aee7-48ce-b2d2-2c1ebf092ed5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a00274bb-bef5-4fcc-9e89-4c0a5c646581", "689ccdc2-5638-437f-b38f-cad7f5d83c6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ab32fdb0-8aab-49ae-ae79-b150a7ad539e", "537c2452-b50a-4ccc-8cd7-74b4b0bd0bfa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7e92c885-e779-46d3-ad5b-a1d3a74d4c9d", "85f71a0e-a0c6-4755-b308-ccee4e7c74c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1aeb8e9e-6a0d-4f4c-bf0e-da3c87a0e77e", "aa034f8d-958f-4a86-b989-51424e905514" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "30826423-b786-4eb0-90a5-f5bb2be2ff83", "e0f0d79b-182a-4acd-bd77-1cb9f138f8f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "309e1126-5fad-42f0-aa68-c884b9a1478c", "9187f7fe-850a-4fba-80c4-5f13e3a3948d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4f24f994-8c5b-4294-9836-800ebedb7b48", "b5b69d0b-cc50-4c2b-b0b5-d40290c62c71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ff73841c-fd54-4fda-b2eb-49e2903e8674", "dcc4363a-4490-4348-9318-cb6d5eac5006" });
        }
    }
}
