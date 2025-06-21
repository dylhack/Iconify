using Iconify.IconSets;

namespace Iconify.Extensions;

/// <summary>
///     Fluent helper that callers use inside AddIconify()
///     to register icon-set JSON files or in-memory IconSet objects.
/// </summary>
public sealed class IconifyBuilder
{
    internal List<string> JsonPaths { get; } = new();
    internal List<IconSet> IconSets { get; } = new();

    /// <summary>Add a single JSON file (absolute or relative to the content root).</summary>
    public IconifyBuilder AddJson(string path)
    {
        JsonPaths.Add(path);
        return this;
    }

    /// <summary>Add every *.json in a folder.</summary>
    public IconifyBuilder AddJsonFolder(string folder)
    {
        foreach (string file in Directory.GetFiles(folder, "*.json"))
            JsonPaths.Add(file);

        return this;
    }

    /// <summary>Add a pre-constructed <see cref="IconSet" /> object.</summary>
    public IconifyBuilder AddSet(IconSet set)
    {
        IconSets.Add(set);
        return this;
    }
}
