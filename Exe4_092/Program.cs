using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_092
{
    class Stack
    {
        //Untuk deklarasi variabel int
        public int[] saras;
        public int top;
        public int max;

        public Stack(int size) //Method untuk memanggil variabel
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

        public void push(int element) //Method untuk menambah data pada array
        {
            if (top == max - 1) //Jika top sama dengan max - 1
            {
                return;
            }
            else
            {
                saras[++top] = element; //Maka array saras increment 1 atau data bertambah 1
            }
        }

        public int pop() //Method untuk menghilangkan data pada array
        {
            if (top == -1) //Jika top menunjukkan data paling atas
            {
                return -1; //Kembali turun -1
            }
            else
            {
                Console.WriteLine("\nThe Popped element is: " + saras[top]);
                return saras[top--]; //Maka muncul pesan top array saras yang sudah berkurang 1, atau top decrement 1
            }
        }

        public void display()
        {
            if (empty()) //Jika method empty dipanggil
                Console.WriteLine("\nStack Empty"); //Muncul pesan Stack Empty
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Element[" + (i + 1) + "]: " + saras[i]); //Kemudian terjadi perulangan
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
}
