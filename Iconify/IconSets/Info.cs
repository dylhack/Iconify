using System.Text.Json.Serialization;

namespace Iconify.IconSets;

public sealed record Info
{
    [JsonPropertyName("name")] public required string Name { get; init; }
    [JsonPropertyName("total")] public required int Total { get; init; }
    [JsonPropertyName("version")] public required string Version { get; init; }
    [JsonPropertyName("author")] public required Author Author { get; init; }
    [JsonPropertyName("license")] public required License License { get; init; }
    [JsonPropertyName("samples")] public List<string>? Samples { get; init; }
    [JsonPropertyName("category")] public string? Category { get; init; }
    [JsonPropertyName("tags")] public List<string>? Tags { get; init; }
    [JsonPropertyName("palette")] public bool Palette { get; init; }
}