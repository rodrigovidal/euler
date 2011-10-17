module ProjectEuler

<<<<<<< HEAD
let sumAllMultiplesOf3Or5Fun list = 
    list |> List.filter (fun x -> x % 3 = 0 || x % 5 = 0)
         |> List.sum
            
let sumAllMultiplesOf3Or5 list = 
    let mutable total = 0
    for i in list do
        if i % 3 = 0 || i % 5 = 0 then
            total <- total + i
    total
         
=======
let isMultipleOf3Or5 x = x % 3 = 0 || x % 5 = 0

let sumAllMultiplesOf3Or5 list = 
    list |> List.filter isMultipleOf3Or5 
         |> List.sum
            
>>>>>>> 85eb776e9c133800675ea24e13be5f247514fb7d
