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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dgv_adjacencyMatrix = new DataGridView();
            btn_addEdge = new Button();
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
            cb_inputSucessorEdge = new RichTextBox();
            label14 = new Label();
            cb_selectSucessorEdge = new ComboBox();
            cb_selectPredecessorEdge = new ComboBox();
            lb_edgeReturn = new Label();
            lb_vertexReturn = new Label();
            chb_directedGraph = new CheckBox();
            btn_Start = new Button();
            panel3 = new Panel();
            button1 = new Button();
            btn_debug = new Button();
            panel4 = new Panel();
            label9 = new Label();
            cb_av_selectVertex = new ComboBox();
            label7 = new Label();
            panel5 = new Panel();
            btn_GenerateGraph = new Button();
            nup_InitialVertexAmount = new NumericUpDown();
            label2 = new Label();
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            lbl_TopologicalOrdering = new Label();
            tabPage4 = new TabPage();
            lbl_TotalWeight = new Label();
            lbl_MinPath = new Label();
            tabPage5 = new TabPage();
            button2 = new Button();
            gdv_MST = new DataGridView();
            lbl_isConected = new Label();
            dgv_Dijkstra = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_adjacencyMatrix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_adjacencyList).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nup_InitialVertexAmount).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gdv_MST).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Dijkstra).BeginInit();
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
            dgv_adjacencyMatrix.Location = new Point(6, 6);
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
            dgv_adjacencyMatrix.Size = new Size(704, 610);
            dgv_adjacencyMatrix.TabIndex = 0;
            // 
            // btn_addEdge
            // 
            btn_addEdge.Enabled = false;
            btn_addEdge.Location = new Point(7, 91);
            btn_addEdge.Name = "btn_addEdge";
            btn_addEdge.Size = new Size(234, 23);
            btn_addEdge.TabIndex = 4;
            btn_addEdge.Text = "Adicionar aresta";
            btn_addEdge.UseVisualStyleBackColor = true;
            btn_addEdge.Click += btn_addEdge_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 13);
            label3.Name = "label3";
            label3.Size = new Size(135, 21);
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
            dgv_adjacencyList.Location = new Point(6, 7);
            dgv_adjacencyList.Name = "dgv_adjacencyList";
            dgv_adjacencyList.ReadOnly = true;
            dgv_adjacencyList.RowHeadersVisible = false;
            dgv_adjacencyList.RowHeadersWidth = 20;
            dgv_adjacencyList.RowTemplate.Height = 25;
            dgv_adjacencyList.Size = new Size(704, 609);
            dgv_adjacencyList.TabIndex = 12;
            // 
            // btn_av_addVertex
            // 
            btn_av_addVertex.Enabled = false;
            btn_av_addVertex.Location = new Point(182, 32);
            btn_av_addVertex.Name = "btn_av_addVertex";
            btn_av_addVertex.Size = new Size(78, 23);
            btn_av_addVertex.TabIndex = 13;
            btn_av_addVertex.Text = "Adicionar";
            btn_av_addVertex.UseVisualStyleBackColor = true;
            btn_av_addVertex.Click += btn_av_addVertex_Click;
            // 
            // btn_removeEdge
            // 
            btn_removeEdge.Enabled = false;
            btn_removeEdge.Location = new Point(7, 120);
            btn_removeEdge.Name = "btn_removeEdge";
            btn_removeEdge.Size = new Size(234, 23);
            btn_removeEdge.TabIndex = 14;
            btn_removeEdge.Text = "Remover aresta";
            btn_removeEdge.UseVisualStyleBackColor = true;
            btn_removeEdge.Click += btn_removeEdge_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 39);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 15;
            label4.Text = "Predecessor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 39);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 16;
            label5.Text = "Sucessor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(21, 14);
            label6.Name = "label6";
            label6.Size = new Size(138, 21);
            label6.TabIndex = 21;
            label6.Text = "Gerenciar Vertices:";
            // 
            // cb_rv_selectVertex
            // 
            cb_rv_selectVertex.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_rv_selectVertex.Enabled = false;
            cb_rv_selectVertex.FormattingEnabled = true;
            cb_rv_selectVertex.Location = new Point(76, 99);
            cb_rv_selectVertex.Name = "cb_rv_selectVertex";
            cb_rv_selectVertex.Size = new Size(100, 23);
            cb_rv_selectVertex.TabIndex = 24;
            cb_rv_selectVertex.DropDown += cb_rv_selectVertex_DropDown;
            cb_rv_selectVertex.TextChanged += cb_rv_selectVertex_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 76);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 25;
            label8.Text = "Remover Vertice:";
            // 
            // btn_rv_removeVertex
            // 
            btn_rv_removeVertex.Enabled = false;
            btn_rv_removeVertex.Location = new Point(182, 99);
            btn_rv_removeVertex.Name = "btn_rv_removeVertex";
            btn_rv_removeVertex.Size = new Size(78, 23);
            btn_rv_removeVertex.TabIndex = 25;
            btn_rv_removeVertex.Text = "Remover";
            btn_rv_removeVertex.UseVisualStyleBackColor = true;
            btn_rv_removeVertex.Click += btn_rv_removeVertex_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 103);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 25;
            label10.Text = "Nome:";
            // 
            // panel2
            // 
            panel2.Controls.Add(cb_inputSucessorEdge);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(cb_selectSucessorEdge);
            panel2.Controls.Add(cb_selectPredecessorEdge);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btn_removeEdge);
            panel2.Controls.Add(btn_addEdge);
            panel2.Location = new Point(13, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(301, 161);
            panel2.TabIndex = 28;
            // 
            // cb_inputSucessorEdge
            // 
            cb_inputSucessorEdge.Location = new Point(184, 57);
            cb_inputSucessorEdge.Multiline = false;
            cb_inputSucessorEdge.Name = "cb_inputSucessorEdge";
            cb_inputSucessorEdge.Size = new Size(57, 23);
            cb_inputSucessorEdge.TabIndex = 29;
            cb_inputSucessorEdge.Text = "";
            cb_inputSucessorEdge.KeyPress += cb_inputSucessorEdge_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(185, 39);
            label14.Name = "label14";
            label14.Size = new Size(35, 15);
            label14.TabIndex = 28;
            label14.Text = "Peso:";
            // 
            // cb_selectSucessorEdge
            // 
            cb_selectSucessorEdge.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_selectSucessorEdge.Enabled = false;
            cb_selectSucessorEdge.FormattingEnabled = true;
            cb_selectSucessorEdge.Location = new Point(95, 57);
            cb_selectSucessorEdge.Name = "cb_selectSucessorEdge";
            cb_selectSucessorEdge.Size = new Size(68, 23);
            cb_selectSucessorEdge.TabIndex = 27;
            cb_selectSucessorEdge.DropDown += cb_selectSucessorEdge_DropDown;
            cb_selectSucessorEdge.SelectedIndexChanged += cb_selectSucessorEdge_SelectedIndexChanged;
            // 
            // cb_selectPredecessorEdge
            // 
            cb_selectPredecessorEdge.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_selectPredecessorEdge.Enabled = false;
            cb_selectPredecessorEdge.FormattingEnabled = true;
            cb_selectPredecessorEdge.Location = new Point(8, 57);
            cb_selectPredecessorEdge.Name = "cb_selectPredecessorEdge";
            cb_selectPredecessorEdge.Size = new Size(72, 23);
            cb_selectPredecessorEdge.TabIndex = 26;
            cb_selectPredecessorEdge.DropDown += cb_selectPredecessorEdge_DropDown;
            cb_selectPredecessorEdge.SelectedIndexChanged += cb_selectPredecessorEdge_SelectedIndexChanged;
            // 
            // lb_edgeReturn
            // 
            lb_edgeReturn.AutoSize = true;
            lb_edgeReturn.ForeColor = Color.Firebrick;
            lb_edgeReturn.Location = new Point(13, 227);
            lb_edgeReturn.Name = "lb_edgeReturn";
            lb_edgeReturn.Size = new Size(0, 15);
            lb_edgeReturn.TabIndex = 28;
            // 
            // lb_vertexReturn
            // 
            lb_vertexReturn.AutoSize = true;
            lb_vertexReturn.ForeColor = Color.Firebrick;
            lb_vertexReturn.Location = new Point(13, 237);
            lb_vertexReturn.Name = "lb_vertexReturn";
            lb_vertexReturn.Size = new Size(0, 15);
            lb_vertexReturn.TabIndex = 29;
            // 
            // chb_directedGraph
            // 
            chb_directedGraph.AutoSize = true;
            chb_directedGraph.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chb_directedGraph.Location = new Point(12, 12);
            chb_directedGraph.Name = "chb_directedGraph";
            chb_directedGraph.Size = new Size(156, 25);
            chb_directedGraph.TabIndex = 17;
            chb_directedGraph.Text = "Grafo Direcionado";
            chb_directedGraph.UseVisualStyleBackColor = true;
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(12, 40);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(75, 23);
            btn_Start.TabIndex = 30;
            btn_Start.Text = "Start";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(lb_edgeReturn);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(btn_debug);
            panel3.Location = new Point(9, 383);
            panel3.Name = "panel3";
            panel3.Size = new Size(317, 401);
            panel3.TabIndex = 31;
            // 
            // button1
            // 
            button1.Location = new Point(20, 227);
            button1.Name = "button1";
            button1.Size = new Size(234, 23);
            button1.TabIndex = 29;
            button1.Text = "Busca em profundidade";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_debug
            // 
            btn_debug.Location = new Point(108, 282);
            btn_debug.Name = "btn_debug";
            btn_debug.Size = new Size(75, 23);
            btn_debug.TabIndex = 33;
            btn_debug.Text = "DEBUG";
            btn_debug.UseVisualStyleBackColor = true;
            btn_debug.Visible = false;
            btn_debug.Click += btn_debug_Click;
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
            panel4.Location = new Point(13, 98);
            panel4.Name = "panel4";
            panel4.Size = new Size(301, 136);
            panel4.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 36);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 28;
            label9.Text = "Nome:";
            // 
            // cb_av_selectVertex
            // 
            cb_av_selectVertex.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_av_selectVertex.Enabled = false;
            cb_av_selectVertex.FormattingEnabled = true;
            cb_av_selectVertex.Location = new Point(76, 33);
            cb_av_selectVertex.Name = "cb_av_selectVertex";
            cb_av_selectVertex.Size = new Size(100, 23);
            cb_av_selectVertex.TabIndex = 27;
            cb_av_selectVertex.DropDown += cb_av_selectVertex_DropDown;
            cb_av_selectVertex.TextChanged += cb_av_selectVertex_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 15);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
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
            panel5.Location = new Point(12, 103);
            panel5.Name = "panel5";
            panel5.Size = new Size(317, 274);
            panel5.TabIndex = 32;
            // 
            // btn_GenerateGraph
            // 
            btn_GenerateGraph.Enabled = false;
            btn_GenerateGraph.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_GenerateGraph.Location = new Point(195, 64);
            btn_GenerateGraph.Name = "btn_GenerateGraph";
            btn_GenerateGraph.Size = new Size(95, 23);
            btn_GenerateGraph.TabIndex = 25;
            btn_GenerateGraph.Text = "Gerar grafo";
            btn_GenerateGraph.UseVisualStyleBackColor = true;
            btn_GenerateGraph.Click += btn_GenerateGraph_Click;
            // 
            // nup_InitialVertexAmount
            // 
            nup_InitialVertexAmount.Enabled = false;
            nup_InitialVertexAmount.Location = new Point(132, 64);
            nup_InitialVertexAmount.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            nup_InitialVertexAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nup_InitialVertexAmount.Name = "nup_InitialVertexAmount";
            nup_InitialVertexAmount.Size = new Size(57, 23);
            nup_InitialVertexAmount.TabIndex = 33;
            nup_InitialVertexAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 66);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 25;
            label2.Text = "Número de vertices:";
            // 
            // cb_VertexNeighborhood
            // 
            cb_VertexNeighborhood.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cb_VertexNeighborhood.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_VertexNeighborhood.Enabled = false;
            cb_VertexNeighborhood.FormattingEnabled = true;
            cb_VertexNeighborhood.Location = new Point(387, 698);
            cb_VertexNeighborhood.Name = "cb_VertexNeighborhood";
            cb_VertexNeighborhood.Size = new Size(100, 23);
            cb_VertexNeighborhood.TabIndex = 28;
            cb_VertexNeighborhood.DropDown += cb_VertexNeighborhood_DropDown;
            cb_VertexNeighborhood.TextChanged += cb_VertexNeighborhood_TextChanged;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label11.AutoSize = true;
            label11.Location = new Point(770, 701);
            label11.Name = "label11";
            label11.Size = new Size(122, 15);
            label11.TabIndex = 34;
            label11.Text = "Vizinhança do vertice:";
            // 
            // lb_Neighborhood
            // 
            lb_Neighborhood.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lb_Neighborhood.AutoSize = true;
            lb_Neighborhood.Location = new Point(898, 701);
            lb_Neighborhood.Name = "lb_Neighborhood";
            lb_Neighborhood.Size = new Size(0, 15);
            lb_Neighborhood.TabIndex = 35;
            lb_Neighborhood.Visible = false;
            // 
            // lb_ResultSimpleGraph
            // 
            lb_ResultSimpleGraph.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lb_ResultSimpleGraph.AutoSize = true;
            lb_ResultSimpleGraph.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_ResultSimpleGraph.Location = new Point(355, 755);
            lb_ResultSimpleGraph.Name = "lb_ResultSimpleGraph";
            lb_ResultSimpleGraph.Size = new Size(0, 25);
            lb_ResultSimpleGraph.TabIndex = 36;
            // 
            // lb_ResultRegularGraph
            // 
            lb_ResultRegularGraph.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lb_ResultRegularGraph.AutoSize = true;
            lb_ResultRegularGraph.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_ResultRegularGraph.Location = new Point(551, 755);
            lb_ResultRegularGraph.Name = "lb_ResultRegularGraph";
            lb_ResultRegularGraph.Size = new Size(0, 25);
            lb_ResultRegularGraph.TabIndex = 37;
            // 
            // lb_ResultCompleteGraph
            // 
            lb_ResultCompleteGraph.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lb_ResultCompleteGraph.AutoSize = true;
            lb_ResultCompleteGraph.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_ResultCompleteGraph.Location = new Point(746, 755);
            lb_ResultCompleteGraph.Name = "lb_ResultCompleteGraph";
            lb_ResultCompleteGraph.Size = new Size(0, 25);
            lb_ResultCompleteGraph.TabIndex = 38;
            // 
            // lb_ResultBipartiteGraph
            // 
            lb_ResultBipartiteGraph.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lb_ResultBipartiteGraph.AutoSize = true;
            lb_ResultBipartiteGraph.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_ResultBipartiteGraph.Location = new Point(952, 755);
            lb_ResultBipartiteGraph.Name = "lb_ResultBipartiteGraph";
            lb_ResultBipartiteGraph.Size = new Size(0, 25);
            lb_ResultBipartiteGraph.TabIndex = 39;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label12.AutoSize = true;
            label12.Location = new Point(336, 701);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 40;
            label12.Text = "Vertice:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label13.AutoSize = true;
            label13.Location = new Point(493, 701);
            label13.Name = "label13";
            label13.Size = new Size(90, 15);
            label13.TabIndex = 41;
            label13.Text = "Grau do vertice:";
            // 
            // lb_ResultVertexDegree
            // 
            lb_ResultVertexDegree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lb_ResultVertexDegree.AutoSize = true;
            lb_ResultVertexDegree.Location = new Point(589, 701);
            lb_ResultVertexDegree.Name = "lb_ResultVertexDegree";
            lb_ResultVertexDegree.Size = new Size(0, 15);
            lb_ResultVertexDegree.TabIndex = 42;
            lb_ResultVertexDegree.Visible = false;
            // 
            // lb_Predecessor
            // 
            lb_Predecessor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lb_Predecessor.AutoSize = true;
            lb_Predecessor.Location = new Point(898, 701);
            lb_Predecessor.Name = "lb_Predecessor";
            lb_Predecessor.Size = new Size(84, 15);
            lb_Predecessor.TabIndex = 43;
            lb_Predecessor.Text = "Predecessores:";
            lb_Predecessor.Visible = false;
            // 
            // lb_Successor
            // 
            lb_Successor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lb_Successor.AutoSize = true;
            lb_Successor.Location = new Point(915, 716);
            lb_Successor.Name = "lb_Successor";
            lb_Successor.Size = new Size(67, 15);
            lb_Successor.TabIndex = 44;
            lb_Successor.Text = "Sucessores:";
            lb_Successor.Visible = false;
            // 
            // lb_ResultPredecessorNeighborhood
            // 
            lb_ResultPredecessorNeighborhood.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lb_ResultPredecessorNeighborhood.AutoSize = true;
            lb_ResultPredecessorNeighborhood.Location = new Point(988, 701);
            lb_ResultPredecessorNeighborhood.Name = "lb_ResultPredecessorNeighborhood";
            lb_ResultPredecessorNeighborhood.Size = new Size(0, 15);
            lb_ResultPredecessorNeighborhood.TabIndex = 45;
            lb_ResultPredecessorNeighborhood.Visible = false;
            // 
            // lb_ResultSuccessorNeighborhood
            // 
            lb_ResultSuccessorNeighborhood.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lb_ResultSuccessorNeighborhood.AutoSize = true;
            lb_ResultSuccessorNeighborhood.Location = new Point(988, 716);
            lb_ResultSuccessorNeighborhood.Name = "lb_ResultSuccessorNeighborhood";
            lb_ResultSuccessorNeighborhood.Size = new Size(0, 15);
            lb_ResultSuccessorNeighborhood.TabIndex = 46;
            lb_ResultSuccessorNeighborhood.Visible = false;
            // 
            // lb_Exit
            // 
            lb_Exit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lb_Exit.AutoSize = true;
            lb_Exit.Location = new Point(601, 716);
            lb_Exit.Name = "lb_Exit";
            lb_Exit.Size = new Size(38, 15);
            lb_Exit.TabIndex = 48;
            lb_Exit.Text = "Saída:";
            lb_Exit.Visible = false;
            // 
            // lb_Entrace
            // 
            lb_Entrace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lb_Entrace.AutoSize = true;
            lb_Entrace.Location = new Point(589, 701);
            lb_Entrace.Name = "lb_Entrace";
            lb_Entrace.Size = new Size(50, 15);
            lb_Entrace.TabIndex = 47;
            lb_Entrace.Text = "Entrada:";
            lb_Entrace.Visible = false;
            // 
            // lb_ResultInVertexDegree
            // 
            lb_ResultInVertexDegree.Anchor = AnchorStyles.Bottom;
            lb_ResultInVertexDegree.AutoSize = true;
            lb_ResultInVertexDegree.Location = new Point(645, 295);
            lb_ResultInVertexDegree.Name = "lb_ResultInVertexDegree";
            lb_ResultInVertexDegree.Size = new Size(0, 15);
            lb_ResultInVertexDegree.TabIndex = 49;
            lb_ResultInVertexDegree.Visible = false;
            // 
            // lb_ResultOutVertexDegree
            // 
            lb_ResultOutVertexDegree.Anchor = AnchorStyles.Bottom;
            lb_ResultOutVertexDegree.AutoSize = true;
            lb_ResultOutVertexDegree.Location = new Point(645, 310);
            lb_ResultOutVertexDegree.Name = "lb_ResultOutVertexDegree";
            lb_ResultOutVertexDegree.Size = new Size(0, 15);
            lb_ResultOutVertexDegree.TabIndex = 50;
            lb_ResultOutVertexDegree.Visible = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(335, 9);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(724, 650);
            tabControl1.TabIndex = 51;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgv_adjacencyList);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(716, 622);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lista de Adjacência";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgv_adjacencyMatrix);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(716, 622);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Matriz de Adjacência";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Location = new Point(1061, 12);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(537, 647);
            tabControl2.TabIndex = 52;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lbl_TopologicalOrdering);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(529, 619);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Ordenação Topológica";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbl_TopologicalOrdering
            // 
            lbl_TopologicalOrdering.AutoSize = true;
            lbl_TopologicalOrdering.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TopologicalOrdering.Location = new Point(21, 87);
            lbl_TopologicalOrdering.Name = "lbl_TopologicalOrdering";
            lbl_TopologicalOrdering.Size = new Size(65, 25);
            lbl_TopologicalOrdering.TabIndex = 0;
            lbl_TopologicalOrdering.Text = "label1";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgv_Dijkstra);
            tabPage4.Controls.Add(lbl_TotalWeight);
            tabPage4.Controls.Add(lbl_MinPath);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(529, 619);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Caminho Mínimo";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // lbl_TotalWeight
            // 
            lbl_TotalWeight.AutoSize = true;
            lbl_TotalWeight.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_TotalWeight.Location = new Point(41, 403);
            lbl_TotalWeight.Name = "lbl_TotalWeight";
            lbl_TotalWeight.Size = new Size(110, 25);
            lbl_TotalWeight.TabIndex = 1;
            lbl_TotalWeight.Text = "Total path: ";
            // 
            // lbl_MinPath
            // 
            lbl_MinPath.AutoSize = true;
            lbl_MinPath.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_MinPath.Location = new Point(54, 360);
            lbl_MinPath.Name = "lbl_MinPath";
            lbl_MinPath.Size = new Size(65, 25);
            lbl_MinPath.TabIndex = 0;
            lbl_MinPath.Text = "label1";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(button2);
            tabPage5.Controls.Add(gdv_MST);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(529, 619);
            tabPage5.TabIndex = 2;
            tabPage5.Text = "AGM";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 19);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Prim";
            button2.UseVisualStyleBackColor = true;
            // 
            // gdv_MST
            // 
            gdv_MST.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdv_MST.Location = new Point(3, 81);
            gdv_MST.Name = "gdv_MST";
            gdv_MST.RowTemplate.Height = 25;
            gdv_MST.Size = new Size(523, 532);
            gdv_MST.TabIndex = 0;
            // 
            // lbl_isConected
            // 
            lbl_isConected.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lbl_isConected.AutoSize = true;
            lbl_isConected.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_isConected.Location = new Point(1334, 759);
            lbl_isConected.Name = "lbl_isConected";
            lbl_isConected.Size = new Size(17, 25);
            lbl_isConected.TabIndex = 53;
            lbl_isConected.Text = "l";
            // 
            // dgv_Dijkstra
            // 
            dgv_Dijkstra.AllowUserToAddRows = false;
            dgv_Dijkstra.AllowUserToDeleteRows = false;
            dgv_Dijkstra.AllowUserToResizeColumns = false;
            dgv_Dijkstra.AllowUserToResizeRows = false;
            dgv_Dijkstra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_Dijkstra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Dijkstra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_Dijkstra.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_Dijkstra.Location = new Point(0, 0);
            dgv_Dijkstra.Name = "dgv_Dijkstra";
            dgv_Dijkstra.ReadOnly = true;
            dgv_Dijkstra.RowHeadersVisible = false;
            dgv_Dijkstra.RowHeadersWidth = 20;
            dgv_Dijkstra.RowTemplate.Height = 25;
            dgv_Dijkstra.Size = new Size(523, 301);
            dgv_Dijkstra.TabIndex = 13;
            // 
            // GraphManipulatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1685, 808);
            Controls.Add(lbl_isConected);
            Controls.Add(tabControl2);
            Controls.Add(tabControl1);
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
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(btn_Start);
            Controls.Add(chb_directedGraph);
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
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gdv_MST).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Dijkstra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_adjacencyMatrix;
        private Button btn_addEdge;
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
        private Button button1;
        private Label label14;
        private RichTextBox cb_inputSucessorEdge;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label lbl_TopologicalOrdering;
        private Label lbl_MinPath;
        private Label lbl_TotalWeight;
        private Label lbl_isConected;
        private TabPage tabPage5;
        private DataGridView gdv_MST;
        private Button button2;
        private DataGridView dgv_Dijkstra;
    }
}