# Fleece.Choicer
Combinators for DU Codecs

How to build and pack

1 - add System.IO.File.WriteAllText ("Library.fs", printCode 40) to generator.fsx

2 - send generator to fsi

3 - dotnet pack -c Release

Rename PackageId in Directory.Build.props to Fleece.Choicer.Plus
Repeat steps with 60 instead of 40

Don't check-in changes !