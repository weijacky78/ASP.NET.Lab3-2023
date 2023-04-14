using System.ComponentModel.DataAnnotations;

public class Product
{
    public uint ProductId { get; set; }

    public string Name { get; set; } = "";

    public string Description { get; set; } = "";

    public decimal Price { get; set; } = 0.0m;

    [Display(Name = "Stock Count")]
    public uint StockCount { get; set; } = 0;
}