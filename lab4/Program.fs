type Lista<'a> = 
    | Pusta 
    | Element of 'a * Lista<'a>

let glowa =
    function 
    | Pusta -> failwith "Nie mozna pobrac glowy z listy pustej"
    | Element (glowa, _) ->  glowa

let ogon = 
    function
    | Pusta -> failwith "Nie mozna pobrac ogona z listy pustej"
    | Element (_,ogon) -> ogon

// let rec suma wynik =
//     function
//     | Pusta -> wynik
//     | Element (x, ogon) -> suma (wynik + x) ogon

// let rec iloczyn wynik =
//     function
//     | Pusta -> wynik
//     | Element (x, ogon) -> iloczyn (wynik * x) ogon
let lista1 = Element(1 ,Element(2,Element(3,Element(4,Element(5,Element(6,Pusta))))))

let rec dodaj2 = 
    function
    | Pusta -> Pusta
    | Element(glowa,ogon) -> Element(glowa+2, dodaj2 ogon)

let rec dodajn n = 
    function
    | Pusta -> Pusta
    | Element(glowa,ogon) -> Element(glowa+n, dodajn n ogon)

let rec razy2 =
    function
    | Pusta -> Pusta
    | Element(glowa,ogon) -> Element(glowa*2, razy2 ogon)

let rec mapuj algorytm = 
    function
    | Pusta -> Pusta
    | Element(glowa,ogon) -> Element(algorytm glowa, mapuj algorytm ogon)

let zwiekszO2 x = x + 2
let zwiekszRazy2 x = x * 2

let rec filtruj predykat = 
    function
    | Pusta -> Pusta
    | Element(glowa, ogon) -> 
        if predykat glowa then
            Element(glowa, filtruj predykat ogon)
        else
            filtruj predykat ogon

let podzielnePrzez2 x = x % 2 = 0

filtruj podzielnePrzez2 lista1
filtruj (fun x-> x>2) lista1
