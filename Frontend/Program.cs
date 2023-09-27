using Frontend.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var connection = String.Empty;
if (builder.Environment.IsDevelopment())
{
    builder.Configuration.AddEnvironmentVariables().AddJsonFile("appsettings.Development.json");
    connection = builder.Configuration.GetConnectionString("Azure");
}
else
{
    connection = Environment.GetEnvironmentVariable("Azure");
}

builder.Services.AddDbContext<CasaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Azure") ?? throw new InvalidOperationException("Connection string 'Azure' not found.")));

//builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<CasaContext>();
    context.Database.EnsureCreated();
    // DbInitializer.Initialize(context);
}

//if (!app.Environment.IsDevelopment())
//{
//app.UseExceptionHandler("/Error");
//app.UseHsts();
//}
//{
//    app.UseDeveloperExceptionPage();
//    app.UseMigrationsEndPoint();
//}

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

