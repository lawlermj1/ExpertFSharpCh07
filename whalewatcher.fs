// whalewatcher.fs

open Dolphins 
open Whales
open System

let idx = Int32.Parse(Environment.GetCommandLineArgs().[1])
let spotted = whales.[idx]

let spot2 = dolphins.[idx] 

printfn "You spotted %A and %A!" spotted  spot2 
