using Microsoft.EntityFrameworkCore;
using Repositories;
using Microsoft.AspNetCore.Identity;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Services.Contrats;

namespace ElsiumC.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            // MariaDB bağlantısını yapılandırma
            services.AddDbContext<RepositoryContext>(options =>
                options.UseMySql(
                    configuration.GetConnectionString("DefaultConnection"),
                    new MySqlServerVersion(new Version(8, 0, 28)),
                    mysqlOptions => mysqlOptions.EnableRetryOnFailure()
                    .MigrationsAssembly("Elsiumc")
                ));
        }

        public static void ConfigureDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAuthManager, AuthManager>();
            services.AddScoped<UserManager<IdentityCitizen>>();
            services.AddScoped<RoleManager<IdentityRole>>();
        }

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<IdentityCitizen, IdentityRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 8;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
            })
            .AddEntityFrameworkStores<RepositoryContext>()
            .AddDefaultTokenProviders();
        }


        public static async Task AddDefaultAdmin(this IServiceProvider serviceProvider)
{
    var userManager = serviceProvider.GetRequiredService<UserManager<IdentityCitizen>>();  // IdentityCitizen tipi kullanılmalı
    var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

    string adminRole = "Admin";
    string adminName = "Admin";
    string adminEmail = "admin@example.com";
    string adminPassword = "Admin123!";

    // Admin rolünü oluştur
    if (!await roleManager.RoleExistsAsync(adminRole))
    {
        await roleManager.CreateAsync(new IdentityRole(adminRole));
    }

    // Admin kullanıcıyı oluştur
    var adminUser = await userManager.FindByNameAsync(adminName);
    if (adminUser == null)
    {
        // Admin kullanıcısını oluştur
        adminUser = new IdentityCitizen
        {
            UserName = adminName,
            Email = adminEmail,
            EmailConfirmed = true,
            FirstName = "Admin",
            LastName = "Admin"
        };

        var createUserResult = await userManager.CreateAsync(adminUser, adminPassword);
        if (createUserResult.Succeeded)
        {
            // Rolü kullanıcıya ata
            await userManager.AddToRoleAsync(adminUser, adminRole);
        }
        else
        {
            // Kullanıcı oluşturulamadıysa hata mesajlarını yazdırabiliriz
            foreach (var error in createUserResult.Errors)
            {
                Console.WriteLine($"Error creating admin user: {error.Description}");
            }
        }
    }
    else
    {
        // Eğer kullanıcı zaten varsa, rol eklemeyi kontrol et
        if (!await userManager.IsInRoleAsync(adminUser, adminRole))
        {
            await userManager.AddToRoleAsync(adminUser, adminRole);
        }
    }
}


        public static void MigrateDatabase(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<RepositoryContext>();
                context.Database.EnsureCreated(); // Eğer veritabanı yoksa oluşturur.
                context.Database.Migrate();      // Migrasyonları uygular.
            }
        }

        public static void MapControllersRoute(this IEndpointRouteBuilder app)
        {
            app.MapAreaControllerRoute(
                name: "AdminArea",
                areaName: "Admin",
                pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
            );

            app.MapAreaControllerRoute(
                name: "CitizenArea",
                areaName: "Citizen",
                pattern: "Citizen/{controller=Home}/{action=Index}/{id?}"
            );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
            );
        }
    }
}
