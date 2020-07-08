// PeekPoke.fs

// open System 

module PeekPoke

type IPeekPoke = 
    abstract member Peek : unit -> int 
    abstract member Poke : int -> unit

let makeCounter initialState = 
    let mutable state = initialState 
    {new IPeekPoke with 
        member x.Poke n = state <- state + n 
        member x.Peek() = state }

