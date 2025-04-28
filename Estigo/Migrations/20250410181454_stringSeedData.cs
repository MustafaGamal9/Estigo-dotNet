using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class stringSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "image",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "1bcb45c6-b3c0-436a-a567-69f65bc204b1", "47d77f4b-a90f-4745-8bd8-c45bd1602e54", "http://est.runasp.net/mahmoud.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "accfe0d9-6d1d-4514-a769-3e4c735a2d23", "1f60dc86-2a11-4ba7-9029-d1aa702322db", "http://est.runasp.net/f.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "6c4160a4-6b82-4594-89b9-9c76045a6804", "14517745-e44b-4077-8b93-0cf07c5016ea", "http://est.runasp.net/sarah.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "9a15520e-e409-42f5-bad1-ea1537beab1b", "7425ac29-93e0-4e8c-9b09-6dbfa662fb63", "http://est.runasp.net/amira.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "c483daad-4d47-4827-9c8f-51f2bd8e50d2", "898696ed-aa2a-4fca-af98-c2eb5af419ba", "http://est.runasp.net/f.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "23b00310-9998-435c-b01a-9a04dc228051", "acc92ffa-22aa-4cd9-9885-0a63864700b6", "http://est.runasp.net/b.jpeg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "1150e36f-679a-419b-96fa-3f28bb9509ac", "0ecf48d7-297b-452b-a1bb-85a4aa8a31c2", "http://est.runasp.net/g.jpeg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "eb72e830-29e7-40cd-8328-bc8098ebf61b", "60472f62-061a-46fb-8e4d-e24590650670", "http://est.runasp.net/q.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "e7af0672-aab2-422b-b559-e0194004de0c", "c7227624-8ffe-4bf3-aed3-0ffeb633db00", "http://est.runasp.net/b.jpeg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "48c7429a-ec23-4bca-b422-d5b01950729e", "d4c7618a-f00e-4863-bf34-573d500d0470", "http://est.runasp.net/c.jpeg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "b0dbd9ee-05db-40fc-b4be-494552865d67", "440468ab-ba2f-447a-b984-e16a808b60c9", "http://est.runasp.net/d.jpeg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "98cd2e31-529e-4086-9d12-01ffdd53263c", "56204be7-8a06-424d-88d4-a66593be1971", "http://est.runasp.net/f.jpg" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "2fc99843-83ac-43f0-83d4-313efc37ccc8", "61a323a4-1710-480a-b715-5b2b34d5bf5f", "http://est.runasp.net/m.jpg" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 1,
                column: "Logo",
                value: "http://est.runasp.net/algebra.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 2,
                column: "Logo",
                value: "http://est.runasp.net/calculas.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 3,
                column: "Logo",
                value: "http://est.runasp.net/geo.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 4,
                column: "Logo",
                value: "http://est.runasp.net/trig.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 5,
                column: "Logo",
                value: "http://est.runasp.net/stat.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 6,
                column: "Logo",
                value: "http://est.runasp.net/jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 7,
                column: "Logo",
                value: "http://est.runasp.net/disc.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 8,
                column: "Logo",
                value: "http://est.runasp.net/mecha.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 9,
                column: "Logo",
                value: "http://est.runasp.net/elec.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 10,
                column: "Logo",
                value: "http://est.runasp.net/iron.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 11,
                column: "Logo",
                value: "http://est.runasp.net/optics.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 12,
                column: "Logo",
                value: "http://est.runasp.net/thermo.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 13,
                column: "Logo",
                value: "http://est.runasp.net/quant.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 14,
                column: "Logo",
                value: "http://est.runasp.net/rela.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 15,
                column: "Logo",
                value: "http://est.runasp.net/cell/jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 16,
                column: "Logo",
                value: "http://est.runasp.net/gena.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 17,
                column: "Logo",
                value: "http://est.runasp.net/move.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 18,
                column: "Logo",
                value: "http://est.runasp.net/eco.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 19,
                column: "Logo",
                value: "http://est.runasp.net/elec.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 20,
                column: "Logo",
                value: "http://est.runasp.net/zoo.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 21,
                column: "Logo",
                value: "http://est.runasp.net/micro.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 22,
                column: "Logo",
                value: "http://est.runasp.net/organic.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 23,
                column: "Logo",
                value: "http://est.runasp.net/inorganic.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 24,
                column: "Logo",
                value: "http://est.runasp.net/physChem.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 25,
                column: "Logo",
                value: "http://est.runasp.net/analyt.png");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 26,
                column: "Logo",
                value: "http://est.runasp.net/biochem.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 27,
                column: "Logo",
                value: "http://est.runasp.net/env.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 28,
                column: "Logo",
                value: "http://est.runasp.net/theo.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 29,
                column: "Logo",
                value: "http://est.runasp.net/lit.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 30,
                column: "Logo",
                value: "http://est.runasp.net/write.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 31,
                column: "Logo",
                value: "http://est.runasp.net/gram.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 32,
                column: "Logo",
                value: "http://est.runasp.net/poe.png");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 33,
                column: "Logo",
                value: "http://est.runasp.net/drama.jpg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 34,
                column: "Logo",
                value: "http://est.runasp.net/fiction.jpeg");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 35,
                column: "Logo",
                value: "http://est.runasp.net/nonfic.jpg");

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

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 11,
                column: "lessonVideo",
                value: "http://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 12,
                column: "lessonVideo",
                value: "http://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 13,
                column: "lessonVideo",
                value: "http://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 14,
                column: "lessonVideo",
                value: "http://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 15,
                column: "lessonVideo",
                value: "http://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 16,
                column: "lessonVideo",
                value: "http://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 17,
                column: "lessonVideo",
                value: "http://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 18,
                column: "lessonVideo",
                value: "http://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 19,
                column: "lessonVideo",
                value: "http://est.runasp.net/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 20,
                column: "lessonVideo",
                value: "http://est.runasp.net/vv.mp4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Logo",
                table: "Courses",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "image",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "348944c1-9ca0-4f2d-865f-fcc79ec6dc4d", "8a17331c-7e47-44d1-babd-bef847887574", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "b16fa281-a224-4f5a-8397-d28667a785f8", "564116b2-cc98-47a3-af72-3b48c1c921c0", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "a7b428f9-4bd4-4c57-a8de-39a2f9abd53e", "0ea70487-1a38-4d4e-842e-470516f09a8b", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "432b3b35-64f3-4c7c-94ab-a9d515d10159", "9dcd0e38-711f-45db-af42-1f23b29bad45", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "62f15097-7b3f-4003-80ac-b3d03a27466d", "0698632a-4d7e-4261-8600-9d3df1bbf889", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "25b5011d-1cd0-42f1-b941-c61c87473d26", "8a0e9f2e-39d4-4ded-bbe0-9fe184fd6390", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "ad67385c-fa39-412c-b104-72a31495fc15", "ff1146c1-8bf4-49bf-a15c-8c3e25bc5ce4", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "b7500a86-3063-4f94-80bb-1942acc3e560", "1601f772-915c-4228-ac63-2f52c516f1f1", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "04d6083b-2450-4938-af86-bfe541d944c6", "0e21acb0-579e-4268-94ad-8a6e97727896", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "ae1455b8-2161-4568-8947-51133d6b5d3b", "a2f20e57-2e32-4b8b-b55d-dee00bcdac18", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "e6ec68dc-8682-48ca-ad23-f23fed76bfec", "3bb01d33-4d8b-42b7-92e4-4e0c9b46ef42", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "dfcff67c-fb83-4610-9359-0bb382fad142", "6248a4b9-bd70-46fc-a85e-fa0967c0f689", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "image" },
                values: new object[] { "8bcf3bfc-a06d-4770-b634-79ff37bafdd1", "d386ca40-a373-4558-b3e6-8e58d97b45fb", null });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 1,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 2,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 3,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 4,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 5,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 6,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 7,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 8,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 9,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 10,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 11,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 12,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 13,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 14,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 15,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 16,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 17,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 18,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 19,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 20,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 21,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 22,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 23,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 24,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 25,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 26,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 27,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 28,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 29,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 30,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 31,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 32,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 33,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 34,
                column: "Logo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 35,
                column: "Logo",
                value: null);

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

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 11,
                column: "lessonVideo",
                value: "http://localhost:5070/vv.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 12,
                column: "lessonVideo",
                value: "http://localhost:5070/cat.mp4");

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

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 15,
                column: "lessonVideo",
                value: "http://path/to/lesson5_video.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 16,
                column: "lessonVideo",
                value: "http://path/to/lesson1_video.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 17,
                column: "lessonVideo",
                value: "http://path/to/lesson2_video.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 18,
                column: "lessonVideo",
                value: "http://path/to/lesson3_video.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 19,
                column: "lessonVideo",
                value: "http://path/to/lesson4_video.mp4");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 20,
                column: "lessonVideo",
                value: "http://path/to/lesson5_video.mp4");
        }
    }
}
