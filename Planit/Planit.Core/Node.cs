using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planit.Core
{
    public class Node<T>
    {
        public T data;
        LinkedList<Node<T>> children;

        public Node(T data)
        {
            this.data = data;
            children = new LinkedList<Node<T>>();
        }

        public void addChild(T data)
        {
            children.AddFirst(new Node<T>(data));
        }

        public bool hasChildren
        { 
            get {return children.Any();}
        }

        public Node<T> getChild(int i)
        {
            foreach (Node<T> n in children)
                if (--i == 0) 
                    return n;
            return null;
        }
        
    }
}
