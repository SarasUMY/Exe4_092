using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_092
{
    class Stack
    {
        public int[] saras;
        public int top;
        public int max;

        public Stack(int size)
        {
            saras = new int[size];
            top = -1;
            max = 90;
        }

        bool empty()
        {
            if (top == -1) //Jika stack empty maka top = -1
                return (true);
            else
                return (false);
        }

        public void push(int element)
        {
            if (top == max - 1)
            {
                return;
            }
            else
            {
                saras[++top] = element;
            }
        }

        public int pop()
        {
            if (top == -1)
            {
                return -1;
            }
            else
            {
                Console.WriteLine("\nThe Popped element is: " + saras[top]);
                return saras[top--];
            }
        }

        public void display()
        {
            if (empty())
                Console.WriteLine("\nStack Empty");
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Element[" + (i + 1) + "]: " + saras[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
