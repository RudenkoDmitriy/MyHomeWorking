open System
open System.IO
open System.Runtime.Serialization.Formatters.Binary

/// 1
let isTrueExpr str =
    let rec recIsTrueExpr (str:string, stack) =
        if str.Length = 0 then true
            else  match str.[0] with
                  | '[' -> recIsTrueExpr(str.[1..str.Length - 1], '['::stack)
                  | '{' -> recIsTrueExpr(str.[1..str.Length - 1], '{'::stack)
                  | '(' -> recIsTrueExpr(str.[1..str.Length - 1], '('::stack)
                  | ']' -> if not stack.IsEmpty && stack.Head = '[' then recIsTrueExpr(str.[1..str.Length - 1], stack.Tail)
                                                                    else false
                  | '}' -> if not stack.IsEmpty && stack.Head = '{' then recIsTrueExpr(str.[1..str.Length - 1], stack.Tail)
                                                                    else false
                  | ')' -> if not stack.IsEmpty && stack.Head = '(' then recIsTrueExpr(str.[1..str.Length - 1], stack.Tail)
                                                                    else false
                  | _ -> recIsTrueExpr(str.[0..str.Length - 2], stack)
    recIsTrueExpr (str, [])

/// 2
//let func x l = List.map(fun y -> y * x) l
//let func x = List.map(fun y -> (*) x y)
//let func x = List.map((*) x)
//let func x = List.map <| (*) x
let func = List.map << (*) 

/// 3
let telBook =
    let rec recHelpFunc (result : (string * string) list) =
        let x = System.Console.ReadLine()
        match x with
        | "0" -> ()
        | "1" -> printfn "Enter name and number"
                 recHelpFunc ((System.Console.ReadLine(), System.Console.ReadLine())::result)
        | "2" -> printfn "Enter name"
                 let name = System.Console.ReadLine()
                 (List.find(fun (a, b) -> a = name) >> snd >> printfn("%A")) result
                 recHelpFunc result
        | "3" -> printfn "Enter number"
                 let number = System.Console.ReadLine()
                 (List.find(fun (a, b) -> b = number) >> fst >> printfn("%A")) result
                 recHelpFunc result
        | "4" -> let fsOut = new FileStream("Data.dat", FileMode.Create)
                 let formatter = new BinaryFormatter()
                 formatter.Serialize(fsOut, box result)
                 recHelpFunc result
        | "5" -> let fsIn = new FileStream("Data.dat", FileMode.Open)
                 let formatter = new BinaryFormatter()
                 let res = formatter.Deserialize(fsIn) |> unbox<(string * string) list>
                 recHelpFunc(res @ result)  
        | _ -> printfn "Incorrect command"
               recHelpFunc result
    recHelpFunc []


/// 4
type Expression =
    | X
    | Const of int
    | Operand of char * Expression * Expression

exception SymbolError of string
exception DivideByZERRO
     
let derivative expr =
    let simplific expr = 
        match expr with
        | X -> X
        | Const x -> Const x
        | Operand('*', Const(1), right) -> right 
        | Operand('*', left, Const(1)) -> left
        | Operand('*', Const(0), right) -> Const(0)
        | Operand('*', left, Const(0)) -> Const(0)
        | Operand('*', Const x, Const y) -> Const(x * y)
        | Operand('+', Operand('*', Const x, X), Operand('*', Const y, X)) -> Operand('*', Const(x + y), X)
        | Operand('+', Const(0), right) -> right
        | Operand('+', left, Const(0)) | Operand('-', left, Const(0))-> left 
        | Operand('-', Operand('*', Const x, X), Operand('*', Const y, X)) -> Operand('*', Const(x - y), X)
        | _ -> expr

    let rec recDerivative expr : Expression =
        let unionFunc = simplific << recDerivative
        match expr with
        | Const x -> Const(0)
        | X -> Const(1)
        | Operand(op, left, right) -> match op with
                                      | '*' -> simplific <| Operand('+', simplific <| Operand('*', unionFunc left, right), 
                                                            simplific <| Operand('*', left, unionFunc right))
                                      | '/' -> if right = Const(0) then raise(DivideByZERRO) 
                                               simplific <| Operand('/', simplific <| Operand('-', simplific <| Operand('*', unionFunc left, right), 
                                                                         simplific <| Operand('*', left, unionFunc right)),
                                                            simplific <| Operand('*', right, right))
                                      | '+' -> simplific <| Operand('+', recDerivative left, unionFunc right)
                                      | '-' -> simplific <| Operand('-', recDerivative left, unionFunc right)
                                      | _ -> raise(SymbolError("Check your expression")) 
    recDerivative expr

/// 5
type Tree =
    | Tip of int
    | Node of int * Tree * Tree

let treeMap func tree =
    let rec recTreeMap (func : int -> int) tree =
        match tree with
        | Tip x -> Tip(func x)
        | Node(x, left, right) -> Node(func x, recTreeMap func left, recTreeMap func right)
    recTreeMap func tree