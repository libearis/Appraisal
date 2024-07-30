using AppraisalDataAccess;

using AppraisalAPI.Configurations;

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                    policy =>
                    {
                        policy.WithOrigins("https://localhost:8080").AllowAnyHeader().AllowAnyMethod();
                    });
});

// Add services to the container.
IConfiguration configuration = builder.Configuration;
IServiceCollection services = builder.Services;

builder.Services.AddEndpointsApiExplorer();
services.AddControllersWithViews();
Dependencies.ConfigureService(configuration, services);
services.AddSwaggerGen();
services.AddControllers();
services.AddBussinessServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
