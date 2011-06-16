module Tests
open NUnit.Framework
open FsxUnit
open ProjectEuler

type ``Project Euler 1 Tests``() = 
    [<Test>] member test.
        ``Given a empty list sum all members should be equal 0``() =
            [] |> sumAllMultiplesOf3Or5 |> should be (equal 0)
    [<Test>] member test.
        ``Given a list with 1 sum all members should be equal 0``() =
            [1] |> sumAllMultiplesOf3Or5 |> should be (equal 0)

    [<Test>] member test.
        ``Given a list with 2 sum all members should be equal 0``() =
            [2] |> sumAllMultiplesOf3Or5 |> should be (equal 0)
    
    [<Test>] member test.
        ``Given a list with 3 sum all members should be equal 3``() =
            [3] |> sumAllMultiplesOf3Or5 |> should be (equal 3)
    
    [<Test>] member test.
        ``Given a list with 4 sum all members should be equal 0``() =
            [4] |> sumAllMultiplesOf3Or5 |> should be (equal 0)

    [<Test>] member test.
        ``Given a list with 5 sum all members should be equal 5``() =
            [5] |> sumAllMultiplesOf3Or5 |> should be (equal 5)

    [<Test>] member test.
        ``Given a list with 1,2,3 sum all members``() =
            [1;2;3] |> sumAllMultiplesOf3Or5 |> should be (equal 3)

    [<Test>] member test.
        ``Given a list with 1,2,3,4,5 sum all members``() =
            [1;2;3;4;5] |> sumAllMultiplesOf3Or5 |> should be (equal 8)

    [<Test>] member test.
        ``Given a list with 1,2,3,4,5,6 sum all members``() =
            [1;2;3;4;5;6] |> sumAllMultiplesOf3Or5 |> should be (equal 14)

    [<Test>] member test.
        ``Given a list with 1,2,3,4,5,6,7,8,9,10 sum all members``() =
            [1;2;3;4;5;6;7;8;9;10] |> sumAllMultiplesOf3Or5 |> should be (equal 33)

    [<Test>] member test.
        ``Given a list with [1..999] sum all members``() =
            [1..999] |> sumAllMultiplesOf3Or5 |> should be (equal 233168)
