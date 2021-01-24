using System;
using System.Collections.Generic;
using System.Linq;

namespace BreadthFirstTraversal
{
    class Graph
    {
        private int Vertices;
        LinkedList<int>[] adj;

        public Graph(int V)
        {
            int i = 0;
            adj = new LinkedList<int>[V];

            for (i = 0; i < adj.Length; i++)
                adj[i] = new LinkedList<int>();

            Vertices = V;
        }

        public void addEdge(int v, int w)
        {
            adj[v].AddLast(w);
        }

        public void BFS(int s)
        {
            bool[] visited = new bool[Vertices];
            int i = 0;

            for (i = 0; i < Vertices; i++)
                visited[i] = false;

            LinkedList<int> queue = new LinkedList<int>();

            visited[s] = true;
            queue.AddLast(s);

            while(queue.Any())
            {
                s = queue.First();
                Console.Write(s + " ");
                queue.RemoveFirst();

                LinkedList<int> list = adj[s];

                foreach (var val in list)
                {
                    if (!visited[val])
                    {
                        visited[val] = true;
                        queue.AddLast(val);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Graph g = new Graph(4);

            g.addEdge(0, 1);
            g.addEdge(0, 2);
            g.addEdge(1, 2);
            g.addEdge(2, 0);
            g.addEdge(2, 3);
            g.addEdge(3, 3);

            Console.Write("Following is Breadth First " +
                          "Traversal(starting from " +
                          "vertex 2)\n");
            g.BFS(2);
        }
    }
}
