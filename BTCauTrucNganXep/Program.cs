using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCauTrucNganXep
{
    class Stack
    {
        private int[] data;
        private int top;
        public Stack()
        {
            data = new int[100];
            top = -1;
        }
        public Stack(int size)
        {
            data = new int[size];
            top = -1;
        }
        public bool isEmpty()
        {
            bool kq = false;
            if (top == -1)
            {
                kq = true;
            }
            return kq;
        }
        public bool isFull()
        {
            bool kq = false;
            if (top == data.Length - 1)
            {
                kq = true;
            }
            return kq;
        }
        public void Push(int x)
        {
            if (isFull())
            {
                Console.WriteLine("Stack day. Them phan tu that bai");
            }
            else
            {
                top++;
                data[top] = x;
            }
        }
        public int Pop()
        {
            int kq = 0;
            if (isEmpty())
            {
                Console.WriteLine("Stack rong. Lay phan tu that bai");
            }
            else
            {
                kq = data[top];
                top--;
            }
            return kq;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen N(he 10): ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Nhap co so X(he 2, 8, 16): ");
            int X = int.Parse(Console.ReadLine());

            Stack s = new Stack();
            int value;
            while (N > 0)
            {
                s.Push(N % X);
                N = N / X;
            }
            Console.WriteLine($"Bieu dien co so {X}: ");
            while (!s.isEmpty())
            {
                value = s.Pop();
                if (X == 16)
                {
                    switch (value)
                    {
                        case 10:
                            Console.Write("A");
                            break;
                        case 11:
                            Console.Write("B");
                            break;
                        case 12:
                            Console.Write("C");
                            break;
                        case 13:
                            Console.Write("D");
                            break;
                        case 14:
                            Console.Write("D");
                            break;
                        case 15:
                            Console.Write("E");
                            break;
                        case 16:
                            Console.Write("F");
                            break;
                        default:
                            Console.Write(value);
                            break;
                    }
                }
                else
                {
                    Console.Write(value);
                }
            }

            Console.ReadLine();
        }
    }
}
