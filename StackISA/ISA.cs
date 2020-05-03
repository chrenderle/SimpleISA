/*
 * Written by: Christian Enderle <enderle@mailbox.org>
 * LICENSE GPLv3
 */
using System;
using System.Collections.Generic;

namespace StackISA
{
    public class ISA
    {
        private Stack<float> _stack;

        public ISA()
        {
            _stack = new Stack<float>();
        }
        
        public void Push(float number, int times)
        {
            for (int i = 0; i < times; ++i)
            {
                Push(number);
            }
        }
        public void Push(float number) => _stack.Push(number);
        
        public float Pop() => _stack.Pop();

        public void Add(int times)
        {
            for (int i = 0; i < times; ++i)
            {
                Add();
            }
        }
        
        public void Add()
        {
            if (!(_stack.Count >= 2))
            {
                throw new Exception();
            }

            float a = _stack.Pop();
            float b = _stack.Pop();
            _stack.Push(a + b);
        }

        public void Sub(int times)
        {
            for (int i = 0; i < times; ++i)
            {
                Sub();
            }
        }
        
        public void Sub()
        {
            if (!(_stack.Count >= 2))
            {
                throw new Exception();
            }

            float a = _stack.Pop();
            float b = _stack.Pop();
            _stack.Push(a - b);
        }

        public void Mult(int times)
        {
            for (int i = 0; i < times; ++i)
            {
                Mult();
            }
        }
        
        public void Mult()
        {
            if (!(_stack.Count >= 2))
            {
                throw new Exception();
            }

            float a = _stack.Pop();
            float b = _stack.Pop();
            _stack.Push(a * b);
        }

        public void Div(int times)
        {
            for (int i = 0; i < times; ++i)
            {
                Div();
            }
        }
        
        public void Div()
        {
            if (!(_stack.Count >= 2))
            {
                throw new Exception();
            }

            float a = _stack.Pop();
            float b = _stack.Pop();
            _stack.Push(a / b);
        }
    }
}