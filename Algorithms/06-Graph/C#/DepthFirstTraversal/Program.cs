/*  Complexity Analysis: 

Time complexity: O(V + E), where V is the number of vertices and E is the number of edges in the graph.

Space Complexity :O(V). 
Since an extra visited array is needed of size V.

*/

using System;
using System.Collections.Generic;

namespace DepthFirstTraversal
{
    public class Graph
    {
        private int Vertices;
        private List<int>[] adj;

        Graph(int vertices)
        {
            Vertices = vertices;
            adj = new List<int>[vertices];

            for (int i = 0; i < vertices; ++i)
                adj[i] = new List<int>();
        }

        void addEdge(int v, int w)
        {
            adj[v].Add(w);
        }

        void DFSUtil(int v, bool[] visited)
        {
            visited[v] = true;
            int n = 0;

            Console.Write(v + " ");

            foreach (int i in adj[v])
            {
                n = i;
                if (!visited[n])
                    DFSUtil(n, visited);
            }
        }

        void DFS()
        {
            bool[] visited = new bool[Vertices];

            for (int i = 0; i < Vertices; ++i)
                if (visited[i] == false)
                    DFSUtil(i, visited);
        }

        public static void Main(String[] args)
        {
            Graph g = new Graph(4);

            g.addEdge(0, 1);
            g.addEdge(0, 2);
            g.addEdge(1, 2);
            g.addEdge(2, 0);
            g.addEdge(2, 3);
            g.addEdge(3, 3);

            Console.WriteLine("Following is Depth First Traversal");

            g.DFS();
        }
    }
}
