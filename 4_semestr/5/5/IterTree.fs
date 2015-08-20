module temp.IterTree

open System.Collections.Generic
open System.Collections

type Dtree<'a> =
   | Empty
   | Tip of 'a
   | Node of 'a * Dtree<'a> * Dtree<'a>

type Enumerator<'a>(tree : Dtree<'a>) =
   let rec createSearch tree =
       match tree with
       | Empty -> []
       | Tip v -> [Some(v)]
       | Node(v, l, r) -> createSearch(l) @ [Some(v)] @ createSearch(r)
   let mutable treeInList = None :: createSearch tree
   interface IEnumerator with
       member t.MoveNext() =
           treeInList <- treeInList.Tail
           match treeInList with
           | [] -> false
           | _ ->  true 
       member t.Current with get() = treeInList.Head :> obj
       member t.Reset() = treeInList <- createSearch tree
   interface IEnumerator<'a> with
       member t.Dispose() = ()
       member t.Current with get() = match treeInList.Head with
                                     | Some(x) -> x
                                     | None -> failwith "Invalid error"

type Btree<'a when 'a : comparison and 'a : equality>() =
   let mutable tree = Empty
   member t.Add(v : 'a) =
       let rec recAdd(v : 'a, tree : Dtree<'a>) =
           match tree with
           | Empty -> Tip(v)
           | Tip x -> if v > x then Node(x, Empty, Tip(v))
                      elif v < x then Node(x, Tip(v), Empty)
                                 else Tip x
           | Node(x, l, r) -> if v > x then Node(x, l, recAdd(v, r)) 
                              elif v < x then Node(x, recAdd(v, l), r)
                                         else Node(x, l, r)
       tree <- recAdd(v, tree)
   member t.Check(v : 'a) =
       let rec recCheck(v : 'a, tree : Dtree<'a>) =
           match tree with
           | Empty -> false
           | Tip x -> x = v
           | Node(x, l, r) -> if x = v then true
                               elif v < x then recCheck(v, l)
                                          else recCheck(v, r)
       recCheck(v, tree)
   member t.Delete(v : 'a) =
       let rec minimum(tree : Dtree<'a>) = 
           match tree with
           | Empty -> failwith "Tree is empty"
           | Tip x -> x
           | Node(x, l, r) -> minimum(l)
       let rec recDel(v : 'a, tree : Dtree<'a>) =
           match tree with
           | Empty -> Empty
           | Tip x -> if x = v then Empty
                               else Tip x
           | Node (x, l, r) -> if v > x then Node(x, l, recDel(v, r))
                               elif v < x then Node(x, recDel(v, l), r)
                               elif l = Empty && r = Empty then Empty
                               elif l = Empty then r
                               elif r = Empty then l
                                              else let temp = minimum(r)
                                                   Node(temp, l, recDel(temp, r))
                               
       tree <- recDel(v, tree)
   interface IEnumerable with
       member t.GetEnumerator() = new Enumerator<'a>(tree) :> IEnumerator
   interface IEnumerable<'a> with
       member t.GetEnumerator() = new Enumerator<'a>(tree) :> IEnumerator<'a>
       
      
  
