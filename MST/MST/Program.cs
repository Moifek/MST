
Console.WriteLine("Method ? : \n");
int x = int.Parse(Console.ReadLine());
if (x==1)
{
    Console.WriteLine("Nombre d'entrée(s) : \n");
    int n = int.Parse(Console.ReadLine());
    int[] Stock = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"{i + 1}\'ème élement:");
        Stock[i] = int.Parse(Console.ReadLine());
    }

    Array.Reverse(Stock);

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"\n {Stock[i]}");
    }

}
else
{
    Console.WriteLine("Nombre d'entrée(s) : \n");
    int n = int.Parse(Console.ReadLine());
    IDictionary<String,int> Stock = new Dictionary<String, int>();
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"{i + 1}\'ème élement [Format :: String ('XY')] :");

        String name = Console.ReadLine();

        Console.WriteLine($"{i + 1}\'ème élement {name}, [Format :: entier ('10') ] :");

        int dist = int.Parse(Console.ReadLine());
    }

    Stock.OrderByDescending(x => x.Value);


    foreach (KeyValuePair<String, int> item in Stock.OrderBy(x => x.Value))
    {
        Console.WriteLine("Key: {0}, Value: {1}", item.Key.ToString(), item.Value.ToString());
    }


}




Console.WriteLine("traitement...");

