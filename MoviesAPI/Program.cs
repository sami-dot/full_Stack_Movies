using Microsoft.EntityFrameworkCore;
using MoviesAPI.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MovieContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("MovieDbCS"))
);

var app = builder.Build();

using(var scope = app.Services.CreateScope()){
    var services = scope.ServiceProvider;

    try {
        var context = services.GetRequiredService<MovieContext>();
        await context.Database.MigrateAsync();
    }

    catch(Exception ex) {
        Console.WriteLine($"An error has occured while migrating database: {ex.Message}");
    }
}

app.MapGet("/", () => "Hello World!");

app.Run();
