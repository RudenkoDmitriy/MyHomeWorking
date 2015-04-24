/// 1
let averageOfSinInList list =
    let rec helpFunc list sum number =
        match list with
        |[] -> sum / number
        |h::t -> helpFunc t (sum + sin h) (number + 1.0)
    helpFunc list 0.0 0.0

printfn "%A" << averageOfSinInList <| [1.0; 2.0; 3.0]

