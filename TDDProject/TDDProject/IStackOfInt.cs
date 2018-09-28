using System;
using System.Collections.Generic;
using System.Text;

namespace TDDProject
{
 public    interface IStackOfInt
    {
        //insert number in top of the stack
        void Push(double x);
        //delete first number in stack
        void Pop();
        //return first number in stack
        double Top ();
        // clear all numbers in stack
        void Clear();
        //Count number in stack
        int Count ();
        //Adds the 2 first number in the stack and put in the top of the stack
        void AddTop2();
        //subtract the 2 first number in the stack and put in the top of the stack
        void SubTop2();
        //Multiply the first 2 number in the stack and put in the top of the stack
        void Multiplytop2();
        //Devide the first 2 number in the stack and put in the top of the stack
        void DivisionTop2();
        //Add all number in the stack and put it to the stack
        void AddAll();
        //Multiply all number in the stack and put it to the stack
        void MultiAllNumbers();


    }
}
