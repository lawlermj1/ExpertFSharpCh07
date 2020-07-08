// IStatistic

module IStatistic 

type IStatistic<'T,'U> = 
    abstract Record : 'T -> unit 
    abstract Value : 'U 

let makeAverage(toFloat : 'T -> float) = 
    let mutable count = 0 
    let mutable total = 0.0 
    { new IStatistic<'T, float> with 
        member __.Record(x) =
            count <- count + 1
            total <- total + toFloat x 
        member __.Value = 
            total / float count  } 

