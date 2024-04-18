using Deicstra_corr;

class Program
{
    public static void Main(string[] args)
    {
        // Создание графа
        var graph = new Graph();

        // Добавление вершина
        var vertexA = new Vertex("A");
        var vertexB = new Vertex("B");
        var vertexC = new Vertex("C");
        // ...
        // Добавляем их в для графа
        graph.Vertices.AddRange(new[] { vertexA, vertexB, vertexC /*, остальные вершины*/ });
        //


        // 
        vertexA.Edges.Add(new Edge(vertexA, vertexB, 1));
        vertexB.Edges.Add(new Edge(vertexB, vertexC, 2));
        // Добавление остальных ребер


        // Используем алгоритм Дейкстра
        Deicstra_alg shortest_to = new Deicstra_alg();

        var shortestPaths = shortest_to.DijkstraAlgorithm(graph, vertexA);

        foreach (var path in shortestPaths)
        {
            Console.WriteLine($"Shortest path to {path.Key.Name}: {path.Value}");
        }
    }

}