namespace Orders.Api.Models;

public record Order(
    int Id,
    int ProductId,
    int Quantity,
    decimal Total
);
