using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        public static void runApp()
        {
            Stack stack = new Stack();
            Console.WriteLine($"Length of the Stack {stack.Length}");
            for (char  i = 'A'; i < 'J'; i++)
            {
                Node node = new Node();
                node.Data=i.ToString();
                stack.push(node);
                Console.WriteLine($"Length of the Stack {stack.Length}");
            }
            stack.pop();
            Node node1 = new Node();
            node1.Data = "J";
            stack.push(node1);
            Console.WriteLine(stack.listContents());
            Console.WriteLine($"Stack Peek element is");
            stack.peek();
            Console.ReadLine();
        }
    }
}
