using Deicstra_corr;

class Program
{
    public static void Main(string[] args)
    {
        var graph = new Graph();

        var vertexA = new Vertex("A");
        var vertexB = new Vertex("B");
        var vertexC = new Vertex("C");
        // Добавление остальных вершин...

        graph.Vertices.AddRange(new[] { vertexA, vertexB, vertexC /*, остальные вершины*/ });

        vertexA.Edges.Add(new Edge(vertexA, vertexB, 1));
        vertexB.Edges.Add(new Edge(vertexB, vertexC, 2));
        // Добавление остальных ребер...

        var shortestPaths = DijkstraAlgorithm(graph, vertexA);

        foreach (var path in shortestPaths)
        {
            Console.WriteLine($"Shortest path to {path.Key.Name}: {path.Value}");
        }
    }


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