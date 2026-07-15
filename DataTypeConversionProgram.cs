byte b = 3;
int i = b;

Console.Write("1. From byte to integer does not need a special function: ");
Console.WriteLine(i);

i = 3;
b = (byte) i;

Console.Write("2. From integer to byte using casting: ");
Console.WriteLine(i);

i = 1000;
b = (byte)i;

Console.WriteLine("3. byte is limited from 0 to 255");
Console.WriteLine("\tex: having i=1000");
Console.Write("\tconverting it to byte gives us: ");
Console.WriteLine(b);
Console.WriteLine("\tbecause some bits are lost.\n");


string s = "17";

i = Convert.ToInt32(s);
int p = int.Parse(s);

Console.WriteLine("\n4. Converting from a string to integer:");
Console.Write("- using Convert.ToInt32: ");
Console.WriteLine(i);
Console.Write("- using int.Parse: ");
Console.WriteLine(p);
Console.WriteLine("and the same goes with different Converto.To* functions.");

