using DAL;
using Models;

namespace BLL
{
    public class ControleDebitoBLL
    {
        public List<ControleDebito> BuscarTodos()
        {
            return new ControleDebitoDAL().BuscarTodos();
        }
        public ControleDebito BuscarDebitoVencido(string _buscarDebitoVencido)
        {
            if (string.IsNullOrEmpty(_buscarDebitoVencido))
                throw new Exception("Informe uma data!");

            return BuscarDebitoVencido(_buscarDebitoVencido);
        }
        public ControleDebito BuscarDebitoVencido(DateTime _buscarDebitoVencido)
        {
            return new ControleDebitoDAL().BuscarDebitoVencido(_buscarDebitoVencido);
        }
        public ControleDebito BuscarDebitoPago(string _buscarDebitoPago)
        {
            if (string.IsNullOrEmpty(_buscarDebitoPago))
                throw new Exception("Informe uma data!");

            return BuscarDebitoPago(_buscarDebitoPago);
        }
        public ControleDebito BuscarDebitoPago(DateTime _buscarDebitoPago)
        {
            return new ControleDebitoDAL().BuscarDebitoPago(_buscarDebitoPago);
        }
        public ControleDebito BuscarDebitoCorrente(string _buscarDebitoCorrente)
        {
            if (string.IsNullOrEmpty(_buscarDebitoCorrente))
                throw new Exception("Informe uma data!");

            return BuscarDebitoCorrente(Convert.ToDateTime(_buscarDebitoCorrente));
        }
        public ControleDebito BuscarDebitoCorrente(DateTime _buscarDebitoCorrente)
        {
            return new ControleDebitoDAL().BuscarDebitoCorrente(_buscarDebitoCorrente);
        }
        public ControleDebito BuscarPorId(int _id)
        {
            return new ControleDebitoDAL().BuscarPorId(_id);
        }
        public void Excluir(int _id)
        {
            new ControleDebitoDAL().Excluir(_id);
        }
        public void Alterar(ControleDebito _controleDebito)
        {
            new ControleDebitoDAL().Alterar(_controleDebito);
        }
        public void Inserir(ControleDebito _controleDebito)
        {
            new ControleDebitoDAL().Inserir(_controleDebito);
        }
    }
}
