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
    }
}
