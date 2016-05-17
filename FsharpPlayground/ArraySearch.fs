module ArraySearch =
    let array = [1;14;5;7;18;22;4;5]
    printfn "Array length = %A" array.Length

    let Find (arr:list<int>) (needle:int) = [
            for i in 0..arr.Length-1 do
                if arr.[i] = needle then
                    yield i ]

    let result = Find array 5
    printfn "Array search result = %A" (result)