using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        public static void runApp()
        {
            Queue Q = new Queue(10);

            Q.enQueue(10);
            Q.enQueue(20);
            Q.enQueue(30);
            Q.enQueue(40);
            Q.enQueue(50);
            Q.enQueue(60);
            Q.enQueue(70);
            Q.enQueue(80);
            Q.enQueue(90);
            Q.enQueue(100);
            Console.WriteLine(Q.printQueue());
            Q.delete();
            Q.delete();
            Console.WriteLine(Q.printQueue());
        }

    }
}
