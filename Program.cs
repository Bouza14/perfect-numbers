using System.Diagnostics;

Console.WriteLine("Hello, please enter a natural number:");
string value = Console.ReadLine()!;

Stopwatch stopWatch = new();
stopWatch.Start();

Console.WriteLine("Start Processing...");

int max = int.Parse(value);

Parallel.For(0, max, (number) =>
{
    if (Perfect(number))
        Console.WriteLine($"{number} is perfect.");
});

//for (int number = 0; number <= max; number++)
//{
//    if (Perfect(number))
//        Console.WriteLine($"{number} is perfect.");
//}


static bool Perfect(int num)
{
    int i = 1;
    int divisorSum = 0;
    while (i < (num / 2) + 1)
    {
        if (num % i == 0)
            divisorSum += i;

        i++;
    }

    return divisorSum == num;
}

TimeSpan ts = stopWatch.Elapsed;

// Format and display the TimeSpan value.
string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
    ts.Hours, ts.Minutes, ts.Seconds,
    ts.Milliseconds / 10);

Console.WriteLine($"End Processing. Duration: {elapsedTime}");
Console.ReadKey();