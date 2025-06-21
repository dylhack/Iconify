using Iconify.IconSets;

namespace Iconify;

public class Registry
{
    private IDictionary<string, IconSet> Sets { get; } = new Dictionary<string, IconSet>();

    /// <summary>
    ///     Register an icon set.
    /// </summary>
    /// <param name="iconSet"></param>
    public void Register(IconSet iconSet)
    {
        Sets.Add(iconSet.Prefix, iconSet);
    }

    /// <summary>
    ///     Register an icon set from a JSON file.
    /// </summary>
    /// <param name="path"></param>
    /// <exception cref="ArgumentException"></exception>
    public void Register(string path)
    {
        IconSet iconSet = IconSet.Load(path)
                          ?? throw new ArgumentException("Invalid icon set path");

        Register(iconSet);
    }

    public IconSet? Resolve(string set)
    {
        return Sets.TryGetValue(set, out IconSet? iconSet) ? iconSet : null;
    }

    public IconData? Resolve(IconId iconId)
    {
        IconSet? iconSet = Resolve(iconId.Set);
        if (iconSet != null && iconSet.Icons.TryGetValue(iconId.Name, out IconData? iconData)) return iconData;

        return null;
    }
}