using AccessoryService.Application.Interfaces.Repositories;
using AccessoryService.Domain.Entities;
using AccessoryService.Domain.Enums;

namespace AccessoryService.Persistence.Repositories;

internal class ItemRepository : IItemRepository
{
    private readonly List<Item> _items = [
        new Item { Id = 1, Name = "Fish", Description = "Salmon to feed dogs", Price = 1.99m, Type = ItemType.Food },
        new Item { Id = 2, Name = "Boomerang", Description = "Fly high", Price = 2.99m, Type = ItemType.Toys },
        new Item { Id = 3, Name = "Dog's shoes", Description = "Good for winter", Price = 3.99m, Type = ItemType.Clothes },
        new Item { Id = 4, Name = "Tent", Description = "Sleep well", Price = 100.29m, Type = ItemType.Other } ];

    public Item? GetById(int id)
        => _items.FirstOrDefault(x => x.Id == id);

    public IEnumerable<Item> GetAll() => _items;
}