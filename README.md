# Examples

## sample1 - console app with lib

`c1` is a console app, with a project reference to `l1`  
`l1` is a F# lib, that uses the `Json.NET` package  
vscode is configured to build and run `c1`

## sample2 - console app with C# lib

`c1` is a console app, with a project reference to `csl1`  
`csl1` is a C# lib, that uses the `Json.NET` package  
vscode is configured to build and run `c1`

## sample3 - console app (netcoreapp+net) with lib (netstandard+net)

`c1` is a console app with tfm (`netcoreapp` and `net`), with a project reference to `l1`
`l1` is a F# lib with tfm (`netstandard` and `net`), that uses the `Json.NET` package
vscode is configured to build and run `c1`

good cases:

- project reference
- package reference
