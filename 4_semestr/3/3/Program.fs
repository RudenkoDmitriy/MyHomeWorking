///1
let maxPos list =
   let rec recMaxPos (prev, list, max, pos, i) =
       match list with
       | [] -> pos
       | [_] -> if prev > max then pos + 1
                              else pos
       | h1::h2::t -> if prev + h2 > max then recMaxPos(h1, h2::t, prev + h2, i, i + 1)
                                         else recMaxPos(h1, h2::t, max, pos, i + 1)
   recMaxPos(0, list, 0, 0, 1)

///2
let diff list  = 
    let rec recDiff (acc, list) = 
        match list with
        | [] -> true
        | h1::t -> t |> List.forall(fun i -> h1 <> i) && acc |> List.forall(fun i -> h1 <> i) && recDiff(h1::acc, t)
    recDiff([], list)

///3
let firstEven list = List.length list - List.fold(fun acc x -> acc + x % 2) 0 list

let secondEven list = list |> List.filter(fun x -> x % 2 = 0) |> List.length

let thirdEven list = List.length list - (list |> List.map(fun x -> x % 2) |> List.sum)

///4
type Tree<'a> =
    | Tip of 'a
    | Node of 'a * Tree<'a> * Tree<'a>
    
let hight (tree:Tree<int>) =
   let rec recHight (tree:Tree<int>) =
       match tree with
       | Tip _ -> 1
       | Node (x, left, right) -> (recHight(right) |> max(recHight(left))) + 1
   recHight tree

///5
type ArTree =
    | Tip of int
    | OpNode of string * ArTree * ArTree


let result (tree:ArTree) =
  let rec recResult (tree:ArTree) =
      match tree with
      | Tip x -> x
      | OpNode (op, left, right) -> match op with
                                  | "+" -> recResult(left) + recResult(right)
                                  | "-" -> recResult(left) - recResult(right)
                                  | "*" -> recResult(left) * recResult(right)
                                  | "/" -> recResult(left) / recResult(right)
  recResult tree

//6
let emptyNumb =
    let isEmpty numb = if numb <= 0 then false else List.forall(fun x -> numb % x <> 0) [2..numb - 1] 
    Seq.initInfinite(fun index -> index) |> Seq.filter(fun x -> isEmpty x)


//let res1 = max [1; 5; 6; 2]
//let res2 = diff [1; 5; 6; 2; 2]
//let res3 = third [1; 5; 6; 2; 2]
//let res4 = result (OpNode("*", Tip(3), OpNode("/", Tip(8), Tip(4))))
//
//printfn "%A" emptyNumb