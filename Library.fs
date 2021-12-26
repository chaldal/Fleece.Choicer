namespace Fleece
    
open Fleece
    
[<AutoOpen>]
module Choicer =
    
    let nonNullTuple<'t> () : 't =
        if Microsoft.FSharp.Reflection.FSharpType.IsTuple typeof<'t> then
            let c = Microsoft.FSharp.Reflection.FSharpType.GetTupleElements typeof<'t> |> Array.length
            Microsoft.FSharp.Reflection.FSharpValue.MakeTuple (Array.zeroCreate c, typeof<'t>) |> unbox
        else Unchecked.defaultof<'t>
    
    type Choice<'t1> =
    | Choice1Of1 of 't1







    type Choice<'t1, 't2, 't3, 't4, 't5, 't6, 't7, 't8> =
    | Choice1Of8 of 't1
    | Choice2Of8 of 't2
    | Choice3Of8 of 't3
    | Choice4Of8 of 't4
    | Choice5Of8 of 't5
    | Choice6Of8 of 't6
    | Choice7Of8 of 't7
    | Choice8Of8 of 't8

    type Choice<'t1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9> =
    | Choice1Of9 of 't1
    | Choice2Of9 of 't2
    | Choice3Of9 of 't3
    | Choice4Of9 of 't4
    | Choice5Of9 of 't5
    | Choice6Of9 of 't6
    | Choice7Of9 of 't7
    | Choice8Of9 of 't8
    | Choice9Of9 of 't9

    type Choice<'t1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10> =
    | Choice1Of10 of 't1
    | Choice2Of10 of 't2
    | Choice3Of10 of 't3
    | Choice4Of10 of 't4
    | Choice5Of10 of 't5
    | Choice6Of10 of 't6
    | Choice7Of10 of 't7
    | Choice8Of10 of 't8
    | Choice9Of10 of 't9
    | Choice10Of10 of 't10

    type Choice<'t1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11> =
    | Choice1Of11 of 't1
    | Choice2Of11 of 't2
    | Choice3Of11 of 't3
    | Choice4Of11 of 't4
    | Choice5Of11 of 't5
    | Choice6Of11 of 't6
    | Choice7Of11 of 't7
    | Choice8Of11 of 't8
    | Choice9Of11 of 't9
    | Choice10Of11 of 't10
    | Choice11Of11 of 't11

    type Choice<'t1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12> =
    | Choice1Of12 of 't1
    | Choice2Of12 of 't2
    | Choice3Of12 of 't3
    | Choice4Of12 of 't4
    | Choice5Of12 of 't5
    | Choice6Of12 of 't6
    | Choice7Of12 of 't7
    | Choice8Of12 of 't8
    | Choice9Of12 of 't9
    | Choice10Of12 of 't10
    | Choice11Of12 of 't11
    | Choice12Of12 of 't12

    type Choice<'t1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13> =
    | Choice1Of13 of 't1
    | Choice2Of13 of 't2
    | Choice3Of13 of 't3
    | Choice4Of13 of 't4
    | Choice5Of13 of 't5
    | Choice6Of13 of 't6
    | Choice7Of13 of 't7
    | Choice8Of13 of 't8
    | Choice9Of13 of 't9
    | Choice10Of13 of 't10
    | Choice11Of13 of 't11
    | Choice12Of13 of 't12
    | Choice13Of13 of 't13

    type Choice<'t1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14> =
    | Choice1Of14 of 't1
    | Choice2Of14 of 't2
    | Choice3Of14 of 't3
    | Choice4Of14 of 't4
    | Choice5Of14 of 't5
    | Choice6Of14 of 't6
    | Choice7Of14 of 't7
    | Choice8Of14 of 't8
    | Choice9Of14 of 't9
    | Choice10Of14 of 't10
    | Choice11Of14 of 't11
    | Choice12Of14 of 't12
    | Choice13Of14 of 't13
    | Choice14Of14 of 't14

    type Choice<'t1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15> =
    | Choice1Of15 of 't1
    | Choice2Of15 of 't2
    | Choice3Of15 of 't3
    | Choice4Of15 of 't4
    | Choice5Of15 of 't5
    | Choice6Of15 of 't6
    | Choice7Of15 of 't7
    | Choice8Of15 of 't8
    | Choice9Of15 of 't9
    | Choice10Of15 of 't10
    | Choice11Of15 of 't11
    | Choice12Of15 of 't12
    | Choice13Of15 of 't13
    | Choice14Of15 of 't14
    | Choice15Of15 of 't15

    type Choice<'t1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16> =
    | Choice1Of16 of 't1
    | Choice2Of16 of 't2
    | Choice3Of16 of 't3
    | Choice4Of16 of 't4
    | Choice5Of16 of 't5
    | Choice6Of16 of 't6
    | Choice7Of16 of 't7
    | Choice8Of16 of 't8
    | Choice9Of16 of 't9
    | Choice10Of16 of 't10
    | Choice11Of16 of 't11
    | Choice12Of16 of 't12
    | Choice13Of16 of 't13
    | Choice14Of16 of 't14
    | Choice15Of16 of 't15
    | Choice16Of16 of 't16

    type Choice<'t1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17> =
    | Choice1Of17 of 't1
    | Choice2Of17 of 't2
    | Choice3Of17 of 't3
    | Choice4Of17 of 't4
    | Choice5Of17 of 't5
    | Choice6Of17 of 't6
    | Choice7Of17 of 't7
    | Choice8Of17 of 't8
    | Choice9Of17 of 't9
    | Choice10Of17 of 't10
    | Choice11Of17 of 't11
    | Choice12Of17 of 't12
    | Choice13Of17 of 't13
    | Choice14Of17 of 't14
    | Choice15Of17 of 't15
    | Choice16Of17 of 't16
    | Choice17Of17 of 't17

    type Choice<'t1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18> =
    | Choice1Of18 of 't1
    | Choice2Of18 of 't2
    | Choice3Of18 of 't3
    | Choice4Of18 of 't4
    | Choice5Of18 of 't5
    | Choice6Of18 of 't6
    | Choice7Of18 of 't7
    | Choice8Of18 of 't8
    | Choice9Of18 of 't9
    | Choice10Of18 of 't10
    | Choice11Of18 of 't11
    | Choice12Of18 of 't12
    | Choice13Of18 of 't13
    | Choice14Of18 of 't14
    | Choice15Of18 of 't15
    | Choice16Of18 of 't16
    | Choice17Of18 of 't17
    | Choice18Of18 of 't18

    type Choice<'t1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19> =
    | Choice1Of19 of 't1
    | Choice2Of19 of 't2
    | Choice3Of19 of 't3
    | Choice4Of19 of 't4
    | Choice5Of19 of 't5
    | Choice6Of19 of 't6
    | Choice7Of19 of 't7
    | Choice8Of19 of 't8
    | Choice9Of19 of 't9
    | Choice10Of19 of 't10
    | Choice11Of19 of 't11
    | Choice12Of19 of 't12
    | Choice13Of19 of 't13
    | Choice14Of19 of 't14
    | Choice15Of19 of 't15
    | Choice16Of19 of 't16
    | Choice17Of19 of 't17
    | Choice18Of19 of 't18
    | Choice19Of19 of 't19

    type Choice<'t1, 't2, 't3, 't4, 't5, 't6, 't7, 't8, 't9, 't10, 't11, 't12, 't13, 't14, 't15, 't16, 't17, 't18, 't19, 't20> =
    | Choice1Of20 of 't1
    | Choice2Of20 of 't2
    | Choice3Of20 of 't3
    | Choice4Of20 of 't4
    | Choice5Of20 of 't5
    | Choice6Of20 of 't6
    | Choice7Of20 of 't7
    | Choice8Of20 of 't8
    | Choice9Of20 of 't9
    | Choice10Of20 of 't10
    | Choice11Of20 of 't11
    | Choice12Of20 of 't12
    | Choice13Of20 of 't13
    | Choice14Of20 of 't14
    | Choice15Of20 of 't15
    | Choice16Of20 of 't16
    | Choice17Of20 of 't17
    | Choice18Of20 of 't18
    | Choice19Of20 of 't19
    | Choice20Of20 of 't20

    type Choice1OfN =
        static member Case (x: 'x, y: 'y, _: Choice<'x * 'y>) = Choice1Of1 (x, y) : Choice<'x * 'y>
        static member Case (x: 'x, y: 'y, _: Choice<'x * 'y, 'x2>) = Choice1Of2 (x, y) : Choice<'x * 'y, 'x2>
        static member Case (x: 'x, y: 'y, _: Choice<'x * 'y, 'x2, 'x3>) = Choice1Of3 (x, y) : Choice<'x * 'y, 'x2, 'x3>
        static member Case (x: 'x, y: 'y, _: Choice<'x * 'y, 'x2, 'x3, 'x4>) = Choice1Of4 (x, y) : Choice<'x * 'y, 'x2, 'x3, 'x4>
        static member Case (x: 'x, y: 'y, _: Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5>) = Choice1Of5 (x, y) : Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5>
        static member Case (x: 'x, y: 'y, _: Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6>) = Choice1Of6 (x, y) : Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6>
        static member Case (x: 'x, y: 'y, _: Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7>) = Choice1Of7 (x, y) : Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7>
        static member Case (x: 'x, y: 'y, _: Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8>) = Choice1Of8 (x, y) : Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8>
        static member Case (x: 'x, y: 'y, _: Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9>) = Choice1Of9 (x, y) : Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9>
        static member Case (x: 'x, y: 'y, _: Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10>) = Choice1Of10 (x, y) : Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10>
        static member Case (x: 'x, y: 'y, _: Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11>) = Choice1Of11 (x, y) : Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11>
        static member Case (x: 'x, y: 'y, _: Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12>) = Choice1Of12 (x, y) : Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12>
        static member Case (x: 'x, y: 'y, _: Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13>) = Choice1Of13 (x, y) : Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13>
        static member Case (x: 'x, y: 'y, _: Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14>) = Choice1Of14 (x, y) : Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14>
        static member Case (x: 'x, y: 'y, _: Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15>) = Choice1Of15 (x, y) : Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15>
        static member Case (x: 'x, y: 'y, _: Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16>) = Choice1Of16 (x, y) : Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16>
        static member Case (x: 'x, y: 'y, _: Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17>) = Choice1Of17 (x, y) : Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17>
        static member Case (x: 'x, y: 'y, _: Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>) = Choice1Of18 (x, y) : Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>
        static member Case (x: 'x, y: 'y, _: Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>) = Choice1Of19 (x, y) : Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>
        static member Case (x: 'x, y: 'y, _: Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>) = Choice1Of20 (x, y) : Choice<'x * 'y, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>
    let inline case1 y (x: ('T -> 'fld option) -> Codec<PropertyList<'Encoding>, PropertyList<'Encoding>, 'fld, 'T>) : 'rt =
        let inline call (_: ^t, _: ^r, (x, y: ^p)) = ((^t or ^r ) : (static member Case: _ * _ * ^r -> ^r) (y, x, Unchecked.defaultof<'r>) )
        call (Unchecked.defaultof<Choice1OfN>, Unchecked.defaultof<'rt>, (x, y))

    type Choice2OfN =
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x * 'y>) = Choice2Of2 (x, y) : Choice<'x1, 'x * 'y>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x * 'y, 'x3>) = Choice2Of3 (x, y) : Choice<'x1, 'x * 'y, 'x3>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x * 'y, 'x3, 'x4>) = Choice2Of4 (x, y) : Choice<'x1, 'x * 'y, 'x3, 'x4>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5>) = Choice2Of5 (x, y) : Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6>) = Choice2Of6 (x, y) : Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7>) = Choice2Of7 (x, y) : Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8>) = Choice2Of8 (x, y) : Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9>) = Choice2Of9 (x, y) : Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10>) = Choice2Of10 (x, y) : Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11>) = Choice2Of11 (x, y) : Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12>) = Choice2Of12 (x, y) : Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13>) = Choice2Of13 (x, y) : Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14>) = Choice2Of14 (x, y) : Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15>) = Choice2Of15 (x, y) : Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16>) = Choice2Of16 (x, y) : Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17>) = Choice2Of17 (x, y) : Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>) = Choice2Of18 (x, y) : Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>) = Choice2Of19 (x, y) : Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>) = Choice2Of20 (x, y) : Choice<'x1, 'x * 'y, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>
    let inline case2 y (x: ('T -> 'fld option) -> Codec<PropertyList<'Encoding>, PropertyList<'Encoding>, 'fld, 'T>) : 'rt =
        let inline call (_: ^t, _: ^r, (x, y: ^p)) = ((^t or ^r ) : (static member Case: _ * _ * ^r -> ^r) (y, x, Unchecked.defaultof<'r>) )
        call (Unchecked.defaultof<Choice2OfN>, Unchecked.defaultof<'rt>, (x, y))

    type Choice3OfN =
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x * 'y>) = Choice3Of3 (x, y) : Choice<'x1, 'x2, 'x * 'y>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x * 'y, 'x4>) = Choice3Of4 (x, y) : Choice<'x1, 'x2, 'x * 'y, 'x4>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5>) = Choice3Of5 (x, y) : Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6>) = Choice3Of6 (x, y) : Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7>) = Choice3Of7 (x, y) : Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8>) = Choice3Of8 (x, y) : Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9>) = Choice3Of9 (x, y) : Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10>) = Choice3Of10 (x, y) : Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11>) = Choice3Of11 (x, y) : Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12>) = Choice3Of12 (x, y) : Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13>) = Choice3Of13 (x, y) : Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14>) = Choice3Of14 (x, y) : Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15>) = Choice3Of15 (x, y) : Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16>) = Choice3Of16 (x, y) : Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17>) = Choice3Of17 (x, y) : Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>) = Choice3Of18 (x, y) : Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>) = Choice3Of19 (x, y) : Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>) = Choice3Of20 (x, y) : Choice<'x1, 'x2, 'x * 'y, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>
    let inline case3 y (x: ('T -> 'fld option) -> Codec<PropertyList<'Encoding>, PropertyList<'Encoding>, 'fld, 'T>) : 'rt =
        let inline call (_: ^t, _: ^r, (x, y: ^p)) = ((^t or ^r ) : (static member Case: _ * _ * ^r -> ^r) (y, x, Unchecked.defaultof<'r>) )
        call (Unchecked.defaultof<Choice3OfN>, Unchecked.defaultof<'rt>, (x, y))

    type Choice4OfN =
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x * 'y>) = Choice4Of4 (x, y) : Choice<'x1, 'x2, 'x3, 'x * 'y>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5>) = Choice4Of5 (x, y) : Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6>) = Choice4Of6 (x, y) : Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7>) = Choice4Of7 (x, y) : Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8>) = Choice4Of8 (x, y) : Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9>) = Choice4Of9 (x, y) : Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10>) = Choice4Of10 (x, y) : Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11>) = Choice4Of11 (x, y) : Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12>) = Choice4Of12 (x, y) : Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13>) = Choice4Of13 (x, y) : Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14>) = Choice4Of14 (x, y) : Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15>) = Choice4Of15 (x, y) : Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16>) = Choice4Of16 (x, y) : Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17>) = Choice4Of17 (x, y) : Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>) = Choice4Of18 (x, y) : Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>) = Choice4Of19 (x, y) : Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>) = Choice4Of20 (x, y) : Choice<'x1, 'x2, 'x3, 'x * 'y, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>
    let inline case4 y (x: ('T -> 'fld option) -> Codec<PropertyList<'Encoding>, PropertyList<'Encoding>, 'fld, 'T>) : 'rt =
        let inline call (_: ^t, _: ^r, (x, y: ^p)) = ((^t or ^r ) : (static member Case: _ * _ * ^r -> ^r) (y, x, Unchecked.defaultof<'r>) )
        call (Unchecked.defaultof<Choice4OfN>, Unchecked.defaultof<'rt>, (x, y))

    type Choice5OfN =
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y>) = Choice5Of5 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6>) = Choice5Of6 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7>) = Choice5Of7 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8>) = Choice5Of8 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9>) = Choice5Of9 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9, 'x10>) = Choice5Of10 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9, 'x10>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11>) = Choice5Of11 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12>) = Choice5Of12 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13>) = Choice5Of13 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14>) = Choice5Of14 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15>) = Choice5Of15 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16>) = Choice5Of16 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17>) = Choice5Of17 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>) = Choice5Of18 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>) = Choice5Of19 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>) = Choice5Of20 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x * 'y, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>
    let inline case5 y (x: ('T -> 'fld option) -> Codec<PropertyList<'Encoding>, PropertyList<'Encoding>, 'fld, 'T>) : 'rt =
        let inline call (_: ^t, _: ^r, (x, y: ^p)) = ((^t or ^r ) : (static member Case: _ * _ * ^r -> ^r) (y, x, Unchecked.defaultof<'r>) )
        call (Unchecked.defaultof<Choice5OfN>, Unchecked.defaultof<'rt>, (x, y))

    type Choice6OfN =
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y>) = Choice6Of6 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7>) = Choice6Of7 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8>) = Choice6Of8 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9>) = Choice6Of9 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9, 'x10>) = Choice6Of10 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9, 'x10>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9, 'x10, 'x11>) = Choice6Of11 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9, 'x10, 'x11>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12>) = Choice6Of12 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13>) = Choice6Of13 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14>) = Choice6Of14 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15>) = Choice6Of15 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16>) = Choice6Of16 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17>) = Choice6Of17 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>) = Choice6Of18 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>) = Choice6Of19 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>) = Choice6Of20 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x * 'y, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>
    let inline case6 y (x: ('T -> 'fld option) -> Codec<PropertyList<'Encoding>, PropertyList<'Encoding>, 'fld, 'T>) : 'rt =
        let inline call (_: ^t, _: ^r, (x, y: ^p)) = ((^t or ^r ) : (static member Case: _ * _ * ^r -> ^r) (y, x, Unchecked.defaultof<'r>) )
        call (Unchecked.defaultof<Choice6OfN>, Unchecked.defaultof<'rt>, (x, y))

    type Choice7OfN =
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y>) = Choice7Of7 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8>) = Choice7Of8 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9>) = Choice7Of9 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9, 'x10>) = Choice7Of10 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9, 'x10>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9, 'x10, 'x11>) = Choice7Of11 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9, 'x10, 'x11>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9, 'x10, 'x11, 'x12>) = Choice7Of12 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9, 'x10, 'x11, 'x12>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13>) = Choice7Of13 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14>) = Choice7Of14 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15>) = Choice7Of15 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16>) = Choice7Of16 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17>) = Choice7Of17 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>) = Choice7Of18 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>) = Choice7Of19 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>) = Choice7Of20 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x * 'y, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>
    let inline case7 y (x: ('T -> 'fld option) -> Codec<PropertyList<'Encoding>, PropertyList<'Encoding>, 'fld, 'T>) : 'rt =
        let inline call (_: ^t, _: ^r, (x, y: ^p)) = ((^t or ^r ) : (static member Case: _ * _ * ^r -> ^r) (y, x, Unchecked.defaultof<'r>) )
        call (Unchecked.defaultof<Choice7OfN>, Unchecked.defaultof<'rt>, (x, y))

    type Choice8OfN =
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y>) = Choice8Of8 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9>) = Choice8Of9 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9, 'x10>) = Choice8Of10 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9, 'x10>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9, 'x10, 'x11>) = Choice8Of11 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9, 'x10, 'x11>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9, 'x10, 'x11, 'x12>) = Choice8Of12 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9, 'x10, 'x11, 'x12>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9, 'x10, 'x11, 'x12, 'x13>) = Choice8Of13 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9, 'x10, 'x11, 'x12, 'x13>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14>) = Choice8Of14 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15>) = Choice8Of15 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16>) = Choice8Of16 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17>) = Choice8Of17 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>) = Choice8Of18 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>) = Choice8Of19 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>) = Choice8Of20 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x * 'y, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>
    let inline case8 y (x: ('T -> 'fld option) -> Codec<PropertyList<'Encoding>, PropertyList<'Encoding>, 'fld, 'T>) : 'rt =
        let inline call (_: ^t, _: ^r, (x, y: ^p)) = ((^t or ^r ) : (static member Case: _ * _ * ^r -> ^r) (y, x, Unchecked.defaultof<'r>) )
        call (Unchecked.defaultof<Choice8OfN>, Unchecked.defaultof<'rt>, (x, y))

    type Choice9OfN =
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y>) = Choice9Of9 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y, 'x10>) = Choice9Of10 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y, 'x10>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y, 'x10, 'x11>) = Choice9Of11 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y, 'x10, 'x11>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y, 'x10, 'x11, 'x12>) = Choice9Of12 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y, 'x10, 'x11, 'x12>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y, 'x10, 'x11, 'x12, 'x13>) = Choice9Of13 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y, 'x10, 'x11, 'x12, 'x13>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y, 'x10, 'x11, 'x12, 'x13, 'x14>) = Choice9Of14 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y, 'x10, 'x11, 'x12, 'x13, 'x14>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15>) = Choice9Of15 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16>) = Choice9Of16 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17>) = Choice9Of17 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>) = Choice9Of18 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>) = Choice9Of19 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>) = Choice9Of20 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x * 'y, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>
    let inline case9 y (x: ('T -> 'fld option) -> Codec<PropertyList<'Encoding>, PropertyList<'Encoding>, 'fld, 'T>) : 'rt =
        let inline call (_: ^t, _: ^r, (x, y: ^p)) = ((^t or ^r ) : (static member Case: _ * _ * ^r -> ^r) (y, x, Unchecked.defaultof<'r>) )
        call (Unchecked.defaultof<Choice9OfN>, Unchecked.defaultof<'rt>, (x, y))

    type Choice10OfN =
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x * 'y>) = Choice10Of10 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x * 'y>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x * 'y, 'x11>) = Choice10Of11 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x * 'y, 'x11>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x * 'y, 'x11, 'x12>) = Choice10Of12 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x * 'y, 'x11, 'x12>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x * 'y, 'x11, 'x12, 'x13>) = Choice10Of13 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x * 'y, 'x11, 'x12, 'x13>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x * 'y, 'x11, 'x12, 'x13, 'x14>) = Choice10Of14 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x * 'y, 'x11, 'x12, 'x13, 'x14>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x * 'y, 'x11, 'x12, 'x13, 'x14, 'x15>) = Choice10Of15 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x * 'y, 'x11, 'x12, 'x13, 'x14, 'x15>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x * 'y, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16>) = Choice10Of16 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x * 'y, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x * 'y, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17>) = Choice10Of17 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x * 'y, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x * 'y, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>) = Choice10Of18 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x * 'y, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x * 'y, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>) = Choice10Of19 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x * 'y, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x * 'y, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>) = Choice10Of20 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x * 'y, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>
    let inline case10 y (x: ('T -> 'fld option) -> Codec<PropertyList<'Encoding>, PropertyList<'Encoding>, 'fld, 'T>) : 'rt =
        let inline call (_: ^t, _: ^r, (x, y: ^p)) = ((^t or ^r ) : (static member Case: _ * _ * ^r -> ^r) (y, x, Unchecked.defaultof<'r>) )
        call (Unchecked.defaultof<Choice10OfN>, Unchecked.defaultof<'rt>, (x, y))

    type Choice11OfN =
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x * 'y>) = Choice11Of11 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x * 'y>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x * 'y, 'x12>) = Choice11Of12 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x * 'y, 'x12>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x * 'y, 'x12, 'x13>) = Choice11Of13 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x * 'y, 'x12, 'x13>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x * 'y, 'x12, 'x13, 'x14>) = Choice11Of14 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x * 'y, 'x12, 'x13, 'x14>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x * 'y, 'x12, 'x13, 'x14, 'x15>) = Choice11Of15 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x * 'y, 'x12, 'x13, 'x14, 'x15>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x * 'y, 'x12, 'x13, 'x14, 'x15, 'x16>) = Choice11Of16 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x * 'y, 'x12, 'x13, 'x14, 'x15, 'x16>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x * 'y, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17>) = Choice11Of17 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x * 'y, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x * 'y, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>) = Choice11Of18 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x * 'y, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x * 'y, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>) = Choice11Of19 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x * 'y, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x * 'y, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>) = Choice11Of20 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x * 'y, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>
    let inline case11 y (x: ('T -> 'fld option) -> Codec<PropertyList<'Encoding>, PropertyList<'Encoding>, 'fld, 'T>) : 'rt =
        let inline call (_: ^t, _: ^r, (x, y: ^p)) = ((^t or ^r ) : (static member Case: _ * _ * ^r -> ^r) (y, x, Unchecked.defaultof<'r>) )
        call (Unchecked.defaultof<Choice11OfN>, Unchecked.defaultof<'rt>, (x, y))

    type Choice12OfN =
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x * 'y>) = Choice12Of12 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x * 'y>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x * 'y, 'x13>) = Choice12Of13 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x * 'y, 'x13>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x * 'y, 'x13, 'x14>) = Choice12Of14 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x * 'y, 'x13, 'x14>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x * 'y, 'x13, 'x14, 'x15>) = Choice12Of15 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x * 'y, 'x13, 'x14, 'x15>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x * 'y, 'x13, 'x14, 'x15, 'x16>) = Choice12Of16 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x * 'y, 'x13, 'x14, 'x15, 'x16>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x * 'y, 'x13, 'x14, 'x15, 'x16, 'x17>) = Choice12Of17 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x * 'y, 'x13, 'x14, 'x15, 'x16, 'x17>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x * 'y, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>) = Choice12Of18 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x * 'y, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x * 'y, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>) = Choice12Of19 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x * 'y, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x * 'y, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>) = Choice12Of20 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x * 'y, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>
    let inline case12 y (x: ('T -> 'fld option) -> Codec<PropertyList<'Encoding>, PropertyList<'Encoding>, 'fld, 'T>) : 'rt =
        let inline call (_: ^t, _: ^r, (x, y: ^p)) = ((^t or ^r ) : (static member Case: _ * _ * ^r -> ^r) (y, x, Unchecked.defaultof<'r>) )
        call (Unchecked.defaultof<Choice12OfN>, Unchecked.defaultof<'rt>, (x, y))

    type Choice13OfN =
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x * 'y>) = Choice13Of13 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x * 'y>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x * 'y, 'x14>) = Choice13Of14 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x * 'y, 'x14>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x * 'y, 'x14, 'x15>) = Choice13Of15 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x * 'y, 'x14, 'x15>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x * 'y, 'x14, 'x15, 'x16>) = Choice13Of16 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x * 'y, 'x14, 'x15, 'x16>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x * 'y, 'x14, 'x15, 'x16, 'x17>) = Choice13Of17 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x * 'y, 'x14, 'x15, 'x16, 'x17>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x * 'y, 'x14, 'x15, 'x16, 'x17, 'x18>) = Choice13Of18 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x * 'y, 'x14, 'x15, 'x16, 'x17, 'x18>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x * 'y, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>) = Choice13Of19 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x * 'y, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x * 'y, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>) = Choice13Of20 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x * 'y, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>
    let inline case13 y (x: ('T -> 'fld option) -> Codec<PropertyList<'Encoding>, PropertyList<'Encoding>, 'fld, 'T>) : 'rt =
        let inline call (_: ^t, _: ^r, (x, y: ^p)) = ((^t or ^r ) : (static member Case: _ * _ * ^r -> ^r) (y, x, Unchecked.defaultof<'r>) )
        call (Unchecked.defaultof<Choice13OfN>, Unchecked.defaultof<'rt>, (x, y))

    type Choice14OfN =
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x * 'y>) = Choice14Of14 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x * 'y>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x * 'y, 'x15>) = Choice14Of15 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x * 'y, 'x15>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x * 'y, 'x15, 'x16>) = Choice14Of16 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x * 'y, 'x15, 'x16>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x * 'y, 'x15, 'x16, 'x17>) = Choice14Of17 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x * 'y, 'x15, 'x16, 'x17>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x * 'y, 'x15, 'x16, 'x17, 'x18>) = Choice14Of18 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x * 'y, 'x15, 'x16, 'x17, 'x18>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x * 'y, 'x15, 'x16, 'x17, 'x18, 'x19>) = Choice14Of19 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x * 'y, 'x15, 'x16, 'x17, 'x18, 'x19>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x * 'y, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>) = Choice14Of20 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x * 'y, 'x15, 'x16, 'x17, 'x18, 'x19, 'x20>
    let inline case14 y (x: ('T -> 'fld option) -> Codec<PropertyList<'Encoding>, PropertyList<'Encoding>, 'fld, 'T>) : 'rt =
        let inline call (_: ^t, _: ^r, (x, y: ^p)) = ((^t or ^r ) : (static member Case: _ * _ * ^r -> ^r) (y, x, Unchecked.defaultof<'r>) )
        call (Unchecked.defaultof<Choice14OfN>, Unchecked.defaultof<'rt>, (x, y))

    type Choice15OfN =
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x * 'y>) = Choice15Of15 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x * 'y>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x * 'y, 'x16>) = Choice15Of16 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x * 'y, 'x16>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x * 'y, 'x16, 'x17>) = Choice15Of17 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x * 'y, 'x16, 'x17>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x * 'y, 'x16, 'x17, 'x18>) = Choice15Of18 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x * 'y, 'x16, 'x17, 'x18>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x * 'y, 'x16, 'x17, 'x18, 'x19>) = Choice15Of19 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x * 'y, 'x16, 'x17, 'x18, 'x19>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x * 'y, 'x16, 'x17, 'x18, 'x19, 'x20>) = Choice15Of20 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x * 'y, 'x16, 'x17, 'x18, 'x19, 'x20>
    let inline case15 y (x: ('T -> 'fld option) -> Codec<PropertyList<'Encoding>, PropertyList<'Encoding>, 'fld, 'T>) : 'rt =
        let inline call (_: ^t, _: ^r, (x, y: ^p)) = ((^t or ^r ) : (static member Case: _ * _ * ^r -> ^r) (y, x, Unchecked.defaultof<'r>) )
        call (Unchecked.defaultof<Choice15OfN>, Unchecked.defaultof<'rt>, (x, y))

    type Choice16OfN =
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x * 'y>) = Choice16Of16 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x * 'y>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x * 'y, 'x17>) = Choice16Of17 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x * 'y, 'x17>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x * 'y, 'x17, 'x18>) = Choice16Of18 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x * 'y, 'x17, 'x18>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x * 'y, 'x17, 'x18, 'x19>) = Choice16Of19 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x * 'y, 'x17, 'x18, 'x19>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x * 'y, 'x17, 'x18, 'x19, 'x20>) = Choice16Of20 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x * 'y, 'x17, 'x18, 'x19, 'x20>
    let inline case16 y (x: ('T -> 'fld option) -> Codec<PropertyList<'Encoding>, PropertyList<'Encoding>, 'fld, 'T>) : 'rt =
        let inline call (_: ^t, _: ^r, (x, y: ^p)) = ((^t or ^r ) : (static member Case: _ * _ * ^r -> ^r) (y, x, Unchecked.defaultof<'r>) )
        call (Unchecked.defaultof<Choice16OfN>, Unchecked.defaultof<'rt>, (x, y))

    type Choice17OfN =
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x * 'y>) = Choice17Of17 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x * 'y>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x * 'y, 'x18>) = Choice17Of18 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x * 'y, 'x18>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x * 'y, 'x18, 'x19>) = Choice17Of19 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x * 'y, 'x18, 'x19>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x * 'y, 'x18, 'x19, 'x20>) = Choice17Of20 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x * 'y, 'x18, 'x19, 'x20>
    let inline case17 y (x: ('T -> 'fld option) -> Codec<PropertyList<'Encoding>, PropertyList<'Encoding>, 'fld, 'T>) : 'rt =
        let inline call (_: ^t, _: ^r, (x, y: ^p)) = ((^t or ^r ) : (static member Case: _ * _ * ^r -> ^r) (y, x, Unchecked.defaultof<'r>) )
        call (Unchecked.defaultof<Choice17OfN>, Unchecked.defaultof<'rt>, (x, y))

    type Choice18OfN =
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x * 'y>) = Choice18Of18 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x * 'y>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x * 'y, 'x19>) = Choice18Of19 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x * 'y, 'x19>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x * 'y, 'x19, 'x20>) = Choice18Of20 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x * 'y, 'x19, 'x20>
    let inline case18 y (x: ('T -> 'fld option) -> Codec<PropertyList<'Encoding>, PropertyList<'Encoding>, 'fld, 'T>) : 'rt =
        let inline call (_: ^t, _: ^r, (x, y: ^p)) = ((^t or ^r ) : (static member Case: _ * _ * ^r -> ^r) (y, x, Unchecked.defaultof<'r>) )
        call (Unchecked.defaultof<Choice18OfN>, Unchecked.defaultof<'rt>, (x, y))

    type Choice19OfN =
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x * 'y>) = Choice19Of19 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x * 'y>
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x * 'y, 'x20>) = Choice19Of20 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x * 'y, 'x20>
    let inline case19 y (x: ('T -> 'fld option) -> Codec<PropertyList<'Encoding>, PropertyList<'Encoding>, 'fld, 'T>) : 'rt =
        let inline call (_: ^t, _: ^r, (x, y: ^p)) = ((^t or ^r ) : (static member Case: _ * _ * ^r -> ^r) (y, x, Unchecked.defaultof<'r>) )
        call (Unchecked.defaultof<Choice19OfN>, Unchecked.defaultof<'rt>, (x, y))

    type Choice20OfN =
        static member Case (x: 'x, y: 'y, _: Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x * 'y>) = Choice20Of20 (x, y) : Choice<'x1, 'x2, 'x3, 'x4, 'x5, 'x6, 'x7, 'x8, 'x9, 'x10, 'x11, 'x12, 'x13, 'x14, 'x15, 'x16, 'x17, 'x18, 'x19, 'x * 'y>
    let inline case20 y (x: ('T -> 'fld option) -> Codec<PropertyList<'Encoding>, PropertyList<'Encoding>, 'fld, 'T>) : 'rt =
        let inline call (_: ^t, _: ^r, (x, y: ^p)) = ((^t or ^r ) : (static member Case: _ * _ * ^r -> ^r) (y, x, Unchecked.defaultof<'r>) )
        call (Unchecked.defaultof<Choice20OfN>, Unchecked.defaultof<'rt>, (x, y))

    [<AutoOpen>]
    type Cases =
        static member withCases (case1) = fun matcher ->
            let f1 (g: ('Union -> _)) : _ = g (case1 (nonNullTuple (): 'params1))
            codec {
                Codec.map case1 (f1 (matcher >> (function Choice1Of1 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice1Of1 x -> Some x | _ -> None) >> Option.map fst))
            }

        static member withCases (case1, case2) = fun matcher ->
            let f1 (g: ('Union -> _)) : _ = g (case1 (nonNullTuple (): 'params1))
            let f2 (g: ('Union -> _)) : _ = g (case2 (nonNullTuple (): 'params2))
            codec {
                Codec.map case1 (f1 (matcher >> (function Choice1Of2 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice1Of2 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case2 (f2 (matcher >> (function Choice2Of2 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice2Of2 x -> Some x | _ -> None) >> Option.map fst))
            }

        static member withCases (case1, case2, case3) = fun matcher ->
            let f1 (g: ('Union -> _)) : _ = g (case1 (nonNullTuple (): 'params1))
            let f2 (g: ('Union -> _)) : _ = g (case2 (nonNullTuple (): 'params2))
            let f3 (g: ('Union -> _)) : _ = g (case3 (nonNullTuple (): 'params3))
            codec {
                Codec.map case1 (f1 (matcher >> (function Choice1Of3 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice1Of3 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case2 (f2 (matcher >> (function Choice2Of3 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice2Of3 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case3 (f3 (matcher >> (function Choice3Of3 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice3Of3 x -> Some x | _ -> None) >> Option.map fst))
            }

        static member withCases (case1, case2, case3, case4) = fun matcher ->
            let f1 (g: ('Union -> _)) : _ = g (case1 (nonNullTuple (): 'params1))
            let f2 (g: ('Union -> _)) : _ = g (case2 (nonNullTuple (): 'params2))
            let f3 (g: ('Union -> _)) : _ = g (case3 (nonNullTuple (): 'params3))
            let f4 (g: ('Union -> _)) : _ = g (case4 (nonNullTuple (): 'params4))
            codec {
                Codec.map case1 (f1 (matcher >> (function Choice1Of4 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice1Of4 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case2 (f2 (matcher >> (function Choice2Of4 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice2Of4 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case3 (f3 (matcher >> (function Choice3Of4 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice3Of4 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case4 (f4 (matcher >> (function Choice4Of4 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice4Of4 x -> Some x | _ -> None) >> Option.map fst))
            }

        static member withCases (case1, case2, case3, case4, case5) = fun matcher ->
            let f1 (g: ('Union -> _)) : _ = g (case1 (nonNullTuple (): 'params1))
            let f2 (g: ('Union -> _)) : _ = g (case2 (nonNullTuple (): 'params2))
            let f3 (g: ('Union -> _)) : _ = g (case3 (nonNullTuple (): 'params3))
            let f4 (g: ('Union -> _)) : _ = g (case4 (nonNullTuple (): 'params4))
            let f5 (g: ('Union -> _)) : _ = g (case5 (nonNullTuple (): 'params5))
            codec {
                Codec.map case1 (f1 (matcher >> (function Choice1Of5 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice1Of5 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case2 (f2 (matcher >> (function Choice2Of5 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice2Of5 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case3 (f3 (matcher >> (function Choice3Of5 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice3Of5 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case4 (f4 (matcher >> (function Choice4Of5 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice4Of5 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case5 (f5 (matcher >> (function Choice5Of5 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice5Of5 x -> Some x | _ -> None) >> Option.map fst))
            }

        static member withCases (case1, case2, case3, case4, case5, case6) = fun matcher ->
            let f1 (g: ('Union -> _)) : _ = g (case1 (nonNullTuple (): 'params1))
            let f2 (g: ('Union -> _)) : _ = g (case2 (nonNullTuple (): 'params2))
            let f3 (g: ('Union -> _)) : _ = g (case3 (nonNullTuple (): 'params3))
            let f4 (g: ('Union -> _)) : _ = g (case4 (nonNullTuple (): 'params4))
            let f5 (g: ('Union -> _)) : _ = g (case5 (nonNullTuple (): 'params5))
            let f6 (g: ('Union -> _)) : _ = g (case6 (nonNullTuple (): 'params6))
            codec {
                Codec.map case1 (f1 (matcher >> (function Choice1Of6 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice1Of6 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case2 (f2 (matcher >> (function Choice2Of6 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice2Of6 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case3 (f3 (matcher >> (function Choice3Of6 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice3Of6 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case4 (f4 (matcher >> (function Choice4Of6 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice4Of6 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case5 (f5 (matcher >> (function Choice5Of6 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice5Of6 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case6 (f6 (matcher >> (function Choice6Of6 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice6Of6 x -> Some x | _ -> None) >> Option.map fst))
            }

        static member withCases (case1, case2, case3, case4, case5, case6, case7) = fun matcher ->
            let f1 (g: ('Union -> _)) : _ = g (case1 (nonNullTuple (): 'params1))
            let f2 (g: ('Union -> _)) : _ = g (case2 (nonNullTuple (): 'params2))
            let f3 (g: ('Union -> _)) : _ = g (case3 (nonNullTuple (): 'params3))
            let f4 (g: ('Union -> _)) : _ = g (case4 (nonNullTuple (): 'params4))
            let f5 (g: ('Union -> _)) : _ = g (case5 (nonNullTuple (): 'params5))
            let f6 (g: ('Union -> _)) : _ = g (case6 (nonNullTuple (): 'params6))
            let f7 (g: ('Union -> _)) : _ = g (case7 (nonNullTuple (): 'params7))
            codec {
                Codec.map case1 (f1 (matcher >> (function Choice1Of7 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice1Of7 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case2 (f2 (matcher >> (function Choice2Of7 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice2Of7 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case3 (f3 (matcher >> (function Choice3Of7 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice3Of7 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case4 (f4 (matcher >> (function Choice4Of7 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice4Of7 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case5 (f5 (matcher >> (function Choice5Of7 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice5Of7 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case6 (f6 (matcher >> (function Choice6Of7 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice6Of7 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case7 (f7 (matcher >> (function Choice7Of7 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice7Of7 x -> Some x | _ -> None) >> Option.map fst))
            }

        static member withCases (case1, case2, case3, case4, case5, case6, case7, case8) = fun matcher ->
            let f1 (g: ('Union -> _)) : _ = g (case1 (nonNullTuple (): 'params1))
            let f2 (g: ('Union -> _)) : _ = g (case2 (nonNullTuple (): 'params2))
            let f3 (g: ('Union -> _)) : _ = g (case3 (nonNullTuple (): 'params3))
            let f4 (g: ('Union -> _)) : _ = g (case4 (nonNullTuple (): 'params4))
            let f5 (g: ('Union -> _)) : _ = g (case5 (nonNullTuple (): 'params5))
            let f6 (g: ('Union -> _)) : _ = g (case6 (nonNullTuple (): 'params6))
            let f7 (g: ('Union -> _)) : _ = g (case7 (nonNullTuple (): 'params7))
            let f8 (g: ('Union -> _)) : _ = g (case8 (nonNullTuple (): 'params8))
            codec {
                Codec.map case1 (f1 (matcher >> (function Choice1Of8 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice1Of8 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case2 (f2 (matcher >> (function Choice2Of8 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice2Of8 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case3 (f3 (matcher >> (function Choice3Of8 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice3Of8 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case4 (f4 (matcher >> (function Choice4Of8 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice4Of8 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case5 (f5 (matcher >> (function Choice5Of8 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice5Of8 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case6 (f6 (matcher >> (function Choice6Of8 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice6Of8 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case7 (f7 (matcher >> (function Choice7Of8 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice7Of8 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case8 (f8 (matcher >> (function Choice8Of8 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice8Of8 x -> Some x | _ -> None) >> Option.map fst))
            }

        static member withCases (case1, case2, case3, case4, case5, case6, case7, case8, case9) = fun matcher ->
            let f1 (g: ('Union -> _)) : _ = g (case1 (nonNullTuple (): 'params1))
            let f2 (g: ('Union -> _)) : _ = g (case2 (nonNullTuple (): 'params2))
            let f3 (g: ('Union -> _)) : _ = g (case3 (nonNullTuple (): 'params3))
            let f4 (g: ('Union -> _)) : _ = g (case4 (nonNullTuple (): 'params4))
            let f5 (g: ('Union -> _)) : _ = g (case5 (nonNullTuple (): 'params5))
            let f6 (g: ('Union -> _)) : _ = g (case6 (nonNullTuple (): 'params6))
            let f7 (g: ('Union -> _)) : _ = g (case7 (nonNullTuple (): 'params7))
            let f8 (g: ('Union -> _)) : _ = g (case8 (nonNullTuple (): 'params8))
            let f9 (g: ('Union -> _)) : _ = g (case9 (nonNullTuple (): 'params9))
            codec {
                Codec.map case1 (f1 (matcher >> (function Choice1Of9 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice1Of9 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case2 (f2 (matcher >> (function Choice2Of9 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice2Of9 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case3 (f3 (matcher >> (function Choice3Of9 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice3Of9 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case4 (f4 (matcher >> (function Choice4Of9 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice4Of9 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case5 (f5 (matcher >> (function Choice5Of9 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice5Of9 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case6 (f6 (matcher >> (function Choice6Of9 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice6Of9 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case7 (f7 (matcher >> (function Choice7Of9 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice7Of9 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case8 (f8 (matcher >> (function Choice8Of9 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice8Of9 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case9 (f9 (matcher >> (function Choice9Of9 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice9Of9 x -> Some x | _ -> None) >> Option.map fst))
            }

        static member withCases (case1, case2, case3, case4, case5, case6, case7, case8, case9, case10) = fun matcher ->
            let f1 (g: ('Union -> _)) : _ = g (case1 (nonNullTuple (): 'params1))
            let f2 (g: ('Union -> _)) : _ = g (case2 (nonNullTuple (): 'params2))
            let f3 (g: ('Union -> _)) : _ = g (case3 (nonNullTuple (): 'params3))
            let f4 (g: ('Union -> _)) : _ = g (case4 (nonNullTuple (): 'params4))
            let f5 (g: ('Union -> _)) : _ = g (case5 (nonNullTuple (): 'params5))
            let f6 (g: ('Union -> _)) : _ = g (case6 (nonNullTuple (): 'params6))
            let f7 (g: ('Union -> _)) : _ = g (case7 (nonNullTuple (): 'params7))
            let f8 (g: ('Union -> _)) : _ = g (case8 (nonNullTuple (): 'params8))
            let f9 (g: ('Union -> _)) : _ = g (case9 (nonNullTuple (): 'params9))
            let f10 (g: ('Union -> _)) : _ = g (case10 (nonNullTuple (): 'params10))
            codec {
                Codec.map case1 (f1 (matcher >> (function Choice1Of10 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice1Of10 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case2 (f2 (matcher >> (function Choice2Of10 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice2Of10 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case3 (f3 (matcher >> (function Choice3Of10 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice3Of10 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case4 (f4 (matcher >> (function Choice4Of10 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice4Of10 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case5 (f5 (matcher >> (function Choice5Of10 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice5Of10 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case6 (f6 (matcher >> (function Choice6Of10 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice6Of10 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case7 (f7 (matcher >> (function Choice7Of10 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice7Of10 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case8 (f8 (matcher >> (function Choice8Of10 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice8Of10 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case9 (f9 (matcher >> (function Choice9Of10 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice9Of10 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case10 (f10 (matcher >> (function Choice10Of10 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice10Of10 x -> Some x | _ -> None) >> Option.map fst))
            }

        static member withCases (case1, case2, case3, case4, case5, case6, case7, case8, case9, case10, case11) = fun matcher ->
            let f1 (g: ('Union -> _)) : _ = g (case1 (nonNullTuple (): 'params1))
            let f2 (g: ('Union -> _)) : _ = g (case2 (nonNullTuple (): 'params2))
            let f3 (g: ('Union -> _)) : _ = g (case3 (nonNullTuple (): 'params3))
            let f4 (g: ('Union -> _)) : _ = g (case4 (nonNullTuple (): 'params4))
            let f5 (g: ('Union -> _)) : _ = g (case5 (nonNullTuple (): 'params5))
            let f6 (g: ('Union -> _)) : _ = g (case6 (nonNullTuple (): 'params6))
            let f7 (g: ('Union -> _)) : _ = g (case7 (nonNullTuple (): 'params7))
            let f8 (g: ('Union -> _)) : _ = g (case8 (nonNullTuple (): 'params8))
            let f9 (g: ('Union -> _)) : _ = g (case9 (nonNullTuple (): 'params9))
            let f10 (g: ('Union -> _)) : _ = g (case10 (nonNullTuple (): 'params10))
            let f11 (g: ('Union -> _)) : _ = g (case11 (nonNullTuple (): 'params11))
            codec {
                Codec.map case1 (f1 (matcher >> (function Choice1Of11 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice1Of11 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case2 (f2 (matcher >> (function Choice2Of11 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice2Of11 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case3 (f3 (matcher >> (function Choice3Of11 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice3Of11 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case4 (f4 (matcher >> (function Choice4Of11 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice4Of11 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case5 (f5 (matcher >> (function Choice5Of11 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice5Of11 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case6 (f6 (matcher >> (function Choice6Of11 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice6Of11 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case7 (f7 (matcher >> (function Choice7Of11 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice7Of11 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case8 (f8 (matcher >> (function Choice8Of11 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice8Of11 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case9 (f9 (matcher >> (function Choice9Of11 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice9Of11 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case10 (f10 (matcher >> (function Choice10Of11 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice10Of11 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case11 (f11 (matcher >> (function Choice11Of11 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice11Of11 x -> Some x | _ -> None) >> Option.map fst))
            }

        static member withCases (case1, case2, case3, case4, case5, case6, case7, case8, case9, case10, case11, case12) = fun matcher ->
            let f1 (g: ('Union -> _)) : _ = g (case1 (nonNullTuple (): 'params1))
            let f2 (g: ('Union -> _)) : _ = g (case2 (nonNullTuple (): 'params2))
            let f3 (g: ('Union -> _)) : _ = g (case3 (nonNullTuple (): 'params3))
            let f4 (g: ('Union -> _)) : _ = g (case4 (nonNullTuple (): 'params4))
            let f5 (g: ('Union -> _)) : _ = g (case5 (nonNullTuple (): 'params5))
            let f6 (g: ('Union -> _)) : _ = g (case6 (nonNullTuple (): 'params6))
            let f7 (g: ('Union -> _)) : _ = g (case7 (nonNullTuple (): 'params7))
            let f8 (g: ('Union -> _)) : _ = g (case8 (nonNullTuple (): 'params8))
            let f9 (g: ('Union -> _)) : _ = g (case9 (nonNullTuple (): 'params9))
            let f10 (g: ('Union -> _)) : _ = g (case10 (nonNullTuple (): 'params10))
            let f11 (g: ('Union -> _)) : _ = g (case11 (nonNullTuple (): 'params11))
            let f12 (g: ('Union -> _)) : _ = g (case12 (nonNullTuple (): 'params12))
            codec {
                Codec.map case1 (f1 (matcher >> (function Choice1Of12 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice1Of12 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case2 (f2 (matcher >> (function Choice2Of12 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice2Of12 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case3 (f3 (matcher >> (function Choice3Of12 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice3Of12 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case4 (f4 (matcher >> (function Choice4Of12 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice4Of12 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case5 (f5 (matcher >> (function Choice5Of12 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice5Of12 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case6 (f6 (matcher >> (function Choice6Of12 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice6Of12 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case7 (f7 (matcher >> (function Choice7Of12 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice7Of12 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case8 (f8 (matcher >> (function Choice8Of12 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice8Of12 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case9 (f9 (matcher >> (function Choice9Of12 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice9Of12 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case10 (f10 (matcher >> (function Choice10Of12 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice10Of12 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case11 (f11 (matcher >> (function Choice11Of12 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice11Of12 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case12 (f12 (matcher >> (function Choice12Of12 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice12Of12 x -> Some x | _ -> None) >> Option.map fst))
            }

        static member withCases (case1, case2, case3, case4, case5, case6, case7, case8, case9, case10, case11, case12, case13) = fun matcher ->
            let f1 (g: ('Union -> _)) : _ = g (case1 (nonNullTuple (): 'params1))
            let f2 (g: ('Union -> _)) : _ = g (case2 (nonNullTuple (): 'params2))
            let f3 (g: ('Union -> _)) : _ = g (case3 (nonNullTuple (): 'params3))
            let f4 (g: ('Union -> _)) : _ = g (case4 (nonNullTuple (): 'params4))
            let f5 (g: ('Union -> _)) : _ = g (case5 (nonNullTuple (): 'params5))
            let f6 (g: ('Union -> _)) : _ = g (case6 (nonNullTuple (): 'params6))
            let f7 (g: ('Union -> _)) : _ = g (case7 (nonNullTuple (): 'params7))
            let f8 (g: ('Union -> _)) : _ = g (case8 (nonNullTuple (): 'params8))
            let f9 (g: ('Union -> _)) : _ = g (case9 (nonNullTuple (): 'params9))
            let f10 (g: ('Union -> _)) : _ = g (case10 (nonNullTuple (): 'params10))
            let f11 (g: ('Union -> _)) : _ = g (case11 (nonNullTuple (): 'params11))
            let f12 (g: ('Union -> _)) : _ = g (case12 (nonNullTuple (): 'params12))
            let f13 (g: ('Union -> _)) : _ = g (case13 (nonNullTuple (): 'params13))
            codec {
                Codec.map case1 (f1 (matcher >> (function Choice1Of13 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice1Of13 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case2 (f2 (matcher >> (function Choice2Of13 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice2Of13 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case3 (f3 (matcher >> (function Choice3Of13 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice3Of13 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case4 (f4 (matcher >> (function Choice4Of13 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice4Of13 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case5 (f5 (matcher >> (function Choice5Of13 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice5Of13 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case6 (f6 (matcher >> (function Choice6Of13 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice6Of13 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case7 (f7 (matcher >> (function Choice7Of13 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice7Of13 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case8 (f8 (matcher >> (function Choice8Of13 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice8Of13 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case9 (f9 (matcher >> (function Choice9Of13 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice9Of13 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case10 (f10 (matcher >> (function Choice10Of13 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice10Of13 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case11 (f11 (matcher >> (function Choice11Of13 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice11Of13 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case12 (f12 (matcher >> (function Choice12Of13 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice12Of13 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case13 (f13 (matcher >> (function Choice13Of13 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice13Of13 x -> Some x | _ -> None) >> Option.map fst))
            }

        static member withCases (case1, case2, case3, case4, case5, case6, case7, case8, case9, case10, case11, case12, case13, case14) = fun matcher ->
            let f1 (g: ('Union -> _)) : _ = g (case1 (nonNullTuple (): 'params1))
            let f2 (g: ('Union -> _)) : _ = g (case2 (nonNullTuple (): 'params2))
            let f3 (g: ('Union -> _)) : _ = g (case3 (nonNullTuple (): 'params3))
            let f4 (g: ('Union -> _)) : _ = g (case4 (nonNullTuple (): 'params4))
            let f5 (g: ('Union -> _)) : _ = g (case5 (nonNullTuple (): 'params5))
            let f6 (g: ('Union -> _)) : _ = g (case6 (nonNullTuple (): 'params6))
            let f7 (g: ('Union -> _)) : _ = g (case7 (nonNullTuple (): 'params7))
            let f8 (g: ('Union -> _)) : _ = g (case8 (nonNullTuple (): 'params8))
            let f9 (g: ('Union -> _)) : _ = g (case9 (nonNullTuple (): 'params9))
            let f10 (g: ('Union -> _)) : _ = g (case10 (nonNullTuple (): 'params10))
            let f11 (g: ('Union -> _)) : _ = g (case11 (nonNullTuple (): 'params11))
            let f12 (g: ('Union -> _)) : _ = g (case12 (nonNullTuple (): 'params12))
            let f13 (g: ('Union -> _)) : _ = g (case13 (nonNullTuple (): 'params13))
            let f14 (g: ('Union -> _)) : _ = g (case14 (nonNullTuple (): 'params14))
            codec {
                Codec.map case1 (f1 (matcher >> (function Choice1Of14 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice1Of14 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case2 (f2 (matcher >> (function Choice2Of14 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice2Of14 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case3 (f3 (matcher >> (function Choice3Of14 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice3Of14 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case4 (f4 (matcher >> (function Choice4Of14 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice4Of14 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case5 (f5 (matcher >> (function Choice5Of14 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice5Of14 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case6 (f6 (matcher >> (function Choice6Of14 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice6Of14 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case7 (f7 (matcher >> (function Choice7Of14 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice7Of14 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case8 (f8 (matcher >> (function Choice8Of14 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice8Of14 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case9 (f9 (matcher >> (function Choice9Of14 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice9Of14 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case10 (f10 (matcher >> (function Choice10Of14 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice10Of14 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case11 (f11 (matcher >> (function Choice11Of14 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice11Of14 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case12 (f12 (matcher >> (function Choice12Of14 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice12Of14 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case13 (f13 (matcher >> (function Choice13Of14 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice13Of14 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case14 (f14 (matcher >> (function Choice14Of14 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice14Of14 x -> Some x | _ -> None) >> Option.map fst))
            }

        static member withCases (case1, case2, case3, case4, case5, case6, case7, case8, case9, case10, case11, case12, case13, case14, case15) = fun matcher ->
            let f1 (g: ('Union -> _)) : _ = g (case1 (nonNullTuple (): 'params1))
            let f2 (g: ('Union -> _)) : _ = g (case2 (nonNullTuple (): 'params2))
            let f3 (g: ('Union -> _)) : _ = g (case3 (nonNullTuple (): 'params3))
            let f4 (g: ('Union -> _)) : _ = g (case4 (nonNullTuple (): 'params4))
            let f5 (g: ('Union -> _)) : _ = g (case5 (nonNullTuple (): 'params5))
            let f6 (g: ('Union -> _)) : _ = g (case6 (nonNullTuple (): 'params6))
            let f7 (g: ('Union -> _)) : _ = g (case7 (nonNullTuple (): 'params7))
            let f8 (g: ('Union -> _)) : _ = g (case8 (nonNullTuple (): 'params8))
            let f9 (g: ('Union -> _)) : _ = g (case9 (nonNullTuple (): 'params9))
            let f10 (g: ('Union -> _)) : _ = g (case10 (nonNullTuple (): 'params10))
            let f11 (g: ('Union -> _)) : _ = g (case11 (nonNullTuple (): 'params11))
            let f12 (g: ('Union -> _)) : _ = g (case12 (nonNullTuple (): 'params12))
            let f13 (g: ('Union -> _)) : _ = g (case13 (nonNullTuple (): 'params13))
            let f14 (g: ('Union -> _)) : _ = g (case14 (nonNullTuple (): 'params14))
            let f15 (g: ('Union -> _)) : _ = g (case15 (nonNullTuple (): 'params15))
            codec {
                Codec.map case1 (f1 (matcher >> (function Choice1Of15 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice1Of15 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case2 (f2 (matcher >> (function Choice2Of15 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice2Of15 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case3 (f3 (matcher >> (function Choice3Of15 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice3Of15 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case4 (f4 (matcher >> (function Choice4Of15 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice4Of15 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case5 (f5 (matcher >> (function Choice5Of15 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice5Of15 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case6 (f6 (matcher >> (function Choice6Of15 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice6Of15 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case7 (f7 (matcher >> (function Choice7Of15 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice7Of15 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case8 (f8 (matcher >> (function Choice8Of15 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice8Of15 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case9 (f9 (matcher >> (function Choice9Of15 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice9Of15 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case10 (f10 (matcher >> (function Choice10Of15 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice10Of15 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case11 (f11 (matcher >> (function Choice11Of15 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice11Of15 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case12 (f12 (matcher >> (function Choice12Of15 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice12Of15 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case13 (f13 (matcher >> (function Choice13Of15 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice13Of15 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case14 (f14 (matcher >> (function Choice14Of15 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice14Of15 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case15 (f15 (matcher >> (function Choice15Of15 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice15Of15 x -> Some x | _ -> None) >> Option.map fst))
            }

        static member withCases (case1, case2, case3, case4, case5, case6, case7, case8, case9, case10, case11, case12, case13, case14, case15, case16) = fun matcher ->
            let f1 (g: ('Union -> _)) : _ = g (case1 (nonNullTuple (): 'params1))
            let f2 (g: ('Union -> _)) : _ = g (case2 (nonNullTuple (): 'params2))
            let f3 (g: ('Union -> _)) : _ = g (case3 (nonNullTuple (): 'params3))
            let f4 (g: ('Union -> _)) : _ = g (case4 (nonNullTuple (): 'params4))
            let f5 (g: ('Union -> _)) : _ = g (case5 (nonNullTuple (): 'params5))
            let f6 (g: ('Union -> _)) : _ = g (case6 (nonNullTuple (): 'params6))
            let f7 (g: ('Union -> _)) : _ = g (case7 (nonNullTuple (): 'params7))
            let f8 (g: ('Union -> _)) : _ = g (case8 (nonNullTuple (): 'params8))
            let f9 (g: ('Union -> _)) : _ = g (case9 (nonNullTuple (): 'params9))
            let f10 (g: ('Union -> _)) : _ = g (case10 (nonNullTuple (): 'params10))
            let f11 (g: ('Union -> _)) : _ = g (case11 (nonNullTuple (): 'params11))
            let f12 (g: ('Union -> _)) : _ = g (case12 (nonNullTuple (): 'params12))
            let f13 (g: ('Union -> _)) : _ = g (case13 (nonNullTuple (): 'params13))
            let f14 (g: ('Union -> _)) : _ = g (case14 (nonNullTuple (): 'params14))
            let f15 (g: ('Union -> _)) : _ = g (case15 (nonNullTuple (): 'params15))
            let f16 (g: ('Union -> _)) : _ = g (case16 (nonNullTuple (): 'params16))
            codec {
                Codec.map case1 (f1 (matcher >> (function Choice1Of16 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice1Of16 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case2 (f2 (matcher >> (function Choice2Of16 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice2Of16 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case3 (f3 (matcher >> (function Choice3Of16 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice3Of16 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case4 (f4 (matcher >> (function Choice4Of16 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice4Of16 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case5 (f5 (matcher >> (function Choice5Of16 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice5Of16 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case6 (f6 (matcher >> (function Choice6Of16 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice6Of16 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case7 (f7 (matcher >> (function Choice7Of16 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice7Of16 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case8 (f8 (matcher >> (function Choice8Of16 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice8Of16 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case9 (f9 (matcher >> (function Choice9Of16 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice9Of16 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case10 (f10 (matcher >> (function Choice10Of16 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice10Of16 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case11 (f11 (matcher >> (function Choice11Of16 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice11Of16 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case12 (f12 (matcher >> (function Choice12Of16 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice12Of16 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case13 (f13 (matcher >> (function Choice13Of16 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice13Of16 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case14 (f14 (matcher >> (function Choice14Of16 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice14Of16 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case15 (f15 (matcher >> (function Choice15Of16 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice15Of16 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case16 (f16 (matcher >> (function Choice16Of16 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice16Of16 x -> Some x | _ -> None) >> Option.map fst))
            }

        static member withCases (case1, case2, case3, case4, case5, case6, case7, case8, case9, case10, case11, case12, case13, case14, case15, case16, case17) = fun matcher ->
            let f1 (g: ('Union -> _)) : _ = g (case1 (nonNullTuple (): 'params1))
            let f2 (g: ('Union -> _)) : _ = g (case2 (nonNullTuple (): 'params2))
            let f3 (g: ('Union -> _)) : _ = g (case3 (nonNullTuple (): 'params3))
            let f4 (g: ('Union -> _)) : _ = g (case4 (nonNullTuple (): 'params4))
            let f5 (g: ('Union -> _)) : _ = g (case5 (nonNullTuple (): 'params5))
            let f6 (g: ('Union -> _)) : _ = g (case6 (nonNullTuple (): 'params6))
            let f7 (g: ('Union -> _)) : _ = g (case7 (nonNullTuple (): 'params7))
            let f8 (g: ('Union -> _)) : _ = g (case8 (nonNullTuple (): 'params8))
            let f9 (g: ('Union -> _)) : _ = g (case9 (nonNullTuple (): 'params9))
            let f10 (g: ('Union -> _)) : _ = g (case10 (nonNullTuple (): 'params10))
            let f11 (g: ('Union -> _)) : _ = g (case11 (nonNullTuple (): 'params11))
            let f12 (g: ('Union -> _)) : _ = g (case12 (nonNullTuple (): 'params12))
            let f13 (g: ('Union -> _)) : _ = g (case13 (nonNullTuple (): 'params13))
            let f14 (g: ('Union -> _)) : _ = g (case14 (nonNullTuple (): 'params14))
            let f15 (g: ('Union -> _)) : _ = g (case15 (nonNullTuple (): 'params15))
            let f16 (g: ('Union -> _)) : _ = g (case16 (nonNullTuple (): 'params16))
            let f17 (g: ('Union -> _)) : _ = g (case17 (nonNullTuple (): 'params17))
            codec {
                Codec.map case1 (f1 (matcher >> (function Choice1Of17 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice1Of17 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case2 (f2 (matcher >> (function Choice2Of17 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice2Of17 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case3 (f3 (matcher >> (function Choice3Of17 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice3Of17 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case4 (f4 (matcher >> (function Choice4Of17 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice4Of17 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case5 (f5 (matcher >> (function Choice5Of17 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice5Of17 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case6 (f6 (matcher >> (function Choice6Of17 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice6Of17 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case7 (f7 (matcher >> (function Choice7Of17 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice7Of17 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case8 (f8 (matcher >> (function Choice8Of17 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice8Of17 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case9 (f9 (matcher >> (function Choice9Of17 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice9Of17 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case10 (f10 (matcher >> (function Choice10Of17 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice10Of17 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case11 (f11 (matcher >> (function Choice11Of17 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice11Of17 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case12 (f12 (matcher >> (function Choice12Of17 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice12Of17 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case13 (f13 (matcher >> (function Choice13Of17 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice13Of17 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case14 (f14 (matcher >> (function Choice14Of17 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice14Of17 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case15 (f15 (matcher >> (function Choice15Of17 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice15Of17 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case16 (f16 (matcher >> (function Choice16Of17 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice16Of17 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case17 (f17 (matcher >> (function Choice17Of17 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice17Of17 x -> Some x | _ -> None) >> Option.map fst))
            }

        static member withCases (case1, case2, case3, case4, case5, case6, case7, case8, case9, case10, case11, case12, case13, case14, case15, case16, case17, case18) = fun matcher ->
            let f1 (g: ('Union -> _)) : _ = g (case1 (nonNullTuple (): 'params1))
            let f2 (g: ('Union -> _)) : _ = g (case2 (nonNullTuple (): 'params2))
            let f3 (g: ('Union -> _)) : _ = g (case3 (nonNullTuple (): 'params3))
            let f4 (g: ('Union -> _)) : _ = g (case4 (nonNullTuple (): 'params4))
            let f5 (g: ('Union -> _)) : _ = g (case5 (nonNullTuple (): 'params5))
            let f6 (g: ('Union -> _)) : _ = g (case6 (nonNullTuple (): 'params6))
            let f7 (g: ('Union -> _)) : _ = g (case7 (nonNullTuple (): 'params7))
            let f8 (g: ('Union -> _)) : _ = g (case8 (nonNullTuple (): 'params8))
            let f9 (g: ('Union -> _)) : _ = g (case9 (nonNullTuple (): 'params9))
            let f10 (g: ('Union -> _)) : _ = g (case10 (nonNullTuple (): 'params10))
            let f11 (g: ('Union -> _)) : _ = g (case11 (nonNullTuple (): 'params11))
            let f12 (g: ('Union -> _)) : _ = g (case12 (nonNullTuple (): 'params12))
            let f13 (g: ('Union -> _)) : _ = g (case13 (nonNullTuple (): 'params13))
            let f14 (g: ('Union -> _)) : _ = g (case14 (nonNullTuple (): 'params14))
            let f15 (g: ('Union -> _)) : _ = g (case15 (nonNullTuple (): 'params15))
            let f16 (g: ('Union -> _)) : _ = g (case16 (nonNullTuple (): 'params16))
            let f17 (g: ('Union -> _)) : _ = g (case17 (nonNullTuple (): 'params17))
            let f18 (g: ('Union -> _)) : _ = g (case18 (nonNullTuple (): 'params18))
            codec {
                Codec.map case1 (f1 (matcher >> (function Choice1Of18 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice1Of18 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case2 (f2 (matcher >> (function Choice2Of18 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice2Of18 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case3 (f3 (matcher >> (function Choice3Of18 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice3Of18 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case4 (f4 (matcher >> (function Choice4Of18 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice4Of18 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case5 (f5 (matcher >> (function Choice5Of18 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice5Of18 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case6 (f6 (matcher >> (function Choice6Of18 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice6Of18 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case7 (f7 (matcher >> (function Choice7Of18 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice7Of18 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case8 (f8 (matcher >> (function Choice8Of18 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice8Of18 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case9 (f9 (matcher >> (function Choice9Of18 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice9Of18 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case10 (f10 (matcher >> (function Choice10Of18 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice10Of18 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case11 (f11 (matcher >> (function Choice11Of18 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice11Of18 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case12 (f12 (matcher >> (function Choice12Of18 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice12Of18 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case13 (f13 (matcher >> (function Choice13Of18 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice13Of18 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case14 (f14 (matcher >> (function Choice14Of18 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice14Of18 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case15 (f15 (matcher >> (function Choice15Of18 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice15Of18 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case16 (f16 (matcher >> (function Choice16Of18 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice16Of18 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case17 (f17 (matcher >> (function Choice17Of18 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice17Of18 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case18 (f18 (matcher >> (function Choice18Of18 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice18Of18 x -> Some x | _ -> None) >> Option.map fst))
            }

        static member withCases (case1, case2, case3, case4, case5, case6, case7, case8, case9, case10, case11, case12, case13, case14, case15, case16, case17, case18, case19) = fun matcher ->
            let f1 (g: ('Union -> _)) : _ = g (case1 (nonNullTuple (): 'params1))
            let f2 (g: ('Union -> _)) : _ = g (case2 (nonNullTuple (): 'params2))
            let f3 (g: ('Union -> _)) : _ = g (case3 (nonNullTuple (): 'params3))
            let f4 (g: ('Union -> _)) : _ = g (case4 (nonNullTuple (): 'params4))
            let f5 (g: ('Union -> _)) : _ = g (case5 (nonNullTuple (): 'params5))
            let f6 (g: ('Union -> _)) : _ = g (case6 (nonNullTuple (): 'params6))
            let f7 (g: ('Union -> _)) : _ = g (case7 (nonNullTuple (): 'params7))
            let f8 (g: ('Union -> _)) : _ = g (case8 (nonNullTuple (): 'params8))
            let f9 (g: ('Union -> _)) : _ = g (case9 (nonNullTuple (): 'params9))
            let f10 (g: ('Union -> _)) : _ = g (case10 (nonNullTuple (): 'params10))
            let f11 (g: ('Union -> _)) : _ = g (case11 (nonNullTuple (): 'params11))
            let f12 (g: ('Union -> _)) : _ = g (case12 (nonNullTuple (): 'params12))
            let f13 (g: ('Union -> _)) : _ = g (case13 (nonNullTuple (): 'params13))
            let f14 (g: ('Union -> _)) : _ = g (case14 (nonNullTuple (): 'params14))
            let f15 (g: ('Union -> _)) : _ = g (case15 (nonNullTuple (): 'params15))
            let f16 (g: ('Union -> _)) : _ = g (case16 (nonNullTuple (): 'params16))
            let f17 (g: ('Union -> _)) : _ = g (case17 (nonNullTuple (): 'params17))
            let f18 (g: ('Union -> _)) : _ = g (case18 (nonNullTuple (): 'params18))
            let f19 (g: ('Union -> _)) : _ = g (case19 (nonNullTuple (): 'params19))
            codec {
                Codec.map case1 (f1 (matcher >> (function Choice1Of19 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice1Of19 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case2 (f2 (matcher >> (function Choice2Of19 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice2Of19 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case3 (f3 (matcher >> (function Choice3Of19 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice3Of19 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case4 (f4 (matcher >> (function Choice4Of19 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice4Of19 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case5 (f5 (matcher >> (function Choice5Of19 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice5Of19 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case6 (f6 (matcher >> (function Choice6Of19 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice6Of19 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case7 (f7 (matcher >> (function Choice7Of19 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice7Of19 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case8 (f8 (matcher >> (function Choice8Of19 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice8Of19 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case9 (f9 (matcher >> (function Choice9Of19 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice9Of19 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case10 (f10 (matcher >> (function Choice10Of19 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice10Of19 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case11 (f11 (matcher >> (function Choice11Of19 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice11Of19 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case12 (f12 (matcher >> (function Choice12Of19 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice12Of19 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case13 (f13 (matcher >> (function Choice13Of19 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice13Of19 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case14 (f14 (matcher >> (function Choice14Of19 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice14Of19 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case15 (f15 (matcher >> (function Choice15Of19 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice15Of19 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case16 (f16 (matcher >> (function Choice16Of19 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice16Of19 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case17 (f17 (matcher >> (function Choice17Of19 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice17Of19 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case18 (f18 (matcher >> (function Choice18Of19 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice18Of19 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case19 (f19 (matcher >> (function Choice19Of19 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice19Of19 x -> Some x | _ -> None) >> Option.map fst))
            }

        static member withCases (case1, case2, case3, case4, case5, case6, case7, case8, case9, case10, case11, case12, case13, case14, case15, case16, case17, case18, case19, case20) = fun matcher ->
            let f1 (g: ('Union -> _)) : _ = g (case1 (nonNullTuple (): 'params1))
            let f2 (g: ('Union -> _)) : _ = g (case2 (nonNullTuple (): 'params2))
            let f3 (g: ('Union -> _)) : _ = g (case3 (nonNullTuple (): 'params3))
            let f4 (g: ('Union -> _)) : _ = g (case4 (nonNullTuple (): 'params4))
            let f5 (g: ('Union -> _)) : _ = g (case5 (nonNullTuple (): 'params5))
            let f6 (g: ('Union -> _)) : _ = g (case6 (nonNullTuple (): 'params6))
            let f7 (g: ('Union -> _)) : _ = g (case7 (nonNullTuple (): 'params7))
            let f8 (g: ('Union -> _)) : _ = g (case8 (nonNullTuple (): 'params8))
            let f9 (g: ('Union -> _)) : _ = g (case9 (nonNullTuple (): 'params9))
            let f10 (g: ('Union -> _)) : _ = g (case10 (nonNullTuple (): 'params10))
            let f11 (g: ('Union -> _)) : _ = g (case11 (nonNullTuple (): 'params11))
            let f12 (g: ('Union -> _)) : _ = g (case12 (nonNullTuple (): 'params12))
            let f13 (g: ('Union -> _)) : _ = g (case13 (nonNullTuple (): 'params13))
            let f14 (g: ('Union -> _)) : _ = g (case14 (nonNullTuple (): 'params14))
            let f15 (g: ('Union -> _)) : _ = g (case15 (nonNullTuple (): 'params15))
            let f16 (g: ('Union -> _)) : _ = g (case16 (nonNullTuple (): 'params16))
            let f17 (g: ('Union -> _)) : _ = g (case17 (nonNullTuple (): 'params17))
            let f18 (g: ('Union -> _)) : _ = g (case18 (nonNullTuple (): 'params18))
            let f19 (g: ('Union -> _)) : _ = g (case19 (nonNullTuple (): 'params19))
            let f20 (g: ('Union -> _)) : _ = g (case20 (nonNullTuple (): 'params20))
            codec {
                Codec.map case1 (f1 (matcher >> (function Choice1Of20 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice1Of20 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case2 (f2 (matcher >> (function Choice2Of20 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice2Of20 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case3 (f3 (matcher >> (function Choice3Of20 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice3Of20 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case4 (f4 (matcher >> (function Choice4Of20 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice4Of20 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case5 (f5 (matcher >> (function Choice5Of20 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice5Of20 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case6 (f6 (matcher >> (function Choice6Of20 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice6Of20 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case7 (f7 (matcher >> (function Choice7Of20 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice7Of20 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case8 (f8 (matcher >> (function Choice8Of20 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice8Of20 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case9 (f9 (matcher >> (function Choice9Of20 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice9Of20 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case10 (f10 (matcher >> (function Choice10Of20 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice10Of20 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case11 (f11 (matcher >> (function Choice11Of20 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice11Of20 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case12 (f12 (matcher >> (function Choice12Of20 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice12Of20 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case13 (f13 (matcher >> (function Choice13Of20 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice13Of20 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case14 (f14 (matcher >> (function Choice14Of20 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice14Of20 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case15 (f15 (matcher >> (function Choice15Of20 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice15Of20 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case16 (f16 (matcher >> (function Choice16Of20 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice16Of20 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case17 (f17 (matcher >> (function Choice17Of20 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice17Of20 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case18 (f18 (matcher >> (function Choice18Of20 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice18Of20 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case19 (f19 (matcher >> (function Choice19Of20 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice19Of20 x -> Some x | _ -> None) >> Option.map fst))
                Codec.map case20 (f20 (matcher >> (function Choice20Of20 x -> Some x | _ -> None) >> Option.get >> snd) (matcher >> (function Choice20Of20 x -> Some x | _ -> None) >> Option.map fst))
            }
