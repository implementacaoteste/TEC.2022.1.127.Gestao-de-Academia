namespace UIGestaoAcademia
{
    partial class FormCadastrarDebito
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
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSourceCadastrarDebito = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDataDoLancamento = new System.Windows.Forms.TextBox();
            this.textBoxFormaDePagamento = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxJuros = new System.Windows.Forms.TextBox();
            this.textBoxDesconto = new System.Windows.Forms.TextBox();
            this.textBoxAcrescimo = new System.Windows.Forms.TextBox();
            this.textBoxDataDoVencimento = new System.Windows.Forms.TextBox();
            this.textBoxDataDoPagamento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastrarDebito)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(919, 53);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cadastrar Debito";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bindingSourceCadastrarDebito
            // 
            this.bindingSourceCadastrarDebito.DataSource = typeof(Models.ControleDebito);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCancelar.Location = new System.Drawing.Point(811, 299);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 32;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSalvar.Location = new System.Drawing.Point(711, 299);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 31;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(609, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Data do lançamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(410, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Forma de pagamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Valor";
            // 
            // textBoxDataDoLancamento
            // 
            this.textBoxDataDoLancamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarDebito, "DataLancamento", true));
            this.textBoxDataDoLancamento.Location = new System.Drawing.Point(609, 142);
            this.textBoxDataDoLancamento.Name = "textBoxDataDoLancamento";
            this.textBoxDataDoLancamento.Size = new System.Drawing.Size(186, 27);
            this.textBoxDataDoLancamento.TabIndex = 30;
            // 
            // textBoxFormaDePagamento
            // 
            this.textBoxFormaDePagamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarDebito, "FormaPagamento", true));
            this.textBoxFormaDePagamento.Location = new System.Drawing.Point(410, 142);
            this.textBoxFormaDePagamento.Name = "textBoxFormaDePagamento";
            this.textBoxFormaDePagamento.Size = new System.Drawing.Size(193, 27);
            this.textBoxFormaDePagamento.TabIndex = 28;
            // 
            // textBoxValor
            // 
            this.textBoxValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarDebito, "ValorDebito", true));
            this.textBoxValor.Location = new System.Drawing.Point(17, 142);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(386, 27);
            this.textBoxValor.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Data do vencimento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(216, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Data do pagamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(414, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Juros";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(609, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Desconto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(17, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Acrescimo";
            // 
            // textBoxJuros
            // 
            this.textBoxJuros.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarDebito, "Juros", true));
            this.textBoxJuros.Location = new System.Drawing.Point(414, 199);
            this.textBoxJuros.Name = "textBoxJuros";
            this.textBoxJuros.Size = new System.Drawing.Size(189, 27);
            this.textBoxJuros.TabIndex = 28;
            // 
            // textBoxDesconto
            // 
            this.textBoxDesconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarDebito, "Desconto", true));
            this.textBoxDesconto.Location = new System.Drawing.Point(609, 199);
            this.textBoxDesconto.Name = "textBoxDesconto";
            this.textBoxDesconto.Size = new System.Drawing.Size(186, 27);
            this.textBoxDesconto.TabIndex = 28;
            // 
            // textBoxAcrescimo
            // 
            this.textBoxAcrescimo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarDebito, "Acrescimo", true));
            this.textBoxAcrescimo.Location = new System.Drawing.Point(17, 251);
            this.textBoxAcrescimo.Name = "textBoxAcrescimo";
            this.textBoxAcrescimo.Size = new System.Drawing.Size(194, 27);
            this.textBoxAcrescimo.TabIndex = 28;
            // 
            // textBoxDataDoVencimento
            // 
            this.textBoxDataDoVencimento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarDebito, "DataVencimento", true));
            this.textBoxDataDoVencimento.Location = new System.Drawing.Point(16, 199);
            this.textBoxDataDoVencimento.Name = "textBoxDataDoVencimento";
            this.textBoxDataDoVencimento.Size = new System.Drawing.Size(193, 27);
            this.textBoxDataDoVencimento.TabIndex = 28;
            // 
            // textBoxDataDoPagamento
            // 
            this.textBoxDataDoPagamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarDebito, "DataPagamento", true));
            this.textBoxDataDoPagamento.Location = new System.Drawing.Point(216, 199);
            this.textBoxDataDoPagamento.Name = "textBoxDataDoPagamento";
            this.textBoxDataDoPagamento.Size = new System.Drawing.Size(193, 27);
            this.textBoxDataDoPagamento.TabIndex = 28;
            // 
            // FormCadastrarDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 343);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDataDoLancamento);
            this.Controls.Add(this.textBoxDataDoPagamento);
            this.Controls.Add(this.textBoxDataDoVencimento);
            this.Controls.Add(this.textBoxAcrescimo);
            this.Controls.Add(this.textBoxDesconto);
            this.Controls.Add(this.textBoxJuros);
            this.Controls.Add(this.textBoxFormaDePagamento);
            this.Controls.Add(this.textBoxValor);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCadastrarDebito";
            this.Text = "FormCadastrarDebito";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastrarDebito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private BindingSource bindingSourceCadastrarDebito;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBoxDataDoLancamento;
        private TextBox textBoxFormaDePagamento;
        private TextBox textBoxValor;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBoxJuros;
        private TextBox textBoxDesconto;
        private TextBox textBoxAcrescimo;
        private TextBox textBoxDataDoVencimento;
        private TextBox textBoxDataDoPagamento;
    }
}