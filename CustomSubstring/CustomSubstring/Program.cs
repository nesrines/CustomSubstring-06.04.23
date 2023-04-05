string CustomSubstring(string Str, int StartIndex, int Length)
{
    string Result = string.Empty;
    for (int i = StartIndex; i < StartIndex + Length; i++)
    { Result += Str[i]; }
    return Result;
}

try
{
    Console.WriteLine("Enter a string:");
    string Str = Console.ReadLine();
    Console.WriteLine("Enter start index:");
    int StartIndex = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter end index:");
    int Length = int.Parse(Console.ReadLine());

    try
    {
        string Result = CustomSubstring(Str, StartIndex, Length);
        Console.WriteLine(Result);
    }

    catch (Exception)
    { Console.WriteLine("There is no such index in your string."); }
}

catch (Exception)
{ Console.WriteLine("Index must be a number."); }