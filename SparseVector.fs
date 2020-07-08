// SparseVector 

module SparseVector 

open System.Collections.Generic

type public SparseVector () = 
    let elems = new SortedDictionary<int, float>()
    member internal vec.Add (k,v) = elems.Add(k,v) 
    member public vec.Count = elems.Keys.Count
    member vec.Item 
        with public get i = 
            if elems.ContainsKey(i) then elems.[i]
            else 0.0 
        and internal set i v = 
            elems.[i] <- v 

