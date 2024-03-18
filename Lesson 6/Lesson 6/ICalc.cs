using System;

namespace Lesson_6
{
    internal interface ICalc
    {
        public event EventHandler<OperandChangedEventArgs> GetResult;
        void Sum(int x);
        void Subtract(int x);
        void Multiply(int x);
        void Divide(int x);
        void CancelLast();
    }
}