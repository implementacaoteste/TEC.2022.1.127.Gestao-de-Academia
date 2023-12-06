﻿namespace UIGestaoAcademia
{
    partial class FormBuscarDebito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.dataGridViewProduto = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDebitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLancamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acrescimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controleDebitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxBuscarPor = new System.Windows.Forms.TextBox();
            this.buttonExcluirDebito = new System.Windows.Forms.Button();
            this.buttonInserirDebito = new System.Windows.Forms.Button();
            this.buttonAlterarDebito = new System.Windows.Forms.Button();
            this.buttonBuscarDebito = new System.Windows.Forms.Button();
            this.textBoxDataFinal = new System.Windows.Forms.TextBox();
            this.labelE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDebitoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "Todos",
            "Clientes",
            "Correntes",
            "Pagos",
            "Vencidos",
            "Data de vencimento entre:",
            "Data de pagamento entre:",
            "Data de lançamento entre:"});
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(10, 56);
            this.comboBoxBuscarPor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(176, 23);
            this.comboBoxBuscarPor.TabIndex = 32;
            this.comboBoxBuscarPor.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuscarPor_SelectedIndexChanged);
            // 
            // dataGridViewProduto
            // 
            this.dataGridViewProduto.AllowUserToAddRows = false;
            this.dataGridViewProduto.AllowUserToDeleteRows = false;
            this.dataGridViewProduto.AllowUserToOrderColumns = true;
            this.dataGridViewProduto.AutoGenerateColumns = false;
            this.dataGridViewProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.NomeCliente,
            this.valorDebitoDataGridViewTextBoxColumn,
            this.NomeFormaPagamento,
            this.dataLancamentoDataGridViewTextBoxColumn,
            this.dataVencimentoDataGridViewTextBoxColumn,
            this.dataPagamentoDataGridViewTextBoxColumn,
            this.jurosDataGridViewTextBoxColumn,
            this.descontoDataGridViewTextBoxColumn,
            this.acrescimoDataGridViewTextBoxColumn});
            this.dataGridViewProduto.DataSource = this.controleDebitoBindingSource;
            this.dataGridViewProduto.Location = new System.Drawing.Point(10, 83);
            this.dataGridViewProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewProduto.Name = "dataGridViewProduto";
            this.dataGridViewProduto.ReadOnly = true;
            this.dataGridViewProduto.RowHeadersWidth = 51;
            this.dataGridViewProduto.RowTemplate.Height = 29;
            this.dataGridViewProduto.Size = new System.Drawing.Size(1094, 252);
            this.dataGridViewProduto.TabIndex = 28;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // NomeCliente
            // 
            this.NomeCliente.DataPropertyName = "NomeCliente";
            this.NomeCliente.HeaderText = "NomeCliente";
            this.NomeCliente.MinimumWidth = 6;
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.ReadOnly = true;
            this.NomeCliente.Width = 125;
            // 
            // valorDebitoDataGridViewTextBoxColumn
            // 
            this.valorDebitoDataGridViewTextBoxColumn.DataPropertyName = "ValorDebito";
            this.valorDebitoDataGridViewTextBoxColumn.HeaderText = "ValorDebito";
            this.valorDebitoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorDebitoDataGridViewTextBoxColumn.Name = "valorDebitoDataGridViewTextBoxColumn";
            this.valorDebitoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorDebitoDataGridViewTextBoxColumn.Width = 125;
            // 
            // NomeFormaPagamento
            // 
            this.NomeFormaPagamento.DataPropertyName = "NomeFormaPagamento";
            this.NomeFormaPagamento.HeaderText = "Forma de pagamento";
            this.NomeFormaPagamento.MinimumWidth = 6;
            this.NomeFormaPagamento.Name = "NomeFormaPagamento";
            this.NomeFormaPagamento.ReadOnly = true;
            this.NomeFormaPagamento.Width = 125;
            // 
            // dataLancamentoDataGridViewTextBoxColumn
            // 
            this.dataLancamentoDataGridViewTextBoxColumn.DataPropertyName = "DataLancamento";
            this.dataLancamentoDataGridViewTextBoxColumn.HeaderText = "DataLancamento";
            this.dataLancamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataLancamentoDataGridViewTextBoxColumn.Name = "dataLancamentoDataGridViewTextBoxColumn";
            this.dataLancamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataLancamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataVencimentoDataGridViewTextBoxColumn
            // 
            this.dataVencimentoDataGridViewTextBoxColumn.DataPropertyName = "DataVencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.HeaderText = "Data de vencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataVencimentoDataGridViewTextBoxColumn.Name = "dataVencimentoDataGridViewTextBoxColumn";
            this.dataVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataVencimentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataPagamentoDataGridViewTextBoxColumn
            // 
            this.dataPagamentoDataGridViewTextBoxColumn.DataPropertyName = "DataPagamento";
            this.dataPagamentoDataGridViewTextBoxColumn.HeaderText = "DataPagamento";
            this.dataPagamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataPagamentoDataGridViewTextBoxColumn.Name = "dataPagamentoDataGridViewTextBoxColumn";
            this.dataPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataPagamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // jurosDataGridViewTextBoxColumn
            // 
            this.jurosDataGridViewTextBoxColumn.DataPropertyName = "Juros";
            this.jurosDataGridViewTextBoxColumn.HeaderText = "Juros";
            this.jurosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jurosDataGridViewTextBoxColumn.Name = "jurosDataGridViewTextBoxColumn";
            this.jurosDataGridViewTextBoxColumn.ReadOnly = true;
            this.jurosDataGridViewTextBoxColumn.Width = 125;
            // 
            // descontoDataGridViewTextBoxColumn
            // 
            this.descontoDataGridViewTextBoxColumn.DataPropertyName = "Desconto";
            this.descontoDataGridViewTextBoxColumn.HeaderText = "Desconto";
            this.descontoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descontoDataGridViewTextBoxColumn.Name = "descontoDataGridViewTextBoxColumn";
            this.descontoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descontoDataGridViewTextBoxColumn.Width = 125;
            // 
            // acrescimoDataGridViewTextBoxColumn
            // 
            this.acrescimoDataGridViewTextBoxColumn.DataPropertyName = "Acrescimo";
            this.acrescimoDataGridViewTextBoxColumn.HeaderText = "Acrescimo";
            this.acrescimoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.acrescimoDataGridViewTextBoxColumn.Name = "acrescimoDataGridViewTextBoxColumn";
            this.acrescimoDataGridViewTextBoxColumn.ReadOnly = true;
            this.acrescimoDataGridViewTextBoxColumn.Width = 125;
            // 
            // controleDebitoBindingSource
            // 
            this.controleDebitoBindingSource.DataSource = typeof(Models.ControleDebito);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelecionar.Location = new System.Drawing.Point(934, 339);
            this.buttonSelecionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(82, 22);
            this.buttonSelecionar.TabIndex = 29;
            this.buttonSelecionar.Text = "Se&lecionar";
            this.buttonSelecionar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Buscar por";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1110, 50);
            this.label1.TabIndex = 22;
            this.label1.Text = "Buscar debito\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.Location = new System.Drawing.Point(1020, 339);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(82, 22);
            this.buttonCancelar.TabIndex = 30;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscarPor
            // 
            this.textBoxBuscarPor.Location = new System.Drawing.Point(189, 56);
            this.textBoxBuscarPor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBuscarPor.Name = "textBoxBuscarPor";
            this.textBoxBuscarPor.Size = new System.Drawing.Size(275, 23);
            this.textBoxBuscarPor.TabIndex = 23;
            // 
            // buttonExcluirDebito
            // 
            this.buttonExcluirDebito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluirDebito.Location = new System.Drawing.Point(1022, 57);
            this.buttonExcluirDebito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExcluirDebito.Name = "buttonExcluirDebito";
            this.buttonExcluirDebito.Size = new System.Drawing.Size(82, 22);
            this.buttonExcluirDebito.TabIndex = 36;
            this.buttonExcluirDebito.Text = "E&xcluir";
            this.buttonExcluirDebito.UseVisualStyleBackColor = true;
            this.buttonExcluirDebito.Click += new System.EventHandler(this.buttonExcluir_Click_1);
            // 
            // buttonInserirDebito
            // 
            this.buttonInserirDebito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInserirDebito.Location = new System.Drawing.Point(934, 57);
            this.buttonInserirDebito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInserirDebito.Name = "buttonInserirDebito";
            this.buttonInserirDebito.Size = new System.Drawing.Size(82, 22);
            this.buttonInserirDebito.TabIndex = 35;
            this.buttonInserirDebito.Text = "&Inserir";
            this.buttonInserirDebito.UseVisualStyleBackColor = true;
            this.buttonInserirDebito.Click += new System.EventHandler(this.buttonInserir_Click_1);
            // 
            // buttonAlterarDebito
            // 
            this.buttonAlterarDebito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterarDebito.Location = new System.Drawing.Point(847, 57);
            this.buttonAlterarDebito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAlterarDebito.Name = "buttonAlterarDebito";
            this.buttonAlterarDebito.Size = new System.Drawing.Size(82, 22);
            this.buttonAlterarDebito.TabIndex = 34;
            this.buttonAlterarDebito.Text = "&Alterar";
            this.buttonAlterarDebito.UseVisualStyleBackColor = true;
            this.buttonAlterarDebito.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonBuscarDebito
            // 
            this.buttonBuscarDebito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscarDebito.Location = new System.Drawing.Point(766, 57);
            this.buttonBuscarDebito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarDebito.Name = "buttonBuscarDebito";
            this.buttonBuscarDebito.Size = new System.Drawing.Size(75, 22);
            this.buttonBuscarDebito.TabIndex = 33;
            this.buttonBuscarDebito.Text = "&Buscar";
            this.buttonBuscarDebito.UseVisualStyleBackColor = true;
            this.buttonBuscarDebito.Click += new System.EventHandler(this.buttonBuscar_Click_1);
            // 
            // textBoxDataFinal
            // 
            this.textBoxDataFinal.Location = new System.Drawing.Point(489, 56);
            this.textBoxDataFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDataFinal.Name = "textBoxDataFinal";
            this.textBoxDataFinal.Size = new System.Drawing.Size(274, 23);
            this.textBoxDataFinal.TabIndex = 23;
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Location = new System.Drawing.Point(470, 59);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(13, 15);
            this.labelE.TabIndex = 31;
            this.labelE.Text = "e";
            // 
            // FormBuscarDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 372);
            this.Controls.Add(this.textBoxDataFinal);
            this.Controls.Add(this.textBoxBuscarPor);
            this.Controls.Add(this.buttonExcluirDebito);
            this.Controls.Add(this.buttonInserirDebito);
            this.Controls.Add(this.buttonAlterarDebito);
            this.Controls.Add(this.buttonBuscarDebito);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.dataGridViewProduto);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.labelE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.MinimumSize = new System.Drawing.Size(870, 411);
            this.Name = "FormBuscarDebito";
            this.Text = "FormControleProduto";
            this.Load += new System.EventHandler(this.FormBuscarDebito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDebitoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxBuscarPor;
        private DataGridView dataGridViewProduto;
        private Button buttonSelecionar;
        private Label label2;
        private Label label1;
        private Button buttonCancelar;
        private TextBox textBoxBuscarPor;
        private Button buttonExcluirDebito;
        private Button buttonInserirDebito;
        private Button buttonAlterarDebito;
        private Button buttonBuscarDebito;
        private BindingSource controleDebitoBindingSource;
        private TextBox textBoxDataFinal;
        private Label labelE;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn NomeCliente;
        private DataGridViewTextBoxColumn valorDebitoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn NomeFormaPagamento;
        private DataGridViewTextBoxColumn dataLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataPagamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jurosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn acrescimoDataGridViewTextBoxColumn;
    }
}