Console.Write("Enter the first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a power of this number: ");
int numberB = Convert.ToInt32(Console.ReadLine());

double RiseToPower(double a, double b)
{
    double result = 0;
    
    for (int i = 0; i<b; i++)
    {
        result = Math.Pow(a, b);
       
    }
     Console.WriteLine(a + " to the " + b + " power is equal to " + result);
     return result;
}
    
RiseToPower(numberA, numberB);
