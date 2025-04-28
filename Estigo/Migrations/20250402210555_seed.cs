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
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "courseId", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "Notes", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "Subject", "TwoFactorEnabled", "UserName", "UserType", "image" },
                values: new object[,]
                {
                    { "t1", 0, "8a6fd9e2-8514-4d90-ab08-5b47d5076030", null, "math1@estigo.com", false, "Male", false, null, "Mahmoud", "MATH1@ESTIGO.COM", "MATH1@ESTIGO.COM", "Expert in Algebra", null, null, false, "Teacher", "3353c204-da83-4352-977f-638f6d3dcec2", "Mathematics", false, "math1@estigo.com", "Teacher", null },
                    { "t10", 0, "f485b883-1a6d-442d-960a-ae34cae728ed", null, "chem3@estigo.com", false, "Male", false, null, "Fahad", "CHEM3@ESTIGO.COM", "CHEM3@ESTIGO.COM", "Skilled in Analytical Chemistry", null, null, false, "Teacher", "a201153c-e232-4537-93a1-ee30d2074082", "Chemistry", false, "chem3@estigo.com", "Teacher", null },
                    { "t11", 0, "ccd70a3a-2878-4dee-8dc7-0b8e745fed22", null, "chem4@estigo.com", false, "Female", false, null, "Sara", "CHEM4@ESTIGO.COM", "CHEM4@ESTIGO.COM", "Focused on Physical Chemistry", null, null, false, "Teacher", "2fed5d24-62b2-4454-aafa-be13a07a5aaa", "Chemistry", false, "chem4@estigo.com", "Teacher", null },
                    { "t12", 0, "056709f4-4933-4a5e-9419-413fc2943145", null, "eng1@estigo.com", false, "Female", false, null, "Sarah", "ENG1@ESTIGO.COM", "ENG1@ESTIGO.COM", "Literature Specialist", null, null, false, "Teacher", "d0cfc77e-d33d-4ad9-a6a2-708700432f06", "English", false, "eng1@estigo.com", "Teacher", null },
                    { "t13", 0, "9c267e64-1666-4b25-b5d6-815a49e4148d", null, "eng2@estigo.com", false, "Male", false, null, "John", "ENG2@ESTIGO.COM", "ENG2@ESTIGO.COM", "Expert in Creative Writing", null, null, false, "Teacher", "351bfecc-524d-4040-bfec-e990ea2115cb", "English", false, "eng2@estigo.com", "Teacher", null },
                    { "t2", 0, "7d220abe-fdba-42e9-8610-be6cfc02fe05", null, "math2@estigo.com", false, "Male", false, null, "Mousa", "MATH2@ESTIGO.COM", "MATH2@ESTIGO.COM", "Specialist in Calculus", null, null, false, "Teacher", "36a0a6a3-8e59-47bb-a6f6-f1d48e3142ff", "Mathematics", false, "math2@estigo.com", "Teacher", null },
                    { "t3", 0, "54ff9403-1f8d-4a97-a3e1-470f750a100c", null, "phys1@estigo.com", false, "Female", false, null, "Amira", "PHYS1@ESTIGO.COM", "PHYS1@ESTIGO.COM", "Specialist in Mechanics", null, null, false, "Teacher", "3ed89086-8448-4c0a-9d13-c79af6b861f1", "Physics", false, "phys1@estigo.com", "Teacher", null },
                    { "t4", 0, "24691afe-9071-46b7-869e-9a6bf138803d", null, "phys2@estigo.com", false, "Female", false, null, "Noura", "PHYS2@ESTIGO.COM", "PHYS2@ESTIGO.COM", "Expert in Electromagnetism", null, null, false, "Teacher", "63f6896e-8800-4fc1-8c58-8e7b76880013", "Physics", false, "phys2@estigo.com", "Teacher", null },
                    { "t5", 0, "c5f04491-bd3a-4412-becf-dbbdfec20ba9", null, "phys3@estigo.com", false, "Male", false, null, "Mustafa", "PHYS3@ESTIGO.COM", "PHYS3@ESTIGO.COM", "Enthusiast in Quantum Physics", null, null, false, "Teacher", "2b7fc1a2-3d00-468a-8ef5-0ddcf6e55a90", "Physics", false, "phys3@estigo.com", "Teacher", null },
                    { "t6", 0, "47d1aca6-a1ed-48cd-8eb7-8f4d99c809d9", null, "bio1@estigo.com", false, "Male", false, null, "Ahmed", "BIO1@ESTIGO.COM", "BIO1@ESTIGO.COM", "Expert in Cell Biology", null, null, false, "Teacher", "fc6a7be5-196c-47c8-8549-e99ae3376848", "Biology", false, "bio1@estigo.com", "Teacher", null },
                    { "t7", 0, "bdb96930-e9ef-4ae5-8579-2f6230acc393", null, "bio2@estigo.com", false, "Male", false, null, "Karim", "BIO2@ESTIGO.COM", "BIO2@ESTIGO.COM", "Specialist in Genetics", null, null, false, "Teacher", "b8671714-f376-4f7a-bdde-76d9b9db2173", "Biology", false, "bio2@estigo.com", "Teacher", null },
                    { "t8", 0, "1f7bd33d-3be2-4e71-af7f-460cd051d8ff", null, "chem1@estigo.com", false, "Male", false, null, "Mohamed", "CHEM1@ESTIGO.COM", "CHEM1@ESTIGO.COM", "Passionate about Organic Chemistry", null, null, false, "Teacher", "6785b589-06a0-4463-b18e-fcac50747cf6", "Chemistry", false, "chem1@estigo.com", "Teacher", null },
                    { "t9", 0, "c6b61e9c-acce-4089-88fb-4b8e49cb36c3", null, "chem2@estigo.com", false, "Female", false, null, "Noura", "CHEM2@ESTIGO.COM", "CHEM2@ESTIGO.COM", "Expert in Inorganic Chemistry", null, null, false, "Teacher", "772d87cf-9a71-40e5-bcfd-cc91f427e813", "Chemistry", false, "chem2@estigo.com", "Teacher", null }
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
                columns: new[] { "courseId", "Available", "CategoryId", "CourseTitle", "CreatedAt", "Description", "Logo", "Price", "TeacherId" },
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
                    { 17, true, 3, "Movement | Unit 3", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Principles of Movement", null, 189, "t6" },
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
                keyColumn: "courseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "courseId",
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
