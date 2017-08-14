using System;

namespace math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;

            double sum(double operand1, double operand2){
                return operand1 + operand2;
            }

            double difference(double operand1, double operand2){
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

            double remainder(double operand1, double operand2){
                return operand1 % operand2;
            }
        }
    }
}
