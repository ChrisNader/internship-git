try
{
    var s = "1234";
    byte b = Convert.ToByte(s);
    Console.Write("Converting from \"1234\" to byte worked.");
}
catch (Exception){
    Console.WriteLine("Converting from \"1234\" to byte did not worked.");
}