module FSharp.TV.PredictiveText

open System.IO
open System

let private usDic = Path.Combine(__SOURCE_DIRECTORY__, "dict.txt")

///Allows you to load your own dictionary of data.
let LoadDictFromPath path =
    File.ReadAllLines path

///Loads the default dictionary of US words, 100000 in total
let LoadDict () =
    let dict = LoadDictFromPath usDic
    dict

///This function will find the words that start with the given prefix
let Autocomplete (prefix:string) (dict:string[]) =
    let candidates = dict |> Array.filter (fun word -> word.StartsWith prefix)
    candidates
