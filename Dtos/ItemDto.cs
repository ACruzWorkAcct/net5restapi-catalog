using System;

namespace Catalog.Dtos
{
    public record ItemDto
    {
        public Guid Id { get; init; } // allow setting value only during initialization
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}