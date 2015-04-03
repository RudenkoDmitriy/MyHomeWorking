//1

let sum() =
   let rec helpFunc(i , a, b, s: int) =
       if a > 1000000 then s
                      elif a % 2 = 0 then helpFunc(i + 1, a + b, a, s + a + b)
                                         else helpFunc(i + 1, a + b, a, s)
                                              
   helpFunc(0, 1, 1, 0)

printfn("%A") <| sum()

//2

type Tree =
    | Tip of int
    | Node of int * Tree * Tree

let treeMap func tree =
    let rec recTree (func : int -> bool) tree =
        match tree with
        | Tip x -> if func x then [x] else []
        | Node(x, left, right) -> if func x then [x] @ recTree func left @ recTree func right else recTree func left @ recTree func
    recTree func tree


//3
exception EmptyQueue

type PriorityQueue() =
  let mutable queue = []
  member t.insert(x, y) = 
      queue <- List.sortBy (fun (x, y) -> x) <| queue @ [(x, y)]
      ()
  member t.exact() =
      if queue.IsEmpty then raise(EmptyQueue)
                       else let temp = queue.Head
                            queue <- queue.Tail
                            snd temp

let x = new PriorityQueue()

x.insert(2,3)
x.insert(2,2)
x.insert(0,1)
x.insert(1,4)

let t = [x.exact(); x.exact(); x.exact(); x.exact(); ]

printfn("%A") <| t
