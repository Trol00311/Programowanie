using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Graf<T>
    {
        List<Node<T>> nodes = new List<Node<T>>();

        public void addNode(Node<T> node)
        {
            nodes.Add(node);
        }
        public void removeNode(Node<T> node)
        {
            List<Edge<T>> edges = node.getEdges();
            
            foreach(Edge<T> edge in edges)
            {
                removeEdge(edge);
            }
            nodes.Remove(node);
        }
        public void addEdge(Edge<T> edge, Node<T> node1, Node<T> node2)
        {
            node1.addEdge(edge);
            node2.addEdge(edge);
            edge.addNodes(node1, node2);
        }

        public void removeEdge(Edge<T> edge)
        {
            edge.removeNodes();

        }

        public string printNeighbour(Node<T> node)
        {
            List<Edge<T>> edges = node.getEdges();
            foreach(Edge<T> edge in edges)
            {
                Node<T>[] nodes = edge.getNodes();
                foreach(Node<T> n1 in nodes)
                {

                }
            }
        }
    }
}
