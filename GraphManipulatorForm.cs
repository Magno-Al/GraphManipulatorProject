using System.Data;
using System.Globalization;

namespace GraphManipulator
{
    public partial class GraphManipulatorForm : Form
    {
        private Graph graph { get; set; }
        public GraphManipulatorForm()
        {
            InitializeComponent();
        }

        #region Methods
        private void resetVertecesControls(bool turnOn)
        {
            btn_av_addVertex.Enabled = turnOn;

            cb_rv_selectVertex.Enabled = turnOn;
        }

        private void ResetEdgesSelectionComboBox()
        {
            if (graph.GetAllVerticesNames().Count > 0)
            {
                cb_selectPredecessorEdge.Enabled = true;
                cb_selectSucessorEdge.Enabled = true;
            }
            else
            {
                cb_selectPredecessorEdge.Enabled = false;
                cb_selectSucessorEdge.Enabled = false;
            }
        }

        private void ResetLabels()
        {

        }

        private void ResetSelectVertexComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(graph.GetAllVerticesNames().ToArray());
        }

        private void ResetAddEdgeButton()
        {
            if ((cb_selectPredecessorEdge.Text != null && cb_selectPredecessorEdge.Text != "") &&
                (cb_selectSucessorEdge.Text != null && cb_selectSucessorEdge.Text != ""))
            {
                btn_addEdge.Enabled = true;
            }
            else
            {
                btn_addEdge.Enabled = false;
            }
        }

        private void ResetRemoveEdgeButton()
        {
            if ((cb_selectPredecessorEdge.Text != null && cb_selectPredecessorEdge.Text != "") &&
                (cb_selectSucessorEdge.Text != null && cb_selectSucessorEdge.Text != ""))
            {
                var indexPredecessor = graph.GetAllVerticesNames().IndexOf(cb_selectPredecessorEdge.Text);
                var indexSuccessor = graph.GetAllVerticesNames().IndexOf(cb_selectSucessorEdge.Text);

                if (graph.AdjacencyMatrix[indexPredecessor, indexSuccessor] != 0)
                {
                    btn_removeEdge.Enabled = true;
                }
            }
            else
            {
                btn_removeEdge.Enabled = false;
            }
        }

        private void UpdateDgvAdjacencyList()
        {
            dgv_adjacencyList.Columns.Clear();
            dgv_adjacencyList.Rows.Clear();

            foreach (var vertex in graph.AdjacencyList.Keys)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = vertex;
                dgv_adjacencyList.Columns.Add(column);
            }

            int columnIndex = 0;
            foreach (var vertex in graph.AdjacencyList.Keys)
            {
                int rowIndex = 0;

                foreach (var neighbor in graph.AdjacencyList[vertex])
                {

                    if (dgv_adjacencyList.Rows.Count < rowIndex + 1)
                        dgv_adjacencyList.Rows.Add();

                    dgv_adjacencyList.Rows[rowIndex].Cells[columnIndex].Value = neighbor;


                    rowIndex++;

                }
                columnIndex++;
            }

