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
        public LinkedList<Node<T>> children;
       
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
            get { return children.Any(); }
        }

        //public IEnumerable<Node<T>> getChildren()
        //{
        //    foreach (Node<T> n in children)
        //        if (--i == 0)
        //            return n;
        //    return null;
        //}

        public IEnumerable<Node<T>> dfs(Node<T> node)
        {
            using(LinkedList<Node<T>>.Enumerator e = node.children.GetEnumerator())
            {
                foreach (var noder in node.children) 
                { 
                    yield return noder; 
                    foreach (var child in dfs(noder)) 
                    { 
                        yield return child; 
                    } 
                }
            }
        }

            //while (e.MoveNext())
            //{
            //    yield return e.Current;
            //    dfs(e.Current); //if (e.Current.hasChildren) dfs(e.Current);
            //}

    }
}

//public static IEnumerable<Node<T>> dsf(Node<T> node)
//{
//    Stack<IEnumerator<Node<T>>> stack = new Stack<IEnumerator<Node<T>>>();

//    IEnumerator<Node<T>> current;
            
//    stack.Push(node.Children.GetEnumerator());

//    while(stack.Count > 0)
//    {
//        current = stack.Pop();
//        while(current.MoveNext())
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
