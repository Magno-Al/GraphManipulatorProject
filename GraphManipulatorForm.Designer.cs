namespace GraphManipulator
{
    partial class GraphManipulatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgv_adjacencyMatrix = new DataGridView();
            btn_addEdge = new Button();
            btn_exhibitionModeList = new Button();
            btn_exhibitionModeMatrix = new Button();
            label1 = new Label();
            label3 = new Label();
            dgv_adjacencyList = new DataGridView();
            btn_av_addVertex = new Button();
            btn_removeEdge = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cb_rv_selectVertex = new ComboBox();
            label8 = new Label();
            btn_rv_removeVertex = new Button();
            label10 = new Label();
            panel2 = new Panel();
            cb_selectSucessorEdge = new ComboBox();
            cb_selectPredecessorEdge = new ComboBox();
            lb_edgeReturn = new Label();
            lb_vertexReturn = new Label();
            chb_directedGraph = new CheckBox();
            btn_Start = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            label9 = new Label();
            cb_av_selectVertex = new ComboBox();
            label7 = new Label();
            panel5 = new Panel();
            btn_GenerateGraph = new Button();
            nup_InitialVertexAmount = new NumericUpDown();
            label2 = new Label();
            btn_debug = new Button();
            cb_VertexNeighborhood = new ComboBox();
            label11 = new Label();
            lb_Neighborhood = new Label();
            lb_ResultSimpleGraph = new Label();
            lb_ResultRegularGraph = new Label();
            lb_ResultCompleteGraph = new Label();
            lb_ResultBipartiteGraph = new Label();
            label12 = new Label();
            label13 = new Label();
            lb_ResultVertexDegree = new Label();
            lb_Predecessor = new Label();
            lb_Successor = new Label();
            lb_ResultPredecessorNeighborhood = new Label();
            lb_ResultSuccessorNeighborhood = new Label();
            lb_Exit = new Label();
            lb_Entrace = new Label();
            lb_ResultInVertexDegree = new Label();
            lb_ResultOutVertexDegree = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_adjacencyMatrix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_adjacencyList).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nup_InitialVertexAmount).BeginInit();
            SuspendLayout();
            // 
            // dgv_adjacencyMatrix
            // 
            dgv_adjacencyMatrix.AllowUserToAddRows = false;
            dgv_adjacencyMatrix.AllowUserToDeleteRows = false;
            dgv_adjacencyMatrix.AllowUserToResizeColumns = false;
            dgv_adjacencyMatrix.AllowUserToResizeRows = false;
            dgv_adjacencyMatrix.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_adjacencyMatrix.ColumnHeadersHeight = 34;
            dgv_adjacencyMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_adjacencyMatrix.Location = new Point(479, 123);
            dgv_adjacencyMatrix.Margin = new Padding(4, 5, 4, 5);
            dgv_adjacencyMatrix.Name = "dgv_adjacencyMatrix";
            dgv_adjacencyMatrix.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_adjacencyMatrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_adjacencyMatrix.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dgv_adjacencyMatrix.RowTemplate.Height = 25;
            dgv_adjacencyMatrix.Size = new Size(1323, 1222);
            dgv_adjacencyMatrix.TabIndex = 0;
            dgv_adjacencyMatrix.Visible = false;
            // 
            // btn_addEdge
            // 
            btn_addEdge.Enabled = false;
            btn_addEdge.Location = new Point(10, 152);
            btn_addEdge.Margin = new Padding(4, 5, 4, 5);
            btn_addEdge.Name = "btn_addEdge";
            btn_addEdge.Size = new Size(334, 38);
            btn_addEdge.TabIndex = 4;
            btn_addEdge.Text = "Adicionar aresta";
            btn_addEdge.UseVisualStyleBackColor = true;
            btn_addEdge.Click += btn_addEdge_Click;
            // 
            // btn_exhibitionModeList
            // 
            btn_exhibitionModeList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_exhibitionModeList.Enabled = false;
            btn_exhibitionModeList.Location = new Point(1276, 17);
            btn_exhibitionModeList.Margin = new Padding(4, 5, 4, 5);
            btn_exhibitionModeList.Name = "btn_exhibitionModeList";
            btn_exhibitionModeList.Size = new Size(251, 38);
            btn_exhibitionModeList.TabIndex = 5;
            btn_exhibitionModeList.Text = "Lista de Adjacência";
            btn_exhibitionModeList.UseVisualStyleBackColor = true;
            btn_exhibitionModeList.Click += btn_exhibitionModeList_Click;
            // 
            // btn_exhibitionModeMatrix
            // 
            btn_exhibitionModeMatrix.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_exhibitionModeMatrix.Enabled = false;
            btn_exhibitionModeMatrix.Location = new Point(1537, 17);
            btn_exhibitionModeMatrix.Margin = new Padding(4, 5, 4, 5);
            btn_exhibitionModeMatrix.Name = "btn_exhibitionModeMatrix";
            btn_exhibitionModeMatrix.Size = new Size(251, 38);
            btn_exhibitionModeMatrix.TabIndex = 6;
            btn_exhibitionModeMatrix.Text = "Matriz de Adjacência";
            btn_exhibitionModeMatrix.UseVisualStyleBackColor = true;
            btn_exhibitionModeMatrix.Click += btn_exhibitionModeMatrix_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1050, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 32);
            label1.TabIndex = 7;
            label1.Text = "Modo de exibição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 22);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(203, 32);
            label3.TabIndex = 9;
            label3.Text = "Gerenciar Arestas:";
            // 
            // dgv_adjacencyList
            // 
            dgv_adjacencyList.AllowUserToAddRows = false;
            dgv_adjacencyList.AllowUserToDeleteRows = false;
            dgv_adjacencyList.AllowUserToResizeColumns = false;
            dgv_adjacencyList.AllowUserToResizeRows = false;
            dgv_adjacencyList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_adjacencyList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_adjacencyList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_adjacencyList.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_adjacencyList.Location = new Point(479, 123);
            dgv_adjacencyList.Margin = new Padding(4, 5, 4, 5);
            dgv_adjacencyList.Name = "dgv_adjacencyList";
            dgv_adjacencyList.ReadOnly = true;
            dgv_adjacencyList.RowHeadersVisible = false;
            dgv_adjacencyList.RowHeadersWidth = 20;
            dgv_adjacencyList.RowTemplate.Height = 25;
            dgv_adjacencyList.Size = new Size(1323, 1222);
            dgv_adjacencyList.TabIndex = 12;
            dgv_adjacencyList.Visible = false;
            // 
            // btn_av_addVertex
            // 
            btn_av_addVertex.Enabled = false;
            btn_av_addVertex.Location = new Point(260, 53);
            btn_av_addVertex.Margin = new Padding(4, 5, 4, 5);
            btn_av_addVertex.Name = "btn_av_addVertex";
            btn_av_addVertex.Size = new Size(111, 38);
            btn_av_addVertex.TabIndex = 13;
            btn_av_addVertex.Text = "Adicionar";
            btn_av_addVertex.UseVisualStyleBackColor = true;
            btn_av_addVertex.Click += btn_av_addVertex_Click;
            // 
            // btn_removeEdge
            // 
            btn_removeEdge.Enabled = false;
            btn_removeEdge.Location = new Point(10, 200);
            btn_removeEdge.Margin = new Padding(4, 5, 4, 5);
            btn_removeEdge.Name = "btn_removeEdge";
            btn_removeEdge.Size = new Size(334, 38);
            btn_removeEdge.TabIndex = 14;
            btn_removeEdge.Text = "Remover aresta";
            btn_removeEdge.UseVisualStyleBackColor = true;
            btn_removeEdge.Click += btn_removeEdge_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 65);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(111, 25);
            label4.TabIndex = 15;
            label4.Text = "Predecessor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(201, 65);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 16;
            label5.Text = "Sucessor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(30, 23);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(209, 32);
            label6.TabIndex = 21;
            label6.Text = "Gerenciar Vertices:";
            // 
            // cb_rv_selectVertex
            // 
            cb_rv_selectVertex.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_rv_selectVertex.Enabled = false;
            cb_rv_selectVertex.FormattingEnabled = true;
            cb_rv_selectVertex.Location = new Point(109, 165);
            cb_rv_selectVertex.Margin = new Padding(4, 5, 4, 5);
            cb_rv_selectVertex.Name = "cb_rv_selectVertex";
            cb_rv_selectVertex.Size = new Size(141, 33);
            cb_rv_selectVertex.TabIndex = 24;
            cb_rv_selectVertex.DropDown += cb_rv_selectVertex_DropDown;
            cb_rv_selectVertex.TextChanged += cb_rv_selectVertex_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 127);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(143, 25);
            label8.TabIndex = 25;
            label8.Text = "Remover Vertice:";
            // 
            // btn_rv_removeVertex
            // 
            btn_rv_removeVertex.Enabled = false;
            btn_rv_removeVertex.Location = new Point(260, 165);
            btn_rv_removeVertex.Margin = new Padding(4, 5, 4, 5);
            btn_rv_removeVertex.Name = "btn_rv_removeVertex";
            btn_rv_removeVertex.Size = new Size(111, 38);
            btn_rv_removeVertex.TabIndex = 25;
            btn_rv_removeVertex.Text = "Remover";
            btn_rv_removeVertex.UseVisualStyleBackColor = true;
            btn_rv_removeVertex.Click += btn_rv_removeVertex_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(39, 172);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(65, 25);
            label10.TabIndex = 25;
            label10.Text = "Nome:";
            // 
            // panel2
            // 
            panel2.Controls.Add(cb_selectSucessorEdge);
            panel2.Controls.Add(cb_selectPredecessorEdge);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btn_removeEdge);
            panel2.Controls.Add(btn_addEdge);
            panel2.Location = new Point(19, 77);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(430, 268);
            panel2.TabIndex = 28;
            // 
            // cb_selectSucessorEdge
            // 
            cb_selectSucessorEdge.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_selectSucessorEdge.Enabled = false;
            cb_selectSucessorEdge.FormattingEnabled = true;
            cb_selectSucessorEdge.Location = new Point(201, 95);
            cb_selectSucessorEdge.Margin = new Padding(4, 5, 4, 5);
            cb_selectSucessorEdge.Name = "cb_selectSucessorEdge";
            cb_selectSucessorEdge.Size = new Size(141, 33);
            cb_selectSucessorEdge.TabIndex = 27;
            cb_selectSucessorEdge.DropDown += cb_selectSucessorEdge_DropDown;
            cb_selectSucessorEdge.SelectedIndexChanged += cb_selectSucessorEdge_SelectedIndexChanged;
            // 
            // cb_selectPredecessorEdge
            // 
            cb_selectPredecessorEdge.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_selectPredecessorEdge.Enabled = false;
            cb_selectPredecessorEdge.FormattingEnabled = true;
            cb_selectPredecessorEdge.Location = new Point(11, 95);
            cb_selectPredecessorEdge.Margin = new Padding(4, 5, 4, 5);
            cb_selectPredecessorEdge.Name = "cb_selectPredecessorEdge";
            cb_selectPredecessorEdge.Size = new Size(141, 33);
            cb_selectPredecessorEdge.TabIndex = 26;
            cb_selectPredecessorEdge.DropDown += cb_selectPredecessorEdge_DropDown;
            cb_selectPredecessorEdge.SelectedIndexChanged += cb_selectPredecessorEdge_SelectedIndexChanged;
            // 
            // lb_edgeReturn
            // 
            lb_edgeReturn.AutoSize = true;
            lb_edgeReturn.ForeColor = Color.Firebrick;
            lb_edgeReturn.Location = new Point(19, 378);
            lb_edgeReturn.Margin = new Padding(4, 0, 4, 0);
            lb_edgeReturn.Name = "lb_edgeReturn";
            lb_edgeReturn.Size = new Size(0, 25);
            lb_edgeReturn.TabIndex = 28;
            // 
            // lb_vertexReturn
            // 
            lb_vertexReturn.AutoSize = true;
            lb_vertexReturn.ForeColor = Color.Firebrick;
            lb_vertexReturn.Location = new Point(19, 395);
            lb_vertexReturn.Margin = new Padding(4, 0, 4, 0);
            lb_vertexReturn.Name = "lb_vertexReturn";
            lb_vertexReturn.Size = new Size(0, 25);
            lb_vertexReturn.TabIndex = 29;
            // 
            // chb_directedGraph
            // 
            chb_directedGraph.AutoSize = true;
            chb_directedGraph.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chb_directedGraph.Location = new Point(17, 20);
            chb_directedGraph.Margin = new Padding(4, 5, 4, 5);
            chb_directedGraph.Name = "chb_directedGraph";
            chb_directedGraph.Size = new Size(234, 36);
            chb_directedGraph.TabIndex = 17;
            chb_directedGraph.Text = "Grafo Direcionado";
            chb_directedGraph.UseVisualStyleBackColor = true;
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(17, 67);
            btn_Start.Margin = new Padding(4, 5, 4, 5);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(107, 38);
            btn_Start.TabIndex = 30;
            btn_Start.Text = "Start";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lb_edgeReturn);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(13, 638);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(453, 668);
            panel3.TabIndex = 31;
            // 
            // panel4
            // 
            panel4.Controls.Add(label9);
            panel4.Controls.Add(cb_av_selectVertex);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(btn_rv_removeVertex);
            panel4.Controls.Add(btn_av_addVertex);
            panel4.Controls.Add(cb_rv_selectVertex);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(19, 163);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(430, 227);
            panel4.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 60);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(65, 25);
            label9.TabIndex = 28;
            label9.Text = "Nome:";
            // 
            // cb_av_selectVertex
            // 
            cb_av_selectVertex.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_av_selectVertex.Enabled = false;
            cb_av_selectVertex.FormattingEnabled = true;
            cb_av_selectVertex.Location = new Point(109, 55);
            cb_av_selectVertex.Margin = new Padding(4, 5, 4, 5);
            cb_av_selectVertex.Name = "cb_av_selectVertex";
            cb_av_selectVertex.Size = new Size(141, 33);
            cb_av_selectVertex.TabIndex = 27;
            cb_av_selectVertex.DropDown += cb_av_selectVertex_DropDown;
            cb_av_selectVertex.TextChanged += cb_av_selectVertex_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 25);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(148, 25);
            label7.TabIndex = 26;
            label7.Text = "Adicionar Vertice:";
            // 
            // panel5
            // 
            panel5.Controls.Add(btn_GenerateGraph);
            panel5.Controls.Add(nup_InitialVertexAmount);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(lb_vertexReturn);
            panel5.Location = new Point(17, 172);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(453, 457);
            panel5.TabIndex = 32;
            // 
            // btn_GenerateGraph
            // 
            btn_GenerateGraph.Enabled = false;
            btn_GenerateGraph.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_GenerateGraph.Location = new Point(279, 107);
            btn_GenerateGraph.Margin = new Padding(4, 5, 4, 5);
            btn_GenerateGraph.Name = "btn_GenerateGraph";
            btn_GenerateGraph.Size = new Size(136, 38);
            btn_GenerateGraph.TabIndex = 25;
            btn_GenerateGraph.Text = "Gerar grafo";
            btn_GenerateGraph.UseVisualStyleBackColor = true;
            btn_GenerateGraph.Click += btn_GenerateGraph_Click;
            // 
            // nup_InitialVertexAmount
            // 
            nup_InitialVertexAmount.Enabled = false;
            nup_InitialVertexAmount.Location = new Point(189, 107);
            nup_InitialVertexAmount.Margin = new Padding(4, 5, 4, 5);
            nup_InitialVertexAmount.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            nup_InitialVertexAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nup_InitialVertexAmount.Name = "nup_InitialVertexAmount";
            nup_InitialVertexAmount.Size = new Size(81, 31);
            nup_InitialVertexAmount.TabIndex = 33;
            nup_InitialVertexAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 110);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 25);
            label2.TabIndex = 25;
            label2.Text = "Número de vertices:";
            // 
            // btn_debug
            // 
            btn_debug.Location = new Point(524, 47);
            btn_debug.Margin = new Padding(4, 5, 4, 5);
            btn_debug.Name = "btn_debug";
            btn_debug.Size = new Size(107, 38);
            btn_debug.TabIndex = 33;
            btn_debug.Text = "DEBUG";
            btn_debug.UseVisualStyleBackColor = true;
            btn_debug.Visible = false;
            btn_debug.Click += btn_debug_Click;
            // 
            // cb_VertexNeighborhood
            // 
            cb_VertexNeighborhood.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cb_VertexNeighborhood.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_VertexNeighborhood.Enabled = false;
            cb_VertexNeighborhood.FormattingEnabled = true;
            cb_VertexNeighborhood.Location = new Point(570, 1373);
            cb_VertexNeighborhood.Margin = new Padding(4, 5, 4, 5);
            cb_VertexNeighborhood.Name = "cb_VertexNeighborhood";
            cb_VertexNeighborhood.Size = new Size(141, 33);
            cb_VertexNeighborhood.TabIndex = 28;
            cb_VertexNeighborhood.DropDown += cb_VertexNeighborhood_DropDown;
            cb_VertexNeighborhood.TextChanged += cb_VertexNeighborhood_TextChanged;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(1117, 1378);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(182, 25);
            label11.TabIndex = 34;
            label11.Text = "Vizinhança do vertice:";
            // 
            // lb_Neighborhood
            // 
            lb_Neighborhood.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lb_Neighborhood.AutoSize = true;
            lb_Neighborhood.Location = new Point(1300, 1378);
            lb_Neighborhood.Margin = new Padding(4, 0, 4, 0);
            lb_Neighborhood.Name = "lb_Neighborhood";
            lb_Neighborhood.Size = new Size(0, 25);
            lb_Neighborhood.TabIndex = 35;
            lb_Neighborhood.Visible = false;
            // 
            // lb_ResultSimpleGraph
            // 
            lb_ResultSimpleGraph.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lb_ResultSimpleGraph.AutoSize = true;
            lb_ResultSimpleGraph.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_ResultSimpleGraph.Location = new Point(524, 1468);
            lb_ResultSimpleGraph.Margin = new Padding(4, 0, 4, 0);
            lb_ResultSimpleGraph.Name = "lb_ResultSimpleGraph";
            lb_ResultSimpleGraph.Size = new Size(0, 40);
            lb_ResultSimpleGraph.TabIndex = 36;
            // 
            // lb_ResultRegularGraph
            // 
            lb_ResultRegularGraph.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lb_ResultRegularGraph.AutoSize = true;
            lb_ResultRegularGraph.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_ResultRegularGraph.Location = new Point(804, 1468);
            lb_ResultRegularGraph.Margin = new Padding(4, 0, 4, 0);
            lb_ResultRegularGraph.Name = "lb_ResultRegularGraph";
            lb_ResultRegularGraph.Size = new Size(0, 40);
            lb_ResultRegularGraph.TabIndex = 37;
            // 
            // lb_ResultCompleteGraph
            // 
            lb_ResultCompleteGraph.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lb_ResultCompleteGraph.AutoSize = true;
            lb_ResultCompleteGraph.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_ResultCompleteGraph.Location = new Point(1083, 1468);
            lb_ResultCompleteGraph.Margin = new Padding(4, 0, 4, 0);
            lb_ResultCompleteGraph.Name = "lb_ResultCompleteGraph";
            lb_ResultCompleteGraph.Size = new Size(0, 40);
            lb_ResultCompleteGraph.TabIndex = 38;
            // 
            // lb_ResultBipartiteGraph
            // 
            lb_ResultBipartiteGraph.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lb_ResultBipartiteGraph.AutoSize = true;
            lb_ResultBipartiteGraph.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_ResultBipartiteGraph.Location = new Point(1377, 1468);
            lb_ResultBipartiteGraph.Margin = new Padding(4, 0, 4, 0);
            lb_ResultBipartiteGraph.Name = "lb_ResultBipartiteGraph";
            lb_ResultBipartiteGraph.Size = new Size(0, 40);
            lb_ResultBipartiteGraph.TabIndex = 39;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(497, 1378);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(68, 25);
            label12.TabIndex = 40;
            label12.Text = "Vertice:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(721, 1378);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(136, 25);
            label13.TabIndex = 41;
            label13.Text = "Grau do vertice:";
            // 
            // lb_ResultVertexDegree
            // 
            lb_ResultVertexDegree.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lb_ResultVertexDegree.AutoSize = true;
            lb_ResultVertexDegree.Location = new Point(859, 1378);
            lb_ResultVertexDegree.Margin = new Padding(4, 0, 4, 0);
            lb_ResultVertexDegree.Name = "lb_ResultVertexDegree";
            lb_ResultVertexDegree.Size = new Size(0, 25);
            lb_ResultVertexDegree.TabIndex = 42;
            lb_ResultVertexDegree.Visible = false;
            // 
            // lb_Predecessor
            // 
            lb_Predecessor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lb_Predecessor.AutoSize = true;
            lb_Predecessor.Location = new Point(1300, 1378);
            lb_Predecessor.Margin = new Padding(4, 0, 4, 0);
            lb_Predecessor.Name = "lb_Predecessor";
            lb_Predecessor.Size = new Size(128, 25);
            lb_Predecessor.TabIndex = 43;
            lb_Predecessor.Text = "Predecessores:";
            lb_Predecessor.Visible = false;
            // 
            // lb_Successor
            // 
            lb_Successor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lb_Successor.AutoSize = true;
            lb_Successor.Location = new Point(1324, 1403);
            lb_Successor.Margin = new Padding(4, 0, 4, 0);
            lb_Successor.Name = "lb_Successor";
            lb_Successor.Size = new Size(103, 25);
            lb_Successor.TabIndex = 44;
            lb_Successor.Text = "Sucessores:";
            lb_Successor.Visible = false;
            // 
            // lb_ResultPredecessorNeighborhood
            // 
            lb_ResultPredecessorNeighborhood.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lb_ResultPredecessorNeighborhood.AutoSize = true;
            lb_ResultPredecessorNeighborhood.Location = new Point(1429, 1378);
            lb_ResultPredecessorNeighborhood.Margin = new Padding(4, 0, 4, 0);
            lb_ResultPredecessorNeighborhood.Name = "lb_ResultPredecessorNeighborhood";
            lb_ResultPredecessorNeighborhood.Size = new Size(0, 25);
            lb_ResultPredecessorNeighborhood.TabIndex = 45;
            lb_ResultPredecessorNeighborhood.Visible = false;
            // 
            // lb_ResultSuccessorNeighborhood
            // 
            lb_ResultSuccessorNeighborhood.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lb_ResultSuccessorNeighborhood.AutoSize = true;
            lb_ResultSuccessorNeighborhood.Location = new Point(1429, 1403);
            lb_ResultSuccessorNeighborhood.Margin = new Padding(4, 0, 4, 0);
            lb_ResultSuccessorNeighborhood.Name = "lb_ResultSuccessorNeighborhood";
            lb_ResultSuccessorNeighborhood.Size = new Size(0, 25);
            lb_ResultSuccessorNeighborhood.TabIndex = 46;
            lb_ResultSuccessorNeighborhood.Visible = false;
            // 
            // lb_Exit
            // 
            lb_Exit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lb_Exit.AutoSize = true;
            lb_Exit.Location = new Point(876, 1403);
            lb_Exit.Margin = new Padding(4, 0, 4, 0);
            lb_Exit.Name = "lb_Exit";
            lb_Exit.Size = new Size(59, 25);
            lb_Exit.TabIndex = 48;
            lb_Exit.Text = "Saída:";
            lb_Exit.Visible = false;
            // 
            // lb_Entrace
            // 
            lb_Entrace.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lb_Entrace.AutoSize = true;
            lb_Entrace.Location = new Point(859, 1378);
            lb_Entrace.Margin = new Padding(4, 0, 4, 0);
            lb_Entrace.Name = "lb_Entrace";
            lb_Entrace.Size = new Size(76, 25);
            lb_Entrace.TabIndex = 47;
            lb_Entrace.Text = "Entrada:";
            lb_Entrace.Visible = false;
            // 
            // lb_ResultInVertexDegree
            // 
            lb_ResultInVertexDegree.AutoSize = true;
            lb_ResultInVertexDegree.Location = new Point(939, 1378);
            lb_ResultInVertexDegree.Margin = new Padding(4, 0, 4, 0);
            lb_ResultInVertexDegree.Name = "lb_ResultInVertexDegree";
            lb_ResultInVertexDegree.Size = new Size(0, 25);
            lb_ResultInVertexDegree.TabIndex = 49;
            lb_ResultInVertexDegree.Visible = false;
            // 
            // lb_ResultOutVertexDegree
            // 
            lb_ResultOutVertexDegree.AutoSize = true;
            lb_ResultOutVertexDegree.Location = new Point(939, 1403);
            lb_ResultOutVertexDegree.Margin = new Padding(4, 0, 4, 0);
            lb_ResultOutVertexDegree.Name = "lb_ResultOutVertexDegree";
            lb_ResultOutVertexDegree.Size = new Size(0, 25);
            lb_ResultOutVertexDegree.TabIndex = 50;
            lb_ResultOutVertexDegree.Visible = false;
            // 
            // GraphManipulatorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1819, 1538);
            Controls.Add(lb_ResultOutVertexDegree);
            Controls.Add(lb_ResultInVertexDegree);
            Controls.Add(lb_Exit);
            Controls.Add(lb_Entrace);
            Controls.Add(lb_ResultSuccessorNeighborhood);
            Controls.Add(lb_ResultPredecessorNeighborhood);
            Controls.Add(lb_Successor);
            Controls.Add(lb_Predecessor);
            Controls.Add(lb_ResultVertexDegree);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(lb_ResultBipartiteGraph);
            Controls.Add(lb_ResultCompleteGraph);
            Controls.Add(lb_ResultRegularGraph);
            Controls.Add(lb_ResultSimpleGraph);
            Controls.Add(lb_Neighborhood);
            Controls.Add(label11);
            Controls.Add(cb_VertexNeighborhood);
            Controls.Add(btn_debug);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(btn_Start);
            Controls.Add(chb_directedGraph);
            Controls.Add(dgv_adjacencyList);
            Controls.Add(label1);
            Controls.Add(btn_exhibitionModeMatrix);
            Controls.Add(btn_exhibitionModeList);
            Controls.Add(dgv_adjacencyMatrix);
            Margin = new Padding(4, 5, 4, 5);
            Name = "GraphManipulatorForm";
            Text = "Grafos";
            ((System.ComponentModel.ISupportInitialize)dgv_adjacencyMatrix).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_adjacencyList).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nup_InitialVertexAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_adjacencyMatrix;
        private Button btn_addEdge;
        private Button btn_exhibitionModeList;
        private Button btn_exhibitionModeMatrix;
        private Label label1;
        private Label label3;
        private DataGridView dgv_adjacencyList;
        private Button btn_av_addVertex;
        private Button btn_removeEdge;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cb_rv_selectVertex;
        private Label label8;
        private Button btn_rv_removeVertex;
        private Label label10;
        private Panel panel2;
        private Label lb_edgeReturn;
        private ComboBox cb_selectSucessorEdge;
        private ComboBox cb_selectPredecessorEdge;
        private Label lb_vertexReturn;
        private CheckBox chb_directedGraph;
        private Button btn_Start;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private NumericUpDown nup_InitialVertexAmount;
        private Label label2;
        private Button btn_GenerateGraph;
        private Button btn_debug;
        private ComboBox cb_VertexNeighborhood;
        private Label label11;
        private Label lb_Neighborhood;
        private Label lb_ResultSimpleGraph;
        private Label lb_ResultRegularGraph;
        private Label lb_ResultCompleteGraph;
        private Label lb_ResultBipartiteGraph;
        private Label label12;
        private Label label13;
        private Label lb_ResultVertexDegree;
        private Label lb_Predecessor;
        private Label lb_Successor;
        private Label lb_ResultPredecessorNeighborhood;
        private Label lb_ResultSuccessorNeighborhood;
        private Label label7;
        private ComboBox cb_av_selectVertex;
        private Label label9;
        private Label lb_Exit;
        private Label lb_Entrace;
        private Label lb_ResultInVertexDegree;
        private Label lb_ResultOutVertexDegree;
    }
}