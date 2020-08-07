using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Dequeue
{
    class DequeA
    {
        private int[] queueArray;
        private int front;
        private int rear;
        public DequeA()
        {
            queueArray = new int[10];
            front = -1;
            rear = -1;
        }
        public DequeA(int maxSize)
        {
            queueArray = new int[maxSize];
            front = -1;
            rear = -1;
        }
        public void InsertFront(int x)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue overflow");
                return;
            }
            if (front == -1)
            {
                front = 0;
                rear = 0;
            }
            else if (front == 0)
                front = queueArray.Length - 1;
            else
                front = front - 1;
            queueArray[front] = x;
        }
        public void InsertRear(int x)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue overflow");
                return;
            }
            if (front == -1)
                front = 0;
            if (rear == queueArray.Length - 1)
                rear = 0;
            else
                rear = rear + 1;
            queueArray[rear] = x;
        }
        public int DeleteFront()
        {
            int x;
            if (IsEmpty())
                throw new System.InvalidOperationException("Queue underflow");
            x = queueArray[front];
            if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else if (front == queueArray.Length - 1)
                front = 0;
            else
                front = front + 1;
            return x;
        }
        public int DeleteRear()
        {
            int x;
            if (IsEmpty())
                throw new System.InvalidOperationException("Queue underflow");
            x = queueArray[rear];
            if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else if (front ==rear)
                rear = queueArray.Length - 1;
            else
                front = front - 1;
            return x;
        }
        public bool IsFull()
        {
            return ((front == 0 && rear == queueArray.Length - 1) || (rear == rear + 1));
        }
        public bool IsEmpty()
        {
            return (front == -1);
        }
        public void Display()
        {
            int i;

            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine("Queue is :");
            i = front;
            if(front <= rear)
            {
                while (i <= rear)
                    Console.Write(queueArray[i++] + " ");
            }
            else
            {
                while (i <= queueArray.Length - 1)
                    Console.WriteLine(queueArray[i++] + " ");
                i = 0;
                while (i <= rear)
                    Console.WriteLine(queueArray[i++] + " ");

            }
            Console.WriteLine(" ");
        }

    }
}
