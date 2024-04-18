using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deicstra_corr
{
    public class Deicstra_alg()
    {
        /*
        public Deicstra_alg()
        {
            
        }
        */

        public static Dictionary<Vertex, int> DijkstraAlgorithm(Graph graph, Vertex source)
        {
            var distances = graph.Vertices.ToDictionary(v => v, v => int.MaxValue);
            var previous = new Dictionary<Vertex, Vertex>();
            var notVisited = new HashSet<Vertex>(graph.Vertices);

            distances[source] = 0;

            while (notVisited.Any())
            {
                var nearestVertex = notVisited.OrderBy(v => distances[v]).FirstOrDefault();
                notVisited.Remove(nearestVertex);

                foreach (var edge in nearestVertex.Edges)
                {
                    var neighbor = edge.To;
                    if (notVisited.Contains(neighbor))
                    {
                        var currentDistance = distances[nearestVertex] + edge.Weight;
                        if (currentDistance < distances[neighbor])
                        {
                            distances[neighbor] = currentDistance;
                            previous[neighbor] = nearestVertex;
                        }
                    }
                }
            }

            return distances;
        }
    }
}
