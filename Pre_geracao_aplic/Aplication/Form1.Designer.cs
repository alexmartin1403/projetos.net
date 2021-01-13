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
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtBase = new System.Windows.Forms.ComboBox();
            this.txtCiclo = new System.Windows.Forms.ComboBox();
            this.txtMes = new System.Windows.Forms.ComboBox();
            this.txtAno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.selNew = new System.Windows.Forms.TabControl();
            this.Principal = new System.Windows.Forms.TabPage();
            this.dgvFunci2 = new System.Windows.Forms.DataGridView();
            this.Totais = new System.Windows.Forms.TabPage();
            this.dgvTotais = new System.Windows.Forms.DataGridView();
            this.excel = new System.Windows.Forms.Button();
            this.txtPorc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selNew.SuspendLayout();
            this.Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunci2)).BeginInit();
            this.Totais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotais)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(785, 36);
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
            "BRA",
            "BRI",
            "CTV",
            "ISP",
            "SOC",
            "SPO",
            "SUL"});
            this.txtBase.Location = new System.Drawing.Point(306, 43);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(69, 21);
            this.txtBase.TabIndex = 10;
            this.txtBase.SelectedIndexChanged += new System.EventHandler(this.txtBase_SelectedIndexChanged);
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
            this.txtCiclo.Location = new System.Drawing.Point(497, 44);
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
            this.txtMes.Location = new System.Drawing.Point(579, 44);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(71, 21);
            this.txtMes.TabIndex = 12;
            // 
            // txtAno
            // 
            this.txtAno.FormattingEnabled = true;
            this.txtAno.Location = new System.Drawing.Point(680, 43);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(65, 21);
            this.txtAno.TabIndex = 13;
            this.txtAno.SelectedIndexChanged += new System.EventHandler(this.txtAno_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Base";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ciclo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mês";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(696, 20);
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
            this.selNew.Controls.Add(this.Totais);
            this.selNew.Location = new System.Drawing.Point(12, 95);
            this.selNew.Name = "selNew";
            this.selNew.SelectedIndex = 0;
            this.selNew.Size = new System.Drawing.Size(1346, 1000);
            this.selNew.TabIndex = 20;
            // 
            // Principal
            // 
            this.Principal.Controls.Add(this.dgvFunci2);
            this.Principal.Location = new System.Drawing.Point(4, 22);
            this.Principal.Name = "Principal";
            this.Principal.Padding = new System.Windows.Forms.Padding(3);
            this.Principal.Size = new System.Drawing.Size(1338, 974);
            this.Principal.TabIndex = 0;
            this.Principal.Text = "Principal";
            this.Principal.UseVisualStyleBackColor = true;
            // 
            // dgvFunci2
            // 
            this.dgvFunci2.AllowUserToDeleteRows = false;
            this.dgvFunci2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFunci2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFunci2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
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
            this.dgvFunci2.Size = new System.Drawing.Size(1326, 450);
            this.dgvFunci2.TabIndex = 3;
            this.dgvFunci2.DataSourceChanged += new System.EventHandler(this.dgvFunci2_DataSourceChanged);
            this.dgvFunci2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunci2_CellClick);
            this.dgvFunci2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunci2_CellContentClick_1);
            this.dgvFunci2.VisibleChanged += new System.EventHandler(this.dgvFunci2_VisibleChanged);
            // 
            // Totais
            // 
            this.Totais.Controls.Add(this.dgvTotais);
            this.Totais.Location = new System.Drawing.Point(4, 22);
            this.Totais.Name = "Totais";
            this.Totais.Padding = new System.Windows.Forms.Padding(3);
            this.Totais.Size = new System.Drawing.Size(1338, 974);
            this.Totais.TabIndex = 1;
            this.Totais.Text = "Totais";
            this.Totais.UseVisualStyleBackColor = true;
            // 
            // dgvTotais
            // 
            this.dgvTotais.AllowUserToDeleteRows = false;
            this.dgvTotais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTotais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTotais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTotais.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTotais.Location = new System.Drawing.Point(6, 7);
            this.dgvTotais.Name = "dgvTotais";
            this.dgvTotais.ReadOnly = true;
            this.dgvTotais.Size = new System.Drawing.Size(996, 252);
            this.dgvTotais.TabIndex = 4;
            // 
            // excel
            // 
            this.excel.Location = new System.Drawing.Point(875, 36);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(88, 34);
            this.excel.TabIndex = 21;
            this.excel.Text = "Exportar para excel";
            this.excel.UseVisualStyleBackColor = true;
            this.excel.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPorc
            // 
            this.txtPorc.Location = new System.Drawing.Point(404, 44);
            this.txtPorc.Name = "txtPorc";
            this.txtPorc.Size = new System.Drawing.Size(63, 20);
            this.txtPorc.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Porcentagem";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dvgFunci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 586);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPorc);
            this.Controls.Add(this.excel);
            this.Controls.Add(this.selNew);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtCiclo);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.btnAtualizar);
            this.Icon = global::Aplication.Resources.Resource1.smart;
            this.Name = "dvgFunci";
            this.Text = "Relatório de Quantidade de Cobrança";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dvgFunci_Load);
            this.selNew.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunci2)).EndInit();
            this.Totais.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.ComboBox txtBase;
        private System.Windows.Forms.ComboBox txtCiclo;
        private System.Windows.Forms.ComboBox txtMes;
        private System.Windows.Forms.ComboBox txtAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TabControl selNew;
        private System.Windows.Forms.TabPage Principal;
        private System.Windows.Forms.TabPage Totais;
        private System.Windows.Forms.Button excel;
        private System.Windows.Forms.TextBox txtPorc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvFunci2;
        private System.Windows.Forms.DataGridView dgvTotais;
    }
}

