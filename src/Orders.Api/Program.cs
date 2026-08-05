using Orders.Api.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

var orders = new List<Order>
{
    new(1001, 1, 2, 840m),
    new(1002, 2, 1, 120m)
};

app.MapGet("/orders", () =>
{
    return TypedResults.Ok(orders);
})
.WithName("GetOrders")
.WithOpenApi();

app.Run();
