open System.ComponentModel
open System.Threading


let array = Array.create 1000000 1

let mutable res = 0

let threadList = [for i in 0..99 -> new BackgroundWorker()]

for i in 0..99 do
    threadList.[i].DoWork.Add(fun _ -> res <- (res + Array.sum array.[i * 10000..(i + 1)* 10000 - 1]))
    threadList.[i].RunWorkerAsync()

printfn "%A" res