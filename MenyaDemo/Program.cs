using Microsoft.AspNetCore.Http;

namespace MenyaDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            #region Built in Middleware
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            // app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            #endregion

            #region Custom Middleware

            //app.Use(async(httpcontext, next) =>
            //{
            //   await httpcontext.Response.WriteAsync("1- Middelware 1 \n");
            //   await next.Invoke();
            //   await httpcontext.Response.WriteAsync("1- Middelware 1 - 1 \n");
            //});

            //app.Use(async (httpcontext, next) =>
            //{
            //    await httpcontext.Response.WriteAsync("2- Middelware 2 \n");
            //    await next.Invoke();
            //    await httpcontext.Response.WriteAsync("2- Middelware 2 - 2 \n");
            //});

            //app.Run(async(HttpContext) => //terminate
            //{
            //    await HttpContext.Response.WriteAsync("3- Terminate\n");
            //});
            //app.Use(async (httpcontext, next) =>
            //{
            //    await httpcontext.Response.WriteAsync("2- Middelware 2 \n");
            //    await next.Invoke();
            //    await httpcontext.Response.WriteAsync("2- Middelware 2 - 2 \n");
            //});



            #endregion

            app.Run();
        }
    }
}