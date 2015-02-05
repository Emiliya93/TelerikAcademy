using System;

class Expression
{
    static void Main()
    {
        string expression = Console.ReadLine();
        decimal result = 0;
        int currentDigit = 0;
        bool inBrackets = false;
        bool isEnd = false;
        char sign = '+';
        decimal bracketResult = 0;

        for (int i = 0; (i < expression.Length) && (isEnd == false); i++)
        {
            switch (expression[i])
            {
                case '1': currentDigit = 1; break;
                case '2': currentDigit = 2; break;
                case '3': currentDigit = 3; break;
                case '4': currentDigit = 4; break;
                case '5': currentDigit = 5; break;
                case '6': currentDigit = 6; break;
                case '7': currentDigit = 7; break;
                case '8': currentDigit = 8; break;
                case '9': currentDigit = 9; break;
                case '+': i++;
                    if (expression[i] == '(' && expression[i + 1] != ')')
                    {
                        inBrackets = true;
                        sign = '+';
                    }
                    else
                    {
                        inBrackets = false;
                        result += (expression[i] - '0');
                    }
                    break;
                case '-': i++;
                    if (expression[i] == '(' && expression[i + 1] != ')')
                    {
                        inBrackets = true;
                        sign = '-';
                    }
                    else
                    {
                        inBrackets = false;
                        result -= (expression[i] - '0');
                    }
                    break;
                case '/': i++;
                    if (expression[i] == '(' && expression[i + 1] != ')')
                    {
                        inBrackets = true;
                        sign = '/';
                    }
                    else
                    {
                        inBrackets = false;
                        result /= (expression[i] - '0');
                    }
                    break;
                case '*': i++;
                    if (expression[i] == '(' && expression[i + 1] != ')')
                    {
                        inBrackets = true;
                        sign = '*';
                    }
                    else
                    {
                        inBrackets = false;
                        result *= (expression[i] - '0');
                    }
                    break;
                case '=': isEnd = true; break;
                default: break;
            }

            if (i == 0)
            {
                result += currentDigit;
            }

            if (inBrackets)
            {
                i++;
                bool isFirstDigit = true;

                while (expression[i] != ')')
                {
                    switch (expression[i])
                    {
                        case '1': currentDigit = 1; if (isFirstDigit) { bracketResult += currentDigit; isFirstDigit = false; } break;
                        case '2': currentDigit = 2; if (isFirstDigit) { bracketResult += currentDigit; isFirstDigit = false; } break;
                        case '3': currentDigit = 3; if (isFirstDigit) { bracketResult += currentDigit; isFirstDigit = false; } break;
                        case '4': currentDigit = 4; if (isFirstDigit) { bracketResult += currentDigit; isFirstDigit = false; } break;
                        case '5': currentDigit = 5; if (isFirstDigit) { bracketResult += currentDigit; isFirstDigit = false; } break;
                        case '6': currentDigit = 6; if (isFirstDigit) { bracketResult += currentDigit; isFirstDigit = false; } break;
                        case '7': currentDigit = 7; if (isFirstDigit) { bracketResult += currentDigit; isFirstDigit = false; } break;
                        case '8': currentDigit = 8; if (isFirstDigit) { bracketResult += currentDigit; isFirstDigit = false; } break;
                        case '9': currentDigit = 9; if (isFirstDigit) { bracketResult += currentDigit; isFirstDigit = false; } break;
                        case '+': i++; bracketResult += (expression[i] - '0'); break;
                        case '-': i++; bracketResult -= (expression[i] - '0'); break;
                        case '/': i++; bracketResult /= (expression[i] - '0'); break;
                        case '*': i++; bracketResult *= (expression[i] - '0'); break;
                        default: break;
                    }
                    i++;
                }
                inBrackets = false;
            }
            if (inBrackets == false && bracketResult > 0)
            {
                switch (sign)
                {
                    case '+': result += bracketResult; break;
                    case '-': result -= bracketResult; break;
                    case '/': result /= bracketResult; break;
                    case '*': result *= bracketResult; break;
                    default: break;
                }
                bracketResult = 0;
            }
        }

        Console.WriteLine("{0:0.00}", result);
    }
}
