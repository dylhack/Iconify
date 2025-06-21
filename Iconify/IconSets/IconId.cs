namespace Iconify.IconSets;

public sealed record IconId
{
    public required string Set { get; init; }
    public required string Name { get; init; }

    public override string ToString()
    {
        return $"{Set}:{Name}";
    }

    public static IconId From(string value)
    {
        string[] split = value.Split(":", 2);
        if (split.Length < 2) throw new ArgumentException("Invalid icon ID format", nameof(value));

        return new IconId
        {
            Set = split[0],
            Name = split[1]
        };
    }
}