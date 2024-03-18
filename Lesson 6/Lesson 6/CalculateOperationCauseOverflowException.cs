using System;
using System.Runtime.Serialization;

namespace Lesson_6
{
    internal class CalculateOperationCauseOverflowException : Exception
    {
        public CalculateOperationCauseOverflowException(string message) : base(message)
        {

        }
    }
}