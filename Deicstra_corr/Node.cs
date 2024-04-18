using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deicstra_corr
{
    public class Vertex
    {
        public string Name { get; }
        public List<Edge> Edges { get; }

        public Vertex(string name)
        {
            Name = name;
            Edges = new List<Edge>();
        }
    }

    public class Edge
    {
        public Vertex From { get; }
        public Vertex To { get; }
        public int Weight { get; }

        public Edge(Vertex from, Vertex to, int weight)
        {
            From = from;
            To = to;
            Weight = weight;
        }
    }
}
