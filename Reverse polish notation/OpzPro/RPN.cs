

using System;
using System.Collections.Generic;
using OpzPro;

public class RPN
{
    private string input;
    private string output;
    public string infixExpr { get; private set; }
    public string postfixExpr { get; private set; }
    
    
    public RPN(string inp)
    {
        input = inp;
        infixExpr = inp;
        postfixExpr = ToPostfix(infixExpr + "\r");
    }
    public double Calculate()
    {
        GetExpression();
        double result = Counting(); 
        return result; 
    }
    
    private void GetExpression()
    { 

        stack<char> operStack = new stack<char>(1000);

        for (int i = 0; i < input.Length; i++)
        {
            
            if (IsDelimeter(input[i]))
                 continue; 
            
            if (Char.IsDigit(input[i])) 
            {
                 while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                 {
                     output += input[i];
                     i++;
    
                     if (i == input.Length) break;
                 }
    
                 output += " ";
                 i--;
            }
            
            if (IsOperator(input[i]))
            {
                if (input[i] == '(') 
                    operStack.Push(input[i]); 
                else if (input[i] == ')') 
                {
                    
                    char s = operStack.Pop();
    
                    while (s != '(')
                    {
                        output += s.ToString() + ' ';
                        s = operStack.Pop();
                    }
                }
                else 
                {
                    if (operStack.Count > 0)
                        if (GetPriority(input[i]) <= GetPriority(operStack.Peek()))
                            output += Convert.ToString(operStack.Pop()) + " "; 
    
                    operStack.Push(char.Parse(input[i].ToString())); 
    
                }
            }
        }
        
        while (operStack.Count > 0)
            output += operStack.Pop() + " ";
        
}
    
    private double Counting()
    {
        double result = 0; 
  //      Stack<double> temp = new Stack<double>(); 
        stack<double> temp = new stack<double>(1000);
        for (int i = 0; i < input.Length; i++) 
        {
            if (Char.IsDigit(input[i])) 
            {
                string a = string.Empty;

                while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                {
                    a += input[i];
                    i++;
                    if (i == input.Length) break;
                }
                temp.Push(double.Parse(a));
                i--;
            }
            else if (IsOperator(input[i]))
            {
                double a = temp.Pop(); 
                double b = temp.Pop();

                switch (input[i])
                { 
                    case '+': result = b + a; break;
                    case '-': result = b - a; break;
                    case '*': result = b * a; break;
                    case '/': result = b / a; break;
                    case '^': result = double.Parse(Math.Pow(double.Parse(b.ToString()), double.Parse(a.ToString())).ToString()); break;
                }
                temp.Push(result);
            }
        }
        return temp.Peek();
    }
    
    private int GetPriority(char s)
    {
        switch (s)
        {
            case '(': return 0;
            case ')': return 1;
            case '+': return 2;
            case '-': return 3;
            case '*': return 4;
            case '/': return 4;
            case '^': return 5;
            default: return 6;
        }
    }
    
    private bool IsDelimeter(char c)
    {
        if ((" =".IndexOf(c) != -1))
            return true;
        return false;
    }
    
    private bool IsOperator(char с)
    {
        if (("+-/*^()".IndexOf(с) != -1))
            return true;
        return false;
    }
    

        private Dictionary<char, int> operationPriority = new Dictionary<char, int>()
        {
            { '(', 0 },
            { '+', 1 },
            { '-', 1 },
            { '*', 2 },
            { '/', 2 },
            { '^', 3 },
            { '~', 4 },
        };
        

        private string GetStringNumber(string expr, ref int pos)
        {
            string strNumber = "";
            for (; pos < expr.Length; pos++)
            {
                char num = expr[pos];

                if (Char.IsDigit(num))
                    strNumber += num;
                else
                {
                    pos--;
                    break;
                }
            }

            return strNumber;
        }

        private string ToPostfix(string infixExpr)
        {
            string postfixExpr = "";
            stack<char> stack = new(10000);
            
            for (int i = 0; i < infixExpr.Length; i++)
            {
                char c = infixExpr[i];
                
                if (Char.IsDigit(c))
                {
                    postfixExpr += GetStringNumber(infixExpr, ref i) + " ";
                }
                else if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                        postfixExpr += stack.Pop();
                    stack.Pop();
                }
                else if (operationPriority.ContainsKey(c))
                {
                    char op = c;
                    if (op == '-' && (i == 0 || (i > 1 && operationPriority.ContainsKey(infixExpr[i - 1]))))
                        op = '~';
                    
                    while (stack.Count > 0 && (operationPriority[stack.Peek()] >= operationPriority[op]))
                        postfixExpr += stack.Pop();
                    stack.Push(op);
                }
            }
            
            foreach (char op in stack)
                postfixExpr += op;
            
            return postfixExpr;
        }

        private double Execute(char op, double first, double second) => op switch
        {
            '+' => first + second,
            '-' => first - second,
            '*' => first * second,
            '/' => first / second,
            '^' => Math.Pow(first, second),
            _ => 0
        };
        
        
    }



