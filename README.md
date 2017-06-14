# Examples

## sample1 - console app with lib

`c1` is a console app, with a project reference to `l1`  
`l1` is a F# lib, that uses the `Json.NET` package  
vscode is configured to build and run `c1`

scenarios:

- project reference
- package reference

## sample2 - console app with C# lib

`c1` is a console app, with a project reference to `csl1`  
`csl1` is a C# lib, that uses the `Json.NET` package  
vscode is configured to build and run `c1`

scenarios:

- c# interop

## sample3 - console app (netcoreapp+net) with lib (netstandard+net)

`c1` is a console app with tfm (`netcoreapp` and `net`), with a project reference to `l1`
`l1` is a F# lib with tfm (`netstandard` and `net`), that uses the `Json.NET` package
vscode is configured to build and run `c1`

scenarios:

- cross targeting (multi target framework)

## sample4 - console app (netcoreapp) with lib1 (netstandard+net) and lib2 (netstandard)

`c1` is a console app with tfm (`netcoreapp`), with a project reference to `l1` and `l2`
`l1` is a F# lib with tfm (`netstandard` and `net`), that uses the `Json.NET` package
`l2` is a F# lib with tfm (`netstandard`), that uses the `Json.NET` package
vscode is configured to build and run `c1`

good cases:

- project reference
- cross targeting (multi target framework)
