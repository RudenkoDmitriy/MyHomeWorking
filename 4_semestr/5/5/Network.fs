module temp.Network

open System
open Graph

type OS =
    | Windows 
    | Linux 
    | MacOS 

type Computer(Os : OS, infected: bool) =
    let mutable OS = Os
    let mutable infection = infected
    let probability = 
        match Os with
        |Windows -> 15
        |Linux -> 10
        |MacOS -> 20
    member v.Infected with get() = infection
    member v.Os with get() = OS and set(z) = OS <- z 
    member v.CheckInfected(randomizer: System.Random) =
        let result = randomizer.Next(1, 100) <= probability 
        infection <- result
        result
    
type Network(randomizer: System.Random, graph : Graph, arrayOfComputer : Computer list) = 
    do if graph.NumberOfVertex <> arrayOfComputer.Length then raise(IncorrectInputData)
    let mutable infectedComp = List.filter(fun x -> x <> -1) [for x in 0..graph.NumberOfVertex - 1 -> if arrayOfComputer.[x].Infected then x else -1]
    member v.OneTact =
        let mutable newInfect = []
        if infectedComp.IsEmpty then ()
        else for start in infectedComp do 
               for stop in 0..graph.NumberOfVertex - 1 do if graph.CheckEdge(start, stop) && not arrayOfComputer.[stop].Infected
                                                                    then if arrayOfComputer.[stop].CheckInfected(randomizer) then newInfect <- stop :: newInfect
        infectedComp <- infectedComp @ newInfect
                                                                                                                                  
    member v.InfoPrint = [for x in arrayOfComputer -> let nameOfWindow = match x.Os with
                                                                         | Windows -> "Windows"
                                                                         | Linux -> "Linux"
                                                                         | MacOS -> "MacOS"
                                                      (nameOfWindow, x.Infected)]
                                                                                                                                
               
            
        