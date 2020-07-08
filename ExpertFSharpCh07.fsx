//  ExpertFSharpCh07.fsx

module public VisitorCredentials = 
    let private visitorTable = 
        dict [("Anna", set [DayOfWeek.Tuesday; DayOfWeek.Wednesday]); 
        ("Carolyn", set[DayOfWeek.Friday])]
    let public checkVisitor(person) = 
        visitorTable.ContainsKey(person) && 
        visitorTable.[person].Contains(DateTime.Today.DayOfWeek)
    let internal allKnownVisitors() = 
        visitorTable.Keys 




