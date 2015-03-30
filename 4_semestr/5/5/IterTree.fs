module temp.IterTree

open System.Collections.Generic
open System.Collections

type Dtree<'a> =
   | Null
   | Tip of 'a
   | Node of 'a * Dtree<'a> * Dtree<'a>

type Enumerator<'a>(tree : Dtree<'a>) =
   let rec createSearch tree =
       match tree with
       | Null -> []
       | Tip v -> [v]
       | Node(v, l, r) -> createSearch(l) @ [v] @ createSearch(r)
   let mutable treeInList = createSearch tree
   let mutable current = None
   interface IEnumerator with
       member t.MoveNext() =
           match treeInList with
           | [] -> false
           | _ -> current <- Some(treeInList.Head)
                  treeInList <- treeInList.Tail
                  true 
       member t.Current with get() = current.Value :> obj
       member t.Reset() = treeInList <- createSearch tree
   interface IEnumerator<'a> with
       member t.Dispose() = ()
       member t.get_Current() = treeInList.Head

type Btree() =
   let mutable tree = Null
   member t.Add(v : 'a) =
       let rec recAdd(v : 'a, tree : Dtree<'a>) =
           match tree with
           | Null -> Tip(v)
           | Tip x -> if v > x then Node(x, Null, Tip(v))
                               else Node(x, Tip(v), Null)
           | Node(x, l, r) -> if v > x then Node(x, l, recAdd(v, r)) else Node(x, recAdd(v, l), r)
       tree <- recAdd(v, tree)
   interface IEnumerable with
      member t.GetEnumerator() = new Enumerator<'a>(tree) :> IEnumerator
       
      
  