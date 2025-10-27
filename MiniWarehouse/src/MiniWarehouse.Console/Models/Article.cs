namespace MiniWarehouse.Console.Models;

/// <summary>
/// Represents an article in the warehouse.
/// </summary>

 public class Article
    {
        public int Id { get; set; }
        public string Sku { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int MinQuantity { get; set; }
    }