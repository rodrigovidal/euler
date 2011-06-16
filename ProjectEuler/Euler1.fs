module ProjectEuler

let isMultipleOf3Or5 x = x % 3 = 0 || x % 5 = 0

let sumAllMultiplesOf3Or5 list = 
    list |> List.filter isMultipleOf3Or5 
         |> List.sum
            
