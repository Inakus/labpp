//zad 1.1
let PKola r: float =
    System.Math.PI * r ** 2.0

printfn "Pole kola wynosi %f" (PKola 6.0)

//zad 1.2
let Pierwiastek (a:float) (b:float) (c: float) = 
    let delta: float  = b * b - 4.0 * a * c in
        if delta > 0 then
            let x1 = (-b - sqrt(delta))/(2.0 * a)
            let x2 = (b - sqrt(delta))/(2.0 * a)
            printfn "x1 = %f, x2 = %f" x1 x2
        else
            if delta = 0.0 then
                let x0 = -b / (2.0 * a)
                printf "x0 = %f" x0
            else
                printfn "Brak"

Pierwiastek 5.0 8.0 2.0

//zad 1.3
let trojkat (a:int) (b:int) (c: int) = 
    if a + b <= c && a + c <= b && b + c <= a then
        printfn "nie mozna stworzyc trojkata"
    else
        printfn "mozna stworzyc trojkat"

trojkat 3 1 1

//zad 1.4
let poleT (a: float) (b: float) (c: float) = 
    if a + b <= c && a + c <= b && b + c <= a then
        printfn "nie mozna stworzyc trojkata"
    else 
        printfn "P = %f" ((a*b) / 2.0)

poleT 5 3 9

//zad 1.5
let rec SumaLiczbNaturalnych (n: int) akumulator = 
    if n > 0 then
        SumaLiczbNaturalnych(n-1) (akumulator + n)
    else
        akumulator

printfn "%d" (SumaLiczbNaturalnych 2 0)

//zad 1.6
let rec SumaPoteg (x:int) (n: int) akumulator = 
    if n > 0 then
        SumaPoteg(x) (n-1) (akumulator + pown x n)
    else
        akumulator

printfn "%d" (SumaPoteg 2 2 0)

//zad 1.7
let rec Fib (n: int)  =
    if n = 0 then 
        0
    elif n = 1 then
        1
    else
        Fib(n-1) + Fib (n-2)
    
printfn "%d" (Fib 5)

//zad 1.8
let rec Dwumian (n: int) (k: int) =
    if k = 0 || k = n then 1
    else Dwumian (n - 1) (k - 1) * n / k

printfn "%d" (Dwumian 5 2)

//zad 1.9
let rec Pierwsza n =
    let rec CzyPierwsza n k =
        if k * k > n then true
        elif n % k = 0 then false
        else CzyPierwsza n (k + 2)
    if n <= 1 then false
    elif n = 2 || n = 3 then true
    elif n % 2 = 0 then false
    else CzyPierwsza n 3

printfn "%b" (Pierwsza 6)

//zad 1.15
[<Measure>] type C 
[<Measure>] type F

let celsiusToFahrenheit (celsius: float<C>): float<F> =
    (celsius * 9.0/5.0) + 32.0<F>

printfn "%f" (FahNaCel 32.0<C>)

let fahrenheitToCelsius (fahrenheit: float<F>) : float<C> =
    (fahrenheit - 32.0<F>) * 5.0/9.0<C>