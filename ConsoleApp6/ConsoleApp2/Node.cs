using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Node<T>
    {
        List<Edge<T>> edges = new List<Edge<T>>();

        T value;

        int number;

        static int total = 0;
        public Node()
        {
            number = total;
            total++;
        }
        public void addEdge( Edge<T> edge)
        {
            edges.Add(edge);
        }

        public void removeEdge(Edge<T> edge)
        {
            edges.Remove(edge);
        }

        public List<Edge<T>> getEdges()
        {
            return edges;
        }

    }
}
