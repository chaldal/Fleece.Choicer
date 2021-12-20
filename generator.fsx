#r "nuget: FSharpPlus"

open FSharpPlus

let nl = System.Environment.NewLine
let spaces x = String.replicate x " "

let printCase maxCases case =
    if case = 1 || case > 7 then
        let createTypeParams i = [1 .. case] |> List.map (fun i -> $"'t{i}") |> String.concat ", "
        let createDuCases    i = [1 .. case] |> List.map (fun i -> $"    | Choice{i}Of{case} of 't{i}") |> String.concat nl
        $"    type Choice<{createTypeParams maxCases}> ={nl}{createDuCases maxCases}{nl}"
    else ""

let printChoice minCase maxCase =
    let printOverload minCase case =
        let tyParams = [1..case] |> List.map (fun i -> if i = minCase then "'x * 'y" else $"'x{i}") |> String.concat ", "
        $"{spaces 8}static member Case (x: 'x, y: 'y, _: Choice<{tyParams}>) = Choice{minCase}Of{case} (x, y) : Choice<{tyParams}>"
    $"    type Choice{minCase}OfN ={nl}{[minCase .. maxCase] |> List.map (fun i -> printOverload minCase i) |> String.concat nl}" + nl
    + $"    let inline case{minCase} y (x: ('T -> 'fld option) -> Codec<PropertyList<'Encoding>, PropertyList<'Encoding>, 'fld, 'T>) : 'rt =" + nl
    + $"{spaces 8}let inline call (_: ^t, _: ^r, (x, y: ^p)) = ((^t or ^r ) : (static member Case: _ * _ * ^r -> ^r) (y, x, Unchecked.defaultof<'r>) )" + nl
    + $"{spaces 8}call (Unchecked.defaultof<Choice{minCase}OfN>, Unchecked.defaultof<'rt>, (x, y))"


let printJCase i =
    let printParams i = [1..i] |> List.map (fun i -> $"case{i}") |> String.concat ", "
    let printBindings i = $"{spaces 12}let f{i} (g: ('Union -> _)) : _ = g (case{i} (nonNullTuple (): 'params{i}))"
    let printMappings maxCases i = $"{spaces 16}Codec.map case{i} (f{i} (matcher >> (function Choice{i}Of{maxCases} x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice{i}Of{maxCases} x -> Some x | _ -> None) >> Option.map fst))"  
    $"{spaces 8}static member jcase ({printParams i}) = fun matcher ->" + nl
    + ([1..i] |> List.map printBindings |> String.concat nl) + nl
    + "            codec {" + nl
    + ([1..i] |> List.map (printMappings i) |> String.concat nl) + nl
    + "            }" + nl
    

let printCode maxCases =
    """namespace Fleece
    
open Fleece
    
[<AutoOpen>]
module Choicer =
    
    let nonNullTuple<'t> () : 't =
        if Microsoft.FSharp.Reflection.FSharpType.IsTuple typeof<'t> then
            let c = Microsoft.FSharp.Reflection.FSharpType.GetTupleElements typeof<'t> |> Array.length
            Microsoft.FSharp.Reflection.FSharpValue.MakeTuple (Array.zeroCreate c, typeof<'t>) |> unbox
        else Unchecked.defaultof<'t>
    """ + nl
    + ([1..maxCases] |> List.map (printCase maxCases) |> String.concat nl)
    + nl
    + ([1..maxCases] |> List.map (fun i -> printChoice i maxCases) |> String.concat (nl+nl)) + nl + nl
    + "    [<AutoOpen>]" + nl
    + "    type jcases =" + nl
    + ([1..maxCases] |> List.map printJCase |> String.concat nl)
