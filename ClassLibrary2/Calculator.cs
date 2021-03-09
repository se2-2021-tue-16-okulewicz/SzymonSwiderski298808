using System;
using System.Linq;

namespace ClassLibrary2
{
    public class Calculator
    {
        char[] operators = { ',', '\n' };
        bool noOperatorsFlag = true;

        public int Calculate(string arg)
        {
            foreach(char op in operators)
            {
                if(arg.Contains(op))
                {
                    arg = operatorsAnalyzer(arg, op);
                }
            }

            int n;
            bool isNumeric = int.TryParse(arg, out n);
            if (isNumeric) return n;
            return 0;
        }

        private string operatorsAnalyzer(string arg, char _operator)
        {
            switch(_operator)
            {
                case ',':
                    return sum(arg);
                case '\n':
                    return sum(arg);
                case '-':
                    throw new ArgumentException("Parameter cannot be negative");
                default:
                    noOperatorsFlag = true;
                    break;
            }
            return arg;
        }
        private string sum(string arg)
        {
            return arg.Split(operators, StringSplitOptions.RemoveEmptyEntries).Sum(t => int.Parse(t)).ToString();
        }
        private bool isOperator(char letter)
        {
            foreach(char _operator in operators)
            {
                if(_operator==letter)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
