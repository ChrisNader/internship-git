Console.Write("Let's roll the dice!\nChoose wether to roll 1 or 2 dice at a time (enter 1 or 2): " );
int x = Convert.ToInt32 (Console.ReadLine());

Random random = new Random();
int r;

if (x == 1) {
    r = random.Next(1, 6);
    Console.WriteLine("The dice gave you " + r);
}
else if (x == 2)
{
    r = random.Next(1, 12);
    Console.WriteLine("The dices gave you " + r);
}
else Console.WriteLine("Wrong input!");