using AccessoryService.Domain.Enums;

namespace AccessoryService.Domain.Entities;

/// <summary>
/// Entity that represents item to sell in database.
/// </summary>
public class Item
{
    /// <summary>
    /// Item's id.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Item's name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Item's description.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Item's price.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Item's type.
    /// </summary>
    public ItemType Type { get; set; } = ItemType.Food;
}