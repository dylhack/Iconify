Iconify for Blazor

**Program.cs**
```csharp
builder.Services.AddIconify(o => o.AddJsonFolder("Resources/Icons"));
```

**Component.razor**
```html
<Icon Name="heroicons:exclamation-triangle" class="size-6 text-yellow-400" />
```
