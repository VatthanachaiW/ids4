using System;
using System.Text.Json.Serialization;

namespace BookStore.API.Dtos.Books.Requests
{
    [Serializable]
    public class CreateBookRequest
    {
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("catalog_id")] public int CatalogId { get; set; }
    }
}