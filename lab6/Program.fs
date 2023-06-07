open System

let generator = new Random()

let cwiartki punkt =
    match punkt with
    | (x,y) when  x>=0 && y>=0 -> 1
    | (x,y) when  x<0 && y>=0 -> 2
    | (x,y) when  x<0 && y<0 -> 3
    | _ -> 4

fun _ -> (generator.Next(-20,20), generator.Next(-20,20))
|> List.init 100
|> List.groupBy cwiartki 
|> List.map (fun (cwiartki, punkt) -> (cwiartki, List.length punkt))
|> List.sortBy fst
|> List.iter (fun (cwiartki, lPunktow) -> printfn "%d %d" cwiartki lPunktow)


type Rozwiazanie =
| Brak
| Jedno of float
| Dwa of float * float

let rownanie (a,  b, c) =
    let delta = (b * b) - 4.0 * a * c
    if delta > 0 then
        let x1 = (-b - sqrt(delta))/(2.0 * a)
        let x2 = (b - sqrt(delta))/(2.0 * a)
        Dwa(x1, x2)
    else
            if delta = 0 then
                let x0 = -b / (2.0 * a)
                Jedno(x0)
            else
                Brak

open System.IO

let naParametry (linijka: string) = 
    linijka.Split(" ") 
    |> Array.toList 
    |> List.map float
    |> (fun lista -> (lista[0], lista[1], lista[2]))

File.ReadAllLines("zad8.txt")
|> Array.toList
|> List.map naParametry
|> List.map rownanie
|> List.iter (printfn "%A")

File.ReadLines("zad8.txt")
|> Seq.map naParametry
|> Seq.map rownanie
// |> Seq.iter (printfn "%A")