using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Equl
{
    class EQUL
    {
        public static Double doop(Double x, Double y, char ch)
        {
            switch (ch)
            {
                case '+':
                    return y + x;
                    
                case '-':
                    return y - x;
                    
                case '*':
                    return y * x;
                    
                case '/':
                    if (x == 0)
                    {
                        MessageBox.Show("Error (Attempted to divide by zero)");
                        return 0;
                        
                    }
                    return y / x;
                    
                default: return 0;
                    
            }
        }
         public static Double Arithmetic (string s)
        {
            Stack<double> numbers= new Stack<double>();
            Stack<char> op=new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (ch == ' ')
                {
                    continue;
                }
                if (ch >= '0' && ch <= '9')
                {
                    int z = 0;
                    while (ch >= '0' && ch <= '9')
                    {
                        z = z * 10 + (ch - '0');
                        i++;
                        if (i >= s.Length)
                        {
                            break;
                        }
                        ch = s[i];
                    }
                    numbers.Push(z);
                     i--;
                }
                if (ch == '*' || ch == '/')
                {
                    op.Push(ch);
                }
                if (ch == '+' || ch == '-')
                {
                    if (op.Count != 0)
                    {
                        while (op.Peek() == '*' || op.Peek() == '/')
                        {
                            Double x = numbers.Peek();
                            numbers.Pop();
                            Double y = numbers.Peek();
                            numbers.Pop();
                            
                            numbers.Push(doop(x, y, op.Peek()));
                            op.Pop();

                            if (op.Count == 0)
                            {
                                break;
                            }
                        }
                    }
                op.Push(ch);
                }
            }
                while (op.Count != 0)
                {
                    Double x = numbers.Peek();
                    numbers.Pop();
                    Double y = numbers.Peek();
                    numbers.Pop();
                    
                    numbers.Push(doop(x, y, op.Peek()));
                    op.Pop();
                }
                return numbers.Peek();
        }
        
    }
}
