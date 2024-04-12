using InternJohan.Dev.Infrastructure.Configuration;
//using InternJohan.Dev.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

//Database Settings
builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("ConnectionStrings"));

// Add services to the container.
//builder.Services.AddTransient<MovieRepository>();
//builder.Services.AddTransient<MovieService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CorsRule",
    builder =>
    {
        builder.WithOrigins("http://localhost:8080")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors("CorsRule");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
// Here you can see we make sure it doesn't start with /api, if it does, it'll 404 within .NET if it can't be found.
app.MapWhen(x => !x.Request.Path.StartsWithSegments("/api"), x =>
{
    app.UseSpa(spa =>
    {
        if (!builder.Environment.IsDevelopment())
            spa.Options.SourcePath = "wwwroot/clientapp";
        else
            app.UseSpa(spa => spa.Options.SourcePath = @"C:\Data\Repos\KEYnet\InternJohan.Dev.App\wwwroot\clientapp\");
    });
});
app.Run();
