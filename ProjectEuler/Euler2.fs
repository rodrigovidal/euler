module Euler2

let fibonacci =
    (0, 1) 
    |> Seq.unfold(fun (current, next) -> Some(current, (next, current + next)))
    |> Seq.takeWhile(fun x -> x <= 4000000)
    |> Seq.filter(fun x -> x % 2 = 0)
    |> Seq.sum
