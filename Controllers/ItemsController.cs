using System;
using System.Collections.Generic;
using Catalog.Entities;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("[controller]")] //alternative: Route("items")
    public class ItemsController : ControllerBase
    {
        private readonly InMemItemsRepository repository;

        public ItemsController()
        {
            repository = new InMemItemsRepository();
        }

        // GET /items
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            var items = repository.GetItems();

            return items;
        }

        // GET /items/{id}
        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
            var item = repository.GetItem(id);

            if (item is null)
            {
                return NotFound(); // When returning status code and type use ActionResult<>
            }

            return item;
        }
    }
}