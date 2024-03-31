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
        public Dictionary<string, List<string>> AdjacencyList { get; private set; }
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
            AdjacencyList = new Dictionary<string, List<string>>();
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

                AdjacencyMatrix[row, col] += 1;

                if (!IsDirectGraph)
                    AdjacencyMatrix[col, row] += 1;
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

            foreach (var vertex in Vertices) // Inicializar todos os vértices como não visitados
            {
                visited[vertex.Name] = false;
            }

            Dictionary<string, bool> colors = new Dictionary<string, bool>(); // Dicionário para armazenar as cores dos vértices (true/false)

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

                        foreach (var neighbor in AdjacencyList[currentVertex]) // Para cada vizinho do vértice atual
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

            AdjacencyList.Add(newVertex.Name, new List<string>());
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
        private bool AddEdge(Vertex predecessorVertex, Vertex successorVertex)
        {
            if (predecessorVertex != null && successorVertex != null)
            {
                string edgeName = "e" + Edges.Count;
                Edges.Add(new Edge(edgeName, predecessorVertex, successorVertex));

                AdjacencyList[predecessorVertex.Name].Add(successorVertex.Name);
                if (!IsDirectGraph && predecessorVertex.Name != successorVertex.Name) AdjacencyList[successorVertex.Name].Add(predecessorVertex.Name);

                UpdateAdjacencyMatrix();

                return true;
            }

            return false;
        }

        public bool AddEdge(string predecessorVertexName, string successorVertexName)
        {
            return AddEdge(Vertices[GetVertexIndexInVertices(predecessorVertexName)], Vertices[GetVertexIndexInVertices(successorVertexName)]);
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

                UpdateAdjacencyMatrix();
                AdjacencyList[predecessorVertexName].Remove(successorVertexName);
                if (!IsDirectGraph && predecessorVertexName != successorVertexName) AdjacencyList[successorVertexName].Remove(predecessorVertexName);

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

            public Edge(string name, Vertex predecessor, Vertex successor)
            {
                Name = name;
                Predecessor = predecessor;
                Successor = successor;
            }
        }
        #endregion
    }
}
