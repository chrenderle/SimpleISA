/*
 * Written by: Christian Enderle <enderle@mailbox.org>
 * LICENSE GPLv3
 */
using System;
using System.Collections.Generic;

namespace StackISA
{
    class Program
    {
        static Stack<float> _stack = new Stack<float>();
        static void Main(string[] args)
        {
            float x = 0;
            Console.Write("x: ");
            x = Convert.ToSingle(Console.In.ReadLine());
            ISA isa = new ISA();
            /*
             * Push(number) puts number on top of the stack
             * Pop() returns you the stack
             * Add() adds the operand at the to the one below
             * Sub() subtracts from the operand at the top the operand below
             * Mult() multiplies the operand on the top with the one below
             * Div() divides the operand at the top by the one below
             * All commands except Pop optionally take a second argument which specifies how many times the operation shall be executed (with the given argument)
             */
            /*Your Program Code here*/
            //r4
            isa.Push(6);
            isa.Push(x, 3);
            isa.Mult(2);
            isa.Div();
            //r2
            isa.Push(1);
            isa.Push(x);
            isa.Div();
            //r3
            isa.Push(2);
            isa.Push(x, 2);
            isa.Mult();
            isa.Div();
            //r1
            isa.Push(1);
            //rges
            isa.Add();
            isa.Sub(2);
            /*Until here, unless the last command isn't Pop*/
            float result = isa.Pop();
            Console.WriteLine($"Result: {result}");
        }

        
    }
}