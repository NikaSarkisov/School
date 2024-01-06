
Console.WriteLine("Please enter a number between 1 to 9");
string input = Console.ReadLine();

int num = int.Parse(input);

for (int y = 0; y < num; y++)
{
    for (int i = 0; i < num; i++)
    {
        Console.Write(i+1 + " ");
    }
    Console.WriteLine();
}

    for (int i = 0; i < num; i++)
    {
        Console.Write(i + 1 + " ");
    }
