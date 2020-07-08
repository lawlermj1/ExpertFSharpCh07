// whales.fs 
module Whales
// 3 kinds 
type Whalekind =
    | Blue 
    | Killer
    | GreatWhale 
let moby = "Moby, Dick, Pacific", GreatWhale
let bluey = "Blue, Southern Ocean", Blue
let orca = "orca, Pacific", Killer
let whales = [|moby ; bluey; orca|]
