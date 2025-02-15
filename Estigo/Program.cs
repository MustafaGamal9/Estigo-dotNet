using Estigo.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Models.Security;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Estigo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // ✅ 1️⃣ إضافة الخدمات إلى الـ Container
            builder.Services.AddControllers();

            // ✅ 2️⃣ تسجيل قاعدة البيانات
            builder.Services.AddDbContext<EstigoDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("cs"));
            });

            // ✅ 3️⃣ تسجيل هوية المستخدم Identity مع ApplicationUser
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<EstigoDbContext>()
                .AddDefaultTokenProviders();

            // ✅ 4️⃣ تسجيل JWT Authentication
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = "yourIssuer",
                        ValidAudience = "yourAudience",
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("yourSecretKey"))
                    };
                });

            // ✅ 5️⃣ تفعيل Authorization مع سياسة "Admin"
            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin", policy => policy.RequireRole("Admin"));
            });

            builder.Services.AddSingleton<IEmailSender<ApplicationUser>, EmailSender>(); // Update the namespace to use the correct EmailSender

            // ✅ 6️⃣ إضافة Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // ✅ 7️⃣ ضبط الـ Middleware
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // ... other code ...


            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthentication(); // ✅ تشغيل المصادقة أولًا
            app.UseAuthorization();  // ✅ ثم التصاريح

            app.MapControllers();
            app.MapIdentityApi<ApplicationUser>(); // ✅ تصحيح المشكلة

            app.Run();
        }
    }
}
