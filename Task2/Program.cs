System.Console.WriteLine("This program shows maximum value out of yours 3 numbers");

int max;

System.Console.Write("Enter your 1st value ");
int value1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter your 2nd value ");
int value2 = Convert.ToInt32(Console.ReadLine());

if (value1 > value2)
{
    max = value1;
}
else
{
    max = value2;
}

System.Console.Write("Enter your 3rd value ");
int value3 = Convert.ToInt32(Console.ReadLine());

if (value3 > max)
{
    max = value3;
}

System.Console.Write($"Maximum is {max}");
