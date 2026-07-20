Console.WriteLine("Please enter your name: ");
String name = Console.ReadLine();

if (name == "") Console.WriteLine("You did not enter your name!");
else
{
    Console.WriteLine("Hello " + name);

    Console.WriteLine("Please enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    if (age < 18) Console.WriteLine("You have to be +18 to sign up.");
    else if (age > 100) Console.WriteLine("You are too old to sign up");
    else Console.WriteLine("You are signed up");
}