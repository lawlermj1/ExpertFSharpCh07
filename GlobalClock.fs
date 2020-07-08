// GlobalClock 
 
module public GlobalClock 

type TickTock = Tick | Tock 
let mutable private clock = Tick 
let private tick = new Event<TickTock>() 
let internal oneTick() = 
        (clock <- match clock with Tick -> Tock | Tock -> Tick)
        tick.Trigger (clock)
let tickEvent = tick.Publish 

let ticker x = 
    match x with 
    | Tick -> Tock 
    | Tock -> Tick 
