var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));
builder.Services.AddSingleton<IBlogRepository, InMemoryBlogRepository>();

var app = builder.Build();
app.MapControllers();
app.Run();