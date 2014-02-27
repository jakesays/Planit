using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planit.Core
{
    public class Node<T>
    {
        #region Fields

        public T data;
        public LinkedList<Node<T>> Children { get; private set; }
        public int Depth { get; set; } // want this to be readonly
        
        #endregion 

        #region Constructors

        public Node(T data)
        {
            Depth = 0;
            this.data = data;
            Children = new LinkedList<Node<T>>();
        }

        public Node(T data, Node<T> parent)
        {
            Depth = parent.Depth + 1;
            this.data = data;
            Children = new LinkedList<Node<T>>();
        }

        #endregion

        #region Methods

        public void addChild(T data)
        {
            Children.AddFirst(new Node<T>(data, this));
        }

        //public bool hasChildren
        //{
        //    get { return Children.Any(); }
        //}

        //public IEnumerable<Node<T>> getChildren()
        //{
        //    foreach (Node<T> n in Children)
        //        if (--i == 0)
        //            return n;
        //    return null;
        //}

        public IEnumerable<Node<T>> dfs(Node<T> parent)
        {
            foreach (var child in parent.Children) 
            { 
                yield return child; 
                foreach (var grandchild in dfs(child)) 
                { 
                    yield return grandchild; 
                } 
            }
        }

        // 18WAFYSG0 implementation (iterative)
        //public static IEnumerable<Node<T>> dsf(Node<T> node)
        //{
        //    Stack<IEnumerator<Node<T>>> stack = new Stack<IEnumerator<Node<T>>>();

        //    IEnumerator<Node<T>> current;

        //    stack.Push(node.Children.GetEnumerator());

        //    while (stack.Count > 0)
        //    {
        //        current = stack.Pop();
        //        while (current.MoveNext())
        //        {
        //            yield return current.Current;
        //            if (current.Current.hasChildren)
        //            {
        //                stack.Push(current);
        //                current = current.Current.Children.GetEnumerator();
        //            }
        //        }
        //        current.Dispose();
        //    }
        //}

        #endregion 

    }
}
