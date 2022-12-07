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
            max = 110;
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

        static void Main(string[] args)
        {
            Stack s = new Stack(110);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n=====STACK MENU=====\n");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your choice: ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        Console.Write("\nEnter a number: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.push(num);
                        break;
                    case '2':
                        if (s.empty())
                        {
                            Console.WriteLine("\nStack Empty");
                            break;
                        }
                        s.pop();
                        break;
                    case '3':
                        s.display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }
        }
    }
}
