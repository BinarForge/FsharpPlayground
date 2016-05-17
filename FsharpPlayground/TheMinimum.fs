module TheMinimum = 
    let FindMinimum (arr:List<int>)= 
        let mutable min = arr.[0]
        for i in 1..arr.Length-2 do
            if arr.[i] < min then
                min <- arr.[i]
        min

    let array = [14;5;7;1;18;22;4;5]
    printf "The minimum element of array %A is %A" array (FindMinimum array)