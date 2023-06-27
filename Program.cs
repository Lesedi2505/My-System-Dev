using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

        // Welcome message and informing user about the limited functions of the calculator
           
            Console.WriteLine("Welcome to our Calculator");
            Console.WriteLine("NB:THIS CALCULATOR CAN ONLY APPLY THE FOLLOWING OPERATORS: + - * /");

            // Prompt user to enter first number
          
            Console.Write("Please enter your number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
             
            // Promting user to insert a valid operator and applying a loop that ensures that the correct operator is inserted
            
            string inputOperator;
            bool isValidOperator = false;

            do
            {
                Console.Write("Please enter a valid operator: ");
                inputOperator = Console.ReadLine();

                if (inputOperator == "+" || inputOperator == "-" || inputOperator == "*" || inputOperator == "/")
                {
                    isValidOperator = true;
                }
                else
                {
                    Console.WriteLine("Invalid operator.Please try again");
                }
            } while (!isValidOperator);

            // Promting user to insert the next number

            Console.Write("Please enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (inputOperator == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (inputOperator == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (inputOperator == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (inputOperator == "/")
            {
                Console.WriteLine(num1 / num2);
            }

            // Promting user to convert measurements from centimeters to meters
            Console.WriteLine("Please enter measurement in centimeters");
            double centimeter = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your measurement in meters is:" + centimeter / 100 + "m");

        }
    }
}

