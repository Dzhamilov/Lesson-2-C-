using System;
using System.Runtime.Serialization;

namespace Lesson_6
{
    internal class CalculatorDivideByZeroException : Exception
    {
        public CalculatorDivideByZeroException(string message) : base(message)
        {

        }

    }
}