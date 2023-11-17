using BLL;
using Models;

namespace UIGestaoAcademia
{
    public partial class FormBuscarProduto : Form
    {
        public FormBuscarProduto()
        {
            InitializeComponent();
        }
        private void buttonBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        bindingSourceProduto.DataSource = new ProdutoBLL().BuscarPorNome(textBoxBuscarPor.Text);
                        break;
                    case 1:
                        bindingSourceProduto.DataSource = new ProdutoBLL().BuscarPorCodigoDeBarras(textBoxBuscarPor.Text);
                        break;
                    default:
                        bindingSourceProduto.DataSource = new ProdutoBLL().BuscarTodos();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAlterar_Click_1(object sender, EventArgs e)
        {
            int id = ((Produto)bindingSourceProduto.Current).Id;

            using (FormCadastrarProduto frm = new FormCadastrarProduto(id))
            {
                frm.ShowDialog();
            }
        }
        private void buttonInserir_Click_1(object sender, EventArgs e)
        {
            using (FormCadastrarProduto frm = new FormCadastrarProduto())
            {
                frm.ShowDialog();
            }
        }
        private void buttonExcluir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Produto)bindingSourceProduto.Current).Id;
            new ProdutoBLL().Excluir(id);
            bindingSourceProduto.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }
    }
}
