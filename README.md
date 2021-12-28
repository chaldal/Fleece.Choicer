# Fleece.Choicer
## Combinators for DU Codecs

This allows to write Fleece DU codecs like this:

```
type Shape =
    | Rectangle of width : float * length : float
    | Circle of radius : float
    | Prism of width : float * float * height : float
    
type Shape with 
    static member get_Codec () =
        function
        | Rectangle (x, y)    -> case1 (x, y)    <| jreqWith (Codecs.tuple2 Codecs.float Codecs.float) "rectangle"
        | Circle     x        -> case2  x        <| jreqWith Codecs.float "radius"
        | Prism     (x, y, z) -> case3 (x, y, z) <| jreq "prism"
        |> withCases (case1 = Rectangle, case2 = Circle, case3 = Prism)
        |> ofObjCodec
```

as opposed to

```
type Shape with
    static member get_Codec () = ofObjCodec <| codec {
        Rectangle <!> jreqWith (Codecs.tuple2 Codecs.float Codecs.float) "rectangle" (function Rectangle (x, y)    -> Some (x, y)    | _ -> None)
        Circle    <!> jreqWith Codecs.float                              "radius"    (function Circle     x        -> Some  x        | _ -> None)
        Prism     <!> jreq                                               "prism"     (function Prism     (x, y, z) -> Some (x, y, z) | _ -> None) }
```

which doesn't provide exhaustive check.



## How to build and pack

1 - Add System.IO.File.WriteAllText ("Library.fs", printCode 40) to generator.fsx

2 - Send generator to fsi

3 - Do dotnet pack -c Release

Rename PackageId in Directory.Build.props to Fleece.Choicer.Plus
Repeat steps with 60 instead of 40

Don't check-in changes !
