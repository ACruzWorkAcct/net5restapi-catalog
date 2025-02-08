using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.Entities;

namespace Catalog.Repositories
{
    public class InMemItemsRepository : IInMemItemsRepository
    {
        // In memory data for initializers setup
        // Read-only instance member should not change after object new
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 9, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Iron Sword", Price = 20, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Bronze Shield", Price = 18, CreatedDate = DateTimeOffset.UtcNow }
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return items.Where(_ => _.Id == id).SingleOrDefault();
        }
        // public Task CreateItemAsync(Item item)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task DeleteItemAsync(Guid id)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task<Item> GetItemAsync(Guid id)
        // {
        //     throw new NotImplementedException();
        // }

        // public Task UpdateItemAsync(Item item)
        // {
        //     throw new NotImplementedException();
        // }

        // Task<System.Collections.Generic.IEnumerable<Item>> IItemsRepository.GetItemsAsync()
        // {
        //     throw new NotImplementedException();
        // }
    }
}