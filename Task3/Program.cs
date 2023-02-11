System.Console.WriteLine("This program checks if your value is EVEN");

System.Console.Write("Enter your value ");
int value = Convert.ToInt32(Console.ReadLine());

if (value%2 == 0)
{
    System.Console.WriteLine($"Yes,{value} is EVEN");

}
else
{
    System.Console.WriteLine($"No, {value} is not EVEN");

}