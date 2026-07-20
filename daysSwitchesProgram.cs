Console.WriteLine("What day is it today?");
String day = Console.ReadLine();
day = day.ToLower();

switch (day)
{
    case "":
        Console.WriteLine("You did not enter a day!");
        break;
    case "monday":
        Console.WriteLine("It's Monday!");
        break;
    case "tuesday":
        Console.WriteLine("It's Tuesday!");
        break;
    case "wednesday":
        Console.WriteLine("It's Wednesday!");
        break;
    case "thursday":
        Console.WriteLine("It's Thursday!");
        break;
    case "friday":
        Console.WriteLine("It's Friday!");
        break;
    case "saturday":
        Console.WriteLine("It's Saturday!");
        break;
    case "sunday":
        Console.WriteLine("It's Sunday!");
        break;
    default:
        Console.WriteLine(day + " is not a day!");
        break;
}