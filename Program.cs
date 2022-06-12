using System;

namespace CalculatorFixed
{
    class Program
    {
        static string equation = "";
        //your equation goes above

        static char[] operators = { '+', '-', '*', '/' };

        static void Main(string[] args)
        {
            int i = 0;
            bool foundOp = false;

            string number1;
            string number2;

            float result = default;

            foreach (char a in equation)
            {
                foreach (char b in operators)
                {
                    if (a == b)
                    {
                        foundOp = true;
                        break;
                    }

                    else
                    {
                        foundOp = false;
                        continue;
                    }
                }

                if (foundOp == true && isFloat(equation.Substring(0, i)) && isFloat(equation.Substring(i + 1)))
                {
                    number1 = equation.Substring(0, i);
                    number2 = equation.Substring(i + 1);

                    if (equation[i] == '+')
                    {
                        result = float.Parse(number1) + float.Parse(number2);
                    }

                    else if (equation[i] == '-')
                    {
                        result = float.Parse(number1) - float.Parse(number2);
                    }

                    else if (equation[i] == '*')
                    {
                        result = float.Parse(number1) * float.Parse(number2);
                    }

                    else if (equation[i] == '/')
                    {
                        result = float.Parse(number1) / float.Parse(number2);
                    }

                    Console.WriteLine(result);
                }

                else
                {
                    i++;
                }
            }

            bool isFloat(string s)
            {
                float myFloat;
                return float.TryParse(s, out myFloat);
            }
        }
    }
}
