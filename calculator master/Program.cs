using System;
class program
{
    static void Main()
    {
        double num1, num2 =0;
        char opration;

        Console.WriteLine("Enter fist number!");
        num1 = Convert.ToDouble (Console.ReadLine());

        Console.WriteLine("Enter a opration");
        opration = Convert.ToChar (Console.ReadLine());

        if (opration == '+' || opration == '-' || opration == '*' || opration == '/' || opration == '^')
        {
            Console.WriteLine("Enter second number:");
            num2 = Convert.ToDouble(Console.ReadLine());
        }

        Double result = 0;
        Boolean validopration = true;

        switch (opration)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':

                if(num2 != 0)
                {
                    result= num1 / num2;
                }
                else
                {
                    Console.WriteLine("Division by zero is not Valid");
                    validopration = false;
                }
                break;

                default: 
                Console.WriteLine("The entered action is not valid.");
                validopration = false;
                break;

            case '^':
                result = Math.Pow(num1, num2);
                break;
            /*sin*/
            case 's':
                result= Math.Sin(num1 * Math.PI /180);
                break;
            /*cos*/
            case 'c':
                result = Math.Cos(num1 * Math.PI / 180);
                break;
            /*tan*/
            case 't':
                result = Math.Tan(num1 * Math.PI / 180);
                break;
            /*ctan*/
            case 'k':
                double radians = num1 * Math.PI / 180;
                if (Math.Tan(radians) != 0)
                {
                    result = 1 / Math.Tan(radians);
                }
                else
                {
                    Console.WriteLine("Cotangent is undefined for this input.");
                    validopration = false;
                }
                break;
        }

        if (validopration)
        {
            Console.WriteLine($"result: {result}");
        }
    }

}
