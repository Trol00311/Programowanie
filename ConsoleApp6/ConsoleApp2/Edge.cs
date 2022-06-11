using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Edge<T>
    {
        Node<T> node1;

        Node<T> node2;

        double value;
        public void addNodes(Node<T> node1, Node<T> node2)
        {
            this.node1 = node1;
            this.node2 = node2;
            node1.addEdge(this);
            node2.addEdge(this);
        }

        public void removeNodes()
        {
            node1.removeEdge(this);
            node2.removeEdge(this);
            node1 = null;
            node2 = null;
        }

        public Node<T>[] getNodes()
        {
            return new Node<T>[] { node1, node2 };
        }
    }
}
