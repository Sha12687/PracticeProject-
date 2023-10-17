using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._9
{
    internal class Stack
    {
        private Node root = null;
        private Node current = null;
        private int length;

        public Node Root
        {
            get { return root; }
            set { root = value; }
        }

        public Node Current
        {
            get { return current; }
            set { current = value; }
        }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public Stack() { }
        public void  push(Node node) {
        
        if(root == null)
            {
            root = node;
            current = node;
            length=1;
            root.Prev = null;
            }
            else
            {
            current.Next = node;
            node.Prev = current;
            current = node;
                length++;
            }
        }
        public void pop() { 
        
        if(root == null)
            {
                Console.WriteLine("Stack is empty!!!!");
                return;
            }
            else if (current == root)
            {
                current=null;
                root = null;
                length = 0;
            }
            else
            {
                Node temp= current.Prev;
                current.Prev.Next = null;
                Console.WriteLine($"The last entered data is deleted {current.Data}");
                current = temp;
                length--;
            }
        }
        public Node getRoot()
        {
            return this.root;
        }
        public int getLengthOfStack()
        {
            return this.length;
        }
        public string listContents()
        {
            string retVal = "";
            Node temp= root;
            
            while (temp != null)
            {
                retVal += temp.Data + " ";
                temp = temp.Next;
            }
            temp = root;
            return retVal;
        }

        public void peek()
        {
            if((current==null))
            {
                Console.WriteLine("Stack is empty!!!!");
                return;
            }
            else
            {
                Console.WriteLine(current.Data);
            }
        }

    }
}
