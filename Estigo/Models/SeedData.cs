using Estigo.Enums;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Estigo.Models
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            var approvedStatus = CourseStatus.CourseStatusEnum.Approved;


            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Mathematics" },
                new Category { Id = 2, Name = "Physics" },
                new Category { Id = 3, Name = "Biology" },
                new Category { Id = 4, Name = "Chemistry" },
                new Category { Id = 5, Name = "English" });

            var seedDate = new DateTime(2024, 3, 29);



            modelBuilder.Entity<Course>().HasData(
    // Mathematics Courses (CategoryId = 1)
    new Course { courseId = 1, CourseTitle = "Algebra | Unit 1", Description = "Introduction to algebraic concepts", Price = 199, Available = true, CategoryId = 1, TeacherId = "f3000e69-e194-41ec-acb3-4a3d41253987", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/u1.jpg", Status = approvedStatus },
    new Course { courseId = 2, CourseTitle = "Calculus | Unit 2", Description = "Fundamentals of differential calculus", Price = 199, Available = true, CategoryId = 1, TeacherId = "f3000e69-e194-41ec-acb3-4a3d41253987", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/u2.jpg", Status = approvedStatus },
    new Course { courseId = 3, CourseTitle = "Geometry | Unit 3", Description = "Basics of geometric shapes and theorems", Price = 189, Available = true, CategoryId = 1, TeacherId = "f3000e69-e194-41ec-acb3-4a3d41253987", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/u3.jpg", Status = approvedStatus },
    new Course { courseId = 4, CourseTitle = "Trigonometry | Unit 4", Description = "Understanding angles and trigonometric functions", Price = 189, Available = true, CategoryId = 1, TeacherId = "f3000e69-e194-41ec-acb3-4a3d41253987", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/u4.jpg", Status = approvedStatus },
    new Course { courseId = 5, CourseTitle = "Statistics | Unit 5", Description = "Introduction to data analysis and probability", Price = 179, Available = true, CategoryId = 1, TeacherId = "f3000e69-e194-41ec-acb3-4a3d41253987", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/u5.jpg", Status = approvedStatus },
    new Course { courseId = 6, CourseTitle = "Probability | Unit 6", Description = "Exploring probability theories and applications", Price = 179, Available = true, CategoryId = 1, TeacherId = "f3000e69-e194-41ec-acb3-4a3d41253987", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/u6.jpg", Status = approvedStatus },
    new Course { courseId = 7, CourseTitle = "Discrete Math | Unit 7", Description = "Fundamentals of logic, set theory, and combinatorics", Price = 189, Available = true, CategoryId = 1, TeacherId = "f3000e69-e194-41ec-acb3-4a3d41253987", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/u7.jpg", Status = approvedStatus },

    // Physics Courses (CategoryId = 2)
    new Course { courseId = 8, CourseTitle = "Mechanics | Unit 1", Description = "Introduction to Newtonian mechanics", Price = 149, Available = true, CategoryId = 2, TeacherId = "22f718af-7a07-48a3-a501-a032466aeef2", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/f1.jpg", Status = approvedStatus },
    new Course { courseId = 9, CourseTitle = "Electricity | Unit 2", Description = "Basics of electric circuits and fields", Price = 149, Available = true, CategoryId = 2, TeacherId = "22f718af-7a07-48a3-a501-a032466aeef2", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/f2.jpg", Status = approvedStatus },
    new Course { courseId = 10, CourseTitle = "Magnetism | Unit 3", Description = "Principles of magnetic forces and fields", Price = 159, Available = true, CategoryId = 2, TeacherId = "22f718af-7a07-48a3-a501-a032466aeef2", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/f3.jpg", Status = approvedStatus },
    new Course { courseId = 11, CourseTitle = "Optics | Unit 4", Description = "Study of light behavior and properties", Price = 159, Available = true, CategoryId = 2, TeacherId = "22f718af-7a07-48a3-a501-a032466aeef2", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/f4.jpg", Status = approvedStatus },
    new Course { courseId = 12, CourseTitle = "Thermodynamics | Unit 5", Description = "Fundamentals of heat and energy", Price = 169, Available = true, CategoryId = 2, TeacherId = "22f718af-7a07-48a3-a501-a032466aeef2", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/f5.jpg", Status = approvedStatus },
    new Course { courseId = 13, CourseTitle = "Quantum Physics | Unit 6", Description = "Introduction to quantum theory", Price = 169, Available = true, CategoryId = 2, TeacherId = "22f718af-7a07-48a3-a501-a032466aeef2", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/f6.jpg", Status = approvedStatus },
    new Course { courseId = 14, CourseTitle = "Relativity | Unit 7", Description = "Concepts of special and general relativity", Price = 169, Available = true, CategoryId = 2, TeacherId = "22f718af-7a07-48a3-a501-a032466aeef2", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/f7.jpg", Status = approvedStatus },

    // Biology Courses (CategoryId = 3)
    new Course { courseId = 15, CourseTitle = "Cell Biology | Unit 1", Description = "Study of cell structure and function", Price = 179, Available = true, CategoryId = 3, TeacherId = "dbac4aa8-2cdb-4a66-9080-23ddf8fde838", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/uu1.jpg", Status = approvedStatus },
    new Course { courseId = 16, CourseTitle = "Genetics | Unit 2", Description = "Introduction to heredity and DNA", Price = 179, Available = true, CategoryId = 3, TeacherId = "dbac4aa8-2cdb-4a66-9080-23ddf8fde838", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/uu2.jpg", Status = approvedStatus },
    new Course { courseId = 17, CourseTitle = "Movement | Unit 3", Description = "Principles of Movement", Price = 189, Available = true, CategoryId = 3, TeacherId = "dbac4aa8-2cdb-4a66-9080-23ddf8fde838", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/uu3.jpg", Status = approvedStatus },
    new Course { courseId = 18, CourseTitle = "Ecology | Unit 4", Description = "Basics of ecosystems and environment", Price = 189, Available = true, CategoryId = 3, TeacherId = "dbac4aa8-2cdb-4a66-9080-23ddf8fde838", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/uu4.jpg", Status = approvedStatus },
    new Course { courseId = 19, CourseTitle = "Botany | Unit 5", Description = "Study of plant biology and physiology", Price = 179, Available = true, CategoryId = 3, TeacherId = "dbac4aa8-2cdb-4a66-9080-23ddf8fde838", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/uu5.jpg", Status = approvedStatus }, // Note: Logo same as Electricity? Might be a typo in original.
    new Course { courseId = 20, CourseTitle = "Zoology | Unit 6", Description = "Introduction to animal biology", Price = 179, Available = true, CategoryId = 3, TeacherId = "dbac4aa8-2cdb-4a66-9080-23ddf8fde838", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/uu6.jpg", Status = approvedStatus },
    new Course { courseId = 21, CourseTitle = "Microbiology | Unit 7", Description = "Basics of microorganisms and their roles", Price = 189, Available = true, CategoryId = 3, TeacherId = "dbac4aa8-2cdb-4a66-9080-23ddf8fde838", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/uu7.jpg", Status = approvedStatus },

    // Chemistry Courses (CategoryId = 4)
    new Course { courseId = 22, CourseTitle = "Organic Chemistry | Unit 1", Description = "Introduction to organic compounds", Price = 159, Available = true, CategoryId = 4, TeacherId = "bb3a1427-d95f-4cbe-9a12-1841e6c3ead9", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/y1.jpg", Status = approvedStatus },
    new Course { courseId = 23, CourseTitle = "Inorganic Chemistry | Unit 2", Description = "Fundamentals of inorganic substances", Price = 159, Available = true, CategoryId = 4, TeacherId = "bb3a1427-d95f-4cbe-9a12-1841e6c3ead9", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/y2.jpg", Status = approvedStatus },
    new Course { courseId = 24, CourseTitle = "Physical Chemistry | Unit 3", Description = "Study of chemical thermodynamics and kinetics", Price = 169, Available = true, CategoryId = 4, TeacherId = "bb3a1427-d95f-4cbe-9a12-1841e6c3ead9", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/y3.jpg", Status = approvedStatus },
    new Course { courseId = 25, CourseTitle = "Analytical Chemistry | Unit 4", Description = "Techniques for chemical analysis", Price = 169, Available = true, CategoryId = 4, TeacherId = "bb3a1427-d95f-4cbe-9a12-1841e6c3ead9", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/y4.jpg", Status = approvedStatus },
    new Course { courseId = 26, CourseTitle = "Biochemistry | Unit 5", Description = "Chemical processes within living organisms", Price = 179, Available = true, CategoryId = 4, TeacherId = "bb3a1427-d95f-4cbe-9a12-1841e6c3ead9", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/y5.jpg", Status = approvedStatus },
    new Course { courseId = 27, CourseTitle = "Environmental Chemistry | Unit 6", Description = "Chemistry in environmental processes", Price = 179, Available = true, CategoryId = 4, TeacherId = "bb3a1427-d95f-4cbe-9a12-1841e6c3ead9", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/y6.jpg", Status = approvedStatus },
    new Course { courseId = 28, CourseTitle = "Theoretical Chemistry | Unit 7", Description = "Conceptual frameworks of chemical behavior", Price = 169, Available = true, CategoryId = 4, TeacherId = "bb3a1427-d95f-4cbe-9a12-1841e6c3ead9", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/y7.jpg", Status = approvedStatus },

    // English Courses (CategoryId = 5)
    new Course { courseId = 29, CourseTitle = "Literature | Unit 1", Description = "Exploring classic and modern literature", Price = 129, Available = true, CategoryId = 5, TeacherId = "290f0fe9-c8cb-4a6e-b863-b61df939f025", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/m1.jpg", Status = approvedStatus },
    new Course { courseId = 30, CourseTitle = "Creative Writing | Unit 2", Description = "Develop storytelling and narrative skills", Price = 129, Available = true, CategoryId = 5, TeacherId = "290f0fe9-c8cb-4a6e-b863-b61df939f025", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/m2.jpg", Status = approvedStatus },
    new Course { courseId = 31, CourseTitle = "Grammar & Composition | Unit 3", Description = "Mastering the rules of English grammar", Price = 119, Available = true, CategoryId = 5, TeacherId = "290f0fe9-c8cb-4a6e-b863-b61df939f025", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/m3.jpg", Status = approvedStatus },
    new Course { courseId = 32, CourseTitle = "Poetry Analysis | Unit 4", Description = "Study and analysis of poetry", Price = 119, Available = true, CategoryId = 5, TeacherId = "290f0fe9-c8cb-4a6e-b863-b61df939f025", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/m4.jpg", Status = approvedStatus },
    new Course { courseId = 33, CourseTitle = "Drama & Theater | Unit 5", Description = "Introduction to dramatic literature and performance", Price = 129, Available = true, CategoryId = 5, TeacherId = "290f0fe9-c8cb-4a6e-b863-b61df939f025", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/m5.jpg", Status = approvedStatus },
    new Course { courseId = 34, CourseTitle = "Fiction Writing | Unit 6", Description = "Techniques for writing compelling fiction", Price = 129, Available = true, CategoryId = 5, TeacherId = "290f0fe9-c8cb-4a6e-b863-b61df939f025", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/m6.jpg", Status = approvedStatus },
    new Course { courseId = 35, CourseTitle = "Non-fiction Writing | Unit 7", Description = "Crafting engaging non-fiction narratives", Price = 119, Available = true, CategoryId = 5, TeacherId = "290f0fe9-c8cb-4a6e-b863-b61df939f025", CreatedAt = seedDate, Logo = "https://estigo.runasp.net/m7.jpg", Status = approvedStatus }
);


            // Seed Lessons - 5 lessons per course with camelCase properties
            modelBuilder.Entity<lesson>().HasData(
                // --- Lessons for Course 1: Algebra | Unit 1 ---
                new lesson { lessonId = 1, lessonTitle = "Algebra Basics", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 1 },
                new lesson { lessonId = 2, lessonTitle = "Solving Linear Equations", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 1 },
                new lesson { lessonId = 3, lessonTitle = "Inequalities", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 1 },
                new lesson { lessonId = 4, lessonTitle = "Functions Introduction", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 1 },
                new lesson { lessonId = 5, lessonTitle = "Polynomial Basics", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 1 },

                // --- Lessons for Course 2: Calculus | Unit 2 ---
                new lesson { lessonId = 6, lessonTitle = "Limits and Continuity", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 2 },
                new lesson { lessonId = 7, lessonTitle = "Introduction to Derivatives", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 2 },
                new lesson { lessonId = 8, lessonTitle = "Differentiation Techniques", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 2 },
                new lesson { lessonId = 9, lessonTitle = "Applications of Derivatives", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 2 },
                new lesson { lessonId = 10, lessonTitle = "Introduction to Integrals", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 2 },

                // --- Lessons for Course 3: Geometry | Unit 3 ---
                new lesson { lessonId = 11, lessonTitle = "Points, Lines, and Planes", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 3 },
                new lesson { lessonId = 12, lessonTitle = "Angles and Angle Relationships", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 3 },
                new lesson { lessonId = 13, lessonTitle = "Parallel Lines and Transversals", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 3 },
                new lesson { lessonId = 14, lessonTitle = "Triangles and Congruence", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 3 },
                new lesson { lessonId = 15, lessonTitle = "Introduction to Polygons", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 3 },

                // --- Lessons for Course 4: Trigonometry | Unit 4 ---
                new lesson { lessonId = 16, lessonTitle = "Right Triangle Trigonometry", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 4 },
                new lesson { lessonId = 17, lessonTitle = "The Unit Circle", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 4 },
                new lesson { lessonId = 18, lessonTitle = "Trigonometric Graphs", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 4 },
                new lesson { lessonId = 19, lessonTitle = "Trigonometric Identities", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 4 },
                new lesson { lessonId = 20, lessonTitle = "Solving Trigonometric Equations", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 4 },

                // --- Lessons for Course 5: Statistics | Unit 5 ---
                new lesson { lessonId = 21, lessonTitle = "Introduction to Statistics", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 5 },
                new lesson { lessonId = 22, lessonTitle = "Descriptive Statistics", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 5 },
                new lesson { lessonId = 23, lessonTitle = "Data Visualization", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 5 },
                new lesson { lessonId = 24, lessonTitle = "Basic Probability Concepts", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 5 },
                new lesson { lessonId = 25, lessonTitle = "Introduction to Distributions", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 5 },

                // --- Lessons for Course 6: Probability | Unit 6 ---
                new lesson { lessonId = 26, lessonTitle = "Foundations of Probability", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 6 },
                new lesson { lessonId = 27, lessonTitle = "Conditional Probability and Independence", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 6 },
                new lesson { lessonId = 28, lessonTitle = "Random Variables", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 6 },
                new lesson { lessonId = 29, lessonTitle = "Expected Value and Variance", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 6 },
                new lesson { lessonId = 30, lessonTitle = "Common Probability Distributions", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 6 },

                // --- Lessons for Course 7: Discrete Math | Unit 7 ---
                new lesson { lessonId = 31, lessonTitle = "Logic and Proofs", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 7 },
                new lesson { lessonId = 32, lessonTitle = "Set Theory", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 7 },
                new lesson { lessonId = 33, lessonTitle = "Counting Principles", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 7 },
                new lesson { lessonId = 34, lessonTitle = "Relations and Functions", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 7 },
                new lesson { lessonId = 35, lessonTitle = "Introduction to Graph Theory", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 7 },

                // --- Lessons for Course 8: Mechanics | Unit 1 ---
                new lesson { lessonId = 36, lessonTitle = "Kinematics in One Dimension", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 8 },
                new lesson { lessonId = 37, lessonTitle = "Vectors and 2D Kinematics", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 8 },
                new lesson { lessonId = 38, lessonTitle = "Newton's Laws of Motion", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 8 },
                new lesson { lessonId = 39, lessonTitle = "Work, Energy, and Power", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 8 },
                new lesson { lessonId = 40, lessonTitle = "Momentum and Collisions", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 8 },

                // --- Lessons for Course 9: Electricity | Unit 2 ---
                new lesson { lessonId = 41, lessonTitle = "Electric Charge and Coulomb's Law", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 9 },
                new lesson { lessonId = 42, lessonTitle = "Electric Fields", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 9 },
                new lesson { lessonId = 43, lessonTitle = "Electric Potential", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 9 },
                new lesson { lessonId = 44, lessonTitle = "Capacitance", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 9 },
                new lesson { lessonId = 45, lessonTitle = "Current, Resistance, and Ohm's Law", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 9 },

                // --- Lessons for Course 10: Magnetism | Unit 3 ---
                new lesson { lessonId = 46, lessonTitle = "Magnetic Fields and Forces", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 10 },
                new lesson { lessonId = 47, lessonTitle = "Sources of Magnetic Fields", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 10 },
                new lesson { lessonId = 48, lessonTitle = "Ampere's Law", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 10 },
                new lesson { lessonId = 49, lessonTitle = "Electromagnetic Induction", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 10 },
                new lesson { lessonId = 50, lessonTitle = "Inductance", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 10 },

                // --- Lessons for Course 11: Optics | Unit 4 ---
                new lesson { lessonId = 51, lessonTitle = "Nature of Light", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 11 },
                new lesson { lessonId = 52, lessonTitle = "Reflection and Refraction", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 11 },
                new lesson { lessonId = 53, lessonTitle = "Lenses and Image Formation", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 11 },
                new lesson { lessonId = 54, lessonTitle = "Wave Optics: Interference", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 11 },
                new lesson { lessonId = 55, lessonTitle = "Wave Optics: Diffraction", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 11 },

                // --- Lessons for Course 12: Thermodynamics | Unit 5 ---
                new lesson { lessonId = 56, lessonTitle = "Temperature and Heat", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 12 },
                new lesson { lessonId = 57, lessonTitle = "First Law of Thermodynamics", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 12 },
                new lesson { lessonId = 58, lessonTitle = "Ideal Gas Law", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 12 },
                new lesson { lessonId = 59, lessonTitle = "Second Law of Thermodynamics", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 12 },
                new lesson { lessonId = 60, lessonTitle = "Thermodynamic Cycles", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 12 },

                // --- Lessons for Course 13: Quantum Physics | Unit 6 ---
                new lesson { lessonId = 61, lessonTitle = "Blackbody Radiation & Planck's Hypothesis", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 13 },
                new lesson { lessonId = 62, lessonTitle = "Photoelectric Effect", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 13 },
                new lesson { lessonId = 63, lessonTitle = "Wave Nature of Matter", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 13 },
                new lesson { lessonId = 64, lessonTitle = "The Bohr Model", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 13 },
                new lesson { lessonId = 65, lessonTitle = "Introduction to Quantum Mechanics", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 13 },

                // --- Lessons for Course 14: Relativity | Unit 7 ---
                new lesson { lessonId = 66, lessonTitle = "Principles of Special Relativity", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 14 },
                new lesson { lessonId = 67, lessonTitle = "Time Dilation and Length Contraction", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 14 },
                new lesson { lessonId = 68, lessonTitle = "Relativistic Momentum and Energy", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 14 },
                new lesson { lessonId = 69, lessonTitle = "Introduction to General Relativity", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 14 },
                new lesson { lessonId = 70, lessonTitle = "Consequences of General Relativity", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 14 },

                // --- Lessons for Course 15: Cell Biology | Unit 1 ---
                new lesson { lessonId = 71, lessonTitle = "Introduction to Cells", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 15 },
                new lesson { lessonId = 72, lessonTitle = "Cell Membrane Structure and Function", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 15 },
                new lesson { lessonId = 73, lessonTitle = "Eukaryotic Organelles", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 15 },
                new lesson { lessonId = 74, lessonTitle = "Cellular Respiration", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 15 },
                new lesson { lessonId = 75, lessonTitle = "The Cell Cycle and Mitosis", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 15 },

                // --- Lessons for Course 16: Genetics | Unit 2 ---
                new lesson { lessonId = 76, lessonTitle = "Mendelian Genetics", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 16 },
                new lesson { lessonId = 77, lessonTitle = "DNA Structure and Replication", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 16 },
                new lesson { lessonId = 78, lessonTitle = "Gene Expression: Transcription", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 16 },
                new lesson { lessonId = 79, lessonTitle = "Gene Expression: Translation", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 16 },
                new lesson { lessonId = 80, lessonTitle = "Mutations and Genetic Variation", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 16 },

                // --- Lessons for Course 17: Movement | Unit 3 ---
                new lesson { lessonId = 81, lessonTitle = "Skeletal Systems", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 17 },
                new lesson { lessonId = 82, lessonTitle = "Muscular Systems", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 17 },
                new lesson { lessonId = 83, lessonTitle = "Biomechanics Basics", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 17 },
                new lesson { lessonId = 84, lessonTitle = "Locomotion in Animals", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 17 },
                new lesson { lessonId = 85, lessonTitle = "Nervous System Control of Movement", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 17 },

                // --- Lessons for Course 18: Ecology | Unit 4 ---
                new lesson { lessonId = 86, lessonTitle = "Introduction to Ecology", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 18 },
                new lesson { lessonId = 87, lessonTitle = "Population Ecology", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 18 },
                new lesson { lessonId = 88, lessonTitle = "Community Ecology", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 18 },
                new lesson { lessonId = 89, lessonTitle = "Ecosystem Dynamics", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 18 },
                new lesson { lessonId = 90, lessonTitle = "Biomes and Conservation", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 18 },

                // --- Lessons for Course 19: Botany | Unit 5 ---
                new lesson { lessonId = 91, lessonTitle = "Plant Structure and Growth", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 19 },
                new lesson { lessonId = 92, lessonTitle = "Plant Transport Systems", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 19 },
                new lesson { lessonId = 93, lessonTitle = "Photosynthesis", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 19 },
                new lesson { lessonId = 94, lessonTitle = "Plant Reproduction", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 19 },
                new lesson { lessonId = 95, lessonTitle = "Plant Hormones and Responses", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 19 },

                // --- Lessons for Course 20: Zoology | Unit 6 ---
                new lesson { lessonId = 96, lessonTitle = "Introduction to Animal Diversity", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 20 },
                new lesson { lessonId = 97, lessonTitle = "Invertebrate Zoology I", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 20 },
                new lesson { lessonId = 98, lessonTitle = "Invertebrate Zoology II", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 20 },
                new lesson { lessonId = 99, lessonTitle = "Vertebrate Zoology I", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 20 },
                new lesson { lessonId = 100, lessonTitle = "Vertebrate Zoology II", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 20 },

                // --- Lessons for Course 21: Microbiology | Unit 7 ---
                new lesson { lessonId = 101, lessonTitle = "Introduction to Microbes", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 21 },
                new lesson { lessonId = 102, lessonTitle = "Bacterial Structure and Function", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 21 },
                new lesson { lessonId = 103, lessonTitle = "Microbial Growth and Metabolism", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 21 },
                new lesson { lessonId = 104, lessonTitle = "Viruses and Prions", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 21 },
                new lesson { lessonId = 105, lessonTitle = "Microbial Roles and Applications", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 21 },

                // --- Lessons for Course 22: Organic Chemistry | Unit 1 ---
                new lesson { lessonId = 106, lessonTitle = "Introduction & Bonding", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 22 },
                new lesson { lessonId = 107, lessonTitle = "Alkanes and Cycloalkanes", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 22 },
                new lesson { lessonId = 108, lessonTitle = "Stereochemistry", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 22 },
                new lesson { lessonId = 109, lessonTitle = "Introduction to Organic Reactions", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 22 },
                new lesson { lessonId = 110, lessonTitle = "Alkenes and Alkynes: Structure & Reactivity", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 22 },

                // --- Lessons for Course 23: Inorganic Chemistry | Unit 2 ---
                new lesson { lessonId = 111, lessonTitle = "Atomic Structure and Periodicity", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 23 },
                new lesson { lessonId = 112, lessonTitle = "Chemical Bonding: Lewis & VSEPR", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 23 },
                new lesson { lessonId = 113, lessonTitle = "Valence Bond and Molecular Orbital Theory", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 23 },
                new lesson { lessonId = 114, lessonTitle = "Acid-Base Chemistry", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 23 },
                new lesson { lessonId = 115, lessonTitle = "Introduction to Coordination Chemistry", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 23 },

                // --- Lessons for Course 24: Physical Chemistry | Unit 3 ---
                new lesson { lessonId = 116, lessonTitle = "Gases and Kinetic Theory", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 24 },
                new lesson { lessonId = 117, lessonTitle = "Thermodynamics: First Law", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 24 },
                new lesson { lessonId = 118, lessonTitle = "Thermodynamics: Second & Third Laws", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 24 },
                new lesson { lessonId = 119, lessonTitle = "Chemical Kinetics", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 24 },
                new lesson { lessonId = 120, lessonTitle = "Introduction to Quantum Chemistry", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 24 },

                // --- Lessons for Course 25: Analytical Chemistry | Unit 4 ---
                new lesson { lessonId = 121, lessonTitle = "Introduction & Statistics", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 25 },
                new lesson { lessonId = 122, lessonTitle = "Gravimetric and Volumetric Analysis", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 25 },
                new lesson { lessonId = 123, lessonTitle = "Spectroscopic Methods", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 25 },
                new lesson { lessonId = 124, lessonTitle = "Chromatography Basics", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 25 },
                new lesson { lessonId = 125, lessonTitle = "Electroanalytical Methods", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 25 },

                // --- Lessons for Course 26: Biochemistry | Unit 5 ---
                new lesson { lessonId = 126, lessonTitle = "Amino Acids and Proteins", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 26 },
                new lesson { lessonId = 127, lessonTitle = "Enzymes and Enzyme Kinetics", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 26 },
                new lesson { lessonId = 128, lessonTitle = "Carbohydrates", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 26 },
                new lesson { lessonId = 129, lessonTitle = "Lipids and Membranes", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 26 },
                new lesson { lessonId = 130, lessonTitle = "Metabolic Pathways Overview", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 26 },

                // --- Lessons for Course 27: Environmental Chemistry | Unit 6 ---
                new lesson { lessonId = 131, lessonTitle = "Atmospheric Chemistry", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 27 },
                new lesson { lessonId = 132, lessonTitle = "Aquatic Chemistry", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 27 },
                new lesson { lessonId = 133, lessonTitle = "Soil Chemistry", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 27 },
                new lesson { lessonId = 134, lessonTitle = "Toxicology and Risk Assessment", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 27 },
                new lesson { lessonId = 135, lessonTitle = "Green Chemistry", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 27 },

                // --- Lessons for Course 28: Theoretical Chemistry | Unit 7 ---
                new lesson { lessonId = 136, lessonTitle = "Quantum Mechanics Fundamentals", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 28 },
                new lesson { lessonId = 137, lessonTitle = "Approximation Methods", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 28 },
                new lesson { lessonId = 138, lessonTitle = "Molecular Symmetry and Group Theory", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 28 },
                new lesson { lessonId = 139, lessonTitle = "Computational Chemistry Methods", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 28 },
                new lesson { lessonId = 140, lessonTitle = "Statistical Thermodynamics", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 28 },

                // --- Lessons for Course 29: Literature | Unit 1 ---
                new lesson { lessonId = 141, lessonTitle = "Introduction to Literary Analysis", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 29 },
                new lesson { lessonId = 142, lessonTitle = "Short Story Analysis", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 29 },
                new lesson { lessonId = 143, lessonTitle = "Poetry Fundamentals", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 29 },
                new lesson { lessonId = 144, lessonTitle = "Novel Study: Introduction", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 29 },
                new lesson { lessonId = 145, lessonTitle = "Introduction to Drama", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 29 },

                // --- Lessons for Course 30: Creative Writing | Unit 2 ---
                new lesson { lessonId = 146, lessonTitle = "Finding Your Voice", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 30 },
                new lesson { lessonId = 147, lessonTitle = "Character Development", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 30 },
                new lesson { lessonId = 148, lessonTitle = "Plotting and Structure", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 30 },
                new lesson { lessonId = 149, lessonTitle = "Setting and Description", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 30 },
                new lesson { lessonId = 150, lessonTitle = "Dialogue Writing", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 30 },

                // --- Lessons for Course 31: Grammar & Composition | Unit 3 ---
                new lesson { lessonId = 151, lessonTitle = "Parts of Speech Review", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 31 },
                new lesson { lessonId = 152, lessonTitle = "Sentence Structure", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 31 },
                new lesson { lessonId = 153, lessonTitle = "Punctuation Rules", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 31 },
                new lesson { lessonId = 154, lessonTitle = "Common Grammatical Errors", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 31 },
                new lesson { lessonId = 155, lessonTitle = "Paragraph and Essay Structure", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 31 },

                // --- Lessons for Course 32: Poetry Analysis | Unit 4 ---
                new lesson { lessonId = 156, lessonTitle = "Elements of Poetry", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 32 },
                new lesson { lessonId = 157, lessonTitle = "Figurative Language", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 32 },
                new lesson { lessonId = 158, lessonTitle = "Sound Devices", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 32 },
                new lesson { lessonId = 159, lessonTitle = "Poetic Forms", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 32 },
                new lesson { lessonId = 160, lessonTitle = "Interpreting Poems", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 32 },

                // --- Lessons for Course 33: Drama & Theater | Unit 5 ---
                new lesson { lessonId = 161, lessonTitle = "History of Theater", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 33 },
                new lesson { lessonId = 162, lessonTitle = "Elements of Drama", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 33 },
                new lesson { lessonId = 163, lessonTitle = "Reading a Play", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 33 },
                new lesson { lessonId = 164, lessonTitle = "Major Dramatic Genres", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 33 },
                new lesson { lessonId = 165, lessonTitle = "Theater Production Basics", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 33 },

                // --- Lessons for Course 34: Fiction Writing | Unit 6 ---
                new lesson { lessonId = 166, lessonTitle = "Generating Ideas", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 34 },
                new lesson { lessonId = 167, lessonTitle = "Point of View and Narrative Voice", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 34 },
                new lesson { lessonId = 168, lessonTitle = "Show, Don't Tell", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 34 },
                new lesson { lessonId = 169, lessonTitle = "Crafting Scenes", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 34 },
                new lesson { lessonId = 170, lessonTitle = "Revision Strategies", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 34 },

                // --- Lessons for Course 35: Non-fiction Writing | Unit 7 ---
                new lesson { lessonId = 171, lessonTitle = "Types of Non-fiction", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 35 },
                new lesson { lessonId = 172, lessonTitle = "Research Techniques", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 35 },
                new lesson { lessonId = 173, lessonTitle = "Structuring Non-fiction", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 35 },
                new lesson { lessonId = 174, lessonTitle = "Writing with Clarity and Style", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 35 },
                new lesson { lessonId = 175, lessonTitle = "Ethics in Non-fiction", lessonVideo = "https://estigo.runasp.net/vv.mp4", courseId = 35 }
                );

            // Ensure the seedDate variable is accessible here
            // var seedDate = new DateTime(2023, 1, 1); // Or your actual seed date variable

            // Seed Exams
            modelBuilder.Entity<Exam>().HasData(
                // Category 1: Core Mathematics (Courses 1, 2, 3, 4, 7) - Ends with Lesson 35 (ExamId 18)
                // Exam for Lesson 1 (Course 1)
                new Exam { Id = 1, ExamTitle = "Algebra Basics Exam", ExamDescription = "Test your knowledge of variables and expressions.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 1, final = false },
                // Exam for Lesson 3 (Course 1)
                new Exam { Id = 2, ExamTitle = "Inequalities Exam", ExamDescription = "Test your understanding and solving of linear inequalities.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 3, final = false },
                // Exam for Lesson 5 (Course 1)
                new Exam { Id = 3, ExamTitle = "Polynomial Basics Exam", ExamDescription = "Test your knowledge of polynomial expressions and operations.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 5, final = false },
                // Exam for Lesson 7 (Course 2)
                new Exam { Id = 4, ExamTitle = "Introduction to Derivatives Exam", ExamDescription = "Test your knowledge of defining the derivative and basic rules.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 7, final = false },
                // Exam for Lesson 9 (Course 2)
                new Exam { Id = 5, ExamTitle = "Applications of Derivatives Exam", ExamDescription = "Test your ability to use derivatives for rates of change and optimization.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 9, final = false },
                // Exam for Lesson 11 (Course 3)
                new Exam { Id = 6, ExamTitle = "Points, Lines, and Planes Exam", ExamDescription = "Test your knowledge of fundamental geometric concepts.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 11, final = false },
                // Exam for Lesson 13 (Course 3)
                new Exam { Id = 7, ExamTitle = "Parallel Lines and Transversals Exam", ExamDescription = "Test your knowledge of angles formed by parallel lines.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 13, final = false },
                // Exam for Lesson 15 (Course 3)
                new Exam { Id = 8, ExamTitle = "Introduction to Polygons Exam", ExamDescription = "Test your knowledge of polygon properties.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 15, final = false },
                // Exam for Lesson 17 (Course 4)
                new Exam { Id = 9, ExamTitle = "The Unit Circle Exam", ExamDescription = "Test your understanding of the unit circle in trigonometry.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 17, final = false },
                // Exam for Lesson 19 (Course 4)
                new Exam { Id = 10, ExamTitle = "Trigonometric Identities Exam", ExamDescription = "Test your knowledge of fundamental trigonometric identities.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 19, final = false },
                // Exam for Lesson 31 (Course 7)
                new Exam { Id = 16, ExamTitle = "Logic and Proofs Exam", ExamDescription = "Test your knowledge of propositional logic and proof methods.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 31, final = false },
                // Exam for Lesson 33 (Course 7)
                new Exam { Id = 17, ExamTitle = "Counting Principles Exam", ExamDescription = "Test your knowledge of permutations and combinations.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 33, final = false },
                // Exam for Lesson 35 (Course 7) - FINAL EXAM FOR CORE MATHEMATICS CATEGORY
                new Exam { Id = 18, ExamTitle = "Core Mathematics Comprehensive Exam", ExamDescription = "Comprehensive test of core mathematical concepts including algebra, calculus, geometry, trigonometry, and discrete math.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 35, final = true },

                // Category 2: Statistics and Probability (Courses 5, 6) - Ends with Lesson 29 (ExamId 15)
                // Exam for Lesson 21 (Course 5)
                new Exam { Id = 11, ExamTitle = "Introduction to Statistics Exam", ExamDescription = "Test your knowledge of basic statistical concepts and data types.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 21, final = false },
                // Exam for Lesson 23 (Course 5)
                new Exam { Id = 12, ExamTitle = "Data Visualization Exam", ExamDescription = "Test your understanding of graphical data representation.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 23, final = false },
                // Exam for Lesson 25 (Course 5)
                new Exam { Id = 13, ExamTitle = "Introduction to Distributions Exam", ExamDescription = "Test your understanding of basic probability distributions.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 25, final = false },
                // Exam for Lesson 27 (Course 6)
                new Exam { Id = 14, ExamTitle = "Conditional Probability Exam", ExamDescription = "Test your understanding of conditional probability and independence.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 27, final = false },
                // Exam for Lesson 29 (Course 6) - FINAL EXAM FOR STATISTICS & PROBABILITY CATEGORY
                new Exam { Id = 15, ExamTitle = "Statistics & Probability Comprehensive Exam", ExamDescription = "Comprehensive test of statistical concepts, data visualization, probability distributions, conditional probability, and expected value.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 29, final = false },

                // Category 3: Physics (Courses 8, 9, 10, 11, 12, 13, 14) - Ends with Lesson 69 (ExamId 35)
                // Exam for Lesson 37 (Course 8)
                new Exam { Id = 19, ExamTitle = "Vectors and 2D Kinematics Exam", ExamDescription = "Test your knowledge of projectile motion and vector operations.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 37, final = false },
                // Exam for Lesson 39 (Course 8)
                new Exam { Id = 20, ExamTitle = "Work, Energy, and Power Exam", ExamDescription = "Test your understanding of work, energy concepts, and conservation.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 39, final = false },
                // Exam for Lesson 41 (Course 9)
                new Exam { Id = 21, ExamTitle = "Electric Charge and Coulomb's Law Exam", ExamDescription = "Test your knowledge of electric charge properties and Coulomb's Law.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 41, final = false },
                // Exam for Lesson 43 (Course 9)
                new Exam { Id = 22, ExamTitle = "Electric Potential Exam", ExamDescription = "Test your understanding of potential difference and electric potential energy.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 43, final = false },
                // Exam for Lesson 45 (Course 9)
                new Exam { Id = 23, ExamTitle = "Current, Resistance, and Ohm's Law Exam", ExamDescription = "Test your knowledge of basic electric current, resistance, and Ohm's Law.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 45, final = false },
                // Exam for Lesson 47 (Course 10)
                new Exam { Id = 24, ExamTitle = "Sources of Magnetic Fields Exam", ExamDescription = "Test your knowledge of magnetic fields produced by currents.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 47, final = false },
                // Exam for Lesson 49 (Course 10)
                new Exam { Id = 25, ExamTitle = "Electromagnetic Induction Exam", ExamDescription = "Test your understanding of Faraday's Law and Lenz's Law.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 49, final = false },
                // Exam for Lesson 51 (Course 11)
                new Exam { Id = 26, ExamTitle = "Nature of Light Exam", ExamDescription = "Test your knowledge of the wave-particle duality and properties of light.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 51, final = false },
                // Exam for Lesson 53 (Course 11)
                new Exam { Id = 27, ExamTitle = "Lenses and Image Formation Exam", ExamDescription = "Test your understanding of lenses and image formation.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 53, final = false },
                // Exam for Lesson 55 (Course 11)
                new Exam { Id = 28, ExamTitle = "Wave Optics: Diffraction Exam", ExamDescription = "Test your knowledge of light diffraction.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 55, final = false },
                // Exam for Lesson 57 (Course 12)
                new Exam { Id = 29, ExamTitle = "First Law of Thermodynamics Exam", ExamDescription = "Test your understanding of internal energy, work, and heat.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 57, final = false },
                // Exam for Lesson 59 (Course 12)
                new Exam { Id = 30, ExamTitle = "Second Law of Thermodynamics Exam", ExamDescription = "Test your knowledge of entropy and the direction of processes.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 59, final = false },
                // Exam for Lesson 61 (Course 13)
                new Exam { Id = 31, ExamTitle = "Blackbody Radiation Exam", ExamDescription = "Test your knowledge of blackbody radiation and Planck's hypothesis.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 61, final = false },
                // Exam for Lesson 63 (Course 13)
                new Exam { Id = 32, ExamTitle = "Wave Nature of Matter Exam", ExamDescription = "Test your understanding of the De Broglie hypothesis.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 63, final = false },
                // Exam for Lesson 65 (Course 13)
                new Exam { Id = 33, ExamTitle = "Introduction to Quantum Mechanics Exam", ExamDescription = "Test your basic understanding of the Schrödinger equation and wave functions.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 65, final = false },
                // Exam for Lesson 67 (Course 14)
                new Exam { Id = 34, ExamTitle = "Time Dilation and Length Contraction Exam", ExamDescription = "Test your knowledge of relativistic effects on time and space.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 67, final = false },
                // Exam for Lesson 69 (Course 14) - FINAL EXAM FOR PHYSICS CATEGORY
                new Exam { Id = 35, ExamTitle = "Physics Comprehensive Exam", ExamDescription = "Comprehensive test of classical mechanics, electricity, magnetism, optics, thermodynamics, and modern physics concepts.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 69, final = true },

                // Category 4: Biology (Courses 15, 16, 17, 18, 19, 20, 21) - Ends with Lesson 105 (ExamId 53)
                // Exam for Lesson 71 (Course 15)
                new Exam { Id = 36, ExamTitle = "Introduction to Cells Exam", ExamDescription = "Test your knowledge of Prokaryotic vs. Eukaryotic cells.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 71, final = false },
                // Exam for Lesson 73 (Course 15)
                new Exam { Id = 37, ExamTitle = "Eukaryotic Organelles Exam", ExamDescription = "Test your knowledge of major organelle structures and functions.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 73, final = false },
                // Exam for Lesson 75 (Course 15)
                new Exam { Id = 38, ExamTitle = "The Cell Cycle and Mitosis Exam", ExamDescription = "Test your understanding of the cell cycle phases and mitosis.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 75, final = false },
                // Exam for Lesson 77 (Course 16)
                new Exam { Id = 39, ExamTitle = "DNA Structure and Replication Exam", ExamDescription = "Test your knowledge of the double helix and DNA synthesis.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 77, final = false },
                // Exam for Lesson 79 (Course 16)
                new Exam { Id = 40, ExamTitle = "Gene Expression: Translation Exam", ExamDescription = "Test your understanding of protein synthesis from RNA.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 79, final = false },
                // Exam for Lesson 81 (Course 17)
                new Exam { Id = 41, ExamTitle = "Skeletal Systems Exam", ExamDescription = "Test your knowledge of skeleton types and bone structure.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 81, final = false },
                // Exam for Lesson 83 (Course 17)
                new Exam { Id = 42, ExamTitle = "Biomechanics Basics Exam", ExamDescription = "Test your understanding of forces and levers in biological systems.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 83, final = false },
                // Exam for Lesson 85 (Course 17)
                new Exam { Id = 43, ExamTitle = "Nervous System Control of Movement Exam", ExamDescription = "Test your knowledge of how the nervous system controls muscles.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 85, final = false },
                // Exam for Lesson 87 (Course 18)
                new Exam { Id = 44, ExamTitle = "Population Ecology Exam", ExamDescription = "Test your understanding of population growth models.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 87, final = false },
                // Exam for Lesson 89 (Course 18)
                new Exam { Id = 45, ExamTitle = "Ecosystem Dynamics Exam", ExamDescription = "Test your knowledge of energy flow and nutrient cycling.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 89, final = false },
                // Exam for Lesson 91 (Course 19)
                new Exam { Id = 46, ExamTitle = "Plant Structure and Growth Exam", ExamDescription = "Test your knowledge of basic plant anatomy.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 91, final = false },
                // Exam for Lesson 93 (Course 19)
                new Exam { Id = 47, ExamTitle = "Photosynthesis Exam", ExamDescription = "Test your understanding of the photosynthesis process.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 93, final = false },
                // Exam for Lesson 95 (Course 19)
                new Exam { Id = 48, ExamTitle = "Plant Hormones and Responses Exam", ExamDescription = "Test your knowledge of chemical signaling in plants.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 95, final = false },
                // Exam for Lesson 97 (Course 20)
                new Exam { Id = 49, ExamTitle = "Invertebrate Zoology I Exam", ExamDescription = "Test your knowledge of simpler invertebrates.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 97, final = false },
                // Exam for Lesson 99 (Course 20)
                new Exam { Id = 50, ExamTitle = "Vertebrate Zoology I Exam", ExamDescription = "Test your knowledge of Chordates and Fish.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 99, final = false },
                // Exam for Lesson 101 (Course 21)
                new Exam { Id = 51, ExamTitle = "Introduction to Microbes Exam", ExamDescription = "Test your knowledge of microbial diversity.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 101, final = false },
                // Exam for Lesson 103 (Course 21)
                new Exam { Id = 52, ExamTitle = "Microbial Growth and Metabolism Exam", ExamDescription = "Test your understanding of microbial growth requirements and pathways.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 103, final = false },
                // Exam for Lesson 105 (Course 21) - FINAL EXAM FOR BIOLOGY CATEGORY
                new Exam { Id = 53, ExamTitle = "Biology Comprehensive Exam", ExamDescription = "Comprehensive test of cell biology, genetics, physiology, ecology, botany, zoology, and microbiology.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 105, final = true },

                // Category 5: Chemistry (Courses 22, 23, 24, 25, 26, 27, 28) - Ends with Lesson 139 (ExamId 70)
                // Exam for Lesson 107 (Course 22)
                new Exam { Id = 54, ExamTitle = "Alkanes and Cycloalkanes Exam", ExamDescription = "Test your knowledge of alkane nomenclature and conformations.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 107, final = false },
                // Exam for Lesson 109 (Course 22)
                new Exam { Id = 55, ExamTitle = "Introduction to Organic Reactions Exam", ExamDescription = "Test your understanding of reaction types and mechanisms.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 109, final = false },
                // Exam for Lesson 111 (Course 23)
                new Exam { Id = 56, ExamTitle = "Atomic Structure and Periodicity Exam", ExamDescription = "Test your knowledge of atomic models and periodic trends.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 111, final = false },
                // Exam for Lesson 113 (Course 23)
                new Exam { Id = 57, ExamTitle = "Bonding Theories Exam", ExamDescription = "Test your understanding of VB and MO theories.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 113, final = false },
                // Exam for Lesson 115 (Course 23)
                new Exam { Id = 58, ExamTitle = "Coordination Chemistry Basics Exam", ExamDescription = "Test your knowledge of transition metals, ligands, and complex ions.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 115, final = false },
                // Exam for Lesson 117 (Course 24)
                new Exam { Id = 59, ExamTitle = "Thermodynamics: First Law Exam", ExamDescription = "Test your knowledge of energy, work, heat, and enthalpy.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 117, final = false },
                // Exam for Lesson 119 (Course 24)
                new Exam { Id = 60, ExamTitle = "Chemical Kinetics Exam", ExamDescription = "Test your understanding of reaction rates and mechanisms.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 119, final = false },
                // Exam for Lesson 121 (Course 25)
                new Exam { Id = 61, ExamTitle = "Analytical Intro & Stats Exam", ExamDescription = "Test your knowledge of analytical errors and data analysis.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 121, final = false },
                // Exam for Lesson 123 (Course 25)
                new Exam { Id = 62, ExamTitle = "Spectroscopic Methods Exam", ExamDescription = "Test your understanding of light-matter interaction and UV-Vis.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 123, final = false },
                // Exam for Lesson 125 (Course 25)
                new Exam { Id = 63, ExamTitle = "Electroanalytical Methods Exam", ExamDescription = "Test your knowledge of potentiometry and voltammetry basics.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 125, final = false },
                // Exam for Lesson 127 (Course 26)
                new Exam { Id = 64, ExamTitle = "Enzymes and Kinetics Exam", ExamDescription = "Test your knowledge of biological catalysts and reaction rates.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 127, final = false },
                // Exam for Lesson 129 (Course 26)
                new Exam { Id = 65, ExamTitle = "Lipids and Membranes Exam", ExamDescription = "Test your understanding of lipid types and membrane structure.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 129, final = false },
                // Exam for Lesson 131 (Course 27)
                new Exam { Id = 66, ExamTitle = "Atmospheric Chemistry Exam", ExamDescription = "Test your knowledge of atmospheric composition and reactions.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 131, final = false },
                // Exam for Lesson 133 (Course 27)
                new Exam { Id = 67, ExamTitle = "Soil Chemistry Exam", ExamDescription = "Test your understanding of soil composition and chemical reactions.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 133, final = false },
                // Exam for Lesson 135 (Course 27)
                new Exam { Id = 68, ExamTitle = "Green Chemistry Exam", ExamDescription = "Test your knowledge of principles for safer chemical processes.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 135, final = false },
                // Exam for Lesson 137 (Course 28)
                new Exam { Id = 69, ExamTitle = "Approximation Methods Exam", ExamDescription = "Test your knowledge of variation principle and perturbation theory.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 137, final = false },
                // Exam for Lesson 139 (Course 28) - FINAL EXAM FOR CHEMISTRY CATEGORY
                new Exam { Id = 70, ExamTitle = "Chemistry Comprehensive Exam", ExamDescription = "Comprehensive test of organic, inorganic, physical, analytical, bio, environmental, and theoretical chemistry.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 139, final = true },

                // Category 6: English & Literature (Courses 29, 30, 31, 32, 33, 34, 35) - Ends with Lesson 175 (ExamId 88)
                // Exam for Lesson 141 (Course 29)
                new Exam { Id = 71, ExamTitle = "Literary Analysis Basics Exam", ExamDescription = "Test your ability to use tools for interpreting literature.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 141, final = false },
                // Exam for Lesson 143 (Course 29)
                new Exam { Id = 72, ExamTitle = "Poetry Fundamentals Exam", ExamDescription = "Test your understanding of poetic devices and forms.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 143, final = false },
                // Exam for Lesson 145 (Course 29)
                new Exam { Id = 73, ExamTitle = "Introduction to Drama Exam", ExamDescription = "Test your knowledge of the elements of dramatic literature.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 145, final = false },
                // Exam for Lesson 147 (Course 30)
                new Exam { Id = 74, ExamTitle = "Character Development Quiz", ExamDescription = "Test your ability to create believable characters.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 147, final = false },
                // Exam for Lesson 149 (Course 30)
                new Exam { Id = 75, ExamTitle = "Setting and Description Quiz", ExamDescription = "Test your skills in building immersive worlds.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 149, final = false },
                // Exam for Lesson 151 (Course 31)
                new Exam { Id = 76, ExamTitle = "Parts of Speech Exam", ExamDescription = "Test your understanding of nouns, verbs, adjectives, etc.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 151, final = false },
                // Exam for Lesson 153 (Course 31)
                new Exam { Id = 77, ExamTitle = "Punctuation Rules Exam", ExamDescription = "Test your knowledge of correct punctuation usage.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 153, final = false },
                // Exam for Lesson 155 (Course 31)
                new Exam { Id = 78, ExamTitle = "Paragraph and Essay Structure Exam", ExamDescription = "Test your ability to organize ideas effectively.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 155, final = false },
                // Exam for Lesson 157 (Course 32)
                new Exam { Id = 79, ExamTitle = "Figurative Language Exam", ExamDescription = "Test your ability to identify and interpret figurative language.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 157, final = false },
                // Exam for Lesson 159 (Course 32)
                new Exam { Id = 80, ExamTitle = "Poetic Forms Exam", ExamDescription = "Test your ability to recognize and analyze different poetic structures.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 159, final = false },
                // Exam for Lesson 161 (Course 33)
                new Exam { Id = 81, ExamTitle = "History of Theater Exam", ExamDescription = "Test your knowledge of key periods and playwrights.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 161, final = false },
                // Exam for Lesson 163 (Course 33)
                new Exam { Id = 82, ExamTitle = "Reading a Play Exam", ExamDescription = "Test your ability to understand stage directions and subtext.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 163, final = false },
                // Exam for Lesson 165 (Course 33)
                new Exam { Id = 83, ExamTitle = "Theater Production Basics Exam", ExamDescription = "Test your knowledge of roles and processes in theater production.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 165, final = false },
                // Exam for Lesson 167 (Course 34)
                new Exam { Id = 84, ExamTitle = "Point of View Quiz", ExamDescription = "Test your understanding of narrative perspectives.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 167, final = false },
                // Exam for Lesson 169 (Course 34)
                new Exam { Id = 85, ExamTitle = "Crafting Scenes Quiz", ExamDescription = "Test your knowledge of scene structure and pacing.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 169, final = false },
                // Exam for Lesson 171 (Course 35)
                new Exam { Id = 86, ExamTitle = "Types of Non-fiction Exam", ExamDescription = "Test your knowledge of different non-fiction forms.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 171, final = false },
                // Exam for Lesson 173 (Course 35)
                new Exam { Id = 87, ExamTitle = "Structuring Non-fiction Exam", ExamDescription = "Test your ability to organize factual material effectively.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 173, final = false },
                // Exam for Lesson 175 (Course 35) - FINAL EXAM FOR ENGLISH & LITERATURE CATEGORY
                new Exam { Id = 88, ExamTitle = "English & Literature Comprehensive Exam", ExamDescription = "Comprehensive test of literary analysis, creative writing, grammar, composition, and non-fiction.", Grade = "Not Graded", CreatedAt = seedDate, lessonId = 175, final = true }
            );

            modelBuilder.Entity<BankOfQuestion>().HasData(
                // --- Questions for Exam 1 (lessonId = 1, Algebra Basics) ---
                new BankOfQuestion { Id = 1, QuestionText = "In the expression 3x + 5, what is 'x' called?", OptionA = "Coefficient", OptionB = "Variable", OptionC = "Constant", OptionD = "Term", CorrectAnswer = "B", ExamId = 1 },
                new BankOfQuestion { Id = 2, QuestionText = "What is the coefficient in the term 7y?", OptionA = "y", OptionB = "7y", OptionC = "7", OptionD = "None", CorrectAnswer = "C", ExamId = 1 },
                new BankOfQuestion { Id = 3, QuestionText = "Which of the following is a constant?", OptionA = "2a", OptionB = "b", OptionC = "-4", OptionD = "x/3", CorrectAnswer = "C", ExamId = 1 },
                new BankOfQuestion { Id = 4, QuestionText = "How many terms are in the expression 2x - y + 6?", OptionA = "1", OptionB = "2", OptionC = "3", OptionD = "6", CorrectAnswer = "C", ExamId = 1 },
                new BankOfQuestion { Id = 5, QuestionText = "Simplify the expression: 4a + 2a - a", OptionA = "6a", OptionB = "5a", OptionC = "7a", OptionD = "4a", CorrectAnswer = "B", ExamId = 1 },

                // --- Questions for Exam 2 (lessonId = 3, Inequalities) ---
                new BankOfQuestion { Id = 6, QuestionText = "Which symbol represents 'less than or equal to'?", OptionA = "<", OptionB = ">", OptionC = "<=", OptionD = ">=", CorrectAnswer = "C", ExamId = 2 },
                new BankOfQuestion { Id = 7, QuestionText = "Solve the inequality: x + 3 > 7", OptionA = "x > 4", OptionB = "x < 4", OptionC = "x > 10", OptionD = "x < 10", CorrectAnswer = "A", ExamId = 2 },
                new BankOfQuestion { Id = 8, QuestionText = "When solving -2x < 6, what happens to the inequality sign?", OptionA = "Stays the same", OptionB = "Flips", OptionC = "Becomes equals", OptionD = "Disappears", CorrectAnswer = "B", ExamId = 2 },
                new BankOfQuestion { Id = 9, QuestionText = "How is 'x is greater than 5' represented on a number line?", OptionA = "Closed circle on 5, shaded left", OptionB = "Open circle on 5, shaded left", OptionC = "Closed circle on 5, shaded right", OptionD = "Open circle on 5, shaded right", CorrectAnswer = "D", ExamId = 2 },
                new BankOfQuestion { Id = 10, QuestionText = "Solve: 3x - 1 <= 8", OptionA = "x <= 3", OptionB = "x >= 3", OptionC = "x <= 9/3", OptionD = "x <= 7/3", CorrectAnswer = "A", ExamId = 2 },

                // --- Questions for Exam 3 (lessonId = 5, Polynomial Basics) ---
                new BankOfQuestion { Id = 11, QuestionText = "What is the degree of the polynomial 3x^2 + 2x - 1?", OptionA = "1", OptionB = "2", OptionC = "3", OptionD = "0", CorrectAnswer = "B", ExamId = 3 },
                new BankOfQuestion { Id = 12, QuestionText = "Which of the following is a binomial?", OptionA = "5x", OptionB = "x^2 + 3x - 4", OptionC = "2y + 7", OptionD = "10", CorrectAnswer = "C", ExamId = 3 },
                new BankOfQuestion { Id = 13, QuestionText = "Add the polynomials: (2x + 3) + (x - 1)", OptionA = "3x + 2", OptionB = "3x + 4", OptionC = "2x + 2", OptionD = "x + 2", CorrectAnswer = "A", ExamId = 3 },
                new BankOfQuestion { Id = 14, QuestionText = "Subtract: (5y - 2) - (y + 3)", OptionA = "4y - 5", OptionB = "4y + 1", OptionC = "6y + 1", OptionD = "4y + 5", CorrectAnswer = "A", ExamId = 3 },
                new BankOfQuestion { Id = 15, QuestionText = "Multiply: x(x + 4)", OptionA = "x^2 + 4", OptionB = "2x + 4", OptionC = "x^2 + 4x", OptionD = "5x", CorrectAnswer = "C", ExamId = 3 },

                // --- Questions for Exam 4 (lessonId = 7, Intro to Derivatives) ---
                new BankOfQuestion { Id = 16, QuestionText = "The derivative of a function f(x) represents the:", OptionA = "Area under the curve", OptionB = "Value of the function", OptionC = "Instantaneous rate of change", OptionD = "Y-intercept", CorrectAnswer = "C", ExamId = 4 },
                new BankOfQuestion { Id = 17, QuestionText = "What is the derivative of a constant function, f(x) = c?", OptionA = "c", OptionB = "x", OptionC = "1", OptionD = "0", CorrectAnswer = "D", ExamId = 4 },
                new BankOfQuestion { Id = 18, QuestionText = "What is the derivative of f(x) = x^n using the power rule?", OptionA = "nx^(n-1)", OptionB = "x^(n-1)", OptionC = "n*x^n", OptionD = "(n-1)x^n", CorrectAnswer = "A", ExamId = 4 },
                new BankOfQuestion { Id = 19, QuestionText = "Find the derivative of f(x) = 5x^3", OptionA = "15x^2", OptionB = "5x^2", OptionC = "15x^3", OptionD = "3x^2", CorrectAnswer = "A", ExamId = 4 },
                new BankOfQuestion { Id = 20, QuestionText = "The derivative of f(x) = 7x is:", OptionA = "7x", OptionB = "x", OptionC = "7", OptionD = "0", CorrectAnswer = "C", ExamId = 4 },

                // --- Questions for Exam 5 (lessonId = 9, Applications of Derivatives) ---
                new BankOfQuestion { Id = 21, QuestionText = "Derivatives can be used to find the ___ of a tangent line to a curve.", OptionA = "Length", OptionB = "Y-intercept", OptionC = "Slope", OptionD = "Area", CorrectAnswer = "C", ExamId = 5 },
                new BankOfQuestion { Id = 22, QuestionText = "If the derivative f'(x) is positive on an interval, the function f(x) is:", OptionA = "Decreasing", OptionB = "Increasing", OptionC = "Constant", OptionD = "Concave down", CorrectAnswer = "B", ExamId = 5 },
                new BankOfQuestion { Id = 23, QuestionText = "A critical point occurs where the derivative f'(x) is:", OptionA = "Positive", OptionB = "Negative", OptionC = "Zero or undefined", OptionD = "Always 1", CorrectAnswer = "C", ExamId = 5 },
                new BankOfQuestion { Id = 24, QuestionText = "Optimization problems often involve finding the ___ or ___ value of a function.", OptionA = "Positive or Negative", OptionB = "Maximum or Minimum", OptionC = "First or Last", OptionD = "Real or Imaginary", CorrectAnswer = "B", ExamId = 5 },
                new BankOfQuestion { Id = 25, QuestionText = "If s(t) is the position function, what does s'(t) represent?", OptionA = "Acceleration", OptionB = "Position", OptionC = "Jerk", OptionD = "Velocity", CorrectAnswer = "D", ExamId = 5 },

                // --- Questions for Exam 6 (lessonId = 11, Points, Lines, and Planes) ---
                new BankOfQuestion { Id = 26, QuestionText = "Which is a fundamental undefined term in geometry?", OptionA = "Angle", OptionB = "Line segment", OptionC = "Point", OptionD = "Circle", CorrectAnswer = "C", ExamId = 6 },
                new BankOfQuestion { Id = 27, QuestionText = "How many points are needed to define a unique line?", OptionA = "1", OptionB = "2", OptionC = "3", OptionD = "Infinite", CorrectAnswer = "B", ExamId = 6 },
                new BankOfQuestion { Id = 28, QuestionText = "How many non-collinear points are needed to define a unique plane?", OptionA = "1", OptionB = "2", OptionC = "3", OptionD = "4", CorrectAnswer = "C", ExamId = 6 },
                new BankOfQuestion { Id = 29, QuestionText = "Points that lie on the same line are called:", OptionA = "Coplanar", OptionB = "Collinear", OptionC = "Concurrent", OptionD = "Congruent", CorrectAnswer = "B", ExamId = 6 },
                new BankOfQuestion { Id = 30, QuestionText = "The intersection of two distinct planes is a:", OptionA = "Point", OptionB = "Line", OptionC = "Plane", OptionD = "Nothing", CorrectAnswer = "B", ExamId = 6 },

                // --- Questions for Exam 7 (lessonId = 13, Parallel Lines and Transversals) ---
                new BankOfQuestion { Id = 31, QuestionText = "Lines that are in the same plane and never intersect are called:", OptionA = "Skew lines", OptionB = "Perpendicular lines", OptionC = "Parallel lines", OptionD = "Transversals", CorrectAnswer = "C", ExamId = 7 },
                new BankOfQuestion { Id = 32, QuestionText = "A line that intersects two or more other lines is called a:", OptionA = "Parallel", OptionB = "Segment", OptionC = "Ray", OptionD = "Transversal", CorrectAnswer = "D", ExamId = 7 },
                new BankOfQuestion { Id = 33, QuestionText = "When a transversal intersects parallel lines, alternate interior angles are:", OptionA = "Supplementary", OptionB = "Complementary", OptionC = "Congruent", OptionD = "Adjacent", CorrectAnswer = "C", ExamId = 7 },
                new BankOfQuestion { Id = 34, QuestionText = "When a transversal intersects parallel lines, corresponding angles are:", OptionA = "Congruent", OptionB = "Supplementary", OptionC = "Complementary", OptionD = "Vertical", CorrectAnswer = "A", ExamId = 7 },
                new BankOfQuestion { Id = 35, QuestionText = "Consecutive interior angles (same-side interior angles) formed by parallel lines and a transversal are:", OptionA = "Congruent", OptionB = "Complementary", OptionC = "Acute", OptionD = "Supplementary", CorrectAnswer = "D", ExamId = 7 },

                // --- Questions for Exam 8 (lessonId = 15, Introduction to Polygons) ---
                new BankOfQuestion { Id = 36, QuestionText = "A polygon is a closed figure made of:", OptionA = "Curves", OptionB = "Line segments", OptionC = "Circles", OptionD = "Points", CorrectAnswer = "B", ExamId = 8 },
                new BankOfQuestion { Id = 37, QuestionText = "How many sides does a hexagon have?", OptionA = "5", OptionB = "6", OptionC = "7", OptionD = "8", CorrectAnswer = "B", ExamId = 8 },
                new BankOfQuestion { Id = 38, QuestionText = "What is the name for a four-sided polygon?", OptionA = "Pentagon", OptionB = "Triangle", OptionC = "Quadrilateral", OptionD = "Octagon", CorrectAnswer = "C", ExamId = 8 },
                new BankOfQuestion { Id = 39, QuestionText = "A polygon where all sides and all angles are equal is called:", OptionA = "Irregular", OptionB = "Concave", OptionC = "Complex", OptionD = "Regular", CorrectAnswer = "D", ExamId = 8 },
                new BankOfQuestion { Id = 40, QuestionText = "What is the formula for the sum of interior angles of an n-sided polygon?", OptionA = "180n", OptionB = "360n", OptionC = "(n-2) * 180", OptionD = "n * 180 / 2", CorrectAnswer = "C", ExamId = 8 },

                // --- Questions for Exam 9 (lessonId = 17, The Unit Circle) ---
                new BankOfQuestion { Id = 41, QuestionText = "What is the radius of the unit circle?", OptionA = "0", OptionB = "1", OptionC = "pi", OptionD = "2", CorrectAnswer = "B", ExamId = 9 },
                new BankOfQuestion { Id = 42, QuestionText = "On the unit circle, the x-coordinate of a point corresponds to which trigonometric function?", OptionA = "Sine", OptionB = "Cosine", OptionC = "Tangent", OptionD = "Secant", CorrectAnswer = "B", ExamId = 9 },
                new BankOfQuestion { Id = 43, QuestionText = "On the unit circle, the y-coordinate of a point corresponds to which trigonometric function?", OptionA = "Sine", OptionB = "Cosine", OptionC = "Cotangent", OptionD = "Cosecant", CorrectAnswer = "A", ExamId = 9 },
                new BankOfQuestion { Id = 44, QuestionText = "What is the value of cos(0) on the unit circle?", OptionA = "0", OptionB = "1", OptionC = "-1", OptionD = "undefined", CorrectAnswer = "B", ExamId = 9 },
                new BankOfQuestion { Id = 45, QuestionText = "What is the value of sin(pi/2) on the unit circle?", OptionA = "0", OptionB = "1", OptionC = "-1", OptionD = "1/2", CorrectAnswer = "B", ExamId = 9 },

                // --- Questions for Exam 10 (lessonId = 19, Trigonometric Identities) ---
                new BankOfQuestion { Id = 46, QuestionText = "Which is the fundamental Pythagorean identity?", OptionA = "sin^2(x) - cos^2(x) = 1", OptionB = "tan^2(x) + 1 = sec^2(x)", OptionC = "sin^2(x) + cos^2(x) = 1", OptionD = "1 + cot^2(x) = csc(x)", CorrectAnswer = "C", ExamId = 10 },
                new BankOfQuestion { Id = 47, QuestionText = "tan(x) is equivalent to:", OptionA = "cos(x) / sin(x)", OptionB = "sin(x) / cos(x)", OptionC = "1 / sin(x)", OptionD = "1 / cos(x)", CorrectAnswer = "B", ExamId = 10 },
                new BankOfQuestion { Id = 48, QuestionText = "csc(x) is the reciprocal of:", OptionA = "sin(x)", OptionB = "cos(x)", OptionC = "tan(x)", OptionD = "sec(x)", CorrectAnswer = "A", ExamId = 10 },
                new BankOfQuestion { Id = 49, QuestionText = "Simplify: sin(x) * csc(x)", OptionA = "1", OptionB = "sin^2(x)", OptionC = "tan(x)", OptionD = "0", CorrectAnswer = "A", ExamId = 10 },
                new BankOfQuestion { Id = 50, QuestionText = "Which identity relates tan^2(x) and sec^2(x)?", OptionA = "tan^2(x) - sec^2(x) = 1", OptionB = "sec^2(x) + tan^2(x) = 1", OptionC = "1 + tan^2(x) = sec^2(x)", OptionD = "1 - tan^2(x) = sec^2(x)", CorrectAnswer = "C", ExamId = 10 },

                // --- Questions for Exam 11 (lessonId = 21, Introduction to Statistics) ---
                new BankOfQuestion { Id = 51, QuestionText = "Statistics is the science of collecting, organizing, analyzing, and ___ data.", OptionA = "Ignoring", OptionB = "Interpreting", OptionC = "Deleting", OptionD = "Complicating", CorrectAnswer = "B", ExamId = 11 },
                new BankOfQuestion { Id = 52, QuestionText = "The entire group of individuals or objects being studied is called the:", OptionA = "Sample", OptionB = "Population", OptionC = "Variable", OptionD = "Statistic", CorrectAnswer = "B", ExamId = 11 },
                new BankOfQuestion { Id = 53, QuestionText = "A subset of the population selected for study is called a:", OptionA = "Parameter", OptionB = "Variable", OptionC = "Sample", OptionD = "Census", CorrectAnswer = "C", ExamId = 11 },
                new BankOfQuestion { Id = 54, QuestionText = "Data that consists of names, labels, or categories (e.g., eye color) is called:", OptionA = "Quantitative", OptionB = "Numerical", OptionC = "Discrete", OptionD = "Qualitative", CorrectAnswer = "D", ExamId = 11 },
                new BankOfQuestion { Id = 55, QuestionText = "Data that consists of numbers representing counts or measurements is called:", OptionA = "Qualitative", OptionB = "Categorical", OptionC = "Quantitative", OptionD = "Nominal", CorrectAnswer = "C", ExamId = 11 },

                // --- Questions for Exam 12 (lessonId = 23, Data Visualization) ---
                new BankOfQuestion { Id = 56, QuestionText = "Which type of graph is best for showing frequencies of categorical data?", OptionA = "Scatter plot", OptionB = "Line graph", OptionC = "Bar chart", OptionD = "Box plot", CorrectAnswer = "C", ExamId = 12 },
                new BankOfQuestion { Id = 57, QuestionText = "A graph that uses bars to represent the frequency of numerical data grouped into intervals is called a:", OptionA = "Pie chart", OptionB = "Histogram", OptionC = "Stem-and-leaf plot", OptionD = "Dot plot", CorrectAnswer = "B", ExamId = 12 },
                new BankOfQuestion { Id = 58, QuestionText = "Which graph is used to show the relationship between two quantitative variables?", OptionA = "Histogram", OptionB = "Bar chart", OptionC = "Pie chart", OptionD = "Scatter plot", CorrectAnswer = "D", ExamId = 12 },
                new BankOfQuestion { Id = 59, QuestionText = "A box plot (box-and-whisker plot) displays which five-number summary?", OptionA = "Mean, Median, Mode, Min, Max", OptionB = "Min, Q1, Median, Q3, Max", OptionC = "Mean, SD, Variance, Range, IQR", OptionD = "Count, Sum, Average, Min, Max", CorrectAnswer = "B", ExamId = 12 },
                new BankOfQuestion { Id = 60, QuestionText = "A pie chart is best used to show:", OptionA = "Trends over time", OptionB = "Comparison between categories", OptionC = "Relationship between variables", OptionD = "Parts of a whole", CorrectAnswer = "D", ExamId = 12 },

                // --- Questions for Exam 13 (lessonId = 25, Introduction to Distributions) ---
                new BankOfQuestion { Id = 61, QuestionText = "A table or equation that links each outcome of a statistical experiment with its probability of occurrence is a:", OptionA = "Frequency table", OptionB = "Probability distribution", OptionC = "Cumulative frequency", OptionD = "Sample space", CorrectAnswer = "B", ExamId = 13 },
                new BankOfQuestion { Id = 62, QuestionText = "Which distribution is often described as 'bell-shaped'?", OptionA = "Binomial", OptionB = "Poisson", OptionC = "Uniform", OptionD = "Normal", CorrectAnswer = "D", ExamId = 13 },
                new BankOfQuestion { Id = 63, QuestionText = "The Binomial distribution applies to experiments with:", OptionA = "Continuous outcomes", OptionB = "Infinite trials", OptionC = "Two possible outcomes per trial", OptionD = "Variable probability of success", CorrectAnswer = "C", ExamId = 13 },
                new BankOfQuestion { Id = 64, QuestionText = "The Normal distribution is completely defined by its:", OptionA = "Mean and Median", OptionB = "Mean and Standard Deviation", OptionC = "Mode and Range", OptionD = "Min and Max", CorrectAnswer = "B", ExamId = 13 },
                new BankOfQuestion { Id = 65, QuestionText = "In a discrete probability distribution, the sum of all probabilities must equal:", OptionA = "0", OptionB = "1", OptionC = "100", OptionD = "Infinity", CorrectAnswer = "B", ExamId = 13 },

                // --- Questions for Exam 14 (lessonId = 27, Conditional Probability) ---
                new BankOfQuestion { Id = 66, QuestionText = "P(A|B) represents the probability of:", OptionA = "Event A and Event B", OptionB = "Event A or Event B", OptionC = "Event A given Event B occurred", OptionD = "Event B given Event A occurred", CorrectAnswer = "C", ExamId = 14 },
                new BankOfQuestion { Id = 67, QuestionText = "Two events A and B are independent if:", OptionA = "P(A|B) = P(B)", OptionB = "P(A|B) = P(A)", OptionC = "P(A and B) = P(A) + P(B)", OptionD = "P(A|B) = 0", CorrectAnswer = "B", ExamId = 14 },
                new BankOfQuestion { Id = 68, QuestionText = "Bayes' Theorem is used to calculate:", OptionA = "Joint probability", OptionB = "Marginal probability", OptionC = "Prior probability", OptionD = "Posterior (conditional) probability", CorrectAnswer = "D", ExamId = 14 },
                new BankOfQuestion { Id = 69, QuestionText = "If P(A) = 0.5, P(B) = 0.4, and P(A and B) = 0.2, are A and B independent?", OptionA = "Yes, because P(A)*P(B) = P(A and B)", OptionB = "No, because P(A)*P(B) != P(A and B)", OptionC = "Yes, because P(A)+P(B) > 1", OptionD = "Cannot be determined", CorrectAnswer = "A", ExamId = 14 },
                new BankOfQuestion { Id = 70, QuestionText = "The formula P(A|B) = P(A and B) / P(B) defines:", OptionA = "Independence", OptionB = "Mutual exclusivity", OptionC = "Conditional probability", OptionD = "Joint probability", CorrectAnswer = "C", ExamId = 14 },

                // --- Questions for Exam 15 (lessonId = 29, Statistics & Probability Comprehensive Exam) ---
                new BankOfQuestion { Id = 71, QuestionText = "Expected Value E(X) of a discrete random variable represents the:", OptionA = "Most likely outcome", OptionB = "Average outcome over many trials", OptionC = "Maximum possible value", OptionD = "Spread of the distribution", CorrectAnswer = "B", ExamId = 15 },
                new BankOfQuestion { Id = 72, QuestionText = "How is Expected Value E(X) calculated?", OptionA = "Sum of (Outcome * Probability)", OptionB = "Sum of Probabilities", OptionC = "Product of Outcomes", OptionD = "Average of Outcomes", CorrectAnswer = "A", ExamId = 15 },
                new BankOfQuestion { Id = 73, QuestionText = "Variance Var(X) measures the:", OptionA = "Central tendency", OptionB = "Average value", OptionC = "Spread or dispersion", OptionD = "Skewness", CorrectAnswer = "C", ExamId = 15 },
                new BankOfQuestion { Id = 74, QuestionText = "Standard Deviation is the ___ of the Variance.", OptionA = "Square", OptionB = "Reciprocal", OptionC = "Square root", OptionD = "Double", CorrectAnswer = "C", ExamId = 15 },
                new BankOfQuestion { Id = 75, QuestionText = "If E(X) = 5, what is E(3X + 2)?", OptionA = "5", OptionB = "15", OptionC = "17", OptionD = "21", CorrectAnswer = "C", ExamId = 15 },

                // --- Questions for Exam 16 (lessonId = 31, Logic and Proofs) ---
                new BankOfQuestion { Id = 76, QuestionText = "A statement that is either true or false is called a:", OptionA = "Theorem", OptionB = "Axiom", OptionC = "Proposition", OptionD = "Corollary", CorrectAnswer = "C", ExamId = 16 },
                new BankOfQuestion { Id = 77, QuestionText = "The symbol '¬' represents which logical operator?", OptionA = "AND", OptionB = "OR", OptionC = "NOT (Negation)", OptionD = "IMPLIES", CorrectAnswer = "C", ExamId = 16 },
                new BankOfQuestion { Id = 78, QuestionText = "A truth table is used to determine the truth value of a:", OptionA = "Single proposition", OptionB = "Compound proposition", OptionC = "Proof", OptionD = "Set", CorrectAnswer = "B", ExamId = 16 },
                new BankOfQuestion { Id = 79, QuestionText = "A proof technique that assumes the negation of the conclusion and derives a contradiction is:", OptionA = "Direct proof", OptionB = "Proof by contraposition", OptionC = "Proof by contradiction", OptionD = "Proof by induction", CorrectAnswer = "C", ExamId = 16 },
                new BankOfQuestion { Id = 80, QuestionText = "The statement 'If P, then Q' (P → Q) is false only when:", OptionA = "P is true, Q is true", OptionB = "P is true, Q is false", OptionC = "P is false, Q is true", OptionD = "P is false, Q is false", CorrectAnswer = "B", ExamId = 16 },

                // --- Questions for Exam 17 (lessonId = 33, Counting Principles) ---
                new BankOfQuestion { Id = 81, QuestionText = "The number of ways to arrange n distinct objects is given by:", OptionA = "n^2", OptionB = "2^n", OptionC = "n!", OptionD = "C(n, 2)", CorrectAnswer = "C", ExamId = 17 },
                new BankOfQuestion { Id = 82, QuestionText = "Which calculation is used when the order of selection matters?", OptionA = "Combination", OptionB = "Permutation", OptionC = "Factorial", OptionD = "Probability", CorrectAnswer = "B", ExamId = 17 },
                new BankOfQuestion { Id = 83, QuestionText = "Which calculation is used when the order of selection does NOT matter?", OptionA = "Combination", OptionB = "Permutation", OptionC = "Factorial", OptionD = "Distribution", CorrectAnswer = "A", ExamId = 17 },
                new BankOfQuestion { Id = 84, QuestionText = "How many ways can you choose 2 letters from {A, B, C} if order doesn't matter?", OptionA = "1", OptionB = "3", OptionC = "6", OptionD = "9", CorrectAnswer = "B", ExamId = 17 },
                new BankOfQuestion { Id = 85, QuestionText = "The Pigeonhole Principle states that if you have n items put into m containers, with n > m, then:", OptionA = "All containers are empty", OptionB = "All containers have 1 item", OptionC = "At least one container has 0 items", OptionD = "At least one container has more than 1 item", CorrectAnswer = "D", ExamId = 17 },

                // --- Questions for Exam 18 (lessonId = 35, Core Mathematics Comprehensive Exam) ---
                new BankOfQuestion { Id = 86, QuestionText = "In graph theory, what are the points called?", OptionA = "Edges", OptionB = "Nodes", OptionC = "Vertices", OptionD = "Lines", CorrectAnswer = "C", ExamId = 18 },
                new BankOfQuestion { Id = 87, QuestionText = "What connects the vertices in a graph?", OptionA = "Nodes", OptionB = "Paths", OptionC = "Cycles", OptionD = "Edges", CorrectAnswer = "D", ExamId = 18 },
                new BankOfQuestion { Id = 88, QuestionText = "A graph where edges have direction is called a:", OptionA = "Directed graph (Digraph)", OptionB = "Undirected graph", OptionC = "Weighted graph", OptionD = "Simple graph", CorrectAnswer = "A", ExamId = 18 },
                new BankOfQuestion { Id = 89, QuestionText = "A sequence of vertices where each adjacent pair is connected by an edge is a:", OptionA = "Cycle", OptionB = "Tree", OptionC = "Walk/Path", OptionD = "Component", CorrectAnswer = "C", ExamId = 18 },
                new BankOfQuestion { Id = 90, QuestionText = "A connected graph with no cycles is called a:", OptionA = "Complete graph", OptionB = "Bipartite graph", OptionC = "Tree", OptionD = "Planar graph", CorrectAnswer = "C", ExamId = 18 },

                // --- Questions for Exam 19 (lessonId = 37, Vectors and 2D Kinematics) ---
                new BankOfQuestion { Id = 91, QuestionText = "A quantity that has both magnitude and direction is a:", OptionA = "Scalar", OptionB = "Vector", OptionC = "Tensor", OptionD = "Matrix", CorrectAnswer = "B", ExamId = 19 },
                new BankOfQuestion { Id = 92, QuestionText = "Which is an example of a scalar quantity?", OptionA = "Velocity", OptionB = "Acceleration", OptionC = "Force", OptionD = "Speed", CorrectAnswer = "D", ExamId = 19 },
                new BankOfQuestion { Id = 93, QuestionText = "Breaking a vector into its horizontal and vertical parts is called:", OptionA = "Addition", OptionB = "Resolution", OptionC = "Dot product", OptionD = "Normalization", CorrectAnswer = "B", ExamId = 19 },
                new BankOfQuestion { Id = 94, QuestionText = "The path of a projectile under gravity (neglecting air resistance) is typically a:", OptionA = "Circle", OptionB = "Straight line", OptionC = "Parabola", OptionD = "Hyperbola", CorrectAnswer = "C", ExamId = 19 },
                new BankOfQuestion { Id = 95, QuestionText = "How are vectors typically added graphically?", OptionA = "Tail-to-tail", OptionB = "Head-to-head", OptionC = "Head-to-tail", OptionD = "Side-by-side", CorrectAnswer = "C", ExamId = 19 },

                // --- Questions for Exam 20 (lessonId = 39, Work, Energy, and Power) ---
                new BankOfQuestion { Id = 96, QuestionText = "Work is done when a ___ causes displacement.", OptionA = "Force", OptionB = "Energy", OptionC = "Power", OptionD = "Mass", CorrectAnswer = "A", ExamId = 20 },
                new BankOfQuestion { Id = 97, QuestionText = "Energy due to motion is called:", OptionA = "Potential energy", OptionB = "Kinetic energy", OptionC = "Chemical energy", OptionD = "Thermal energy", CorrectAnswer = "B", ExamId = 20 },
                new BankOfQuestion { Id = 98, QuestionText = "Energy stored due to position or configuration is called:", OptionA = "Kinetic energy", OptionB = "Potential energy", OptionC = "Work", OptionD = "Power", CorrectAnswer = "B", ExamId = 20 },
                new BankOfQuestion { Id = 99, QuestionText = "The principle of Conservation of Energy states that energy cannot be:", OptionA = "Transferred", OptionB = "Transformed", OptionC = "Created or destroyed", OptionD = "Measured", CorrectAnswer = "C", ExamId = 20 },
                new BankOfQuestion { Id = 100, QuestionText = "Power is the ___ at which work is done or energy is transferred.", OptionA = "Amount", OptionB = "Type", OptionC = "Rate", OptionD = "Direction", CorrectAnswer = "C", ExamId = 20 },

                // --- Questions for Exam 21 (lessonId = 41, Electric Charge and Coulomb's Law) ---
                new BankOfQuestion { Id = 101, QuestionText = "The two types of electric charge are:", OptionA = "Positive and Negative", OptionB = "Strong and Weak", OptionC = "North and South", OptionD = "Up and Down", CorrectAnswer = "A", ExamId = 21 },
                new BankOfQuestion { Id = 102, QuestionText = "Like charges ___ and opposite charges ___.", OptionA = "Attract, Repel", OptionB = "Repel, Attract", OptionC = "Attract, Attract", OptionD = "Repel, Repel", CorrectAnswer = "B", ExamId = 21 },
                new BankOfQuestion { Id = 103, QuestionText = "The fundamental unit of charge is carried by the:", OptionA = "Neutron", OptionB = "Proton", OptionC = "Electron (and Proton)", OptionD = "Atom", CorrectAnswer = "C", ExamId = 21 },
                new BankOfQuestion { Id = 104, QuestionText = "Coulomb's Law describes the ___ between two point charges.", OptionA = "Potential", OptionB = "Field", OptionC = "Force", OptionD = "Current", CorrectAnswer = "C", ExamId = 21 },
                new BankOfQuestion { Id = 105, QuestionText = "According to Coulomb's Law, the force is inversely proportional to the ___ of the distance between charges.", OptionA = "Distance", OptionB = "Square of the distance", OptionC = "Cube of the distance", OptionD = "Square root of the distance", CorrectAnswer = "B", ExamId = 21 },

                // --- Questions for Exam 22 (lessonId = 43, Electric Potential) ---
                new BankOfQuestion { Id = 106, QuestionText = "Electric potential is defined as electric potential ___ per unit charge.", OptionA = "Force", OptionB = "Field", OptionC = "Energy", OptionD = "Current", CorrectAnswer = "C", ExamId = 22 },
                new BankOfQuestion { Id = 107, QuestionText = "The unit of electric potential is the:", OptionA = "Ampere (A)", OptionB = "Coulomb (C)", OptionC = "Ohm (Ω)", OptionD = "Volt (V)", CorrectAnswer = "D", ExamId = 22 },
                new BankOfQuestion { Id = 108, QuestionText = "Potential difference is also known as:", OptionA = "Current", OptionB = "Resistance", OptionC = "Voltage", OptionD = "Capacitance", CorrectAnswer = "C", ExamId = 22 },
                new BankOfQuestion { Id = 109, QuestionText = "Positive charges tend to move from regions of ___ potential to ___ potential.", OptionA = "High, Low", OptionB = "Low, High", OptionC = "Negative, Positive", OptionD = "Zero, Non-zero", CorrectAnswer = "A", ExamId = 22 },
                new BankOfQuestion { Id = 110, QuestionText = "An equipotential surface is one where all points have the same:", OptionA = "Electric field", OptionB = "Charge density", OptionC = "Electric potential", OptionD = "Force", CorrectAnswer = "C", ExamId = 22 },

                // --- Questions for Exam 23 (lessonId = 45, Current, Resistance, and Ohm's Law) ---
                new BankOfQuestion { Id = 111, QuestionText = "Electric current is the rate of flow of:", OptionA = "Voltage", OptionB = "Resistance", OptionC = "Charge", OptionD = "Energy", CorrectAnswer = "C", ExamId = 23 },
                new BankOfQuestion { Id = 112, QuestionText = "The unit of electric current is the:", OptionA = "Volt (V)", OptionB = "Ohm (Ω)", OptionC = "Watt (W)", OptionD = "Ampere (A)", CorrectAnswer = "D", ExamId = 23 },
                new BankOfQuestion { Id = 113, QuestionText = "Resistance is the opposition to:", OptionA = "Voltage", OptionB = "Current flow", OptionC = "Charge buildup", OptionD = "Magnetic fields", CorrectAnswer = "B", ExamId = 23 },
                new BankOfQuestion { Id = 114, QuestionText = "Ohm's Law states the relationship between voltage (V), current (I), and resistance (R) as:", OptionA = "V = I / R", OptionB = "V = R / I", OptionC = "V = I * R", OptionD = "I = V * R", CorrectAnswer = "C", ExamId = 23 },
                new BankOfQuestion { Id = 115, QuestionText = "The unit of electrical resistance is the:", OptionA = "Ampere (A)", OptionB = "Volt (V)", OptionC = "Ohm (Ω)", OptionD = "Farad (F)", CorrectAnswer = "C", ExamId = 23 },

                // --- Questions for Exam 24 (lessonId = 47, Sources of Magnetic Fields) ---
                new BankOfQuestion { Id = 116, QuestionText = "Moving electric charges (currents) create:", OptionA = "Electric fields only", OptionB = "Magnetic fields", OptionC = "Gravitational fields", OptionD = "No fields", CorrectAnswer = "B", ExamId = 24 },
                new BankOfQuestion { Id = 117, QuestionText = "The Biot-Savart Law is used to calculate the:", OptionA = "Electric force", OptionB = "Magnetic force", OptionC = "Electric field", OptionD = "Magnetic field created by a current element", CorrectAnswer = "D", ExamId = 24 },
                new BankOfQuestion { Id = 118, QuestionText = "The magnetic field lines around a long, straight current-carrying wire form:", OptionA = "Straight lines parallel to the wire", OptionB = "Straight lines perpendicular to the wire", OptionC = "Concentric circles around the wire", OptionD = "Spirals", CorrectAnswer = "C", ExamId = 24 },
                new BankOfQuestion { Id = 119, QuestionText = "A coil of wire designed to produce a strong magnetic field inside it is called a:", OptionA = "Capacitor", OptionB = "Resistor", OptionC = "Solenoid", OptionD = "Transistor", CorrectAnswer = "C", ExamId = 24 },
                new BankOfQuestion { Id = 120, QuestionText = "The direction of the magnetic field around a wire can be found using the:", OptionA = "Left-hand rule", OptionB = "Right-hand rule", OptionC = "Ohm's Law", OptionD = "Coulomb's Law", CorrectAnswer = "B", ExamId = 24 },

                // --- Questions for Exam 25 (lessonId = 49, Electromagnetic Induction) ---
                new BankOfQuestion { Id = 121, QuestionText = "Electromagnetic induction is the production of an ___ across an electrical conductor in a changing magnetic field.", OptionA = "Current", OptionB = "Electromotive force (EMF) / Voltage", OptionC = "Resistance", OptionD = "Charge", CorrectAnswer = "B", ExamId = 25 },
                new BankOfQuestion { Id = 122, QuestionText = "Faraday's Law of Induction states that the induced EMF is proportional to the rate of change of:", OptionA = "Electric field", OptionB = "Magnetic field", OptionC = "Current", OptionD = "Magnetic flux", CorrectAnswer = "D", ExamId = 25 },
                new BankOfQuestion { Id = 123, QuestionText = "Magnetic flux is a measure of the amount of ___ passing through a given area.", OptionA = "Electric field lines", OptionB = "Magnetic field lines", OptionC = "Current", OptionD = "Voltage", CorrectAnswer = "B", ExamId = 25 },
                new BankOfQuestion { Id = 124, QuestionText = "Lenz's Law determines the ___ of the induced current.", OptionA = "Magnitude", OptionB = "Direction", OptionC = "Frequency", OptionD = "Power", CorrectAnswer = "B", ExamId = 25 },
                new BankOfQuestion { Id = 125, QuestionText = "Lenz's Law states that the induced current flows in a direction that ___ the change in magnetic flux that produced it.", OptionA = "Enhances", OptionB = "Opposes", OptionC = "Ignores", OptionD = "Doubles", CorrectAnswer = "B", ExamId = 25 },

                // --- Questions for Exam 26 (lessonId = 51, Nature of Light) ---
                new BankOfQuestion { Id = 126, QuestionText = "Light exhibits properties of both:", OptionA = "Solids and Liquids", OptionB = "Waves and Particles", OptionC = "Acids and Bases", OptionD = "Magnets and Charges", CorrectAnswer = "B", ExamId = 26 },
                new BankOfQuestion { Id = 127, QuestionText = "The particle nature of light is demonstrated by the:", OptionA = "Diffraction effect", OptionB = "Interference effect", OptionC = "Photoelectric effect", OptionD = "Refraction effect", CorrectAnswer = "C", ExamId = 26 },
                new BankOfQuestion { Id = 128, QuestionText = "Light is a form of ___ radiation.", OptionA = "Acoustic", OptionB = "Nuclear", OptionC = "Electromagnetic", OptionD = "Thermal", CorrectAnswer = "C", ExamId = 26 },
                new BankOfQuestion { Id = 129, QuestionText = "Which color of visible light has the longest wavelength?", OptionA = "Violet", OptionB = "Blue", OptionC = "Green", OptionD = "Red", CorrectAnswer = "D", ExamId = 26 },
                new BankOfQuestion { Id = 130, QuestionText = "The speed of light in a vacuum (c) is approximately:", OptionA = "3 x 10^6 m/s", OptionB = "3 x 10^8 m/s", OptionC = "3 x 10^10 m/s", OptionD = "340 m/s", CorrectAnswer = "B", ExamId = 26 },

                // --- Questions for Exam 27 (lessonId = 53, Lenses and Image Formation) ---
                new BankOfQuestion { Id = 131, QuestionText = "A lens that converges parallel light rays to a focal point is a:", OptionA = "Converging (Convex) lens", OptionB = "Diverging (Concave) lens", OptionC = "Plane mirror", OptionD = "Prism", CorrectAnswer = "A", ExamId = 27 },
                new BankOfQuestion { Id = 132, QuestionText = "A lens that spreads out parallel light rays appears to originate from a focal point is a:", OptionA = "Converging (Convex) lens", OptionB = "Diverging (Concave) lens", OptionC = "Convex mirror", OptionD = "Diffraction grating", CorrectAnswer = "B", ExamId = 27 },
                new BankOfQuestion { Id = 133, QuestionText = "An image formed where light rays actually converge is called a ___ image.", OptionA = "Virtual", OptionB = "Real", OptionC = "Inverted", OptionD = "Magnified", CorrectAnswer = "B", ExamId = 27 },
                new BankOfQuestion { Id = 134, QuestionText = "An image formed where light rays only appear to diverge from is called a ___ image.", OptionA = "Virtual", OptionB = "Real", OptionC = "Upright", OptionD = "Diminished", CorrectAnswer = "A", ExamId = 27 },
                new BankOfQuestion { Id = 135, QuestionText = "The thin lens equation relates object distance (p), image distance (q), and focal length (f) as:", OptionA = "1/p - 1/q = 1/f", OptionB = "p + q = f", OptionC = "1/p + 1/q = 1/f", OptionD = "p*q = f", CorrectAnswer = "C", ExamId = 27 },

                // --- Questions for Exam 28 (lessonId = 55, Wave Optics: Diffraction) ---
                new BankOfQuestion { Id = 136, QuestionText = "Diffraction is the bending of waves as they pass through an opening or around an obstacle.", OptionA = "Reflection", OptionB = "Refraction", OptionC = "Diffraction", OptionD = "Interference", CorrectAnswer = "C", ExamId = 28 },
                new BankOfQuestion { Id = 137, QuestionText = "Diffraction effects are most noticeable when the wavelength of the wave is ___ the size of the opening or obstacle.", OptionA = "Much smaller than", OptionB = "Much larger than", OptionC = "Comparable to", OptionD = "Unrelated to", CorrectAnswer = "C", ExamId = 28 },
                new BankOfQuestion { Id = 138, QuestionText = "When light passes through a single narrow slit, it produces a central bright fringe that is ___ than the other bright fringes.", OptionA = "Narrower and dimmer", OptionB = "Wider and brighter", OptionC = "The same width and brightness", OptionD = "Absent", CorrectAnswer = "B", ExamId = 28 },
                new BankOfQuestion { Id = 139, QuestionText = "A diffraction grating consists of many closely spaced:", OptionA = "Lenses", OptionB = "Mirrors", OptionC = "Prisms", OptionD = "Slits or lines", CorrectAnswer = "D", ExamId = 28 },
                new BankOfQuestion { Id = 140, QuestionText = "Diffraction limits the ___ of optical instruments like telescopes and microscopes.", OptionA = "Magnification", OptionB = "Brightness", OptionC = "Resolution (ability to distinguish details)", OptionD = "Color accuracy", CorrectAnswer = "C", ExamId = 28 },

                // --- Questions for Exam 29 (lessonId = 57, First Law of Thermodynamics) ---
                new BankOfQuestion { Id = 141, QuestionText = "The First Law of Thermodynamics is a statement of the conservation of:", OptionA = "Mass", OptionB = "Momentum", OptionC = "Charge", OptionD = "Energy", CorrectAnswer = "D", ExamId = 29 },
                new BankOfQuestion { Id = 142, QuestionText = "The change in internal energy (ΔU) of a system equals the heat (Q) added to the system minus the ___ (W) done by the system.", OptionA = "Work", OptionB = "Temperature", OptionC = "Pressure", OptionD = "Volume", CorrectAnswer = "A", ExamId = 29 },
                new BankOfQuestion { Id = 143, QuestionText = "Internal energy (U) refers to the total ___ energy of the molecules within a system.", OptionA = "Potential only", OptionB = "Kinetic only", OptionC = "Kinetic and Potential", OptionD = "External", CorrectAnswer = "C", ExamId = 29 },
                new BankOfQuestion { Id = 144, QuestionText = "In an adiabatic process, what is equal to zero?", OptionA = "Change in Internal Energy (ΔU)", OptionB = "Work done (W)", OptionC = "Heat transfer (Q)", OptionD = "Change in Temperature (ΔT)", CorrectAnswer = "C", ExamId = 29 },
                new BankOfQuestion { Id = 145, QuestionText = "In an isothermal process, what remains constant?", OptionA = "Pressure", OptionB = "Volume", OptionC = "Temperature", OptionD = "Internal Energy (for ideal gas)", CorrectAnswer = "C", ExamId = 29 },

                // --- Questions for Exam 30 (lessonId = 59, Second Law of Thermodynamics) ---
                new BankOfQuestion { Id = 146, QuestionText = "The Second Law of Thermodynamics deals with the concept of:", OptionA = "Energy conservation", OptionB = "Entropy and the direction of processes", OptionC = "Absolute zero", OptionD = "Pressure-volume relationship", CorrectAnswer = "B", ExamId = 30 },
                new BankOfQuestion { Id = 147, QuestionText = "Entropy is a measure of the ___ or randomness of a system.", OptionA = "Energy", OptionB = "Temperature", OptionC = "Order", OptionD = "Disorder", CorrectAnswer = "D", ExamId = 30 },
                new BankOfQuestion { Id = 148, QuestionText = "The Second Law states that the total entropy of an isolated system tends to ___ over time.", OptionA = "Decrease", OptionB = "Stay constant", OptionC = "Increase", OptionD = "Fluctuate randomly", CorrectAnswer = "C", ExamId = 30 },
                new BankOfQuestion { Id = 149, QuestionText = "Heat naturally flows from a ___ object to a ___ object.", OptionA = "Hotter, Colder", OptionB = "Colder, Hotter", OptionC = "Larger, Smaller", OptionD = "Smaller, Larger", CorrectAnswer = "A", ExamId = 30 },
                new BankOfQuestion { Id = 150, QuestionText = "A heat engine converts ___ energy into ___ work.", OptionA = "Mechanical, Thermal", OptionB = "Thermal, Mechanical", OptionC = "Electrical, Chemical", OptionD = "Chemical, Electrical", CorrectAnswer = "B", ExamId = 30 },

                // --- Questions for Exam 31 (lessonId = 61, Blackbody Radiation) ---
                new BankOfQuestion { Id = 151, QuestionText = "A perfect blackbody is an idealized object that:", OptionA = "Reflects all incident radiation", OptionB = "Absorbs all incident radiation", OptionC = "Transmits all incident radiation", OptionD = "Emits only visible light", CorrectAnswer = "B", ExamId = 31 },
                new BankOfQuestion { Id = 152, QuestionText = "Classical physics failed to explain the observed spectrum of blackbody radiation, leading to the:", OptionA = "Photoelectric effect", OptionB = "Compton effect", OptionC = "Ultraviolet catastrophe", OptionD = "Wave-particle duality", CorrectAnswer = "C", ExamId = 31 },
                new BankOfQuestion { Id = 153, QuestionText = "Max Planck proposed that energy is quantized, meaning it can only be emitted or absorbed in discrete packets called:", OptionA = "Electrons", OptionB = "Protons", OptionC = "Waves", OptionD = "Quanta (photons)", CorrectAnswer = "D", ExamId = 31 },
                new BankOfQuestion { Id = 154, QuestionText = "The energy of a quantum (photon) is proportional to its:", OptionA = "Wavelength", OptionB = "Frequency", OptionC = "Amplitude", OptionD = "Speed", CorrectAnswer = "B", ExamId = 31 },
                new BankOfQuestion { Id = 155, QuestionText = "Planck's constant (h) relates the energy of a photon to its:", OptionA = "Mass", OptionB = "Charge", OptionC = "Frequency", OptionD = "Wavelength", CorrectAnswer = "C", ExamId = 31 },

                // --- Questions for Exam 32 (lessonId = 63, Wave Nature of Matter) ---
                new BankOfQuestion { Id = 156, QuestionText = "Who proposed that particles, like electrons, could exhibit wave-like properties?", OptionA = "Albert Einstein", OptionB = "Max Planck", OptionC = "Louis de Broglie", OptionD = "Niels Bohr", CorrectAnswer = "C", ExamId = 32 },
                new BankOfQuestion { Id = 157, QuestionText = "The de Broglie wavelength of a particle is inversely proportional to its:", OptionA = "Mass", OptionB = "Velocity", OptionC = "Momentum", OptionD = "Energy", CorrectAnswer = "C", ExamId = 32 },
                new BankOfQuestion { Id = 158, QuestionText = "The wave nature of electrons was experimentally confirmed by observing:", OptionA = "Photoelectric effect", OptionB = "Electron diffraction", OptionC = "Blackbody radiation", OptionD = "Atomic spectra", CorrectAnswer = "B", ExamId = 32 },
                new BankOfQuestion { Id = 159, QuestionText = "Wave-particle duality means that entities like light and electrons exhibit:", OptionA = "Only wave properties", OptionB = "Only particle properties", OptionC = "Both wave and particle properties", OptionD = "Neither wave nor particle properties", CorrectAnswer = "C", ExamId = 32 },
                new BankOfQuestion { Id = 160, QuestionText = "For macroscopic objects (like a baseball), the de Broglie wavelength is:", OptionA = "Very large and easily observable", OptionB = "Comparable to visible light", OptionC = "Extremely small and negligible", OptionD = "Zero", CorrectAnswer = "C", ExamId = 32 },

                // --- Questions for Exam 33 (lessonId = 65, Introduction to Quantum Mechanics) ---
                new BankOfQuestion { Id = 161, QuestionText = "The fundamental equation of non-relativistic quantum mechanics is the:", OptionA = "Newton's equation (F=ma)", OptionB = "Maxwell's equations", OptionC = "Schrödinger equation", OptionD = "Einstein's field equations", CorrectAnswer = "C", ExamId = 33 },
                new BankOfQuestion { Id = 162, QuestionText = "In quantum mechanics, the state of a particle is described by its:", OptionA = "Position and momentum", OptionB = "Wave function (Ψ)", OptionC = "Energy level", OptionD = "Spin", CorrectAnswer = "B", ExamId = 33 },
                new BankOfQuestion { Id = 163, QuestionText = "The square of the magnitude of the wave function (|Ψ|^2) represents:", OptionA = "Energy density", OptionB = "Momentum density", OptionC = "Probability density of finding the particle", OptionD = "Charge density", CorrectAnswer = "C", ExamId = 33 },
                new BankOfQuestion { Id = 164, QuestionText = "Heisenberg's Uncertainty Principle states that you cannot simultaneously know both the exact ___ and ___ of a particle.", OptionA = "Position, Energy", OptionB = "Position, Momentum", OptionC = "Energy, Time", OptionD = "Spin, Charge", CorrectAnswer = "B", ExamId = 33 },
                new BankOfQuestion { Id = 165, QuestionText = "Quantum tunneling refers to a particle's ability to:", OptionA = "Travel faster than light", OptionB = "Pass through a potential barrier it classically shouldn't overcome", OptionC = "Exist in multiple places at once", OptionD = "Split into two particles", CorrectAnswer = "B", ExamId = 33 },

                // --- Questions for Exam 34 (lessonId = 67, Time Dilation and Length Contraction) ---
                new BankOfQuestion { Id = 166, QuestionText = "Time dilation is a consequence of:", OptionA = "General Relativity", OptionB = "Special Relativity", OptionC = "Quantum Mechanics", OptionD = "Newtonian Mechanics", CorrectAnswer = "B", ExamId = 34 },
                new BankOfQuestion { Id = 167, QuestionText = "According to time dilation, time for a moving observer appears to pass ___ compared to a stationary observer.", OptionA = "Faster", OptionB = "Slower", OptionC = "At the same rate", OptionD = "Backward", CorrectAnswer = "B", ExamId = 34 },
                new BankOfQuestion { Id = 168, QuestionText = "Length contraction means that an object moving at relativistic speeds appears ___ in the direction of motion to a stationary observer.", OptionA = "Longer", OptionB = "Wider", OptionC = "Shorter", OptionD = "Unchanged", CorrectAnswer = "C", ExamId = 34 },
                new BankOfQuestion { Id = 169, QuestionText = "These relativistic effects become significant only at speeds close to:", OptionA = "The speed of sound", OptionB = "Escape velocity", OptionC = "The speed of light", OptionD = "Orbital velocity", CorrectAnswer = "C", ExamId = 34 },
                new BankOfQuestion { Id = 170, QuestionText = "The twin paradox involves one twin traveling at relativistic speed. When they reunite, the traveling twin is ___.", OptionA = "Older", OptionB = "Younger", OptionC = "The same age", OptionD = "It's impossible to say", CorrectAnswer = "B", ExamId = 34 },

                // --- Questions for Exam 35 (lessonId = 69, Physics Comprehensive Exam) ---
                new BankOfQuestion { Id = 171, QuestionText = "General Relativity, developed by Einstein, is a theory of:", OptionA = "Electromagnetism", OptionB = "Quantum Mechanics", OptionC = "Gravitation", OptionD = "Thermodynamics", CorrectAnswer = "C", ExamId = 35 },
                new BankOfQuestion { Id = 172, QuestionText = "The Principle of Equivalence states that ___ is indistinguishable from acceleration.", OptionA = "Velocity", OptionB = "Gravity", OptionC = "Mass", OptionD = "Time", CorrectAnswer = "B", ExamId = 35 },
                new BankOfQuestion { Id = 173, QuestionText = "General Relativity describes gravity not as a force, but as a curvature of:", OptionA = "Electric fields", OptionB = "Magnetic fields", OptionC = "Spacetime", OptionD = "Energy levels", CorrectAnswer = "C", ExamId = 35 },
                new BankOfQuestion { Id = 174, QuestionText = "What causes the curvature of spacetime, according to General Relativity?", OptionA = "Charge", OptionB = "Mass and Energy", OptionC = "Velocity", OptionD = "Spin", CorrectAnswer = "B", ExamId = 35 },
                new BankOfQuestion { Id = 175, QuestionText = "Which phenomenon provides observational evidence for General Relativity?", OptionA = "Photoelectric effect", OptionB = "Gravitational lensing", OptionC = "Electron diffraction", OptionD = "Blackbody radiation", CorrectAnswer = "B", ExamId = 35 },

                // --- Questions for Exam 36 (lessonId = 71, Introduction to Cells) ---
                new BankOfQuestion { Id = 176, QuestionText = "Which cell type lacks a true nucleus and membrane-bound organelles?", OptionA = "Eukaryotic", OptionB = "Prokaryotic", OptionC = "Plant cell", OptionD = "Animal cell", CorrectAnswer = "B", ExamId = 36 },
                new BankOfQuestion { Id = 177, QuestionText = "Which cell type has a nucleus and membrane-bound organelles?", OptionA = "Eukaryotic", OptionB = "Prokaryotic", OptionC = "Bacterial cell", OptionD = "Archaeal cell", CorrectAnswer = "A", ExamId = 36 },
                new BankOfQuestion { Id = 178, QuestionText = "The basic structural and functional unit of all known organisms is the:", OptionA = "Organ", OptionB = "Tissue", OptionC = "Molecule", OptionD = "Cell", CorrectAnswer = "D", ExamId = 36 },
                new BankOfQuestion { Id = 179, QuestionText = "Which of these is found in plant cells but not typically in animal cells?", OptionA = "Nucleus", OptionB = "Mitochondria", OptionC = "Cell Wall", OptionD = "Cell membrane", CorrectAnswer = "C", ExamId = 36 },
                new BankOfQuestion { Id = 180, QuestionText = "The semi-fluid substance filling the cell, enclosing the organelles, is the:", OptionA = "Nucleus", OptionB = "Cytoplasm", OptionC = "Cell membrane", OptionD = "Cell wall", CorrectAnswer = "B", ExamId = 36 },

                // --- Questions for Exam 37 (lessonId = 73, Eukaryotic Organelles) ---
                new BankOfQuestion { Id = 181, QuestionText = "Which organelle contains the cell's genetic material (DNA)?", OptionA = "Ribosome", OptionB = "Mitochondrion", OptionC = "Nucleus", OptionD = "Endoplasmic Reticulum", CorrectAnswer = "C", ExamId = 37 },
                new BankOfQuestion { Id = 182, QuestionText = "Which organelle is responsible for generating most of the cell's ATP through cellular respiration?", OptionA = "Lysosome", OptionB = "Mitochondrion", OptionC = "Golgi apparatus", OptionD = "Chloroplast", CorrectAnswer = "B", ExamId = 37 },
                new BankOfQuestion { Id = 183, QuestionText = "Which organelle is the site of protein synthesis?", OptionA = "Nucleus", OptionB = "Vacuole", OptionC = "Ribosome", OptionD = "Peroxisome", CorrectAnswer = "C", ExamId = 37 },
                new BankOfQuestion { Id = 184, QuestionText = "Which organelle modifies, sorts, and packages proteins and lipids for secretion or delivery?", OptionA = "Endoplasmic Reticulum", OptionB = "Golgi apparatus", OptionC = "Lysosome", OptionD = "Mitochondrion", CorrectAnswer = "B", ExamId = 37 },
                new BankOfQuestion { Id = 185, QuestionText = "Which organelle, found in plant cells and algae, is the site of photosynthesis?", OptionA = "Mitochondrion", OptionB = "Chloroplast", OptionC = "Vacuole", OptionD = "Cell Wall", CorrectAnswer = "B", ExamId = 37 },

                // --- Questions for Exam 38 (lessonId = 75, The Cell Cycle and Mitosis) ---
                new BankOfQuestion { Id = 186, QuestionText = "The phase of the cell cycle where the cell grows and replicates its DNA is called:", OptionA = "Mitosis", OptionB = "Cytokinesis", OptionC = "Interphase", OptionD = "Meiosis", CorrectAnswer = "C", ExamId = 38 },
                new BankOfQuestion { Id = 187, QuestionText = "Mitosis is the process of:", OptionA = "DNA replication", OptionB = "Cell growth", OptionC = "Nuclear division", OptionD = "Cytoplasm division", CorrectAnswer = "C", ExamId = 38 },
                new BankOfQuestion { Id = 188, QuestionText = "During which phase of mitosis do chromosomes condense and become visible?", OptionA = "Metaphase", OptionB = "Anaphase", OptionC = "Telophase", OptionD = "Prophase", CorrectAnswer = "D", ExamId = 38 },
                new BankOfQuestion { Id = 189, QuestionText = "During which phase of mitosis do chromosomes line up along the center of the cell?", OptionA = "Prophase", OptionB = "Metaphase", OptionC = "Anaphase", OptionD = "Telophase", CorrectAnswer = "B", ExamId = 38 },
                new BankOfQuestion { Id = 190, QuestionText = "The division of the cytoplasm to form two separate daughter cells is called:", OptionA = "Interphase", OptionB = "Mitosis", OptionC = "Cytokinesis", OptionD = "Meiosis", CorrectAnswer = "C", ExamId = 38 },

                // --- Questions for Exam 39 (lessonId = 77, DNA Structure and Replication) ---
                new BankOfQuestion { Id = 191, QuestionText = "DNA stands for:", OptionA = "Deoxyribonucleic Acid", OptionB = "Ribonucleic Acid", OptionC = "Dioxygen Nucleic Acid", OptionD = "Double Nucleotide Axis", CorrectAnswer = "A", ExamId = 39 },
                new BankOfQuestion { Id = 192, QuestionText = "The structure of DNA is described as a:", OptionA = "Single helix", OptionB = "Double helix", OptionC = "Triple helix", OptionD = "Beta sheet", CorrectAnswer = "B", ExamId = 39 },
                new BankOfQuestion { Id = 193, QuestionText = "In DNA base pairing, Adenine (A) always pairs with:", OptionA = "Guanine (G)", OptionB = "Cytosine (C)", OptionC = "Thymine (T)", OptionD = "Uracil (U)", CorrectAnswer = "C", ExamId = 39 },
                new BankOfQuestion { Id = 194, QuestionText = "In DNA base pairing, Guanine (G) always pairs with:", OptionA = "Adenine (A)", OptionB = "Cytosine (C)", OptionC = "Thymine (T)", OptionD = "Uracil (U)", CorrectAnswer = "B", ExamId = 39 },
                new BankOfQuestion { Id = 195, QuestionText = "DNA replication is described as semi-conservative because each new DNA molecule consists of:", OptionA = "Two new strands", OptionB = "Two original strands", OptionC = "One new strand and one original strand", OptionD = "Random segments of old and new", CorrectAnswer = "C", ExamId = 39 },

                // --- Questions for Exam 40 (lessonId = 79, Gene Expression: Translation) ---
                new BankOfQuestion { Id = 196, QuestionText = "Translation is the process of synthesizing ___ from a(n) ___ template.", OptionA = "DNA, RNA", OptionB = "RNA, DNA", OptionC = "Protein, RNA", OptionD = "RNA, Protein", CorrectAnswer = "C", ExamId = 40 },
                new BankOfQuestion { Id = 197, QuestionText = "Where does translation occur in a eukaryotic cell?", OptionA = "Nucleus", OptionB = "Mitochondrion", OptionC = "Ribosome (in cytoplasm)", OptionD = "Golgi apparatus", CorrectAnswer = "C", ExamId = 40 },
                new BankOfQuestion { Id = 198, QuestionText = "A sequence of three nucleotides on mRNA that specifies an amino acid is called a:", OptionA = "Gene", OptionB = "Anticodon", OptionC = "Codon", OptionD = "Exon", CorrectAnswer = "C", ExamId = 40 },
                new BankOfQuestion { Id = 199, QuestionText = "Which type of RNA carries amino acids to the ribosome during translation?", OptionA = "mRNA (messenger RNA)", OptionB = "tRNA (transfer RNA)", OptionC = "rRNA (ribosomal RNA)", OptionD = "snRNA (small nuclear RNA)", CorrectAnswer = "B", ExamId = 40 },
                new BankOfQuestion { Id = 200, QuestionText = "The process starts when the ribosome binds to the mRNA and finds the ___ codon.", OptionA = "Stop", OptionB = "Start (usually AUG)", OptionC = "Anticodon", OptionD = "Promoter", CorrectAnswer = "B", ExamId = 40 },

                // --- Questions for Exam 41 (lessonId = 81, Skeletal Systems) ---
                new BankOfQuestion { Id = 201, QuestionText = "Which is NOT a primary function of the skeletal system?", OptionA = "Support", OptionB = "Protection of organs", OptionC = "Movement (with muscles)", OptionD = "Digestion of food", CorrectAnswer = "D", ExamId = 41 },
                new BankOfQuestion { Id = 202, QuestionText = "The human skeleton is an example of an:", OptionA = "Exoskeleton", OptionB = "Endoskeleton", OptionC = "Hydrostatic skeleton", OptionD = "No skeleton", CorrectAnswer = "B", ExamId = 41 },
                new BankOfQuestion { Id = 203, QuestionText = "Bones are primarily composed of calcium phosphate and a protein called:", OptionA = "Keratin", OptionB = "Collagen", OptionC = "Actin", OptionD = "Myosin", CorrectAnswer = "B", ExamId = 41 },
                new BankOfQuestion { Id = 204, QuestionText = "The place where two or more bones meet is called a:", OptionA = "Tendon", OptionB = "Ligament", OptionC = "Joint", OptionD = "Cartilage", CorrectAnswer = "C", ExamId = 41 },
                new BankOfQuestion { Id = 205, QuestionText = "Red bone marrow is responsible for producing:", OptionA = "Fat cells", OptionB = "Cartilage", OptionC = "Blood cells", OptionD = "Nerve cells", CorrectAnswer = "C", ExamId = 41 },

                // --- Questions for Exam 42 (lessonId = 83, Biomechanics Basics) ---
                new BankOfQuestion { Id = 206, QuestionText = "Biomechanics applies the principles of ___ to biological systems.", OptionA = "Chemistry", OptionB = "Genetics", OptionC = "Ecology", OptionD = "Mechanics (Physics)", CorrectAnswer = "D", ExamId = 42 },
                new BankOfQuestion { Id = 207, QuestionText = "A lever system in the body consists of a rigid bar (bone), a pivot point (joint), and:", OptionA = "Effort (muscle force) and Load (resistance)", OptionB = "Only Effort", OptionC = "Only Load", OptionD = "Blood vessels", CorrectAnswer = "A", ExamId = 42 },
                new BankOfQuestion { Id = 208, QuestionText = "Forces acting on the body can cause:", OptionA = "Only movement", OptionB = "Only deformation", OptionC = "Both movement and deformation", OptionD = "Only temperature change", CorrectAnswer = "C", ExamId = 42 },
                new BankOfQuestion { Id = 209, QuestionText = "Analyzing the forces involved in activities like walking or jumping is part of:", OptionA = "Cell biology", OptionB = "Genetics", OptionC = "Biomechanics", OptionD = "Taxonomy", CorrectAnswer = "C", ExamId = 42 },
                new BankOfQuestion { Id = 210, QuestionText = "Stress in biomechanics refers to:", OptionA = "Mental anxiety", OptionB = "Force applied per unit area", OptionC = "Change in length", OptionD = "Rate of movement", CorrectAnswer = "B", ExamId = 42 },

                // --- Questions for Exam 43 (lessonId = 85, Nervous System Control of Movement) ---
                new BankOfQuestion { Id = 211, QuestionText = "Which part of the nervous system sends signals from the brain/spinal cord to muscles?", OptionA = "Sensory neurons", OptionB = "Motor neurons", OptionC = "Interneurons", OptionD = "Glial cells", CorrectAnswer = "B", ExamId = 43 },
                new BankOfQuestion { Id = 212, QuestionText = "The junction where a motor neuron communicates with a muscle fiber is the:", OptionA = "Synapse", OptionB = "Neuromuscular junction", OptionC = "Axon terminal", OptionD = "Dendrite", CorrectAnswer = "B", ExamId = 43 },
                new BankOfQuestion { Id = 213, QuestionText = "A rapid, involuntary response to a stimulus is called a:", OptionA = "Voluntary action", OptionB = "Reflex", OptionC = "Thought", OptionD = "Habit", CorrectAnswer = "B", ExamId = 43 },
                new BankOfQuestion { Id = 214, QuestionText = "Which part of the brain is primarily responsible for coordinating voluntary movements and balance?", OptionA = "Cerebrum", OptionB = "Cerebellum", OptionC = "Brainstem", OptionD = "Thalamus", CorrectAnswer = "B", ExamId = 43 },
                new BankOfQuestion { Id = 215, QuestionText = "Muscle contraction is initiated by the release of a neurotransmitter called ___ at the neuromuscular junction.", OptionA = "Serotonin", OptionB = "Dopamine", OptionC = "Acetylcholine", OptionD = "GABA", CorrectAnswer = "C", ExamId = 43 },

                // --- Questions for Exam 44 (lessonId = 87, Population Ecology) ---
                new BankOfQuestion { Id = 216, QuestionText = "Population ecology studies the dynamics of:", OptionA = "Individual organisms", OptionB = "Species populations", OptionC = "Entire ecosystems", OptionD = "Global climate", CorrectAnswer = "B", ExamId = 44 },
                new BankOfQuestion { Id = 217, QuestionText = "Unrestricted population growth with unlimited resources follows a(n) ___ growth model.", OptionA = "Logistic", OptionB = "Exponential", OptionC = "Linear", OptionD = "Logarithmic", CorrectAnswer = "B", ExamId = 44 },
                new BankOfQuestion { Id = 218, QuestionText = "The maximum population size that an environment can sustain indefinitely is the:", OptionA = "Growth rate (r)", OptionB = "Carrying capacity (K)", OptionC = "Population density", OptionD = "Biotic potential", CorrectAnswer = "B", ExamId = 44 },
                new BankOfQuestion { Id = 219, QuestionText = "Factors like disease or competition, whose effects intensify as population density increases, are:", OptionA = "Density-independent", OptionB = "Density-dependent", OptionC = "Abiotic factors", OptionD = "Random factors", CorrectAnswer = "B", ExamId = 44 },
                new BankOfQuestion { Id = 220, QuestionText = "Factors like natural disasters (fire, flood), whose effects are independent of population density, are:", OptionA = "Density-dependent", OptionB = "Biotic factors", OptionC = "Density-independent", OptionD = "Competitive factors", CorrectAnswer = "C", ExamId = 44 },

                // --- Questions for Exam 45 (lessonId = 89, Ecosystem Dynamics) ---
                new BankOfQuestion { Id = 221, QuestionText = "An ecosystem includes all the living organisms (biotic factors) and the ___ components in an area.", OptionA = "Only plant", OptionB = "Only animal", OptionC = "Non-living (abiotic)", OptionD = "Microscopic", CorrectAnswer = "C", ExamId = 45 },
                new BankOfQuestion { Id = 222, QuestionText = "The flow of energy in most ecosystems originates from:", OptionA = "Decomposers", OptionB = "The sun", OptionC = "Chemical bonds", OptionD = "Geothermal heat", CorrectAnswer = "B", ExamId = 45 },
                new BankOfQuestion { Id = 223, QuestionText = "Organisms that produce their own food (like plants) are called:", OptionA = "Consumers", OptionB = "Producers (Autotrophs)", OptionC = "Decomposers", OptionD = "Herbivores", CorrectAnswer = "B", ExamId = 45 },
                new BankOfQuestion { Id = 224, QuestionText = "A sequence showing how energy is transferred from one living organism to another is a:", OptionA = "Food web", OptionB = "Food chain", OptionC = "Biogeochemical cycle", OptionD = "Trophic level", CorrectAnswer = "B", ExamId = 45 },
                new BankOfQuestion { Id = 225, QuestionText = "Biogeochemical cycles describe the movement of ___ through an ecosystem.", OptionA = "Energy only", OptionB = "Organisms", OptionC = "Chemical elements/Nutrients", OptionD = "Water only", CorrectAnswer = "C", ExamId = 45 },

                // --- Questions for Exam 46 (lessonId = 91, Plant Structure and Growth) ---
                new BankOfQuestion { Id = 226, QuestionText = "Which plant part typically anchors the plant and absorbs water and nutrients?", OptionA = "Leaf", OptionB = "Stem", OptionC = "Flower", OptionD = "Root", CorrectAnswer = "D", ExamId = 46 },
                new BankOfQuestion { Id = 227, QuestionText = "Which plant part typically supports the leaves and flowers and transports substances?", OptionA = "Root", OptionB = "Leaf", OptionC = "Stem", OptionD = "Seed", CorrectAnswer = "C", ExamId = 46 },
                new BankOfQuestion { Id = 228, QuestionText = "The primary site of photosynthesis in most plants is the:", OptionA = "Root", OptionB = "Stem", OptionC = "Leaf", OptionD = "Flower", CorrectAnswer = "C", ExamId = 46 },
                new BankOfQuestion { Id = 229, QuestionText = "Regions of actively dividing cells responsible for plant growth are called:", OptionA = "Vascular tissues", OptionB = "Epidermis", OptionC = "Meristems", OptionD = "Ground tissues", CorrectAnswer = "C", ExamId = 46 },
                new BankOfQuestion { Id = 230, QuestionText = "Primary growth increases the ___ of a plant, while secondary growth increases its ___.", OptionA = "Width, Length", OptionB = "Length, Width", OptionC = "Height, Depth", OptionD = "Color, Texture", CorrectAnswer = "B", ExamId = 46 },

                // --- Questions for Exam 47 (lessonId = 93, Photosynthesis) ---
                new BankOfQuestion { Id = 231, QuestionText = "Photosynthesis uses sunlight, water, and ___ to produce glucose and oxygen.", OptionA = "Nitrogen", OptionB = "Carbon Dioxide", OptionC = "Oxygen", OptionD = "Hydrogen", CorrectAnswer = "B", ExamId = 47 },
                new BankOfQuestion { Id = 232, QuestionText = "The green pigment in plants that captures light energy is:", OptionA = "Carotene", OptionB = "Xanthophyll", OptionC = "Chlorophyll", OptionD = "Anthocyanin", CorrectAnswer = "C", ExamId = 47 },
                new BankOfQuestion { Id = 233, QuestionText = "Where do the light-dependent reactions of photosynthesis occur?", OptionA = "Stroma", OptionB = "Thylakoid membranes (within chloroplasts)", OptionC = "Cytoplasm", OptionD = "Mitochondria", CorrectAnswer = "B", ExamId = 47 },
                new BankOfQuestion { Id = 234, QuestionText = "Where does the Calvin cycle (light-independent reactions) occur?", OptionA = "Thylakoid membranes", OptionB = "Stroma (within chloroplasts)", OptionC = "Nucleus", OptionD = "Cell wall", CorrectAnswer = "B", ExamId = 47 },
                new BankOfQuestion { Id = 235, QuestionText = "The primary product of the Calvin cycle is:", OptionA = "Oxygen", OptionB = "ATP", OptionC = "NADPH", OptionD = "Glucose (or precursors)", CorrectAnswer = "D", ExamId = 47 },

                // --- Questions for Exam 48 (lessonId = 95, Plant Hormones and Responses) ---
                new BankOfQuestion { Id = 236, QuestionText = "Chemical messengers that regulate plant growth and development are called:", OptionA = "Enzymes", OptionB = "Pigments", OptionC = "Hormones (Phytohormones)", OptionD = "Neurotransmitters", CorrectAnswer = "C", ExamId = 48 },
                new BankOfQuestion { Id = 237, QuestionText = "Which hormone is primarily responsible for cell elongation and apical dominance?", OptionA = "Gibberellin", OptionB = "Cytokinin", OptionC = "Auxin", OptionD = "Abscisic acid", CorrectAnswer = "C", ExamId = 48 },
                new BankOfQuestion { Id = 238, QuestionText = "A plant's growth response towards a light source is called:", OptionA = "Gravitropism", OptionB = "Thigmotropism", OptionC = "Phototropism", OptionD = "Hydrotropism", CorrectAnswer = "C", ExamId = 48 },
                new BankOfQuestion { Id = 239, QuestionText = "A plant's growth response to gravity is called:", OptionA = "Phototropism", OptionB = "Gravitropism (Geotropism)", OptionC = "Thigmotropism", OptionD = "Nastic movement", CorrectAnswer = "B", ExamId = 48 },
                new BankOfQuestion { Id = 240, QuestionText = "Which hormone promotes seed germination and stem elongation?", OptionA = "Auxin", OptionB = "Ethylene", OptionC = "Abscisic acid", OptionD = "Gibberellin", CorrectAnswer = "D", ExamId = 48 },

                // --- Questions for Exam 49 (lessonId = 97, Invertebrate Zoology I) ---
                new BankOfQuestion { Id = 241, QuestionText = "Animals lacking a backbone are classified as:", OptionA = "Vertebrates", OptionB = "Chordates", OptionC = "Invertebrates", OptionD = "Mammals", CorrectAnswer = "C", ExamId = 49 },
                new BankOfQuestion { Id = 242, QuestionText = "Which phylum includes simple, porous animals like sponges?", OptionA = "Cnidaria", OptionB = "Platyhelminthes", OptionC = "Porifera", OptionD = "Nematoda", CorrectAnswer = "C", ExamId = 49 },
                new BankOfQuestion { Id = 243, QuestionText = "Jellyfish, corals, and anemones belong to which phylum, characterized by stinging cells (cnidocytes)?", OptionA = "Porifera", OptionB = "Cnidaria", OptionC = "Mollusca", OptionD = "Annelida", CorrectAnswer = "B", ExamId = 49 },
                new BankOfQuestion { Id = 244, QuestionText = "Flatworms, such as planarians and tapeworms, belong to the phylum:", OptionA = "Nematoda", OptionB = "Annelida", OptionC = "Platyhelminthes", OptionD = "Arthropoda", CorrectAnswer = "C", ExamId = 49 },
                new BankOfQuestion { Id = 245, QuestionText = "Roundworms, often parasitic, are members of the phylum:", OptionA = "Platyhelminthes", OptionB = "Annelida", OptionC = "Cnidaria", OptionD = "Nematoda", CorrectAnswer = "D", ExamId = 49 },

                // --- Questions for Exam 50 (lessonId = 99, Vertebrate Zoology I) ---
                new BankOfQuestion { Id = 246, QuestionText = "Vertebrates belong to the phylum:", OptionA = "Arthropoda", OptionB = "Mollusca", OptionC = "Chordata", OptionD = "Echinodermata", CorrectAnswer = "C", ExamId = 50 },
                new BankOfQuestion { Id = 247, QuestionText = "Which is NOT a defining characteristic of chordates (at some life stage)?", OptionA = "Notochord", OptionB = "Dorsal hollow nerve cord", OptionC = "Exoskeleton", OptionD = "Pharyngeal slits", CorrectAnswer = "C", ExamId = 50 },
                new BankOfQuestion { Id = 248, QuestionText = "Fish are aquatic vertebrates characterized by:", OptionA = "Lungs and feathers", OptionB = "Gills and fins", OptionC = "Mammary glands and hair", OptionD = "Scaly skin and amniotic eggs", CorrectAnswer = "B", ExamId = 50 },
                new BankOfQuestion { Id = 249, QuestionText = "The two major groups of living fish are the cartilaginous fish (e.g., sharks) and the ___ fish.", OptionA = "Jawless", OptionB = "Bony", OptionC = "Lobe-finned", OptionD = "Ray-finned", CorrectAnswer = "B", ExamId = 50 },
                new BankOfQuestion { Id = 250, QuestionText = "Most fish utilize ___ for gas exchange.", OptionA = "Lungs", OptionB = "Skin", OptionC = "Gills", OptionD = "Spiracles", CorrectAnswer = "C", ExamId = 50 },

                // --- Questions for Exam 51 (lessonId = 101, Introduction to Microbes) ---
                new BankOfQuestion { Id = 251, QuestionText = "Microbiology is the study of organisms too small to be seen with the naked eye, called:", OptionA = "Animals", OptionB = "Plants", OptionC = "Microorganisms (Microbes)", OptionD = "Minerals", CorrectAnswer = "C", ExamId = 51 },
                new BankOfQuestion { Id = 252, QuestionText = "Which group of microbes are prokaryotic?", OptionA = "Fungi and Protists", OptionB = "Bacteria and Archaea", OptionC = "Viruses and Prions", OptionD = "Algae and Protozoa", CorrectAnswer = "B", ExamId = 51 },
                new BankOfQuestion { Id = 253, QuestionText = "Which group are acellular infectious agents, consisting of genetic material within a protein coat?", OptionA = "Bacteria", OptionB = "Fungi", OptionC = "Viruses", OptionD = "Protists", CorrectAnswer = "C", ExamId = 51 },
                new BankOfQuestion { Id = 254, QuestionText = "Yeasts and molds belong to which kingdom?", OptionA = "Bacteria", OptionB = "Archaea", OptionC = "Protista", OptionD = "Fungi", CorrectAnswer = "D", ExamId = 51 },
                new BankOfQuestion { Id = 255, QuestionText = "Protists are a diverse group of ___ organisms.", OptionA = "Prokaryotic", OptionB = "Eukaryotic", OptionC = "Viral", OptionD = "Bacterial", CorrectAnswer = "B", ExamId = 51 },

                // --- Questions for Exam 52 (lessonId = 103, Microbial Growth and Metabolism) ---
                new BankOfQuestion { Id = 256, QuestionText = "Most bacteria reproduce asexually through a process called:", OptionA = "Mitosis", OptionB = "Meiosis", OptionC = "Binary Fission", OptionD = "Budding", CorrectAnswer = "C", ExamId = 52 },
                new BankOfQuestion { Id = 257, QuestionText = "The typical bacterial growth curve has four phases: Lag, Log (Exponential), ___, and Death.", OptionA = "Stationary", OptionB = "Growth", OptionC = "Decline", OptionD = "Peak", CorrectAnswer = "A", ExamId = 52 },
                new BankOfQuestion { Id = 258, QuestionText = "During which phase is bacterial growth most rapid?", OptionA = "Lag", OptionB = "Log (Exponential)", OptionC = "Stationary", OptionD = "Death", CorrectAnswer = "B", ExamId = 52 },
                new BankOfQuestion { Id = 259, QuestionText = "Microbes that require oxygen for growth are called:", OptionA = "Obligate anaerobes", OptionB = "Facultative anaerobes", OptionC = "Aerotolerant anaerobes", OptionD = "Obligate aerobes", CorrectAnswer = "D", ExamId = 52 },
                new BankOfQuestion { Id = 260, QuestionText = "Metabolism refers to all the ___ reactions occurring within a cell.", OptionA = "Physical", OptionB = "Chemical", OptionC = "Nuclear", OptionD = "Mechanical", CorrectAnswer = "B", ExamId = 52 },

                // --- Questions for Exam 53 (lessonId = 105, Biology Comprehensive Exam) ---
                new BankOfQuestion { Id = 261, QuestionText = "Microorganisms that cause disease are called:", OptionA = "Decomposers", OptionB = "Producers", OptionC = "Pathogens", OptionD = "Symbionts", CorrectAnswer = "C", ExamId = 53 },
                new BankOfQuestion { Id = 262, QuestionText = "Microbes like bacteria and fungi play a crucial role in ecosystems as:", OptionA = "Primary producers", OptionB = "Top predators", OptionC = "Decomposers", OptionD = "Herbivores", CorrectAnswer = "C", ExamId = 53 },
                new BankOfQuestion { Id = 263, QuestionText = "The use of microorganisms to produce foods like yogurt, cheese, and bread is an example of:", OptionA = "Bioremediation", OptionB = "Pathogenesis", OptionC = "Fermentation", OptionD = "Nitrogen fixation", CorrectAnswer = "C", ExamId = 53 },
                new BankOfQuestion { Id = 264, QuestionText = "Using microbes to clean up pollutants (like oil spills) is called:", OptionA = "Fermentation", OptionB = "Pasteurization", OptionC = "Bioremediation", OptionD = "Vaccination", CorrectAnswer = "C", ExamId = 53 },
                new BankOfQuestion { Id = 265, QuestionText = "Many antibiotics are naturally produced by:", OptionA = "Viruses", OptionB = "Plants", OptionC = "Animals", OptionD = "Microorganisms (bacteria, fungi)", CorrectAnswer = "D", ExamId = 53 },

                // --- Questions for Exam 54 (lessonId = 107, Alkanes and Cycloalkanes) ---
                new BankOfQuestion { Id = 266, QuestionText = "Alkanes are hydrocarbons containing only ___ bonds.", OptionA = "Single", OptionB = "Double", OptionC = "Triple", OptionD = "Single and double", CorrectAnswer = "A", ExamId = 54 },
                new BankOfQuestion { Id = 267, QuestionText = "The general formula for non-cyclic alkanes is:", OptionA = "CnH2n", OptionB = "CnH2n+2", OptionC = "CnH2n-2", OptionD = "CnHn", CorrectAnswer = "B", ExamId = 54 },
                new BankOfQuestion { Id = 268, QuestionText = "What is the IUPAC name for CH4?", OptionA = "Ethane", OptionB = "Propane", OptionC = "Methane", OptionD = "Butane", CorrectAnswer = "C", ExamId = 54 },
                new BankOfQuestion { Id = 269, QuestionText = "Cycloalkanes are alkanes that form a:", OptionA = "Straight chain", OptionB = "Branched chain", OptionC = "Ring structure", OptionD = "Double bond", CorrectAnswer = "C", ExamId = 54 },
                new BankOfQuestion { Id = 270, QuestionText = "Different spatial arrangements of a molecule that result from rotation around single bonds are called:", OptionA = "Isomers", OptionB = "Isotopes", OptionC = "Conformations", OptionD = "Resonance structures", CorrectAnswer = "C", ExamId = 54 },

                // --- Questions for Exam 55 (lessonId = 109, Introduction to Organic Reactions) ---
                new BankOfQuestion { Id = 271, QuestionText = "Organic chemistry focuses on compounds containing which element?", OptionA = "Oxygen", OptionB = "Nitrogen", OptionC = "Carbon", OptionD = "Silicon", CorrectAnswer = "C", ExamId = 55 },
                new BankOfQuestion { Id = 272, QuestionText = "Curved arrows in reaction mechanisms typically show the movement of:", OptionA = "Atoms", OptionB = "Protons", OptionC = "Electrons (usually pairs)", OptionD = "Neutrons", CorrectAnswer = "C", ExamId = 55 },
                new BankOfQuestion { Id = 273, QuestionText = "A species that donates an electron pair is a:", OptionA = "Electrophile", OptionB = "Nucleophile", OptionC = "Radical", OptionD = "Carbocation", CorrectAnswer = "B", ExamId = 55 },
                new BankOfQuestion { Id = 274, QuestionText = "A species that accepts an electron pair is an:", OptionA = "Electrophile", OptionB = "Nucleophile", OptionC = "Carbanion", OptionD = "Alkane", CorrectAnswer = "A", ExamId = 55 },
                new BankOfQuestion { Id = 275, QuestionText = "A reaction energy diagram plots ___ versus reaction progress.", OptionA = "Temperature", OptionB = "Pressure", OptionC = "Concentration", OptionD = "Energy", CorrectAnswer = "D", ExamId = 55 },

                // --- Questions for Exam 56 (lessonId = 111, Atomic Structure and Periodicity) ---
                new BankOfQuestion { Id = 276, QuestionText = "The central part of an atom containing protons and neutrons is the:", OptionA = "Electron cloud", OptionB = "Orbital", OptionC = "Nucleus", OptionD = "Shell", CorrectAnswer = "C", ExamId = 56 },
                new BankOfQuestion { Id = 277, QuestionText = "The number of protons in the nucleus defines the element's:", OptionA = "Mass number", OptionB = "Atomic number", OptionC = "Isotope", OptionD = "Charge", CorrectAnswer = "B", ExamId = 56 },
                new BankOfQuestion { Id = 278, QuestionText = "Electrons occupy specific energy levels or regions around the nucleus called:", OptionA = "Nucleons", OptionB = "Isotopes", OptionC = "Orbitals/Shells", OptionD = "Quarks", CorrectAnswer = "C", ExamId = 56 },
                new BankOfQuestion { Id = 279, QuestionText = "Electronegativity generally ___ across a period (left to right) on the periodic table.", OptionA = "Increases", OptionB = "Decreases", OptionC = "Stays constant", OptionD = "Becomes zero", CorrectAnswer = "A", ExamId = 56 },
                new BankOfQuestion { Id = 280, QuestionText = "Atomic radius generally ___ down a group (top to bottom) on the periodic table.", OptionA = "Decreases", OptionB = "Stays constant", OptionC = "Increases", OptionD = "Becomes negative", CorrectAnswer = "C", ExamId = 56 },

                // --- Questions for Exam 57 (lessonId = 113, Valence Bond and Molecular Orbital Theory) ---
                new BankOfQuestion { Id = 281, QuestionText = "Valence Bond Theory describes covalent bonds as the overlap of:", OptionA = "Nuclei", OptionB = "Inner shell electrons", OptionC = "Atomic orbitals", OptionD = "Molecular orbitals", CorrectAnswer = "C", ExamId = 57 },
                new BankOfQuestion { Id = 282, QuestionText = "The mixing of atomic orbitals to form new hybrid orbitals (like sp, sp2, sp3) is called:", OptionA = "Ionization", OptionB = "Excitation", OptionC = "Hybridization", OptionD = "Resonance", CorrectAnswer = "C", ExamId = 57 },
                new BankOfQuestion { Id = 283, QuestionText = "Molecular Orbital (MO) Theory describes bonding in terms of orbitals that belong to the:", OptionA = "Individual atoms", OptionB = "Entire molecule", OptionC = "Nucleus only", OptionD = "Valence shell only", CorrectAnswer = "B", ExamId = 57 },
                new BankOfQuestion { Id = 284, QuestionText = "In MO theory, combining atomic orbitals forms bonding MOs (lower energy) and ___ MOs (higher energy).", OptionA = "Antibonding", OptionB = "Nonbonding", OptionC = "Hybrid", OptionD = "Sigma", CorrectAnswer = "A", ExamId = 57 },
                new BankOfQuestion { Id = 285, QuestionText = "Which theory better explains the paramagnetism of O2?", OptionA = "Valence Bond Theory", OptionB = "VSEPR Theory", OptionC = "Lewis Theory", OptionD = "Molecular Orbital Theory", CorrectAnswer = "D", ExamId = 57 },

                // --- Questions for Exam 58 (lessonId = 115, Coordination Chemistry Basics) ---
                new BankOfQuestion { Id = 286, QuestionText = "Coordination chemistry primarily involves complexes formed by:", OptionA = "Alkali metals", OptionB = "Halogens", OptionC = "Noble gases", OptionD = "Transition metals", CorrectAnswer = "D", ExamId = 58 },
                new BankOfQuestion { Id = 287, QuestionText = "A central metal ion bonded to surrounding molecules or ions (ligands) forms a:", OptionA = "Salt", OptionB = "Alloy", OptionC = "Coordination complex/Compound", OptionD = "Zwitterion", CorrectAnswer = "C", ExamId = 58 },
                new BankOfQuestion { Id = 288, QuestionText = "Ligands act as ___ by donating electron pairs to the central metal ion.", OptionA = "Lewis acids", OptionB = "Lewis bases", OptionC = "Bronsted acids", OptionD = "Bronsted bases", CorrectAnswer = "B", ExamId = 58 },
                new BankOfQuestion { Id = 289, QuestionText = "The number of donor atoms directly attached to the central metal ion is the:", OptionA = "Oxidation state", OptionB = "Coordination number", OptionC = "Atomic number", OptionD = "Ligand field strength", CorrectAnswer = "B", ExamId = 58 },
                new BankOfQuestion { Id = 290, QuestionText = "Common ligands include H2O, NH3, Cl-, and CN-. Which of these is neutral?", OptionA = "Cl-", OptionB = "CN-", OptionC = "H2O", OptionD = "None are neutral", CorrectAnswer = "C", ExamId = 58 },

                // --- Questions for Exam 59 (lessonId = 117, Thermodynamics: First Law - Physical Chem) ---
                new BankOfQuestion { Id = 291, QuestionText = "The First Law of Thermodynamics mathematically is often written as ΔU = Q + W, where W is work done ___ the system.", OptionA = "By", OptionB = "On", OptionC = "Around", OptionD = "Through", CorrectAnswer = "B", ExamId = 59 },
                new BankOfQuestion { Id = 292, QuestionText = "A property whose value depends only on the current state of the system, not the path taken, is a:", OptionA = "Path function (e.g., Q, W)", OptionB = "State function (e.g., U, H, T, P, V)", OptionC = "Process variable", OptionD = "Constant", CorrectAnswer = "B", ExamId = 59 },
                new BankOfQuestion { Id = 293, QuestionText = "Enthalpy (H) is defined as H = U + ___.", OptionA = "PV", OptionB = "TS", OptionC = "Q", OptionD = "W", CorrectAnswer = "A", ExamId = 59 },
                new BankOfQuestion { Id = 294, QuestionText = "For a reaction at constant pressure, the change in enthalpy (ΔH) is equal to the:", OptionA = "Work done (W)", OptionB = "Heat transferred (Qp)", OptionC = "Change in internal energy (ΔU)", OptionD = "Change in entropy (ΔS)", CorrectAnswer = "B", ExamId = 59 },
                new BankOfQuestion { Id = 295, QuestionText = "Calorimetry is used to measure:", OptionA = "Pressure changes", OptionB = "Volume changes", OptionC = "Heat flow", OptionD = "Reaction rates", CorrectAnswer = "C", ExamId = 59 },

                // --- Questions for Exam 60 (lessonId = 119, Chemical Kinetics) ---
                new BankOfQuestion { Id = 296, QuestionText = "Chemical kinetics is the study of:", OptionA = "Reaction equilibrium", OptionB = "Reaction thermodynamics (spontaneity)", OptionC = "Reaction rates and mechanisms", OptionD = "Atomic structure", CorrectAnswer = "C", ExamId = 60 },
                new BankOfQuestion { Id = 297, QuestionText = "The rate law expresses the reaction rate as a function of:", OptionA = "Temperature only", OptionB = "Product concentrations", OptionC = "Reactant concentrations", OptionD = "Catalyst concentration only", CorrectAnswer = "C", ExamId = 60 },
                new BankOfQuestion { Id = 298, QuestionText = "The minimum energy required for reactants to form products is the:", OptionA = "Enthalpy change (ΔH)", OptionB = "Gibbs free energy change (ΔG)", OptionC = "Activation energy (Ea)", OptionD = "Internal energy (U)", CorrectAnswer = "C", ExamId = 60 },
                new BankOfQuestion { Id = 299, QuestionText = "A substance that increases the reaction rate without being consumed is a:", OptionA = "Reactant", OptionB = "Product", OptionC = "Intermediate", OptionD = "Catalyst", CorrectAnswer = "D", ExamId = 60 },
                new BankOfQuestion { Id = 300, QuestionText = "The Arrhenius equation relates the rate constant (k) to temperature and:", OptionA = "Pressure", OptionB = "Concentration", OptionC = "Activation energy", OptionD = "Entropy", CorrectAnswer = "C", ExamId = 60 },

                // --- Questions for Exam 61 (lessonId = 121, Analytical Intro & Stats) ---
                new BankOfQuestion { Id = 301, QuestionText = "Analytical chemistry deals with the ___, ___, and quantification of chemical substances.", OptionA = "Synthesis, reaction", OptionB = "Separation, identification", OptionC = "Theory, calculation", OptionD = "Safety, disposal", CorrectAnswer = "B", ExamId = 61 },
                new BankOfQuestion { Id = 302, QuestionText = "The closeness of a measurement to the true value is called:", OptionA = "Precision", OptionB = "Accuracy", OptionC = "Resolution", OptionD = "Sensitivity", CorrectAnswer = "B", ExamId = 61 },
                new BankOfQuestion { Id = 303, QuestionText = "The closeness of repeated measurements to each other is called:", OptionA = "Precision", OptionB = "Accuracy", OptionC = "Bias", OptionD = "Significance", CorrectAnswer = "A", ExamId = 61 },
                new BankOfQuestion { Id = 304, QuestionText = "Errors that affect accuracy and have a definite value and assignable cause are:", OptionA = "Random errors", OptionB = "Systematic errors", OptionC = "Gross errors", OptionD = "Statistical errors", CorrectAnswer = "B", ExamId = 61 },
                new BankOfQuestion { Id = 305, QuestionText = "How many significant figures are in the number 0.0520 cm?", OptionA = "2", OptionB = "3", OptionC = "4", OptionD = "5", CorrectAnswer = "B", ExamId = 61 },

                // --- Questions for Exam 62 (lessonId = 123, Spectroscopic Methods) ---
                new BankOfQuestion { Id = 306, QuestionText = "Spectroscopy studies the interaction between ___ and matter.", OptionA = "Sound", OptionB = "Heat", OptionC = "Electromagnetic radiation (light)", OptionD = "Magnetic fields", CorrectAnswer = "C", ExamId = 62 },
                new BankOfQuestion { Id = 307, QuestionText = "UV-Vis spectroscopy measures the absorption of ultraviolet and visible light, which is related to:", OptionA = "Molecular vibrations", OptionB = "Nuclear spin", OptionC = "Electron transitions", OptionD = "Molecular rotation", CorrectAnswer = "C", ExamId = 62 },
                new BankOfQuestion { Id = 308, QuestionText = "Beer-Lambert Law relates absorbance (A) to concentration (c), path length (b), and:", OptionA = "Molar absorptivity (ε)", OptionB = "Wavelength (λ)", OptionC = "Frequency (ν)", OptionD = "Refractive index (n)", CorrectAnswer = "A", ExamId = 62 },
                new BankOfQuestion { Id = 309, QuestionText = "Infrared (IR) spectroscopy is primarily used to identify:", OptionA = "Elemental composition", OptionB = "Molecular weight", OptionC = "Functional groups", OptionD = "Electron configuration", CorrectAnswer = "C", ExamId = 62 },
                new BankOfQuestion { Id = 310, QuestionText = "A spectrophotometer measures the ___ of light passing through a sample.", OptionA = "Intensity (Transmittance/Absorbance)", OptionB = "Wavelength", OptionC = "Frequency", OptionD = "Speed", CorrectAnswer = "A", ExamId = 62 },

                // --- Questions for Exam 63 (lessonId = 125, Electroanalytical Methods) ---
                new BankOfQuestion { Id = 311, QuestionText = "Electroanalytical methods are based on measuring ___ properties of a solution.", OptionA = "Optical", OptionB = "Thermal", OptionC = "Magnetic", OptionD = "Electrical (potential, current, charge)", CorrectAnswer = "D", ExamId = 63 },
                new BankOfQuestion { Id = 312, QuestionText = "Potentiometry measures the ___ difference between two electrodes in a solution at equilibrium.", OptionA = "Current", OptionB = "Resistance", OptionC = "Potential (Voltage)", OptionD = "Capacitance", CorrectAnswer = "C", ExamId = 63 },
                new BankOfQuestion { Id = 313, QuestionText = "A common application of potentiometry is measuring ___ using a pH meter.", OptionA = "Conductivity", OptionB = "Temperature", OptionC = "pH", OptionD = "Viscosity", CorrectAnswer = "C", ExamId = 63 },
                new BankOfQuestion { Id = 314, QuestionText = "Voltammetry involves measuring the ___ as the potential applied to an electrode is varied.", OptionA = "Current", OptionB = "Resistance", OptionC = "pH", OptionD = "Temperature", CorrectAnswer = "A", ExamId = 63 },
                new BankOfQuestion { Id = 315, QuestionText = "These methods often use a working electrode, a reference electrode, and sometimes a ___ electrode.", OptionA = "Counter (Auxiliary)", OptionB = "Indicator", OptionC = "Sacrificial", OptionD = "Grounding", CorrectAnswer = "A", ExamId = 63 },

                // --- Questions for Exam 64 (lessonId = 127, Enzymes and Kinetics - Biochem) ---
                new BankOfQuestion { Id = 316, QuestionText = "Enzymes are biological catalysts that increase the rate of biochemical reactions, typically made of:", OptionA = "Carbohydrates", OptionB = "Lipids", OptionC = "Proteins", OptionD = "Nucleic acids", CorrectAnswer = "C", ExamId = 64 },
                new BankOfQuestion { Id = 317, QuestionText = "Enzymes increase reaction rates by lowering the:", OptionA = "Temperature", OptionB = "Substrate concentration", OptionC = "Activation energy", OptionD = "pH", CorrectAnswer = "C", ExamId = 64 },
                new BankOfQuestion { Id = 318, QuestionText = "The specific molecule upon which an enzyme acts is called the:", OptionA = "Product", OptionB = "Substrate", OptionC = "Cofactor", OptionD = "Inhibitor", CorrectAnswer = "B", ExamId = 64 },
                new BankOfQuestion { Id = 319, QuestionText = "The Michaelis-Menten equation describes the relationship between reaction velocity and:", OptionA = "Enzyme concentration", OptionB = "Substrate concentration", OptionC = "Temperature", OptionD = "pH", CorrectAnswer = "B", ExamId = 64 },
                new BankOfQuestion { Id = 320, QuestionText = "A substance that binds to an enzyme and decreases its activity is an:", OptionA = "Activator", OptionB = "Substrate", OptionC = "Inhibitor", OptionD = "Cofactor", CorrectAnswer = "C", ExamId = 64 },

                // --- Questions for Exam 65 (lessonId = 129, Lipids and Membranes) ---
                new BankOfQuestion { Id = 321, QuestionText = "Lipids are a diverse group of organic molecules characterized by being largely:", OptionA = "Hydrophilic (water-loving)", OptionB = "Hydrophobic (water-fearing)", OptionC = "Positively charged", OptionD = "Negatively charged", CorrectAnswer = "B", ExamId = 65 },
                new BankOfQuestion { Id = 322, QuestionText = "Fats and oils are composed of glycerol bonded to three:", OptionA = "Amino acids", OptionB = "Fatty acids", OptionC = "Monosaccharides", OptionD = "Nucleotides", CorrectAnswer = "B", ExamId = 65 },
                new BankOfQuestion { Id = 323, QuestionText = "The primary structural components of cell membranes are:", OptionA = "Triglycerides", OptionB = "Steroids", OptionC = "Phospholipids", OptionD = "Waxes", CorrectAnswer = "C", ExamId = 65 },
                new BankOfQuestion { Id = 324, QuestionText = "Phospholipids have a hydrophilic head and a ___ tail.", OptionA = "Hydrophilic", OptionB = "Hydrophobic", OptionC = "Charged", OptionD = "Polar", CorrectAnswer = "B", ExamId = 65 },
                new BankOfQuestion { Id = 325, QuestionText = "The Fluid Mosaic Model describes the cell membrane as proteins embedded or attached to a fluid bilayer of:", OptionA = "Triglycerides", OptionB = "Phospholipids", OptionC = "Carbohydrates", OptionD = "Cholesterol", CorrectAnswer = "B", ExamId = 65 },

                // --- Questions for Exam 66 (lessonId = 131, Atmospheric Chemistry) ---
                new BankOfQuestion { Id = 326, QuestionText = "The most abundant gas in Earth's atmosphere is:", OptionA = "Oxygen (O2)", OptionB = "Nitrogen (N2)", OptionC = "Carbon Dioxide (CO2)", OptionD = "Argon (Ar)", CorrectAnswer = "B", ExamId = 66 },
                new BankOfQuestion { Id = 327, QuestionText = "The ozone layer, which absorbs harmful UV radiation, is located primarily in the:", OptionA = "Troposphere", OptionB = "Stratosphere", OptionC = "Mesosphere", OptionD = "Thermosphere", CorrectAnswer = "B", ExamId = 66 },
                new BankOfQuestion { Id = 328, QuestionText = "Which gases contribute to the greenhouse effect by trapping heat?", OptionA = "N2 and O2", OptionB = "CO2, CH4, H2O", OptionC = "Ar and Ne", OptionD = "O3 and SO2", CorrectAnswer = "B", ExamId = 66 },
                new BankOfQuestion { Id = 329, QuestionText = "Acid rain is primarily caused by atmospheric pollutants like sulfur dioxide (SO2) and ___ oxides.", OptionA = "Carbon", OptionB = "Nitrogen", OptionC = "Ozone", OptionD = "Chlorine", CorrectAnswer = "B", ExamId = 66 },
                new BankOfQuestion { Id = 330, QuestionText = "Chlorofluorocarbons (CFCs) were phased out due to their role in:", OptionA = "Acid rain formation", OptionB = "Ozone layer depletion", OptionC = "Global warming", OptionD = "Smog formation", CorrectAnswer = "B", ExamId = 66 },

                // --- Questions for Exam 67 (lessonId = 133, Soil Chemistry) ---
                new BankOfQuestion { Id = 331, QuestionText = "Soil is a complex mixture of minerals, organic matter, water, and:", OptionA = "Air", OptionB = "Plastic", OptionC = "Metal", OptionD = "Glass", CorrectAnswer = "A", ExamId = 67 },
                new BankOfQuestion { Id = 332, QuestionText = "The decomposition of dead plants and animals forms ___ in the soil.", OptionA = "Minerals", OptionB = "Bedrock", OptionC = "Organic matter (humus)", OptionD = "Sand", CorrectAnswer = "C", ExamId = 67 },
                new BankOfQuestion { Id = 333, QuestionText = "Soil pH affects:", OptionA = "Only water retention", OptionB = "Only soil color", OptionC = "Nutrient availability to plants", OptionD = "Only soil texture", CorrectAnswer = "C", ExamId = 67 },
                new BankOfQuestion { Id = 334, QuestionText = "Cation Exchange Capacity (CEC) is a measure of the soil's ability to hold:", OptionA = "Water", OptionB = "Air", OptionC = "Positive ions (cations)", OptionD = "Negative ions (anions)", CorrectAnswer = "C", ExamId = 67 },
                new BankOfQuestion { Id = 335, QuestionText = "Contamination of soil with heavy metals or pesticides can negatively impact:", OptionA = "Only plant growth", OptionB = "Only water quality", OptionC = "Plant growth, water quality, and human health", OptionD = "Only air quality", CorrectAnswer = "C", ExamId = 67 },

                // --- Questions for Exam 68 (lessonId = 135, Green Chemistry) ---
                new BankOfQuestion { Id = 336, QuestionText = "Green Chemistry aims to design chemical products and processes that reduce or eliminate the use and generation of:", OptionA = "Useful substances", OptionB = "Hazardous substances", OptionC = "Expensive substances", OptionD = "Recyclable substances", CorrectAnswer = "B", ExamId = 68 },
                new BankOfQuestion { Id = 337, QuestionText = "Which principle emphasizes using raw materials efficiently (atom economy)?", OptionA = "Prevent waste", OptionB = "Maximize atom economy", OptionC = "Use safer solvents", OptionD = "Design for energy efficiency", CorrectAnswer = "B", ExamId = 68 },
                new BankOfQuestion { Id = 338, QuestionText = "Designing chemicals with little or no toxicity is a principle of Green Chemistry related to:", OptionA = "Waste prevention", OptionB = "Safer chemical design", OptionC = "Catalysis", OptionD = "Real-time analysis", CorrectAnswer = "B", ExamId = 68 },
                new BankOfQuestion { Id = 339, QuestionText = "Using catalysts instead of stoichiometric reagents often leads to:", OptionA = "More waste", OptionB = "Less selectivity", OptionC = "Higher energy use", OptionD = "Less waste and higher efficiency", CorrectAnswer = "D", ExamId = 68 },
                new BankOfQuestion { Id = 340, QuestionText = "Choosing solvents like water or supercritical CO2 over hazardous organic solvents aligns with the principle of:", OptionA = "Atom economy", OptionB = "Designing for degradation", OptionC = "Using safer solvents and auxiliaries", OptionD = "Inherently safer chemistry", CorrectAnswer = "C", ExamId = 68 },

                // --- Questions for Exam 69 (lessonId = 137, Approximation Methods - Theo Chem) ---
                new BankOfQuestion { Id = 341, QuestionText = "Approximation methods are needed in quantum chemistry because the Schrödinger equation can only be solved exactly for:", OptionA = "All molecules", OptionB = "Very simple systems (e.g., H atom)", OptionC = "Only solids", OptionD = "No systems", CorrectAnswer = "B", ExamId = 69 },
                new BankOfQuestion { Id = 342, QuestionText = "The Variation Principle states that the energy calculated using any approximate wave function will be ___ the true ground state energy.", OptionA = "Equal to or greater than", OptionB = "Equal to or less than", OptionC = "Always less than", OptionD = "Unrelated to", CorrectAnswer = "A", ExamId = 69 },
                new BankOfQuestion { Id = 343, QuestionText = "Perturbation theory is used when the system's Hamiltonian is only slightly different from one that:", OptionA = "Cannot be solved", OptionB = "Can be solved exactly", OptionC = "Has zero energy", OptionD = "Is temperature dependent", CorrectAnswer = "B", ExamId = 69 },
                new BankOfQuestion { Id = 344, QuestionText = "The goal of the variational method is to find the parameters in a trial wave function that ___ the calculated energy.", OptionA = "Maximize", OptionB = "Minimize", OptionC = "Keep constant", OptionD = "Make zero", CorrectAnswer = "B", ExamId = 69 },
                new BankOfQuestion { Id = 345, QuestionText = "These methods allow chemists to approximate solutions for complex:", OptionA = "Social systems", OptionB = "Economic models", OptionC = "Chemical reactions", OptionD = "Atoms and molecules", CorrectAnswer = "D", ExamId = 69 },

                // --- Questions for Exam 70 (lessonId = 139, Chemistry Comprehensive Exam) ---
                new BankOfQuestion { Id = 346, QuestionText = "Computational chemistry uses computer simulations to:", OptionA = "Synthesize new elements", OptionB = "Solve chemical problems", OptionC = "Perform physical experiments", OptionD = "Analyze historical data", CorrectAnswer = "B", ExamId = 70 },
                new BankOfQuestion { Id = 347, QuestionText = "Methods based directly on solving the Schrödinger equation (with approximations) are called ___ methods.", OptionA = "Molecular mechanics", OptionB = "Semi-empirical", OptionC = "Ab initio", OptionD = "Density functional theory", CorrectAnswer = "C", ExamId = 70 },
                new BankOfQuestion { Id = 348, QuestionText = "Hartree-Fock (HF) is a common ___ method that approximates electron interactions.", OptionA = "Molecular mechanics", OptionB = "Ab initio", OptionC = "Density functional theory", OptionD = "Empirical", CorrectAnswer = "B", ExamId = 70 },
                new BankOfQuestion { Id = 349, QuestionText = "Density Functional Theory (DFT) focuses on calculating the ___ instead of the complex wave function.", OptionA = "Electron density", OptionB = "Nuclear positions", OptionC = "Total energy directly", OptionD = "Dipole moment", CorrectAnswer = "A", ExamId = 70 },
                new BankOfQuestion { Id = 350, QuestionText = "Molecular Mechanics (MM) methods use classical physics and potential energy functions, making them computationally ___ than quantum methods.", OptionA = "Slower", OptionB = "Faster", OptionC = "More accurate", OptionD = "Less applicable", CorrectAnswer = "B", ExamId = 70 },

                // --- Questions for Exam 71 (lessonId = 141, Literary Analysis Basics) ---
                new BankOfQuestion { Id = 351, QuestionText = "The central idea or underlying message of a literary work is its:", OptionA = "Plot", OptionB = "Setting", OptionC = "Theme", OptionD = "Character", CorrectAnswer = "C", ExamId = 71 },
                new BankOfQuestion { Id = 352, QuestionText = "The sequence of events in a story constitutes its:", OptionA = "Theme", OptionB = "Plot", OptionC = "Setting", OptionD = "Point of view", CorrectAnswer = "B", ExamId = 71 },
                new BankOfQuestion { Id = 353, QuestionText = "The time and place in which a story occurs is the:", OptionA = "Plot", OptionB = "Character", OptionC = "Theme", OptionD = "Setting", CorrectAnswer = "D", ExamId = 71 },
                new BankOfQuestion { Id = 354, QuestionText = "The perspective from which a story is told (e.g., first-person, third-person) is the:", OptionA = "Setting", OptionB = "Point of view", OptionC = "Plot", OptionD = "Theme", CorrectAnswer = "B", ExamId = 71 },
                new BankOfQuestion { Id = 355, QuestionText = "Analyzing how authors use language (diction, imagery, syntax) is part of studying:", OptionA = "Plot structure", OptionB = "Character motivation", OptionC = "Literary style", OptionD = "Historical context", CorrectAnswer = "C", ExamId = 71 },

                // --- Questions for Exam 72 (lessonId = 143, Poetry Fundamentals) ---
                new BankOfQuestion { Id = 356, QuestionText = "A comparison between two unlike things using 'like' or 'as' is a:", OptionA = "Metaphor", OptionB = "Simile", OptionC = "Personification", OptionD = "Hyperbole", CorrectAnswer = "B", ExamId = 72 },
                new BankOfQuestion { Id = 357, QuestionText = "A direct comparison between two unlike things without using 'like' or 'as' is a:", OptionA = "Metaphor", OptionB = "Simile", OptionC = "Alliteration", OptionD = "Onomatopoeia", CorrectAnswer = "A", ExamId = 72 },
                new BankOfQuestion { Id = 358, QuestionText = "Giving human qualities or abilities to inanimate objects or animals is:", OptionA = "Hyperbole", OptionB = "Simile", OptionC = "Personification", OptionD = "Metaphor", CorrectAnswer = "C", ExamId = 72 },
                new BankOfQuestion { Id = 359, QuestionText = "The pattern of stressed and unstressed syllables in a line of poetry is its:", OptionA = "Rhyme scheme", OptionB = "Meter", OptionC = "Stanza", OptionD = "Imagery", CorrectAnswer = "B", ExamId = 72 },
                new BankOfQuestion { Id = 360, QuestionText = "A fourteen-line poem with a specific rhyme scheme (e.g., Shakespearean, Petrarchan) is a:", OptionA = "Haiku", OptionB = "Limerick", OptionC = "Sonnet", OptionD = "Villanelle", CorrectAnswer = "C", ExamId = 72 },

                // --- Questions for Exam 73 (lessonId = 145, Introduction to Drama) ---
                new BankOfQuestion { Id = 361, QuestionText = "Drama is literature written to be:", OptionA = "Read silently", OptionB = "Performed by actors", OptionC = "Analyzed mathematically", OptionD = "Sung as an opera", CorrectAnswer = "B", ExamId = 73 },
                new BankOfQuestion { Id = 362, QuestionText = "The written text of a play is called the:", OptionA = "Score", OptionB = "Script", OptionC = "Novel", OptionD = "Libretto", CorrectAnswer = "B", ExamId = 73 },
                new BankOfQuestion { Id = 363, QuestionText = "Conversation between characters in a play is called:", OptionA = "Monologue", OptionB = "Aside", OptionC = "Dialogue", OptionD = "Soliloquy", CorrectAnswer = "C", ExamId = 73 },
                new BankOfQuestion { Id = 364, QuestionText = "Instructions in the script indicating movement, position, or tone are:", OptionA = "Dialogue", OptionB = "Stage directions", OptionC = "Subtext", OptionD = "Themes", CorrectAnswer = "B", ExamId = 73 },
                new BankOfQuestion { Id = 365, QuestionText = "A long speech delivered by one character, often alone on stage, revealing inner thoughts, is a:", OptionA = "Dialogue", OptionB = "Aside", OptionC = "Chorus", OptionD = "Soliloquy", CorrectAnswer = "D", ExamId = 73 },

                // --- Questions for Exam 74 (lessonId = 147, Character Development Quiz) ---
                new BankOfQuestion { Id = 366, QuestionText = "A character who undergoes significant internal change throughout the story is a:", OptionA = "Static character", OptionB = "Flat character", OptionC = "Dynamic character", OptionD = "Stock character", CorrectAnswer = "C", ExamId = 74 },
                new BankOfQuestion { Id = 367, QuestionText = "A character who does not change significantly is a:", OptionA = "Dynamic character", OptionB = "Round character", OptionC = "Static character", OptionD = "Protagonist", CorrectAnswer = "C", ExamId = 74 },
                new BankOfQuestion { Id = 368, QuestionText = "The underlying reason for a character's actions is their:", OptionA = "Appearance", OptionB = "Dialogue", OptionC = "Motivation", OptionD = "Setting", CorrectAnswer = "C", ExamId = 74 },
                new BankOfQuestion { Id = 369, QuestionText = "Revealing character through actions, speech, thoughts, and appearance rather than direct statements is:", OptionA = "Direct characterization", OptionB = "Indirect characterization", OptionC = "Plot development", OptionD = "Setting description", CorrectAnswer = "B", ExamId = 74 },
                new BankOfQuestion { Id = 370, QuestionText = "A stereotypical character easily recognized by readers (e.g., the mad scientist) is a:", OptionA = "Round character", OptionB = "Dynamic character", OptionC = "Protagonist", OptionD = "Stock character", CorrectAnswer = "D", ExamId = 74 },

                // --- Questions for Exam 75 (lessonId = 149, Setting and Description Quiz) ---
                new BankOfQuestion { Id = 371, QuestionText = "Setting encompasses the time period, location, and ___ environment of a story.", OptionA = "Character", OptionB = "Plot", OptionC = "Social/Cultural", OptionD = "Thematic", CorrectAnswer = "C", ExamId = 75 },
                new BankOfQuestion { Id = 372, QuestionText = "Using details related to sight, sound, smell, taste, and touch to create vivid descriptions is using:", OptionA = "Figurative language", OptionB = "Sensory details", OptionC = "Dialogue", OptionD = "Plot points", CorrectAnswer = "B", ExamId = 75 },
                new BankOfQuestion { Id = 373, QuestionText = "The overall mood or feeling created by the setting and description is the:", OptionA = "Pacing", OptionB = "Conflict", OptionC = "Atmosphere", OptionD = "Climax", CorrectAnswer = "C", ExamId = 75 },
                new BankOfQuestion { Id = 374, QuestionText = "Effective description should primarily serve to:", OptionA = "Slow down the plot", OptionB = "Confuse the reader", OptionC = "Enhance atmosphere, character, or plot", OptionD = "Show off vocabulary", CorrectAnswer = "C", ExamId = 75 },
                new BankOfQuestion { Id = 375, QuestionText = "Integrating setting details naturally within the narrative is often more effective than long:", OptionA = "Dialogue scenes", OptionB = "Action sequences", OptionC = "Descriptive passages (info dumps)", OptionD = "Character arcs", CorrectAnswer = "C", ExamId = 75 },

                // --- Questions for Exam 76 (lessonId = 151, Parts of Speech Exam) ---
                new BankOfQuestion { Id = 376, QuestionText = "Which part of speech names a person, place, thing, or idea?", OptionA = "Verb", OptionB = "Adjective", OptionC = "Noun", OptionD = "Adverb", CorrectAnswer = "C", ExamId = 76 },
                new BankOfQuestion { Id = 377, QuestionText = "Which part of speech describes an action or state of being?", OptionA = "Noun", OptionB = "Adjective", OptionC = "Verb", OptionD = "Preposition", CorrectAnswer = "C", ExamId = 76 },
                new BankOfQuestion { Id = 378, QuestionText = "Which part of speech modifies (describes) a noun or pronoun?", OptionA = "Verb", OptionB = "Adverb", OptionC = "Adjective", OptionD = "Conjunction", CorrectAnswer = "C", ExamId = 76 },
                new BankOfQuestion { Id = 379, QuestionText = "Which part of speech modifies a verb, adjective, or another adverb (often ending in -ly)?", OptionA = "Adjective", OptionB = "Preposition", OptionC = "Adverb", OptionD = "Interjection", CorrectAnswer = "C", ExamId = 76 },
                new BankOfQuestion { Id = 380, QuestionText = "Words like 'and', 'but', 'or' that connect words, phrases, or clauses are:", OptionA = "Prepositions", OptionB = "Interjections", OptionC = "Pronouns", OptionD = "Conjunctions", CorrectAnswer = "D", ExamId = 76 },

                // --- Questions for Exam 77 (lessonId = 153, Punctuation Rules Exam) ---
                new BankOfQuestion { Id = 381, QuestionText = "Which punctuation mark is used to end a declarative sentence?", OptionA = "Question mark (?)", OptionB = "Exclamation point (!)", OptionC = "Period (.)", OptionD = "Comma (,)", CorrectAnswer = "C", ExamId = 77 },
                new BankOfQuestion { Id = 382, QuestionText = "Commas are typically used to separate items in a:", OptionA = "Question", OptionB = "Command", OptionC = "List or series", OptionD = "Title", CorrectAnswer = "C", ExamId = 77 },
                new BankOfQuestion { Id = 383, QuestionText = "Which punctuation mark is used to indicate possession or contractions?", OptionA = "Semicolon (;)", OptionB = "Colon (:)", OptionC = "Apostrophe (')", OptionD = "Hyphen (-)", CorrectAnswer = "C", ExamId = 77 },
                new BankOfQuestion { Id = 384, QuestionText = "A semicolon (;) can be used to connect two closely related:", OptionA = "Dependent clauses", OptionB = "Independent clauses", OptionC = "Phrases", OptionD = "Words", CorrectAnswer = "B", ExamId = 77 },
                new BankOfQuestion { Id = 385, QuestionText = "Quotation marks are used primarily to indicate:", OptionA = "Possession", OptionB = "A question", OptionC = "Direct speech or quoted text", OptionD = "An abbreviation", CorrectAnswer = "C", ExamId = 77 },

                // --- Questions for Exam 78 (lessonId = 155, Paragraph and Essay Structure Exam) ---
                new BankOfQuestion { Id = 386, QuestionText = "A paragraph typically focuses on developing:", OptionA = "Multiple main ideas", OptionB = "A single main idea", OptionC = "The entire essay's argument", OptionD = "Character backstories", CorrectAnswer = "B", ExamId = 78 },
                new BankOfQuestion { Id = 387, QuestionText = "The sentence that states the main idea of a paragraph is the:", OptionA = "Supporting sentence", OptionB = "Concluding sentence", OptionC = "Topic sentence", OptionD = "Transition sentence", CorrectAnswer = "C", ExamId = 78 },
                new BankOfQuestion { Id = 388, QuestionText = "The main argument or central point of an entire essay is presented in the:", OptionA = "Topic sentence", OptionB = "Conclusion", OptionC = "Introduction", OptionD = "Thesis statement", CorrectAnswer = "D", ExamId = 78 },
                new BankOfQuestion { Id = 389, QuestionText = "Words or phrases like 'however', 'in addition', 'therefore' that link ideas are called:", OptionA = "Topics", OptionB = "Arguments", OptionC = "Transitions", OptionD = "Conclusions", CorrectAnswer = "C", ExamId = 78 },
                new BankOfQuestion { Id = 390, QuestionText = "The concluding paragraph of an essay typically summarizes main points and restates the:", OptionA = "Introduction", OptionB = "First topic sentence", OptionC = "Thesis statement (in different words)", OptionD = "Supporting details", CorrectAnswer = "C", ExamId = 78 },

                // --- Questions for Exam 79 (lessonId = 157, Figurative Language Exam) ---
                new BankOfQuestion { Id = 391, QuestionText = "An extreme exaggeration used for emphasis or effect is:", OptionA = "Simile", OptionB = "Metaphor", OptionC = "Hyperbole", OptionD = "Personification", CorrectAnswer = "C", ExamId = 79 },
                new BankOfQuestion { Id = 392, QuestionText = "'The wind whispered through the trees' is an example of:", OptionA = "Simile", OptionB = "Metaphor", OptionC = "Personification", OptionD = "Hyperbole", CorrectAnswer = "C", ExamId = 79 },
                new BankOfQuestion { Id = 393, QuestionText = "'Her smile was a ray of sunshine' is an example of:", OptionA = "Simile", OptionB = "Metaphor", OptionC = "Personification", OptionD = "Alliteration", CorrectAnswer = "B", ExamId = 79 },
                new BankOfQuestion { Id = 394, QuestionText = "'He is as strong as an ox' is an example of:", OptionA = "Simile", OptionB = "Metaphor", OptionC = "Onomatopoeia", OptionD = "Personification", CorrectAnswer = "A", ExamId = 79 },
                new BankOfQuestion { Id = 395, QuestionText = "Figurative language goes beyond the ___ meaning of words.", OptionA = "Figurative", OptionB = "Literal", OptionC = "Poetic", OptionD = "Rhythmic", CorrectAnswer = "B", ExamId = 79 },

                // --- Questions for Exam 80 (lessonId = 159, Poetic Forms Exam) ---
                new BankOfQuestion { Id = 396, QuestionText = "A three-line Japanese poem with a 5-7-5 syllable structure is a:", OptionA = "Sonnet", OptionB = "Limerick", OptionC = "Haiku", OptionD = "Villanelle", CorrectAnswer = "C", ExamId = 80 },
                new BankOfQuestion { Id = 397, QuestionText = "A humorous five-line poem with a specific AABBA rhyme scheme is a:", OptionA = "Sonnet", OptionB = "Limerick", OptionC = "Haiku", OptionD = "Ballad", CorrectAnswer = "B", ExamId = 80 },
                new BankOfQuestion { Id = 398, QuestionText = "Poetry that does not follow regular patterns of rhyme or meter is called:", OptionA = "Fixed verse", OptionB = "Free verse", OptionC = "Blank verse", OptionD = "Rhyming verse", CorrectAnswer = "B", ExamId = 80 },
                new BankOfQuestion { Id = 399, QuestionText = "Blank verse is written in unrhymed:", OptionA = "Free form", OptionB = "Iambic pentameter", OptionC = "Trochaic tetrameter", OptionD = "Dactylic hexameter", CorrectAnswer = "B", ExamId = 80 },
                new BankOfQuestion { Id = 400, QuestionText = "A complex nineteen-line poem with two repeating rhymes and two refrains is a:", OptionA = "Sonnet", OptionB = "Haiku", OptionC = "Sestina", OptionD = "Villanelle", CorrectAnswer = "D", ExamId = 80 },

                // --- Questions for Exam 81 (lessonId = 161, History of Theater Exam) ---
                new BankOfQuestion { Id = 401, QuestionText = "Western theater originated in ancient ___ with festivals honoring the god Dionysus.", OptionA = "Rome", OptionB = "Egypt", OptionC = "Greece", OptionD = "Mesopotamia", CorrectAnswer = "C", ExamId = 81 },
                new BankOfQuestion { Id = 402, QuestionText = "Sophocles, Aeschylus, and Euripides were famous ancient Greek writers of:", OptionA = "Comedy", OptionB = "Tragedy", OptionC = "Satyr plays", OptionD = "Epic poetry", CorrectAnswer = "B", ExamId = 81 },
                new BankOfQuestion { Id = 403, QuestionText = "During the English Renaissance, ___ was a prominent playwright associated with the Globe Theatre.", OptionA = "Christopher Marlowe", OptionB = "Ben Jonson", OptionC = "William Shakespeare", OptionD = "John Webster", CorrectAnswer = "C", ExamId = 81 },
                new BankOfQuestion { Id = 404, QuestionText = "Realism in theater, emerging in the 19th century, aimed to portray life:", OptionA = "Idealistically", OptionB = "Comically", OptionC = "Truthfully and objectively", OptionD = "Symbolically", CorrectAnswer = "C", ExamId = 81 },
                new BankOfQuestion { Id = 405, QuestionText = "Playwrights like Henrik Ibsen and Anton Chekhov are associated with which theatrical movement?", OptionA = "Absurdism", OptionB = "Romanticism", OptionC = "Realism/Naturalism", OptionD = "Expressionism", CorrectAnswer = "C", ExamId = 81 },

                // --- Questions for Exam 82 (lessonId = 163, Reading a Play Exam) ---
                new BankOfQuestion { Id = 406, QuestionText = "Understanding the historical or cultural ___ of a play can enhance interpretation.", OptionA = "Dialogue", OptionB = "Context", OptionC = "Staging", OptionD = "Characters", CorrectAnswer = "B", ExamId = 82 },
                new BankOfQuestion { Id = 407, QuestionText = "Stage directions provide information about setting, actions, and ___.", OptionA = "Themes", OptionB = "Character tone/emotion", OptionC = "Rhyme scheme", OptionD = "Plot summary", CorrectAnswer = "B", ExamId = 82 },
                new BankOfQuestion { Id = 408, QuestionText = "The underlying, unspoken meaning or intention behind a character's words is the:", OptionA = "Text", OptionB = "Subtext", OptionC = "Context", OptionD = "Direction", CorrectAnswer = "B", ExamId = 82 },
                new BankOfQuestion { Id = 409, QuestionText = "When reading a play, it's helpful to ___ the action and setting.", OptionA = "Ignore", OptionB = "Summarize", OptionC = "Visualize", OptionD = "Critique", CorrectAnswer = "C", ExamId = 82 },
                new BankOfQuestion { Id = 410, QuestionText = "Analyzing how dialogue reveals character traits and advances the ___ is key.", OptionA = "Setting", OptionB = "Theme", OptionC = "Plot", OptionD = "Mood", CorrectAnswer = "C", ExamId = 82 },

                // --- Questions for Exam 83 (lessonId = 165, Theater Production Basics Exam) ---
                new BankOfQuestion { Id = 411, QuestionText = "Who is responsible for the overall artistic vision and interpretation of the play?", OptionA = "Actor", OptionB = "Playwright", OptionC = "Director", OptionD = "Stage Manager", CorrectAnswer = "C", ExamId = 83 },
                new BankOfQuestion { Id = 412, QuestionText = "Who embodies the characters and delivers the dialogue?", OptionA = "Director", OptionB = "Designer", OptionC = "Actor", OptionD = "Producer", CorrectAnswer = "C", ExamId = 83 },
                new BankOfQuestion { Id = 413, QuestionText = "Set designers, costume designers, and lighting designers create the ___ elements of the production.", OptionA = "Auditory", OptionB = "Visual", OptionC = "Textual", OptionD = "Financial", CorrectAnswer = "B", ExamId = 83 },
                new BankOfQuestion { Id = 414, QuestionText = "Who manages the logistical aspects of the production, including rehearsals and performances?", OptionA = "Director", OptionB = "Playwright", OptionC = "Stage Manager", OptionD = "Lead Actor", CorrectAnswer = "C", ExamId = 83 },
                new BankOfQuestion { Id = 415, QuestionText = "The process typically starts with the script and involves casting, rehearsals, design, and finally:", OptionA = "Writing", OptionB = "Publication", OptionC = "Performance", OptionD = "Funding", CorrectAnswer = "C", ExamId = 83 },

                // --- Questions for Exam 84 (lessonId = 167, Point of View Quiz) ---
                new BankOfQuestion { Id = 416, QuestionText = "In first-person POV, the narrator uses which pronoun?", OptionA = "He/She/They", OptionB = "You", OptionC = "I/We", OptionD = "It", CorrectAnswer = "C", ExamId = 84 },
                new BankOfQuestion { Id = 417, QuestionText = "Third-person limited POV allows the reader access to the thoughts and feelings of:", OptionA = "No characters", OptionB = "All characters", OptionC = "One character", OptionD = "Only the narrator", CorrectAnswer = "C", ExamId = 84 },
                new BankOfQuestion { Id = 418, QuestionText = "Third-person omniscient POV means the narrator:", OptionA = "Knows only one character's thoughts", OptionB = "Is a character in the story", OptionC = "Knows the thoughts and feelings of all characters", OptionD = "Does not know any character's thoughts", CorrectAnswer = "C", ExamId = 84 },
                new BankOfQuestion { Id = 419, QuestionText = "Second-person POV ('You go to the store...') is:", OptionA = "Very common in fiction", OptionB = "Rarely used in fiction", OptionC = "The same as first-person", OptionD = "The same as third-person omniscient", CorrectAnswer = "B", ExamId = 84 },
                new BankOfQuestion { Id = 420, QuestionText = "The choice of POV significantly impacts the reader's ___ and understanding of the story.", OptionA = "Vocabulary", OptionB = "Grammar", OptionC = "Experience/Perspective", OptionD = "Punctuation", CorrectAnswer = "C", ExamId = 84 },

                // --- Questions for Exam 85 (lessonId = 169, Crafting Scenes Quiz) ---
                new BankOfQuestion { Id = 421, QuestionText = "A scene in fiction is typically a unit of action that occurs in:", OptionA = "Multiple locations over weeks", OptionB = "A single location and continuous time", OptionC = "The narrator's mind only", OptionD = "The past", CorrectAnswer = "B", ExamId = 85 },
                new BankOfQuestion { Id = 422, QuestionText = "Effective scenes often contain some form of goal, conflict, and:", OptionA = "Resolution/Outcome", OptionB = "Flashback", OptionC = "Description only", OptionD = "Happy ending", CorrectAnswer = "A", ExamId = 85 },
                new BankOfQuestion { Id = 423, QuestionText = "Pacing within a scene refers to the ___ at which information is revealed and action unfolds.", OptionA = "Volume", OptionB = "Speed/Rhythm", OptionC = "Location", OptionD = "Accuracy", CorrectAnswer = "B", ExamId = 85 },
                new BankOfQuestion { Id = 424, QuestionText = "Ending a scene with a question, surprise, or setback can create:", OptionA = "Resolution", OptionB = "Summary", OptionC = "Suspense", OptionD = "Confusion", CorrectAnswer = "C", ExamId = 85 },
                new BankOfQuestion { Id = 425, QuestionText = "Linking scenes together smoothly often requires effective:", OptionA = "Dialogue", OptionB = "Character names", OptionC = "Transitions", OptionD = "Chapter breaks", CorrectAnswer = "C", ExamId = 85 },

                // --- Questions for Exam 86 (lessonId = 171, Types of Non-fiction Exam) ---
                new BankOfQuestion { Id = 426, QuestionText = "Non-fiction writing is based on:", OptionA = "Imagination and fantasy", OptionB = "Facts, real events, and real people", OptionC = "Poetic meter and rhyme", OptionD = "Dialogue only", CorrectAnswer = "B", ExamId = 86 },
                new BankOfQuestion { Id = 427, QuestionText = "A written account of another person's life is a:", OptionA = "Memoir", OptionB = "Autobiography", OptionC = "Biography", OptionD = "Personal essay", CorrectAnswer = "C", ExamId = 86 },
                new BankOfQuestion { Id = 428, QuestionText = "A writer's account of their own life is an:", OptionA = "Biography", OptionB = "Autobiography", OptionC = "Instruction manual", OptionD = "News report", CorrectAnswer = "B", ExamId = 86 },
                new BankOfQuestion { Id = 429, QuestionText = "A short piece of writing on a particular subject, often expressing the author's viewpoint, is an:", OptionA = "Essay", OptionB = "Novel", OptionC = "Play", OptionD = "Biography", CorrectAnswer = "A", ExamId = 86 },
                new BankOfQuestion { Id = 430, QuestionText = "Writing that reports on current events is:", OptionA = "Memoir", OptionB = "Journalism", OptionC = "Travel writing", OptionD = "Literary criticism", CorrectAnswer = "B", ExamId = 86 },

                // --- Questions for Exam 87 (lessonId = 173, Structuring Non-fiction Exam) ---
                new BankOfQuestion { Id = 431, QuestionText = "Arranging events in the order they occurred is ___ structure.", OptionA = "Thematic", OptionB = "Comparative", OptionC = "Chronological", OptionD = "Spatial", CorrectAnswer = "C", ExamId = 87 },
                new BankOfQuestion { Id = 432, QuestionText = "Organizing information based on topics or categories is ___ structure.", OptionA = "Chronological", OptionB = "Thematic", OptionC = "Narrative", OptionD = "Cause-and-effect", CorrectAnswer = "B", ExamId = 87 },
                new BankOfQuestion { Id = 433, QuestionText = "Presenting information by describing how things relate in physical space uses ___ structure.", OptionA = "Chronological", OptionB = "Thematic", OptionC = "Spatial", OptionD = "Problem-solution", CorrectAnswer = "C", ExamId = 87 },
                new BankOfQuestion { Id = 434, QuestionText = "Explaining similarities and differences between subjects uses ___ structure.", OptionA = "Compare and Contrast", OptionB = "Chronological", OptionC = "Narrative", OptionD = "Thematic", CorrectAnswer = "A", ExamId = 87 },
                new BankOfQuestion { Id = 435, QuestionText = "Using storytelling techniques (plot, character) to present factual information employs ___ structure.", OptionA = "Thematic", OptionB = "Spatial", OptionC = "Narrative", OptionD = "Compare and Contrast", CorrectAnswer = "C", ExamId = 87 },

                // --- Questions for Exam 88 (lessonId = 175, English & Literature Comprehensive Exam) ---
                new BankOfQuestion { Id = 436, QuestionText = "A primary ethical responsibility in non-fiction is:", OptionA = "Inventing details", OptionB = "Accuracy and truthfulness", OptionC = "Ignoring sources", OptionD = "Using complex vocabulary", CorrectAnswer = "B", ExamId = 88 },
                new BankOfQuestion { Id = 437, QuestionText = "Verifying information through multiple reliable sources is called:", OptionA = "Plagiarism", OptionB = "Fact-checking", OptionC = "Speculation", OptionD = "Fictionalization", CorrectAnswer = "B", ExamId = 88 },
                new BankOfQuestion { Id = 438, QuestionText = "Presenting someone else's work or ideas as your own is:", OptionA = "Citation", OptionB = "Paraphrasing", OptionC = "Plagiarism", OptionD = "Quoting", CorrectAnswer = "C", ExamId = 88 },
                new BankOfQuestion { Id = 439, QuestionText = "When writing about real people, authors must consider issues of:", OptionA = "Plot structure", OptionB = "Privacy and potential harm", OptionC = "Rhyme scheme", OptionD = "Character archetypes", CorrectAnswer = "B", ExamId = 88 },
                new BankOfQuestion { Id = 440, QuestionText = "Fairly portraying subjects and avoiding bias is crucial for ethical:", OptionA = "Fictionalization", OptionB = "Representation", OptionC = "Speculation", OptionD = "Exaggeration", CorrectAnswer = "B", ExamId = 88 },

                // --- ADDITIONAL COMPREHENSIVE QUESTIONS FOR FINAL EXAMS ---

                // --- Additional Comprehensive Questions for Exam 18 (Core Mathematics Comprehensive Exam, lessonId = 35) ---
                // Existing: 441-445. New: 471-485
                new BankOfQuestion { Id = 471, QuestionText = "What is the value of 'i' raised to the power of 4 (i^4), where 'i' is the imaginary unit?", OptionA = "1", OptionB = "-1", OptionC = "i", OptionD = "-i", CorrectAnswer = "A", ExamId = 18 },
                new BankOfQuestion { Id = 472, QuestionText = "The process of finding the area under a curve is known as:", OptionA = "Differentiation", OptionB = "Integration", OptionC = "Factorization", OptionD = "Extrapolation", CorrectAnswer = "B", ExamId = 18 },
                new BankOfQuestion { Id = 473, QuestionText = "A function f(x) is continuous at a point 'a' if which condition is met?", OptionA = "The limit of f(x) as x approaches 'a' exists", OptionB = "f(a) is defined", OptionC = "The limit of f(x) as x approaches 'a' equals f(a)", OptionD = "All of the above", CorrectAnswer = "D", ExamId = 18 },
                new BankOfQuestion { Id = 474, QuestionText = "Which trigonometric function is the reciprocal of cosine?", OptionA = "Sine", OptionB = "Tangent", OptionC = "Secant", OptionD = "Cosecant", CorrectAnswer = "C", ExamId = 18 },
                new BankOfQuestion { Id = 475, QuestionText = "A matrix that is its own inverse is called:", OptionA = "An identity matrix", OptionB = "A zero matrix", OptionC = "An involutory matrix", OptionD = "A singular matrix", CorrectAnswer = "C", ExamId = 18 },
                new BankOfQuestion { Id = 476, QuestionText = "The Fundamental Theorem of Algebra states that every non-constant single-variable polynomial with complex coefficients has at least one:", OptionA = "Real root", OptionB = "Complex root", OptionC = "Rational root", OptionD = "Integer root", CorrectAnswer = "B", ExamId = 18 },
                new BankOfQuestion { Id = 477, QuestionText = "What is the eccentricity of a circle in conic sections?", OptionA = "0", OptionB = "1", OptionC = "Greater than 1", OptionD = "Between 0 and 1", CorrectAnswer = "A", ExamId = 18 },
                new BankOfQuestion { Id = 478, QuestionText = "The power rule for derivatives states that d/dx(x^n) =", OptionA = "nx^(n+1)", OptionB = "n*x^(n-1)", OptionC = "x^n / n", OptionD = "(n-1)x^n", CorrectAnswer = "B", ExamId = 18 },
                new BankOfQuestion { Id = 479, QuestionText = "In set theory, the set of all elements that are in A or in B (or in both) is called the:", OptionA = "Intersection of A and B", OptionB = "Union of A and B", OptionC = "Complement of A", OptionD = "Cartesian product of A and B", CorrectAnswer = "B", ExamId = 18 },
                new BankOfQuestion { Id = 480, QuestionText = "What does the term 'bijection' refer to in functions?", OptionA = "A function that is only injective (one-to-one)", OptionB = "A function that is only surjective (onto)", OptionC = "A function that is both injective and surjective", OptionD = "A function that is neither injective nor surjective", CorrectAnswer = "C", ExamId = 18 },
                new BankOfQuestion { Id = 481, QuestionText = "Which geometric transformation involves flipping a figure over a line?", OptionA = "Translation", OptionB = "Rotation", OptionC = "Reflection", OptionD = "Dilation", CorrectAnswer = "C", ExamId = 18 },
                new BankOfQuestion { Id = 482, QuestionText = "The expression (n!) / (k!(n-k)!) is the formula for:", OptionA = "Permutations P(n,k)", OptionB = "Combinations C(n,k)", OptionC = "Factorial of n+k", OptionD = "Arithmetic series sum", CorrectAnswer = "B", ExamId = 18 },
                new BankOfQuestion { Id = 483, QuestionText = "A tautology in propositional logic is a statement that is:", OptionA = "Always false", OptionB = "Always true", OptionC = "Sometimes true, sometimes false", OptionD = "Undefined", CorrectAnswer = "B", ExamId = 18 },
                new BankOfQuestion { Id = 484, QuestionText = "What is the derivative of sin(x)?", OptionA = "cos(x)", OptionB = "-sin(x)", OptionC = "-cos(x)", OptionD = "tan(x)", CorrectAnswer = "A", ExamId = 18 },
                new BankOfQuestion { Id = 485, QuestionText = "A graph is considered 'complete' if:", OptionA = "It has no cycles", OptionB = "Every vertex is connected to every other vertex", OptionC = "It is a tree", OptionD = "It is planar", CorrectAnswer = "B", ExamId = 18 },

                // --- Additional Comprehensive Questions for Exam 15 (Statistics & Probability Comprehensive Exam, lessonId = 29) ---
                // Existing: 446-450. New: 486-500
                new BankOfQuestion { Id = 486, QuestionText = "The range of a dataset is calculated by:", OptionA = "Summing all values", OptionB = "Subtracting the minimum value from the maximum value", OptionC = "Finding the most frequent value", OptionD = "Averaging all values", CorrectAnswer = "B", ExamId = 15 },
                new BankOfQuestion { Id = 487, QuestionText = "A p-value in hypothesis testing represents the probability of:", OptionA = "The null hypothesis being true", OptionB = "The alternative hypothesis being true", OptionC = "Observing the test statistic (or more extreme) if the null hypothesis is true", OptionD = "Making a Type II error", CorrectAnswer = "C", ExamId = 15 },
                new BankOfQuestion { Id = 488, QuestionText = "Which of these is NOT a characteristic of a normal distribution?", OptionA = "Symmetric about the mean", OptionB = "Bell-shaped curve", OptionC = "Mean, median, and mode are equal", OptionD = "Skewed to the right", CorrectAnswer = "D", ExamId = 15 },
                new BankOfQuestion { Id = 489, QuestionText = "If events A and B are mutually exclusive, then P(A or B) is:", OptionA = "P(A) * P(B)", OptionB = "P(A) + P(B)", OptionC = "P(A) + P(B) - P(A and B)", OptionD = "0", CorrectAnswer = "B", ExamId = 15 }, // Since P(A and B) = 0 for mutually exclusive
                new BankOfQuestion { Id = 490, QuestionText = "What does a correlation coefficient of -1 indicate?", OptionA = "Perfect positive linear relationship", OptionB = "Perfect negative linear relationship", OptionC = "No linear relationship", OptionD = "Weak positive linear relationship", CorrectAnswer = "B", ExamId = 15 },


                // --- Additional Comprehensive Questions for Exam 35 (Physics Comprehensive Exam, lessonId = 69) ---
                // Existing: 451-455. New: 501-515
                new BankOfQuestion { Id = 501, QuestionText = "The unit of power is the Watt (W), which is equivalent to:", OptionA = "Joule/second (J/s)", OptionB = "Newton-meter (N·m)", OptionC = "Kilogram-meter/second (kg·m/s)", OptionD = "Coulomb/second (C/s)", CorrectAnswer = "A", ExamId = 35 },
                new BankOfQuestion { Id = 502, QuestionText = "Which law states that for every action, there is an equal and opposite reaction?", OptionA = "Newton's First Law", OptionB = "Newton's Second Law", OptionC = "Newton's Third Law", OptionD = "Law of Conservation of Momentum", CorrectAnswer = "C", ExamId = 35 },
                new BankOfQuestion { Id = 503, QuestionText = "In a series circuit, the total resistance is the ___ of individual resistances.", OptionA = "Product", OptionB = "Sum", OptionC = "Reciprocal of the sum of reciprocals", OptionD = "Average", CorrectAnswer = "B", ExamId = 35 },
                new BankOfQuestion { Id = 504, QuestionText = "The photoelectric effect demonstrates the ___ nature of light.", OptionA = "Wave", OptionB = "Particle (photon)", OptionC = "Continuous", OptionD = "Magnetic", CorrectAnswer = "B", ExamId = 35 },
                new BankOfQuestion { Id = 505, QuestionText = "What is the SI unit of magnetic field strength?", OptionA = "Volt (V)", OptionB = "Ampere (A)", OptionC = "Tesla (T)", OptionD = "Weber (Wb)", CorrectAnswer = "C", ExamId = 35 },
                new BankOfQuestion { Id = 506, QuestionText = "The principle of superposition in waves states that when two waves meet:", OptionA = "They reflect off each other", OptionB = "They cancel each other out completely", OptionC = "Their displacements add algebraically", OptionD = "Their frequencies double", CorrectAnswer = "C", ExamId = 35 },
                new BankOfQuestion { Id = 507, QuestionText = "According to the First Law of Thermodynamics, the change in internal energy of a system is equal to:", OptionA = "Heat added minus work done by the system", OptionB = "Work done by the system minus heat added", OptionC = "Heat added plus work done on the system", OptionD = "Always zero", CorrectAnswer = "A", ExamId = 35 }, // or C, depending on W convention
                new BankOfQuestion { Id = 508, QuestionText = "Which quantity remains constant in an isolated system according to the law of conservation of momentum?", OptionA = "Velocity", OptionB = "Acceleration", OptionC = "Total momentum", OptionD = "Force", CorrectAnswer = "C", ExamId = 35 },
                new BankOfQuestion { Id = 509, QuestionText = "A concave lens always produces images that are:", OptionA = "Real and inverted", OptionB = "Virtual and upright", OptionC = "Real and upright", OptionD = "Virtual and inverted", CorrectAnswer = "B", ExamId = 35 },
                new BankOfQuestion { Id = 510, QuestionText = "The resistance of a wire is directly proportional to its length and inversely proportional to its:", OptionA = "Temperature", OptionB = "Cross-sectional area", OptionC = "Voltage", OptionD = "Current", CorrectAnswer = "B", ExamId = 35 },
                new BankOfQuestion { Id = 511, QuestionText = "Which type of nuclear decay involves the emission of an electron?", OptionA = "Alpha decay", OptionB = "Beta-minus decay", OptionC = "Gamma decay", OptionD = "Positron emission (Beta-plus decay)", CorrectAnswer = "B", ExamId = 35 },
                new BankOfQuestion { Id = 512, QuestionText = "The frequency of a wave is related to its wavelength (λ) and speed (v) by the equation:", OptionA = "f = vλ", OptionB = "f = v/λ", OptionC = "f = λ/v", OptionD = "f = v + λ", CorrectAnswer = "B", ExamId = 35 },
                new BankOfQuestion { Id = 513, QuestionText = "In a uniform circular motion, the acceleration vector is always directed:", OptionA = "Tangent to the circle", OptionB = "Away from the center", OptionC = "Towards the center of the circle", OptionD = "In the direction of velocity", CorrectAnswer = "C", ExamId = 35 },
                new BankOfQuestion { Id = 514, QuestionText = "Special Relativity postulates that the laws of physics are the same in all inertial frames and that the speed of light in a vacuum is:", OptionA = "Relative to the observer", OptionB = "Constant for all observers", OptionC = "Dependent on the source's speed", OptionD = "Variable", CorrectAnswer = "B", ExamId = 35 },
                new BankOfQuestion { Id = 515, QuestionText = "The tendency of a system to move towards a state of greater disorder is described by the:", OptionA = "First Law of Thermodynamics", OptionB = "Second Law of Thermodynamics", OptionC = "Zeroth Law of Thermodynamics", OptionD = "Third Law of Thermodynamics", CorrectAnswer = "B", ExamId = 35 },

                // --- Additional Comprehensive Questions for Exam 53 (Biology Comprehensive Exam, lessonId = 105) ---
                // Existing: 456-460. New: 516-530
                new BankOfQuestion { Id = 516, QuestionText = "What is the primary molecule used by cells for energy currency?", OptionA = "Glucose", OptionB = "ATP (Adenosine Triphosphate)", OptionC = "DNA", OptionD = "RNA", CorrectAnswer = "B", ExamId = 53 },
                new BankOfQuestion { Id = 517, QuestionText = "The process where a cell divides to produce two genetically identical daughter cells is:", OptionA = "Meiosis", OptionB = "Mitosis", OptionC = "Fertilization", OptionD = "Binary Fission", CorrectAnswer = "B", ExamId = 53 },
                new BankOfQuestion { Id = 518, QuestionText = "Which of these is a key component of the cell membrane, forming a bilayer?", OptionA = "Cellulose", OptionB = "Phospholipids", OptionC = "Starch", OptionD = "Amino acids", CorrectAnswer = "B", ExamId = 53 },
                new BankOfQuestion { Id = 519, QuestionText = "The site of protein synthesis in a eukaryotic cell is the:", OptionA = "Nucleus", OptionB = "Mitochondrion", OptionC = "Ribosome", OptionD = "Golgi apparatus", CorrectAnswer = "C", ExamId = 53 },
                new BankOfQuestion { Id = 520, QuestionText = "Which kingdom do mushrooms and yeasts belong to?", OptionA = "Plantae", OptionB = "Animalia", OptionC = "Fungi", OptionD = "Protista", CorrectAnswer = "C", ExamId = 53 },
                new BankOfQuestion { Id = 521, QuestionText = "The observable characteristics of an organism, resulting from its genotype and environment, are its:", OptionA = "Genotype", OptionB = "Phenotype", OptionC = "Allele", OptionD = "Genome", CorrectAnswer = "B", ExamId = 53 },
                new BankOfQuestion { Id = 522, QuestionText = "What is the primary role of chlorophyll in photosynthesis?", OptionA = "To absorb light energy", OptionB = "To produce glucose", OptionC = "To release oxygen", OptionD = "To transport water", CorrectAnswer = "A", ExamId = 53 },
                new BankOfQuestion { Id = 523, QuestionText = "A group of individuals of the same species living in the same area is called a:", OptionA = "Community", OptionB = "Ecosystem", OptionC = "Population", OptionD = "Biome", CorrectAnswer = "C", ExamId = 53 },
                new BankOfQuestion { Id = 524, QuestionText = "Which human body system is primarily responsible for transporting oxygen, nutrients, and waste?", OptionA = "Respiratory System", OptionB = "Digestive System", OptionC = "Circulatory System", OptionD = "Nervous System", CorrectAnswer = "C", ExamId = 53 },
                new BankOfQuestion { Id = 525, QuestionText = "The process by which DNA makes a copy of itself is called:", OptionA = "Transcription", OptionB = "Translation", OptionC = "Replication", OptionD = "Mutation", CorrectAnswer = "C", ExamId = 53 },
                new BankOfQuestion { Id = 526, QuestionText = "What are enzymes primarily composed of?", OptionA = "Lipids", OptionB = "Carbohydrates", OptionC = "Nucleic Acids", OptionD = "Proteins", CorrectAnswer = "D", ExamId = 53 },
                new BankOfQuestion { Id = 527, QuestionText = "The interaction between two different species where both benefit is called:", OptionA = "Parasitism", OptionB = "Commensalism", OptionC = "Mutualism", OptionD = "Predation", CorrectAnswer = "C", ExamId = 53 },
                new BankOfQuestion { Id = 528, QuestionText = "Which of the following is a characteristic of prokaryotic cells but not eukaryotic cells?", OptionA = "Presence of a nucleus", OptionB = "Membrane-bound organelles", OptionC = "Circular DNA not enclosed in a nucleus", OptionD = "Multiple linear chromosomes", CorrectAnswer = "C", ExamId = 53 },
                new BankOfQuestion { Id = 529, QuestionText = "Homeostasis refers to the ability of an organism to:", OptionA = "Reproduce rapidly", OptionB = "Maintain a stable internal environment", OptionC = "Evolve over time", OptionD = "Respond to external stimuli", CorrectAnswer = "B", ExamId = 53 },
                new BankOfQuestion { Id = 530, QuestionText = "The first trophic level in an ecosystem is typically occupied by:", OptionA = "Herbivores", OptionB = "Carnivores", OptionC = "Producers (e.g., plants)", OptionD = "Decomposers", CorrectAnswer = "C", ExamId = 53 },

                // --- Additional Comprehensive Questions for Exam 70 (Chemistry Comprehensive Exam, lessonId = 139) ---
                // Existing: 461-465. New: 531-545
                new BankOfQuestion { Id = 531, QuestionText = "The number of protons in an atom's nucleus defines its:", OptionA = "Mass number", OptionB = "Atomic number", OptionC = "Isotope", OptionD = "Ion charge", CorrectAnswer = "B", ExamId = 70 },
                new BankOfQuestion { Id = 532, QuestionText = "Which of the following is an example of a noble gas?", OptionA = "Oxygen (O)", OptionB = "Nitrogen (N)", OptionC = "Helium (He)", OptionD = "Hydrogen (H)", CorrectAnswer = "C", ExamId = 70 },
                new BankOfQuestion { Id = 533, QuestionText = "A solution with a pH of 3 is considered:", OptionA = "Strongly acidic", OptionB = "Weakly acidic", OptionC = "Neutral", OptionD = "Weakly basic", CorrectAnswer = "A", ExamId = 70 },
                new BankOfQuestion { Id = 534, QuestionText = "What type of reaction involves the loss of electrons by a chemical species?", OptionA = "Reduction", OptionB = "Oxidation", OptionC = "Neutralization", OptionD = "Hydration", CorrectAnswer = "B", ExamId = 70 },
                new BankOfQuestion { Id = 535, QuestionText = "Avogadro's number (approximately 6.022 x 10^23) represents the number of entities in one:", OptionA = "Gram", OptionB = "Liter", OptionC = "Mole", OptionD = "Milliliter", CorrectAnswer = "C", ExamId = 70 },
                new BankOfQuestion { Id = 536, QuestionText = "Which of these is a characteristic property of metals?", OptionA = "Poor conductor of electricity", OptionB = "Brittle solid", OptionC = "Forms anions readily", OptionD = "Good conductor of heat and electricity", CorrectAnswer = "D", ExamId = 70 },
                new BankOfQuestion { Id = 537, QuestionText = "The law of conservation of mass states that in a chemical reaction:", OptionA = "Energy is conserved", OptionB = "Mass is conserved", OptionC = "Volume is conserved", OptionD = "Moles are conserved", CorrectAnswer = "B", ExamId = 70 },
                new BankOfQuestion { Id = 538, QuestionText = "Which branch of chemistry deals primarily with carbon-containing compounds?", OptionA = "Inorganic Chemistry", OptionB = "Organic Chemistry", OptionC = "Physical Chemistry", OptionD = "Analytical Chemistry", CorrectAnswer = "B", ExamId = 70 },
                new BankOfQuestion { Id = 539, QuestionText = "A catalyst increases the rate of a chemical reaction by:", OptionA = "Increasing the activation energy", OptionB = "Decreasing the activation energy", OptionC = "Increasing the temperature", OptionD = "Shifting the equilibrium", CorrectAnswer = "B", ExamId = 70 },
                new BankOfQuestion { Id = 540, QuestionText = "What is the general formula for alkanes?", OptionA = "CnH2n", OptionB = "CnH2n+2", OptionC = "CnH2n-2", OptionD = "CnHn", CorrectAnswer = "B", ExamId = 70 },
                new BankOfQuestion { Id = 541, QuestionText = "The process by which a solid changes directly to a gas without passing through the liquid phase is called:", OptionA = "Melting", OptionB = "Evaporation", OptionC = "Sublimation", OptionD = "Condensation", CorrectAnswer = "C", ExamId = 70 },
                new BankOfQuestion { Id = 542, QuestionText = "Which of the following elements is a halogen?", OptionA = "Sodium (Na)", OptionB = "Calcium (Ca)", OptionC = "Chlorine (Cl)", OptionD = "Sulfur (S)", CorrectAnswer = "C", ExamId = 70 },
                new BankOfQuestion { Id = 543, QuestionText = "The empirical formula of a compound represents:", OptionA = "The actual number of atoms of each element", OptionB = "The simplest whole-number ratio of atoms", OptionC = "The structural arrangement of atoms", OptionD = "The molecular weight of the compound", CorrectAnswer = "B", ExamId = 70 },
                new BankOfQuestion { Id = 544, QuestionText = "What is the main component of natural gas?", OptionA = "Ethane", OptionB = "Propane", OptionC = "Methane", OptionD = "Butane", CorrectAnswer = "C", ExamId = 70 },
                new BankOfQuestion { Id = 545, QuestionText = "In an exothermic reaction, heat is:", OptionA = "Absorbed by the system", OptionB = "Released by the system", OptionC = "Neither absorbed nor released", OptionD = "Converted to work", CorrectAnswer = "B", ExamId = 70 },

                // --- Additional Comprehensive Questions for Exam 88 (English & Literature Comprehensive Exam, lessonId = 175) ---
                // Existing: 466-470. New: 546-560
                new BankOfQuestion { Id = 546, QuestionText = "A story told from the 'I' perspective is using which point of view?", OptionA = "Second-person", OptionB = "Third-person limited", OptionC = "First-person", OptionD = "Third-person omniscient", CorrectAnswer = "C", ExamId = 88 },
                new BankOfQuestion { Id = 547, QuestionText = "The use of 'like' or 'as' to compare two unlike things is a:", OptionA = "Metaphor", OptionB = "Simile", OptionC = "Personification", OptionD = "Hyperbole", CorrectAnswer = "B", ExamId = 88 },
                new BankOfQuestion { Id = 548, QuestionText = "Which punctuation mark is used to indicate a pause or to separate items in a series?", OptionA = "Period (.)", OptionB = "Comma (,)", OptionC = "Semicolon (;)", OptionD = "Question Mark (?)", CorrectAnswer = "B", ExamId = 88 },
                new BankOfQuestion { Id = 549, QuestionText = "The underlying meaning or message the author conveys in a literary work is the:", OptionA = "Plot", OptionB = "Setting", OptionC = "Theme", OptionD = "Conflict", CorrectAnswer = "C", ExamId = 88 },
                new BankOfQuestion { Id = 550, QuestionText = "A character who opposes the main character is the:", OptionA = "Protagonist", OptionB = "Narrator", OptionC = "Antagonist", OptionD = "Foil", CorrectAnswer = "C", ExamId = 88 },
                new BankOfQuestion { Id = 551, QuestionText = "What part of speech describes a noun or pronoun (e.g., 'beautiful' flower)?", OptionA = "Adverb", OptionB = "Verb", OptionC = "Adjective", OptionD = "Preposition", CorrectAnswer = "C", ExamId = 88 },
                new BankOfQuestion { Id = 552, QuestionText = "The structure of a sentence, including the arrangement of words and phrases, is known as:", OptionA = "Diction", OptionB = "Syntax", OptionC = "Tone", OptionD = "Imagery", CorrectAnswer = "B", ExamId = 88 },
                new BankOfQuestion { Id = 553, QuestionText = "Which literary genre typically features a hero on a quest, often involving supernatural elements?", OptionA = "Realism", OptionB = "Historical Fiction", OptionC = "Epic", OptionD = "Satire", CorrectAnswer = "C", ExamId = 88 },
                new BankOfQuestion { Id = 554, QuestionText = "A writer's attitude toward the subject or audience, conveyed through word choice and style, is the:", OptionA = "Mood", OptionB = "Tone", OptionC = "Theme", OptionD = "Plot", CorrectAnswer = "B", ExamId = 88 },
                new BankOfQuestion { Id = 555, QuestionText = "In essay writing, the sentence that states the main argument or purpose of the essay is the:", OptionA = "Topic sentence", OptionB = "Supporting detail", OptionC = "Thesis statement", OptionD = "Conclusion", CorrectAnswer = "C", ExamId = 88 },
                new BankOfQuestion { Id = 556, QuestionText = "Giving human qualities to an inanimate object or animal is called:", OptionA = "Simile", OptionB = "Metaphor", OptionC = "Personification", OptionD = "Allusion", CorrectAnswer = "C", ExamId = 88 },
                new BankOfQuestion { Id = 557, QuestionText = "A short, amusing or interesting story about a real incident or person is an:", OptionA = "Allegory", OptionB = "Anecdote", OptionC = "Analogy", OptionD = "Aphorism", CorrectAnswer = "B", ExamId = 88 },
                new BankOfQuestion { Id = 558, QuestionText = "Which of the following is a type of non-fiction that tells the story of a person's life, written by that person?", OptionA = "Biography", OptionB = "Autobiography", OptionC = "Memoir", OptionD = "Journal", CorrectAnswer = "B", ExamId = 88 }, // Memoir is often a part, Autobiography is the whole life.
                new BankOfQuestion { Id = 559, QuestionText = "The feeling or atmosphere that a writer creates for the reader is the:", OptionA = "Tone", OptionB = "Mood", OptionC = "Style", OptionD = "Voice", CorrectAnswer = "B", ExamId = 88 },
                new BankOfQuestion { Id = 560, QuestionText = "The literary technique of using humor, irony, exaggeration, or ridicule to expose and criticize people's stupidity or vices is:", OptionA = "Pathos", OptionB = "Logos", OptionC = "Satire", OptionD = "Foreshadowing", CorrectAnswer = "C", ExamId = 88 }
            );



        }
    }
}
