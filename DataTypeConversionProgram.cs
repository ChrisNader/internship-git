byte b = 3;
int i = b;

Console.WriteLine("1. From byte to integer does not need a special function: " + i);

i = 3;
b = (byte)i;

Console.WriteLine("2. From integer to byte using casting: " + i);

i = 1000;
b = (byte)i;

Console.WriteLine("3. byte is limited from 0 to 255");
Console.WriteLine("\tex: having i=1000");
Console.WriteLine("\tconverting it to byte gives us: " + b);
Console.WriteLine("\tbecause some bits are lost.\n");


string s = "17";

i = Convert.ToInt32(s);
int p = int.Parse(s);

Console.WriteLine("\n4. Converting from a string to integer:");
Console.WriteLine("\t- using Convert.ToInt32: " + i);
Console.WriteLine("\t- using int.Parse: " + p);
Console.WriteLine("*And the same goes with different Converto.To* functions.");

i = 321;
s = Convert.ToString(i);
Console.WriteLine("5. Converting from integer to string: " + i);

double d = 3.14;
i = Convert.ToInt32(d);
Console.WriteLine("6. Converting from double to integer: " + i);

i = 123;
d = Convert.ToDouble(i);
Console.WriteLine("7. Converting from integer to double: " + d);

s = "$";
char c = Convert.ToChar(s);
Console.WriteLine("8. Converting from string to character: " + c);

s = "true";
bool bb = Convert.ToBoolean(s);
Console.WriteLine("9. Converting from string to boolean: " + bb);
