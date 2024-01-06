
Console.WriteLine("Please enter a number between 1 to 9");
string input = Console.ReadLine();

int num = int.Parse(input);

for (int i = 1; i <= num; i++)
{
    Console.Write(i + " ");
}