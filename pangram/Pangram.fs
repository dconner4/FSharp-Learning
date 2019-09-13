module Pangram

let isPangram (input: string): bool = 
    input.ToUpper() 
    |> Seq.filter(fun x -> Seq.exists((=) x) ['A'..'Z'])
    |> fun x -> ['A'..'Z'] |> Seq.forall(fun y -> Seq.exists((=) y) x)