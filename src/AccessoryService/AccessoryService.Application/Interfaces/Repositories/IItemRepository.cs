using AccessoryService.Domain.Entities;

namespace AccessoryService.Application.Interfaces.Repositories;

/// <summary>
/// Fake repository for <see cref="Item"/> entity."/>
/// </summary>
public interface IItemRepository
{
    /// <summary>
    /// Returns item by id.
    /// </summary>
    /// <param name="id">Item's Id.</param>
    /// <returns>Item if found, otherwise null.</returns>
    public Item? GetById(int id);

    /// <summary>
    /// Returns all items.
    /// </summary>
    /// <returns>Collection of item.</returns>
    public IEnumerable<Item> GetAll();
}