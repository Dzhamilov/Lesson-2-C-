using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    internal class CalculatorDivideByZeroException : Exception
    {
        public CalculatorDivideByZeroException(string message) : base(message)
        {

        }

    }
}
