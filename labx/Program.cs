// Func<double, double, double> funkcja1 = (a,b) => a/b;
// var x1 = 10;
// var x2 = 2;

// Func<Tp2, Tp1, Tz> Odwroc<Tp1,Tp2,Tz>(Func<Tp1, Tp2, Tz> funkcja){
//     return (b,a) => funkcja(a,b);
// }

// var wynik1 = funkcja1(x1,x2);
// var funkcja2 = Odwroc(funkcja1);
// var wynik2 = funkcja2(x2,x1);
// if(wynik1 == wynik2)
//     Console.WriteLine("OK");
// else
//     Console.WriteLine("Blad");

// Func<string,int,int> funkcja3 = (str, i) => str.Length + i;
// var funkcja4 = Odwroc(funkcja3);

// Func<double, double> funkcja5 = a => a * a;
// Func<double, double> funkcja6 = b => b * 2;

// Func<T1, T3> Zloz<T1,T2,T3>(Func<T1, T2> funkcja1a, Func<T2, T3> funkcja2a){
//     return (a) => funkcja2a(funkcja1a(a));
// }

// var funkcja7 = Zloz(funkcja5,funkcja6);
// var wynik = funkcja7(10);
// if(wynik == 200)
//     Console.WriteLine("OK");
// else
//     Console.WriteLine("Blad");

T2[] Przetworz<T1, T2>(T1 x, Func<T1,T2>[] funkcje){
    T2[] wyniki = new T2[funkcje.Length];
    for(int i = 0; i< funkcje.Length; i++)
    {
        wyniki[i] = funkcje[i](x);
    }
    return wyniki;
    
}

var wynik1 = Przetworz(1.0, new[] {Math.Sin, Math.Cos});

Action<T> Powtorz<T>(int x, Action<T> akcja){
    return (a) => {
        for(int i = 0; i<x; i++){
            akcja(a);
        }
    };
}

var akcja = Powtorz<string>(10, Console.WriteLine);
akcja("Ala ma kota");
