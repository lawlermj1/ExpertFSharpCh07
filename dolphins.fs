//  dolphins.fs 
module Dolphins 

type Dolphinkind =
    | LongBeaked 
    | ShortBeaked

let longBeaked = "Delphinus capensis", LongBeaked
let shortBeaked = "Delphinus delphis", ShortBeaked
let dolphins = [| longBeaked ; shortBeaked |]
//  printfn "Known Dolphins: %A" dolphins 
