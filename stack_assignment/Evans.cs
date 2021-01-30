using System;
using System.Collections.Generic;
using System.Text;

namespace stack_assignment
{
    public class Evans
    {
        private object[] array;
        private int top;

        public Evans(int size)
        {
            array = new object[size];
            top = -1;
        }

       /* public void checker(object user_input)
        {
            if (array.Length > user_input)
            {

            }
        }*/
        public void push(object item)
        {
            if (top <= array.Length - 1)
            {
                top++;
                array[top] = item;
            }
            else
                throw new Exception("stack is empty..");
        }

        public object Pop()
        {
            if (top > -1)
            {
                object item = array[top];
                top--;
                return item;
            }
            else
                throw new Exception("stack is empty....");
        }

        public object Peek()
        {
            if (top > -1)
            {
                object item = array[top];
                return item;
            }
            else
                throw new Exception("stack is empty.....");
        }

        public void Clear()
        {
            top = -1;
        }

        public void Print()
        {
            for (var i = top; i >= 0; i++)
            {
                Console.WriteLine("the stack contains {0}", array[i]);
            }
        }

    }

}
