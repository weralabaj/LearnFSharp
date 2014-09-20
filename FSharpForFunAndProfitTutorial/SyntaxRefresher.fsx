let myInt = 5
let myFloat = 3.24
let myString = "HELLO WERA!"

let twoToFive = [2;3;4;5]
let oneToFive = 1 :: twoToFive
let zeroToFive = [0;1] @ oneToFive

let square x = x * x
square 3

let add x y = x + y
add 1 5

let getEvenElements list =
    let isEven x = x % 2 = 0
    List.filter isEven list
getEvenElements zeroToFive

let sumOfSquaresTo100 =
    List.sum (List.map square [1..100])

let sumOfSquaresTo100piped = 
    [1..100] |> List.map square |> List.sum

let sumOfSquaresTo100pipedWithFun =
    [1..100] |> List.map (fun x -> x * x) |> List.sum

let simplePatternMatch =
    let x = "xyz"
    match x with
        | "a" -> printf "x is a"
        | "b" -> printf "x is b"
        | _ -> printf "x is something else"
        
let optionPatternMatch input =
    match input with
        | Some i -> printf "input is an int=%d" i
        | None -> printf "input is missing"

let validValue = Some(99)
optionPatternMatch validValue
optionPatternMatch None

let twoTuple = 1,2
let threeTuple = "A",2,true

type Temp =
    | DegreesC of float
    | DegreesF of float
let temp = DegreesF 98.6
let temp2 = DegreesC 30.0

type Person = {First:string; Last:string}
type Employee =
    | Worker of Person
    | Manager of Employee list
    
let jdoe = {First="John"; Last="Doe"}
let worker = Worker jdoe

