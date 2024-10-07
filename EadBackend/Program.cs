using MongoDB.Driver;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using EadBackend.Repositories;
using EadBackend.Services;
using EadBackend.Auth;

var builder = WebApplication.CreateBuilder(args);

// Add CORS services
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// Add MongoDB settings from appsettings.json
builder.Services.Configure<MongoDatabaseSettings>(
    builder.Configuration.GetSection("MongoDB"));

// Register MongoDB client
builder.Services.AddSingleton<IMongoClient>(sp =>
{
    var settings = sp.GetRequiredService<IOptions<MongoDatabaseSettings>>().Value;
    return new MongoClient(settings.ConnectionString);
});

// Register repositories and services
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IShopRepository, ShopRepository>();
builder.Services.AddScoped<IShopService, ShopService>();
builder.Services.AddScoped<IShopItemRepository, ShopItemRepository>();
builder.Services.AddScoped<IShopItemService, ShopItemService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<ReviewService>();
builder.Services.AddScoped<IJwtUtils, JwtUtils>();

// Add controllers
builder.Services.AddControllers();

// Configure JWT authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890")),
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidIssuer = "EadProject",
            ValidAudience = "EadProjectUsers",
            ClockSkew = TimeSpan.Zero
        };
    });

// Add authorization
builder.Services.AddAuthorization();

// Add Swagger/OpenAPI support
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Use CORS middleware
app.UseCors("AllowAll");

// Add authentication and authorization middleware
app.UseAuthentication();
app.UseAuthorization();

// Map health check
app.MapGet("/health", () => Results.Ok("Healthy")).AllowAnonymous();

// Map controllers
app.MapControllers();

app.Run();

// MongoDB settings class
public class MongoDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;
    public string DatabaseName { get; set; } = null!;
}