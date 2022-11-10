using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node("Juan", 86);
            Node n2 = new Node("Pedro", 50);
            Node n3 = new Node("Maria", 48);
            Node n4 = new Node("Jose", 26);
            Node n5 = new Node("Rosa", 24);
            Node n6 = new Node("Luis", 12);
            Node n7 = new Node("Ana", 10);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
            VisitorN1 visitor = new VisitorN1();
            visitor.Visit(n1);
            Console.WriteLine(visitor.Content);
            VisitorN2 visitor2 = new VisitorN2();
            visitor2.Visit(n1);
            Console.WriteLine(visitor2.Content);
            VisitorN3 visitor3 = new VisitorN3();
            visitor3.Visit(n1);
            Console.WriteLine(visitor3.Content);
        }
    }
}
