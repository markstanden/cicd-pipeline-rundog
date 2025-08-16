# Contributing to the Rundog project 

## Package Management

This project uses a `packages.lock.json` file to ensure reproducible builds with exact dependency versions.

### Updating Dependencies

When you need to add or update NuGet packages:

```bash
# Update dependencies (bypasses lock file temporarily)
dotnet restore rundog/rundog.csproj --force-evaluate

# Verify everything works with the lock file
dotnet restore rundog/rundog.csproj --locked-mode
dotnet build rundog/rundog.csproj --no-restore
```

### Adding New Packages

```bash
# Add your package first
dotnet add rundog package Microsoft.Extensions.Logging --version 8.0.0

# Then regenerate the lock file
dotnet restore rundog/rundog.csproj --force-evaluate
```

>  ⚠️  **Important:**  
>
> Always commit both the `.csproj` and `packages.lock.json` files together.

### Troubleshooting

If you get lock file errors:
```bash
dotnet restore rundog/rundog.csproj --force-evaluate
```