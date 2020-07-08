// TickTockDriver 

module internal TickTockDriver  

open GlobalClock 
open System.Threading 

    let timer = new Timer (callback = (fun _ -> GlobalClock.oneTick()), state = null , dueTime = 0, period = 100)

//    let tickTockListener =  
//        GlobalClock.tickEvent.Add(function
//            | GlobalClock.Tick -> printfn "tick!"
//            | GlobalClock.Tock -> printfn "tock!" )
