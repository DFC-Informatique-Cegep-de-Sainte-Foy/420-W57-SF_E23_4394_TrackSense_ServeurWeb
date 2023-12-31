using Microsoft.EntityFrameworkCore;

using TrackSense.API.Entities.Interfaces;
using TrackSense.API.Data;
using TrackSense.API.Services.ServiceUsers;
using TrackSense.API.Services.ServiceRides;
//using TrackSense.API.Services.ServiceComptes;

namespace TrackSense.API
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                            throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<TracksenseContext>(options => options.UseMySQL(connectionString));
            //builder.Services.AddDbContext<TracksenseContext>(options => options.UseSqlServer(connectionString));
            Console.WriteLine("Connection String: " + connectionString);
            //Database : MySQL
            /*builder.Services.AddScoped<IDepotUsers, DepotUsersMySQL>();
            builder.Services.AddScoped<IDepotRides, DepotRidesMySQL>();*/

            // Database : 
            builder.Services.AddScoped<IDepotUsers, DepotUsers_MySQL>();
            builder.Services.AddScoped<IDepotRides, DepotRides_MySQL>();

            //builder.Services.AddScoped<IDepotCompteUser, DepotCompteUser>();

            builder.Services.AddScoped<ManipulationUsers>();
            builder.Services.AddScoped<ManipulationRides>();

            builder.Services.AddControllers();

            builder.Services.AddControllersWithViews();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options => options.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

         /*   builder.Services.AddIdentity<User, IdentityRole>()
                            .AddEntityFrameworkStores<TracksenseContext>()
                            .AddDefaultTokenProviders();*/
            // Authentication
           /* builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                            .AddJwtBearer(options =>
                            {
                                options.SaveToken = true;
                                options.RequireHttpsMetadata = false;
                                options.TokenValidationParameters = new TokenValidationParameters
                                {
                                    ValidateIssuer = true,
                                    ValidateAudience = true,
                                    ValidateLifetime = true,
                                    ValidateIssuerSigningKey = true,

                                    ValidIssuer = builder.Configuration["Jwt:ValidIssuer"],
                                    ValidAudience = builder.Configuration["Jwt:ValidAudience"],
                                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:SecretKey"]))
                                };
                            });*/

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseSwagger();
                app.UseSwaggerUI();
          /*  if (app.Environment.IsDevelopment())
            {
            }
*/
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }

    }
}
