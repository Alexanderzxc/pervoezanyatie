

using System;
using System.Collections.Generic;

public class RPN
{
    private string input;
    private string output;

    public RPN(string inp)
    {
        input = inp;
    }
    public double Calculate()
    {
        GetExpression();
        double result = Counting(); 
        return result; 
    }
    
    private void GetExpression()
    { 
        Stack<char> operStack = new Stack<char>();

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
        Stack<double> temp = new Stack<double>(); 

        for (int i = 0; i < output.Length; i++) 
        {
            if (Char.IsDigit(output[i])) 
            {
                string a = string.Empty;

                while (!IsDelimeter(output[i]) && !IsOperator(output[i]))
                {
                    a += output[i];
                    i++;
                    if (i == output.Length) break;
                }
                temp.Push(double.Parse(a));
                i--;
            }
            else if (IsOperator(output[i]))
            {
                double a = temp.Pop(); 
                double b = temp.Pop();

                switch (output[i])
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
    
}