module Euler1

let sumAllMultiplesOf3Or5Fun list = 
    list |> List.filter (fun x -> x % 3 = 0 || x % 5 = 0)
         |> List.sum
            
let sumAllMultiplesOf3Or5 list = 
    let mutable total = 0
    for i in list do
        if i % 3 = 0 || i % 5 = 0 then
            total <- total + i
    total
