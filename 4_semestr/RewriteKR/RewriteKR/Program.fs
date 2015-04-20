//1
let supermap list func =
    let rec helpFunc ((list : 'a list), (func : 'a -> 'b list), (acc : 'b list)) =
        match list with
        |[] -> acc
        |h::t -> helpFunc(t, func, acc @ func h)
    helpFunc(list, func, [])

printfn "%A" <| supermap [1; 2; 3] (fun x -> [x;x])

  
    

    