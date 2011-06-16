module ProjectEuler

let isMultipleOf3Or5 x = x % 3 = 0 || x % 5 = 0

let sumAllMultiplesOf3Or5Ref list = 
    list |> List.filter isMultipleOf3Or5 
         |> List.sum
            
let isMultipleOf3Or5 x = x % 3 = 0 || x % 5 = 0

let sumAllMultiplesOf3Or52 list = List.sum (List.filter isMultipleOf3Or5 list)

let sumAllMultiplesOf3Or5 list = 
    let mutable total = 0
    for i in list do
        if i % 3 = 0 || i % 5 = 0 then
            total <- total + i
    total
         
