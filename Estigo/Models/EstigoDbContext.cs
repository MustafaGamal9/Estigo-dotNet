using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Estigo.Models
{
    public class EstigoDbContext : IdentityDbContext<ApplicationUser>
    {



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning)); }
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

            //modelBuilder.Entity<ApplicationUser>()
            //    .Property(u => u.CreatedAt)
            //    .HasDefaultValueSql("GETDATE()");

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



            ////// 7. Teachers 
            //var biologyImageBytes = File.ReadAllBytes("wwwroot/image/Biology/biology-a2.jpg"); // Load image as byte array

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

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<lesson> lessons { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<StudentExamResult> StudentExamResults { get; set; }
        public DbSet<BankOfQuestion> BankOfQuestions { get; set; }
        public DbSet<Payment> Payments { get; set; }

    }
}
