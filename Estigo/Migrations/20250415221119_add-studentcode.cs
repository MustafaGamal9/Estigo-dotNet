using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class addstudentcode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentCode",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f122326b-c54f-4981-8a6d-fa9e35a14a8a", "d2c0293a-c50c-4a05-a9d9-b75c831b7894" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3d30e028-54c1-49da-a086-a8ee4ca89cfd", "b069c9eb-ab7f-4e80-bde3-dd8bfffdd25c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "795daf3c-37f4-4fb2-965a-c5a13a62f6e4", "740f3bf6-e2b1-4ccc-be41-2d2316e0d509" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "770d0ef6-90ac-4f0f-ad3e-067356444bbd", "40e8e074-94f2-4b50-a2c3-296424e64135" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "93843040-b3b4-497d-affc-505320c441b3", "823ea01b-3e87-4bf9-9be6-25fcf43643c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "74c7d7c0-113a-4e2a-87c6-f760eb0c2b99", "dcf45317-b9f7-4838-929f-faf618916aff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac7da726-aca8-4889-bd0f-94502110d2f7", "f4f9d405-0f07-426b-be97-bbf22010f0b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "77397133-12b0-44e5-8815-5a3b6c5de3e4", "2327cbb1-e469-442e-b92f-b87976cd5153" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b5b170a7-f77b-4a2e-94ab-1858fbf29cb4", "b9b8e944-0290-4a78-9fcd-fe6edb13becf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c3dd0b6b-7f73-4e0c-9ee4-44e21788caff", "357cac18-f066-4dab-9345-6ac3f2e882c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "98e19efb-61d2-48a5-b02e-14a4d176989b", "fc0a9451-5ae6-48be-b7fc-4218c80bda89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "41500f71-ce90-4b71-a202-7b877e1f64a6", "bb130826-4cca-4d79-b423-4a73f3a9703e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "36e8ba15-33dd-4441-becf-f7e74254bf3d", "b0b3f9f7-c589-4c80-b49c-1cbd169bd7ae" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_StudentCode",
                table: "AspNetUsers",
                column: "StudentCode",
                unique: true,
                filter: "[StudentCode] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_StudentCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StudentCode",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "10cc3ae8-7d17-45b2-b71e-5cdae5b9e688", "e70b85b3-172e-4c7e-b4b9-1e314f36fe29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1157c9a6-435c-4a99-8d30-003b73dfa765", "fb7c3567-b557-4ad4-8a05-2cc637f69216" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3ff3012a-45e4-47d0-8b76-2232bc7c92a0", "509dfffb-851c-4630-ad0f-4a4a60d968e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3aa1f434-3895-44d5-b042-69e3ac385c87", "a128ae87-fed7-4a03-bd08-867ea55142a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ebaefd3-3d63-45e1-bd6a-977697219b40", "e98d6cda-a439-418b-b365-8cee2d372f97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "74899b6d-adcd-4faa-8966-748dfdcf6d04", "b0f1d3ab-d40a-4131-9a63-dacd53e07990" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7faee7a9-245b-4f39-b169-c3750e124147", "14f96850-b33f-47c2-ba84-d6e3290ea8be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f368dd7e-0e7b-4224-bf5c-515d492d1f65", "c264d932-51cc-4d74-9c04-6e4c9c6ab217" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7bfb639c-1213-42e6-89f0-9d5ccc7a7e21", "0a235f88-1704-4edc-8ede-45e09fb3d519" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ba76a68f-ada4-4355-a130-113fae8768f1", "a8eded4d-7997-4022-a423-4dceabe6609c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1aad727b-3a86-4533-b208-228de4179d2a", "928c6c1a-c8f2-40fd-9c65-8178dfd78841" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "647ebb60-26e9-4d35-ba72-783f1957babc", "aa9caec1-30df-4d2f-b1cb-74832a7c4dd1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d191b322-7125-42d8-b032-898548eb1ce3", "610939a9-443e-4c07-9e46-a4b5b65bcb22" });
        }
    }
}
