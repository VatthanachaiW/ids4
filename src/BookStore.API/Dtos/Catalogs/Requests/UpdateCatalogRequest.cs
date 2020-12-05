using System;
using System.Text.Json.Serialization;

namespace BookStore.API.Dtos.Catalogs.Requests
{
    [Serializable]
    public class UpdateCatalogRequest
    {
        [JsonPropertyName("name")] public string Name { get; set; }
    }
}