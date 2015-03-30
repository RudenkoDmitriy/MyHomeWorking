module temp.Graph

exception IncorrectInputData

type Graph(numberOfVertex:int) = 
    let Matrix = Array2D.create numberOfVertex numberOfVertex false
    member v.NumberOfVertex  = numberOfVertex
    member v.CreateEdge(firstVertex : int, secondVertex : int) =
        if firstVertex >= numberOfVertex || secondVertex >= numberOfVertex || firstVertex < 0 || secondVertex < 0
          then raise(IncorrectInputData)
          else Matrix.[firstVertex, secondVertex] <- true 
               Matrix.[secondVertex, firstVertex] <- true
        ()
    member v.CheckEdge(firstVertex : int, secondVertex : int) =
        if firstVertex >= numberOfVertex || secondVertex >= numberOfVertex || firstVertex < 0 || secondVertex < 0
          then raise(IncorrectInputData)
          else Matrix.[firstVertex, secondVertex]


