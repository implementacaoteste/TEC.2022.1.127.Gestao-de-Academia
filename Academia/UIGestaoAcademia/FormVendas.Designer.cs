﻿namespace UIGestaoAcademia
{
    partial class FormVendas
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
            labelCliente = new Label();
            labelUser = new Label();
            itensVendaBindingSource = new BindingSource(components);
            textBoxBuscarPorCliente = new TextBox();
            vendaBindingSource = new BindingSource(components);
            buttonFinalizarVenda = new Button();
            label6 = new Label();
            textBox4 = new TextBox();
            labelData = new Label();
            label8 = new Label();
            buttonBuscarCliente = new Button();
            buttonFormaDePagamento = new Button();
            textBoxFormaPagamento = new TextBox();
            buttonExcluir = new Button();
            textBoxProduto = new TextBox();
            textBoxQuantidade = new TextBox();
            label10 = new Label();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            codigoDeBarrasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeProdutoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantidadeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            buttonBuscarProduto = new Button();
            labelValorTotal = new Label();
            labelVenda = new Label();
            label4 = new Label();
            groupBoxVenda = new GroupBox();
            calendarioDataVencimento = new Calendario();
            labelCodigoVenda = new Label();
            labeUser = new Label();
            pictureBoxVenda = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)itensVendaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vendaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVenda).BeginInit();
            SuspendLayout();
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(218, 22);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(64, 20);
            labelCliente.TabIndex = 11;
            labelCliente.Text = "CLIENTE";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.BackColor = Color.Transparent;
            labelUser.ForeColor = Color.Black;
            labelUser.Location = new Point(15, 14);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(41, 20);
            labelUser.TabIndex = 10;
            labelUser.Text = "User:";
            // 
            // itensVendaBindingSource
            // 
            itensVendaBindingSource.DataSource = typeof(Models.ItensVenda);
            // 
            // textBoxBuscarPorCliente
            // 
            textBoxBuscarPorCliente.DataBindings.Add(new Binding("Text", vendaBindingSource, "ClienteId", true));
            textBoxBuscarPorCliente.Location = new Point(288, 17);
            textBoxBuscarPorCliente.Name = "textBoxBuscarPorCliente";
            textBoxBuscarPorCliente.Size = new Size(398, 27);
            textBoxBuscarPorCliente.TabIndex = 2;
            // 
            // vendaBindingSource
            // 
            vendaBindingSource.DataSource = typeof(Models.Venda);
            // 
            // buttonFinalizarVenda
            // 
            buttonFinalizarVenda.Location = new Point(766, 128);
            buttonFinalizarVenda.Name = "buttonFinalizarVenda";
            buttonFinalizarVenda.Size = new Size(147, 41);
            buttonFinalizarVenda.TabIndex = 19;
            buttonFinalizarVenda.Text = "&Finalizar venda";
            buttonFinalizarVenda.UseVisualStyleBackColor = true;
            buttonFinalizarVenda.Click += buttonFinalizarVenda_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 742);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 11;
            label6.Text = "Desconto";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(172, 744);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 5;
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Location = new Point(732, 22);
            labelData.Name = "labelData";
            labelData.Size = new Size(46, 20);
            labelData.TabIndex = 8;
            labelData.Text = "DATA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 712);
            label8.Name = "label8";
            label8.Size = new Size(153, 20);
            label8.TabIndex = 11;
            label8.Text = "Forma de pagamento";
            // 
            // buttonBuscarCliente
            // 
            buttonBuscarCliente.Location = new Point(692, 17);
            buttonBuscarCliente.Name = "buttonBuscarCliente";
            buttonBuscarCliente.Size = new Size(33, 29);
            buttonBuscarCliente.TabIndex = 3;
            buttonBuscarCliente.Text = "...";
            buttonBuscarCliente.UseVisualStyleBackColor = true;
            buttonBuscarCliente.Click += buttonBuscarCliente_Click;
            // 
            // buttonFormaDePagamento
            // 
            buttonFormaDePagamento.Location = new Point(303, 709);
            buttonFormaDePagamento.Name = "buttonFormaDePagamento";
            buttonFormaDePagamento.Size = new Size(33, 29);
            buttonFormaDePagamento.TabIndex = 16;
            buttonFormaDePagamento.Text = "...";
            buttonFormaDePagamento.UseVisualStyleBackColor = true;
            buttonFormaDePagamento.Click += buttonFormaDePagamento_Click;
            // 
            // textBoxFormaPagamento
            // 
            textBoxFormaPagamento.DataBindings.Add(new Binding("Text", vendaBindingSource, "FormaPagamentoId", true));
            textBoxFormaPagamento.Location = new Point(172, 709);
            textBoxFormaPagamento.Name = "textBoxFormaPagamento";
            textBoxFormaPagamento.Size = new Size(125, 27);
            textBoxFormaPagamento.TabIndex = 17;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(607, 129);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(153, 40);
            buttonExcluir.TabIndex = 1;
            buttonExcluir.Text = "&Excluir item";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // textBoxProduto
            // 
            textBoxProduto.Location = new Point(122, 143);
            textBoxProduto.Name = "textBoxProduto";
            textBoxProduto.Size = new Size(161, 27);
            textBoxProduto.TabIndex = 6;
            textBoxProduto.KeyDown += textBoxProduto_KeyDown;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(10, 142);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(98, 27);
            textBoxQuantidade.TabIndex = 8;
            textBoxQuantidade.Text = "1";
            textBoxQuantidade.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(122, 114);
            label10.Name = "label10";
            label10.Size = new Size(124, 20);
            label10.TabIndex = 12;
            label10.Text = "Código de barras";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 113);
            label12.Name = "label12";
            label12.Size = new Size(87, 20);
            label12.TabIndex = 10;
            label12.Text = "Quantidade";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigoDeBarrasDataGridViewTextBoxColumn, nomeProdutoDataGridViewTextBoxColumn, quantidadeDataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView1.DataSource = itensVendaBindingSource;
            dataGridView1.Location = new Point(12, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(903, 288);
            dataGridView1.TabIndex = 2;
            // 
            // codigoDeBarrasDataGridViewTextBoxColumn
            // 
            codigoDeBarrasDataGridViewTextBoxColumn.DataPropertyName = "CodigoDeBarras";
            codigoDeBarrasDataGridViewTextBoxColumn.HeaderText = "CodigoDeBarras";
            codigoDeBarrasDataGridViewTextBoxColumn.MinimumWidth = 6;
            codigoDeBarrasDataGridViewTextBoxColumn.Name = "codigoDeBarrasDataGridViewTextBoxColumn";
            codigoDeBarrasDataGridViewTextBoxColumn.ReadOnly = true;
            codigoDeBarrasDataGridViewTextBoxColumn.Width = 180;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            nomeProdutoDataGridViewTextBoxColumn.HeaderText = "NomeProduto";
            nomeProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            nomeProdutoDataGridViewTextBoxColumn.Width = 300;
            // 
            // quantidadeDataGridViewTextBoxColumn1
            // 
            quantidadeDataGridViewTextBoxColumn1.DataPropertyName = "Quantidade";
            quantidadeDataGridViewTextBoxColumn1.HeaderText = "Quantidade";
            quantidadeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            quantidadeDataGridViewTextBoxColumn1.Name = "quantidadeDataGridViewTextBoxColumn1";
            quantidadeDataGridViewTextBoxColumn1.ReadOnly = true;
            quantidadeDataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "PrecoUnitario";
            dataGridViewTextBoxColumn3.HeaderText = "PrecoUnitario";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "PrecoTotal";
            dataGridViewTextBoxColumn4.HeaderText = "PrecoTotal";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // buttonBuscarProduto
            // 
            buttonBuscarProduto.Location = new Point(299, 143);
            buttonBuscarProduto.Name = "buttonBuscarProduto";
            buttonBuscarProduto.Size = new Size(29, 29);
            buttonBuscarProduto.TabIndex = 7;
            buttonBuscarProduto.Text = "...";
            buttonBuscarProduto.UseVisualStyleBackColor = true;
            buttonBuscarProduto.Click += buttonBuscarProduto_Click;
            // 
            // labelValorTotal
            // 
            labelValorTotal.AutoSize = true;
            labelValorTotal.DataBindings.Add(new Binding("Text", vendaBindingSource, "TotalVenda", true));
            labelValorTotal.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelValorTotal.Location = new Point(692, 689);
            labelValorTotal.Name = "labelValorTotal";
            labelValorTotal.Size = new Size(157, 62);
            labelValorTotal.TabIndex = 23;
            labelValorTotal.Text = "TOTAL";
            // 
            // labelVenda
            // 
            labelVenda.AutoSize = true;
            labelVenda.BackColor = Color.Transparent;
            labelVenda.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelVenda.Location = new Point(619, 14);
            labelVenda.Name = "labelVenda";
            labelVenda.Size = new Size(185, 41);
            labelVenda.TabIndex = 10;
            labelVenda.Text = "Cod. Venda:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(384, 695);
            label4.Name = "label4";
            label4.Size = new Size(300, 54);
            label4.TabIndex = 0;
            label4.Text = "TOTAL VENDA:";
            // 
            // groupBoxVenda
            // 
            groupBoxVenda.Controls.Add(calendarioDataVencimento);
            groupBoxVenda.Controls.Add(buttonExcluir);
            groupBoxVenda.Controls.Add(buttonFinalizarVenda);
            groupBoxVenda.Controls.Add(textBoxProduto);
            groupBoxVenda.Controls.Add(dataGridView1);
            groupBoxVenda.Controls.Add(buttonBuscarProduto);
            groupBoxVenda.Controls.Add(textBoxQuantidade);
            groupBoxVenda.Controls.Add(label10);
            groupBoxVenda.Controls.Add(buttonBuscarCliente);
            groupBoxVenda.Controls.Add(label12);
            groupBoxVenda.Controls.Add(labelCliente);
            groupBoxVenda.Controls.Add(textBoxBuscarPorCliente);
            groupBoxVenda.Controls.Add(labelData);
            groupBoxVenda.Location = new Point(15, 192);
            groupBoxVenda.Name = "groupBoxVenda";
            groupBoxVenda.Size = new Size(924, 500);
            groupBoxVenda.TabIndex = 24;
            groupBoxVenda.TabStop = false;
            groupBoxVenda.Text = "Nova Venda";
            // 
            // calendarioDataVencimento
            // 
            calendarioDataVencimento.Checked = false;
            calendarioDataVencimento.CustomFormat = " ";
            calendarioDataVencimento.DataBindings.Add(new Binding("Text", vendaBindingSource, "DataVenda", true));
            calendarioDataVencimento.Format = DateTimePickerFormat.Custom;
            calendarioDataVencimento.Location = new Point(779, 19);
            calendarioDataVencimento.Name = "calendarioDataVencimento";
            calendarioDataVencimento.RightToLeftLayout = true;
            calendarioDataVencimento.ShowCheckBox = true;
            calendarioDataVencimento.Size = new Size(140, 27);
            calendarioDataVencimento.TabIndex = 27;
            // 
            // labelCodigoVenda
            // 
            labelCodigoVenda.AutoSize = true;
            labelCodigoVenda.BackColor = Color.Transparent;
            labelCodigoVenda.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelCodigoVenda.Location = new Point(795, 2);
            labelCodigoVenda.Name = "labelCodigoVenda";
            labelCodigoVenda.Size = new Size(126, 62);
            labelCodigoVenda.TabIndex = 29;
            labelCodigoVenda.Text = "COD";
            // 
            // labeUser
            // 
            labeUser.AutoSize = true;
            labeUser.BackColor = Color.Transparent;
            labeUser.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labeUser.ForeColor = Color.Black;
            labeUser.Location = new Point(51, 2);
            labeUser.Name = "labeUser";
            labeUser.Size = new Size(90, 41);
            labeUser.TabIndex = 30;
            labeUser.Text = "USER";
            labeUser.Click += labeUser_Click;
            // 
            // pictureBoxVenda
            // 
            pictureBoxVenda.Dock = DockStyle.Fill;
            pictureBoxVenda.Location = new Point(0, 0);
            pictureBoxVenda.Name = "pictureBoxVenda";
            pictureBoxVenda.Size = new Size(954, 863);
            pictureBoxVenda.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxVenda.TabIndex = 31;
            pictureBoxVenda.TabStop = false;
            // 
            // FormVendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(954, 863);
            Controls.Add(labeUser);
            Controls.Add(labelCodigoVenda);
            Controls.Add(label4);
            Controls.Add(labelVenda);
            Controls.Add(labelValorTotal);
            Controls.Add(textBoxFormaPagamento);
            Controls.Add(buttonFormaDePagamento);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(labelUser);
            Controls.Add(groupBoxVenda);
            Controls.Add(pictureBoxVenda);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormVendas";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormVendas_Load;
            ((System.ComponentModel.ISupportInitialize)itensVendaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)vendaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxVenda.ResumeLayout(false);
            groupBoxVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelCliente;
        private Label label3;
        private TextBox textBoxValorTotal;
        private DataGridViewTextBoxColumn produtoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoUnitarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoTotalDataGridViewTextBoxColumn;
        private TextBox textBoxBuscarPorCliente;
        private BindingSource itensVendaBindingSource;
        private Button buttonFinalizarVenda;
        private Label label6;
        private TextBox textBox4;
        private Label labelData;
        private Label label8;
        private Button buttonBuscarCliente;
        private Button buttonFormaDePagamento;
        private TextBox textBoxFormaPagamento;
        private Button buttonExcluir;
        private TextBox textBoxProduto;
        private TextBox textBoxQuantidade;
        private Label label10;
        private Label label12;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn codigoDeBarrasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button buttonBuscarProduto;
        private Label labelValorTotal;
        private Label labelVenda;
        private Label label4;
        private GroupBox groupBoxVenda;
        private Calendario calendarioDataVencimento;
        private Label labelCodigoVenda;
        private BindingSource vendaBindingSource;
        private Label labeUser;
        private Label labelUser;
        private PictureBox pictureBoxVenda;
    }
}