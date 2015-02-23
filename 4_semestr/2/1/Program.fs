///1. Reverse of list
let reverse list = 
   let rec recReverse list acc =
       match list with
       | h :: t -> recReverse t (h :: acc)
       | [] -> acc
   recReverse list []

///2. List of degrees.
let degrees startDegree = [ for x in startDegree..startDegree + 4 -> 2.0 ** float(x) ]

///3. Product of numbers in number.
let rec productOfNumbers number =
    if number = 0  then 1
    else number % 10 * productOfNumbers (number / 10)

///4. Find first position of number in list.
let firstPosition list number  = 
    let rec recFirst list number acc =
        match list with
        | h :: t -> if h = number then acc else recFirst t number acc + 1
        | [] -> -1
    recFirst list number 0

///5. Is string palindrom?
let rec isPalindrom string =
    if string = "" then true
    elif string.Length = 1 then true
    elif string.[0] = string.[string.Length - 1] then isPalindrom(string.[1..string.Length - 2])
    else false
    
//let res = reverse [ 1; 2; 3 ]
//let res1 = degrees 5
//let res2 = productOfNumbers 12345
//let res3 = firstPosition [0;2;2;3;1;5] 1
//let res4 = isPalindrom "shabahs s"
//
//
//printfn "%A" res3