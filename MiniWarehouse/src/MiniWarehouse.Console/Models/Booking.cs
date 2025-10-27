namespace MiniWarehouse.Console.Models;

/// <summary>Every stock change is logged as a booking.</summary>
public sealed class Booking
{
    public int Id { get; set; }
    public int ArticleId { get; set; }
    public int Delta { get; set; }                 // >0 inbound, <0 outbound
    public string Reason { get; set; } = "Unknown";
    public DateTime CreatedAt { get; set; }
}
