Console.Write("How many columns do you need? ");
int c = Convert.ToInt32(Console.ReadLine());

Console.Write("\nHow many rows do you need? ");
int r = Convert.ToInt32(Console.ReadLine());

Console.Write("\nEnter a symbol: ");
char symbol = (char)Console.Read();

Console.WriteLine();

for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)
    {
        Console.Write(symbol);
    }
    Console.WriteLine();
}