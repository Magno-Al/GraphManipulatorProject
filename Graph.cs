using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

                //AdjacencyMatrix[row, col] += 1;

                // if (!IsDirectGraph)
                // AdjacencyMatrix[col, row] += 1;

                // Aqui, você pode definir o peso na matriz de adjacência
                AdjacencyMatrix[row, col] = edge.Weight ?? 1; // Defina o peso como 1 se for nulo

                if (!IsDirectGraph)
                    AdjacencyMatrix[col, row] = edge.Weight ?? 1; // Defina o peso como 1 se for nulo
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

            Dictionary<string, bool> visited = new Dictionary<string, bool>(); // Dicionário para armazenar se um vértice foi visitado e sua cor (true/false)
            Dictionary<string, bool> colors = new Dictionary<string, bool>(); // Dicionário para armazenar as cores dos vértices (true/false)

            foreach (var vertex in Vertices) // Inicializar todos os vértices como não visitados
            {
                visited[vertex.Name] = false;
                colors[vertex.Name] = false;
            }

            
            foreach (var vertex in Vertices) // Percorrer todos os vértices
            {
                if (!visited[vertex.Name]) // Se o vértice ainda não foi visitado
                {
                    Queue<string> queue = new Queue<string>(); // Fila para realizar a travessia em largura (BFS)
                    queue.Enqueue(vertex.Name); // Adicionar o vértice à fila
                    colors[vertex.Name] = true; // Colorir o vértice com a cor verdadeira

                    while (queue.Count > 0) // Enquanto a fila não estiver vazia
                    {
                        string currentVertex = queue.Dequeue(); // Remover o vértice da frente da fila

                        foreach (var (neighbor, weight) in AdjacencyList[currentVertex]) // Para cada vizinho do vértice atual
                        {
                            if (!visited[neighbor]) // Se o vizinho não foi visitado
                            {
                                visited[neighbor] = true; // Marcar o vizinho como visitado
                                colors[neighbor] = !colors[currentVertex]; // Atribuir ao vizinho a cor oposta ao do vértice atual
                                queue.Enqueue(neighbor); // Adicionar o vizinho à fila
                            }
                            else if (colors[neighbor] == colors[currentVertex]) // Se o vizinho já foi visitado e tem a mesma cor do vértice atual
                            {
                                return false; // O grafo não é bipartido, pois existe uma aresta entre vértices com a mesma cor
                            }
                        }
                    }
                }
            }

            return true; // Se todas as arestas foram verificadas e nenhum conflito de cor foi encontrado, o grafo é bipartido
        }

        // Deep Search with target retuning path
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
        // teste
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



        // Função recursiva para busca em profundidade
        private void DepthSearchUtil(string vertex, Dictionary<string, bool> visited, List<string> visitedVertices, int currentCost)
        {
            // Marca o vértice atual como visitado e o imprime
            visited[vertex] = true;
            visitedVertices.Add(vertex);

            // Percorre todos os vértices adjacentes ao vértice atual
            foreach (var (adjacentVertex, weight) in AdjacencyList[vertex])
            {
                if (!visited[adjacentVertex])
                {
                    DepthSearchUtil(adjacentVertex, visited, visitedVertices, currentCost + weight);
                }
            }
        }

        // Função para realizar busca em profundidade
        public List<string> DepthSearch()
        {
            List<string> visitedVertices = new List<string>();

            // Inicializa todos os vértices como não visitados
            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            foreach (var vertex in Vertices)
            {
                visited[vertex.Name] = false;
            }

            // Executa a DFS a partir de todos os vértices não visitados
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


        //Função para realizar busca em largura partindo de um vertice especifico
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

        //Função para realizar busca em largura partindo de um vertice aleatorio
        public List<string> BreadthSearch()
        {
            List<string> visitedVertices = new List<string>();
            Queue<(string, int)> queue = new Queue<(string, int)>();

            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            foreach (var vertex in Vertices)
            {
                visited[vertex.Name] = false;
            }

            // Escolhe um vértice aleatório para começar a BFS
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

        //Funçao para realizar ordenação topologica
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

        //Função recursiva para realizar a ordenação topologica
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

        // Verifica se o grafo é conexo utilizando busca em largura ou busca em profundidade
        public bool IsConnectedGraph()
        {

            // Realiza a busca em largura (BFS) ou busca em profundidade (DFS)
            List<string> visitedVertices;
            if (!IsDirectGraph)
            {
                visitedVertices = BreadthSearch();
            }
            else
            {
                visitedVertices = DepthSearch();
            }

            // Verifica se todos os vértices foram visitados
            bool isConected = visitedVertices.Count == Vertices.Count;
            return isConected;
        }

        public void KruskalMST()
        {
            List<Edge> mst = new List<Edge>(); // Árvore Geradora Mínima
            DisjointSet disjointSet = new DisjointSet(Vertices.Select(v => v.Name).ToArray()); // Conjunto Disjunto para detectar ciclos

            // Ordena todas as arestas em ordem crescente de peso
            List<Edge> sortedEdges = Edges.OrderBy(e => e.Weight).ToList();

            foreach (var edge in sortedEdges)
            {
                string predecessorSet = disjointSet.Find(edge.Predecessor.Name);
                string successorSet = disjointSet.Find(edge.Successor.Name);

                // Verifica se a inclusão da aresta não cria um ciclo
                if (predecessorSet != successorSet)
                {
                    mst.Add(edge); // Adiciona a aresta à Árvore Geradora Mínima
                    disjointSet.Union(predecessorSet, successorSet); // Une os conjuntos dos vértices conectados pela aresta
                }
            }

            Console.Write(mst.ToString());
            // return mst;
        }

        public void PrimMST()
        {
            List<Edge> mst = new List<Edge>(); // Árvore Geradora Mínima
            HashSet<string> visited = new HashSet<string>(); // Conjunto de vértices já visitados
            PriorityQueue<Edge> priorityQueue = new PriorityQueue<Edge>(); // Fila de prioridade para arestas

            // Seleciona um vértice inicial (pode ser qualquer um)
            string startVertex = Vertices[0].Name;

            // Adiciona o vértice inicial ao conjunto de visitados
            visited.Add(startVertex);

            // Adiciona todas as arestas conectadas ao vértice inicial à fila de prioridade
            foreach (var edge in Edges)
            {
                if (edge.Predecessor.Name == startVertex || edge.Successor.Name == startVertex)
                {
                    priorityQueue.Enqueue(edge, edge.Weight ?? 1);
                }
            }

            while (priorityQueue.Count > 0)
            {
                // Obtém a aresta de menor peso da fila de prioridade
                Edge minEdge = priorityQueue.Dequeue();

                // Verifica se a aresta forma um ciclo (verifica se o vértice de destino já foi visitado)
                if (visited.Contains(minEdge.Predecessor.Name) && visited.Contains(minEdge.Successor.Name))
                {
                    continue;
                }

                // Adiciona a aresta à Árvore Geradora Mínima
                mst.Add(minEdge);

                // Adiciona o vértice de destino ao conjunto de visitados
                string nextVertex = visited.Contains(minEdge.Predecessor.Name) ? minEdge.Successor.Name : minEdge.Predecessor.Name;
                visited.Add(nextVertex);

                // Adiciona todas as arestas conectadas ao vértice adicionado à fila de prioridade
                foreach (var edge in Edges)
                {
                    if (edge.Predecessor.Name == nextVertex || edge.Successor.Name == nextVertex)
                    {
                        priorityQueue.Enqueue(edge, edge.Weight ?? 1);
                    }
                }
            }

            Console.Write(mst.ToString());

            // return mst;
        }

        public (List<string> path, int totalWeight) DijkstraShortestPath(string startVertex, string endVertex)
        {
            Dictionary<string, int> distances = new Dictionary<string, int>(); // Dicionário para armazenar as distâncias mínimas até cada vértice
            Dictionary<string, string> previousVertices = new Dictionary<string, string>(); // Dicionário para armazenar os vértices anteriores no caminho mínimo
            HashSet<string> visited = new HashSet<string>(); // Conjunto de vértices já visitados
            PriorityQueue<string> priorityQueue = new PriorityQueue<string>(); // Fila de prioridade para vértices

            // Inicializa as distâncias com infinito e o vértice anterior como nulo para todos os vértices, exceto o vértice inicial
            foreach (var vertex in Vertices)
            {
                distances[vertex.Name] = int.MaxValue;
                previousVertices[vertex.Name] = null;
            }
            distances[startVertex] = 0; // Distância até o vértice inicial é 0

            // Adiciona o vértice inicial à fila de prioridade
            priorityQueue.Enqueue(startVertex, 0);

            while (priorityQueue.Count > 0)
            {
                string currentVertex = priorityQueue.Dequeue(); // Remove o vértice com a menor distância da fila de prioridade

                if (currentVertex == endVertex)
                {
                    // Chegamos ao vértice de destino, construímos o caminho mínimo e o retornamos junto com o peso total do caminho
                    List<string> shortestPath = new List<string>();
                    int totalWeight = distances[endVertex];
                    while (previousVertices[currentVertex] != null)
                    {
                        shortestPath.Add(currentVertex);
                        currentVertex = previousVertices[currentVertex];
                    }
                    shortestPath.Add(startVertex);
                    shortestPath.Reverse(); // Reverte a lista para obter o caminho na ordem correta
                    return (shortestPath, totalWeight);
                }

                if (visited.Contains(currentVertex))
                {
                    continue; // Se o vértice já foi visitado, passa para o próximo vértice
                }

                visited.Add(currentVertex); // Marca o vértice como visitado

                // Atualiza as distâncias dos vértices adjacentes
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

            return (null, 0); // Se o caminho não for encontrado, retorna null e peso total 0
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
