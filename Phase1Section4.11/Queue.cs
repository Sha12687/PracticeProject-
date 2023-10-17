using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._11
{
    internal class Queue
    {
        private int[] ele;
        private int front;
        private int rear;
        private int max;

public Queue(int size) {
            rear = -1;
            max=size;
            front = 0;
            ele = new int[size];    
        }
        public void enQueue(int data)
        {
            if (rear < max - 1)
            {
                ele[++rear] = data;
            }
            else
                return;
        }
        public int  delete() { 
        if(rear+1 ==front) {
                Console.WriteLine("Queue is empty!!!");
                return -1;
            }
            else
            {
                return ele[front++];
            }
        
        }
        public string printQueue()
        {
            string retVal = "";
            if (front == rear + 1)
            {
                return retVal;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    retVal += " " + ele[i];
                }
            }
            return retVal;
        }
    }
}
