module HighScores

let scores (values: int list): int list = values

let latest (values: int list): int = Seq.last(values)

let personalBest (values: int list): int = 
    Seq.sortDescending(values)
    |> Seq.head

let personalTopThree (values: int list): int list = 
    match values.Length with
    | 1 -> values
    | 2 -> Seq.sortDescending(values) |> Seq.toList
    | _ ->
        Seq.sortDescending(values)
        |> Seq.take(3)
        |> Seq.toList
