using CompleteAspNetCoreWebApi.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CompleteAspNetCoreWebApi.Data
{
    public class AppDbInitialzer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "1st Book Title",
                        Description = "1st Book Desciption",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        CoverUrl = "http://......",
                        DateAdded = DateTime.Now

                    },
                    new Book()
                    {
                        Title = "2st Book Title",
                        Description = "2st Book Desciption",
                        IsRead = true,
                        Genre = "Biography",
                        CoverUrl = "http://......",
                        DateAdded = DateTime.Now

                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
