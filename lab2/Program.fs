//zad 2.3
let PoleIObwodTrójkata a b c = 
    let Obwod = a + b + c in
        let p = 0.5 * Obwod in
            let Pole = sqrt(p * (p-a) * (p-b) * (p-c))
            (Obwod, Pole)

let wynik = PoleIObwodTrójkata 4.0 3.0 2.0
printfn "pole trojkata to: %f, a obwod to: %f" (snd wynik) (fst wynik)

type PoleIObwod = {
    pole: float
    obwod: float
}

let poleIObwodRecord a b c = 
    let Obwod = a + b + c in
        let p = 0.5 * Obwod in
            let Pole = sqrt(p * (p-a) * (p-b) * (p-c))
            {PoleIObwod.pole = Pole; obwod = Obwod}

let wynikRekord = poleIObwodRecord 4 2 3
printfn "pole trojkata to: %f, a obwod to: %f" wynikRekord.pole wynikRekord.obwod

//zad 2.7

let Sprawdz ((x_o, y_o), r) (x_p, y_p) =
    let odleglosc = sqrt((x_o - x_p) ** 2.0 + (y_o - y_p) ** 2.0)
    odleglosc < r

Sprawdz ((1.,0.), 5.) (1.,2.)

//2.11

type TypWyniku =
| Poprawne = 1
| Bledny = 2

let Dzielenie a b =
    if b<>0 then
       (a/b, TypWyniku.Poprawne)
    else 
        (0, TypWyniku.Bledny)

let (wynikDzielenia, flaga) = Dzielenie 2 0

if flaga = TypWyniku.Poprawne then 
    printfn "%d" wynikDzielenia
else
    printfn "Nie mozna dzielic przez 0"

type Wynik =
| Poprawny of int
| Bledny

let Dzielenie1 a b =
    if b<>0 then
        Poprawny (a/b)
    else 
        Bledny
let wynikUnia = Dzielenie1 2 1
match wynikUnia with
| Poprawny x -> printfn "%d" x
| Bledny -> printfn "Nie mozna dzielic przez 0"