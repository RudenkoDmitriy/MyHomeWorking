let rec fact n = 
  if n = 0 then 1
  else n * fact (n - 1)

let rec fib n = 
  if n = 1 then 0
  elif n < 3 then 1
  else fib (n - 1) + fib (n - 2)

let x = fib 4

let y = fact 10

printfn "%A" x

printfn "%A" y


