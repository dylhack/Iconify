using System.Text.Json.Serialization;

namespace Iconify.IconSets;

public sealed record IconData
{
    [JsonPropertyName("body")] public required string Body { get; init; }
    [JsonPropertyName("width")] public int? Width { get; init; } = null;
    [JsonPropertyName("height")] public int? Height { get; init; } = null;
}