using Catalog.Api.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var products = new List<Product>
{
    new(1, "Laptop Dell", 4200m),
    new(2, "Mouse Logitech", 120m),
    new(3, "Monitor LG", 980m)
};

app.MapGet("/products", () =>
{
    return TypedResults.Ok(products);
})
.WithName("GetProducts")
.WithOpenApi();

app.Run();
