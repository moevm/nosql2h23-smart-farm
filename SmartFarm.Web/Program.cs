using MongoFramework;
using Radzen;
using SmartFarm.Web.Data;

namespace SmartFarm.Web
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages();
            builder.Services.AddRadzenComponents();
            builder.Services.AddScoped<DialogService>();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddTransient<IMongoDbConnection>(
                _ => MongoDbConnection.FromConnectionString(builder.Configuration.GetConnectionString("MongoConnectionString"))
            );

            builder.Services.AddTransient<ApplicationMongoContext>();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}