using System.Text.Json.Serialization;

namespace Iconify.IconSets;

public sealed record Author
{
    [JsonPropertyName("name")] public required string Name { get; init; }
    [JsonPropertyName("url")] public required string Url { get; init; }
}