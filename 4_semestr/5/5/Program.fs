open temp.Network
open temp.Graph
open temp.IterTree
 
let graph = new Graph(4)
graph.CreateEdge(0, 1)
graph.CreateEdge(0, 2)
graph.CreateEdge(0, 3)

let arrayOfComputer = [new Computer(Windows, true); new Computer(Linux, false); new Computer(MacOS, false); new Computer(MacOS, false)]

let network = new Network(new System.Random(100), graph, arrayOfComputer)

let rec result() =
    let x = System.Console.ReadLine()
    match x with
    |"0" -> ()
    |_ -> printfn("%A") <| network.InfoPrint
          network.OneTact
          result()
    
//result()

let tree = new Btree()
tree.Add(1)
tree.Add(2)
tree.Add(0)

let x = [for x in tree -> x]

printfn("%A") <| x