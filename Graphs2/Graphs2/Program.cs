using System;
using System.Collections.Generic;
using System.Linq;
using System.Texr;

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
    }
}