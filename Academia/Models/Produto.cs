﻿namespace Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
        public string CodigoDeBarras { get; set; }
    }
}
