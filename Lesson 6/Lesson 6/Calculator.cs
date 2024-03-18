using System.Collections.Generic;
using System;

namespace Lesson_6
{
    internal class Calculator : ICalc
    {


        public event EventHandler<OperandChangedEventArgs> GetResult;
        private Stack<int> stack = new Stack<int>();

        private int Result
        {
            get
            {
                return stack.Count() == 0 ? 0 : stack.Peek();

            }
            set
            {
                stack.Push(value);
                RaiseEvent();
            }
        }




        public void CancelLast()
        {
            if (stack.Count > 0)
            {
                stack.Pop();
                RaiseEvent();
            }

        }
        public void RaiseEvent()
        {
            GetResult.Invoke(this, new OperandChangedEventArgs(Result));
        }


        public void Divide(int number)

        {
            try
            {

                if (number == 0)
                    throw new CalculatorDivideByZeroException("Деление на ноль недопустимо");
                Result /= number;


            }

            catch (OverflowException)
            {
                throw new CalculateOperationCauseOverflowException("Превышено допустимое число");
            }
        }



        public void Multiply(int number)

        {
            try
            {
                checked
                {
                    Result *= number;
                }
            }
            catch
            {
                throw new CalculateOperationCauseOverflowException("Превышено допустимое число");
            }

        }



        public void Subtract(int number)
        {
            try
            {

                Result -= number;

            }
            catch
            {
                throw new CalculateOperationCauseOverflowException("Превышено допустимое число");
            }
        }


        public void Sum(int number)
        {
            try
            {

                Result += number;
            }
            catch
            {
                throw new CalculateOperationCauseOverflowException("Превышено допустимое число");
            }
        }





        //перегрузка для работой с double
        private double result
        {
            get
            {
                return stack.Count() == 0 ? 0 : stack.Peek();

            }
            set
            {
                stack.Push((int)value);
                RaiseEvent();
            }
        }
        public void Sum(double number)
        {
            try
            {

                result += number;
            }
            catch
            {
                throw new CalculateOperationCauseOverflowException("Превышено допустимое число");
            }
        }
        public void Subtract(double number)
        {
            try
            {

                result -= number;

            }
            catch
            {
                throw new CalculateOperationCauseOverflowException("Превышено допустимое число");
            }
        }
        public void Divide(double number)

        {
            try
            {

                if (number == 0)
                    throw new CalculatorDivideByZeroException("Деление на ноль недопустимо");
                result /= number;


            }

            catch (OverflowException)
            {
                throw new CalculateOperationCauseOverflowException("Превышено допустимое число");
            }
        }
        public void Multiply(double number)

        {
            try
            {
                checked
                {
                    result *= number;
                }
            }
            catch
            {
                throw new CalculateOperationCauseOverflowException("Превышено допустимое число");
            }

        }
    }
}