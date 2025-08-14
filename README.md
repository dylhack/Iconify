Iconify for Blazor

- Download an icon pack from [here](https://github.com/iconify/icon-sets/tree/master/json)
- Add it to your project (ie. `Resources/Icons`)

```sh
dotnet add package Iconify
```

**Program.cs**
```csharp
builder.Services.AddIconify(o => o.AddJsonFolder("Resources/Icons"));
```

**Component.razor**
```html
<Icon Name="heroicons:exclamation-triangle" class="size-6 text-yellow-400" />
```
