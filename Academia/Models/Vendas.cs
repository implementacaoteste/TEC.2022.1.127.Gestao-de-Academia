using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Models
{
    public class Vendas
    {
        public int Id { get; set; }
        public int FuncionarioId  { get; set; }
        public int ClienteId { get; set; }
        public DateTime Data_Venda { get; set; }
        public double Total_Venda { get; set; }

    }
}
