open FSharp.TV.PredictiveText
[<EntryPoint>]
let main argv = 
    let candidates = Autocomplete "aa" (LoadDict())
    for candidate in candidates do printfn "%A" candidate
    0 // return an integer exit code

