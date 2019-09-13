module Hamming
open System
let distance (strand1: string) (strand2: string): int option =
    match (strand1.Length, strand2.Length) with
    | (s1, s2) when (s1 <> s2) -> None
    | (_,_) ->
        (strand1, strand2)
        ||> Seq.map2(fun y z -> if y <> z then 1 else 0)
        |> Seq.sum
        |> Some