using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    internal class OperandChangedEventArgs(double operand) : EventArgs
    {
        public double Operand => operand;
    }
}
