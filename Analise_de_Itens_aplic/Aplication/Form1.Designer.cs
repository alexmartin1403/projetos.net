namespace Aplication
{
    partial class dvgFunci
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtBase = new System.Windows.Forms.ComboBox();
            this.txtCiclo = new System.Windows.Forms.ComboBox();
            this.txtMes = new System.Windows.Forms.ComboBox();
            this.txtAno = new System.Windows.Forms.ComboBox();
            this.txtPorc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.selNew = new System.Windows.Forms.TabControl();
            this.Principal = new System.Windows.Forms.TabPage();
            this.dgvFunci2 = new System.Windows.Forms.DataGridView();
            this.Detalhe = new System.Windows.Forms.TabPage();
            this.dgvFunciD = new System.Windows.Forms.DataGridView();
            this.qtd = new System.Windows.Forms.TabPage();
            this.dgvFunciQ = new System.Windows.Forms.DataGridView();
            this.valor = new System.Windows.Forms.TabPage();
            this.dgvFunciV = new System.Windows.Forms.DataGridView();
            this.zeradas = new System.Windows.Forms.TabPage();
            this.dgvFunciZ = new System.Windows.Forms.DataGridView();
            this.total = new System.Windows.Forms.TabPage();
            this.dgvFunciT = new System.Windows.Forms.DataGridView();
            this.excel = new System.Windows.Forms.Button();
            this.selNew.SuspendLayout();
            this.Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunci2)).BeginInit();
            this.Detalhe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciD)).BeginInit();
            this.qtd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciQ)).BeginInit();
            this.valor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciV)).BeginInit();
            this.zeradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciZ)).BeginInit();
            this.total.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(610, 40);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 34);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtBase
            // 
            this.txtBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBase.FormattingEnabled = true;
            this.txtBase.Items.AddRange(new object[] {
            "TUDO",
            "BHZ",
            "ISP",
            "SOC",
            "SUL",
            "BRI",
            "BRA",
            "SPO",
            "CTV"});
            this.txtBase.Location = new System.Drawing.Point(88, 48);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(62, 21);
            this.txtBase.TabIndex = 10;
            // 
            // txtCiclo
            // 
            this.txtCiclo.FormattingEnabled = true;
            this.txtCiclo.Items.AddRange(new object[] {
            "5-8",
            "10",
            "15",
            "20",
            "25-28"});
            this.txtCiclo.Location = new System.Drawing.Point(286, 47);
            this.txtCiclo.Name = "txtCiclo";
            this.txtCiclo.Size = new System.Drawing.Size(58, 21);
            this.txtCiclo.TabIndex = 11;
            // 
            // txtMes
            // 
            this.txtMes.FormattingEnabled = true;
            this.txtMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.txtMes.Location = new System.Drawing.Point(381, 47);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(94, 21);
            this.txtMes.TabIndex = 12;
            // 
            // txtAno
            // 
            this.txtAno.FormattingEnabled = true;
            this.txtAno.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019",
            "2018"});
            this.txtAno.Location = new System.Drawing.Point(499, 47);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(65, 21);
            this.txtAno.TabIndex = 13;
            // 
            // txtPorc
            // 
            this.txtPorc.Location = new System.Drawing.Point(174, 48);
            this.txtPorc.Name = "txtPorc";
            this.txtPorc.Size = new System.Drawing.Size(85, 20);
            this.txtPorc.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Base";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Porcentagem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ciclo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mês";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ano";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "img";
            this.dataGridViewImageColumn1.HeaderText = "img";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // selNew
            // 
            this.selNew.Controls.Add(this.Principal);
            this.selNew.Controls.Add(this.Detalhe);
            this.selNew.Controls.Add(this.qtd);
            this.selNew.Controls.Add(this.valor);
            this.selNew.Controls.Add(this.zeradas);
            this.selNew.Controls.Add(this.total);
            this.selNew.Location = new System.Drawing.Point(12, 95);
            this.selNew.Name = "selNew";
            this.selNew.SelectedIndex = 0;
            this.selNew.Size = new System.Drawing.Size(856, 315);
            this.selNew.TabIndex = 20;
            // 
            // Principal
            // 
            this.Principal.Controls.Add(this.dgvFunci2);
            this.Principal.Location = new System.Drawing.Point(4, 22);
            this.Principal.Name = "Principal";
            this.Principal.Padding = new System.Windows.Forms.Padding(3);
            this.Principal.Size = new System.Drawing.Size(848, 289);
            this.Principal.TabIndex = 0;
            this.Principal.Text = "Principal";
            this.Principal.UseVisualStyleBackColor = true;
            // 
            // dgvFunci2
            // 
            this.dgvFunci2.AllowUserToDeleteRows = false;
            this.dgvFunci2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFunci2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFunci2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFunci2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFunci2.Location = new System.Drawing.Point(6, 7);
            this.dgvFunci2.Name = "dgvFunci2";
            this.dgvFunci2.ReadOnly = true;
            this.dgvFunci2.Size = new System.Drawing.Size(836, 274);
            this.dgvFunci2.TabIndex = 3;
            this.dgvFunci2.DataSourceChanged += new System.EventHandler(this.dgvFunci2_DataSourceChanged);
            this.dgvFunci2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunci2_CellClick);
            this.dgvFunci2.VisibleChanged += new System.EventHandler(this.dgvFunci2_VisibleChanged);
            // 
            // Detalhe
            // 
            this.Detalhe.Controls.Add(this.dgvFunciD);
            this.Detalhe.Location = new System.Drawing.Point(4, 22);
            this.Detalhe.Name = "Detalhe";
            this.Detalhe.Padding = new System.Windows.Forms.Padding(3);
            this.Detalhe.Size = new System.Drawing.Size(848, 289);
            this.Detalhe.TabIndex = 1;
            this.Detalhe.Text = "Detalhe";
            this.Detalhe.UseVisualStyleBackColor = true;
            // 
            // dgvFunciD
            // 
            this.dgvFunciD.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvFunciD.AllowUserToDeleteRows = false;
            this.dgvFunciD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFunciD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFunciD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunciD.EnableHeadersVisualStyles = false;
            this.dgvFunciD.Location = new System.Drawing.Point(6, 6);
            this.dgvFunciD.Name = "dgvFunciD";
            this.dgvFunciD.ReadOnly = true;
            this.dgvFunciD.Size = new System.Drawing.Size(836, 277);
            this.dgvFunciD.TabIndex = 0;
            // 
            // qtd
            // 
            this.qtd.Controls.Add(this.dgvFunciQ);
            this.qtd.Location = new System.Drawing.Point(4, 22);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(848, 289);
            this.qtd.TabIndex = 2;
            this.qtd.Text = "Quantidade de itens";
            this.qtd.UseVisualStyleBackColor = true;
            // 
            // dgvFunciQ
            // 
            this.dgvFunciQ.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvFunciQ.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFunciQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFunciQ.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFunciQ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFunciQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFunciQ.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFunciQ.Location = new System.Drawing.Point(6, 9);
            this.dgvFunciQ.Name = "dgvFunciQ";
            this.dgvFunciQ.ReadOnly = true;
            this.dgvFunciQ.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvFunciQ.Size = new System.Drawing.Size(837, 270);
            this.dgvFunciQ.TabIndex = 0;
            // 
            // valor
            // 
            this.valor.Controls.Add(this.dgvFunciV);
            this.valor.Location = new System.Drawing.Point(4, 22);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(848, 289);
            this.valor.TabIndex = 3;
            this.valor.Text = "Valor Itens";
            this.valor.UseVisualStyleBackColor = true;
            // 
            // dgvFunciV
            // 
            this.dgvFunciV.AllowUserToDeleteRows = false;
            this.dgvFunciV.AllowUserToResizeColumns = false;
            this.dgvFunciV.AllowUserToResizeRows = false;
            this.dgvFunciV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFunciV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFunciV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFunciV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFunciV.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFunciV.Location = new System.Drawing.Point(6, 9);
            this.dgvFunciV.Name = "dgvFunciV";
            this.dgvFunciV.Size = new System.Drawing.Size(839, 272);
            this.dgvFunciV.TabIndex = 0;
            // 
            // zeradas
            // 
            this.zeradas.Controls.Add(this.dgvFunciZ);
            this.zeradas.Location = new System.Drawing.Point(4, 22);
            this.zeradas.Name = "zeradas";
            this.zeradas.Size = new System.Drawing.Size(848, 289);
            this.zeradas.TabIndex = 5;
            this.zeradas.Text = "Zeradas";
            this.zeradas.UseVisualStyleBackColor = true;
            // 
            // dgvFunciZ
            // 
            this.dgvFunciZ.AllowUserToDeleteRows = false;
            this.dgvFunciZ.AllowUserToResizeColumns = false;
            this.dgvFunciZ.AllowUserToResizeRows = false;
            this.dgvFunciZ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFunciZ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFunciZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFunciZ.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvFunciZ.Location = new System.Drawing.Point(6, 9);
            this.dgvFunciZ.Name = "dgvFunciZ";
            this.dgvFunciZ.Size = new System.Drawing.Size(839, 270);
            this.dgvFunciZ.TabIndex = 0;
            this.dgvFunciZ.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunciZ_CellClick);
            this.dgvFunciZ.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunciZ_CellContentClick);
            // 
            // total
            // 
            this.total.Controls.Add(this.dgvFunciT);
            this.total.Location = new System.Drawing.Point(4, 22);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(848, 289);
            this.total.TabIndex = 4;
            this.total.Text = "Total";
            this.total.UseVisualStyleBackColor = true;
            // 
            // dgvFunciT
            // 
            this.dgvFunciT.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFunciT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvFunciT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFunciT.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvFunciT.Location = new System.Drawing.Point(6, 9);
            this.dgvFunciT.Name = "dgvFunciT";
            this.dgvFunciT.Size = new System.Drawing.Size(839, 268);
            this.dgvFunciT.TabIndex = 0;
            // 
            // excel
            // 
            this.excel.Location = new System.Drawing.Point(714, 40);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(88, 34);
            this.excel.TabIndex = 21;
            this.excel.Text = "Exportar para excel";
            this.excel.UseVisualStyleBackColor = true;
            this.excel.Click += new System.EventHandler(this.button1_Click);
            // 
            // dvgFunci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.excel);
            this.Controls.Add(this.selNew);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPorc);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtCiclo);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.btnAtualizar);
            this.Name = "dvgFunci";
            this.Text = "Processo de Analise de Itens";
            this.Load += new System.EventHandler(this.dvgFunci_Load);
            this.selNew.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunci2)).EndInit();
            this.Detalhe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciD)).EndInit();
            this.qtd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciQ)).EndInit();
            this.valor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciV)).EndInit();
            this.zeradas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciZ)).EndInit();
            this.total.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.ComboBox txtBase;
        private System.Windows.Forms.ComboBox txtCiclo;
        private System.Windows.Forms.ComboBox txtMes;
        private System.Windows.Forms.ComboBox txtAno;
        private System.Windows.Forms.TextBox txtPorc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TabControl selNew;
        private System.Windows.Forms.TabPage Principal;
        private System.Windows.Forms.TabPage Detalhe;
        private System.Windows.Forms.DataGridView dgvFunci2;
        private System.Windows.Forms.DataGridView dgvFunciD;
        private System.Windows.Forms.TabPage qtd;
        private System.Windows.Forms.TabPage valor;
        private System.Windows.Forms.TabPage total;
        private System.Windows.Forms.DataGridView dgvFunciQ;
        private System.Windows.Forms.DataGridView dgvFunciV;
        private System.Windows.Forms.DataGridView dgvFunciT;
        private System.Windows.Forms.TabPage zeradas;
        private System.Windows.Forms.DataGridView dgvFunciZ;
        private System.Windows.Forms.Button excel;
    }
}

