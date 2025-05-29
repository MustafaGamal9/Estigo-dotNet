using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class fixCourseLive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLive",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "LiveLink",
                table: "Courses");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsLive",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LiveLink",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "501907e7-642f-4fd9-822a-8e1885fa5298", "6e2e4d62-7c36-4685-a0a5-982e0403fa1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fa23d3d2-4f28-41a4-b4c9-c9d45000a0ca", "5c396b81-bd2e-46a8-9310-5569733aacfb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "39607e20-a6af-4d2b-b857-df8d05ef6039", "fdaba976-9dee-4641-99ef-0b15c26756d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "32c234b1-419e-4d70-8f8c-7b1a67ef5d01", "823d135c-253f-426c-9b40-9c69bd14e02c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "354bb1c5-08fd-4698-ab37-0e9d96fa0a3f", "41b834b7-8521-4f93-95b9-a57d8966d544" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0e185ec3-46fc-4091-ad67-288ef3a33ed7", "4c09e649-6f40-4a70-97be-94ee20ef2779" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3ad9db08-0ea2-4627-947b-0258131da131", "d3e1b96f-ffaf-4b1d-9f4a-c193e5df2ab9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0992a02c-ba92-4caf-ab2a-2411253f1f1e", "03c4022a-fb53-4ec4-bb91-1af909f7ea06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "68758145-b19a-44b5-bcb6-39778203d975", "9e823e61-9fbc-44fc-9d64-96064491d356" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c5c0d66f-b3e8-4796-bdd2-fb97524df7f8", "15bc310b-b955-4ef2-90f8-37185cde0418" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2a61cf69-8599-45b0-b9a8-3cf213afadac", "47eb43aa-2f21-4b02-b14d-d2bd04e87526" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "88be9ef0-4ab5-439b-9cee-6a03c4bb37e5", "ded11417-bde0-4c35-a0f8-7e09f89d6dcb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d4953efa-e738-453c-b824-ffbb330aa099", "06a941f0-3d95-4a66-8ed0-19df51fe4ef2" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 1,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 2,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 3,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 4,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 5,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 6,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 7,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 8,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 9,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 10,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 11,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 12,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 13,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 14,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 15,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 16,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 17,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 18,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 19,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 20,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 21,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 22,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 23,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 24,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 25,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 26,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 27,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 28,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 29,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 30,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 31,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 32,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 33,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 34,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 35,
                columns: new[] { "IsLive", "LiveLink" },
                values: new object[] { false, null });
        }
    }
}
