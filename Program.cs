// Calculator by Dannicah Montano

using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        string operation = "";
        while (operation != "="){
            Console.Write("\nEnter first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int second = int.Parse(Console.ReadLine());
            
            Console.Write("Choose an operation(+,-,*,/,%,=): ");
            operation = Console.ReadLine();
            
            while(operation != "+" && operation != "-" && operation !="*"&& operation != "/" &&operation != "%" &&operation != "="){
            Console.WriteLine("\nIncorrect operation used. Please try again.");
            Console.Write("Choose an operation(+,-,*,/,%,=): ");
            operation = Console.ReadLine();
            }
         
            double? result = Calculate(first, second, operation);
            if(result != null){
                Console.WriteLine($"\nResult: {result}");
            }
        }
    }
}
