Console.WriteLine("Enter the first number (double) : ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("=====================================");

Console.WriteLine("Enter a value for the power (integer) :");
int p = Convert.ToInt32(Console.ReadLine());
double result = Math.Pow(x, p);
Console.WriteLine(x + " to the power " + p + " = " + result + "\n");
Console.WriteLine("-------------------------------------");


result = Math.Sqrt(x);
Console.WriteLine("Square root of " + x + " = " + result);

result = Math.Abs(x);
Console.WriteLine("Absolut value of " + x + " = " + result);

result = Math.Round(x);
Console.WriteLine("Round of " + x + " = " + result);

result = Math.Ceiling(x);
Console.WriteLine("Ceiling value of " + x + " = " + result);

result = Math.Floor(x);
Console.WriteLine("Floor value of " + x + " = " + result);
Console.WriteLine("-------------------------------------");

Console.WriteLine("Enter a second number (double) : ");
double y = Convert.ToDouble(Console.ReadLine());
result = Math.Max(x, y);
Console.WriteLine("The maximum number between " + x + " and " + y + " is " + result + ".");

result = Math.Min(x, y);
Console.WriteLine("The minimum number between " + x + " and " + y + " is " + result + ".");
