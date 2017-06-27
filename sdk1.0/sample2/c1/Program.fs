// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    csl1.Say.Hello "F#!"
    csl1.Say.JsonStuff()
    0 // return an integer exit code
