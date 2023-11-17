namespace Models
{
    public class ControleDebito
    {
        public int Id { get; set; }
        public int clienteId { get; set; }
        public double ValorDebito { get; set; }
        public string FormaPagamento { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public double Juros { get; set; }
        public double Desconto { get; set; }
        public double Acrescimo { get; set; }
    }
}
