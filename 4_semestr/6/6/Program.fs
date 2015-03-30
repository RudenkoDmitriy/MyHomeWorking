type rounding(x : int) =
    member t.Bind ((y : float), (rest: float -> float)) = rest <| System.Math.Round(y, x)
    member t.Return(y : float) = System.Math.Round(y, x)

let x = rounding 3 {
        let! a = 2.0 / 12.0
        let! b = 3.5
        return a / b
    }
