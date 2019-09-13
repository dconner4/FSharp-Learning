module Grains

let square (n: int): Result<uint64,string> = 
    if(List.exists ((=) n) [1..64]) then
        let squared:uint64 = uint64(pown 2UL (n-1))
        Ok squared
    else
        Error "square must be between 1 and 64"

let total: Result<uint64,string> = 
    let sum = List.sumBy(fun n -> 
        match square n with
        | Ok x -> x
        | Error _ -> 0UL) [1..64]
    Ok sum