            UpdateGraphAttributes();
        }

        private void UpdateDgvAdjacencyMatrix()
        {
            dgv_adjacencyMatrix.Columns.Clear();
            dgv_adjacencyMatrix.Rows.Clear();

            int columnIndex = 0;
            foreach (var vertex in graph.GetAllVerticesNames())
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = vertex;

                dgv_adjacencyMatrix.Columns.Add(column);
                dgv_adjacencyMatrix.Rows.Add();
                dgv_adjacencyMatrix.Rows[columnIndex].HeaderCell.Value = vertex;

                columnIndex++;
            }

            for (int i = 0; i < graph.AdjacencyMatrix.GetLength(1); i++)
            {
                for (int j = 0; j < graph.AdjacencyMatrix.GetLength(0); j++)
                {
                    dgv_adjacencyMatrix.Rows[i].Cells[j].Value = graph.AdjacencyMatrix[i, j];
                }
            }
            UpdateGraphAttributes();
        }

        private void UpdateGraphAttributes()
        {
            lb_ResultSimpleGraph.Text = graph.IsSimpleGraph() ? "Grafo é simples" : "Grafo não é simples";
            lb_ResultRegularGraph.Text = graph.IsRegularGraph() ? "Grafo é regular" : "Grafo não é regular";
            lb_ResultCompleteGraph.Text = graph.IsCompleteGraph() ? "Grafo é completo" : "Grafo não é completo";
            lb_ResultBipartiteGraph.Text = graph.IsBipartiteGraph() ? "Grafo é bipartido" : "Grafo não é bipartido";
        }

        #endregion

        #region Events
        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (btn_Start.Text == "Start")
            {
                chb_directedGraph.Enabled = false;

                dgv_adjacencyList.Columns.Clear();
                dgv_adjacencyList.Rows.Clear();
                dgv_adjacencyMatrix.Columns.Clear();
                dgv_adjacencyMatrix.Rows.Clear();
                graph = new Graph(chb_directedGraph.Checked);

                nup_InitialVertexAmount.Enabled = true;
                btn_GenerateGraph.Enabled = true;

                lb_ResultSimpleGraph.Visible = true;
                lb_ResultBipartiteGraph.Visible = true;
                lb_ResultCompleteGraph.Visible = true;
                lb_ResultRegularGraph.Visible = true;

                nup_InitialVertexAmount.Enabled = true;
                btn_GenerateGraph.Enabled = true;

                if (chb_directedGraph.Checked)
                {
                    lb_Predecessor.Visible = true;
                    lb_Successor.Visible = true;
                    lb_Entrace.Visible = true;
                    lb_Exit.Visible = true;

                    lb_ResultVertexDegree.Visible = false;

                    lb_ResultInVertexDegree.Visible = true;
                    lb_ResultOutVertexDegree.Visible = true;
                    lb_ResultPredecessorNeighborhood.Visible = true;
                    lb_ResultSuccessorNeighborhood.Visible = true;
                    lb_Neighborhood.Visible = false;
                }
                else
                {
                    lb_Predecessor.Visible = false;
                    lb_Successor.Visible = false;
                    lb_Entrace.Visible = false;
                    lb_Exit.Visible = false;

                    lb_ResultVertexDegree.Visible = true;

                    lb_ResultInVertexDegree.Visible = false;
                    lb_ResultOutVertexDegree.Visible = false;
                    lb_ResultPredecessorNeighborhood.Visible = false;
                    lb_ResultSuccessorNeighborhood.Visible = false;
                    lb_Neighborhood.Visible = true;
                }

                btn_Start.Text = "Reset";
            }
            else if (btn_Start.Text == "Reset")
            {
                chb_directedGraph.Checked = false;
                chb_directedGraph.Enabled = true;
                btn_Start.Text = "Start";

                nup_InitialVertexAmount.Value = 1;
                nup_InitialVertexAmount.Enabled = false;

                btn_GenerateGraph.Enabled = false;

                btn_av_addVertex.Enabled = false;

                lb_ResultVertexDegree.Visible = false;

                lb_Entrace.Visible = false;
                lb_Exit.Visible = false;
                lb_ResultInVertexDegree.Visible = false;
                lb_ResultOutVertexDegree.Visible = false;

                lb_Predecessor.Visible = false;
                lb_Successor.Visible = false;
                lb_ResultPredecessorNeighborhood.Visible = false;
                lb_ResultSuccessorNeighborhood.Visible = false;
                lb_Neighborhood.Visible = false;

                lb_ResultSimpleGraph.Visible = false;
                lb_ResultBipartiteGraph.Visible = false;
                lb_ResultCompleteGraph.Visible = false;
                lb_ResultRegularGraph.Visible = false;


                cb_VertexNeighborhood.Enabled = false;
                cb_VertexNeighborhood.Items.Clear();
                cb_rv_selectVertex.Enabled = false;
                cb_rv_selectVertex.Items.Clear();
                cb_selectPredecessorEdge.Items.Clear();
                cb_selectSucessorEdge.Items.Clear();

                nup_InitialVertexAmount.Enabled = false;
                btn_GenerateGraph.Enabled = false;

                lb_vertexReturn.Text = "";
                lb_edgeReturn.Text = "";

            }

        }

        private void btn_av_addVertex_Click(object sender, EventArgs e)
        {
            if (cb_av_selectVertex.Text != "" && cb_av_selectVertex.Text != null)
            {
                graph.AddVertex(cb_av_selectVertex.Text);

                lb_vertexReturn.Text = $"Vertice {cb_av_selectVertex.Text} adicionado";

                ResetSelectVertexComboBox(cb_av_selectVertex);

                UpdateDgvAdjacencyList();
                UpdateDgvAdjacencyMatrix();
                ResetEdgesSelectionComboBox();
            }

            btn_av_addVertex.Enabled = false;
        }

        private void cb_rv_selectVertex_DropDown(object sender, EventArgs e)
        {
            ResetSelectVertexComboBox(cb_rv_selectVertex);
        }

        private void btn_rv_removeVertex_Click(object sender, EventArgs e)
        {
            if (graph.GetAllVerticesNames().Count == 1)
            {
                lb_vertexReturn.Text = $"Vertice {cb_rv_selectVertex.Text} não pode ser removido pois é o unico vertice do grafo";
                MessageBox.Show($"Vertice {cb_rv_selectVertex.Text} não pode ser removido pois é o unico vertice do grafo");
            }
            else if (graph.GetDegreeVertexNonDirectedGraph(cb_rv_selectVertex.Text) != 0 ||
                graph.GetEntraceDegreeVertexDirectedGraph(cb_rv_selectVertex.Text) != 0 ||
                graph.GetExitDegreeVertexDirectedGraph(cb_rv_selectVertex.Text) != 0)
            {
                lb_vertexReturn.Text = $"Vertice {cb_rv_selectVertex.Text} não pode ser removido pois contem aresta(s)";
                MessageBox.Show($"Vertice {cb_rv_selectVertex.Text} não pode ser removido pois contem aresta(s)");
            }
            else if (graph.RemoveVertex(cb_rv_selectVertex.Text))
            {
                lb_vertexReturn.Text = $"Vertice {cb_rv_selectVertex.Text} removido";

                ResetSelectVertexComboBox(cb_rv_selectVertex);

                UpdateDgvAdjacencyList();
                UpdateDgvAdjacencyMatrix();
                ResetEdgesSelectionComboBox();
            }

            btn_rv_removeVertex.Enabled = false;
        }

        private void cb_selectPredecessorEdge_DropDown(object sender, EventArgs e)
        {
            ResetSelectVertexComboBox(cb_selectPredecessorEdge);
            ResetAddEdgeButton();
            ResetRemoveEdgeButton();
        }

        private void cb_selectSucessorEdge_DropDown(object sender, EventArgs e)
        {
            ResetSelectVertexComboBox(cb_selectSucessorEdge);
            ResetAddEdgeButton();
            ResetRemoveEdgeButton();
        }

        private void cb_selectPredecessorEdge_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetAddEdgeButton();
            ResetRemoveEdgeButton();
        }

        private void cb_selectSucessorEdge_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetAddEdgeButton();
            ResetRemoveEdgeButton();
        }

        private void btn_addEdge_Click(object sender, EventArgs e)
        {
            if (cb_selectPredecessorEdge.Text == null || cb_selectPredecessorEdge.Text == "")
            {
                lb_vertexReturn.Text = "Vertice predecessor invalido";
            }
            else if (cb_selectSucessorEdge.Text == null || cb_selectSucessorEdge.Text == "")
            {
                lb_vertexReturn.Text = "Vertice sucessor invalido";
            }
            else
            {
                int? weight = null; // Inicialize o peso como null
                if (!string.IsNullOrEmpty(cb_inputSucessorEdge.Text))
                {
                    // Tente converter o valor do campo de entrada de texto em um número inteiro
                    if (!int.TryParse(cb_inputSucessorEdge.Text, out int tempWeight))
                    {
                        // Se a conversão falhar, exiba uma mensagem de erro
                        MessageBox.Show("Por favor, insira um valor válido para o peso.");
                        return;
                    }
                    weight = tempWeight; // Atribua o valor convertido à variável de peso
                }
                if (graph.AddEdge(cb_selectPredecessorEdge.Text, cb_selectSucessorEdge.Text, weight))
                {
                    lb_edgeReturn.Text = $"Aresta {{{cb_selectPredecessorEdge.Text}, {cb_selectSucessorEdge.Text}}} adicionada";

                    ResetSelectVertexComboBox(cb_selectPredecessorEdge);
                    ResetSelectVertexComboBox(cb_selectSucessorEdge);
                    ResetSelectVertexComboBox(cb_VertexNeighborhood);

                    lb_ResultVertexDegree.Text = "";
                    lb_Neighborhood.Text = "";
                    lb_ResultPredecessorNeighborhood.Text = "";
                    lb_ResultSuccessorNeighborhood.Text = "";

                    lb_ResultInVertexDegree.Text = "";
                    lb_ResultOutVertexDegree.Text = "";

                    UpdateDgvAdjacencyList();
                    UpdateDgvAdjacencyMatrix();
                }
                else
                {
                    lb_edgeReturn.Text = $"Erro ao adicionar aresta";
                }
            }
        }

        private void btn_removeEdge_Click(object sender, EventArgs e)
        {
            if (cb_selectPredecessorEdge.Text == null || cb_selectPredecessorEdge.Text == "")
            {
                lb_vertexReturn.Text = "Vertice predecessor invalido";
            }
            else if (cb_selectSucessorEdge.Text == null || cb_selectSucessorEdge.Text == "")
            {
                lb_vertexReturn.Text = "Vertice sucessor invalido";
            }
            else
            {
                if (graph.RemoveEdge(cb_selectPredecessorEdge.Text, cb_selectSucessorEdge.Text))
                {
                    lb_edgeReturn.Text = $"Aresta {{{cb_selectPredecessorEdge.Text}, {cb_selectSucessorEdge.Text}}} removida";

                    ResetSelectVertexComboBox(cb_selectPredecessorEdge);
                    ResetSelectVertexComboBox(cb_selectSucessorEdge);
                    ResetSelectVertexComboBox(cb_VertexNeighborhood);

                    lb_ResultVertexDegree.Text = "";
                    lb_Neighborhood.Text = "";
                    lb_ResultPredecessorNeighborhood.Text = "";
                    lb_ResultSuccessorNeighborhood.Text = "";

                    lb_ResultInVertexDegree.Text = "";
                    lb_ResultOutVertexDegree.Text = "";

                    UpdateDgvAdjacencyList();
                    UpdateDgvAdjacencyMatrix();
                }
                else
                {
                    lb_edgeReturn.Text = $"Erro ao remover aresta";
                }
            }
        }

        private void btn_GenerateGraph_Click(object sender, EventArgs e)
        {
            int letter = 65;

            for (int i = 0; i < nup_InitialVertexAmount.Value; i++)
            {
                graph.AddVertex(((char)letter).ToString());
                letter++;
            }

            UpdateDgvAdjacencyList();
            UpdateDgvAdjacencyMatrix();
            lb_vertexReturn.Text = $"Um grafo com {letter - 65} verticies foi criado.";

            cb_av_selectVertex.Enabled = true;
            cb_rv_selectVertex.Enabled = true;

            nup_InitialVertexAmount.Enabled = false;
            btn_GenerateGraph.Enabled = false;
            cb_VertexNeighborhood.Enabled = true;

            lb_ResultSimpleGraph.Enabled = true;
            lb_ResultBipartiteGraph.Enabled = true;
            lb_ResultCompleteGraph.Enabled = true;
            lb_ResultRegularGraph.Enabled = true;

            ResetEdgesSelectionComboBox();
        }

        private void btn_debug_Click(object sender, EventArgs e)
        {
            var test = graph;
        }

        private void cb_VertexNeighborhood_DropDown(object sender, EventArgs e)
        {
            ResetSelectVertexComboBox(cb_VertexNeighborhood);
        }

        private void cb_av_selectVertex_DropDown(object sender, EventArgs e)
        {
            cb_av_selectVertex.Items.Clear();

            char letter;
            for (int i = 65; i <= 90; i++)
            {
                letter = (char)i;
                if (!graph.GetAllVerticesNames().Contains(letter.ToString()))
                    cb_av_selectVertex.Items.Add(((char)i).ToString());
            }
        }

        private void cb_av_selectVertex_TextChanged(object sender, EventArgs e)
        {
            if (cb_av_selectVertex.Text != null && cb_av_selectVertex.Text != "")
                btn_av_addVertex.Enabled = true;
            else
                btn_av_addVertex.Enabled = false;
        }

        private void cb_rv_selectVertex_TextChanged(object sender, EventArgs e)
        {
            if (cb_rv_selectVertex.Text != null && cb_rv_selectVertex.Text != "")
                btn_rv_removeVertex.Enabled = true;
            else
                btn_rv_removeVertex.Enabled = false;
        }

        private void cb_VertexNeighborhood_TextChanged(object sender, EventArgs e)
        {
            if (graph.IsDirectGraph)
            {
                lb_ResultPredecessorNeighborhood.Text = graph.GetVertexPredecessors(cb_VertexNeighborhood.Text);
                lb_ResultSuccessorNeighborhood.Text = graph.GetVertexNeighborhood(cb_VertexNeighborhood.Text);

                lb_ResultInVertexDegree.Text = graph.GetEntraceDegreeVertexDirectedGraph(cb_VertexNeighborhood.Text).ToString();
                lb_ResultOutVertexDegree.Text = graph.GetExitDegreeVertexDirectedGraph(cb_VertexNeighborhood.Text).ToString();
            }
            else
            {
                lb_ResultVertexDegree.Text = graph.GetDegreeVertexNonDirectedGraph(cb_VertexNeighborhood.Text).ToString();
                lb_Neighborhood.Text = graph.GetVertexNeighborhood(cb_VertexNeighborhood.Text);
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            graph.DepthSearch();
            graph.DeepSearch("A", "F");
            graph.BreadthSearch("A");
            graph.BreadthSearch();

            Graph subgraph = new Graph(graph.IsDirectGraph);

            

            lbl_TopologicalOrdering.Text = "";
            var topologicalOrdering = graph.TopologicalSort();

            foreach (var t in topologicalOrdering)
            {
                lbl_TopologicalOrdering.Text += t.ToString() + " ";
            }

            bool isConnected = graph.IsConnectedGraph();

            lbl_isConected.Text = "";
            lbl_isConected.Text = isConnected ? "Grafo é Conexo" : "Grafo não conexo";
            if (isConnected)
            {
                //var subgraph = graph.KruskalMST();
                //UpdateDgvMSTAdjacencyList(subgraph);

                subgraph = graph.MSTPrim("A");
                UpdateDgvMSTAdjacencyList(subgraph);

                subgraph = graph.Dijkstra("A");
                UpdateDgvDijkstraAdjacencyList(subgraph);



                var path = graph.DijkstraShortestPath("A", "C");
                lbl_MinPath.Text = "";
                foreach (var p in path.path)
                {
                    lbl_MinPath.Text += p.ToString() + " ";
                }
                lbl_TotalWeight.Text = "Total path: " + path.totalWeight;
            }
        }

        private void cb_inputSucessorEdge_TextChanged(object sender, KeyPressEventArgs e)
        {
            // Verificar se a tecla pressionada não é um número ou uma tecla de controle
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Se não for um número, cancelar a entrada de teclado
                e.Handled = true;
            }
        }

        // apagar depois
        private void UpdateDgvMSTAdjacencyList(Graph graph)
        {
            // Limpar colunas e linhas
            gdv_MST.Columns.Clear();
            gdv_MST.Rows.Clear();

            // Adicionar cabeçalhos de coluna (vértices)
            foreach (var vertex in graph.AdjacencyList.Keys)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = vertex;
                gdv_MST.Columns.Add(column);
            }

            // Adicionar cabeçalhos de linha
            foreach (var vertex in graph.AdjacencyList.Keys)
            {
                DataGridViewRow row = new DataGridViewRow();
                //row.HeaderCell.Value = vertex;
                gdv_MST.Rows.Add(row);
            }

            // Preencher células com os vizinhos de cada vértice
            int columnIndex = 0;
            foreach (var vertex in graph.AdjacencyList.Keys)
            {
                int rowIndex = 0;
                foreach (var neighbor in graph.AdjacencyList[vertex])
                {
                    gdv_MST.Rows[rowIndex].Cells[columnIndex].Value = $"{neighbor.Item1}, {neighbor.Item2}";
                    rowIndex++;
                }
                columnIndex++;
            }
        }


        private void UpdateDgvDijkstraAdjacencyList(Graph graph)
        {
            // Limpar colunas e linhas
            gdv_MST.Columns.Clear();
            gdv_MST.Rows.Clear();

            // Adicionar cabeçalhos de coluna (vértices)
            foreach (var vertex in graph.AdjacencyList.Keys)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = vertex;
                dgv_Dijkstra.Columns.Add(column);
            }

            // Adicionar cabeçalhos de linha
            foreach (var vertex in graph.AdjacencyList.Keys)
            {
                DataGridViewRow row = new DataGridViewRow();
                //row.HeaderCell.Value = vertex;
                dgv_Dijkstra.Rows.Add(row);
            }

            // Preencher células com os vizinhos de cada vértice
            int columnIndex = 0;
            foreach (var vertex in graph.AdjacencyList.Keys)
            {
                int rowIndex = 0;
                foreach (var neighbor in graph.AdjacencyList[vertex])
                {
                    dgv_Dijkstra.Rows[rowIndex].Cells[columnIndex].Value = $"{neighbor.Item1}, {neighbor.Item2}";
                    rowIndex++;
                }
                columnIndex++;
            }
        }

    }
}