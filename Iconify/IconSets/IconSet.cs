using System.Text.Json;
using System.Text.Json.Serialization;

namespace Iconify.IconSets;

public sealed record IconSet
{
    [JsonPropertyName("prefix")] public required string Prefix { get; init; }
    [JsonPropertyName("info")] public required Info Info { get; init; }
    [JsonPropertyName("lastModified")] public required long LastModified { get; init; }
    [JsonPropertyName("icons")] public required Dictionary<string, IconData> Icons { get; init; }

    public static IconSet? Load(string path)
    {
        using FileStream stream = File.OpenRead(path);
        return JsonSerializer.Deserialize<IconSet>(stream);
    }
}