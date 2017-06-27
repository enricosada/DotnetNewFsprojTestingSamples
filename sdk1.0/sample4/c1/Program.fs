// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    l1.Say.hello "F#!"
    l1.Say.jsonstuff()

    l2.Say2.hello "F#!"
    l2.Say2.jsonstuff()

    0 // return an integer exit code
