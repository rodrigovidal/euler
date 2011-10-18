module Euler7

let isPrime n = 
    let squareRoot = n |> float |> sqrt |> int64
    { 2L .. squareRoot } |> Seq.forall(fun m -> n % m <> 0L)
let primes = seq {1L .. System.Int64.MaxValue} |> Seq.filter(isPrime)
let result = primes |> Seq.nth 10001
