namespace UIGestaoAcademia
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
            components = new System.ComponentModel.Container();
            comboBoxBuscarPor = new ComboBox();
            dataGridViewProduto = new DataGridView();
            buttonSelecionar = new Button();
            label2 = new Label();
            label1 = new Label();
            buttonCancelar = new Button();
            textBoxBuscarPor = new TextBox();
            buttonExcluir = new Button();
            buttonInserir = new Button();
            buttonAlterar = new Button();
            buttonBuscar = new Button();
            controleDebitoBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorDebitoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            formaPagamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataLancamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataVencimentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataPagamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            jurosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descontoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            acrescimoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)controleDebitoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Correntes", "Pagos", "Vencidos", "Todos" });
            comboBoxBuscarPor.Location = new Point(9, 56);
            comboBoxBuscarPor.Margin = new Padding(3, 2, 3, 2);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(126, 23);
            comboBoxBuscarPor.TabIndex = 32;
            // 
            // dataGridViewProduto
            // 
            dataGridViewProduto.AllowUserToAddRows = false;
            dataGridViewProduto.AllowUserToDeleteRows = false;
            dataGridViewProduto.AllowUserToOrderColumns = true;
            dataGridViewProduto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProduto.AutoGenerateColumns = false;
            dataGridViewProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduto.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, valorDebitoDataGridViewTextBoxColumn, formaPagamentoDataGridViewTextBoxColumn, dataLancamentoDataGridViewTextBoxColumn, dataVencimentoDataGridViewTextBoxColumn, dataPagamentoDataGridViewTextBoxColumn, jurosDataGridViewTextBoxColumn, descontoDataGridViewTextBoxColumn, acrescimoDataGridViewTextBoxColumn });
            dataGridViewProduto.DataSource = controleDebitoBindingSource;
            dataGridViewProduto.Location = new Point(10, 83);
            dataGridViewProduto.Margin = new Padding(3, 2, 3, 2);
            dataGridViewProduto.Name = "dataGridViewProduto";
            dataGridViewProduto.ReadOnly = true;
            dataGridViewProduto.RowHeadersWidth = 51;
            dataGridViewProduto.RowTemplate.Height = 29;
            dataGridViewProduto.Size = new Size(879, 252);
            dataGridViewProduto.TabIndex = 28;
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSelecionar.Location = new Point(721, 339);
            buttonSelecionar.Margin = new Padding(3, 2, 3, 2);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(82, 22);
            buttonSelecionar.TabIndex = 29;
            buttonSelecionar.Text = "Se&lecionar";
            buttonSelecionar.TextAlign = ContentAlignment.TopCenter;
            buttonSelecionar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(10, 38);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 31;
            label2.Text = "Buscar por";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(897, 50);
            label1.TabIndex = 22;
            label1.Text = "Buscar debito\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.Location = new Point(807, 339);
            buttonCancelar.Margin = new Padding(3, 2, 3, 2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(82, 22);
            buttonCancelar.TabIndex = 30;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.TextAlign = ContentAlignment.TopCenter;
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscarPor
            // 
            textBoxBuscarPor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxBuscarPor.Location = new Point(140, 56);
            textBoxBuscarPor.Margin = new Padding(3, 2, 3, 2);
            textBoxBuscarPor.Name = "textBoxBuscarPor";
            textBoxBuscarPor.Size = new Size(398, 23);
            textBoxBuscarPor.TabIndex = 23;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonExcluir.Location = new Point(807, 56);
            buttonExcluir.Margin = new Padding(3, 2, 3, 2);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(82, 22);
            buttonExcluir.TabIndex = 36;
            buttonExcluir.Text = "E&xcluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click_1;
            // 
            // buttonInserir
            // 
            buttonInserir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonInserir.Location = new Point(719, 56);
            buttonInserir.Margin = new Padding(3, 2, 3, 2);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(82, 22);
            buttonInserir.TabIndex = 35;
            buttonInserir.Text = "&Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            buttonInserir.Click += buttonInserir_Click_1;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAlterar.Location = new Point(632, 57);
            buttonAlterar.Margin = new Padding(3, 2, 3, 2);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(82, 22);
            buttonAlterar.TabIndex = 34;
            buttonAlterar.Text = "&Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonBuscar.Location = new Point(544, 57);
            buttonBuscar.Margin = new Padding(3, 2, 3, 2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(82, 22);
            buttonBuscar.TabIndex = 33;
            buttonBuscar.Text = "&Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click_1;
            // 
            // controleDebitoBindingSource
            // 
            controleDebitoBindingSource.DataSource = typeof(Models.ControleDebito);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDebitoDataGridViewTextBoxColumn
            // 
            valorDebitoDataGridViewTextBoxColumn.DataPropertyName = "ValorDebito";
            valorDebitoDataGridViewTextBoxColumn.HeaderText = "ValorDebito";
            valorDebitoDataGridViewTextBoxColumn.Name = "valorDebitoDataGridViewTextBoxColumn";
            valorDebitoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formaPagamentoDataGridViewTextBoxColumn
            // 
            formaPagamentoDataGridViewTextBoxColumn.DataPropertyName = "FormaPagamento";
            formaPagamentoDataGridViewTextBoxColumn.HeaderText = "FormaPagamento";
            formaPagamentoDataGridViewTextBoxColumn.Name = "formaPagamentoDataGridViewTextBoxColumn";
            formaPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataLancamentoDataGridViewTextBoxColumn
            // 
            dataLancamentoDataGridViewTextBoxColumn.DataPropertyName = "DataLancamento";
            dataLancamentoDataGridViewTextBoxColumn.HeaderText = "DataLancamento";
            dataLancamentoDataGridViewTextBoxColumn.Name = "dataLancamentoDataGridViewTextBoxColumn";
            dataLancamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataVencimentoDataGridViewTextBoxColumn
            // 
            dataVencimentoDataGridViewTextBoxColumn.DataPropertyName = "DataVencimento";
            dataVencimentoDataGridViewTextBoxColumn.HeaderText = "DataVencimento";
            dataVencimentoDataGridViewTextBoxColumn.Name = "dataVencimentoDataGridViewTextBoxColumn";
            dataVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataPagamentoDataGridViewTextBoxColumn
            // 
            dataPagamentoDataGridViewTextBoxColumn.DataPropertyName = "DataPagamento";
            dataPagamentoDataGridViewTextBoxColumn.HeaderText = "DataPagamento";
            dataPagamentoDataGridViewTextBoxColumn.Name = "dataPagamentoDataGridViewTextBoxColumn";
            dataPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jurosDataGridViewTextBoxColumn
            // 
            jurosDataGridViewTextBoxColumn.DataPropertyName = "Juros";
            jurosDataGridViewTextBoxColumn.HeaderText = "Juros";
            jurosDataGridViewTextBoxColumn.Name = "jurosDataGridViewTextBoxColumn";
            jurosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descontoDataGridViewTextBoxColumn
            // 
            descontoDataGridViewTextBoxColumn.DataPropertyName = "Desconto";
            descontoDataGridViewTextBoxColumn.HeaderText = "Desconto";
            descontoDataGridViewTextBoxColumn.Name = "descontoDataGridViewTextBoxColumn";
            descontoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // acrescimoDataGridViewTextBoxColumn
            // 
            acrescimoDataGridViewTextBoxColumn.DataPropertyName = "Acrescimo";
            acrescimoDataGridViewTextBoxColumn.HeaderText = "Acrescimo";
            acrescimoDataGridViewTextBoxColumn.Name = "acrescimoDataGridViewTextBoxColumn";
            acrescimoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormBuscarDebito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 366);
            Controls.Add(textBoxBuscarPor);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonInserir);
            Controls.Add(buttonAlterar);
            Controls.Add(buttonBuscar);
            Controls.Add(comboBoxBuscarPor);
            Controls.Add(dataGridViewProduto);
            Controls.Add(buttonSelecionar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancelar);
            Name = "FormBuscarDebito";
            Text = "FormControleProduto";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)controleDebitoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxBuscarPor;
        private DataGridView dataGridViewProduto;
        private Button buttonSelecionar;
        private Label label2;
        private Label label1;
        private Button buttonCancelar;
        private TextBox textBoxBuscarPor;
        private Button buttonExcluir;
        private Button buttonInserir;
        private Button buttonAlterar;
        private Button buttonBuscar;
        private BindingSource controleDebitoBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorDebitoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn formaPagamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataPagamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jurosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn acrescimoDataGridViewTextBoxColumn;
    }
}