using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Graph_list_sm
{
    private int _vertices;
    private List<int>[] _adjacencyList;

    public Graph(int vertices) // Создание графа с v вершинами
    {
        _vertices = vertices;
        _adjacencyList = new List<int>[vertices];
        for (int i = 0; i < vertices; i++)
            _adjacencyList[i] = new List<int>();
    }
}

