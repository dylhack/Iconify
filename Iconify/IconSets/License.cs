using System.Text.Json.Serialization;

namespace Iconify.IconSets;

public sealed record License
{
    [JsonPropertyName("title")] public required string Title { get; init; }
    [JsonPropertyName("spdx")] public required string Spdx { get; init; }
    [JsonPropertyName("url")] public required string Url { get; init; }
}