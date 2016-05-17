module Anagrams = 
    let str0 = "habchdef"
    let str1 = "chbhdefa"
    let str2 = "zhbdxefa"

    let IsAnagram (str:string) (otherStr:string) = Array.sort (str.ToCharArray()) = Array.sort (otherStr.ToCharArray())
    printfn "The result array %b" (IsAnagram str0 str1)
    printfn "The result array %b" (IsAnagram str1 str2)