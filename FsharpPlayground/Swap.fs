module Swapper = 
    let array = [1;14;5;7;18;22;4;5]

    let Swap (arr:list<int>) (i:int) (j:int) =
        [
            for idx in 0..arr.Length-1 do
                if idx = i then
                    yield arr.[j]
                elif idx = j then
                    yield arr.[i]
                else
                    yield arr.[idx]
        ]

    let newArray = Swap array 0 1

    printfn "Initial array looks like this %A" array
    printfn " newArray now looks like this %A" newArray