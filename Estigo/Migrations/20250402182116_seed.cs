using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CourseId", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "Notes", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "Subject", "TwoFactorEnabled", "UserName", "UserType", "image" },
                values: new object[,]
                {
                    { "t1", 0, "cf612486-09e6-4c38-85dd-01724e54cac1", null, "math1@estigo.com", false, "Male", false, null, "Mahmoud", "MATH1@ESTIGO.COM", "MATH1@ESTIGO.COM", "Expert in Algebra", null, null, false, "Teacher", "d2705691-d5c1-48ec-b7fa-ee48f77954fa", "Mathematics", false, "math1@estigo.com", "Teacher", null },
                    { "t10", 0, "327bd85c-a367-47ff-b7ec-3e0433771076", null, "chem3@estigo.com", false, "Male", false, null, "Fahad", "CHEM3@ESTIGO.COM", "CHEM3@ESTIGO.COM", "Skilled in Analytical Chemistry", null, null, false, "Teacher", "929b18d0-6d13-47ae-b40f-057c8911e7b4", "Chemistry", false, "chem3@estigo.com", "Teacher", null },
                    { "t11", 0, "7b22afee-275d-486b-8a75-56e78ef7fe95", null, "chem4@estigo.com", false, "Female", false, null, "Sara", "CHEM4@ESTIGO.COM", "CHEM4@ESTIGO.COM", "Focused on Physical Chemistry", null, null, false, "Teacher", "345852ef-3850-49c0-8f76-22f188a011ef", "Chemistry", false, "chem4@estigo.com", "Teacher", null },
                    { "t12", 0, "ee472e5d-da05-4d97-9be5-6fa222778fe5", null, "eng1@estigo.com", false, "Female", false, null, "Sarah", "ENG1@ESTIGO.COM", "ENG1@ESTIGO.COM", "Literature Specialist", null, null, false, "Teacher", "44cd2c20-7b09-4f16-b4c9-d0a8c0c6949e", "English", false, "eng1@estigo.com", "Teacher", null },
                    { "t13", 0, "93714b7b-bbc9-4347-af7d-4e2b1ffaf3e3", null, "eng2@estigo.com", false, "Male", false, null, "John", "ENG2@ESTIGO.COM", "ENG2@ESTIGO.COM", "Expert in Creative Writing", null, null, false, "Teacher", "1965fa38-3ccb-4af1-aea1-423a994e091e", "English", false, "eng2@estigo.com", "Teacher", null },
                    { "t2", 0, "0628f31a-f890-418c-9d8f-9d08f6dc43da", null, "math2@estigo.com", false, "Male", false, null, "Mousa", "MATH2@ESTIGO.COM", "MATH2@ESTIGO.COM", "Specialist in Calculus", null, null, false, "Teacher", "b59f49f0-a906-4d92-a7e4-153cfd741258", "Mathematics", false, "math2@estigo.com", "Teacher", null },
                    { "t3", 0, "f5120645-4776-4428-bb39-dfe3be2f7586", null, "phys1@estigo.com", false, "Female", false, null, "Amira", "PHYS1@ESTIGO.COM", "PHYS1@ESTIGO.COM", "Specialist in Mechanics", null, null, false, "Teacher", "41332fc2-7665-4c25-a224-1b7bd66c60cf", "Physics", false, "phys1@estigo.com", "Teacher", null },
                    { "t4", 0, "d32f336d-4d3b-4aa7-8b89-93603a69bee8", null, "phys2@estigo.com", false, "Female", false, null, "Noura", "PHYS2@ESTIGO.COM", "PHYS2@ESTIGO.COM", "Expert in Electromagnetism", null, null, false, "Teacher", "44e719f0-4621-4ec7-9df5-395bf2f372c9", "Physics", false, "phys2@estigo.com", "Teacher", null },
                    { "t5", 0, "29870918-ad9e-4853-a909-7364d90f3d7d", null, "phys3@estigo.com", false, "Male", false, null, "Mustafa", "PHYS3@ESTIGO.COM", "PHYS3@ESTIGO.COM", "Enthusiast in Quantum Physics", null, null, false, "Teacher", "ac148edd-e82e-4134-85c3-027c35d0934f", "Physics", false, "phys3@estigo.com", "Teacher", null },
                    { "t6", 0, "60789199-6423-433b-825c-f602b3ab2c74", null, "bio1@estigo.com", false, "Male", false, null, "Ahmed", "BIO1@ESTIGO.COM", "BIO1@ESTIGO.COM", "Expert in Cell Biology", null, null, false, "Teacher", "afbb4b43-d28d-4e7d-8985-c4ecc866c87e", "Biology", false, "bio1@estigo.com", "Teacher", null },
                    { "t7", 0, "08a77e8f-faaf-4cea-9215-9330e6aff2ee", null, "bio2@estigo.com", false, "Male", false, null, "Karim", "BIO2@ESTIGO.COM", "BIO2@ESTIGO.COM", "Specialist in Genetics", null, null, false, "Teacher", "126bfc1a-a78c-448a-bbc1-7a64b96f15a5", "Biology", false, "bio2@estigo.com", "Teacher", null },
                    { "t8", 0, "115d9513-04a2-4648-b159-51e544679e5b", null, "chem1@estigo.com", false, "Male", false, null, "Mohamed", "CHEM1@ESTIGO.COM", "CHEM1@ESTIGO.COM", "Passionate about Organic Chemistry", null, null, false, "Teacher", "3f9e426b-0a66-49cf-b028-ceaae62bc4fc", "Chemistry", false, "chem1@estigo.com", "Teacher", null },
                    { "t9", 0, "77e41eb8-a0a0-4a28-ab46-78951798ad47", null, "chem2@estigo.com", false, "Female", false, null, "Noura", "CHEM2@ESTIGO.COM", "CHEM2@ESTIGO.COM", "Expert in Inorganic Chemistry", null, null, false, "Teacher", "521485cd-f33e-4f01-8961-c1b79175b6ba", "Chemistry", false, "chem2@estigo.com", "Teacher", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mathematics" },
                    { 2, "Physics" },
                    { 3, "Biology" },
                    { 4, "Chemistry" },
                    { 5, "English" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Available", "CategoryId", "CourseTitle", "CreatedAt", "Description", "Logo", "Price", "TeacherId" },
                values: new object[,]
                {
                    { 1, true, 1, "Algebra | Unit 1", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to algebraic concepts", null, 199, "t1" },
                    { 2, true, 1, "Calculus | Unit 2", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fundamentals of differential calculus", null, 199, "t2" },
                    { 3, true, 1, "Geometry | Unit 3", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Basics of geometric shapes and theorems", null, 189, "t1" },
                    { 4, true, 1, "Trigonometry | Unit 4", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Understanding angles and trigonometric functions", null, 189, "t2" },
                    { 5, true, 1, "Statistics | Unit 5", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to data analysis and probability", null, 179, "t1" },
                    { 6, true, 1, "Probability | Unit 6", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exploring probability theories and applications", null, 179, "t2" },
                    { 7, true, 1, "Discrete Math | Unit 7", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fundamentals of logic, set theory, and combinatorics", null, 189, "t1" },
                    { 8, true, 2, "Mechanics | Unit 1", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to Newtonian mechanics", null, 149, "t3" },
                    { 9, true, 2, "Electricity | Unit 2", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Basics of electric circuits and fields", null, 149, "t4" },
                    { 10, true, 2, "Magnetism | Unit 3", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Principles of magnetic forces and fields", null, 159, "t5" },
                    { 11, true, 2, "Optics | Unit 4", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Study of light behavior and properties", null, 159, "t3" },
                    { 12, true, 2, "Thermodynamics | Unit 5", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fundamentals of heat and energy", null, 169, "t4" },
                    { 13, true, 2, "Quantum Physics | Unit 6", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to quantum theory", null, 169, "t5" },
                    { 14, true, 2, "Relativity | Unit 7", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Concepts of special and general relativity", null, 169, "t3" },
                    { 15, true, 3, "Cell Biology | Unit 1", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Study of cell structure and function", null, 179, "t6" },
                    { 16, true, 3, "Genetics | Unit 2", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to heredity and DNA", null, 179, "t7" },
                    { 17, true, 3, "Evolution | Unit 3", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Principles of biological evolution", null, 189, "t6" },
                    { 18, true, 3, "Ecology | Unit 4", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Basics of ecosystems and environment", null, 189, "t7" },
                    { 19, true, 3, "Botany | Unit 5", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Study of plant biology and physiology", null, 179, "t6" },
                    { 20, true, 3, "Zoology | Unit 6", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to animal biology", null, 179, "t7" },
                    { 21, true, 3, "Microbiology | Unit 7", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Basics of microorganisms and their roles", null, 189, "t6" },
                    { 22, true, 4, "Organic Chemistry | Unit 1", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to organic compounds", null, 159, "t8" },
                    { 23, true, 4, "Inorganic Chemistry | Unit 2", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fundamentals of inorganic substances", null, 159, "t9" },
                    { 24, true, 4, "Physical Chemistry | Unit 3", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Study of chemical thermodynamics and kinetics", null, 169, "t10" },
                    { 25, true, 4, "Analytical Chemistry | Unit 4", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Techniques for chemical analysis", null, 169, "t11" },
                    { 26, true, 4, "Biochemistry | Unit 5", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chemical processes within living organisms", null, 179, "t8" },
                    { 27, true, 4, "Environmental Chemistry | Unit 6", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chemistry in environmental processes", null, 179, "t9" },
                    { 28, true, 4, "Theoretical Chemistry | Unit 7", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conceptual frameworks of chemical behavior", null, 169, "t10" },
                    { 29, true, 5, "Literature | Unit 1", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exploring classic and modern literature", null, 129, "t12" },
                    { 30, true, 5, "Creative Writing | Unit 2", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Develop storytelling and narrative skills", null, 129, "t13" },
                    { 31, true, 5, "Grammar & Composition | Unit 3", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mastering the rules of English grammar", null, 119, "t12" },
                    { 32, true, 5, "Poetry Analysis | Unit 4", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Study and analysis of poetry", null, 119, "t13" },
                    { 33, true, 5, "Drama & Theater | Unit 5", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to dramatic literature and performance", null, 129, "t12" },
                    { 34, true, 5, "Fiction Writing | Unit 6", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Techniques for writing compelling fiction", null, 129, "t13" },
                    { 35, true, 5, "Non-fiction Writing | Unit 7", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crafting engaging non-fiction narratives", null, 119, "t12" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "t9");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()");
        }
    }
}
