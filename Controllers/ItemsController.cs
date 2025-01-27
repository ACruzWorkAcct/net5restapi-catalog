using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    // GET /items
    [ApiController]
    [Route("items")] //alternative: Route("[controller]")
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository repository;
    }
}