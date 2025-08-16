# Contributing to the Rundog project 

## Package Management

This project uses NuGet package locking to ensure reproducible builds. The `packages.lock.json` file pins exact versions of all dependencies, making builds deterministic across different environments.

### Understanding the Lock File

The `packages.lock.json` file:
- Contains exact versions of all direct and transitive dependencies
- Ensures consistent builds between local development, CI/CD, and production
- Prevents "it works on my machine" issues caused by floating version ranges

### When to Update the Lock File

You'll need to regenerate the lock file when:
- Adding new NuGet packages to the project
- Updating existing package versions
- Changing target frameworks
- The lock file becomes out of sync with the `.csproj` file

### How to Update Dependencies

#### Adding or Updating Packages

1. **Temporarily disable locked mode** by commenting out the lock file properties in `rundog.csproj`:
   ```xml
   <!-- <RestoreLocked>true</RestoreLocked> -->
   <!-- <RestorePackagesWithLockFile>true</RestorePackagesWithLockFile> -->
   ```

2. **Make your package changes**:
   ```bash
   # Add a new package
   dotnet add package Microsoft.Extensions.Logging --version 8.0.0
   
   # Or update existing packages
   dotnet list package --outdated
   dotnet add package Microsoft.AspNetCore.Components.WebAssembly --version 8.0.18
   ```

3. **Restore to regenerate the lock file**:
   ```bash
   dotnet restore
   ```

4. **Re-enable locked mode** by uncommenting the properties:
   ```xml
   <RestoreLocked>true</RestoreLocked>
   <RestorePackagesWithLockFile>true</RestorePackagesWithLockFile>
   ```

5. **Verify the changes work**:
   ```bash
   dotnet restore --locked-mode
   dotnet build
   ```

#### Alternative Method (Simpler)

You can also temporarily disable locked mode for a single restore:
```bash
dotnet restore --force-evaluate
```

This bypasses the lock file for that restore only, then regenerates it.

### Best Practices

- **Always commit** both `.csproj` changes and the updated `packages.lock.json` together
- **Test locally** with `dotnet restore --locked-mode` before pushing
- **Review lock file changes** in PRs to ensure only expected packages changed
- **Don't manually edit** the `packages.lock.json` file - always regenerate it

### Troubleshooting

**"Assets file doesn't have a target" error:**
```bash
dotnet restore --force-evaluate
```

**Lock file out of sync:**
```bash
# Temporarily disable locking and restore
dotnet restore
# Then verify with locked mode
dotnet restore --locked-mode
```

### CI/CD Integration

The Azure deployment workflow uses `--locked-mode` to ensure production builds use exactly the same package versions as tested in development. If the lock file is out of sync, the build will fail fast rather than silently using different versions.