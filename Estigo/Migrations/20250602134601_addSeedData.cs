﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class addSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "courseId", "Available", "CategoryId", "CourseTitle", "CreatedAt", "Description", "Logo", "Price", "Status", "TeacherId" },
                values: new object[,]
                {
                    { 1, true, 1, "Algebra | Unit 1", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to algebraic concepts", "https://estigo.runasp.net/u1.jpg", 199, 1, "f3000e69-e194-41ec-acb3-4a3d41253987" },
                    { 2, true, 1, "Calculus | Unit 2", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fundamentals of differential calculus", "https://estigo.runasp.net/u2.jpg", 199, 1, "f3000e69-e194-41ec-acb3-4a3d41253987" },
                    { 3, true, 1, "Geometry | Unit 3", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Basics of geometric shapes and theorems", "https://estigo.runasp.net/u3.jpg", 189, 1, "f3000e69-e194-41ec-acb3-4a3d41253987" },
                    { 4, true, 1, "Trigonometry | Unit 4", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Understanding angles and trigonometric functions", "https://estigo.runasp.net/u4.jpg", 189, 1, "f3000e69-e194-41ec-acb3-4a3d41253987" },
                    { 5, true, 1, "Statistics | Unit 5", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to data analysis and probability", "https://estigo.runasp.net/u5.jpg", 179, 1, "f3000e69-e194-41ec-acb3-4a3d41253987" },
                    { 6, true, 1, "Probability | Unit 6", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exploring probability theories and applications", "https://estigo.runasp.net/u6.jpg", 179, 1, "f3000e69-e194-41ec-acb3-4a3d41253987" },
                    { 7, true, 1, "Discrete Math | Unit 7", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fundamentals of logic, set theory, and combinatorics", "https://estigo.runasp.net/u7.jpg", 189, 1, "f3000e69-e194-41ec-acb3-4a3d41253987" },
                    { 8, true, 2, "Mechanics | Unit 1", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to Newtonian mechanics", "https://estigo.runasp.net/f1.jpg", 149, 1, "22f718af-7a07-48a3-a501-a032466aeef2" },
                    { 9, true, 2, "Electricity | Unit 2", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Basics of electric circuits and fields", "https://estigo.runasp.net/f2.jpg", 149, 1, "22f718af-7a07-48a3-a501-a032466aeef2" },
                    { 10, true, 2, "Magnetism | Unit 3", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Principles of magnetic forces and fields", "https://estigo.runasp.net/f3.jpg", 159, 1, "22f718af-7a07-48a3-a501-a032466aeef2" },
                    { 11, true, 2, "Optics | Unit 4", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Study of light behavior and properties", "https://estigo.runasp.net/f4.jpg", 159, 1, "22f718af-7a07-48a3-a501-a032466aeef2" },
                    { 12, true, 2, "Thermodynamics | Unit 5", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fundamentals of heat and energy", "https://estigo.runasp.net/f5.jpg", 169, 1, "22f718af-7a07-48a3-a501-a032466aeef2" },
                    { 13, true, 2, "Quantum Physics | Unit 6", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to quantum theory", "https://estigo.runasp.net/f6.jpg", 169, 1, "22f718af-7a07-48a3-a501-a032466aeef2" },
                    { 14, true, 2, "Relativity | Unit 7", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Concepts of special and general relativity", "https://estigo.runasp.net/f7.jpg", 169, 1, "22f718af-7a07-48a3-a501-a032466aeef2" },
                    { 15, true, 3, "Cell Biology | Unit 1", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Study of cell structure and function", "https://estigo.runasp.net/uu1.jpg", 179, 1, "dbac4aa8-2cdb-4a66-9080-23ddf8fde838" },
                    { 16, true, 3, "Genetics | Unit 2", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to heredity and DNA", "https://estigo.runasp.net/uu2.jpg", 179, 1, "dbac4aa8-2cdb-4a66-9080-23ddf8fde838" },
                    { 17, true, 3, "Movement | Unit 3", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Principles of Movement", "https://estigo.runasp.net/uu3.jpg", 189, 1, "dbac4aa8-2cdb-4a66-9080-23ddf8fde838" },
                    { 18, true, 3, "Ecology | Unit 4", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Basics of ecosystems and environment", "https://estigo.runasp.net/uu4.jpg", 189, 1, "dbac4aa8-2cdb-4a66-9080-23ddf8fde838" },
                    { 19, true, 3, "Botany | Unit 5", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Study of plant biology and physiology", "https://estigo.runasp.net/uu5.jpg", 179, 1, "dbac4aa8-2cdb-4a66-9080-23ddf8fde838" },
                    { 20, true, 3, "Zoology | Unit 6", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to animal biology", "https://estigo.runasp.net/uu6.jpg", 179, 1, "dbac4aa8-2cdb-4a66-9080-23ddf8fde838" },
                    { 21, true, 3, "Microbiology | Unit 7", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Basics of microorganisms and their roles", "https://estigo.runasp.net/uu7.jpg", 189, 1, "dbac4aa8-2cdb-4a66-9080-23ddf8fde838" },
                    { 22, true, 4, "Organic Chemistry | Unit 1", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to organic compounds", "https://estigo.runasp.net/y1.jpg", 159, 1, "bb3a1427-d95f-4cbe-9a12-1841e6c3ead9" },
                    { 23, true, 4, "Inorganic Chemistry | Unit 2", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fundamentals of inorganic substances", "https://estigo.runasp.net/y2.jpg", 159, 1, "bb3a1427-d95f-4cbe-9a12-1841e6c3ead9" },
                    { 24, true, 4, "Physical Chemistry | Unit 3", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Study of chemical thermodynamics and kinetics", "https://estigo.runasp.net/y3.jpg", 169, 1, "bb3a1427-d95f-4cbe-9a12-1841e6c3ead9" },
                    { 25, true, 4, "Analytical Chemistry | Unit 4", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Techniques for chemical analysis", "https://estigo.runasp.net/y4.jpg", 169, 1, "bb3a1427-d95f-4cbe-9a12-1841e6c3ead9" },
                    { 26, true, 4, "Biochemistry | Unit 5", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chemical processes within living organisms", "https://estigo.runasp.net/y5.jpg", 179, 1, "bb3a1427-d95f-4cbe-9a12-1841e6c3ead9" },
                    { 27, true, 4, "Environmental Chemistry | Unit 6", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chemistry in environmental processes", "https://estigo.runasp.net/y6.jpg", 179, 1, "bb3a1427-d95f-4cbe-9a12-1841e6c3ead9" },
                    { 28, true, 4, "Theoretical Chemistry | Unit 7", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conceptual frameworks of chemical behavior", "https://estigo.runasp.net/y7.jpg", 169, 1, "bb3a1427-d95f-4cbe-9a12-1841e6c3ead9" },
                    { 29, true, 5, "Literature | Unit 1", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Exploring classic and modern literature", "https://estigo.runasp.net/m1.jpg", 129, 1, "290f0fe9-c8cb-4a6e-b863-b61df939f025" },
                    { 30, true, 5, "Creative Writing | Unit 2", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Develop storytelling and narrative skills", "https://estigo.runasp.net/m2.jpg", 129, 1, "290f0fe9-c8cb-4a6e-b863-b61df939f025" },
                    { 31, true, 5, "Grammar & Composition | Unit 3", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mastering the rules of English grammar", "https://estigo.runasp.net/m3.jpg", 119, 1, "290f0fe9-c8cb-4a6e-b863-b61df939f025" },
                    { 32, true, 5, "Poetry Analysis | Unit 4", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Study and analysis of poetry", "https://estigo.runasp.net/m4.jpg", 119, 1, "290f0fe9-c8cb-4a6e-b863-b61df939f025" },
                    { 33, true, 5, "Drama & Theater | Unit 5", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Introduction to dramatic literature and performance", "https://estigo.runasp.net/m5.jpg", 129, 1, "290f0fe9-c8cb-4a6e-b863-b61df939f025" },
                    { 34, true, 5, "Fiction Writing | Unit 6", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Techniques for writing compelling fiction", "https://estigo.runasp.net/m6.jpg", 129, 1, "290f0fe9-c8cb-4a6e-b863-b61df939f025" },
                    { 35, true, 5, "Non-fiction Writing | Unit 7", new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crafting engaging non-fiction narratives", "https://estigo.runasp.net/m7.jpg", 119, 1, "290f0fe9-c8cb-4a6e-b863-b61df939f025" }
                });

            migrationBuilder.InsertData(
                table: "lessons",
                columns: new[] { "lessonId", "courseId", "isLive", "lessonTitle", "lessonVideo" },
                values: new object[,]
                {
                    { 1, 1, false, "Algebra Basics", "https://estigo.runasp.net/vv.mp4" },
                    { 2, 1, false, "Solving Linear Equations", "https://estigo.runasp.net/vv.mp4" },
                    { 3, 1, false, "Inequalities", "https://estigo.runasp.net/vv.mp4" },
                    { 4, 1, false, "Functions Introduction", "https://estigo.runasp.net/vv.mp4" },
                    { 5, 1, false, "Polynomial Basics", "https://estigo.runasp.net/vv.mp4" },
                    { 6, 2, false, "Limits and Continuity", "https://estigo.runasp.net/vv.mp4" },
                    { 7, 2, false, "Introduction to Derivatives", "https://estigo.runasp.net/vv.mp4" },
                    { 8, 2, false, "Differentiation Techniques", "https://estigo.runasp.net/vv.mp4" },
                    { 9, 2, false, "Applications of Derivatives", "https://estigo.runasp.net/vv.mp4" },
                    { 10, 2, false, "Introduction to Integrals", "https://estigo.runasp.net/vv.mp4" },
                    { 11, 3, false, "Points, Lines, and Planes", "https://estigo.runasp.net/vv.mp4" },
                    { 12, 3, false, "Angles and Angle Relationships", "https://estigo.runasp.net/vv.mp4" },
                    { 13, 3, false, "Parallel Lines and Transversals", "https://estigo.runasp.net/vv.mp4" },
                    { 14, 3, false, "Triangles and Congruence", "https://estigo.runasp.net/vv.mp4" },
                    { 15, 3, false, "Introduction to Polygons", "https://estigo.runasp.net/vv.mp4" },
                    { 16, 4, false, "Right Triangle Trigonometry", "https://estigo.runasp.net/vv.mp4" },
                    { 17, 4, false, "The Unit Circle", "https://estigo.runasp.net/vv.mp4" },
                    { 18, 4, false, "Trigonometric Graphs", "https://estigo.runasp.net/vv.mp4" },
                    { 19, 4, false, "Trigonometric Identities", "https://estigo.runasp.net/vv.mp4" },
                    { 20, 4, false, "Solving Trigonometric Equations", "https://estigo.runasp.net/vv.mp4" },
                    { 21, 5, false, "Introduction to Statistics", "https://estigo.runasp.net/vv.mp4" },
                    { 22, 5, false, "Descriptive Statistics", "https://estigo.runasp.net/vv.mp4" },
                    { 23, 5, false, "Data Visualization", "https://estigo.runasp.net/vv.mp4" },
                    { 24, 5, false, "Basic Probability Concepts", "https://estigo.runasp.net/vv.mp4" },
                    { 25, 5, false, "Introduction to Distributions", "https://estigo.runasp.net/vv.mp4" },
                    { 26, 6, false, "Foundations of Probability", "https://estigo.runasp.net/vv.mp4" },
                    { 27, 6, false, "Conditional Probability and Independence", "https://estigo.runasp.net/vv.mp4" },
                    { 28, 6, false, "Random Variables", "https://estigo.runasp.net/vv.mp4" },
                    { 29, 6, false, "Expected Value and Variance", "https://estigo.runasp.net/vv.mp4" },
                    { 30, 6, false, "Common Probability Distributions", "https://estigo.runasp.net/vv.mp4" },
                    { 31, 7, false, "Logic and Proofs", "https://estigo.runasp.net/vv.mp4" },
                    { 32, 7, false, "Set Theory", "https://estigo.runasp.net/vv.mp4" },
                    { 33, 7, false, "Counting Principles", "https://estigo.runasp.net/vv.mp4" },
                    { 34, 7, false, "Relations and Functions", "https://estigo.runasp.net/vv.mp4" },
                    { 35, 7, false, "Introduction to Graph Theory", "https://estigo.runasp.net/vv.mp4" },
                    { 36, 8, false, "Kinematics in One Dimension", "https://estigo.runasp.net/vv.mp4" },
                    { 37, 8, false, "Vectors and 2D Kinematics", "https://estigo.runasp.net/vv.mp4" },
                    { 38, 8, false, "Newton's Laws of Motion", "https://estigo.runasp.net/vv.mp4" },
                    { 39, 8, false, "Work, Energy, and Power", "https://estigo.runasp.net/vv.mp4" },
                    { 40, 8, false, "Momentum and Collisions", "https://estigo.runasp.net/vv.mp4" },
                    { 41, 9, false, "Electric Charge and Coulomb's Law", "https://estigo.runasp.net/vv.mp4" },
                    { 42, 9, false, "Electric Fields", "https://estigo.runasp.net/vv.mp4" },
                    { 43, 9, false, "Electric Potential", "https://estigo.runasp.net/vv.mp4" },
                    { 44, 9, false, "Capacitance", "https://estigo.runasp.net/vv.mp4" },
                    { 45, 9, false, "Current, Resistance, and Ohm's Law", "https://estigo.runasp.net/vv.mp4" },
                    { 46, 10, false, "Magnetic Fields and Forces", "https://estigo.runasp.net/vv.mp4" },
                    { 47, 10, false, "Sources of Magnetic Fields", "https://estigo.runasp.net/vv.mp4" },
                    { 48, 10, false, "Ampere's Law", "https://estigo.runasp.net/vv.mp4" },
                    { 49, 10, false, "Electromagnetic Induction", "https://estigo.runasp.net/vv.mp4" },
                    { 50, 10, false, "Inductance", "https://estigo.runasp.net/vv.mp4" },
                    { 51, 11, false, "Nature of Light", "https://estigo.runasp.net/vv.mp4" },
                    { 52, 11, false, "Reflection and Refraction", "https://estigo.runasp.net/vv.mp4" },
                    { 53, 11, false, "Lenses and Image Formation", "https://estigo.runasp.net/vv.mp4" },
                    { 54, 11, false, "Wave Optics: Interference", "https://estigo.runasp.net/vv.mp4" },
                    { 55, 11, false, "Wave Optics: Diffraction", "https://estigo.runasp.net/vv.mp4" },
                    { 56, 12, false, "Temperature and Heat", "https://estigo.runasp.net/vv.mp4" },
                    { 57, 12, false, "First Law of Thermodynamics", "https://estigo.runasp.net/vv.mp4" },
                    { 58, 12, false, "Ideal Gas Law", "https://estigo.runasp.net/vv.mp4" },
                    { 59, 12, false, "Second Law of Thermodynamics", "https://estigo.runasp.net/vv.mp4" },
                    { 60, 12, false, "Thermodynamic Cycles", "https://estigo.runasp.net/vv.mp4" },
                    { 61, 13, false, "Blackbody Radiation & Planck's Hypothesis", "https://estigo.runasp.net/vv.mp4" },
                    { 62, 13, false, "Photoelectric Effect", "https://estigo.runasp.net/vv.mp4" },
                    { 63, 13, false, "Wave Nature of Matter", "https://estigo.runasp.net/vv.mp4" },
                    { 64, 13, false, "The Bohr Model", "https://estigo.runasp.net/vv.mp4" },
                    { 65, 13, false, "Introduction to Quantum Mechanics", "https://estigo.runasp.net/vv.mp4" },
                    { 66, 14, false, "Principles of Special Relativity", "https://estigo.runasp.net/vv.mp4" },
                    { 67, 14, false, "Time Dilation and Length Contraction", "https://estigo.runasp.net/vv.mp4" },
                    { 68, 14, false, "Relativistic Momentum and Energy", "https://estigo.runasp.net/vv.mp4" },
                    { 69, 14, false, "Introduction to General Relativity", "https://estigo.runasp.net/vv.mp4" },
                    { 70, 14, false, "Consequences of General Relativity", "https://estigo.runasp.net/vv.mp4" },
                    { 71, 15, false, "Introduction to Cells", "https://estigo.runasp.net/vv.mp4" },
                    { 72, 15, false, "Cell Membrane Structure and Function", "https://estigo.runasp.net/vv.mp4" },
                    { 73, 15, false, "Eukaryotic Organelles", "https://estigo.runasp.net/vv.mp4" },
                    { 74, 15, false, "Cellular Respiration", "https://estigo.runasp.net/vv.mp4" },
                    { 75, 15, false, "The Cell Cycle and Mitosis", "https://estigo.runasp.net/vv.mp4" },
                    { 76, 16, false, "Mendelian Genetics", "https://estigo.runasp.net/vv.mp4" },
                    { 77, 16, false, "DNA Structure and Replication", "https://estigo.runasp.net/vv.mp4" },
                    { 78, 16, false, "Gene Expression: Transcription", "https://estigo.runasp.net/vv.mp4" },
                    { 79, 16, false, "Gene Expression: Translation", "https://estigo.runasp.net/vv.mp4" },
                    { 80, 16, false, "Mutations and Genetic Variation", "https://estigo.runasp.net/vv.mp4" },
                    { 81, 17, false, "Skeletal Systems", "https://estigo.runasp.net/vv.mp4" },
                    { 82, 17, false, "Muscular Systems", "https://estigo.runasp.net/vv.mp4" },
                    { 83, 17, false, "Biomechanics Basics", "https://estigo.runasp.net/vv.mp4" },
                    { 84, 17, false, "Locomotion in Animals", "https://estigo.runasp.net/vv.mp4" },
                    { 85, 17, false, "Nervous System Control of Movement", "https://estigo.runasp.net/vv.mp4" },
                    { 86, 18, false, "Introduction to Ecology", "https://estigo.runasp.net/vv.mp4" },
                    { 87, 18, false, "Population Ecology", "https://estigo.runasp.net/vv.mp4" },
                    { 88, 18, false, "Community Ecology", "https://estigo.runasp.net/vv.mp4" },
                    { 89, 18, false, "Ecosystem Dynamics", "https://estigo.runasp.net/vv.mp4" },
                    { 90, 18, false, "Biomes and Conservation", "https://estigo.runasp.net/vv.mp4" },
                    { 91, 19, false, "Plant Structure and Growth", "https://estigo.runasp.net/vv.mp4" },
                    { 92, 19, false, "Plant Transport Systems", "https://estigo.runasp.net/vv.mp4" },
                    { 93, 19, false, "Photosynthesis", "https://estigo.runasp.net/vv.mp4" },
                    { 94, 19, false, "Plant Reproduction", "https://estigo.runasp.net/vv.mp4" },
                    { 95, 19, false, "Plant Hormones and Responses", "https://estigo.runasp.net/vv.mp4" },
                    { 96, 20, false, "Introduction to Animal Diversity", "https://estigo.runasp.net/vv.mp4" },
                    { 97, 20, false, "Invertebrate Zoology I", "https://estigo.runasp.net/vv.mp4" },
                    { 98, 20, false, "Invertebrate Zoology II", "https://estigo.runasp.net/vv.mp4" },
                    { 99, 20, false, "Vertebrate Zoology I", "https://estigo.runasp.net/vv.mp4" },
                    { 100, 20, false, "Vertebrate Zoology II", "https://estigo.runasp.net/vv.mp4" },
                    { 101, 21, false, "Introduction to Microbes", "https://estigo.runasp.net/vv.mp4" },
                    { 102, 21, false, "Bacterial Structure and Function", "https://estigo.runasp.net/vv.mp4" },
                    { 103, 21, false, "Microbial Growth and Metabolism", "https://estigo.runasp.net/vv.mp4" },
                    { 104, 21, false, "Viruses and Prions", "https://estigo.runasp.net/vv.mp4" },
                    { 105, 21, false, "Microbial Roles and Applications", "https://estigo.runasp.net/vv.mp4" },
                    { 106, 22, false, "Introduction & Bonding", "https://estigo.runasp.net/vv.mp4" },
                    { 107, 22, false, "Alkanes and Cycloalkanes", "https://estigo.runasp.net/vv.mp4" },
                    { 108, 22, false, "Stereochemistry", "https://estigo.runasp.net/vv.mp4" },
                    { 109, 22, false, "Introduction to Organic Reactions", "https://estigo.runasp.net/vv.mp4" },
                    { 110, 22, false, "Alkenes and Alkynes: Structure & Reactivity", "https://estigo.runasp.net/vv.mp4" },
                    { 111, 23, false, "Atomic Structure and Periodicity", "https://estigo.runasp.net/vv.mp4" },
                    { 112, 23, false, "Chemical Bonding: Lewis & VSEPR", "https://estigo.runasp.net/vv.mp4" },
                    { 113, 23, false, "Valence Bond and Molecular Orbital Theory", "https://estigo.runasp.net/vv.mp4" },
                    { 114, 23, false, "Acid-Base Chemistry", "https://estigo.runasp.net/vv.mp4" },
                    { 115, 23, false, "Introduction to Coordination Chemistry", "https://estigo.runasp.net/vv.mp4" },
                    { 116, 24, false, "Gases and Kinetic Theory", "https://estigo.runasp.net/vv.mp4" },
                    { 117, 24, false, "Thermodynamics: First Law", "https://estigo.runasp.net/vv.mp4" },
                    { 118, 24, false, "Thermodynamics: Second & Third Laws", "https://estigo.runasp.net/vv.mp4" },
                    { 119, 24, false, "Chemical Kinetics", "https://estigo.runasp.net/vv.mp4" },
                    { 120, 24, false, "Introduction to Quantum Chemistry", "https://estigo.runasp.net/vv.mp4" },
                    { 121, 25, false, "Introduction & Statistics", "https://estigo.runasp.net/vv.mp4" },
                    { 122, 25, false, "Gravimetric and Volumetric Analysis", "https://estigo.runasp.net/vv.mp4" },
                    { 123, 25, false, "Spectroscopic Methods", "https://estigo.runasp.net/vv.mp4" },
                    { 124, 25, false, "Chromatography Basics", "https://estigo.runasp.net/vv.mp4" },
                    { 125, 25, false, "Electroanalytical Methods", "https://estigo.runasp.net/vv.mp4" },
                    { 126, 26, false, "Amino Acids and Proteins", "https://estigo.runasp.net/vv.mp4" },
                    { 127, 26, false, "Enzymes and Enzyme Kinetics", "https://estigo.runasp.net/vv.mp4" },
                    { 128, 26, false, "Carbohydrates", "https://estigo.runasp.net/vv.mp4" },
                    { 129, 26, false, "Lipids and Membranes", "https://estigo.runasp.net/vv.mp4" },
                    { 130, 26, false, "Metabolic Pathways Overview", "https://estigo.runasp.net/vv.mp4" },
                    { 131, 27, false, "Atmospheric Chemistry", "https://estigo.runasp.net/vv.mp4" },
                    { 132, 27, false, "Aquatic Chemistry", "https://estigo.runasp.net/vv.mp4" },
                    { 133, 27, false, "Soil Chemistry", "https://estigo.runasp.net/vv.mp4" },
                    { 134, 27, false, "Toxicology and Risk Assessment", "https://estigo.runasp.net/vv.mp4" },
                    { 135, 27, false, "Green Chemistry", "https://estigo.runasp.net/vv.mp4" },
                    { 136, 28, false, "Quantum Mechanics Fundamentals", "https://estigo.runasp.net/vv.mp4" },
                    { 137, 28, false, "Approximation Methods", "https://estigo.runasp.net/vv.mp4" },
                    { 138, 28, false, "Molecular Symmetry and Group Theory", "https://estigo.runasp.net/vv.mp4" },
                    { 139, 28, false, "Computational Chemistry Methods", "https://estigo.runasp.net/vv.mp4" },
                    { 140, 28, false, "Statistical Thermodynamics", "https://estigo.runasp.net/vv.mp4" },
                    { 141, 29, false, "Introduction to Literary Analysis", "https://estigo.runasp.net/vv.mp4" },
                    { 142, 29, false, "Short Story Analysis", "https://estigo.runasp.net/vv.mp4" },
                    { 143, 29, false, "Poetry Fundamentals", "https://estigo.runasp.net/vv.mp4" },
                    { 144, 29, false, "Novel Study: Introduction", "https://estigo.runasp.net/vv.mp4" },
                    { 145, 29, false, "Introduction to Drama", "https://estigo.runasp.net/vv.mp4" },
                    { 146, 30, false, "Finding Your Voice", "https://estigo.runasp.net/vv.mp4" },
                    { 147, 30, false, "Character Development", "https://estigo.runasp.net/vv.mp4" },
                    { 148, 30, false, "Plotting and Structure", "https://estigo.runasp.net/vv.mp4" },
                    { 149, 30, false, "Setting and Description", "https://estigo.runasp.net/vv.mp4" },
                    { 150, 30, false, "Dialogue Writing", "https://estigo.runasp.net/vv.mp4" },
                    { 151, 31, false, "Parts of Speech Review", "https://estigo.runasp.net/vv.mp4" },
                    { 152, 31, false, "Sentence Structure", "https://estigo.runasp.net/vv.mp4" },
                    { 153, 31, false, "Punctuation Rules", "https://estigo.runasp.net/vv.mp4" },
                    { 154, 31, false, "Common Grammatical Errors", "https://estigo.runasp.net/vv.mp4" },
                    { 155, 31, false, "Paragraph and Essay Structure", "https://estigo.runasp.net/vv.mp4" },
                    { 156, 32, false, "Elements of Poetry", "https://estigo.runasp.net/vv.mp4" },
                    { 157, 32, false, "Figurative Language", "https://estigo.runasp.net/vv.mp4" },
                    { 158, 32, false, "Sound Devices", "https://estigo.runasp.net/vv.mp4" },
                    { 159, 32, false, "Poetic Forms", "https://estigo.runasp.net/vv.mp4" },
                    { 160, 32, false, "Interpreting Poems", "https://estigo.runasp.net/vv.mp4" },
                    { 161, 33, false, "History of Theater", "https://estigo.runasp.net/vv.mp4" },
                    { 162, 33, false, "Elements of Drama", "https://estigo.runasp.net/vv.mp4" },
                    { 163, 33, false, "Reading a Play", "https://estigo.runasp.net/vv.mp4" },
                    { 164, 33, false, "Major Dramatic Genres", "https://estigo.runasp.net/vv.mp4" },
                    { 165, 33, false, "Theater Production Basics", "https://estigo.runasp.net/vv.mp4" },
                    { 166, 34, false, "Generating Ideas", "https://estigo.runasp.net/vv.mp4" },
                    { 167, 34, false, "Point of View and Narrative Voice", "https://estigo.runasp.net/vv.mp4" },
                    { 168, 34, false, "Show, Don't Tell", "https://estigo.runasp.net/vv.mp4" },
                    { 169, 34, false, "Crafting Scenes", "https://estigo.runasp.net/vv.mp4" },
                    { 170, 34, false, "Revision Strategies", "https://estigo.runasp.net/vv.mp4" },
                    { 171, 35, false, "Types of Non-fiction", "https://estigo.runasp.net/vv.mp4" },
                    { 172, 35, false, "Research Techniques", "https://estigo.runasp.net/vv.mp4" },
                    { 173, 35, false, "Structuring Non-fiction", "https://estigo.runasp.net/vv.mp4" },
                    { 174, 35, false, "Writing with Clarity and Style", "https://estigo.runasp.net/vv.mp4" },
                    { 175, 35, false, "Ethics in Non-fiction", "https://estigo.runasp.net/vv.mp4" }
                });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "CreatedAt", "ExamDescription", "ExamTitle", "Grade", "attempts", "final", "lessonId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of variables and expressions.", "Algebra Basics Exam", "Not Graded", 0, false, 1 },
                    { 2, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding and solving of linear inequalities.", "Inequalities Exam", "Not Graded", 0, false, 3 },
                    { 3, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of polynomial expressions and operations.", "Polynomial Basics Exam", "Not Graded", 0, false, 5 },
                    { 4, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of defining the derivative and basic rules.", "Introduction to Derivatives Exam", "Not Graded", 0, false, 7 },
                    { 5, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your ability to use derivatives for rates of change and optimization.", "Applications of Derivatives Exam", "Not Graded", 0, false, 9 },
                    { 6, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of fundamental geometric concepts.", "Points, Lines, and Planes Exam", "Not Graded", 0, false, 11 },
                    { 7, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of angles formed by parallel lines.", "Parallel Lines and Transversals Exam", "Not Graded", 0, false, 13 },
                    { 8, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of polygon properties.", "Introduction to Polygons Exam", "Not Graded", 0, false, 15 },
                    { 9, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of the unit circle in trigonometry.", "The Unit Circle Exam", "Not Graded", 0, false, 17 },
                    { 10, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of fundamental trigonometric identities.", "Trigonometric Identities Exam", "Not Graded", 0, false, 19 },
                    { 11, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of basic statistical concepts and data types.", "Introduction to Statistics Exam", "Not Graded", 0, false, 21 },
                    { 12, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of graphical data representation.", "Data Visualization Exam", "Not Graded", 0, false, 23 },
                    { 13, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of basic probability distributions.", "Introduction to Distributions Exam", "Not Graded", 0, false, 25 },
                    { 14, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of conditional probability and independence.", "Conditional Probability Exam", "Not Graded", 0, false, 27 },
                    { 15, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comprehensive test of statistical concepts, data visualization, probability distributions, conditional probability, and expected value.", "Statistics & Probability Comprehensive Exam", "Not Graded", 0, false, 29 },
                    { 16, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of propositional logic and proof methods.", "Logic and Proofs Exam", "Not Graded", 0, false, 31 },
                    { 17, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of permutations and combinations.", "Counting Principles Exam", "Not Graded", 0, false, 33 },
                    { 18, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comprehensive test of core mathematical concepts including algebra, calculus, geometry, trigonometry, and discrete math.", "Core Mathematics Comprehensive Exam", "Not Graded", 0, true, 35 },
                    { 19, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of projectile motion and vector operations.", "Vectors and 2D Kinematics Exam", "Not Graded", 0, false, 37 },
                    { 20, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of work, energy concepts, and conservation.", "Work, Energy, and Power Exam", "Not Graded", 0, false, 39 },
                    { 21, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of electric charge properties and Coulomb's Law.", "Electric Charge and Coulomb's Law Exam", "Not Graded", 0, false, 41 },
                    { 22, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of potential difference and electric potential energy.", "Electric Potential Exam", "Not Graded", 0, false, 43 },
                    { 23, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of basic electric current, resistance, and Ohm's Law.", "Current, Resistance, and Ohm's Law Exam", "Not Graded", 0, false, 45 },
                    { 24, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of magnetic fields produced by currents.", "Sources of Magnetic Fields Exam", "Not Graded", 0, false, 47 },
                    { 25, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of Faraday's Law and Lenz's Law.", "Electromagnetic Induction Exam", "Not Graded", 0, false, 49 },
                    { 26, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of the wave-particle duality and properties of light.", "Nature of Light Exam", "Not Graded", 0, false, 51 },
                    { 27, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of lenses and image formation.", "Lenses and Image Formation Exam", "Not Graded", 0, false, 53 },
                    { 28, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of light diffraction.", "Wave Optics: Diffraction Exam", "Not Graded", 0, false, 55 },
                    { 29, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of internal energy, work, and heat.", "First Law of Thermodynamics Exam", "Not Graded", 0, false, 57 },
                    { 30, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of entropy and the direction of processes.", "Second Law of Thermodynamics Exam", "Not Graded", 0, false, 59 },
                    { 31, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of blackbody radiation and Planck's hypothesis.", "Blackbody Radiation Exam", "Not Graded", 0, false, 61 },
                    { 32, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of the De Broglie hypothesis.", "Wave Nature of Matter Exam", "Not Graded", 0, false, 63 },
                    { 33, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your basic understanding of the Schrödinger equation and wave functions.", "Introduction to Quantum Mechanics Exam", "Not Graded", 0, false, 65 },
                    { 34, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of relativistic effects on time and space.", "Time Dilation and Length Contraction Exam", "Not Graded", 0, false, 67 },
                    { 35, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comprehensive test of classical mechanics, electricity, magnetism, optics, thermodynamics, and modern physics concepts.", "Physics Comprehensive Exam", "Not Graded", 0, true, 69 },
                    { 36, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of Prokaryotic vs. Eukaryotic cells.", "Introduction to Cells Exam", "Not Graded", 0, false, 71 },
                    { 37, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of major organelle structures and functions.", "Eukaryotic Organelles Exam", "Not Graded", 0, false, 73 },
                    { 38, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of the cell cycle phases and mitosis.", "The Cell Cycle and Mitosis Exam", "Not Graded", 0, false, 75 },
                    { 39, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of the double helix and DNA synthesis.", "DNA Structure and Replication Exam", "Not Graded", 0, false, 77 },
                    { 40, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of protein synthesis from RNA.", "Gene Expression: Translation Exam", "Not Graded", 0, false, 79 },
                    { 41, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of skeleton types and bone structure.", "Skeletal Systems Exam", "Not Graded", 0, false, 81 },
                    { 42, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of forces and levers in biological systems.", "Biomechanics Basics Exam", "Not Graded", 0, false, 83 },
                    { 43, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of how the nervous system controls muscles.", "Nervous System Control of Movement Exam", "Not Graded", 0, false, 85 },
                    { 44, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of population growth models.", "Population Ecology Exam", "Not Graded", 0, false, 87 },
                    { 45, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of energy flow and nutrient cycling.", "Ecosystem Dynamics Exam", "Not Graded", 0, false, 89 },
                    { 46, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of basic plant anatomy.", "Plant Structure and Growth Exam", "Not Graded", 0, false, 91 },
                    { 47, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of the photosynthesis process.", "Photosynthesis Exam", "Not Graded", 0, false, 93 },
                    { 48, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of chemical signaling in plants.", "Plant Hormones and Responses Exam", "Not Graded", 0, false, 95 },
                    { 49, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of simpler invertebrates.", "Invertebrate Zoology I Exam", "Not Graded", 0, false, 97 },
                    { 50, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of Chordates and Fish.", "Vertebrate Zoology I Exam", "Not Graded", 0, false, 99 },
                    { 51, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of microbial diversity.", "Introduction to Microbes Exam", "Not Graded", 0, false, 101 },
                    { 52, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of microbial growth requirements and pathways.", "Microbial Growth and Metabolism Exam", "Not Graded", 0, false, 103 },
                    { 53, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comprehensive test of cell biology, genetics, physiology, ecology, botany, zoology, and microbiology.", "Biology Comprehensive Exam", "Not Graded", 0, true, 105 },
                    { 54, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of alkane nomenclature and conformations.", "Alkanes and Cycloalkanes Exam", "Not Graded", 0, false, 107 },
                    { 55, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of reaction types and mechanisms.", "Introduction to Organic Reactions Exam", "Not Graded", 0, false, 109 },
                    { 56, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of atomic models and periodic trends.", "Atomic Structure and Periodicity Exam", "Not Graded", 0, false, 111 },
                    { 57, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of VB and MO theories.", "Bonding Theories Exam", "Not Graded", 0, false, 113 },
                    { 58, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of transition metals, ligands, and complex ions.", "Coordination Chemistry Basics Exam", "Not Graded", 0, false, 115 },
                    { 59, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of energy, work, heat, and enthalpy.", "Thermodynamics: First Law Exam", "Not Graded", 0, false, 117 },
                    { 60, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of reaction rates and mechanisms.", "Chemical Kinetics Exam", "Not Graded", 0, false, 119 },
                    { 61, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of analytical errors and data analysis.", "Analytical Intro & Stats Exam", "Not Graded", 0, false, 121 },
                    { 62, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of light-matter interaction and UV-Vis.", "Spectroscopic Methods Exam", "Not Graded", 0, false, 123 },
                    { 63, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of potentiometry and voltammetry basics.", "Electroanalytical Methods Exam", "Not Graded", 0, false, 125 },
                    { 64, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of biological catalysts and reaction rates.", "Enzymes and Kinetics Exam", "Not Graded", 0, false, 127 },
                    { 65, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of lipid types and membrane structure.", "Lipids and Membranes Exam", "Not Graded", 0, false, 129 },
                    { 66, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of atmospheric composition and reactions.", "Atmospheric Chemistry Exam", "Not Graded", 0, false, 131 },
                    { 67, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of soil composition and chemical reactions.", "Soil Chemistry Exam", "Not Graded", 0, false, 133 },
                    { 68, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of principles for safer chemical processes.", "Green Chemistry Exam", "Not Graded", 0, false, 135 },
                    { 69, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of variation principle and perturbation theory.", "Approximation Methods Exam", "Not Graded", 0, false, 137 },
                    { 70, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comprehensive test of organic, inorganic, physical, analytical, bio, environmental, and theoretical chemistry.", "Chemistry Comprehensive Exam", "Not Graded", 0, true, 139 },
                    { 71, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your ability to use tools for interpreting literature.", "Literary Analysis Basics Exam", "Not Graded", 0, false, 141 },
                    { 72, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of poetic devices and forms.", "Poetry Fundamentals Exam", "Not Graded", 0, false, 143 },
                    { 73, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of the elements of dramatic literature.", "Introduction to Drama Exam", "Not Graded", 0, false, 145 },
                    { 74, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your ability to create believable characters.", "Character Development Quiz", "Not Graded", 0, false, 147 },
                    { 75, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your skills in building immersive worlds.", "Setting and Description Quiz", "Not Graded", 0, false, 149 },
                    { 76, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of nouns, verbs, adjectives, etc.", "Parts of Speech Exam", "Not Graded", 0, false, 151 },
                    { 77, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of correct punctuation usage.", "Punctuation Rules Exam", "Not Graded", 0, false, 153 },
                    { 78, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your ability to organize ideas effectively.", "Paragraph and Essay Structure Exam", "Not Graded", 0, false, 155 },
                    { 79, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your ability to identify and interpret figurative language.", "Figurative Language Exam", "Not Graded", 0, false, 157 },
                    { 80, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your ability to recognize and analyze different poetic structures.", "Poetic Forms Exam", "Not Graded", 0, false, 159 },
                    { 81, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of key periods and playwrights.", "History of Theater Exam", "Not Graded", 0, false, 161 },
                    { 82, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your ability to understand stage directions and subtext.", "Reading a Play Exam", "Not Graded", 0, false, 163 },
                    { 83, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of roles and processes in theater production.", "Theater Production Basics Exam", "Not Graded", 0, false, 165 },
                    { 84, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your understanding of narrative perspectives.", "Point of View Quiz", "Not Graded", 0, false, 167 },
                    { 85, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of scene structure and pacing.", "Crafting Scenes Quiz", "Not Graded", 0, false, 169 },
                    { 86, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your knowledge of different non-fiction forms.", "Types of Non-fiction Exam", "Not Graded", 0, false, 171 },
                    { 87, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test your ability to organize factual material effectively.", "Structuring Non-fiction Exam", "Not Graded", 0, false, 173 },
                    { 88, new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comprehensive test of literary analysis, creative writing, grammar, composition, and non-fiction.", "English & Literature Comprehensive Exam", "Not Graded", 0, true, 175 }
                });

            migrationBuilder.InsertData(
                table: "BankOfQuestions",
                columns: new[] { "Id", "CorrectAnswer", "ExamId", "OptionA", "OptionB", "OptionC", "OptionD", "QuestionText" },
                values: new object[,]
                {
                    { 1, "B", 1, "Coefficient", "Variable", "Constant", "Term", "In the expression 3x + 5, what is 'x' called?" },
                    { 2, "C", 1, "y", "7y", "7", "None", "What is the coefficient in the term 7y?" },
                    { 3, "C", 1, "2a", "b", "-4", "x/3", "Which of the following is a constant?" },
                    { 4, "C", 1, "1", "2", "3", "6", "How many terms are in the expression 2x - y + 6?" },
                    { 5, "B", 1, "6a", "5a", "7a", "4a", "Simplify the expression: 4a + 2a - a" },
                    { 6, "C", 2, "<", ">", "<=", ">=", "Which symbol represents 'less than or equal to'?" },
                    { 7, "A", 2, "x > 4", "x < 4", "x > 10", "x < 10", "Solve the inequality: x + 3 > 7" },
                    { 8, "B", 2, "Stays the same", "Flips", "Becomes equals", "Disappears", "When solving -2x < 6, what happens to the inequality sign?" },
                    { 9, "D", 2, "Closed circle on 5, shaded left", "Open circle on 5, shaded left", "Closed circle on 5, shaded right", "Open circle on 5, shaded right", "How is 'x is greater than 5' represented on a number line?" },
                    { 10, "A", 2, "x <= 3", "x >= 3", "x <= 9/3", "x <= 7/3", "Solve: 3x - 1 <= 8" },
                    { 11, "B", 3, "1", "2", "3", "0", "What is the degree of the polynomial 3x^2 + 2x - 1?" },
                    { 12, "C", 3, "5x", "x^2 + 3x - 4", "2y + 7", "10", "Which of the following is a binomial?" },
                    { 13, "A", 3, "3x + 2", "3x + 4", "2x + 2", "x + 2", "Add the polynomials: (2x + 3) + (x - 1)" },
                    { 14, "A", 3, "4y - 5", "4y + 1", "6y + 1", "4y + 5", "Subtract: (5y - 2) - (y + 3)" },
                    { 15, "C", 3, "x^2 + 4", "2x + 4", "x^2 + 4x", "5x", "Multiply: x(x + 4)" },
                    { 16, "C", 4, "Area under the curve", "Value of the function", "Instantaneous rate of change", "Y-intercept", "The derivative of a function f(x) represents the:" },
                    { 17, "D", 4, "c", "x", "1", "0", "What is the derivative of a constant function, f(x) = c?" },
                    { 18, "A", 4, "nx^(n-1)", "x^(n-1)", "n*x^n", "(n-1)x^n", "What is the derivative of f(x) = x^n using the power rule?" },
                    { 19, "A", 4, "15x^2", "5x^2", "15x^3", "3x^2", "Find the derivative of f(x) = 5x^3" },
                    { 20, "C", 4, "7x", "x", "7", "0", "The derivative of f(x) = 7x is:" },
                    { 21, "C", 5, "Length", "Y-intercept", "Slope", "Area", "Derivatives can be used to find the ___ of a tangent line to a curve." },
                    { 22, "B", 5, "Decreasing", "Increasing", "Constant", "Concave down", "If the derivative f'(x) is positive on an interval, the function f(x) is:" },
                    { 23, "C", 5, "Positive", "Negative", "Zero or undefined", "Always 1", "A critical point occurs where the derivative f'(x) is:" },
                    { 24, "B", 5, "Positive or Negative", "Maximum or Minimum", "First or Last", "Real or Imaginary", "Optimization problems often involve finding the ___ or ___ value of a function." },
                    { 25, "D", 5, "Acceleration", "Position", "Jerk", "Velocity", "If s(t) is the position function, what does s'(t) represent?" },
                    { 26, "C", 6, "Angle", "Line segment", "Point", "Circle", "Which is a fundamental undefined term in geometry?" },
                    { 27, "B", 6, "1", "2", "3", "Infinite", "How many points are needed to define a unique line?" },
                    { 28, "C", 6, "1", "2", "3", "4", "How many non-collinear points are needed to define a unique plane?" },
                    { 29, "B", 6, "Coplanar", "Collinear", "Concurrent", "Congruent", "Points that lie on the same line are called:" },
                    { 30, "B", 6, "Point", "Line", "Plane", "Nothing", "The intersection of two distinct planes is a:" },
                    { 31, "C", 7, "Skew lines", "Perpendicular lines", "Parallel lines", "Transversals", "Lines that are in the same plane and never intersect are called:" },
                    { 32, "D", 7, "Parallel", "Segment", "Ray", "Transversal", "A line that intersects two or more other lines is called a:" },
                    { 33, "C", 7, "Supplementary", "Complementary", "Congruent", "Adjacent", "When a transversal intersects parallel lines, alternate interior angles are:" },
                    { 34, "A", 7, "Congruent", "Supplementary", "Complementary", "Vertical", "When a transversal intersects parallel lines, corresponding angles are:" },
                    { 35, "D", 7, "Congruent", "Complementary", "Acute", "Supplementary", "Consecutive interior angles (same-side interior angles) formed by parallel lines and a transversal are:" },
                    { 36, "B", 8, "Curves", "Line segments", "Circles", "Points", "A polygon is a closed figure made of:" },
                    { 37, "B", 8, "5", "6", "7", "8", "How many sides does a hexagon have?" },
                    { 38, "C", 8, "Pentagon", "Triangle", "Quadrilateral", "Octagon", "What is the name for a four-sided polygon?" },
                    { 39, "D", 8, "Irregular", "Concave", "Complex", "Regular", "A polygon where all sides and all angles are equal is called:" },
                    { 40, "C", 8, "180n", "360n", "(n-2) * 180", "n * 180 / 2", "What is the formula for the sum of interior angles of an n-sided polygon?" },
                    { 41, "B", 9, "0", "1", "pi", "2", "What is the radius of the unit circle?" },
                    { 42, "B", 9, "Sine", "Cosine", "Tangent", "Secant", "On the unit circle, the x-coordinate of a point corresponds to which trigonometric function?" },
                    { 43, "A", 9, "Sine", "Cosine", "Cotangent", "Cosecant", "On the unit circle, the y-coordinate of a point corresponds to which trigonometric function?" },
                    { 44, "B", 9, "0", "1", "-1", "undefined", "What is the value of cos(0) on the unit circle?" },
                    { 45, "B", 9, "0", "1", "-1", "1/2", "What is the value of sin(pi/2) on the unit circle?" },
                    { 46, "C", 10, "sin^2(x) - cos^2(x) = 1", "tan^2(x) + 1 = sec^2(x)", "sin^2(x) + cos^2(x) = 1", "1 + cot^2(x) = csc(x)", "Which is the fundamental Pythagorean identity?" },
                    { 47, "B", 10, "cos(x) / sin(x)", "sin(x) / cos(x)", "1 / sin(x)", "1 / cos(x)", "tan(x) is equivalent to:" },
                    { 48, "A", 10, "sin(x)", "cos(x)", "tan(x)", "sec(x)", "csc(x) is the reciprocal of:" },
                    { 49, "A", 10, "1", "sin^2(x)", "tan(x)", "0", "Simplify: sin(x) * csc(x)" },
                    { 50, "C", 10, "tan^2(x) - sec^2(x) = 1", "sec^2(x) + tan^2(x) = 1", "1 + tan^2(x) = sec^2(x)", "1 - tan^2(x) = sec^2(x)", "Which identity relates tan^2(x) and sec^2(x)?" },
                    { 51, "B", 11, "Ignoring", "Interpreting", "Deleting", "Complicating", "Statistics is the science of collecting, organizing, analyzing, and ___ data." },
                    { 52, "B", 11, "Sample", "Population", "Variable", "Statistic", "The entire group of individuals or objects being studied is called the:" },
                    { 53, "C", 11, "Parameter", "Variable", "Sample", "Census", "A subset of the population selected for study is called a:" },
                    { 54, "D", 11, "Quantitative", "Numerical", "Discrete", "Qualitative", "Data that consists of names, labels, or categories (e.g., eye color) is called:" },
                    { 55, "C", 11, "Qualitative", "Categorical", "Quantitative", "Nominal", "Data that consists of numbers representing counts or measurements is called:" },
                    { 56, "C", 12, "Scatter plot", "Line graph", "Bar chart", "Box plot", "Which type of graph is best for showing frequencies of categorical data?" },
                    { 57, "B", 12, "Pie chart", "Histogram", "Stem-and-leaf plot", "Dot plot", "A graph that uses bars to represent the frequency of numerical data grouped into intervals is called a:" },
                    { 58, "D", 12, "Histogram", "Bar chart", "Pie chart", "Scatter plot", "Which graph is used to show the relationship between two quantitative variables?" },
                    { 59, "B", 12, "Mean, Median, Mode, Min, Max", "Min, Q1, Median, Q3, Max", "Mean, SD, Variance, Range, IQR", "Count, Sum, Average, Min, Max", "A box plot (box-and-whisker plot) displays which five-number summary?" },
                    { 60, "D", 12, "Trends over time", "Comparison between categories", "Relationship between variables", "Parts of a whole", "A pie chart is best used to show:" },
                    { 61, "B", 13, "Frequency table", "Probability distribution", "Cumulative frequency", "Sample space", "A table or equation that links each outcome of a statistical experiment with its probability of occurrence is a:" },
                    { 62, "D", 13, "Binomial", "Poisson", "Uniform", "Normal", "Which distribution is often described as 'bell-shaped'?" },
                    { 63, "C", 13, "Continuous outcomes", "Infinite trials", "Two possible outcomes per trial", "Variable probability of success", "The Binomial distribution applies to experiments with:" },
                    { 64, "B", 13, "Mean and Median", "Mean and Standard Deviation", "Mode and Range", "Min and Max", "The Normal distribution is completely defined by its:" },
                    { 65, "B", 13, "0", "1", "100", "Infinity", "In a discrete probability distribution, the sum of all probabilities must equal:" },
                    { 66, "C", 14, "Event A and Event B", "Event A or Event B", "Event A given Event B occurred", "Event B given Event A occurred", "P(A|B) represents the probability of:" },
                    { 67, "B", 14, "P(A|B) = P(B)", "P(A|B) = P(A)", "P(A and B) = P(A) + P(B)", "P(A|B) = 0", "Two events A and B are independent if:" },
                    { 68, "D", 14, "Joint probability", "Marginal probability", "Prior probability", "Posterior (conditional) probability", "Bayes' Theorem is used to calculate:" },
                    { 69, "A", 14, "Yes, because P(A)*P(B) = P(A and B)", "No, because P(A)*P(B) != P(A and B)", "Yes, because P(A)+P(B) > 1", "Cannot be determined", "If P(A) = 0.5, P(B) = 0.4, and P(A and B) = 0.2, are A and B independent?" },
                    { 70, "C", 14, "Independence", "Mutual exclusivity", "Conditional probability", "Joint probability", "The formula P(A|B) = P(A and B) / P(B) defines:" },
                    { 71, "B", 15, "Most likely outcome", "Average outcome over many trials", "Maximum possible value", "Spread of the distribution", "Expected Value E(X) of a discrete random variable represents the:" },
                    { 72, "A", 15, "Sum of (Outcome * Probability)", "Sum of Probabilities", "Product of Outcomes", "Average of Outcomes", "How is Expected Value E(X) calculated?" },
                    { 73, "C", 15, "Central tendency", "Average value", "Spread or dispersion", "Skewness", "Variance Var(X) measures the:" },
                    { 74, "C", 15, "Square", "Reciprocal", "Square root", "Double", "Standard Deviation is the ___ of the Variance." },
                    { 75, "C", 15, "5", "15", "17", "21", "If E(X) = 5, what is E(3X + 2)?" },
                    { 76, "C", 16, "Theorem", "Axiom", "Proposition", "Corollary", "A statement that is either true or false is called a:" },
                    { 77, "C", 16, "AND", "OR", "NOT (Negation)", "IMPLIES", "The symbol '¬' represents which logical operator?" },
                    { 78, "B", 16, "Single proposition", "Compound proposition", "Proof", "Set", "A truth table is used to determine the truth value of a:" },
                    { 79, "C", 16, "Direct proof", "Proof by contraposition", "Proof by contradiction", "Proof by induction", "A proof technique that assumes the negation of the conclusion and derives a contradiction is:" },
                    { 80, "B", 16, "P is true, Q is true", "P is true, Q is false", "P is false, Q is true", "P is false, Q is false", "The statement 'If P, then Q' (P → Q) is false only when:" },
                    { 81, "C", 17, "n^2", "2^n", "n!", "C(n, 2)", "The number of ways to arrange n distinct objects is given by:" },
                    { 82, "B", 17, "Combination", "Permutation", "Factorial", "Probability", "Which calculation is used when the order of selection matters?" },
                    { 83, "A", 17, "Combination", "Permutation", "Factorial", "Distribution", "Which calculation is used when the order of selection does NOT matter?" },
                    { 84, "B", 17, "1", "3", "6", "9", "How many ways can you choose 2 letters from {A, B, C} if order doesn't matter?" },
                    { 85, "D", 17, "All containers are empty", "All containers have 1 item", "At least one container has 0 items", "At least one container has more than 1 item", "The Pigeonhole Principle states that if you have n items put into m containers, with n > m, then:" },
                    { 86, "C", 18, "Edges", "Nodes", "Vertices", "Lines", "In graph theory, what are the points called?" },
                    { 87, "D", 18, "Nodes", "Paths", "Cycles", "Edges", "What connects the vertices in a graph?" },
                    { 88, "A", 18, "Directed graph (Digraph)", "Undirected graph", "Weighted graph", "Simple graph", "A graph where edges have direction is called a:" },
                    { 89, "C", 18, "Cycle", "Tree", "Walk/Path", "Component", "A sequence of vertices where each adjacent pair is connected by an edge is a:" },
                    { 90, "C", 18, "Complete graph", "Bipartite graph", "Tree", "Planar graph", "A connected graph with no cycles is called a:" },
                    { 91, "B", 19, "Scalar", "Vector", "Tensor", "Matrix", "A quantity that has both magnitude and direction is a:" },
                    { 92, "D", 19, "Velocity", "Acceleration", "Force", "Speed", "Which is an example of a scalar quantity?" },
                    { 93, "B", 19, "Addition", "Resolution", "Dot product", "Normalization", "Breaking a vector into its horizontal and vertical parts is called:" },
                    { 94, "C", 19, "Circle", "Straight line", "Parabola", "Hyperbola", "The path of a projectile under gravity (neglecting air resistance) is typically a:" },
                    { 95, "C", 19, "Tail-to-tail", "Head-to-head", "Head-to-tail", "Side-by-side", "How are vectors typically added graphically?" },
                    { 96, "A", 20, "Force", "Energy", "Power", "Mass", "Work is done when a ___ causes displacement." },
                    { 97, "B", 20, "Potential energy", "Kinetic energy", "Chemical energy", "Thermal energy", "Energy due to motion is called:" },
                    { 98, "B", 20, "Kinetic energy", "Potential energy", "Work", "Power", "Energy stored due to position or configuration is called:" },
                    { 99, "C", 20, "Transferred", "Transformed", "Created or destroyed", "Measured", "The principle of Conservation of Energy states that energy cannot be:" },
                    { 100, "C", 20, "Amount", "Type", "Rate", "Direction", "Power is the ___ at which work is done or energy is transferred." },
                    { 101, "A", 21, "Positive and Negative", "Strong and Weak", "North and South", "Up and Down", "The two types of electric charge are:" },
                    { 102, "B", 21, "Attract, Repel", "Repel, Attract", "Attract, Attract", "Repel, Repel", "Like charges ___ and opposite charges ___." },
                    { 103, "C", 21, "Neutron", "Proton", "Electron (and Proton)", "Atom", "The fundamental unit of charge is carried by the:" },
                    { 104, "C", 21, "Potential", "Field", "Force", "Current", "Coulomb's Law describes the ___ between two point charges." },
                    { 105, "B", 21, "Distance", "Square of the distance", "Cube of the distance", "Square root of the distance", "According to Coulomb's Law, the force is inversely proportional to the ___ of the distance between charges." },
                    { 106, "C", 22, "Force", "Field", "Energy", "Current", "Electric potential is defined as electric potential ___ per unit charge." },
                    { 107, "D", 22, "Ampere (A)", "Coulomb (C)", "Ohm (Ω)", "Volt (V)", "The unit of electric potential is the:" },
                    { 108, "C", 22, "Current", "Resistance", "Voltage", "Capacitance", "Potential difference is also known as:" },
                    { 109, "A", 22, "High, Low", "Low, High", "Negative, Positive", "Zero, Non-zero", "Positive charges tend to move from regions of ___ potential to ___ potential." },
                    { 110, "C", 22, "Electric field", "Charge density", "Electric potential", "Force", "An equipotential surface is one where all points have the same:" },
                    { 111, "C", 23, "Voltage", "Resistance", "Charge", "Energy", "Electric current is the rate of flow of:" },
                    { 112, "D", 23, "Volt (V)", "Ohm (Ω)", "Watt (W)", "Ampere (A)", "The unit of electric current is the:" },
                    { 113, "B", 23, "Voltage", "Current flow", "Charge buildup", "Magnetic fields", "Resistance is the opposition to:" },
                    { 114, "C", 23, "V = I / R", "V = R / I", "V = I * R", "I = V * R", "Ohm's Law states the relationship between voltage (V), current (I), and resistance (R) as:" },
                    { 115, "C", 23, "Ampere (A)", "Volt (V)", "Ohm (Ω)", "Farad (F)", "The unit of electrical resistance is the:" },
                    { 116, "B", 24, "Electric fields only", "Magnetic fields", "Gravitational fields", "No fields", "Moving electric charges (currents) create:" },
                    { 117, "D", 24, "Electric force", "Magnetic force", "Electric field", "Magnetic field created by a current element", "The Biot-Savart Law is used to calculate the:" },
                    { 118, "C", 24, "Straight lines parallel to the wire", "Straight lines perpendicular to the wire", "Concentric circles around the wire", "Spirals", "The magnetic field lines around a long, straight current-carrying wire form:" },
                    { 119, "C", 24, "Capacitor", "Resistor", "Solenoid", "Transistor", "A coil of wire designed to produce a strong magnetic field inside it is called a:" },
                    { 120, "B", 24, "Left-hand rule", "Right-hand rule", "Ohm's Law", "Coulomb's Law", "The direction of the magnetic field around a wire can be found using the:" },
                    { 121, "B", 25, "Current", "Electromotive force (EMF) / Voltage", "Resistance", "Charge", "Electromagnetic induction is the production of an ___ across an electrical conductor in a changing magnetic field." },
                    { 122, "D", 25, "Electric field", "Magnetic field", "Current", "Magnetic flux", "Faraday's Law of Induction states that the induced EMF is proportional to the rate of change of:" },
                    { 123, "B", 25, "Electric field lines", "Magnetic field lines", "Current", "Voltage", "Magnetic flux is a measure of the amount of ___ passing through a given area." },
                    { 124, "B", 25, "Magnitude", "Direction", "Frequency", "Power", "Lenz's Law determines the ___ of the induced current." },
                    { 125, "B", 25, "Enhances", "Opposes", "Ignores", "Doubles", "Lenz's Law states that the induced current flows in a direction that ___ the change in magnetic flux that produced it." },
                    { 126, "B", 26, "Solids and Liquids", "Waves and Particles", "Acids and Bases", "Magnets and Charges", "Light exhibits properties of both:" },
                    { 127, "C", 26, "Diffraction effect", "Interference effect", "Photoelectric effect", "Refraction effect", "The particle nature of light is demonstrated by the:" },
                    { 128, "C", 26, "Acoustic", "Nuclear", "Electromagnetic", "Thermal", "Light is a form of ___ radiation." },
                    { 129, "D", 26, "Violet", "Blue", "Green", "Red", "Which color of visible light has the longest wavelength?" },
                    { 130, "B", 26, "3 x 10^6 m/s", "3 x 10^8 m/s", "3 x 10^10 m/s", "340 m/s", "The speed of light in a vacuum (c) is approximately:" },
                    { 131, "A", 27, "Converging (Convex) lens", "Diverging (Concave) lens", "Plane mirror", "Prism", "A lens that converges parallel light rays to a focal point is a:" },
                    { 132, "B", 27, "Converging (Convex) lens", "Diverging (Concave) lens", "Convex mirror", "Diffraction grating", "A lens that spreads out parallel light rays appears to originate from a focal point is a:" },
                    { 133, "B", 27, "Virtual", "Real", "Inverted", "Magnified", "An image formed where light rays actually converge is called a ___ image." },
                    { 134, "A", 27, "Virtual", "Real", "Upright", "Diminished", "An image formed where light rays only appear to diverge from is called a ___ image." },
                    { 135, "C", 27, "1/p - 1/q = 1/f", "p + q = f", "1/p + 1/q = 1/f", "p*q = f", "The thin lens equation relates object distance (p), image distance (q), and focal length (f) as:" },
                    { 136, "C", 28, "Reflection", "Refraction", "Diffraction", "Interference", "Diffraction is the bending of waves as they pass through an opening or around an obstacle." },
                    { 137, "C", 28, "Much smaller than", "Much larger than", "Comparable to", "Unrelated to", "Diffraction effects are most noticeable when the wavelength of the wave is ___ the size of the opening or obstacle." },
                    { 138, "B", 28, "Narrower and dimmer", "Wider and brighter", "The same width and brightness", "Absent", "When light passes through a single narrow slit, it produces a central bright fringe that is ___ than the other bright fringes." },
                    { 139, "D", 28, "Lenses", "Mirrors", "Prisms", "Slits or lines", "A diffraction grating consists of many closely spaced:" },
                    { 140, "C", 28, "Magnification", "Brightness", "Resolution (ability to distinguish details)", "Color accuracy", "Diffraction limits the ___ of optical instruments like telescopes and microscopes." },
                    { 141, "D", 29, "Mass", "Momentum", "Charge", "Energy", "The First Law of Thermodynamics is a statement of the conservation of:" },
                    { 142, "A", 29, "Work", "Temperature", "Pressure", "Volume", "The change in internal energy (ΔU) of a system equals the heat (Q) added to the system minus the ___ (W) done by the system." },
                    { 143, "C", 29, "Potential only", "Kinetic only", "Kinetic and Potential", "External", "Internal energy (U) refers to the total ___ energy of the molecules within a system." },
                    { 144, "C", 29, "Change in Internal Energy (ΔU)", "Work done (W)", "Heat transfer (Q)", "Change in Temperature (ΔT)", "In an adiabatic process, what is equal to zero?" },
                    { 145, "C", 29, "Pressure", "Volume", "Temperature", "Internal Energy (for ideal gas)", "In an isothermal process, what remains constant?" },
                    { 146, "B", 30, "Energy conservation", "Entropy and the direction of processes", "Absolute zero", "Pressure-volume relationship", "The Second Law of Thermodynamics deals with the concept of:" },
                    { 147, "D", 30, "Energy", "Temperature", "Order", "Disorder", "Entropy is a measure of the ___ or randomness of a system." },
                    { 148, "C", 30, "Decrease", "Stay constant", "Increase", "Fluctuate randomly", "The Second Law states that the total entropy of an isolated system tends to ___ over time." },
                    { 149, "A", 30, "Hotter, Colder", "Colder, Hotter", "Larger, Smaller", "Smaller, Larger", "Heat naturally flows from a ___ object to a ___ object." },
                    { 150, "B", 30, "Mechanical, Thermal", "Thermal, Mechanical", "Electrical, Chemical", "Chemical, Electrical", "A heat engine converts ___ energy into ___ work." },
                    { 151, "B", 31, "Reflects all incident radiation", "Absorbs all incident radiation", "Transmits all incident radiation", "Emits only visible light", "A perfect blackbody is an idealized object that:" },
                    { 152, "C", 31, "Photoelectric effect", "Compton effect", "Ultraviolet catastrophe", "Wave-particle duality", "Classical physics failed to explain the observed spectrum of blackbody radiation, leading to the:" },
                    { 153, "D", 31, "Electrons", "Protons", "Waves", "Quanta (photons)", "Max Planck proposed that energy is quantized, meaning it can only be emitted or absorbed in discrete packets called:" },
                    { 154, "B", 31, "Wavelength", "Frequency", "Amplitude", "Speed", "The energy of a quantum (photon) is proportional to its:" },
                    { 155, "C", 31, "Mass", "Charge", "Frequency", "Wavelength", "Planck's constant (h) relates the energy of a photon to its:" },
                    { 156, "C", 32, "Albert Einstein", "Max Planck", "Louis de Broglie", "Niels Bohr", "Who proposed that particles, like electrons, could exhibit wave-like properties?" },
                    { 157, "C", 32, "Mass", "Velocity", "Momentum", "Energy", "The de Broglie wavelength of a particle is inversely proportional to its:" },
                    { 158, "B", 32, "Photoelectric effect", "Electron diffraction", "Blackbody radiation", "Atomic spectra", "The wave nature of electrons was experimentally confirmed by observing:" },
                    { 159, "C", 32, "Only wave properties", "Only particle properties", "Both wave and particle properties", "Neither wave nor particle properties", "Wave-particle duality means that entities like light and electrons exhibit:" },
                    { 160, "C", 32, "Very large and easily observable", "Comparable to visible light", "Extremely small and negligible", "Zero", "For macroscopic objects (like a baseball), the de Broglie wavelength is:" },
                    { 161, "C", 33, "Newton's equation (F=ma)", "Maxwell's equations", "Schrödinger equation", "Einstein's field equations", "The fundamental equation of non-relativistic quantum mechanics is the:" },
                    { 162, "B", 33, "Position and momentum", "Wave function (Ψ)", "Energy level", "Spin", "In quantum mechanics, the state of a particle is described by its:" },
                    { 163, "C", 33, "Energy density", "Momentum density", "Probability density of finding the particle", "Charge density", "The square of the magnitude of the wave function (|Ψ|^2) represents:" },
                    { 164, "B", 33, "Position, Energy", "Position, Momentum", "Energy, Time", "Spin, Charge", "Heisenberg's Uncertainty Principle states that you cannot simultaneously know both the exact ___ and ___ of a particle." },
                    { 165, "B", 33, "Travel faster than light", "Pass through a potential barrier it classically shouldn't overcome", "Exist in multiple places at once", "Split into two particles", "Quantum tunneling refers to a particle's ability to:" },
                    { 166, "B", 34, "General Relativity", "Special Relativity", "Quantum Mechanics", "Newtonian Mechanics", "Time dilation is a consequence of:" },
                    { 167, "B", 34, "Faster", "Slower", "At the same rate", "Backward", "According to time dilation, time for a moving observer appears to pass ___ compared to a stationary observer." },
                    { 168, "C", 34, "Longer", "Wider", "Shorter", "Unchanged", "Length contraction means that an object moving at relativistic speeds appears ___ in the direction of motion to a stationary observer." },
                    { 169, "C", 34, "The speed of sound", "Escape velocity", "The speed of light", "Orbital velocity", "These relativistic effects become significant only at speeds close to:" },
                    { 170, "B", 34, "Older", "Younger", "The same age", "It's impossible to say", "The twin paradox involves one twin traveling at relativistic speed. When they reunite, the traveling twin is ___." },
                    { 171, "C", 35, "Electromagnetism", "Quantum Mechanics", "Gravitation", "Thermodynamics", "General Relativity, developed by Einstein, is a theory of:" },
                    { 172, "B", 35, "Velocity", "Gravity", "Mass", "Time", "The Principle of Equivalence states that ___ is indistinguishable from acceleration." },
                    { 173, "C", 35, "Electric fields", "Magnetic fields", "Spacetime", "Energy levels", "General Relativity describes gravity not as a force, but as a curvature of:" },
                    { 174, "B", 35, "Charge", "Mass and Energy", "Velocity", "Spin", "What causes the curvature of spacetime, according to General Relativity?" },
                    { 175, "B", 35, "Photoelectric effect", "Gravitational lensing", "Electron diffraction", "Blackbody radiation", "Which phenomenon provides observational evidence for General Relativity?" },
                    { 176, "B", 36, "Eukaryotic", "Prokaryotic", "Plant cell", "Animal cell", "Which cell type lacks a true nucleus and membrane-bound organelles?" },
                    { 177, "A", 36, "Eukaryotic", "Prokaryotic", "Bacterial cell", "Archaeal cell", "Which cell type has a nucleus and membrane-bound organelles?" },
                    { 178, "D", 36, "Organ", "Tissue", "Molecule", "Cell", "The basic structural and functional unit of all known organisms is the:" },
                    { 179, "C", 36, "Nucleus", "Mitochondria", "Cell Wall", "Cell membrane", "Which of these is found in plant cells but not typically in animal cells?" },
                    { 180, "B", 36, "Nucleus", "Cytoplasm", "Cell membrane", "Cell wall", "The semi-fluid substance filling the cell, enclosing the organelles, is the:" },
                    { 181, "C", 37, "Ribosome", "Mitochondrion", "Nucleus", "Endoplasmic Reticulum", "Which organelle contains the cell's genetic material (DNA)?" },
                    { 182, "B", 37, "Lysosome", "Mitochondrion", "Golgi apparatus", "Chloroplast", "Which organelle is responsible for generating most of the cell's ATP through cellular respiration?" },
                    { 183, "C", 37, "Nucleus", "Vacuole", "Ribosome", "Peroxisome", "Which organelle is the site of protein synthesis?" },
                    { 184, "B", 37, "Endoplasmic Reticulum", "Golgi apparatus", "Lysosome", "Mitochondrion", "Which organelle modifies, sorts, and packages proteins and lipids for secretion or delivery?" },
                    { 185, "B", 37, "Mitochondrion", "Chloroplast", "Vacuole", "Cell Wall", "Which organelle, found in plant cells and algae, is the site of photosynthesis?" },
                    { 186, "C", 38, "Mitosis", "Cytokinesis", "Interphase", "Meiosis", "The phase of the cell cycle where the cell grows and replicates its DNA is called:" },
                    { 187, "C", 38, "DNA replication", "Cell growth", "Nuclear division", "Cytoplasm division", "Mitosis is the process of:" },
                    { 188, "D", 38, "Metaphase", "Anaphase", "Telophase", "Prophase", "During which phase of mitosis do chromosomes condense and become visible?" },
                    { 189, "B", 38, "Prophase", "Metaphase", "Anaphase", "Telophase", "During which phase of mitosis do chromosomes line up along the center of the cell?" },
                    { 190, "C", 38, "Interphase", "Mitosis", "Cytokinesis", "Meiosis", "The division of the cytoplasm to form two separate daughter cells is called:" },
                    { 191, "A", 39, "Deoxyribonucleic Acid", "Ribonucleic Acid", "Dioxygen Nucleic Acid", "Double Nucleotide Axis", "DNA stands for:" },
                    { 192, "B", 39, "Single helix", "Double helix", "Triple helix", "Beta sheet", "The structure of DNA is described as a:" },
                    { 193, "C", 39, "Guanine (G)", "Cytosine (C)", "Thymine (T)", "Uracil (U)", "In DNA base pairing, Adenine (A) always pairs with:" },
                    { 194, "B", 39, "Adenine (A)", "Cytosine (C)", "Thymine (T)", "Uracil (U)", "In DNA base pairing, Guanine (G) always pairs with:" },
                    { 195, "C", 39, "Two new strands", "Two original strands", "One new strand and one original strand", "Random segments of old and new", "DNA replication is described as semi-conservative because each new DNA molecule consists of:" },
                    { 196, "C", 40, "DNA, RNA", "RNA, DNA", "Protein, RNA", "RNA, Protein", "Translation is the process of synthesizing ___ from a(n) ___ template." },
                    { 197, "C", 40, "Nucleus", "Mitochondrion", "Ribosome (in cytoplasm)", "Golgi apparatus", "Where does translation occur in a eukaryotic cell?" },
                    { 198, "C", 40, "Gene", "Anticodon", "Codon", "Exon", "A sequence of three nucleotides on mRNA that specifies an amino acid is called a:" },
                    { 199, "B", 40, "mRNA (messenger RNA)", "tRNA (transfer RNA)", "rRNA (ribosomal RNA)", "snRNA (small nuclear RNA)", "Which type of RNA carries amino acids to the ribosome during translation?" },
                    { 200, "B", 40, "Stop", "Start (usually AUG)", "Anticodon", "Promoter", "The process starts when the ribosome binds to the mRNA and finds the ___ codon." },
                    { 201, "D", 41, "Support", "Protection of organs", "Movement (with muscles)", "Digestion of food", "Which is NOT a primary function of the skeletal system?" },
                    { 202, "B", 41, "Exoskeleton", "Endoskeleton", "Hydrostatic skeleton", "No skeleton", "The human skeleton is an example of an:" },
                    { 203, "B", 41, "Keratin", "Collagen", "Actin", "Myosin", "Bones are primarily composed of calcium phosphate and a protein called:" },
                    { 204, "C", 41, "Tendon", "Ligament", "Joint", "Cartilage", "The place where two or more bones meet is called a:" },
                    { 205, "C", 41, "Fat cells", "Cartilage", "Blood cells", "Nerve cells", "Red bone marrow is responsible for producing:" },
                    { 206, "D", 42, "Chemistry", "Genetics", "Ecology", "Mechanics (Physics)", "Biomechanics applies the principles of ___ to biological systems." },
                    { 207, "A", 42, "Effort (muscle force) and Load (resistance)", "Only Effort", "Only Load", "Blood vessels", "A lever system in the body consists of a rigid bar (bone), a pivot point (joint), and:" },
                    { 208, "C", 42, "Only movement", "Only deformation", "Both movement and deformation", "Only temperature change", "Forces acting on the body can cause:" },
                    { 209, "C", 42, "Cell biology", "Genetics", "Biomechanics", "Taxonomy", "Analyzing the forces involved in activities like walking or jumping is part of:" },
                    { 210, "B", 42, "Mental anxiety", "Force applied per unit area", "Change in length", "Rate of movement", "Stress in biomechanics refers to:" },
                    { 211, "B", 43, "Sensory neurons", "Motor neurons", "Interneurons", "Glial cells", "Which part of the nervous system sends signals from the brain/spinal cord to muscles?" },
                    { 212, "B", 43, "Synapse", "Neuromuscular junction", "Axon terminal", "Dendrite", "The junction where a motor neuron communicates with a muscle fiber is the:" },
                    { 213, "B", 43, "Voluntary action", "Reflex", "Thought", "Habit", "A rapid, involuntary response to a stimulus is called a:" },
                    { 214, "B", 43, "Cerebrum", "Cerebellum", "Brainstem", "Thalamus", "Which part of the brain is primarily responsible for coordinating voluntary movements and balance?" },
                    { 215, "C", 43, "Serotonin", "Dopamine", "Acetylcholine", "GABA", "Muscle contraction is initiated by the release of a neurotransmitter called ___ at the neuromuscular junction." },
                    { 216, "B", 44, "Individual organisms", "Species populations", "Entire ecosystems", "Global climate", "Population ecology studies the dynamics of:" },
                    { 217, "B", 44, "Logistic", "Exponential", "Linear", "Logarithmic", "Unrestricted population growth with unlimited resources follows a(n) ___ growth model." },
                    { 218, "B", 44, "Growth rate (r)", "Carrying capacity (K)", "Population density", "Biotic potential", "The maximum population size that an environment can sustain indefinitely is the:" },
                    { 219, "B", 44, "Density-independent", "Density-dependent", "Abiotic factors", "Random factors", "Factors like disease or competition, whose effects intensify as population density increases, are:" },
                    { 220, "C", 44, "Density-dependent", "Biotic factors", "Density-independent", "Competitive factors", "Factors like natural disasters (fire, flood), whose effects are independent of population density, are:" },
                    { 221, "C", 45, "Only plant", "Only animal", "Non-living (abiotic)", "Microscopic", "An ecosystem includes all the living organisms (biotic factors) and the ___ components in an area." },
                    { 222, "B", 45, "Decomposers", "The sun", "Chemical bonds", "Geothermal heat", "The flow of energy in most ecosystems originates from:" },
                    { 223, "B", 45, "Consumers", "Producers (Autotrophs)", "Decomposers", "Herbivores", "Organisms that produce their own food (like plants) are called:" },
                    { 224, "B", 45, "Food web", "Food chain", "Biogeochemical cycle", "Trophic level", "A sequence showing how energy is transferred from one living organism to another is a:" },
                    { 225, "C", 45, "Energy only", "Organisms", "Chemical elements/Nutrients", "Water only", "Biogeochemical cycles describe the movement of ___ through an ecosystem." },
                    { 226, "D", 46, "Leaf", "Stem", "Flower", "Root", "Which plant part typically anchors the plant and absorbs water and nutrients?" },
                    { 227, "C", 46, "Root", "Leaf", "Stem", "Seed", "Which plant part typically supports the leaves and flowers and transports substances?" },
                    { 228, "C", 46, "Root", "Stem", "Leaf", "Flower", "The primary site of photosynthesis in most plants is the:" },
                    { 229, "C", 46, "Vascular tissues", "Epidermis", "Meristems", "Ground tissues", "Regions of actively dividing cells responsible for plant growth are called:" },
                    { 230, "B", 46, "Width, Length", "Length, Width", "Height, Depth", "Color, Texture", "Primary growth increases the ___ of a plant, while secondary growth increases its ___." },
                    { 231, "B", 47, "Nitrogen", "Carbon Dioxide", "Oxygen", "Hydrogen", "Photosynthesis uses sunlight, water, and ___ to produce glucose and oxygen." },
                    { 232, "C", 47, "Carotene", "Xanthophyll", "Chlorophyll", "Anthocyanin", "The green pigment in plants that captures light energy is:" },
                    { 233, "B", 47, "Stroma", "Thylakoid membranes (within chloroplasts)", "Cytoplasm", "Mitochondria", "Where do the light-dependent reactions of photosynthesis occur?" },
                    { 234, "B", 47, "Thylakoid membranes", "Stroma (within chloroplasts)", "Nucleus", "Cell wall", "Where does the Calvin cycle (light-independent reactions) occur?" },
                    { 235, "D", 47, "Oxygen", "ATP", "NADPH", "Glucose (or precursors)", "The primary product of the Calvin cycle is:" },
                    { 236, "C", 48, "Enzymes", "Pigments", "Hormones (Phytohormones)", "Neurotransmitters", "Chemical messengers that regulate plant growth and development are called:" },
                    { 237, "C", 48, "Gibberellin", "Cytokinin", "Auxin", "Abscisic acid", "Which hormone is primarily responsible for cell elongation and apical dominance?" },
                    { 238, "C", 48, "Gravitropism", "Thigmotropism", "Phototropism", "Hydrotropism", "A plant's growth response towards a light source is called:" },
                    { 239, "B", 48, "Phototropism", "Gravitropism (Geotropism)", "Thigmotropism", "Nastic movement", "A plant's growth response to gravity is called:" },
                    { 240, "D", 48, "Auxin", "Ethylene", "Abscisic acid", "Gibberellin", "Which hormone promotes seed germination and stem elongation?" },
                    { 241, "C", 49, "Vertebrates", "Chordates", "Invertebrates", "Mammals", "Animals lacking a backbone are classified as:" },
                    { 242, "C", 49, "Cnidaria", "Platyhelminthes", "Porifera", "Nematoda", "Which phylum includes simple, porous animals like sponges?" },
                    { 243, "B", 49, "Porifera", "Cnidaria", "Mollusca", "Annelida", "Jellyfish, corals, and anemones belong to which phylum, characterized by stinging cells (cnidocytes)?" },
                    { 244, "C", 49, "Nematoda", "Annelida", "Platyhelminthes", "Arthropoda", "Flatworms, such as planarians and tapeworms, belong to the phylum:" },
                    { 245, "D", 49, "Platyhelminthes", "Annelida", "Cnidaria", "Nematoda", "Roundworms, often parasitic, are members of the phylum:" },
                    { 246, "C", 50, "Arthropoda", "Mollusca", "Chordata", "Echinodermata", "Vertebrates belong to the phylum:" },
                    { 247, "C", 50, "Notochord", "Dorsal hollow nerve cord", "Exoskeleton", "Pharyngeal slits", "Which is NOT a defining characteristic of chordates (at some life stage)?" },
                    { 248, "B", 50, "Lungs and feathers", "Gills and fins", "Mammary glands and hair", "Scaly skin and amniotic eggs", "Fish are aquatic vertebrates characterized by:" },
                    { 249, "B", 50, "Jawless", "Bony", "Lobe-finned", "Ray-finned", "The two major groups of living fish are the cartilaginous fish (e.g., sharks) and the ___ fish." },
                    { 250, "C", 50, "Lungs", "Skin", "Gills", "Spiracles", "Most fish utilize ___ for gas exchange." },
                    { 251, "C", 51, "Animals", "Plants", "Microorganisms (Microbes)", "Minerals", "Microbiology is the study of organisms too small to be seen with the naked eye, called:" },
                    { 252, "B", 51, "Fungi and Protists", "Bacteria and Archaea", "Viruses and Prions", "Algae and Protozoa", "Which group of microbes are prokaryotic?" },
                    { 253, "C", 51, "Bacteria", "Fungi", "Viruses", "Protists", "Which group are acellular infectious agents, consisting of genetic material within a protein coat?" },
                    { 254, "D", 51, "Bacteria", "Archaea", "Protista", "Fungi", "Yeasts and molds belong to which kingdom?" },
                    { 255, "B", 51, "Prokaryotic", "Eukaryotic", "Viral", "Bacterial", "Protists are a diverse group of ___ organisms." },
                    { 256, "C", 52, "Mitosis", "Meiosis", "Binary Fission", "Budding", "Most bacteria reproduce asexually through a process called:" },
                    { 257, "A", 52, "Stationary", "Growth", "Decline", "Peak", "The typical bacterial growth curve has four phases: Lag, Log (Exponential), ___, and Death." },
                    { 258, "B", 52, "Lag", "Log (Exponential)", "Stationary", "Death", "During which phase is bacterial growth most rapid?" },
                    { 259, "D", 52, "Obligate anaerobes", "Facultative anaerobes", "Aerotolerant anaerobes", "Obligate aerobes", "Microbes that require oxygen for growth are called:" },
                    { 260, "B", 52, "Physical", "Chemical", "Nuclear", "Mechanical", "Metabolism refers to all the ___ reactions occurring within a cell." },
                    { 261, "C", 53, "Decomposers", "Producers", "Pathogens", "Symbionts", "Microorganisms that cause disease are called:" },
                    { 262, "C", 53, "Primary producers", "Top predators", "Decomposers", "Herbivores", "Microbes like bacteria and fungi play a crucial role in ecosystems as:" },
                    { 263, "C", 53, "Bioremediation", "Pathogenesis", "Fermentation", "Nitrogen fixation", "The use of microorganisms to produce foods like yogurt, cheese, and bread is an example of:" },
                    { 264, "C", 53, "Fermentation", "Pasteurization", "Bioremediation", "Vaccination", "Using microbes to clean up pollutants (like oil spills) is called:" },
                    { 265, "D", 53, "Viruses", "Plants", "Animals", "Microorganisms (bacteria, fungi)", "Many antibiotics are naturally produced by:" },
                    { 266, "A", 54, "Single", "Double", "Triple", "Single and double", "Alkanes are hydrocarbons containing only ___ bonds." },
                    { 267, "B", 54, "CnH2n", "CnH2n+2", "CnH2n-2", "CnHn", "The general formula for non-cyclic alkanes is:" },
                    { 268, "C", 54, "Ethane", "Propane", "Methane", "Butane", "What is the IUPAC name for CH4?" },
                    { 269, "C", 54, "Straight chain", "Branched chain", "Ring structure", "Double bond", "Cycloalkanes are alkanes that form a:" },
                    { 270, "C", 54, "Isomers", "Isotopes", "Conformations", "Resonance structures", "Different spatial arrangements of a molecule that result from rotation around single bonds are called:" },
                    { 271, "C", 55, "Oxygen", "Nitrogen", "Carbon", "Silicon", "Organic chemistry focuses on compounds containing which element?" },
                    { 272, "C", 55, "Atoms", "Protons", "Electrons (usually pairs)", "Neutrons", "Curved arrows in reaction mechanisms typically show the movement of:" },
                    { 273, "B", 55, "Electrophile", "Nucleophile", "Radical", "Carbocation", "A species that donates an electron pair is a:" },
                    { 274, "A", 55, "Electrophile", "Nucleophile", "Carbanion", "Alkane", "A species that accepts an electron pair is an:" },
                    { 275, "D", 55, "Temperature", "Pressure", "Concentration", "Energy", "A reaction energy diagram plots ___ versus reaction progress." },
                    { 276, "C", 56, "Electron cloud", "Orbital", "Nucleus", "Shell", "The central part of an atom containing protons and neutrons is the:" },
                    { 277, "B", 56, "Mass number", "Atomic number", "Isotope", "Charge", "The number of protons in the nucleus defines the element's:" },
                    { 278, "C", 56, "Nucleons", "Isotopes", "Orbitals/Shells", "Quarks", "Electrons occupy specific energy levels or regions around the nucleus called:" },
                    { 279, "A", 56, "Increases", "Decreases", "Stays constant", "Becomes zero", "Electronegativity generally ___ across a period (left to right) on the periodic table." },
                    { 280, "C", 56, "Decreases", "Stays constant", "Increases", "Becomes negative", "Atomic radius generally ___ down a group (top to bottom) on the periodic table." },
                    { 281, "C", 57, "Nuclei", "Inner shell electrons", "Atomic orbitals", "Molecular orbitals", "Valence Bond Theory describes covalent bonds as the overlap of:" },
                    { 282, "C", 57, "Ionization", "Excitation", "Hybridization", "Resonance", "The mixing of atomic orbitals to form new hybrid orbitals (like sp, sp2, sp3) is called:" },
                    { 283, "B", 57, "Individual atoms", "Entire molecule", "Nucleus only", "Valence shell only", "Molecular Orbital (MO) Theory describes bonding in terms of orbitals that belong to the:" },
                    { 284, "A", 57, "Antibonding", "Nonbonding", "Hybrid", "Sigma", "In MO theory, combining atomic orbitals forms bonding MOs (lower energy) and ___ MOs (higher energy)." },
                    { 285, "D", 57, "Valence Bond Theory", "VSEPR Theory", "Lewis Theory", "Molecular Orbital Theory", "Which theory better explains the paramagnetism of O2?" },
                    { 286, "D", 58, "Alkali metals", "Halogens", "Noble gases", "Transition metals", "Coordination chemistry primarily involves complexes formed by:" },
                    { 287, "C", 58, "Salt", "Alloy", "Coordination complex/Compound", "Zwitterion", "A central metal ion bonded to surrounding molecules or ions (ligands) forms a:" },
                    { 288, "B", 58, "Lewis acids", "Lewis bases", "Bronsted acids", "Bronsted bases", "Ligands act as ___ by donating electron pairs to the central metal ion." },
                    { 289, "B", 58, "Oxidation state", "Coordination number", "Atomic number", "Ligand field strength", "The number of donor atoms directly attached to the central metal ion is the:" },
                    { 290, "C", 58, "Cl-", "CN-", "H2O", "None are neutral", "Common ligands include H2O, NH3, Cl-, and CN-. Which of these is neutral?" },
                    { 291, "B", 59, "By", "On", "Around", "Through", "The First Law of Thermodynamics mathematically is often written as ΔU = Q + W, where W is work done ___ the system." },
                    { 292, "B", 59, "Path function (e.g., Q, W)", "State function (e.g., U, H, T, P, V)", "Process variable", "Constant", "A property whose value depends only on the current state of the system, not the path taken, is a:" },
                    { 293, "A", 59, "PV", "TS", "Q", "W", "Enthalpy (H) is defined as H = U + ___." },
                    { 294, "B", 59, "Work done (W)", "Heat transferred (Qp)", "Change in internal energy (ΔU)", "Change in entropy (ΔS)", "For a reaction at constant pressure, the change in enthalpy (ΔH) is equal to the:" },
                    { 295, "C", 59, "Pressure changes", "Volume changes", "Heat flow", "Reaction rates", "Calorimetry is used to measure:" },
                    { 296, "C", 60, "Reaction equilibrium", "Reaction thermodynamics (spontaneity)", "Reaction rates and mechanisms", "Atomic structure", "Chemical kinetics is the study of:" },
                    { 297, "C", 60, "Temperature only", "Product concentrations", "Reactant concentrations", "Catalyst concentration only", "The rate law expresses the reaction rate as a function of:" },
                    { 298, "C", 60, "Enthalpy change (ΔH)", "Gibbs free energy change (ΔG)", "Activation energy (Ea)", "Internal energy (U)", "The minimum energy required for reactants to form products is the:" },
                    { 299, "D", 60, "Reactant", "Product", "Intermediate", "Catalyst", "A substance that increases the reaction rate without being consumed is a:" },
                    { 300, "C", 60, "Pressure", "Concentration", "Activation energy", "Entropy", "The Arrhenius equation relates the rate constant (k) to temperature and:" },
                    { 301, "B", 61, "Synthesis, reaction", "Separation, identification", "Theory, calculation", "Safety, disposal", "Analytical chemistry deals with the ___, ___, and quantification of chemical substances." },
                    { 302, "B", 61, "Precision", "Accuracy", "Resolution", "Sensitivity", "The closeness of a measurement to the true value is called:" },
                    { 303, "A", 61, "Precision", "Accuracy", "Bias", "Significance", "The closeness of repeated measurements to each other is called:" },
                    { 304, "B", 61, "Random errors", "Systematic errors", "Gross errors", "Statistical errors", "Errors that affect accuracy and have a definite value and assignable cause are:" },
                    { 305, "B", 61, "2", "3", "4", "5", "How many significant figures are in the number 0.0520 cm?" },
                    { 306, "C", 62, "Sound", "Heat", "Electromagnetic radiation (light)", "Magnetic fields", "Spectroscopy studies the interaction between ___ and matter." },
                    { 307, "C", 62, "Molecular vibrations", "Nuclear spin", "Electron transitions", "Molecular rotation", "UV-Vis spectroscopy measures the absorption of ultraviolet and visible light, which is related to:" },
                    { 308, "A", 62, "Molar absorptivity (ε)", "Wavelength (λ)", "Frequency (ν)", "Refractive index (n)", "Beer-Lambert Law relates absorbance (A) to concentration (c), path length (b), and:" },
                    { 309, "C", 62, "Elemental composition", "Molecular weight", "Functional groups", "Electron configuration", "Infrared (IR) spectroscopy is primarily used to identify:" },
                    { 310, "A", 62, "Intensity (Transmittance/Absorbance)", "Wavelength", "Frequency", "Speed", "A spectrophotometer measures the ___ of light passing through a sample." },
                    { 311, "D", 63, "Optical", "Thermal", "Magnetic", "Electrical (potential, current, charge)", "Electroanalytical methods are based on measuring ___ properties of a solution." },
                    { 312, "C", 63, "Current", "Resistance", "Potential (Voltage)", "Capacitance", "Potentiometry measures the ___ difference between two electrodes in a solution at equilibrium." },
                    { 313, "C", 63, "Conductivity", "Temperature", "pH", "Viscosity", "A common application of potentiometry is measuring ___ using a pH meter." },
                    { 314, "A", 63, "Current", "Resistance", "pH", "Temperature", "Voltammetry involves measuring the ___ as the potential applied to an electrode is varied." },
                    { 315, "A", 63, "Counter (Auxiliary)", "Indicator", "Sacrificial", "Grounding", "These methods often use a working electrode, a reference electrode, and sometimes a ___ electrode." },
                    { 316, "C", 64, "Carbohydrates", "Lipids", "Proteins", "Nucleic acids", "Enzymes are biological catalysts that increase the rate of biochemical reactions, typically made of:" },
                    { 317, "C", 64, "Temperature", "Substrate concentration", "Activation energy", "pH", "Enzymes increase reaction rates by lowering the:" },
                    { 318, "B", 64, "Product", "Substrate", "Cofactor", "Inhibitor", "The specific molecule upon which an enzyme acts is called the:" },
                    { 319, "B", 64, "Enzyme concentration", "Substrate concentration", "Temperature", "pH", "The Michaelis-Menten equation describes the relationship between reaction velocity and:" },
                    { 320, "C", 64, "Activator", "Substrate", "Inhibitor", "Cofactor", "A substance that binds to an enzyme and decreases its activity is an:" },
                    { 321, "B", 65, "Hydrophilic (water-loving)", "Hydrophobic (water-fearing)", "Positively charged", "Negatively charged", "Lipids are a diverse group of organic molecules characterized by being largely:" },
                    { 322, "B", 65, "Amino acids", "Fatty acids", "Monosaccharides", "Nucleotides", "Fats and oils are composed of glycerol bonded to three:" },
                    { 323, "C", 65, "Triglycerides", "Steroids", "Phospholipids", "Waxes", "The primary structural components of cell membranes are:" },
                    { 324, "B", 65, "Hydrophilic", "Hydrophobic", "Charged", "Polar", "Phospholipids have a hydrophilic head and a ___ tail." },
                    { 325, "B", 65, "Triglycerides", "Phospholipids", "Carbohydrates", "Cholesterol", "The Fluid Mosaic Model describes the cell membrane as proteins embedded or attached to a fluid bilayer of:" },
                    { 326, "B", 66, "Oxygen (O2)", "Nitrogen (N2)", "Carbon Dioxide (CO2)", "Argon (Ar)", "The most abundant gas in Earth's atmosphere is:" },
                    { 327, "B", 66, "Troposphere", "Stratosphere", "Mesosphere", "Thermosphere", "The ozone layer, which absorbs harmful UV radiation, is located primarily in the:" },
                    { 328, "B", 66, "N2 and O2", "CO2, CH4, H2O", "Ar and Ne", "O3 and SO2", "Which gases contribute to the greenhouse effect by trapping heat?" },
                    { 329, "B", 66, "Carbon", "Nitrogen", "Ozone", "Chlorine", "Acid rain is primarily caused by atmospheric pollutants like sulfur dioxide (SO2) and ___ oxides." },
                    { 330, "B", 66, "Acid rain formation", "Ozone layer depletion", "Global warming", "Smog formation", "Chlorofluorocarbons (CFCs) were phased out due to their role in:" },
                    { 331, "A", 67, "Air", "Plastic", "Metal", "Glass", "Soil is a complex mixture of minerals, organic matter, water, and:" },
                    { 332, "C", 67, "Minerals", "Bedrock", "Organic matter (humus)", "Sand", "The decomposition of dead plants and animals forms ___ in the soil." },
                    { 333, "C", 67, "Only water retention", "Only soil color", "Nutrient availability to plants", "Only soil texture", "Soil pH affects:" },
                    { 334, "C", 67, "Water", "Air", "Positive ions (cations)", "Negative ions (anions)", "Cation Exchange Capacity (CEC) is a measure of the soil's ability to hold:" },
                    { 335, "C", 67, "Only plant growth", "Only water quality", "Plant growth, water quality, and human health", "Only air quality", "Contamination of soil with heavy metals or pesticides can negatively impact:" },
                    { 336, "B", 68, "Useful substances", "Hazardous substances", "Expensive substances", "Recyclable substances", "Green Chemistry aims to design chemical products and processes that reduce or eliminate the use and generation of:" },
                    { 337, "B", 68, "Prevent waste", "Maximize atom economy", "Use safer solvents", "Design for energy efficiency", "Which principle emphasizes using raw materials efficiently (atom economy)?" },
                    { 338, "B", 68, "Waste prevention", "Safer chemical design", "Catalysis", "Real-time analysis", "Designing chemicals with little or no toxicity is a principle of Green Chemistry related to:" },
                    { 339, "D", 68, "More waste", "Less selectivity", "Higher energy use", "Less waste and higher efficiency", "Using catalysts instead of stoichiometric reagents often leads to:" },
                    { 340, "C", 68, "Atom economy", "Designing for degradation", "Using safer solvents and auxiliaries", "Inherently safer chemistry", "Choosing solvents like water or supercritical CO2 over hazardous organic solvents aligns with the principle of:" },
                    { 341, "B", 69, "All molecules", "Very simple systems (e.g., H atom)", "Only solids", "No systems", "Approximation methods are needed in quantum chemistry because the Schrödinger equation can only be solved exactly for:" },
                    { 342, "A", 69, "Equal to or greater than", "Equal to or less than", "Always less than", "Unrelated to", "The Variation Principle states that the energy calculated using any approximate wave function will be ___ the true ground state energy." },
                    { 343, "B", 69, "Cannot be solved", "Can be solved exactly", "Has zero energy", "Is temperature dependent", "Perturbation theory is used when the system's Hamiltonian is only slightly different from one that:" },
                    { 344, "B", 69, "Maximize", "Minimize", "Keep constant", "Make zero", "The goal of the variational method is to find the parameters in a trial wave function that ___ the calculated energy." },
                    { 345, "D", 69, "Social systems", "Economic models", "Chemical reactions", "Atoms and molecules", "These methods allow chemists to approximate solutions for complex:" },
                    { 346, "B", 70, "Synthesize new elements", "Solve chemical problems", "Perform physical experiments", "Analyze historical data", "Computational chemistry uses computer simulations to:" },
                    { 347, "C", 70, "Molecular mechanics", "Semi-empirical", "Ab initio", "Density functional theory", "Methods based directly on solving the Schrödinger equation (with approximations) are called ___ methods." },
                    { 348, "B", 70, "Molecular mechanics", "Ab initio", "Density functional theory", "Empirical", "Hartree-Fock (HF) is a common ___ method that approximates electron interactions." },
                    { 349, "A", 70, "Electron density", "Nuclear positions", "Total energy directly", "Dipole moment", "Density Functional Theory (DFT) focuses on calculating the ___ instead of the complex wave function." },
                    { 350, "B", 70, "Slower", "Faster", "More accurate", "Less applicable", "Molecular Mechanics (MM) methods use classical physics and potential energy functions, making them computationally ___ than quantum methods." },
                    { 351, "C", 71, "Plot", "Setting", "Theme", "Character", "The central idea or underlying message of a literary work is its:" },
                    { 352, "B", 71, "Theme", "Plot", "Setting", "Point of view", "The sequence of events in a story constitutes its:" },
                    { 353, "D", 71, "Plot", "Character", "Theme", "Setting", "The time and place in which a story occurs is the:" },
                    { 354, "B", 71, "Setting", "Point of view", "Plot", "Theme", "The perspective from which a story is told (e.g., first-person, third-person) is the:" },
                    { 355, "C", 71, "Plot structure", "Character motivation", "Literary style", "Historical context", "Analyzing how authors use language (diction, imagery, syntax) is part of studying:" },
                    { 356, "B", 72, "Metaphor", "Simile", "Personification", "Hyperbole", "A comparison between two unlike things using 'like' or 'as' is a:" },
                    { 357, "A", 72, "Metaphor", "Simile", "Alliteration", "Onomatopoeia", "A direct comparison between two unlike things without using 'like' or 'as' is a:" },
                    { 358, "C", 72, "Hyperbole", "Simile", "Personification", "Metaphor", "Giving human qualities or abilities to inanimate objects or animals is:" },
                    { 359, "B", 72, "Rhyme scheme", "Meter", "Stanza", "Imagery", "The pattern of stressed and unstressed syllables in a line of poetry is its:" },
                    { 360, "C", 72, "Haiku", "Limerick", "Sonnet", "Villanelle", "A fourteen-line poem with a specific rhyme scheme (e.g., Shakespearean, Petrarchan) is a:" },
                    { 361, "B", 73, "Read silently", "Performed by actors", "Analyzed mathematically", "Sung as an opera", "Drama is literature written to be:" },
                    { 362, "B", 73, "Score", "Script", "Novel", "Libretto", "The written text of a play is called the:" },
                    { 363, "C", 73, "Monologue", "Aside", "Dialogue", "Soliloquy", "Conversation between characters in a play is called:" },
                    { 364, "B", 73, "Dialogue", "Stage directions", "Subtext", "Themes", "Instructions in the script indicating movement, position, or tone are:" },
                    { 365, "D", 73, "Dialogue", "Aside", "Chorus", "Soliloquy", "A long speech delivered by one character, often alone on stage, revealing inner thoughts, is a:" },
                    { 366, "C", 74, "Static character", "Flat character", "Dynamic character", "Stock character", "A character who undergoes significant internal change throughout the story is a:" },
                    { 367, "C", 74, "Dynamic character", "Round character", "Static character", "Protagonist", "A character who does not change significantly is a:" },
                    { 368, "C", 74, "Appearance", "Dialogue", "Motivation", "Setting", "The underlying reason for a character's actions is their:" },
                    { 369, "B", 74, "Direct characterization", "Indirect characterization", "Plot development", "Setting description", "Revealing character through actions, speech, thoughts, and appearance rather than direct statements is:" },
                    { 370, "D", 74, "Round character", "Dynamic character", "Protagonist", "Stock character", "A stereotypical character easily recognized by readers (e.g., the mad scientist) is a:" },
                    { 371, "C", 75, "Character", "Plot", "Social/Cultural", "Thematic", "Setting encompasses the time period, location, and ___ environment of a story." },
                    { 372, "B", 75, "Figurative language", "Sensory details", "Dialogue", "Plot points", "Using details related to sight, sound, smell, taste, and touch to create vivid descriptions is using:" },
                    { 373, "C", 75, "Pacing", "Conflict", "Atmosphere", "Climax", "The overall mood or feeling created by the setting and description is the:" },
                    { 374, "C", 75, "Slow down the plot", "Confuse the reader", "Enhance atmosphere, character, or plot", "Show off vocabulary", "Effective description should primarily serve to:" },
                    { 375, "C", 75, "Dialogue scenes", "Action sequences", "Descriptive passages (info dumps)", "Character arcs", "Integrating setting details naturally within the narrative is often more effective than long:" },
                    { 376, "C", 76, "Verb", "Adjective", "Noun", "Adverb", "Which part of speech names a person, place, thing, or idea?" },
                    { 377, "C", 76, "Noun", "Adjective", "Verb", "Preposition", "Which part of speech describes an action or state of being?" },
                    { 378, "C", 76, "Verb", "Adverb", "Adjective", "Conjunction", "Which part of speech modifies (describes) a noun or pronoun?" },
                    { 379, "C", 76, "Adjective", "Preposition", "Adverb", "Interjection", "Which part of speech modifies a verb, adjective, or another adverb (often ending in -ly)?" },
                    { 380, "D", 76, "Prepositions", "Interjections", "Pronouns", "Conjunctions", "Words like 'and', 'but', 'or' that connect words, phrases, or clauses are:" },
                    { 381, "C", 77, "Question mark (?)", "Exclamation point (!)", "Period (.)", "Comma (,)", "Which punctuation mark is used to end a declarative sentence?" },
                    { 382, "C", 77, "Question", "Command", "List or series", "Title", "Commas are typically used to separate items in a:" },
                    { 383, "C", 77, "Semicolon (;)", "Colon (:)", "Apostrophe (')", "Hyphen (-)", "Which punctuation mark is used to indicate possession or contractions?" },
                    { 384, "B", 77, "Dependent clauses", "Independent clauses", "Phrases", "Words", "A semicolon (;) can be used to connect two closely related:" },
                    { 385, "C", 77, "Possession", "A question", "Direct speech or quoted text", "An abbreviation", "Quotation marks are used primarily to indicate:" },
                    { 386, "B", 78, "Multiple main ideas", "A single main idea", "The entire essay's argument", "Character backstories", "A paragraph typically focuses on developing:" },
                    { 387, "C", 78, "Supporting sentence", "Concluding sentence", "Topic sentence", "Transition sentence", "The sentence that states the main idea of a paragraph is the:" },
                    { 388, "D", 78, "Topic sentence", "Conclusion", "Introduction", "Thesis statement", "The main argument or central point of an entire essay is presented in the:" },
                    { 389, "C", 78, "Topics", "Arguments", "Transitions", "Conclusions", "Words or phrases like 'however', 'in addition', 'therefore' that link ideas are called:" },
                    { 390, "C", 78, "Introduction", "First topic sentence", "Thesis statement (in different words)", "Supporting details", "The concluding paragraph of an essay typically summarizes main points and restates the:" },
                    { 391, "C", 79, "Simile", "Metaphor", "Hyperbole", "Personification", "An extreme exaggeration used for emphasis or effect is:" },
                    { 392, "C", 79, "Simile", "Metaphor", "Personification", "Hyperbole", "'The wind whispered through the trees' is an example of:" },
                    { 393, "B", 79, "Simile", "Metaphor", "Personification", "Alliteration", "'Her smile was a ray of sunshine' is an example of:" },
                    { 394, "A", 79, "Simile", "Metaphor", "Onomatopoeia", "Personification", "'He is as strong as an ox' is an example of:" },
                    { 395, "B", 79, "Figurative", "Literal", "Poetic", "Rhythmic", "Figurative language goes beyond the ___ meaning of words." },
                    { 396, "C", 80, "Sonnet", "Limerick", "Haiku", "Villanelle", "A three-line Japanese poem with a 5-7-5 syllable structure is a:" },
                    { 397, "B", 80, "Sonnet", "Limerick", "Haiku", "Ballad", "A humorous five-line poem with a specific AABBA rhyme scheme is a:" },
                    { 398, "B", 80, "Fixed verse", "Free verse", "Blank verse", "Rhyming verse", "Poetry that does not follow regular patterns of rhyme or meter is called:" },
                    { 399, "B", 80, "Free form", "Iambic pentameter", "Trochaic tetrameter", "Dactylic hexameter", "Blank verse is written in unrhymed:" },
                    { 400, "D", 80, "Sonnet", "Haiku", "Sestina", "Villanelle", "A complex nineteen-line poem with two repeating rhymes and two refrains is a:" },
                    { 401, "C", 81, "Rome", "Egypt", "Greece", "Mesopotamia", "Western theater originated in ancient ___ with festivals honoring the god Dionysus." },
                    { 402, "B", 81, "Comedy", "Tragedy", "Satyr plays", "Epic poetry", "Sophocles, Aeschylus, and Euripides were famous ancient Greek writers of:" },
                    { 403, "C", 81, "Christopher Marlowe", "Ben Jonson", "William Shakespeare", "John Webster", "During the English Renaissance, ___ was a prominent playwright associated with the Globe Theatre." },
                    { 404, "C", 81, "Idealistically", "Comically", "Truthfully and objectively", "Symbolically", "Realism in theater, emerging in the 19th century, aimed to portray life:" },
                    { 405, "C", 81, "Absurdism", "Romanticism", "Realism/Naturalism", "Expressionism", "Playwrights like Henrik Ibsen and Anton Chekhov are associated with which theatrical movement?" },
                    { 406, "B", 82, "Dialogue", "Context", "Staging", "Characters", "Understanding the historical or cultural ___ of a play can enhance interpretation." },
                    { 407, "B", 82, "Themes", "Character tone/emotion", "Rhyme scheme", "Plot summary", "Stage directions provide information about setting, actions, and ___." },
                    { 408, "B", 82, "Text", "Subtext", "Context", "Direction", "The underlying, unspoken meaning or intention behind a character's words is the:" },
                    { 409, "C", 82, "Ignore", "Summarize", "Visualize", "Critique", "When reading a play, it's helpful to ___ the action and setting." },
                    { 410, "C", 82, "Setting", "Theme", "Plot", "Mood", "Analyzing how dialogue reveals character traits and advances the ___ is key." },
                    { 411, "C", 83, "Actor", "Playwright", "Director", "Stage Manager", "Who is responsible for the overall artistic vision and interpretation of the play?" },
                    { 412, "C", 83, "Director", "Designer", "Actor", "Producer", "Who embodies the characters and delivers the dialogue?" },
                    { 413, "B", 83, "Auditory", "Visual", "Textual", "Financial", "Set designers, costume designers, and lighting designers create the ___ elements of the production." },
                    { 414, "C", 83, "Director", "Playwright", "Stage Manager", "Lead Actor", "Who manages the logistical aspects of the production, including rehearsals and performances?" },
                    { 415, "C", 83, "Writing", "Publication", "Performance", "Funding", "The process typically starts with the script and involves casting, rehearsals, design, and finally:" },
                    { 416, "C", 84, "He/She/They", "You", "I/We", "It", "In first-person POV, the narrator uses which pronoun?" },
                    { 417, "C", 84, "No characters", "All characters", "One character", "Only the narrator", "Third-person limited POV allows the reader access to the thoughts and feelings of:" },
                    { 418, "C", 84, "Knows only one character's thoughts", "Is a character in the story", "Knows the thoughts and feelings of all characters", "Does not know any character's thoughts", "Third-person omniscient POV means the narrator:" },
                    { 419, "B", 84, "Very common in fiction", "Rarely used in fiction", "The same as first-person", "The same as third-person omniscient", "Second-person POV ('You go to the store...') is:" },
                    { 420, "C", 84, "Vocabulary", "Grammar", "Experience/Perspective", "Punctuation", "The choice of POV significantly impacts the reader's ___ and understanding of the story." },
                    { 421, "B", 85, "Multiple locations over weeks", "A single location and continuous time", "The narrator's mind only", "The past", "A scene in fiction is typically a unit of action that occurs in:" },
                    { 422, "A", 85, "Resolution/Outcome", "Flashback", "Description only", "Happy ending", "Effective scenes often contain some form of goal, conflict, and:" },
                    { 423, "B", 85, "Volume", "Speed/Rhythm", "Location", "Accuracy", "Pacing within a scene refers to the ___ at which information is revealed and action unfolds." },
                    { 424, "C", 85, "Resolution", "Summary", "Suspense", "Confusion", "Ending a scene with a question, surprise, or setback can create:" },
                    { 425, "C", 85, "Dialogue", "Character names", "Transitions", "Chapter breaks", "Linking scenes together smoothly often requires effective:" },
                    { 426, "B", 86, "Imagination and fantasy", "Facts, real events, and real people", "Poetic meter and rhyme", "Dialogue only", "Non-fiction writing is based on:" },
                    { 427, "C", 86, "Memoir", "Autobiography", "Biography", "Personal essay", "A written account of another person's life is a:" },
                    { 428, "B", 86, "Biography", "Autobiography", "Instruction manual", "News report", "A writer's account of their own life is an:" },
                    { 429, "A", 86, "Essay", "Novel", "Play", "Biography", "A short piece of writing on a particular subject, often expressing the author's viewpoint, is an:" },
                    { 430, "B", 86, "Memoir", "Journalism", "Travel writing", "Literary criticism", "Writing that reports on current events is:" },
                    { 431, "C", 87, "Thematic", "Comparative", "Chronological", "Spatial", "Arranging events in the order they occurred is ___ structure." },
                    { 432, "B", 87, "Chronological", "Thematic", "Narrative", "Cause-and-effect", "Organizing information based on topics or categories is ___ structure." },
                    { 433, "C", 87, "Chronological", "Thematic", "Spatial", "Problem-solution", "Presenting information by describing how things relate in physical space uses ___ structure." },
                    { 434, "A", 87, "Compare and Contrast", "Chronological", "Narrative", "Thematic", "Explaining similarities and differences between subjects uses ___ structure." },
                    { 435, "C", 87, "Thematic", "Spatial", "Narrative", "Compare and Contrast", "Using storytelling techniques (plot, character) to present factual information employs ___ structure." },
                    { 436, "B", 88, "Inventing details", "Accuracy and truthfulness", "Ignoring sources", "Using complex vocabulary", "A primary ethical responsibility in non-fiction is:" },
                    { 437, "B", 88, "Plagiarism", "Fact-checking", "Speculation", "Fictionalization", "Verifying information through multiple reliable sources is called:" },
                    { 438, "C", 88, "Citation", "Paraphrasing", "Plagiarism", "Quoting", "Presenting someone else's work or ideas as your own is:" },
                    { 439, "B", 88, "Plot structure", "Privacy and potential harm", "Rhyme scheme", "Character archetypes", "When writing about real people, authors must consider issues of:" },
                    { 440, "B", 88, "Fictionalization", "Representation", "Speculation", "Exaggeration", "Fairly portraying subjects and avoiding bias is crucial for ethical:" },
                    { 471, "A", 18, "1", "-1", "i", "-i", "What is the value of 'i' raised to the power of 4 (i^4), where 'i' is the imaginary unit?" },
                    { 472, "B", 18, "Differentiation", "Integration", "Factorization", "Extrapolation", "The process of finding the area under a curve is known as:" },
                    { 473, "D", 18, "The limit of f(x) as x approaches 'a' exists", "f(a) is defined", "The limit of f(x) as x approaches 'a' equals f(a)", "All of the above", "A function f(x) is continuous at a point 'a' if which condition is met?" },
                    { 474, "C", 18, "Sine", "Tangent", "Secant", "Cosecant", "Which trigonometric function is the reciprocal of cosine?" },
                    { 475, "C", 18, "An identity matrix", "A zero matrix", "An involutory matrix", "A singular matrix", "A matrix that is its own inverse is called:" },
                    { 476, "B", 18, "Real root", "Complex root", "Rational root", "Integer root", "The Fundamental Theorem of Algebra states that every non-constant single-variable polynomial with complex coefficients has at least one:" },
                    { 477, "A", 18, "0", "1", "Greater than 1", "Between 0 and 1", "What is the eccentricity of a circle in conic sections?" },
                    { 478, "B", 18, "nx^(n+1)", "n*x^(n-1)", "x^n / n", "(n-1)x^n", "The power rule for derivatives states that d/dx(x^n) =" },
                    { 479, "B", 18, "Intersection of A and B", "Union of A and B", "Complement of A", "Cartesian product of A and B", "In set theory, the set of all elements that are in A or in B (or in both) is called the:" },
                    { 480, "C", 18, "A function that is only injective (one-to-one)", "A function that is only surjective (onto)", "A function that is both injective and surjective", "A function that is neither injective nor surjective", "What does the term 'bijection' refer to in functions?" },
                    { 481, "C", 18, "Translation", "Rotation", "Reflection", "Dilation", "Which geometric transformation involves flipping a figure over a line?" },
                    { 482, "B", 18, "Permutations P(n,k)", "Combinations C(n,k)", "Factorial of n+k", "Arithmetic series sum", "The expression (n!) / (k!(n-k)!) is the formula for:" },
                    { 483, "B", 18, "Always false", "Always true", "Sometimes true, sometimes false", "Undefined", "A tautology in propositional logic is a statement that is:" },
                    { 484, "A", 18, "cos(x)", "-sin(x)", "-cos(x)", "tan(x)", "What is the derivative of sin(x)?" },
                    { 485, "B", 18, "It has no cycles", "Every vertex is connected to every other vertex", "It is a tree", "It is planar", "A graph is considered 'complete' if:" },
                    { 486, "B", 15, "Summing all values", "Subtracting the minimum value from the maximum value", "Finding the most frequent value", "Averaging all values", "The range of a dataset is calculated by:" },
                    { 487, "C", 15, "The null hypothesis being true", "The alternative hypothesis being true", "Observing the test statistic (or more extreme) if the null hypothesis is true", "Making a Type II error", "A p-value in hypothesis testing represents the probability of:" },
                    { 488, "D", 15, "Symmetric about the mean", "Bell-shaped curve", "Mean, median, and mode are equal", "Skewed to the right", "Which of these is NOT a characteristic of a normal distribution?" },
                    { 489, "B", 15, "P(A) * P(B)", "P(A) + P(B)", "P(A) + P(B) - P(A and B)", "0", "If events A and B are mutually exclusive, then P(A or B) is:" },
                    { 490, "B", 15, "Perfect positive linear relationship", "Perfect negative linear relationship", "No linear relationship", "Weak positive linear relationship", "What does a correlation coefficient of -1 indicate?" },
                    { 501, "A", 35, "Joule/second (J/s)", "Newton-meter (N·m)", "Kilogram-meter/second (kg·m/s)", "Coulomb/second (C/s)", "The unit of power is the Watt (W), which is equivalent to:" },
                    { 502, "C", 35, "Newton's First Law", "Newton's Second Law", "Newton's Third Law", "Law of Conservation of Momentum", "Which law states that for every action, there is an equal and opposite reaction?" },
                    { 503, "B", 35, "Product", "Sum", "Reciprocal of the sum of reciprocals", "Average", "In a series circuit, the total resistance is the ___ of individual resistances." },
                    { 504, "B", 35, "Wave", "Particle (photon)", "Continuous", "Magnetic", "The photoelectric effect demonstrates the ___ nature of light." },
                    { 505, "C", 35, "Volt (V)", "Ampere (A)", "Tesla (T)", "Weber (Wb)", "What is the SI unit of magnetic field strength?" },
                    { 506, "C", 35, "They reflect off each other", "They cancel each other out completely", "Their displacements add algebraically", "Their frequencies double", "The principle of superposition in waves states that when two waves meet:" },
                    { 507, "A", 35, "Heat added minus work done by the system", "Work done by the system minus heat added", "Heat added plus work done on the system", "Always zero", "According to the First Law of Thermodynamics, the change in internal energy of a system is equal to:" },
                    { 508, "C", 35, "Velocity", "Acceleration", "Total momentum", "Force", "Which quantity remains constant in an isolated system according to the law of conservation of momentum?" },
                    { 509, "B", 35, "Real and inverted", "Virtual and upright", "Real and upright", "Virtual and inverted", "A concave lens always produces images that are:" },
                    { 510, "B", 35, "Temperature", "Cross-sectional area", "Voltage", "Current", "The resistance of a wire is directly proportional to its length and inversely proportional to its:" },
                    { 511, "B", 35, "Alpha decay", "Beta-minus decay", "Gamma decay", "Positron emission (Beta-plus decay)", "Which type of nuclear decay involves the emission of an electron?" },
                    { 512, "B", 35, "f = vλ", "f = v/λ", "f = λ/v", "f = v + λ", "The frequency of a wave is related to its wavelength (λ) and speed (v) by the equation:" },
                    { 513, "C", 35, "Tangent to the circle", "Away from the center", "Towards the center of the circle", "In the direction of velocity", "In a uniform circular motion, the acceleration vector is always directed:" },
                    { 514, "B", 35, "Relative to the observer", "Constant for all observers", "Dependent on the source's speed", "Variable", "Special Relativity postulates that the laws of physics are the same in all inertial frames and that the speed of light in a vacuum is:" },
                    { 515, "B", 35, "First Law of Thermodynamics", "Second Law of Thermodynamics", "Zeroth Law of Thermodynamics", "Third Law of Thermodynamics", "The tendency of a system to move towards a state of greater disorder is described by the:" },
                    { 516, "B", 53, "Glucose", "ATP (Adenosine Triphosphate)", "DNA", "RNA", "What is the primary molecule used by cells for energy currency?" },
                    { 517, "B", 53, "Meiosis", "Mitosis", "Fertilization", "Binary Fission", "The process where a cell divides to produce two genetically identical daughter cells is:" },
                    { 518, "B", 53, "Cellulose", "Phospholipids", "Starch", "Amino acids", "Which of these is a key component of the cell membrane, forming a bilayer?" },
                    { 519, "C", 53, "Nucleus", "Mitochondrion", "Ribosome", "Golgi apparatus", "The site of protein synthesis in a eukaryotic cell is the:" },
                    { 520, "C", 53, "Plantae", "Animalia", "Fungi", "Protista", "Which kingdom do mushrooms and yeasts belong to?" },
                    { 521, "B", 53, "Genotype", "Phenotype", "Allele", "Genome", "The observable characteristics of an organism, resulting from its genotype and environment, are its:" },
                    { 522, "A", 53, "To absorb light energy", "To produce glucose", "To release oxygen", "To transport water", "What is the primary role of chlorophyll in photosynthesis?" },
                    { 523, "C", 53, "Community", "Ecosystem", "Population", "Biome", "A group of individuals of the same species living in the same area is called a:" },
                    { 524, "C", 53, "Respiratory System", "Digestive System", "Circulatory System", "Nervous System", "Which human body system is primarily responsible for transporting oxygen, nutrients, and waste?" },
                    { 525, "C", 53, "Transcription", "Translation", "Replication", "Mutation", "The process by which DNA makes a copy of itself is called:" },
                    { 526, "D", 53, "Lipids", "Carbohydrates", "Nucleic Acids", "Proteins", "What are enzymes primarily composed of?" },
                    { 527, "C", 53, "Parasitism", "Commensalism", "Mutualism", "Predation", "The interaction between two different species where both benefit is called:" },
                    { 528, "C", 53, "Presence of a nucleus", "Membrane-bound organelles", "Circular DNA not enclosed in a nucleus", "Multiple linear chromosomes", "Which of the following is a characteristic of prokaryotic cells but not eukaryotic cells?" },
                    { 529, "B", 53, "Reproduce rapidly", "Maintain a stable internal environment", "Evolve over time", "Respond to external stimuli", "Homeostasis refers to the ability of an organism to:" },
                    { 530, "C", 53, "Herbivores", "Carnivores", "Producers (e.g., plants)", "Decomposers", "The first trophic level in an ecosystem is typically occupied by:" },
                    { 531, "B", 70, "Mass number", "Atomic number", "Isotope", "Ion charge", "The number of protons in an atom's nucleus defines its:" },
                    { 532, "C", 70, "Oxygen (O)", "Nitrogen (N)", "Helium (He)", "Hydrogen (H)", "Which of the following is an example of a noble gas?" },
                    { 533, "A", 70, "Strongly acidic", "Weakly acidic", "Neutral", "Weakly basic", "A solution with a pH of 3 is considered:" },
                    { 534, "B", 70, "Reduction", "Oxidation", "Neutralization", "Hydration", "What type of reaction involves the loss of electrons by a chemical species?" },
                    { 535, "C", 70, "Gram", "Liter", "Mole", "Milliliter", "Avogadro's number (approximately 6.022 x 10^23) represents the number of entities in one:" },
                    { 536, "D", 70, "Poor conductor of electricity", "Brittle solid", "Forms anions readily", "Good conductor of heat and electricity", "Which of these is a characteristic property of metals?" },
                    { 537, "B", 70, "Energy is conserved", "Mass is conserved", "Volume is conserved", "Moles are conserved", "The law of conservation of mass states that in a chemical reaction:" },
                    { 538, "B", 70, "Inorganic Chemistry", "Organic Chemistry", "Physical Chemistry", "Analytical Chemistry", "Which branch of chemistry deals primarily with carbon-containing compounds?" },
                    { 539, "B", 70, "Increasing the activation energy", "Decreasing the activation energy", "Increasing the temperature", "Shifting the equilibrium", "A catalyst increases the rate of a chemical reaction by:" },
                    { 540, "B", 70, "CnH2n", "CnH2n+2", "CnH2n-2", "CnHn", "What is the general formula for alkanes?" },
                    { 541, "C", 70, "Melting", "Evaporation", "Sublimation", "Condensation", "The process by which a solid changes directly to a gas without passing through the liquid phase is called:" },
                    { 542, "C", 70, "Sodium (Na)", "Calcium (Ca)", "Chlorine (Cl)", "Sulfur (S)", "Which of the following elements is a halogen?" },
                    { 543, "B", 70, "The actual number of atoms of each element", "The simplest whole-number ratio of atoms", "The structural arrangement of atoms", "The molecular weight of the compound", "The empirical formula of a compound represents:" },
                    { 544, "C", 70, "Ethane", "Propane", "Methane", "Butane", "What is the main component of natural gas?" },
                    { 545, "B", 70, "Absorbed by the system", "Released by the system", "Neither absorbed nor released", "Converted to work", "In an exothermic reaction, heat is:" },
                    { 546, "C", 88, "Second-person", "Third-person limited", "First-person", "Third-person omniscient", "A story told from the 'I' perspective is using which point of view?" },
                    { 547, "B", 88, "Metaphor", "Simile", "Personification", "Hyperbole", "The use of 'like' or 'as' to compare two unlike things is a:" },
                    { 548, "B", 88, "Period (.)", "Comma (,)", "Semicolon (;)", "Question Mark (?)", "Which punctuation mark is used to indicate a pause or to separate items in a series?" },
                    { 549, "C", 88, "Plot", "Setting", "Theme", "Conflict", "The underlying meaning or message the author conveys in a literary work is the:" },
                    { 550, "C", 88, "Protagonist", "Narrator", "Antagonist", "Foil", "A character who opposes the main character is the:" },
                    { 551, "C", 88, "Adverb", "Verb", "Adjective", "Preposition", "What part of speech describes a noun or pronoun (e.g., 'beautiful' flower)?" },
                    { 552, "B", 88, "Diction", "Syntax", "Tone", "Imagery", "The structure of a sentence, including the arrangement of words and phrases, is known as:" },
                    { 553, "C", 88, "Realism", "Historical Fiction", "Epic", "Satire", "Which literary genre typically features a hero on a quest, often involving supernatural elements?" },
                    { 554, "B", 88, "Mood", "Tone", "Theme", "Plot", "A writer's attitude toward the subject or audience, conveyed through word choice and style, is the:" },
                    { 555, "C", 88, "Topic sentence", "Supporting detail", "Thesis statement", "Conclusion", "In essay writing, the sentence that states the main argument or purpose of the essay is the:" },
                    { 556, "C", 88, "Simile", "Metaphor", "Personification", "Allusion", "Giving human qualities to an inanimate object or animal is called:" },
                    { 557, "B", 88, "Allegory", "Anecdote", "Analogy", "Aphorism", "A short, amusing or interesting story about a real incident or person is an:" },
                    { 558, "B", 88, "Biography", "Autobiography", "Memoir", "Journal", "Which of the following is a type of non-fiction that tells the story of a person's life, written by that person?" },
                    { 559, "B", 88, "Tone", "Mood", "Style", "Voice", "The feeling or atmosphere that a writer creates for the reader is the:" },
                    { 560, "C", 88, "Pathos", "Logos", "Satire", "Foreshadowing", "The literary technique of using humor, irony, exaggeration, or ridicule to expose and criticize people's stupidity or vices is:" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 175);

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
        }
    }
}
