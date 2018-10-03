    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDProject
{
  public  class StackOfInt : IStackOfInt
    {
        readonly public Stack<double> StackInt = new Stack<double>();

        public void AddAll()
        {
            if (StackInt.Count >= 0)
            {
                double result = 0;


                while (StackInt.Count > 0)
                {
                    result = result + StackInt.Pop();
                }
                StackInt.Push(result);
            }
            else
            {
                throw new Exception();
            }
        }

        public void AddTop2()
        {
            if (StackInt.Count > 1)
            {
                double result = StackInt.Pop() + StackInt.Pop();
                StackInt.Push(result);
            }
            else
            {
                throw new Exception();  
                    }
        }

        public void Clear()
        {
            StackInt.Clear();
        }

        public int Count()
        {
            return StackInt.Count();
        }

        public void DivisionTop2()
        {
            if (StackInt.Count > 1)
            {
                double result = StackInt.Pop() / StackInt.Pop();
                StackInt.Push(result);
            }
            else
            {
                throw new Exception();
            }
        }

        public void MultiAllNumbers()
        {
            if (StackInt.Count >= 0)
            {
                double result = 1;


                while (StackInt.Count > 0)
                {
                    result = result * StackInt.Pop();
                }
                StackInt.Push(result);
            }
            else
            {
                throw new Exception();
            }
        }

        public void Multiplytop2()
        {
            if (StackInt.Count > 1)
            {
                double result = StackInt.Pop() * StackInt.Pop();
                StackInt.Push(result);
            }
            else
            {
                throw new Exception();
            }
        }

        public double Pop()
        {
           
            return  StackInt.Pop();
           
        }

        public void Push(double x)
        {
            StackInt.Push(x);



        }

        public void SubTop2()
        {
            if (StackInt.Count > 1)
            {
                double result = StackInt.Pop() - StackInt.Pop();
                StackInt.Push(result);
            }
            else
            {
                throw new Exception();
            }
        }

        public double Top()
        {
            return StackInt.Peek();
        }
    }
}
