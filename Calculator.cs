// Calculator by Dannicah Montano

     public static double? Calculate(int first, int second, string operation)
    {
        switch (operation)
        {
            case "+":
                return first + second;

            case "-":
                return first - second;

            case "*":
                return first * second;

            case "/":
                if (second == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return null;
                }
                return (double)first / second;

            case "%":
                if (second == 0)
                {
                    Console.WriteLine("Cannot modulo by zero.");
                    return null;
                }
                return first % second;

            case "=":
                Console.WriteLine("Program terminated.");
                return null;

            default:
                return null;
        }
    }
