using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ParcialScripting
{
    class Program
    {
        private Node nodo00 = new Node(1, 0);
        private Node nodo01 = new Node(2, 0);
        private Node nodo02 = new Node(3, 0);
        private Node nodo03 = new Node(5, 0);
        private Node nodo04 = new Node(1, -1);
        private Node nodo05 = new Node(2, -1);
        private Node nodo06 = new Node(3, -1);
        private Node nodo07 = new Node(5, -1);
        private Node nodo08 = new Node(1, -2);
        private Node nodo09 = new Node(2, -2);
        private Node nodo10 = new Node(3, -2);
        private Node nodo11 = new Node(5, -2);
        private Node nodo12 = new Node(1, -3);
        private Node nodo13 = new Node(5, -3);
        private Node nodo14 = new Node(1, -4);
        private Node nodo15 = new Node(2, -4);
        private Node nodo16 = new Node(3, -4);
        private Node nodo17 = new Node(4, -4);
        private Node nodo18 = new Node(5, -4);
        
        static void Main(string[] args)
        {
            
        }

        
    }
    class Node

    {
        private int x;
        private int y;

        public Node()
        {

        }
        public Node(int x, int y)
        {
            X = x;
            Y = y;

        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
}
    