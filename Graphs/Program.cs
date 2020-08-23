using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Graph();
            var v1 = new Vertex(1);
            var v2 = new Vertex(2);
            var v3 = new Vertex(3);
            var v4 = new Vertex(4);
            var v5 = new Vertex(5);
            var v6 = new Vertex(6);
            var v7 = new Vertex(7);

            graph.AddVertex(v1);
            graph.AddVertex(v2);
            graph.AddVertex(v3);
            graph.AddVertex(v4);
            graph.AddVertex(v5);
            graph.AddVertex(v6);
            graph.AddVertex(v7);

            graph.AddEdge(v1, v2);
            graph.AddEdge(v1, v3);
            graph.AddEdge(v3, v4);
            graph.AddEdge(v2, v5);
            graph.AddEdge(v2, v6);
            graph.AddEdge(v6, v5);
            graph.AddEdge(v5, v6);

            GetMatrix(graph);

            Console.WriteLine();
            Console.WriteLine();

            GetVertex(v1, graph);
            GetVertex(v2, graph);
            GetVertex(v3, graph);
            GetVertex(v4, graph);
            GetVertex(v5, graph);
            GetVertex(v6, graph);
            GetVertex(v7, graph);
           
            Console.WriteLine();

            Console.WriteLine(graph.Wave(v1, v5));
            Console.WriteLine(graph.Wave(v2, v4));

            Console.WriteLine();
        }
        private static void GetVertex(Vertex vertex, Graph graph)
        {
            foreach (var v in graph.GetVertexList(vertex))
            {
                Console.Write(v + " ");
            }
            Console.WriteLine();
        }
        private static void GetMatrix(Graph graph)
        {
            var matrix = graph.GetMatrix();

            for (int i = 0; i < graph.VertexCount; i++)
            {
                for (int j = 0; j < graph.VertexCount; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
