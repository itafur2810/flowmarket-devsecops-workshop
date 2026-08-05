var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapGet("/", () =>
{
    return TypedResults.Ok(new
    {
        Service = "Gateway.Api",
        Status = "Running",
        Timestamp = DateTime.UtcNow
    });
})
.WithName("GatewayHealth")
.WithOpenApi();

app.Run();