module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let isEven x = x % 2L = 0L

let collatz n =
  let rec iter n step = 
    let n = int64 n
    if n = 1L then step
    elif isEven n then iter (n/2L) (step+1)
    else iter (3L*n + 1L) (step + 1)
  iter n 0
