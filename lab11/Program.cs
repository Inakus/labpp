//zad 5.1
int[] StworzTabliceLosowa(int n, int min, int max){
    Random generator = new Random();
    var przepis1 = from ind in Enumerable.Range(0,n)
                    select generator.Next(min,max);

    var przepis2 = Enumerable.Range(0, n)
            .Select(ind => generator.Next(min,max));

    return przepis1.ToArray();
}

var tab = StworzTabliceLosowa(20, -5,5);
            // .OrderByDescending(x => x)
            // .Take(5)
            // .ToArray();


for(int i = 0; i<tab.Length;i++){
    Console.Write($"{tab[i]},");
}

// tab.Aggregate((a,x) => a+x);
// tab.Average();
Console.WriteLine();
var histogram = tab
    .Where(x => x%2 == 0)
    .GroupBy(x => x)
    .Select(grupa => (Klucz: grupa.Key, LiczbaWystapien: grupa.Count()))
    .OrderByDescending(para => para.LiczbaWystapien)
    .First();
    // .Take(1)
    // .ToArray();

// foreach(var element in histogram){
    Console.WriteLine($"{histogram.Klucz}: {histogram.LiczbaWystapien}");
// }



// foreach(var grupa in tab.GroupBy((x) => x)){
//     Console.Write(grupa.Key + ": ");
//     Console.Write(grupa.Count());
//     // foreach (var item in grupa){
//     //     Console.Write($"{item}, ");
//     // }
//     Console.WriteLine();
// }
        
    