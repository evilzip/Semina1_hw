System.Console.WriteLine("Program shows all even nubers from 1 till N");

System.Console.Write("Enter your N ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 1;
while (i < n +1)
{
    if (i%2 == 0)
    {
        System.Console.Write($" {i} ");        
    }
    i++;    
}

