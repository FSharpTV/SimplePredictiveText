module Tests
open FsUnit
open NUnit.Framework
open FSharp.TV.PredictiveText

let dictionary = LoadDict()

[<Test>]
let shouldLoadUsDict() =
    dictionary |> should not' (be Empty)

[<Test>]
let shouldNotContainTheWordFSharp() =
    dictionary |> should not' (contain "fsharp")

[<Test>]
let shouldContainOnlyOneCandidateForAardvarks() =
    let result = Autocomplete "aardvarks" dictionary
    result |> Array.length |> should equal 1

[<Test>]
let shouldContainElevenCandidatesForTreasu() =
    let result = Autocomplete "treasu" dictionary
    result |> Array.length |> should equal 11

[<Test>]
let shouldContainTenCandidatesForManuf() =
    let result = Autocomplete "manuf" dictionary
    result |> Array.length |> should equal 10