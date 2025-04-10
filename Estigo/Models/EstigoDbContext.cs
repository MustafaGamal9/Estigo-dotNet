using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.IO;

namespace Estigo.Models
{
    public class EstigoDbContext : IdentityDbContext<ApplicationUser>
    {
        // uncomment to test the seed data
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

        public EstigoDbContext(DbContextOptions<EstigoDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // تحديد "Discriminator" تلقائيًا في الجدول AspNetUsers
            modelBuilder.Entity<ApplicationUser>()
                .HasDiscriminator<string>("UserType")
                .HasValue<Student>("Student")
                .HasValue<Admin>("Admin")
                .HasValue<Teacher>("Teacher")
                .HasValue<Parent>("Parent");

           // modelBuilder.Entity<ApplicationUser>()
           //     .Property(u => u.CreatedAt)
           //     .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Course>()
                        .HasMany(c => c.Payments)
                        .WithOne(p => p.Course)
                        .HasForeignKey(p => p.CourseId)
                        .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Student>()
                  .HasMany(s => s.Courses)
                  .WithMany(c => c.students)
                  .UsingEntity<MyCourse>(
                           j => j
                     .HasOne(mc => mc.Course)
                     .WithMany()
                     .HasForeignKey(mc => mc.CourseId)
                     .OnDelete(DeleteBehavior.Restrict),
                                  j => j
                     .HasOne(mc => mc.Student)
                     .WithMany()
                     .HasForeignKey(mc => mc.StudentId)
                     .OnDelete(DeleteBehavior.Restrict),
                          j =>
                          {
                              j.ToTable("MyCourses");
                              j.HasKey(mc => mc.MyCourseId);

                          });


            modelBuilder.Entity<Course>()
                .Property(c => c.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Course>()
                .Property(c => c.UpdatedAt)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Chapter>()
                .Property(c => c.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Chapter>()
                .Property(c => c.UpdatedAt)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<lesson>()
                .Property(l => l.lessonTitle)
                .HasMaxLength(100);

            modelBuilder.Entity<lesson>()
                .Property(l => l.lessonContent)
                .HasMaxLength(250);

            modelBuilder.Entity<lesson>()
                .Property(l => l.lessonVideo)
                .HasMaxLength(250);

            modelBuilder.Entity<lesson>()
                .Property(l => l.lessonDescription)
                .HasMaxLength(250);


            modelBuilder.Entity<lesson>()
                .Property(l => l.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<lesson>()
                .Property(l => l.UpdatedAt)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Exam>()
                .Property(l => l.CreatedAt)
                .HasDefaultValueSql("GETDATE()");


            modelBuilder.Entity<Exam>()
                .Property(l => l.UpdatedAt)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<StudentExamResult>()
                .Property(l => l.ExamDate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<ApplicationUser>()
                .Property(l => l.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Teacher)
                .WithMany(t => t.CoursesTaught)
                .HasForeignKey(c => c.TeacherId)  
                .OnDelete(DeleteBehavior.Restrict);

            //// Home Page Data ( most popular courses | meet our instructors ) 

            //// Seed Categories
            //modelBuilder.Entity<Category>().HasData(
            //    new Category { Id = 1, Name = "Mathematics" },
            //    new Category { Id = 2, Name = "Physics" },
            //    new Category { Id = 3, Name = "Biology" },
            //    new Category { Id = 4, Name = "Chemistry" },
            //    new Category { Id = 5, Name = "English" }


            modelBuilder.Entity<ApplicationUser>()
                .Property(l => l.UpdatedAt)
                .HasDefaultValueSql("GETDATE()");

            // SEED Data

            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Mathematics" },
                new Category { Id = 2, Name = "Physics" },
                new Category { Id = 3, Name = "Biology" },
                new Category { Id = 4, Name = "Chemistry" },
                new Category { Id = 5, Name = "English" });

            var seedDate = new DateTime(2024, 3, 29);
            //modelBuilder.Entity<Teacher>().HasData(
            //    new Teacher { Id = "teacher1-guid", Name = "Mustafa", Email = "teacher1@estigo.com", NormalizedEmail = "TEACHER1@ESTIGO.COM", UserName = "teacher1@estigo.com", NormalizedUserName = "TEACHER1@ESTIGO.COM", Phone = "123-111-1212", Gender = "Male", Subject = "Mathematics", Notes = "Expert in Algebra", image = biologyImageBytes },
            //    new Teacher { Id = "teacher2-guid", Name = "Mahmoud", Email = "teacher2@estigo.com", NormalizedEmail = "TEACHER2@ESTIGO.COM", UserName = "teacher2@estigo.com", NormalizedUserName = "TEACHER2@ESTIGO.COM", Phone = "123-222-2323", Gender = "Female", Subject = "Physics", Notes = "Specialist in Mechanics", image = biologyImageBytes },
            //    new Teacher { Id = "teacher3-guid", Name = "Ahmed", Email = "teacher3@estigo.com", NormalizedEmail = "TEACHER3@ESTIGO.COM", UserName = "teacher3@estigo.com", NormalizedUserName = "TEACHER3@ESTIGO.COM", Phone = "123-333-3434", Gender = "Male", Subject = "Biology", Notes = "Experienced in Cell Biology", image = biologyImageBytes },
            //    new Teacher { Id = "teacher4-guid", Name = "Mohamed", Email = "teacher4@estigo.com", NormalizedEmail = "TEACHER4@ESTIGO.COM", UserName = "teacher4@estigo.com", NormalizedUserName = "TEACHER4@ESTIGO.COM", Phone = "123-444-4545", Gender = "Female", Subject = "Chemistry", Notes = "Passionate about Organic Chemistry", image = biologyImageBytes },
            //    new Teacher { Id = "teacher5-guid", Name = "kareem", Email = "teacher5@estigo.com", NormalizedEmail = "TEACHER5@ESTIGO.COM", UserName = "teacher5@estigo.com", NormalizedUserName = "TEACHER5@ESTIGO.COM", Phone = "123-555-5656", Gender = "Male", Subject = "English", Notes = "Loves English Literature", image = biologyImageBytes },
            //    new Teacher { Id = "teacher6-guid", Name = "Teacher Six", Email = "teacher6@estigo.com", NormalizedEmail = "TEACHER6@ESTIGO.COM", UserName = "teacher6@estigo.com", NormalizedUserName = "TEACHER6@ESTIGO.COM", Phone = "123-666-6767", Gender = "Female", Subject = "History", Notes = "History Enthusiast", image = biologyImageBytes },
            //    new Teacher { Id = "teacher7-guid", Name = "Teacher Seven", Email = "teacher7@estigo.com", NormalizedEmail = "TEACHER7@ESTIGO.COM", UserName = "teacher7@estigo.com", NormalizedUserName = "TEACHER7@ESTIGO.COM", Phone = "123-777-7878", Gender = "Male", Subject = "Geography", Notes = "Geography Expert", image = biologyImageBytes },
            //     new Teacher { Id = "teacher8-guid", Name = "Teacher Eight", Email = "teacher8@estigo.com", NormalizedEmail = "TEACHER8@ESTIGO.COM", UserName = "teacher8@estigo.com", NormalizedUserName = "TEACHER8@ESTIGO.COM", Phone = "123-888-8989", Gender = "Female", Subject = "Computer Science", Notes = "Coding Guru", image = biologyImageBytes },
            //    new Teacher { Id = "teacher9-guid", Name = "Teacher Nine", Email = "teacher9@estigo.com", NormalizedEmail = "TEACHER9@ESTIGO.COM", UserName = "teacher9@estigo.com", NormalizedUserName = "TEACHER9@ESTIGO.COM", Phone = "123-999-9090", Gender = "Male", Subject = "Art", Notes = "Artistic Soul", image = biologyImageBytes },
            //    new Teacher { Id = "teacher10-guid", Name = "Teacher Ten", Email = "teacher10@estigo.com", NormalizedEmail = "TEACHER10@ESTIGO.COM", UserName = "teacher10@estigo.com", NormalizedUserName = "TEACHER10@ESTIGO.COM", Phone = "123-000-0101", Gender = "Female", Subject = "Music", Notes = "Music Lover", image = biologyImageBytes }
            //);

            // Seed Teachers
            modelBuilder.Entity<Teacher>().HasData(
                // Mathematics (2 teachers)
                new Teacher { Id = "t1", Name = "Mahmoud", Email = "math1@estigo.com", NormalizedEmail = "MATH1@ESTIGO.COM", UserName = "math1@estigo.com", NormalizedUserName = "MATH1@ESTIGO.COM", Gender = "Male", Subject = "Mathematics", Notes = "Expert in Algebra", Role = "Teacher", image = "http://est.runasp.net/mahmoud.jpg" },
                new Teacher { Id = "t2", Name = "Mousa", Email = "math2@estigo.com", NormalizedEmail = "MATH2@ESTIGO.COM", UserName = "math2@estigo.com", NormalizedUserName = "MATH2@ESTIGO.COM", Gender = "Male", Subject = "Mathematics", Notes = "Specialist in Calculus", Role = "Teacher", image = "http://est.runasp.net/b.jpeg" },

                // Physics (3 teachers)
                new Teacher { Id = "t3", Name = "Amira", Email = "phys1@estigo.com", NormalizedEmail = "PHYS1@ESTIGO.COM", UserName = "phys1@estigo.com", NormalizedUserName = "PHYS1@ESTIGO.COM", Gender = "Female", Subject = "Physics", Notes = "Specialist in Mechanics", Role = "Teacher", image = "http://est.runasp.net/g.jpeg" },
                new Teacher { Id = "t4", Name = "Noura", Email = "phys2@estigo.com", NormalizedEmail = "PHYS2@ESTIGO.COM", UserName = "phys2@estigo.com", NormalizedUserName = "PHYS2@ESTIGO.COM", Gender = "Female", Subject = "Physics", Notes = "Expert in Electromagnetism", Role = "Teacher", image = "http://est.runasp.net/q.jpg" },
                new Teacher { Id = "t5", Name = "Mustafa", Email = "phys3@estigo.com", NormalizedEmail = "PHYS3@ESTIGO.COM", UserName = "phys3@estigo.com", NormalizedUserName = "PHYS3@ESTIGO.COM", Gender = "Male", Subject = "Physics", Notes = "Enthusiast in Quantum Physics", Role = "Teacher", image = "http://est.runasp.net/b.jpeg" },

                // Biology (2 teachers)
                new Teacher { Id = "t6", Name = "Ahmed", Email = "bio1@estigo.com", NormalizedEmail = "BIO1@ESTIGO.COM", UserName = "bio1@estigo.com", NormalizedUserName = "BIO1@ESTIGO.COM", Gender = "Male", Subject = "Biology", Notes = "Expert in Cell Biology", Role = "Teacher", image = "http://est.runasp.net/c.jpeg" },
                new Teacher { Id = "t7", Name = "Karim", Email = "bio2@estigo.com", NormalizedEmail = "BIO2@ESTIGO.COM", UserName = "bio2@estigo.com", NormalizedUserName = "BIO2@ESTIGO.COM", Gender = "Male", Subject = "Biology", Notes = "Specialist in Genetics", Role = "Teacher", image = "http://est.runasp.net/d.jpeg" },

                // Chemistry (4 teachers)
                new Teacher { Id = "t8", Name = "Mohamed", Email = "chem1@estigo.com", NormalizedEmail = "CHEM1@ESTIGO.COM", UserName = "chem1@estigo.com", NormalizedUserName = "CHEM1@ESTIGO.COM", Gender = "Male", Subject = "Chemistry", Notes = "Passionate about Organic Chemistry", Role = "Teacher", image = "http://est.runasp.net/f.jpg" },
                new Teacher { Id = "t9", Name = "Noura", Email = "chem2@estigo.com", NormalizedEmail = "CHEM2@ESTIGO.COM", UserName = "chem2@estigo.com", NormalizedUserName = "CHEM2@ESTIGO.COM", Gender = "Female", Subject = "Chemistry", Notes = "Expert in Inorganic Chemistry", Role = "Teacher", image = "http://est.runasp.net/m.jpg" },
                new Teacher { Id = "t10", Name = "Fahad", Email = "chem3@estigo.com", NormalizedEmail = "CHEM3@ESTIGO.COM", UserName = "chem3@estigo.com", NormalizedUserName = "CHEM3@ESTIGO.COM", Gender = "Male", Subject = "Chemistry", Notes = "Skilled in Analytical Chemistry", Role = "Teacher", image = "http://est.runasp.net/f.jpg" },
                new Teacher { Id = "t11", Name = "Sara", Email = "chem4@estigo.com", NormalizedEmail = "CHEM4@ESTIGO.COM", UserName = "chem4@estigo.com", NormalizedUserName = "CHEM4@ESTIGO.COM", Gender = "Female", Subject = "Chemistry", Notes = "Focused on Physical Chemistry", Role = "Teacher", image = "http://est.runasp.net/sarah.jpg" },

                // English (2 teachers)
                new Teacher { Id = "t12", Name = "Sarah", Email = "eng1@estigo.com", NormalizedEmail = "ENG1@ESTIGO.COM", UserName = "eng1@estigo.com", NormalizedUserName = "ENG1@ESTIGO.COM", Gender = "Female", Subject = "English", Notes = "Literature Specialist", Role = "Teacher", image = "http://est.runasp.net/amira.jpg" },
                new Teacher { Id = "t13", Name = "John", Email = "eng2@estigo.com", NormalizedEmail = "ENG2@ESTIGO.COM", UserName = "eng2@estigo.com", NormalizedUserName = "ENG2@ESTIGO.COM", Gender = "Male", Subject = "English", Notes = "Expert in Creative Writing", Role = "Teacher", image = "http://est.runasp.net/f.jpg" }
            );

            // Seed Courses - Distribute 7 courses per category among the available teachers
            modelBuilder.Entity<Course>().HasData(
                // Mathematics Courses (CategoryId = 1) rotating between teachers "t1" and "t2"
                new Course { CourseId = 1, CourseTitle = "Algebra | Unit 1", Description = "Introduction to algebraic concepts", Price = 199, Available = true, CategoryId = 1, TeacherId = "t1", CreatedAt = seedDate, Logo = "http://est.runasp.net/algebra.jpg" },
                new Course { CourseId = 2, CourseTitle = "Calculus | Unit 2", Description = "Fundamentals of differential calculus", Price = 199, Available = true, CategoryId = 1, TeacherId = "t2", CreatedAt = seedDate, Logo = "http://est.runasp.net/calculas.jpeg" },
                new Course { CourseId = 3, CourseTitle = "Geometry | Unit 3", Description = "Basics of geometric shapes and theorems", Price = 189, Available = true, CategoryId = 1, TeacherId = "t1", CreatedAt = seedDate, Logo = "http://est.runasp.net/geo.jpeg" },
                new Course { CourseId = 4, CourseTitle = "Trigonometry | Unit 4", Description = "Understanding angles and trigonometric functions", Price = 189, Available = true, CategoryId = 1, TeacherId = "t2", CreatedAt = seedDate, Logo = "http://est.runasp.net/trig.jpeg" },
                new Course { CourseId = 5, CourseTitle = "Statistics | Unit 5", Description = "Introduction to data analysis and probability", Price = 179, Available = true, CategoryId = 1, TeacherId = "t1", CreatedAt = seedDate, Logo = "http://est.runasp.net/stat.jpeg" },
                new Course { CourseId = 6, CourseTitle = "Probability | Unit 6", Description = "Exploring probability theories and applications", Price = 179, Available = true, CategoryId = 1, TeacherId = "t2", CreatedAt = seedDate, Logo = "http://est.runasp.net/jpeg" },
                new Course { CourseId = 7, CourseTitle = "Discrete Math | Unit 7", Description = "Fundamentals of logic, set theory, and combinatorics", Price = 189, Available = true, CategoryId = 1, TeacherId = "t1", CreatedAt = seedDate, Logo = "http://est.runasp.net/disc.jpeg" },

                // Physics Courses (CategoryId = 2) rotating among teachers "t3", "t4", and "t5"
                new Course { CourseId = 8, CourseTitle = "Mechanics | Unit 1", Description = "Introduction to Newtonian mechanics", Price = 149, Available = true, CategoryId = 2, TeacherId = "t3", CreatedAt = seedDate, Logo = "http://est.runasp.net/mecha.jpg" },
                new Course { CourseId = 9, CourseTitle = "Electricity | Unit 2", Description = "Basics of electric circuits and fields", Price = 149, Available = true, CategoryId = 2, TeacherId = "t4", CreatedAt = seedDate, Logo = "http://est.runasp.net/elec.jpg" },
                new Course { CourseId = 10, CourseTitle = "Magnetism | Unit 3", Description = "Principles of magnetic forces and fields", Price = 159, Available = true, CategoryId = 2, TeacherId = "t5", CreatedAt = seedDate, Logo = "http://est.runasp.net/iron.jpg" },
                new Course { CourseId = 11, CourseTitle = "Optics | Unit 4", Description = "Study of light behavior and properties", Price = 159, Available = true, CategoryId = 2, TeacherId = "t3", CreatedAt = seedDate, Logo = "http://est.runasp.net/optics.jpeg" },
                new Course { CourseId = 12, CourseTitle = "Thermodynamics | Unit 5", Description = "Fundamentals of heat and energy", Price = 169, Available = true, CategoryId = 2, TeacherId = "t4", CreatedAt = seedDate, Logo = "http://est.runasp.net/thermo.jpeg" },
                new Course { CourseId = 13, CourseTitle = "Quantum Physics | Unit 6", Description = "Introduction to quantum theory", Price = 169, Available = true, CategoryId = 2, TeacherId = "t5", CreatedAt = seedDate, Logo = "http://est.runasp.net/quant.jpeg" },
                new Course { CourseId = 14, CourseTitle = "Relativity | Unit 7", Description = "Concepts of special and general relativity", Price = 169, Available = true, CategoryId = 2, TeacherId = "t3", CreatedAt = seedDate, Logo = "http://est.runasp.net/rela.jpg" },

                // Biology Courses (CategoryId = 3) rotating between teachers "t6" and "t7"
                new Course { CourseId = 15, CourseTitle = "Cell Biology | Unit 1", Description = "Study of cell structure and function", Price = 179, Available = true, CategoryId = 3, TeacherId = "t6", CreatedAt = seedDate, Logo = "http://est.runasp.net/cell.jpg" },
                new Course { CourseId = 16, CourseTitle = "Genetics | Unit 2", Description = "Introduction to heredity and DNA", Price = 179, Available = true, CategoryId = 3, TeacherId = "t7", CreatedAt = seedDate, Logo = "http://est.runasp.net/gena.jpeg" },
                new Course { CourseId = 17, CourseTitle = "Movement | Unit 3", Description = "Principles of Movement", Price = 189, Available = true, CategoryId = 3, TeacherId = "t6", CreatedAt = seedDate, Logo = "http://est.runasp.net/move.jpeg" },
                new Course { CourseId = 18, CourseTitle = "Ecology | Unit 4", Description = "Basics of ecosystems and environment", Price = 189, Available = true, CategoryId = 3, TeacherId = "t7", CreatedAt = seedDate, Logo = "http://est.runasp.net/eco.jpg" },
                new Course { CourseId = 19, CourseTitle = "Botany | Unit 5", Description = "Study of plant biology and physiology", Price = 179, Available = true, CategoryId = 3, TeacherId = "t6", CreatedAt = seedDate, Logo = "http://est.runasp.net/elec.jpg" },
                new Course { CourseId = 20, CourseTitle = "Zoology | Unit 6", Description = "Introduction to animal biology", Price = 179, Available = true, CategoryId = 3, TeacherId = "t7", CreatedAt = seedDate, Logo = "http://est.runasp.net/zoo.jpg" },
                new Course { CourseId = 21, CourseTitle = "Microbiology | Unit 7", Description = "Basics of microorganisms and their roles", Price = 189, Available = true, CategoryId = 3, TeacherId = "t6", CreatedAt = seedDate, Logo = "http://est.runasp.net/micro.jpg" },

                // Chemistry Courses (CategoryId = 4) rotating among teachers "t8", "t9", "t10", and "t11"
                new Course { CourseId = 22, CourseTitle = "Organic Chemistry | Unit 1", Description = "Introduction to organic compounds", Price = 159, Available = true, CategoryId = 4, TeacherId = "t8", CreatedAt = seedDate, Logo = "http://est.runasp.net/organic.jpeg" },
                new Course { CourseId = 23, CourseTitle = "Inorganic Chemistry | Unit 2", Description = "Fundamentals of inorganic substances", Price = 159, Available = true, CategoryId = 4, TeacherId = "t9", CreatedAt = seedDate, Logo = "http://est.runasp.net/inorganic.jpeg" },
                new Course { CourseId = 24, CourseTitle = "Physical Chemistry | Unit 3", Description = "Study of chemical thermodynamics and kinetics", Price = 169, Available = true, CategoryId = 4, TeacherId = "t10", CreatedAt = seedDate, Logo = "http://est.runasp.net/physChem.jpg" },
                new Course { CourseId = 25, CourseTitle = "Analytical Chemistry | Unit 4", Description = "Techniques for chemical analysis", Price = 169, Available = true, CategoryId = 4, TeacherId = "t11", CreatedAt = seedDate, Logo = "http://est.runasp.net/analyt.png" },
                new Course { CourseId = 26, CourseTitle = "Biochemistry | Unit 5", Description = "Chemical processes within living organisms", Price = 179, Available = true, CategoryId = 4, TeacherId = "t8", CreatedAt = seedDate, Logo = "http://est.runasp.net/biochem.jpeg" },
                new Course { CourseId = 27, CourseTitle = "Environmental Chemistry | Unit 6", Description = "Chemistry in environmental processes", Price = 179, Available = true, CategoryId = 4, TeacherId = "t9", CreatedAt = seedDate, Logo = "http://est.runasp.net/env.jpg" },
                new Course { CourseId = 28, CourseTitle = "Theoretical Chemistry | Unit 7", Description = "Conceptual frameworks of chemical behavior", Price = 169, Available = true, CategoryId = 4, TeacherId = "t10", CreatedAt = seedDate, Logo = "http://est.runasp.net/theo.jpeg" },

                // English Courses (CategoryId = 5) rotating between teachers "t12" and "t13"
                new Course { CourseId = 29, CourseTitle = "Literature | Unit 1", Description = "Exploring classic and modern literature", Price = 129, Available = true, CategoryId = 5, TeacherId = "t12", CreatedAt = seedDate, Logo = "http://est.runasp.net/lit.jpg" },
                new Course { CourseId = 30, CourseTitle = "Creative Writing | Unit 2", Description = "Develop storytelling and narrative skills", Price = 129, Available = true, CategoryId = 5, TeacherId = "t13", CreatedAt = seedDate, Logo = "http://est.runasp.net/write.jpg" },
                new Course { CourseId = 31, CourseTitle = "Grammar & Composition | Unit 3", Description = "Mastering the rules of English grammar", Price = 119, Available = true, CategoryId = 5, TeacherId = "t12", CreatedAt = seedDate, Logo = "http://est.runasp.net/gram.jpg" },
                new Course { CourseId = 32, CourseTitle = "Poetry Analysis | Unit 4", Description = "Study and analysis of poetry", Price = 119, Available = true, CategoryId = 5, TeacherId = "t13", CreatedAt = seedDate, Logo = "http://est.runasp.net/poe.png" },
                new Course { CourseId = 33, CourseTitle = "Drama & Theater | Unit 5", Description = "Introduction to dramatic literature and performance", Price = 129, Available = true, CategoryId = 5, TeacherId = "t12", CreatedAt = seedDate, Logo = "http://est.runasp.net/drama.jpg" },
                new Course { CourseId = 34, CourseTitle = "Fiction Writing | Unit 6", Description = "Techniques for writing compelling fiction", Price = 129, Available = true, CategoryId = 5, TeacherId = "t13", CreatedAt = seedDate, Logo = "http://est.runasp.net/fiction.jpeg" },
                new Course { CourseId = 35, CourseTitle = "Non-fiction Writing | Unit 7", Description = "Crafting engaging non-fiction narratives", Price = 119, Available = true, CategoryId = 5, TeacherId = "t12", CreatedAt = seedDate, Logo = "http://est.runasp.net/nonfic.jpg" }
            );

            // Seed data for Lessons (5 lessons for each course)
            modelBuilder.Entity<lesson>().HasData(
                // 5 Lessons for Course 1
                new lesson{ lessonId = 11, lessonTitle = "Introduction to C#", lessonDescription = "This lesson covers the basics of C# programming.", lessonContent = "This is the content of the lesson.", lessonVideo = "http://est.runasp.net/vv.mp4", courseId = 1, },
                new lesson{ lessonId = 12,lessonTitle = "C# Variables and Data Types",lessonDescription = "Learn about variables and data types in C#.",lessonContent = "This is the content of the lesson.",lessonVideo = "http://est.runasp.net/vv.mp4", courseId = 1,},
                new lesson{lessonId = 13,lessonTitle = "C# Control Structures",lessonDescription = "Learn about control structures in C#.",lessonContent = "This is the content of the lesson.",lessonVideo = "http://est.runasp.net/vv.mp4", courseId = 1,},
                new lesson{ lessonId = 14,lessonTitle = "C# Functions",lessonDescription = "Learn how to define and call functions in C#.",lessonContent = "This is the content of the lesson.",lessonVideo = "http://est.runasp.net/vv.mp4", courseId = 1,},
                new lesson{ lessonId = 15, lessonTitle = "C# Classes and Objects", lessonDescription = "Learn about classes and objects in C#.", lessonContent = "This is the content of the lesson.", lessonVideo = "http://est.runasp.net/vv.mp4", courseId = 1, },

                 // 5 Lessons for Course 2

                new lesson { lessonId = 16, lessonTitle = "Introduction to C#", lessonDescription = "This lesson covers the basics of C# programming.", lessonContent = "This is the content of the lesson.", lessonVideo = "http://est.runasp.net/vv.mp4", courseId = 2, },
                new lesson { lessonId = 17, lessonTitle = "C# Variables and Data Types", lessonDescription = "Learn about variables and data types in C#.", lessonContent = "This is the content of the lesson.", lessonVideo = "http://est.runasp.net/vv.mp4", courseId = 2, },
                new lesson { lessonId = 18, lessonTitle = "C# Control Structures", lessonDescription = "Learn about control structures in C#.", lessonContent = "This is the content of the lesson.", lessonVideo = "http://est.runasp.net/vv.mp4", courseId = 2, },
                new lesson { lessonId = 19, lessonTitle = "C# Functions", lessonDescription = "Learn how to define and call functions in C#.", lessonContent = "This is the content of the lesson.", lessonVideo = "http://est.runasp.net/vv.mp4", courseId = 2, },
                new lesson { lessonId = 20, lessonTitle = "C# Classes and Objects", lessonDescription = "Learn about classes and objects in C#.", lessonContent = "This is the content of the lesson.", lessonVideo = "http://est.runasp.net/vv.mp4", courseId = 2, }

            );

            modelBuilder.Entity<Exam>().HasData(
                // Exams for Course 1 (Lessons 11–15)
                new Exam { Id = 11, ExamTitle = "Exam: Introduction to C#", ExamDescription = "Test your knowledge of C# basics.", Grade = "Not Graded", CreatedAt = DateTime.UtcNow, courseId = 1, lessonId = 11 },
                new Exam { Id = 12, ExamTitle = "Exam: Variables and Data Types", ExamDescription = "Variables and types quiz.", Grade = "Not Graded", CreatedAt = DateTime.UtcNow, courseId = 1, lessonId = 12 },
                new Exam { Id = 13, ExamTitle = "Exam: Control Structures", ExamDescription = "Control flow evaluation.", Grade = "Not Graded", CreatedAt = DateTime.UtcNow, courseId = 1, lessonId = 13 },
                new Exam { Id = 14, ExamTitle = "Exam: Functions", ExamDescription = "Function usage test.", Grade = "Not Graded", CreatedAt = DateTime.UtcNow, courseId = 1, lessonId = 14 },
                new Exam { Id = 15, ExamTitle = "Exam: Classes and Objects", ExamDescription = "OOP concepts in C#.", Grade = "Not Graded", CreatedAt = DateTime.UtcNow, courseId = 1, lessonId = 15 },

                // Exams for Course 2 (Lessons 16–20)
                new Exam { Id = 16, ExamTitle = "Exam: Introduction to C#", ExamDescription = "Test your knowledge of C# basics.", Grade = "Not Graded", CreatedAt = DateTime.UtcNow, courseId = 2, lessonId = 16 },
                new Exam { Id = 17, ExamTitle = "Exam: Variables and Data Types", ExamDescription = "Variables and types quiz.", Grade = "Not Graded", CreatedAt = DateTime.UtcNow, courseId = 2, lessonId = 17 },
                new Exam { Id = 18, ExamTitle = "Exam: Control Structures", ExamDescription = "Control flow evaluation.", Grade = "Not Graded", CreatedAt = DateTime.UtcNow, courseId = 2, lessonId = 18 },
                new Exam { Id = 19, ExamTitle = "Exam: Functions", ExamDescription = "Function usage test.", Grade = "Not Graded", CreatedAt = DateTime.UtcNow, courseId = 2, lessonId = 19 },
                new Exam { Id = 20, ExamTitle = "Exam: Classes and Objects", ExamDescription = "OOP concepts in C#.", Grade = "Not Graded", CreatedAt = DateTime.UtcNow, courseId = 2, lessonId = 20 }
            );
            modelBuilder.Entity<BankOfQuestion>().HasData(
                 // Exam 11 Questions
                new BankOfQuestion{Id = 1,QuestionText = "What is the capital of France?",OptionA = "Paris",OptionB = "London",OptionC = "Rome",OptionD = "Berlin",CorrectAnswer = "A",ExamId = 11},
                new BankOfQuestion {Id = 2,QuestionText = "Which planet is known as the Red Planet?",OptionA = "Earth",OptionB = "Mars",OptionC = "Jupiter",OptionD = "Saturn",CorrectAnswer = "B",ExamId = 11},
                new BankOfQuestion{Id = 3,QuestionText = "What is 5 + 7?",OptionA = "10",OptionB = "11",OptionC = "12",OptionD = "13",CorrectAnswer = "C",ExamId = 11},
                new BankOfQuestion{Id = 4,QuestionText = "Which language is primarily used for Android development?",OptionA = "Java",OptionB = "Swift",OptionC = "Kotlin",OptionD = "C#",CorrectAnswer = "C",ExamId = 11},
                new BankOfQuestion{Id = 5,QuestionText = "What is the chemical symbol for water?",OptionA = "H2O",OptionB = "O2",OptionC = "CO2",OptionD = "NaCl",CorrectAnswer = "A",ExamId = 11},

             // Exam 12 Questions
                new BankOfQuestion{Id = 6,QuestionText = "What is the square root of 81?",OptionA = "8",OptionB = "9",OptionC = "10",OptionD = "7",CorrectAnswer = "B",ExamId = 12},
                new BankOfQuestion{Id = 7,QuestionText = "Who painted the Mona Lisa?",OptionA = "Vincent van Gogh",OptionB = "Leonardo da Vinci",OptionC = "Pablo Picasso",OptionD = "Michelangelo",CorrectAnswer = "B",ExamId = 12},
                new BankOfQuestion{Id = 8,QuestionText = "Which organ pumps blood through the body?",OptionA = "Brain",OptionB = "Lungs",OptionC = "Liver",OptionD = "Heart",CorrectAnswer = "D",ExamId = 12},
                new BankOfQuestion{Id = 9,QuestionText = "What is the largest planet in our solar system?",OptionA = "Earth",OptionB = "Mars",OptionC = "Jupiter",OptionD = "Saturn",CorrectAnswer = "C",ExamId = 12},
                new BankOfQuestion{Id = 10,QuestionText = "Which element has the atomic number 1?",OptionA = "Oxygen",OptionB = "Hydrogen",OptionC = "Helium",OptionD = "Carbon",CorrectAnswer = "B",ExamId = 12}
            );


        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
       // public DbSet<Chapter> Chapters { get; set; }
        public DbSet<lesson> lessons { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<StudentExamResult> StudentExamResults { get; set; }
        public DbSet<BankOfQuestion> BankOfQuestions { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public DbSet<MyCourse> MyCourses { get; set; }

    }
}

