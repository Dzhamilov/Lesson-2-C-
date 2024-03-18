using System.Collections.Generic;
using System.Text;

namespace Lesson_6
{
    internal class Logger
    {
        private Stack<(int, string)> log = new Stack<(int, string)>();

        public void AddLog(int number, string operation)
        {
            log.Push(new(number, operation));
        }
        public string GetLog()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" StackTrace: ");
            foreach (var log in log)
            {
                sb.Append(log.ToString());
            }
            return sb.ToString();
        }
    }
}