using System;

namespace Lesson_6
{
    public class OperandChangedEventArgs(double operand) : EventArgs
    {
        public double Operand => operand;
    }
}