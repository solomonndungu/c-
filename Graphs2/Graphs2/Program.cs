using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreadthFirstSearch
{
    class Graph
    {
        private int _v;
        private bool _direct;

        LinkedList<int>[] _adj;

        public Graph (int v, bool direct)
        {
            _adj = new LinkedList<int>[v];

            for (int i = 0; i < _adj.Length; i++)
            {
                _adj[i] = new LinkedList<int>();
            }

            _v = v;

            _direct = direct;
        }

        public void Add_edge(int v, int w)
        {
            _adj[v].AddLast(w);

            if (!_direct) {
                _adj[w].AddLast(v);
                    }
        }
        public void BreadthFirstSearch(int s)
        {
            bool[] visited = new bool[_v];

            for (int i = 0; i < _v; i++)
            {
                visited[i] = false;

                // Create a queue for BFS
                LinkedList<int> queue1 = new LinkedList<int>();

                visited[s] = true;

                queue1.AddLast(s);

                while (queue1.Any())
                {
                    // Dequeue a vertex from queue and print it
                    s = queue1.First();
                    Console.Write(s + "");

                    queue1.RemoveFirst();

                    LinkedList<int> list = _adj[s];

                    foreach (var val in list)
                    {
                        if (!visited[val])
                        {
                            visited[val] = true;

                            queue1.AddLast(val);
                        }
                    }
                }
            }
            
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Graph gr = new Graph(7, true);

            gr.Add_edge(0, 1);
            gr.Add_edge(0, 2);
            gr.Add_edge(0, 3);
            gr.Add_edge(1, 0);
            gr.Add_edge(1, 5);
            gr.Add_edge(2, 5);
            gr.Add_edge(3, 0);
            gr.Add_edge(3, 4);
            gr.Add_edge(4, 6);
            gr.Add_edge(5, 1);
            gr.Add_edge(6, 5);

            Console.Write("Breadth First Traversal from vertex 2:\n");

            gr.BreadthFirstSearch(2);
        }
    }
}