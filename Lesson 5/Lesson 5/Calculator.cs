﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    internal class Calculator : ICalculator
    {
        public event EventHandler<OperandChangedEventArgs> GetResult;
        private Stack<double> stack = new Stack<double>();
        private double Result
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
        public void RaiseEvent()
        {
            GetResult.Invoke(this, new OperandChangedEventArgs(Result));
        }
        public void CancelLast()
        {
            if (stack.Count > 0)
            {
                stack.Pop();
                RaiseEvent();
            }
        }
        public void Divide(double numder)
        {
            Result /= numder;
        }

        public void Multiply(double numder)
        {
            Result *= numder;
        }

        public void Substract(double numder)
        {
            Result -= numder;
        }

        public void Sum(double numder)
        {
            Result += numder;
        }

    }
}
