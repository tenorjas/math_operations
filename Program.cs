using System;

namespace math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;

            double add(double operand1, double operand2){
                return operand1 + operand2;
            }

            double subtract(double operand1, double operand2){
                return operand1 - operand2;
            }

            double multiply(double operand1, double operand2){
                return operand1 * operand2;
            }

            double divide(double operand1, double operand2){
                if (operand2 == 0)
                {
                    return 1000000;
                }
                else
                {
                    return operand1 / operand2;
                }
            }

            double modulo(double operand1, double operand2){
                return operand1 % operand2;
            }

            void showResults(double sum, double difference, double product, double quotient, double remainder){
                Console.WriteLine($"The sum of the two numbers is {sum}.");
                Console.WriteLine($"The difference of the two numbers is {difference}.");
                Console.WriteLine($"The product of the two numbers is {product}.");
                Console.WriteLine($"The quotient of the two numbers is {quotient}.");
                Console.WriteLine($"When number 1 is divided by number 2, the remainder is {remainder}.");
            }

            Console.WriteLine("Please enter Number 1: ");
            number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Number 2:");
            number2 = double.Parse(Console.ReadLine());

            showResults(add(number1, number2), subtract(number1, number2), multiply(number1,number2), divide(number1,number2), modulo(number1,number2));
        }
    }
}
