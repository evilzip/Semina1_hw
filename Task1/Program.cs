System.Console.WriteLine("This program gives maximum and minumum value out of two values");
System.Console.WriteLine("Enter your 1st value");
int value1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter your 2nd value");
int value2 = Convert.ToInt32(Console.ReadLine());

if (value1 != value2)
{
    if (value1 > value2)
    {
        System.Console.WriteLine($" MAX = {value1}, MIN = {value2}");
    }
    else
    {
        System.Console.WriteLine($"MAX = {value2} , MIN = {value1}");
    }
}
else
{
    System.Console.WriteLine($"{value2} = {value1} => there is no MIN/MAX");
}