using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private Person person;

        private List<Node> children = new List<Node>();

        public Person Person {
            get
            {
                return this.person;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(string name, int age)
        {
            Person newPerson = new Person(name, age);
            this.person = newPerson;
        }
        

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
          public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
        
    }
}
