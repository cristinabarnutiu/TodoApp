using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using TodoApp.Models;

namespace TodoApp.Data
{
    public class SeedData
    { 
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new TodoDbContext(serviceProvider.GetRequiredService<DbContextOptions<TodoDbContext>>()))
        {
            // Look for any movies.
            if (context.TodoItem.Any())
            {
                return;   // DB table has been seeded
            }

            context.TodoItem.AddRange(
                new TodoItem
                    {
                        Title = "Item 1",
                        Description = "Description 1",
                        AddedAt = DateTime.Now,
                        Deadline = DateTimeOffset.Now,
                        Importance = Importance.Low,
                        State = State.InProgress,
                        ClosedAt = DateTime.Now
                    },

                new TodoItem
                    {
                        Title = "Item 2",
                        Description = "Description 2",
                        AddedAt = DateTime.Now,
                        Deadline = DateTimeOffset.Now,
                        Importance = Importance.Low,
                        State = State.InProgress,
                        ClosedAt = DateTime.Now
                     }

            );
            context.SaveChanges();
        }
    }
}
}