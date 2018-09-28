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
            double result = 0;
            //foreach (var item in StackInt)
            //{
            //    result = result + item;

            //}
            //StackInt.Clear();
            
            while (StackInt.Count > 0)
            {
                result = result + StackInt.Pop();
            }
          StackInt.Push(result);
        }

        public void AddTop2()
        {
            double result = StackInt.Pop() + StackInt.Pop();
            StackInt.Push(result);
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
            double result = StackInt.Pop() / StackInt.Pop();
            StackInt.Push(result);
        }

        public void MultiAllNumbers()
        {
            double result = 1;
        

            while (StackInt.Count > 0)
            {
                result = result * StackInt.Pop();
            }
            StackInt.Push(result);
        }

        public void Multiplytop2()
        {
            double result = StackInt.Pop() * StackInt.Pop();
            StackInt.Push(result);
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
            double result = StackInt.Pop() - StackInt.Pop();
            StackInt.Push(result);
        }

        public double Top()
        {
            return StackInt.Peek();
        }
    }
}
