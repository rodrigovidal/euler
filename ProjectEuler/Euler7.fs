module Euler7

open System

let sieveOfEratosthenes n = 
    let arr = [| for i in 0..n -> 1 |]
    let sqrt = sqrt(float n) |> int
    for k = 2 to sqrt + 1 do
        if arr.[k] = 1 then
            for j in 2*k..k..n-1 do
                arr.[j] <- 0
    seq { for i in 2..n-1 do if arr.[i] = 1 then yield i }

let primes = sieveOfEratosthenes 500000

let result = primes  |> Seq.nth 10000 

printfn "%d" result