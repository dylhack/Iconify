using Iconify.IconSets;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Iconify.Extensions;

public static class IconifyServiceCollectionExtensions
{
    /// <summary>
    ///     Registers the <see cref="Registry" /> singleton and (optionally)
    ///     pre-loads icon-set JSON files or <see cref="IconSet" /> instances.
    /// </summary>
    /// <param name="services">The DI container.</param>
    /// <param name="configure">
    ///     Optional callback that lets callers add icon sets:
    ///     <code>
    /// services.AddIconify(b =>
    /// {
    ///     b.AddJson("wwwroot/icons/mdi.json")
    ///      .AddJson("wwwroot/icons/lucide.json");
    /// });
    /// </code>
    /// </param>
    public static IServiceCollection AddIconify(
        this IServiceCollection services,
        Action<IconifyBuilder>? configure = null)
    {
        // Collect caller-supplied sets/paths
        IconifyBuilder builder = new();
        configure?.Invoke(builder);

        // Register Registry as a singleton
        services.AddSingleton<Registry>(sp =>
        {
            IHostEnvironment env = sp.GetRequiredService<IHostEnvironment>();
            Registry registry = new();

            foreach (string full in builder.JsonPaths.Select(path => Path.IsPathRooted(path)
                         ? path
                         : Path.Combine(env.ContentRootPath, path)))
                registry.Register(full);

            foreach (IconSet set in builder.IconSets) registry.Register(set);

            return registry;
        });

        return services;
    }
}
