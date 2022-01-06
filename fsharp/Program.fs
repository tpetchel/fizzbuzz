open System

let (|Fizz|_|) n =
    if n % 3 = 0 then Some("Fizz")
    else None

let (|Buzz|_|) n =
    if n % 5 = 0 then Some("Buzz")
    else None

let r = { 1 .. 100 } |> Seq.map (fun i -> 
    match i with 
    | Fizz(s) | Buzz(s) -> s
    | _ -> i.ToString()) |> Seq.toArray
    
printfn $"{String.Join(',', r)}"
