namespace MiniWarehouse.Console.Models;

/// <summary>Current stock level for an article.</summary>
public sealed class Stock
{
    public int ArticleId { get; set; }
    public int Quantity { get; set; }
}
