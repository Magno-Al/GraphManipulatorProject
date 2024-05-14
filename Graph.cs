using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GraphManipulator
{
    public class Graph
    {
        public bool IsDirectGraph { get; set; }
        private List<Vertex> Vertices { get; set; }
        private List<Edge> Edges { get; set; }
        public Dictionary<string, List<(string, int)>> AdjacencyList { get; private set; }
        public int[,] AdjacencyMatrix { get; private set; }

        public int GraphDegree
        {
            get
            {
                return GetNonDirectedGraphDegree();
            }
        }

        public Graph(bool isDirectGraph)
        {
            IsDirectGraph = isDirectGraph;

            Vertices = new List<Vertex>();
            Edges = new List<Edge>();

            AdjacencyMatrix = new int[0, 0];
            AdjacencyList = new Dictionary<string, List<(string, int)>>();
        }

        #region GraphPrivateMethods
        private int GetVertexIndexInVertices(string vertexName)
        {
            for (int i = 0; i < Vertices.Count; i++)
            {
                if (Vertices[i].Name == vertexName)
                {
                    return i;
                }
            }

            return -1;
        }

        private void UpdateAdjacencyMatrix()
        {
            int vertexCount = Vertices.Count;

            AdjacencyMatrix = new int[vertexCount, vertexCount];
            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = 0; j < vertexCount; j++)
                {
                    AdjacencyMatrix[i, j] = 0;
                }
            }

            foreach (Edge edge in Edges)
            {
                int row = Vertices.IndexOf(edge.Predecessor);
                int col = Vertices.IndexOf(edge.Successor);
                                
                AdjacencyMatrix[row, col] = edge.Weight ?? 1; 

                if (!IsDirectGraph)
                    AdjacencyMatrix[col, row] = edge.Weight ?? 1;
            }
        }

        public int GetGraphDegree()
        {
            return GetNonDirectedGraphDegree();
        }

        private int GetNonDirectedGraphDegree()
        {
            var sum = 0;
            foreach (var vertex in Vertices)
            {
                sum += GetDegreeVertexNonDirectedGraph(vertex.Name);
            }
            return sum;
        }

        public bool IsSimpleGraph()
        {
            for (int i = 0; i < Vertices.Count; i++)
            {
                for (int j = 0; j < Vertices.Count; j++)
                {
                    if ((i == j) && AdjacencyMatrix[i, i] != 0)
                    {
                        return false;
                    }
                    if (AdjacencyMatrix[i, j] > 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsRegularGraph()
        {
            if (IsDirectGraph)
            {
                int entraceDegree = GetEntraceDegreeVertexDirectedGraph(Vertices[0].Name);
                int exitDegree = GetExitDegreeVertexDirectedGraph(Vertices[0].Name);

                foreach (var vertex in Vertices)
                {
                    if (entraceDegree != GetEntraceDegreeVertexDirectedGraph(vertex.Name) ||
                        exitDegree != GetExitDegreeVertexDirectedGraph(vertex.Name))
                    {
                        return false;
                    }
                }
            }
            else
            {
                int degree = GetDegreeVertexNonDirectedGraph(Vertices[0].Name);
                foreach (var vertex in Vertices)
                {
                    if (degree != GetDegreeVertexNonDirectedGraph(vertex.Name))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsCompleteGraph()
        {
            if (!IsSimpleGraph())
                return false;

            int n = Vertices.Count;
            var r = (n * (n - 1)) / 2;

            if (r != Edges.Count)
                return false;

            return true;
        }

        public bool IsBipartiteGraph()
        {
            if (Vertices.Count == 0)
                return false;

            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            Dictionary<string, bool> colors = new Dictionary<string, bool>(); 

            foreach (var vertex in Vertices) 
            {
                visited[vertex.Name] = false;
                colors[vertex.Name] = false;
            }

            foreach (var vertex in Vertices) 
            {
                if (!visited[vertex.Name]) // Se o vértice ainda não foi visitado
                {
                    Queue<string> queue = new Queue<string>(); 
                    queue.Enqueue(vertex.Name);
                    colors[vertex.Name] = true; 

                    while (queue.Count > 0) 
                    {
                        string currentVertex = queue.Dequeue(); 

                        foreach (var (neighbor, weight) in AdjacencyList[currentVertex]) // Para cada vizinho do vértice atual
                        {
                            if (!visited[neighbor]) 
                            {
                                visited[neighbor] = true; 
                                colors[neighbor] = !colors[currentVertex]; 
                                queue.Enqueue(neighbor); 
                            }
                            else if (colors[neighbor] == colors[currentVertex]) // Se o vizinho já foi visitado e tem a mesma cor do vértice atual
                            {
                                return false; 
                            }
                        }
                    }
                }
            }

            return true; 
        }

       
        public List<string> TopologicalSort()
        {
            Stack<string> stack = new Stack<string>();
            Dictionary<string, bool> visited = new Dictionary<string, bool>();

            foreach (var vertex in Vertices)
            {
                visited[vertex.Name] = false;
            }

            foreach (var vertex in Vertices)
            {
                if (!visited[vertex.Name])
                {
                    TopologicalSortUtil(vertex.Name, visited, stack);
                }
            }

            List<string> result = new List<string>();
            while (stack.Count != 0)
            {
                result.Add(stack.Pop());
            }

            return result;
        }

        private void TopologicalSortUtil(string vertex, Dictionary<string, bool> visited, Stack<string> stack)
        {
            visited[vertex] = true;

            foreach (var (adjacentVertex, weight) in AdjacencyList[vertex])
            {
                if (!visited[adjacentVertex])
                {
                    TopologicalSortUtil(adjacentVertex, visited, stack);
                }
            }

            stack.Push(vertex);
        }

        public bool IsConnectedGraph()
        {

            List<string> visitedVertices;
            if (!IsDirectGraph)
            {
                visitedVertices = BreadthSearch();
            }
            else
            {
                visitedVertices = DepthSearch();
            }

            bool isConected = visitedVertices.Count == Vertices.Count;
            return isConected;
        }  
               



        #endregion

        #region VetexMethods
        public bool AddVertex(string name)
        {
            foreach (var vertex in Vertices)
            {
                if (vertex.Name == name)
                {
                    return false;
                }
            }

            Vertex newVertex = new Vertex(name);
            Vertices.Add(newVertex);

            AdjacencyList.Add(newVertex.Name, new List<(string, int)>());
            UpdateAdjacencyMatrix();

            return true;
        }

        public bool RemoveVertex(string vertexName)
        {
            int vertexIndex = GetVertexIndexInVertices(vertexName);

            if (vertexIndex != -1)
            {
                Vertices.RemoveAt(vertexIndex);

                AdjacencyList.Remove(vertexName);
                UpdateAdjacencyMatrix();

                return true;
            }

            return false;
        }

        public List<string> GetAllVerticesNames()
        {
            List<string> names = new List<string>();

            foreach (var vertex in Vertices)
            {
                names.Add(vertex.Name);
            }

            return names;
        }
        public int GetDegreeVertexNonDirectedGraph(string vertexName)
        {
            return AdjacencyList[vertexName].Count;
        }

        public int GetEntraceDegreeVertexDirectedGraph(string vertexName)
        {
            int count = 0;
            foreach (var edge in Edges)
            {
                if (edge.Successor.Name == vertexName)
                {
                    count++;
                }
            }

            return count;
        }

        public int GetExitDegreeVertexDirectedGraph(string vertexName)
        {
            return AdjacencyList[vertexName].Count;
        }

        public string GetVertexNeighborhood(string vertexName)
        {
            string neighborhood = "";

            foreach (var name in AdjacencyList[vertexName])
            {
                neighborhood += $"{name}, ";
            }

            return neighborhood;
        }
        #endregion

        #region EdgeMethods
        private bool AddEdge(Vertex predecessorVertex, Vertex successorVertex, int? weight)
        {
            if (predecessorVertex != null && successorVertex != null)
            {
                string edgeName = predecessorVertex.Name + successorVertex.Name;
                Edges.Add(new Edge(edgeName, predecessorVertex, successorVertex, weight));

                AdjacencyList[predecessorVertex.Name].Add((successorVertex.Name, weight ?? 1));
                if (!IsDirectGraph && predecessorVertex.Name != successorVertex.Name)
                    AdjacencyList[successorVertex.Name].Add((predecessorVertex.Name, weight ?? 1));

                UpdateAdjacencyMatrix();

                return true;
            }

            return false;
        }

        public bool AddEdge(string predecessorVertexName, string successorVertexName, int? weight)
        {
            return AddEdge(Vertices[GetVertexIndexInVertices(predecessorVertexName)], Vertices[GetVertexIndexInVertices(successorVertexName)], weight);
        }

        public string GetVertexPredecessors(string vertexName)
        {
            string predecessor = "";
            foreach (var edge in Edges)
            {
                if (edge.Successor.Name == vertexName)
                {
                    predecessor += $"{edge.Predecessor.Name}, ";
                }
            }

            return predecessor;
        }

        public bool RemoveEdge(string predecessorVertexName, string successorVertexName)
        {
            int indexEdgeToRemove = -1;

            for (int i = 0; i < Edges.Count; i++)
            {
                if (Edges[i].Predecessor.Name == predecessorVertexName &&
                    Edges[i].Successor.Name == successorVertexName)
                {
                    indexEdgeToRemove = i;
                }
            }

            if (indexEdgeToRemove != -1)
            {
                Edges.RemoveAt(indexEdgeToRemove);


                AdjacencyList[predecessorVertexName].RemoveAll(pair => pair.Item1 == successorVertexName);
                if (!IsDirectGraph && predecessorVertexName != successorVertexName)
                    AdjacencyList[successorVertexName].RemoveAll(pair => pair.Item1 == predecessorVertexName);

                UpdateAdjacencyMatrix();
                return true;
            }
            return false;
        }

        #endregion

        #region VertexClass
        private class Vertex
        {
            public string Name { get; set; }
            public bool? ColorMark { get; set; }
            public Vertex(string name)
            {
                Name = name;
                ColorMark = null;
            }
        }
        #endregion

        #region EdgeClass
        private class Edge
        {
            public string Name { get; set; }
            public Vertex Predecessor { get; set; }
            public Vertex Successor { get; set; }
            public int? Weight { get; set; }

            public Edge(string name, Vertex predecessor, Vertex successor, int? weight)
            {
                Name = name;
                Predecessor = predecessor;
                Successor = successor;
                Weight = weight;
            }
        }
        #endregion


        #region Search Methods
        public List<string> DeepSearch(string startVertex, string targetVertex)
        {
            List<string> path = new List<string>();
            Dictionary<string, bool> visited = new Dictionary<string, bool>();

            foreach (var vertex in Vertices)
            {
                visited[vertex.Name] = false;
            }

            DeepSearch(startVertex, targetVertex, visited, path, 0);

            return path;
        }      
        private bool DeepSearch(string currentVertex, string targetVertex, Dictionary<string, bool> visited, List<string> path, int currentCost)
        {
            visited[currentVertex] = true;
            path.Add(currentVertex);

            if (currentVertex == targetVertex)
            {
                return true;
            }

            foreach (var (neighbor, weight) in AdjacencyList[currentVertex])
            {
                if (!visited[neighbor])
                {
                    if (DeepSearch(neighbor, targetVertex, visited, path, currentCost + weight))
                    {
                        return true;
                    }
                }
            }

            path.Remove(currentVertex);
            return false;
        }
        private void DepthSearchUtil(string vertex, Dictionary<string, bool> visited, List<string> visitedVertices, int currentCost)
        {
            visited[vertex] = true;
            visitedVertices.Add(vertex);

            foreach (var (adjacentVertex, weight) in AdjacencyList[vertex])
            {
                if (!visited[adjacentVertex])
                {
                    DepthSearchUtil(adjacentVertex, visited, visitedVertices, currentCost + weight);
                }
            }
        }
        public List<string> DepthSearch()
        {
            List<string> visitedVertices = new List<string>();

            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            foreach (var vertex in Vertices)
            {
                visited[vertex.Name] = false;
            }

            foreach (var vertex in Vertices)
            {
                if (!visited[vertex.Name])
                {
                    int currentCost = 0;
                    DepthSearchUtil(vertex.Name, visited, visitedVertices, currentCost);
                }
            }

            return visitedVertices;
        }
        public List<string> BreadthSearch(string startVertex)
        {
            List<string> visitedVertices = new List<string>();
            Queue<(string, int)> queue = new Queue<(string, int)>();

            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            foreach (var vertex in Vertices)
            {
                visited[vertex.Name] = false;
            }

            queue.Enqueue((startVertex, 0));
            visited[startVertex] = true;

            while (queue.Count != 0)
            {
                var (currentVertex, currentCost) = queue.Dequeue();
                visitedVertices.Add(currentVertex);

                foreach (var (adjacentVertex, weight) in AdjacencyList[currentVertex])
                {
                    if (!visited[adjacentVertex])
                    {
                        visited[adjacentVertex] = true;
                        queue.Enqueue((adjacentVertex, currentCost + weight));
                    }
                }
            }

            return visitedVertices;
        }
        public List<string> BreadthSearch()
        {
            List<string> visitedVertices = new List<string>();
            Queue<(string, int)> queue = new Queue<(string, int)>();

            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            foreach (var vertex in Vertices)
            {
                visited[vertex.Name] = false;
            }

            Random rand = new Random();
            int randomIndex = rand.Next(0, Vertices.Count);
            string startVertex = Vertices[randomIndex].Name;

            queue.Enqueue((startVertex, 0));
            visited[startVertex] = true;

            while (queue.Count != 0)
            {
                var (currentVertex, currentCost) = queue.Dequeue();
                visitedVertices.Add(currentVertex);

                foreach (var (adjacentVertex, weight) in AdjacencyList[currentVertex])
                {
                    if (!visited[adjacentVertex])
                    {
                        visited[adjacentVertex] = true;
                        queue.Enqueue((adjacentVertex, currentCost + weight));
                    }
                }
            }

            return visitedVertices;
        }
      
        #endregion


        #region Subgraph Methods
        public Graph MSTKruskal()
        {
            Graph mstGraph = new Graph(IsDirectGraph);


            List<Edge> sortedEdges = Edges.OrderBy(e => e.Weight).ToList();

            foreach (var edge in sortedEdges)
            {

                mstGraph.AddEdge(edge.Predecessor.Name, edge.Successor.Name, edge.Weight);

                // CRIAR FUNÇÃO PARA VERIFICAR SE O GRAFO TEM CICLO
                //if (mstGraph.ContainsCycle())
                //{
                //    mstGraph.RemoveEdge(edge.Predecessor.Name, edge.Successor.Name);
                //}
            }

            return mstGraph;
        }
        public Graph MSTPrim(string root)
        {
            Graph mstGraph = new Graph(IsDirectGraph);
            HashSet<string> visited = new HashSet<string>();

            mstGraph.AddVertex(root);
            visited.Add(root);

            while (visited.Count < Vertices.Count)
            {
                int minWeight = int.MaxValue;
                Edge minEdge = null;

                foreach (var visitedVertex in visited)
                {
                    foreach (var (neighbor, weight) in AdjacencyList[visitedVertex])
                    {
                        if (!visited.Contains(neighbor) && weight < minWeight)
                        {
                            minWeight = weight;
                            minEdge = new Edge($"{visitedVertex}-{neighbor}", new Vertex(visitedVertex), new Vertex(neighbor), weight);
                        }
                    }
                }

                if (minEdge != null)
                {
                    mstGraph.AddVertex(minEdge.Successor.Name);
                    mstGraph.AddEdge(minEdge.Predecessor.Name, minEdge.Successor.Name, minEdge.Weight);
                    visited.Add(minEdge.Successor.Name);
                }
            }

            return mstGraph;
        }
        public (List<string> path, int totalWeight) DijkstraShortestPath(string startVertex, string endVertex)
        {
            Dictionary<string, int> distances = new Dictionary<string, int>();
            Dictionary<string, string> previousVertices = new Dictionary<string, string>();
            HashSet<string> visited = new HashSet<string>();
            PriorityQueue<string> priorityQueue = new PriorityQueue<string>();


            foreach (var vertex in Vertices)
            {
                distances[vertex.Name] = int.MaxValue;
                previousVertices[vertex.Name] = null;
            }
            distances[startVertex] = 0;


            priorityQueue.Enqueue(startVertex, 0);

            while (priorityQueue.Count > 0)
            {
                string currentVertex = priorityQueue.Dequeue();

                if (currentVertex == endVertex)
                {
                    List<string> shortestPath = new List<string>();
                    int totalWeight = distances[endVertex];
                    while (previousVertices[currentVertex] != null)
                    {
                        shortestPath.Add(currentVertex);
                        currentVertex = previousVertices[currentVertex];
                    }
                    shortestPath.Add(startVertex);
                    shortestPath.Reverse();
                    return (shortestPath, totalWeight);
                }

                if (visited.Contains(currentVertex))
                {
                    continue;
                }

                visited.Add(currentVertex);


                foreach (var (neighbor, weight) in AdjacencyList[currentVertex])
                {
                    int newDistance = distances[currentVertex] + weight;
                    if (newDistance < distances[neighbor])
                    {
                        distances[neighbor] = newDistance;
                        previousVertices[neighbor] = currentVertex;
                        priorityQueue.Enqueue(neighbor, newDistance);
                    }
                }
            }

            return (null, 0);
        }
        public Graph Dijkstra(string root)
        {
            var distances = new Dictionary<string, int>();
            var predecessors = new Dictionary<string, string>();

            foreach (var vertex in Vertices)
            {
                distances[vertex.Name] = int.MaxValue;
                predecessors[vertex.Name] = null;
            }
            distances[root] = 0;

            var unvisitedVertices = new HashSet<string>(Vertices.Select(v => v.Name));

            while (unvisitedVertices.Count > 0)
            {
                var currentVertex = unvisitedVertices.OrderBy(v => distances[v]).First();
                unvisitedVertices.Remove(currentVertex);

                foreach (var (neighbor, weight) in AdjacencyList[currentVertex])
                {

                    var newDistance = distances[currentVertex] + weight;

                    if (newDistance < distances[neighbor]) // Relaxação
                    {
                        distances[neighbor] = newDistance;
                        predecessors[neighbor] = currentVertex;
                    }
                }
            }

            // Monta a árvore resultnte 
            var dijkstraGraph = new Graph(IsDirectGraph);


            foreach (var vertex in Vertices)
            {
                dijkstraGraph.AddVertex(vertex.Name);
            }

            foreach (var vertex in Vertices)
            {
                if (predecessors[vertex.Name] != null)
                {
                    var predecessor = predecessors[vertex.Name];
                    var weight = distances[vertex.Name];
                    dijkstraGraph.AddEdge(predecessor, vertex.Name, weight);
                }
            }

            return dijkstraGraph;
        }

        #endregion







        #region DisjointSetClass
        // Classe para representar um conjunto disjunto
        private class DisjointSet
        {
            private Dictionary<string, string> _parent;

            public DisjointSet(string[] elements)
            {
                _parent = new Dictionary<string, string>();
                foreach (var element in elements)
                {
                    _parent[element] = element; // Inicialmente, cada elemento é seu próprio pai
                }
            }

            public string Find(string element)
            {
                if (_parent[element] != element)
                {
                    _parent[element] = Find(_parent[element]); // Atualiza o pai para otimização (path compression)
                }
                return _parent[element];
            }

            public void Union(string element1, string element2)
            {
                string root1 = Find(element1);
                string root2 = Find(element2);
                if (root1 != root2)
                {
                    _parent[root1] = root2; // Atualiza o pai de uma árvore para apontar para a raiz da outra árvore
                }
            }
        }
        #endregion

        #region PriorityQueueClass

        // Classe para representar uma fila de prioridade
        private class PriorityQueue<T>
        {
            private SortedDictionary<int, Queue<T>> _dictionary;

            public int Count
            {
                get
                {
                    int count = 0;
                    foreach (var queue in _dictionary.Values)
                    {
                        count += queue.Count;
                    }
                    return count;
                }
            }

            public PriorityQueue()
            {
                _dictionary = new SortedDictionary<int, Queue<T>>();
            }

            public void Enqueue(T item, int priority)
            {
                if (!_dictionary.ContainsKey(priority))
                {
                    _dictionary[priority] = new Queue<T>();
                }
                _dictionary[priority].Enqueue(item);
            }

            public T Dequeue()
            {
                if (_dictionary.Count == 0)
                {
                    throw new InvalidOperationException("Priority queue is empty.");
                }
                var queue = _dictionary[_dictionary.Keys.First()];
                T item = queue.Dequeue();
                if (queue.Count == 0)
                {
                    _dictionary.Remove(_dictionary.Keys.First());
                }
                return item;
            }
        }
        #endregion

    }
}
