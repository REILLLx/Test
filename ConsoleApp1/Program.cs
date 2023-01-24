
using System.Threading.Channels;


List<string> recruits = new List<string>();
List<string> pidB = new List<string>();
List<string> noB = new List<string>();

recruits.Add("Віталя");
recruits.Add("Даня");
recruits.Add("Ілля");
recruits.Add("Влад");
recruits.Add("Міша");
Console.WriteLine("Our recruits: ");

Random rnd = new Random();

foreach (var recruit in recruits)
{
    Console.WriteLine(recruit);
}

Console.WriteLine();

for (int i = 0; i < 5; i++)
{
    int power = rnd.Next(0, 100);
    if (power>50)
    {
        pidB.Add(recruits[i]);
        continue;
    }

    if (power<50)
    {
        noB.Add(recruits[i]);
    }

    if (power == 50)
    {
        noB.Add(recruits[i]);
    }

}

Console.WriteLine();
Console.WriteLine("Will go to Warzone");
foreach (var powerful in pidB)
{
    Console.WriteLine(powerful);
}

Console.WriteLine();
Console.WriteLine("Won't go to Warzone");
foreach (var powerless in noB)
{
    Console.WriteLine(powerless);
}

Queue<string> arriving = new Queue<string>();
foreach (var rule in pidB)
{
    arriving.Enqueue(rule);
}
Console.WriteLine();

if (arriving.Count > 1)
{
    Console.WriteLine(arriving.Dequeue() + " " + "has arrived to Warzone");
    Console.WriteLine(arriving.Peek() + " " + "is the next who will arrive to Warzone");
    Console.WriteLine("The remaining recruits");
    foreach (var warzone in arriving)
    {
        Console.WriteLine(warzone);
    }
}

if (arriving.Count <= 1)
{
    Console.WriteLine(arriving.Dequeue() + " " + "has arrived to Warzone");
}
   





