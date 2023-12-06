﻿namespace UIGestaoAcademia
{
    partial class FormCompra
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
            this.buttonBuscarProduto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itensCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.textBoxBuscarFormaPagamento = new System.Windows.Forms.TextBox();
            this.buttonFormaDePagamento = new System.Windows.Forms.Button();
            this.textBoxBuscarFornecedor = new System.Windows.Forms.TextBox();
            this.buttonBuscarFornecedor = new System.Windows.Forms.Button();
            this.textBoxCodigoDeBarras = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSourceCompraProduto = new System.Windows.Forms.BindingSource(this.components);
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxValorProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCompraProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuscarProduto
            // 
            this.buttonBuscarProduto.Location = new System.Drawing.Point(852, 245);
            this.buttonBuscarProduto.Name = "buttonBuscarProduto";
            this.buttonBuscarProduto.Size = new System.Drawing.Size(29, 29);
            this.buttonBuscarProduto.TabIndex = 51;
            this.buttonBuscarProduto.Text = "...";
            this.buttonBuscarProduto.UseVisualStyleBackColor = true;
            this.buttonBuscarProduto.Click += new System.EventHandler(this.buttonBuscarProduto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorUnitarioDataGridViewTextBoxColumn,
            this.valorTotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itensCompraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(869, 333);
            this.dataGridView1.TabIndex = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaDataGridViewTextBoxColumn.Width = 200;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorUnitarioDataGridViewTextBoxColumn
            // 
            this.valorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitario";
            this.valorUnitarioDataGridViewTextBoxColumn.HeaderText = "ValorUnitario";
            this.valorUnitarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorUnitarioDataGridViewTextBoxColumn.Name = "valorUnitarioDataGridViewTextBoxColumn";
            this.valorUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorUnitarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            this.valorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal";
            this.valorTotalDataGridViewTextBoxColumn.HeaderText = "ValorTotal";
            this.valorTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            this.valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // itensCompraBindingSource
            // 
            this.itensCompraBindingSource.DataSource = typeof(Models.ItensCompra);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(619, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 49;
            this.label12.Text = "Quantidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "Código de barras";
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensCompraBindingSource, "Quantidade", true));
            this.textBoxQuantidade.Location = new System.Drawing.Point(619, 245);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(98, 27);
            this.textBoxQuantidade.TabIndex = 47;
            this.textBoxQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxBuscarFormaPagamento
            // 
            this.textBoxBuscarFormaPagamento.Location = new System.Drawing.Point(179, 154);
            this.textBoxBuscarFormaPagamento.Name = "textBoxBuscarFormaPagamento";
            this.textBoxBuscarFormaPagamento.Size = new System.Drawing.Size(125, 27);
            this.textBoxBuscarFormaPagamento.TabIndex = 44;
            // 
            // buttonFormaDePagamento
            // 
            this.buttonFormaDePagamento.Location = new System.Drawing.Point(310, 154);
            this.buttonFormaDePagamento.Name = "buttonFormaDePagamento";
            this.buttonFormaDePagamento.Size = new System.Drawing.Size(33, 29);
            this.buttonFormaDePagamento.TabIndex = 43;
            this.buttonFormaDePagamento.Text = "...";
            this.buttonFormaDePagamento.UseVisualStyleBackColor = true;
            this.buttonFormaDePagamento.Click += new System.EventHandler(this.buttonFormaDePagamento_Click);
            // 
            // textBoxBuscarFornecedor
            // 
            this.textBoxBuscarFornecedor.Location = new System.Drawing.Point(102, 121);
            this.textBoxBuscarFornecedor.Name = "textBoxBuscarFornecedor";
            this.textBoxBuscarFornecedor.Size = new System.Drawing.Size(202, 27);
            this.textBoxBuscarFornecedor.TabIndex = 42;
            // 
            // buttonBuscarFornecedor
            // 
            this.buttonBuscarFornecedor.Location = new System.Drawing.Point(310, 121);
            this.buttonBuscarFornecedor.Name = "buttonBuscarFornecedor";
            this.buttonBuscarFornecedor.Size = new System.Drawing.Size(33, 29);
            this.buttonBuscarFornecedor.TabIndex = 41;
            this.buttonBuscarFornecedor.Text = "...";
            this.buttonBuscarFornecedor.UseVisualStyleBackColor = true;
            this.buttonBuscarFornecedor.Click += new System.EventHandler(this.buttonBuscarFornecedor_Click);
            // 
            // textBoxCodigoDeBarras
            // 
            this.textBoxCodigoDeBarras.Location = new System.Drawing.Point(13, 245);
            this.textBoxCodigoDeBarras.Name = "textBoxCodigoDeBarras";
            this.textBoxCodigoDeBarras.Size = new System.Drawing.Size(161, 27);
            this.textBoxCodigoDeBarras.TabIndex = 46;
            this.textBoxCodigoDeBarras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxProduto_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Forma de pagamento";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(889, 68);
            this.label2.TabIndex = 27;
            this.label2.Text = "Compra de produto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Fornecedor";
            // 
            // bindingSourceCompraProduto
            // 
            this.bindingSourceCompraProduto.DataSource = typeof(Models.CompraProduto);
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Font = new System.Drawing.Font("Segoe UI", 20.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValorTotal.Location = new System.Drawing.Point(717, 68);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(0, 46);
            this.labelValorTotal.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "TOTAL DA COMPRA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(485, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 27);
            this.textBox1.TabIndex = 54;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "VALOR DO FRETE";
            // 
            // textBoxValorProduto
            // 
            this.textBoxValorProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensCompraBindingSource, "ValorUnitario", true));
            this.textBoxValorProduto.Location = new System.Drawing.Point(723, 245);
            this.textBoxValorProduto.Name = "textBoxValorProduto";
            this.textBoxValorProduto.Size = new System.Drawing.Size(123, 27);
            this.textBoxValorProduto.TabIndex = 56;
            this.textBoxValorProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxValorProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(723, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Valor do produto";
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensCompraBindingSource, "Nome", true));
            this.textBoxNomeProduto.Location = new System.Drawing.Point(182, 245);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(431, 27);
            this.textBoxNomeProduto.TabIndex = 46;
            this.textBoxNomeProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxProduto_KeyDown);
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 689);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxValorProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelValorTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonBuscarProduto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.textBoxBuscarFormaPagamento);
            this.Controls.Add(this.buttonFormaDePagamento);
            this.Controls.Add(this.textBoxBuscarFornecedor);
            this.Controls.Add(this.buttonBuscarFornecedor);
            this.Controls.Add(this.textBoxNomeProduto);
            this.Controls.Add(this.textBoxCodigoDeBarras);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "FormCompra";
            this.Text = "FormCompra";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCompraProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonBuscarProduto;
        private DataGridView dataGridView1;
        private Label label12;
        private Label label10;
        private TextBox textBoxQuantidade;
        private TextBox textBoxBuscarFormaPagamento;
        private Button buttonFormaDePagamento;
        private TextBox textBoxBuscarFornecedor;
        private Button buttonBuscarFornecedor;
        private TextBox textBoxCodigoDeBarras;
        private Label label8;
        private Label label2;
        private Label label3;
        private BindingSource itensCompraBindingSource;
        private BindingSource bindingSourceCompraProduto;
        private Label labelValorTotal;
        private Label label4;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBoxValorProduto;
        private Label label5;
        private TextBox textBoxNomeProduto;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
    }
}