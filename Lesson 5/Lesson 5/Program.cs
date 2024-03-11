using System;

namespace Lesson_5
{
    internal class Program
    {
        /*Задача 1 Спроектируем интерфейс калькулятора, поддерживающего простые 
         * арифметические действия,хранящего результат и также 
         * способного выводить информацию о результате  при помощи события*/

        static void Main(string[] args)
        {
            
            ICalculator calculator = new Calculator();
            Logger logger = new Logger();
            calculator.GetResult += Calculator_GetResult;
            do
            {
                try
                {

                    Console.Write("Введите число: ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите операцию (для выхода из программы введите 'q'): ");
                    string operation = Console.ReadLine();
                    logger.AddLog(number, operation);
                    switch (operation)
                    {
                        case "+":
                            calculator.Sum(number);
                            break;
                        case "-":
                            calculator.Substract(number);
                            break;
                        case "*":
                            calculator.Multiply(int.MaxValue);
                            break;
                        case "/":
                            calculator.Divide(number);
                            break;
                        case "q":
                            return;
                            break;
                        default:
                            Console.WriteLine("Неверная команда");
                            break;
                    }
                }
                catch (CalculateOperationCauseOverflowException ex)
                {
                    Console.WriteLine(ex.Message + logger.GetLog());
                }
                catch (CalculatorDivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message + logger.GetLog());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + logger.GetLog());
                }

            } while (true);
        }

        private static void Calculator_GetResult(object? sender, OperandChangedEventArgs e)
        {
            Console.WriteLine(e.Operand);
        }
    }
    
}
