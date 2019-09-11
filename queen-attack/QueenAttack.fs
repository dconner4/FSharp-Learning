module QueenAttack
open System
let create ((posX, posY): int * int): bool = 
    (posX >= 0 && posY >= 0) && (posX < 8 && posY < 8) 


let canAttack ((queen1X, queen1Y): int * int) ((queen2X, queen2Y): int * int): bool = 
    queen1X = queen2X || queen1Y = queen2Y || Math.Abs(queen1X - queen2X) = Math.Abs(queen1Y - queen2Y)