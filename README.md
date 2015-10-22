## Release C# Library

The CellStore.NET library is published at [Nuget.or] (https://www.nuget.org/packages/CellStore.NET/). 
This Readme describes how to build a release.

### Dependencies

- [NuGet] (https://nuget.org/nuget.exe): Make sure its in the PATH
- For being able to publish:

```
nuget setApiKey API-Key
```

### Prepare Release

1. Increase Version in CellStore.dll.nuspec
2. Compile: 

```
compile.bat
```
3. Pack:

```
nuget pack CellStore.dll.nuspec
```

4. Publish:

```
nuget push CellStore.NET.0.0.1.nupkg
```
